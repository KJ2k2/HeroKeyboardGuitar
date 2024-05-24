using AudioAnalyzing;
using HeroKeyboardGuitar.Properties;
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
    private int songDuration;
    private Timer tmrSongDuration;

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
    }

    public void FrmMain_Load(object sender, EventArgs e)
    {
        score = new();
        //streak = new();
        lblScore.Text = score.Amount.ToString();
        label1.Text = score.HighScore.ToString();
        label2.Text = score.Streak.ToString();
        // lblSongLengthInSeconds = songDuration; 
        panBg.BackgroundImage = Game.GetInstance().GetBg();
        panBg.Height = (int)(Height * 0.8);
        curSong = Game.GetInstance().CurSong;
        notes = new();
        //  songDuration = curSong.GetNumberOfSamples() * curSong.Interval;

        //tmrSongDuration = new Timer
        //{
        //    Interval = 1000,
        //    Enabled = true
        //};

        //  tmrSongDuration.Tick += TmrSongDuration_Tick;
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
        tmrWaitThenPlay.Tick += (e, sender) =>
        {
            Game.GetInstance().CurSong.Play();
            tmrWaitThenPlay.Enabled = false;
            tmrPlay.Enabled = true;
        };
        // songLengthInSeconds = curSong.GetNumberOfSamples() / curSong.GetSampleRate();
        // lblSongLength.Text = $"Song Length: {songLengthInSeconds / 60}:{songLengthInSeconds % 60:D2}";
    }

    private void tmrPlay_Tick(object sender, EventArgs e)
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
            // Song has finished playing
            tmrPlay.Enabled = false;
            foreach (var note in notes)
            {
                Controls.Remove(note.Pic);
                note.Dispose();
            }
            // End the program or perform other actions
            EndGame();
        }
    }
    private void EndGame()
    {
        // Save high score or perform other actions
        score.SaveHighScore();

        MessageBox.Show("Congradulations! Your high score is: " + score.HighScore);
        Game.GetInstance().CurSong.Stop();
        Close();
    }

    private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
    {
        foreach (var note in notes)
        {
            if (note.CheckHit(picTarget))
            {
                score.Add(1);

                lblScore.Text = score.Amount.ToString();
                lblScore.Font = new("Arial", 42);
                label1.Text = score.Streak.ToString(); // Update streak label
                if (score.Amount > score.HighScore)
                {
                    label2.Text = score.Amount.ToString(); // Update highscore label if the current score is higher
                }
                break;
            }
        }
    }

    private void FrmMain_KeyDown(object sender, KeyEventArgs e)
    {
        picTarget.BackgroundImage = Resources.pressed;
    }

    private void FrmMain_KeyUp(object sender, KeyEventArgs e)
    {
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

    private void lblScore_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
}
