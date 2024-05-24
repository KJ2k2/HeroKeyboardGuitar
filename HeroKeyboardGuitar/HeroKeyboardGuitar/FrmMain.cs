using AudioAnalyzing;
using HeroKeyboardGuitar.Properties;
using OpenTK.Graphics.ES11;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HeroKeyboardGuitar;

internal partial class FrmMain : Form
{
    private List<Note> notes;
    private const float noteSpeed = 0.5f;
    private Audio curSong;
    private Score score;
    private bool pause;
    private int playback;//Tracks where song paused
    private DateTime startTime;//track button held (cheat prevent)
    // for double buffering
    protected override CreateParams CreateParams
    {
        get
        {
            var cp = base.CreateParams;
            cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
            return cp;
        }
    }

    public FrmMain()
    {
        InitializeComponent();
        pause = false;
        startTime = DateTime.MinValue;
        playback = 0;
    }

    public void FrmMain_Load(object sender, EventArgs e)
    {
        score = new();
        lblScore.Text = score.Amount.ToString();
        panBg.BackgroundImage = Game.GetInstance().GetBg();
        panBg.Height = (int)(Height * 0.8);
        curSong = Game.GetInstance().CurSong;
        notes = new();
        foreach (var actionTime in curSong.ActionTimes)
        {
            double x = actionTime * noteSpeed + picTarget.Left + picTarget.Width;
            const int noteSize = 50;
            if (notes.Any(note => (x - note.Pic.Left) < noteSize / 2))
            {
                continue;
            }
            PictureBox picNote = new()
            {
                BackColor = Color.Black,
                ForeColor = Color.Black,
                Width = noteSize,
                Height = noteSize,
                Top = picTarget.Top + picTarget.Height / 2 - noteSize / 2,
                Left = (int)x,
                BackgroundImage = Resources.marker,
                BackgroundImageLayout = ImageLayout.Stretch,
                Anchor = AnchorStyles.Bottom,
            };
            Controls.Add(picNote);
            notes.Add(new(picNote, x));
        }
        Timer tmrWaitThenPlay = new()
        {
            Interval = 1000,
            Enabled = true,
        };
        components.Add(tmrWaitThenPlay);
        tmrWaitThenPlay.Tick += (e, sender) => {
            Game.GetInstance().CurSong.Play();
            tmrWaitThenPlay.Enabled = false;
            tmrPlay.Enabled = true;
        };
    }

    private void tmrPlay_Tick(object sender, EventArgs e)
    {
        if(!pause)
        {
            int index = curSong.GetPosition();
            foreach (var note in notes)
            {
                note.Move(tmrPlay.Interval * (noteSpeed * 1.3));
                if (note.CheckMiss(picTarget))
                {
                    score.Miss();
                }
            }
            if (index >= curSong.GetNumberOfSamples() - 1)
            {
                tmrPlay.Enabled = false;
                foreach (var note in notes)
                {
                    Controls.Remove(note.Pic);
                    note.Dispose();
                }
            }
        }
    }

    private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
    {

    }
    private void FrmMain_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            PauseGame();
        }
        else if (e.KeyCode == Keys.Q)
        {
            QuitGame();
        }
        else if (pause && e.KeyCode == Keys.ShiftKey)
        {
            PlayGame();
        }
        //Use spacebar to click notes
        else if (!pause && e.KeyCode == Keys.Space && startTime == DateTime.MinValue) // Only handle spacebar for hitting notes
        {
            startTime = DateTime.Now;
            picTarget.BackgroundImage = Resources.pressed;
            foreach (var note in notes)
            {
                if (note.CheckHit(picTarget))
                {
                    score.Add(5);
                    lblScore.Text = score.Amount.ToString();
                    lblScore.Font = new("Arial", 42);
                    break;
                }
            }
        }
        //No other keys are bind
        else
        {
            // Do nothing for all other keys
            return;
        }
    }


    private void FrmMain_KeyUp(object sender, KeyEventArgs e)
    {
        //Anti-Cheat/Bug User can no longer hold down button to "click" notes
        if (e.KeyCode == Keys.Space && startTime != DateTime.MinValue)
        {
            double limit = (DateTime.Now - startTime).TotalSeconds;
            startTime = DateTime.MinValue;
        }
        picTarget.BackgroundImage = Resources._default;
    }

    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        Game.GetInstance().CurSong.Stop();
    }

    private void tmrScoreShrink_Tick(object sender, EventArgs e)
    {
        if (lblScore.Font.Size > 20)
        {
            lblScore.Font = new("Arial", lblScore.Font.Size - 1);
        }
    }
    private void PauseGame()
    {
        pause = true;
        tmrPlay.Enabled = false;
        playback = curSong.GetPosition();
        curSong.Stop();
    }
    private void PlayGame()
    {
        pause = false;
        tmrPlay.Enabled = true;
        //curSong.PlayFromPosition(playback);
        curSong.Play();
    }
    private void QuitGame() { Close();}
    //private void EndGame()
    //{
    //    // Save high score or perform other actions
    //    //score.SaveHighScore();

    //    MessageBox.Show("Congradulations! Your high score is: " + score.HighScore);
    //    Game.GetInstance().CurSong.Stop();
    //    Close();
    //}
}
