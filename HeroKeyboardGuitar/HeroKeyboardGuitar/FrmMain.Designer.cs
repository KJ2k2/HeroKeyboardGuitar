namespace HeroKeyboardGuitar
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tmrPlay = new System.Windows.Forms.Timer(components);
            picTarget = new System.Windows.Forms.PictureBox();
            lblScore = new System.Windows.Forms.Label();
            tmrScoreShrink = new System.Windows.Forms.Timer(components);
            panBg = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)picTarget).BeginInit();
            panBg.SuspendLayout();
            SuspendLayout();
            //
            // tmrPlay
            //
            tmrPlay.Interval = 50;
            tmrPlay.Tick += tmrPlay_Tick;
            //
            // picTarget
            //
            picTarget.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            picTarget.BackgroundImage = Properties.Resources._default;
            picTarget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            picTarget.Location = new System.Drawing.Point(372, 498);
            picTarget.Name = "picTarget";
            picTarget.Size = new System.Drawing.Size(120, 120);
            picTarget.TabIndex = 3;
            picTarget.TabStop = false;
            //
            // lblScore
            //
            lblScore.BackColor = System.Drawing.Color.Transparent;
            lblScore.Dock = System.Windows.Forms.DockStyle.Bottom;
            lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblScore.ForeColor = System.Drawing.Color.White;
            lblScore.Location = new System.Drawing.Point(0, 391);
            lblScore.Name = "lblScore";
            lblScore.Size = new System.Drawing.Size(1237, 89);
            lblScore.TabIndex = 5;
            lblScore.Text = "0";
            lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            ////lblHighScore
            //lblHighScore.BackColor = System.Drawing.Color.Transparent;
            //lblHighScore.Dock = System.Windows.Forms.DockStyle.Bottom;
            //lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            //lblHighScore.ForeColor = System.Drawing.Color.White;
            //lblHighScore.Location = new System.Drawing.Point(10, 10);
            //lblHighScore.Name = "lblHighScore";
            //lblHighScore.Size = new System.Drawing.Size(1237, 89);
            //lblHighScore.TabIndex = 5;
            //lblHighScore.Text = "0";
            //lblHighScore.TextAlign = System.Drawing.ContentAlignment.TopLeft;


            ////Streak

            //lblStreak.BackColor = System.Drawing.Color.Transparent;
            //lblStreak.Dock = System.Windows.Forms.DockStyle.Bottom;
            //lblStreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            //lblStreak.ForeColor = System.Drawing.Color.White;
            //lblStreak.Location = new System.Drawing.Point(this.Width - lblStreak.Width - 10, 10);
            //lblStreak.Name = "lblStreak";
            //lblStreak.Size = new System.Drawing.Size(1237, 89);
            //lblStreak.TabIndex = 5;
            //lblStreak.Text = "0";
            //lblStreak.TextAlign = System.Drawing.ContentAlignment.TopRight;

            //
            // tmrScoreShrink
            //
            tmrScoreShrink.Enabled = true;
            tmrScoreShrink.Tick += tmrScoreShrink_Tick;
            //
            // panBg
            //
            panBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panBg.Controls.Add(lblScore);
            panBg.Dock = System.Windows.Forms.DockStyle.Top;
            panBg.Location = new System.Drawing.Point(0, 0);
            panBg.Name = "panBg";
            panBg.Size = new System.Drawing.Size(1237, 480);
            panBg.TabIndex = 6;
            //
            // FrmMain
            //
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1237, 644);
            Controls.Add(panBg);
            Controls.Add(picTarget);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "FrmMain";
            Text = "Play Song";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            KeyDown += FrmMain_KeyDown;
            KeyPress += FrmMain_KeyPress;
            KeyUp += FrmMain_KeyUp;
            ((System.ComponentModel.ISupportInitialize)picTarget).EndInit();
            panBg.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer tmrPlay;
        private System.Windows.Forms.PictureBox picTarget;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblStreak;
        private System.Windows.Forms.Label lblSongLengthInSeconds;
        private System.Windows.Forms.Timer tmrScoreShrink;
        private System.Windows.Forms.Panel panBg;
    }
}