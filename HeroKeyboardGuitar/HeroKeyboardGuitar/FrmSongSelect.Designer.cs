namespace HeroKeyboardGuitar {
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
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(0, 664);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(1211, 89);
            label2.TabIndex = 6;
            label2.Text = "HighScore: 0";
            label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            label2.Click += lblScore_Click;
            checkBox1 = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            checkBox1.AutoSize = true;
            checkBox1.BackColor = System.Drawing.Color.Lime;
            checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            checkBox1.Location = new System.Drawing.Point(12, 711);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(132, 30);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Colorblind Mode";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.Click += checkBox1_Click;
            // 
            // FrmSongSelect
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(1211, 753);
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
    }
}