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

        private System.Windows.Forms.CheckBox checkBox1;
    }
}