namespace USALauncher
{
    partial class MainFrame
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.lblPathDescription = new System.Windows.Forms.Label();
            this.lblInstallationPath = new System.Windows.Forms.Label();
            this.btnChangePath = new System.Windows.Forms.Button();
            this.wbChangelog = new System.Windows.Forms.WebBrowser();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblArmaSpieler = new System.Windows.Forms.Label();
            this.tmrUpdateStats = new System.Windows.Forms.Timer(this.components);
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.lblProfil = new System.Windows.Forms.Label();
            this.cbSplash = new System.Windows.Forms.CheckBox();
            this.cbWindow = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudVram = new System.Windows.Forms.NumericUpDown();
            this.txtParams = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProfileDescription = new System.Windows.Forms.Label();
            this.lblprofilePath = new System.Windows.Forms.Label();
            this.btnProfilePath = new System.Windows.Forms.Button();
            this.cbHyper = new System.Windows.Forms.CheckBox();
            this.cbIntro = new System.Windows.Forms.CheckBox();
            this.cbnologs = new System.Windows.Forms.CheckBox();
            this.fbdprofilePath = new System.Windows.Forms.FolderBrowserDialog();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttontexture = new System.Windows.Forms.Button();
            this.cbRadioMod = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxOpacity6 = new USALauncher.PictureBoxOpacity();
            this.pictureBoxOpacity5 = new USALauncher.PictureBoxOpacity();
            this.pictureBoxOpacity2 = new USALauncher.PictureBoxOpacity();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLaunch = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxOpacity4 = new USALauncher.PictureBoxOpacity();
            this.pictureBoxOpacity3 = new USALauncher.PictureBoxOpacity();
            this.pictureBoxOpacity1 = new USALauncher.PictureBoxOpacity();
            this.picLaunch = new USALauncher.PictureBoxOpacity();
            this.picForum = new USALauncher.PictureBoxOpacity();
            this.picHomepage = new USALauncher.PictureBoxOpacity();
            this.picRegeln = new USALauncher.PictureBoxOpacity();
            this.picTeamspeak = new USALauncher.PictureBoxOpacity();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpacity6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpacity5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpacity2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpacity4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpacity3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpacity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLaunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHomepage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegeln)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeamspeak)).BeginInit();
            this.SuspendLayout();
            // 
            // picMinimize
            // 
            this.picMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.picMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMinimize.BackgroundImage")));
            this.picMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picMinimize.Location = new System.Drawing.Point(839, 12);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.picMinimize.Size = new System.Drawing.Size(21, 23);
            this.picMinimize.TabIndex = 1;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(866, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(22, 23);
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picBanner
            // 
            this.picBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.picBanner.Image = ((System.Drawing.Image)(resources.GetObject("picBanner.Image")));
            this.picBanner.Location = new System.Drawing.Point(0, -1);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(901, 60);
            this.picBanner.TabIndex = 3;
            this.picBanner.TabStop = false;
            this.picBanner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBanner_MouseDown);
            // 
            // lblPathDescription
            // 
            this.lblPathDescription.AutoSize = true;
            this.lblPathDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblPathDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathDescription.ForeColor = System.Drawing.Color.White;
            this.lblPathDescription.Location = new System.Drawing.Point(12, 124);
            this.lblPathDescription.Name = "lblPathDescription";
            this.lblPathDescription.Size = new System.Drawing.Size(128, 17);
            this.lblPathDescription.TabIndex = 8;
            this.lblPathDescription.Text = "Arma 3 Installation:";
            // 
            // lblInstallationPath
            // 
            this.lblInstallationPath.AutoSize = true;
            this.lblInstallationPath.BackColor = System.Drawing.Color.Transparent;
            this.lblInstallationPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallationPath.ForeColor = System.Drawing.Color.White;
            this.lblInstallationPath.Location = new System.Drawing.Point(193, 124);
            this.lblInstallationPath.Name = "lblInstallationPath";
            this.lblInstallationPath.Size = new System.Drawing.Size(81, 17);
            this.lblInstallationPath.TabIndex = 9;
            this.lblInstallationPath.Text = "UNKNOWN";
            // 
            // btnChangePath
            // 
            this.btnChangePath.Location = new System.Drawing.Point(751, 121);
            this.btnChangePath.Name = "btnChangePath";
            this.btnChangePath.Size = new System.Drawing.Size(137, 23);
            this.btnChangePath.TabIndex = 10;
            this.btnChangePath.Text = "Pfad ändern";
            this.btnChangePath.UseVisualStyleBackColor = true;
            this.btnChangePath.Click += new System.EventHandler(this.btnChangePath_Click);
            // 
            // wbChangelog
            // 
            this.wbChangelog.Location = new System.Drawing.Point(290, 415);
            this.wbChangelog.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbChangelog.Name = "wbChangelog";
            this.wbChangelog.Size = new System.Drawing.Size(44, 20);
            this.wbChangelog.TabIndex = 11;
            this.wbChangelog.Url = new System.Uri("https://forum.usa-life.net/forum/index.php?board/9-server-updates/", System.UriKind.Absolute);
            this.wbChangelog.Visible = false;
            this.wbChangelog.NewWindow += new System.ComponentModel.CancelEventHandler(this.AdaptChangelog);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(730, 488);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(158, 13);
            this.lblVersion.TabIndex = 12;
            this.lblVersion.Text = "USA.LIFE LAUNCHER v0.0.0.0";
            // 
            // lblArmaSpieler
            // 
            this.lblArmaSpieler.AutoSize = true;
            this.lblArmaSpieler.BackColor = System.Drawing.Color.Transparent;
            this.lblArmaSpieler.Font = new System.Drawing.Font("Arial", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmaSpieler.ForeColor = System.Drawing.Color.White;
            this.lblArmaSpieler.Location = new System.Drawing.Point(566, 353);
            this.lblArmaSpieler.Name = "lblArmaSpieler";
            this.lblArmaSpieler.Size = new System.Drawing.Size(277, 35);
            this.lblArmaSpieler.TabIndex = 13;
            this.lblArmaSpieler.Text = "Spieler Online:    /?";
            // 
            // tmrUpdateStats
            // 
            this.tmrUpdateStats.Interval = 10000;
            this.tmrUpdateStats.Tick += new System.EventHandler(this.updateStats);
            // 
            // cbProfile
            // 
            this.cbProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.cbProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProfile.ForeColor = System.Drawing.SystemColors.Window;
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(196, 193);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(279, 21);
            this.cbProfile.TabIndex = 16;
            this.cbProfile.SelectedIndexChanged += new System.EventHandler(this.cbProfile_SelectedIndexChanged);
            // 
            // lblProfil
            // 
            this.lblProfil.AutoSize = true;
            this.lblProfil.BackColor = System.Drawing.Color.Transparent;
            this.lblProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProfil.ForeColor = System.Drawing.Color.White;
            this.lblProfil.Location = new System.Drawing.Point(12, 194);
            this.lblProfil.Name = "lblProfil";
            this.lblProfil.Size = new System.Drawing.Size(44, 17);
            this.lblProfil.TabIndex = 17;
            this.lblProfil.Text = "Profil:";
            // 
            // cbSplash
            // 
            this.cbSplash.AutoSize = true;
            this.cbSplash.BackColor = System.Drawing.Color.Transparent;
            this.cbSplash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSplash.ForeColor = System.Drawing.Color.White;
            this.cbSplash.Location = new System.Drawing.Point(750, 179);
            this.cbSplash.Name = "cbSplash";
            this.cbSplash.Size = new System.Drawing.Size(151, 20);
            this.cbSplash.TabIndex = 18;
            this.cbSplash.Text = "Splash überspringen";
            this.cbSplash.UseVisualStyleBackColor = false;
            this.cbSplash.CheckedChanged += new System.EventHandler(this.cbSplash_CheckedChanged);
            this.cbSplash.Click += new System.EventHandler(this.cbSplash_Click);
            // 
            // cbWindow
            // 
            this.cbWindow.AutoSize = true;
            this.cbWindow.BackColor = System.Drawing.Color.Transparent;
            this.cbWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWindow.ForeColor = System.Drawing.Color.White;
            this.cbWindow.Location = new System.Drawing.Point(750, 205);
            this.cbWindow.Name = "cbWindow";
            this.cbWindow.Size = new System.Drawing.Size(113, 20);
            this.cbWindow.TabIndex = 19;
            this.cbWindow.Text = "Fenstermodus";
            this.cbWindow.UseVisualStyleBackColor = false;
            this.cbWindow.Click += new System.EventHandler(this.cbWindow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Max. VRAM (MB), 0 default:";
            // 
            // nudVram
            // 
            this.nudVram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.nudVram.ForeColor = System.Drawing.Color.White;
            this.nudVram.Location = new System.Drawing.Point(196, 224);
            this.nudVram.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudVram.Name = "nudVram";
            this.nudVram.Size = new System.Drawing.Size(91, 20);
            this.nudVram.TabIndex = 22;
            this.nudVram.ValueChanged += new System.EventHandler(this.nudVram_ValueChanged);
            // 
            // txtParams
            // 
            this.txtParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.txtParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParams.ForeColor = System.Drawing.SystemColors.Window;
            this.txtParams.Location = new System.Drawing.Point(15, 281);
            this.txtParams.Multiline = true;
            this.txtParams.Name = "txtParams";
            this.txtParams.Size = new System.Drawing.Size(315, 83);
            this.txtParams.TabIndex = 23;
            this.txtParams.TextChanged += new System.EventHandler(this.txtParams_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Andere Parameter (z.B. -cpuCount=<Anzahl Cores>)";
            // 
            // lblProfileDescription
            // 
            this.lblProfileDescription.AutoSize = true;
            this.lblProfileDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblProfileDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileDescription.ForeColor = System.Drawing.Color.White;
            this.lblProfileDescription.Location = new System.Drawing.Point(12, 153);
            this.lblProfileDescription.Name = "lblProfileDescription";
            this.lblProfileDescription.Size = new System.Drawing.Size(121, 17);
            this.lblProfileDescription.TabIndex = 25;
            this.lblProfileDescription.Text = "Arma 3 Profilpfad:";
            // 
            // lblprofilePath
            // 
            this.lblprofilePath.AutoSize = true;
            this.lblprofilePath.BackColor = System.Drawing.Color.Transparent;
            this.lblprofilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprofilePath.ForeColor = System.Drawing.Color.White;
            this.lblprofilePath.Location = new System.Drawing.Point(193, 153);
            this.lblprofilePath.Name = "lblprofilePath";
            this.lblprofilePath.Size = new System.Drawing.Size(106, 17);
            this.lblprofilePath.TabIndex = 27;
            this.lblprofilePath.Text = "- coming soon -";
            // 
            // btnProfilePath
            // 
            this.btnProfilePath.Location = new System.Drawing.Point(751, 150);
            this.btnProfilePath.Name = "btnProfilePath";
            this.btnProfilePath.Size = new System.Drawing.Size(137, 23);
            this.btnProfilePath.TabIndex = 28;
            this.btnProfilePath.Text = "Pfad ändern";
            this.btnProfilePath.UseVisualStyleBackColor = true;
            this.btnProfilePath.Click += new System.EventHandler(this.btnProfilePath_Click);
            // 
            // cbHyper
            // 
            this.cbHyper.AutoSize = true;
            this.cbHyper.BackColor = System.Drawing.Color.Transparent;
            this.cbHyper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHyper.ForeColor = System.Drawing.Color.White;
            this.cbHyper.Location = new System.Drawing.Point(750, 231);
            this.cbHyper.Name = "cbHyper";
            this.cbHyper.Size = new System.Drawing.Size(130, 20);
            this.cbHyper.TabIndex = 29;
            this.cbHyper.Text = "Hyper-Threading";
            this.cbHyper.UseVisualStyleBackColor = false;
            this.cbHyper.CheckedChanged += new System.EventHandler(this.cbHyper_CheckedChanged);
            this.cbHyper.Click += new System.EventHandler(this.cbHyper_Click);
            // 
            // cbIntro
            // 
            this.cbIntro.AutoSize = true;
            this.cbIntro.BackColor = System.Drawing.Color.Transparent;
            this.cbIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIntro.ForeColor = System.Drawing.Color.White;
            this.cbIntro.Location = new System.Drawing.Point(750, 257);
            this.cbIntro.Name = "cbIntro";
            this.cbIntro.Size = new System.Drawing.Size(134, 20);
            this.cbIntro.TabIndex = 30;
            this.cbIntro.Text = "Intro überspringen";
            this.cbIntro.UseVisualStyleBackColor = false;
            this.cbIntro.Click += new System.EventHandler(this.cbIntro_Click);
            // 
            // cbnologs
            // 
            this.cbnologs.AutoSize = true;
            this.cbnologs.BackColor = System.Drawing.Color.Transparent;
            this.cbnologs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnologs.ForeColor = System.Drawing.Color.White;
            this.cbnologs.Location = new System.Drawing.Point(750, 282);
            this.cbnologs.Name = "cbnologs";
            this.cbnologs.Size = new System.Drawing.Size(94, 20);
            this.cbnologs.TabIndex = 31;
            this.cbnologs.Text = "Keine Logs";
            this.cbnologs.UseVisualStyleBackColor = false;
            this.cbnologs.Click += new System.EventHandler(this.cbnologs_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(290, 441);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(44, 21);
            this.axWindowsMediaPlayer1.TabIndex = 33;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "USA-Life Radio by laut.fm";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.trackBar1.Location = new System.Drawing.Point(64, 438);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(153, 28);
            this.trackBar1.TabIndex = 36;
            this.trackBar1.Value = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // buttontexture
            // 
            this.buttontexture.Location = new System.Drawing.Point(290, 386);
            this.buttontexture.Name = "buttontexture";
            this.buttontexture.Size = new System.Drawing.Size(44, 23);
            this.buttontexture.TabIndex = 38;
            this.buttontexture.Text = "Textureupdate";
            this.buttontexture.UseVisualStyleBackColor = true;
            this.buttontexture.Visible = false;
            this.buttontexture.Click += new System.EventHandler(this.buttontexture_Click);
            // 
            // cbRadioMod
            // 
            this.cbRadioMod.AutoSize = true;
            this.cbRadioMod.BackColor = System.Drawing.Color.Transparent;
            this.cbRadioMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRadioMod.ForeColor = System.Drawing.Color.White;
            this.cbRadioMod.Location = new System.Drawing.Point(750, 315);
            this.cbRadioMod.Name = "cbRadioMod";
            this.cbRadioMod.Size = new System.Drawing.Size(15, 14);
            this.cbRadioMod.TabIndex = 39;
            this.cbRadioMod.UseVisualStyleBackColor = false;
            this.cbRadioMod.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(767, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "USA Radio Mod";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(767, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "verwenden?";
            this.label6.Visible = false;
            // 
            // pictureBoxOpacity6
            // 
            this.pictureBoxOpacity6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOpacity6.Image = global::USALauncher.Properties.Resources.facebook_icon;
            this.pictureBoxOpacity6.Location = new System.Drawing.Point(816, 69);
            this.pictureBoxOpacity6.Name = "pictureBoxOpacity6";
            this.pictureBoxOpacity6.Opacity = 1F;
            this.pictureBoxOpacity6.Size = new System.Drawing.Size(33, 33);
            this.pictureBoxOpacity6.TabIndex = 43;
            this.pictureBoxOpacity6.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxOpacity6, "Folge uns auf Facebook!");
            this.pictureBoxOpacity6.Click += new System.EventHandler(this.facebookBtn_Click);
            // 
            // pictureBoxOpacity5
            // 
            this.pictureBoxOpacity5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOpacity5.Image = global::USALauncher.Properties.Resources.steam;
            this.pictureBoxOpacity5.Location = new System.Drawing.Point(855, 69);
            this.pictureBoxOpacity5.Name = "pictureBoxOpacity5";
            this.pictureBoxOpacity5.Opacity = 1F;
            this.pictureBoxOpacity5.Size = new System.Drawing.Size(33, 33);
            this.pictureBoxOpacity5.TabIndex = 42;
            this.pictureBoxOpacity5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxOpacity5, "Folge uns auf Steam!");
            this.pictureBoxOpacity5.Click += new System.EventHandler(this.steamBtn_Click);
            // 
            // pictureBoxOpacity2
            // 
            this.pictureBoxOpacity2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOpacity2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOpacity2.Image")));
            this.pictureBoxOpacity2.Location = new System.Drawing.Point(491, 397);
            this.pictureBoxOpacity2.Name = "pictureBoxOpacity2";
            this.pictureBoxOpacity2.Opacity = 1F;
            this.pictureBoxOpacity2.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxOpacity2.TabIndex = 32;
            this.pictureBoxOpacity2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxOpacity2, "Nach Updates suchen");
            this.pictureBoxOpacity2.Click += new System.EventHandler(this.pictureBoxOpacity2_Click);
            this.pictureBoxOpacity2.MouseEnter += new System.EventHandler(this.MouseHoverEnter);
            this.pictureBoxOpacity2.MouseLeave += new System.EventHandler(this.MouseHoverLeave);
            // 
            // toolTipLaunch
            // 
            this.toolTipLaunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolTipLaunch.ForeColor = System.Drawing.Color.Black;
            // 
            // pictureBoxOpacity4
            // 
            this.pictureBoxOpacity4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxOpacity4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOpacity4.Image")));
            this.pictureBoxOpacity4.Location = new System.Drawing.Point(64, 416);
            this.pictureBoxOpacity4.Name = "pictureBoxOpacity4";
            this.pictureBoxOpacity4.Opacity = 1F;
            this.pictureBoxOpacity4.Size = new System.Drawing.Size(153, 22);
            this.pictureBoxOpacity4.TabIndex = 37;
            this.pictureBoxOpacity4.TabStop = false;
            // 
            // pictureBoxOpacity3
            // 
            this.pictureBoxOpacity3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOpacity3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOpacity3.Image")));
            this.pictureBoxOpacity3.Location = new System.Drawing.Point(15, 416);
            this.pictureBoxOpacity3.Name = "pictureBoxOpacity3";
            this.pictureBoxOpacity3.Opacity = 1F;
            this.pictureBoxOpacity3.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxOpacity3.TabIndex = 35;
            this.pictureBoxOpacity3.TabStop = false;
            this.pictureBoxOpacity3.Click += new System.EventHandler(this.pictureBoxOpacity3_Click);
            this.pictureBoxOpacity3.MouseEnter += new System.EventHandler(this.MouseHoverEnter);
            this.pictureBoxOpacity3.MouseLeave += new System.EventHandler(this.MouseHoverLeave);
            // 
            // pictureBoxOpacity1
            // 
            this.pictureBoxOpacity1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOpacity1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOpacity1.Image")));
            this.pictureBoxOpacity1.Location = new System.Drawing.Point(656, 69);
            this.pictureBoxOpacity1.Name = "pictureBoxOpacity1";
            this.pictureBoxOpacity1.Opacity = 1F;
            this.pictureBoxOpacity1.Size = new System.Drawing.Size(136, 33);
            this.pictureBoxOpacity1.TabIndex = 26;
            this.pictureBoxOpacity1.TabStop = false;
            this.pictureBoxOpacity1.Click += new System.EventHandler(this.serverUpdatesButton_Click);
            this.pictureBoxOpacity1.MouseEnter += new System.EventHandler(this.MouseHoverEnter);
            this.pictureBoxOpacity1.MouseLeave += new System.EventHandler(this.MouseHoverLeave);
            // 
            // picLaunch
            // 
            this.picLaunch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLaunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLaunch.Image = ((System.Drawing.Image)(resources.GetObject("picLaunch.Image")));
            this.picLaunch.Location = new System.Drawing.Point(572, 397);
            this.picLaunch.Margin = new System.Windows.Forms.Padding(0);
            this.picLaunch.Name = "picLaunch";
            this.picLaunch.Opacity = 1F;
            this.picLaunch.Size = new System.Drawing.Size(316, 80);
            this.picLaunch.TabIndex = 15;
            this.picLaunch.TabStop = false;
            this.picLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            this.picLaunch.MouseEnter += new System.EventHandler(this.MouseHoverEnter);
            this.picLaunch.MouseLeave += new System.EventHandler(this.MouseHoverLeave);
            // 
            // picForum
            // 
            this.picForum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picForum.Image = ((System.Drawing.Image)(resources.GetObject("picForum.Image")));
            this.picForum.Location = new System.Drawing.Point(495, 69);
            this.picForum.Name = "picForum";
            this.picForum.Opacity = 1F;
            this.picForum.Size = new System.Drawing.Size(136, 33);
            this.picForum.TabIndex = 7;
            this.picForum.TabStop = false;
            this.picForum.Click += new System.EventHandler(this.picForum_Click);
            this.picForum.MouseEnter += new System.EventHandler(this.MouseHoverEnter);
            this.picForum.MouseLeave += new System.EventHandler(this.MouseHoverLeave);
            // 
            // picHomepage
            // 
            this.picHomepage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHomepage.Image = ((System.Drawing.Image)(resources.GetObject("picHomepage.Image")));
            this.picHomepage.Location = new System.Drawing.Point(334, 69);
            this.picHomepage.Name = "picHomepage";
            this.picHomepage.Opacity = 1F;
            this.picHomepage.Size = new System.Drawing.Size(136, 33);
            this.picHomepage.TabIndex = 6;
            this.picHomepage.TabStop = false;
            this.picHomepage.Click += new System.EventHandler(this.picHomepage_Click);
            this.picHomepage.MouseEnter += new System.EventHandler(this.MouseHoverEnter);
            this.picHomepage.MouseLeave += new System.EventHandler(this.MouseHoverLeave);
            // 
            // picRegeln
            // 
            this.picRegeln.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRegeln.Image = ((System.Drawing.Image)(resources.GetObject("picRegeln.Image")));
            this.picRegeln.Location = new System.Drawing.Point(173, 69);
            this.picRegeln.Name = "picRegeln";
            this.picRegeln.Opacity = 1F;
            this.picRegeln.Size = new System.Drawing.Size(136, 33);
            this.picRegeln.TabIndex = 5;
            this.picRegeln.TabStop = false;
            this.picRegeln.Click += new System.EventHandler(this.picRegeln_Click);
            this.picRegeln.MouseEnter += new System.EventHandler(this.MouseHoverEnter);
            this.picRegeln.MouseLeave += new System.EventHandler(this.MouseHoverLeave);
            // 
            // picTeamspeak
            // 
            this.picTeamspeak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTeamspeak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.picTeamspeak.Image = ((System.Drawing.Image)(resources.GetObject("picTeamspeak.Image")));
            this.picTeamspeak.Location = new System.Drawing.Point(12, 69);
            this.picTeamspeak.Name = "picTeamspeak";
            this.picTeamspeak.Opacity = 1F;
            this.picTeamspeak.Size = new System.Drawing.Size(136, 33);
            this.picTeamspeak.TabIndex = 4;
            this.picTeamspeak.TabStop = false;
            this.picTeamspeak.Click += new System.EventHandler(this.picTeamspeak_Click);
            this.picTeamspeak.MouseEnter += new System.EventHandler(this.MouseHoverEnter);
            this.picTeamspeak.MouseLeave += new System.EventHandler(this.MouseHoverLeave);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxOpacity6);
            this.Controls.Add(this.pictureBoxOpacity5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbRadioMod);
            this.Controls.Add(this.buttontexture);
            this.Controls.Add(this.pictureBoxOpacity4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBoxOpacity3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pictureBoxOpacity2);
            this.Controls.Add(this.cbnologs);
            this.Controls.Add(this.cbIntro);
            this.Controls.Add(this.cbHyper);
            this.Controls.Add(this.btnProfilePath);
            this.Controls.Add(this.lblprofilePath);
            this.Controls.Add(this.pictureBoxOpacity1);
            this.Controls.Add(this.lblProfileDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParams);
            this.Controls.Add(this.nudVram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbWindow);
            this.Controls.Add(this.cbSplash);
            this.Controls.Add(this.lblProfil);
            this.Controls.Add(this.cbProfile);
            this.Controls.Add(this.picLaunch);
            this.Controls.Add(this.lblArmaSpieler);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.wbChangelog);
            this.Controls.Add(this.btnChangePath);
            this.Controls.Add(this.lblInstallationPath);
            this.Controls.Add(this.lblPathDescription);
            this.Controls.Add(this.picForum);
            this.Controls.Add(this.picHomepage);
            this.Controls.Add(this.picRegeln);
            this.Controls.Add(this.picTeamspeak);
            this.Controls.Add(this.picMinimize);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picBanner);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 506);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 506);
            this.Name = "MainFrame";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFrame_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpacity6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpacity5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpacity2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpacity4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpacity3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpacity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLaunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHomepage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegeln)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeamspeak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picBanner;
        private PictureBoxOpacity picTeamspeak;
        private PictureBoxOpacity picRegeln;
        private PictureBoxOpacity picHomepage;
        private PictureBoxOpacity picForum;
        private System.Windows.Forms.Label lblPathDescription;
        private System.Windows.Forms.Label lblInstallationPath;
        private System.Windows.Forms.Button btnChangePath;
        private System.Windows.Forms.WebBrowser wbChangelog;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblArmaSpieler;
        private System.Windows.Forms.Timer tmrUpdateStats;
        private PictureBoxOpacity picLaunch;
        private System.Windows.Forms.ComboBox cbProfile;
        private System.Windows.Forms.Label lblProfil;
        private System.Windows.Forms.CheckBox cbSplash;
        private System.Windows.Forms.CheckBox cbWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudVram;
        private System.Windows.Forms.TextBox txtParams;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProfileDescription;
        private PictureBoxOpacity pictureBoxOpacity1;
        private System.Windows.Forms.Label lblprofilePath;
        private System.Windows.Forms.Button btnProfilePath;
        private System.Windows.Forms.CheckBox cbHyper;
        private System.Windows.Forms.CheckBox cbIntro;
        private System.Windows.Forms.CheckBox cbnologs;
        private System.Windows.Forms.FolderBrowserDialog fbdprofilePath;
        private PictureBoxOpacity pictureBoxOpacity2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label4;
        private PictureBoxOpacity pictureBoxOpacity3;
        private System.Windows.Forms.TrackBar trackBar1;
        private PictureBoxOpacity pictureBoxOpacity4;
        private System.Windows.Forms.Button buttontexture;
        private System.Windows.Forms.CheckBox cbRadioMod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private PictureBoxOpacity pictureBoxOpacity5;
        private PictureBoxOpacity pictureBoxOpacity6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTipLaunch;
    }
}

