﻿namespace HeroKeyboardGuitar {
    partial class FrmSongSelect {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new System.Windows.Forms.Label();
            checkBox1 = new System.Windows.Forms.CheckBox();
            checkBox2 = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(0, 622);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(1211, 131);
            label2.TabIndex = 6;
            label2.Text = "HighScore: 0";
            label2.Click += checkBox1_Click;
            // 
            // checkBox1
            // 
            checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            checkBox1.AutoSize = true;
            checkBox1.BackColor = System.Drawing.Color.Lime;
            checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            checkBox1.Location = new System.Drawing.Point(12, 675);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(160, 30);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Colorblind Mode: Off";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.Click += checkBox1_Click;
            // 
            // checkBox2
            // 
            checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            checkBox2.AutoSize = true;
            checkBox2.BackColor = System.Drawing.Color.Lime;
            checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            checkBox2.Location = new System.Drawing.Point(12, 711);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(115, 30);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Difficulty: Easy";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // FrmSongSelect
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(1211, 753);
            Controls.Add(checkBox2);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FrmSongSelect";
            Text = "Select Song";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FrmSongSelect_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}