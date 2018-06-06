namespace USALauncher
{
    partial class PathSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PathSelection));
            this.lblPathText = new System.Windows.Forms.Label();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.fbdSelectPath = new System.Windows.Forms.FolderBrowserDialog();
            this.btnWeiter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblErkannt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPathText
            // 
            this.lblPathText.AutoSize = true;
            this.lblPathText.Location = new System.Drawing.Point(9, 207);
            this.lblPathText.Name = "lblPathText";
            this.lblPathText.Size = new System.Drawing.Size(266, 39);
            this.lblPathText.TabIndex = 0;
            this.lblPathText.Text = "Hallo! Schön das du den USA-LIFE Launcher benutzt. \r\nDu hilfst uns damit, den Ser" +
    "ver zu schonen.\r\nWähle bitte dein Arma3-Installationsverzeichnis aus.\r\n";
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(284, 275);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(28, 20);
            this.btnSelectPath.TabIndex = 1;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 275);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(266, 20);
            this.txtPath.TabIndex = 2;
            // 
            // fbdSelectPath
            // 
            this.fbdSelectPath.HelpRequest += new System.EventHandler(this.fbdSelectPath_HelpRequest);
            // 
            // btnWeiter
            // 
            this.btnWeiter.Location = new System.Drawing.Point(237, 301);
            this.btnWeiter.Name = "btnWeiter";
            this.btnWeiter.Size = new System.Drawing.Size(75, 23);
            this.btnWeiter.TabIndex = 3;
            this.btnWeiter.Text = "Speichern";
            this.btnWeiter.UseVisualStyleBackColor = true;
            this.btnWeiter.Click += new System.EventHandler(this.btnWeiter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(26, -31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 268);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblErkannt
            // 
            this.lblErkannt.AutoSize = true;
            this.lblErkannt.ForeColor = System.Drawing.Color.Green;
            this.lblErkannt.Location = new System.Drawing.Point(9, 259);
            this.lblErkannt.Name = "lblErkannt";
            this.lblErkannt.Size = new System.Drawing.Size(178, 13);
            this.lblErkannt.TabIndex = 5;
            this.lblErkannt.Text = "Arma3 Standardverzeichnis erkannt.";
            // 
            // PathSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 339);
            this.ControlBox = false;
            this.Controls.Add(this.lblErkannt);
            this.Controls.Add(this.btnWeiter);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.lblPathText);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PathSelection";
            this.Text = "USA-LIFE Launcher - Pfad wählen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPathText;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.FolderBrowserDialog fbdSelectPath;
        private System.Windows.Forms.Button btnWeiter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblErkannt;
    }
}