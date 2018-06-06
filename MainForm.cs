using mshtml;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using USALauncher.Properties;
using System.Text;

namespace USALauncher
{
    public partial class MainFrame : Form
    {
        //properties
        string missionDownloadUri = "https://download.usa-life.net/mission.txt";
        string modDownloadUri = "https://download.usa-life.net/mod.txt";
        //string radioDownloadUri = "https://download.usa-life.net/radio.txt";

        private void Form1_Load(object sender, EventArgs e)
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            AppDomain.CurrentDomain.FirstChanceException += CurrentDomain_FirstChanceException;
        }
        private void CurrentDomain_FirstChanceException(object sender, System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs e)
        {
            WriteDownToLog(DateTime.Now.ToString("HH:mm:ss") + " - First Chance EXC -> " + e.Exception.ToString());
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            WriteDownToLog(DateTime.Now.ToString("HH:mm:ss") + " - Unhandled EXC -> " + e.ExceptionObject.ToString());
        }
        private void WriteDownToLog(string message)
        {
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Logs"))
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "Logs");
            StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Logs\\ErrorLog-" + DateTime.Now.ToString("dd-MM-yyyy"), true);
            sw.WriteLine(message);
            sw.Close();
        }
        public MainFrame()
        {

            InitializeComponent();

            Icon = Resources.TaskbarIconWhite;

            // Center
            CenterToScreen();

            // Version setzen
            lblVersion.Text = "USA.LIFE LAUNCHER v." + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            // Prüfen ob Pfad bereits gesetzt
            armaPath = Settings.Default.armaPath.ToString();
           ///////////////////////////////////////////////7 string profilPathExists = "C:\\Users\"; /////////////////////////////////////////////////////////////////////
            if (string.IsNullOrEmpty(armaPath))
            {
                PathSelection selection = new PathSelection();
                selection.ShowDialog();
            }
            profilePath = Settings.Default.profilePath.ToString();
            if (string.IsNullOrEmpty(profilePath))
            {
               // if (!Directory.Exists(profilPathExists)) ///////////////////////////////
             //   {
                    MessageBox.Show("Bitte wähle deinen Arma3-Profilordner aus." + "\n" + "\n" + "Standartmäßig sollte dieser so aussehen: C:/Users/USERNAME/Documents/Arma3 - Other Profiles");
                    selectProfilePath();
               // }
            }
            lblprofilePath.Text = profilePath;
            armaPath = Settings.Default["armaPath"].ToString();
            localPath = Environment.GetEnvironmentVariable("localappdata") + "\\Arma 3\\MPMissionsCache";
            
            profilePath = Settings.Default.profilePath.ToString();
         //   if (string.IsNullOrEmpty(profilePath))
         //   {
         //       profilePath = Environment.GetEnvironmentVariable("userprofile") + "\\Documents\\Arma 3 - Other Profiles";
         //   }
         //   lblprofilePath.Text = profilePath;

            // Update Profiles
            loadProfiles();

            lblInstallationPath.Text = armaPath;

            // Settings
            cbSplash.Checked = Settings.Default.noSplash;
            cbWindow.Checked = Settings.Default.windowed;
            nudVram.Value = Settings.Default.maxVram;
            txtParams.Text = Settings.Default.customParams;
            cbHyper.Checked = Settings.Default.enableHT;
            cbIntro.Checked = Settings.Default.skipIntro;
            cbnologs.Checked = Settings.Default.noLogs;

            new Thread(() => updateStats(null, null)).Start();
            tmrUpdateStats.Start();

            wbChangelog.DocumentTitleChanged += AdaptChangelog;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public string armaPath;
        public string localPath;
        public string profilePath;

        IPAddress[] addresslist = Dns.GetHostAddresses("s.usa-life.net");
        public ArmA3ServerInfo info = new ArmA3ServerInfo(Dns.GetHostAddresses("s.usa-life.net").FirstOrDefault().ToString(), 2303);
        private System.Threading.Timer timer;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainFrame_MouseDown(object sender, MouseEventArgs e)
        {
            /* if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            } */
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picBanner_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void picLogo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void picTeamspeak_Click(object sender, EventArgs e)
        {
            Process.Start("ts3server://ts.usa-life.net");
        }

        private void picRegeln_Click(object sender, EventArgs e)
        {
            Process.Start("https://usa-life.net/regeln");
        }

        private void picHomepage_Click(object sender, EventArgs e)
        {
            Process.Start("https://usa-life.net/");
        }

        private void picForum_Click(object sender, EventArgs e)
        {
            Process.Start("https://forum.usa-life.net/");
        }

        private void serverUpdatesButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://forum.usa-life.net/forum/index.php?board/9-changelogs/");
        }

        private void steamBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://steamcommunity.com/groups/usaliferpg");
        }

        private void facebookBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/usaliferpg/");
        }

        private void btnChangePath_Click(object sender, EventArgs e)
        {
            PathSelection selection = new PathSelection();
            selection.ShowDialog();

            armaPath = Settings.Default["armaPath"].ToString();

            lblInstallationPath.Text = armaPath;
        }

        private void updateStats(object sender, EventArgs e)
        {
            // Info laden
            info.Update();

            if (info.ServerInfo == null)
            {
                updateStats(null, null);
            }

            this.InvokeEx(f => f.lblArmaSpieler.Text = "Spieler Online: " + info.ServerInfo.NumPlayers + "/" + info.ServerInfo.MaxPlayers);
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            Updaterplaybutton();

            // Get newest Version
            using (var wb = new WebClient())
            {
                
                wb.Headers.Add("user-agent", "Only a test!");
                var response = wb.DownloadString(missionDownloadUri);
                response = response.Split(new string[] { "\n" }, StringSplitOptions.None)[0];

                var filename = response.Split('/').Last();
                var radiopath = armaPath + "\\" + "@USALifeMod";

                //if (Directory.Exists(radiopath) && (cbRadioMod.Checked))
                //{
                //    if (!File.Exists(localPath + "\\" + filename))
                //    {
                //        Download download = new Download(response, localPath, armaPath, this);
                //        //Download download = new Download("test.txt", localPath, armaPath);
                //        download.ShowDialog();
                //    }
                //    else
                //    {

                //        ProcessStartInfo psi = new ProcessStartInfo();
                //        psi.FileName = Path.GetFileName(armaPath + "\\arma3.exe");
                //        psi.WorkingDirectory = Path.GetDirectoryName(armaPath + "\\arma3.exe");
                //        psi.Arguments = " -noLauncher -mod=@USARadio -connect=s.usa-life.net -useBE";
                //        MessageBox.Show("32-Bit wird nun gestartet");
                //        if (Settings.Default.profile != null && Settings.Default.profile != "")
                //        {
                //            UserProfile profile = new UserProfile(Settings.Default.profile);
                //            psi.Arguments += " \"-name=" + profile + "\"";
                //        }
                //        if (cbSplash.Checked)
                //        {
                //            psi.Arguments += " -nosplash";
                //        }
                //        if (cbWindow.Checked)
                //        {
                //            psi.Arguments += " -window";
                //        }
                //        if (cbHyper.Checked)
                //        {
                //            psi.Arguments += " -enableHT";
                //        }
                //        if (cbIntro.Checked)
                //        {
                //            psi.Arguments += " -skipIntro";
                //        }
                //        if (cbnologs.Checked)
                //        {
                //            psi.Arguments += " -noLogs";
                //        }
                //        if (nudVram.Value != 0)
                //        {
                //            psi.Arguments += " -maxVRAM=" + nudVram.Value;
                //        }
                //        if (txtParams.Text.Length != 0)
                //        {
                //            psi.Arguments += " " + txtParams.Text;
                //        }
                //        Process.Start(psi);
                //        disableLaunchButton();
                //    }
                //}

                //else
                //{
                    if (!File.Exists(localPath + "\\" + filename))
                    {
                        Download download = new Download(response, localPath, armaPath, this);
                        //Download download = new Download("test.txt", localPath, armaPath);
                        download.ShowDialog();
                    }
                    else
                    {
                    toolTipLaunch.Show("Arma 3 wird gestartet...", this, Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y, 100000);

                    ProcessStartInfo psi = new ProcessStartInfo();
                        psi.FileName = Path.GetFileName(armaPath + "\\arma3launcher.exe");
                        psi.WorkingDirectory = Path.GetDirectoryName(armaPath + "\\arma3launcher.exe");
                        psi.Arguments = " -noLauncher -connect=s.usa-life.net -useBE -mod=@USALifeMod";
                        if (Settings.Default.profile != null && Settings.Default.profile != "")
                        {
                            UserProfile profile = new UserProfile(Settings.Default.profile);
                            psi.Arguments += " \"-name=" + profile + "\"";
                        }
                        if (cbSplash.Checked)
                        {
                            psi.Arguments += " -nosplash";
                        }
                        if (cbWindow.Checked)
                        {
                            psi.Arguments += " -window";
                        }
                        if (cbHyper.Checked)
                        {
                            psi.Arguments += " -enableHT";
                        }
                        if (cbIntro.Checked)
                        {
                            psi.Arguments += " -skipIntro";
                        }
                        if (cbnologs.Checked)
                        {
                            psi.Arguments += " -noLogs";
                        }
                        if (nudVram.Value != 0)
                        {
                            psi.Arguments += " -maxVRAM=" + nudVram.Value;
                        }
                        if (txtParams.Text.Length != 0)
                        {
                            psi.Arguments += " " + txtParams.Text;
                        }
                        Process.Start(psi);
                        disableLaunchButton();
                    }

                
            }
        }


        public void disableLaunchButton()
        {
            this.InvokeEx(f => f.picLaunch.Enabled = false);
            this.InvokeEx(f => f.picLaunch.Text = "Starte ArmA...");
            timer = new System.Threading.Timer((obj) =>
            {
                this.InvokeEx(f => f.picLaunch.Enabled = true);
                this.InvokeEx(f => f.picLaunch.Text = "USA.LIFE Spielen");
                timer.Dispose();
            },
            null, 10000, Timeout.Infinite);
        }

        private void MouseHoverEnter(object sender, EventArgs e)
        {
            PictureBoxOpacity pic = (PictureBoxOpacity)sender;
            pic.Opacity = 0.9F;
        }

        private void MouseHoverLeave(object sender, EventArgs e)
        {
            PictureBoxOpacity pic = (PictureBoxOpacity)sender;
            pic.Opacity = 1F;
        }

        private void AdaptChangelog(object sender, EventArgs e)
        {
            IHTMLDocument2 doc = (wbChangelog.Document.DomDocument) as IHTMLDocument2;
            // The first parameter is the url, the second is the index of the added style sheet.
            IHTMLStyleSheet ss = doc.createStyleSheet("", 0);

            // Now that you have the style sheet you have a few options:
            // 1. You can just set the content as text.
            ss.cssText = @"#pageHeaderContainer { display: none; } .cookiePolicyNotice { display: none; } .toTop { display: none !important; } #main { padding-top: 10px !important; } .articleList > li:not(:first-child) { margin-top: 20px !important; } #content > .section { margin-top: 10px; }";

            HtmlElement head = wbChangelog.Document.GetElementsByTagName("head")[0];
            HtmlElement scriptEl = wbChangelog.Document.CreateElement("script");
            IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;
            element.text = @"function check() { if (typeof $ === 'undefined' || window.ada) { return; } $(document).ready(function() { if($('.contentTitle').text() !== 'Artikel') { $('.contentTitle').prepend('<a onclick=\'window.history.back();\'><<</a> '); window.ada = true; } }); }";
            head.AppendChild(scriptEl);
            wbChangelog.Document.InvokeScript("check");
        }

        private void cbProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.profile = ((UserProfile)cbProfile.SelectedItem).path;
            Settings.Default.Save();
            Settings.Default.Reload();
        }

        private void cbSplash_Click(object sender, EventArgs e)
        {
            Settings.Default.noSplash = ((CheckBox)sender).Checked;
            Settings.Default.Save();
            Settings.Default.Reload();
        }

        private void cbWindow_Click(object sender, EventArgs e)
        {
            Settings.Default.windowed = ((CheckBox)sender).Checked;
            Settings.Default.Save();
            Settings.Default.Reload();
        }

        private void cbHyper_Click(object sender, EventArgs e)
        {
            Settings.Default.enableHT = ((CheckBox)sender).Checked;
            Settings.Default.Save();
            Settings.Default.Reload();
        }

        private void cbIntro_Click(object sender, EventArgs e)
        {
            Settings.Default.skipIntro = ((CheckBox)sender).Checked;
            Settings.Default.Save();
            Settings.Default.Reload();
        }

        private void cbnologs_Click(object sender, EventArgs e)
        {
            Settings.Default.noLogs = ((CheckBox)sender).Checked;
            Settings.Default.Save();
            Settings.Default.Reload();
        }

        private void nudVram_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.maxVram = Convert.ToInt32(((NumericUpDown)sender).Value);
            Settings.Default.Save();
            Settings.Default.Reload();
        }

        private void txtParams_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.customParams = ((TextBox)sender).Text;
            Settings.Default.Save();
            Settings.Default.Reload();
        }

        private void selectProfilePath()
        {
            fbdprofilePath.SelectedPath = lblprofilePath.Text;
            DialogResult result = fbdprofilePath.ShowDialog();

            if (result == DialogResult.OK)
            {
                lblprofilePath.Text = fbdprofilePath.SelectedPath;
                loadProfiles();
                Settings.Default.profilePath = fbdprofilePath.SelectedPath;
                Settings.Default.Save();
                Settings.Default.Reload();
            }
        }
        private void btnProfilePath_Click(object sender, EventArgs e)
        {
            selectProfilePath();
        }

        private void loadProfiles()
        {
            cbProfile.Items.Clear();
            // Update Profiles
            foreach (string dir in Directory.GetDirectories(lblprofilePath.Text))
            {
                UserProfile profile = new UserProfile(dir);
                cbProfile.Items.Add(profile);

                if (Settings.Default.profile != null && Settings.Default.profile == dir)
                {
                    cbProfile.SelectedItem = profile;
                }
            }
        }
        private void pictureBoxOpacity2_Click(object sender2, EventArgs e2)
        {
            Updater();
        }
        private void Updater()
        {
            Download downloadUpdater = new Download();
            // Get newest Version
            using (var wb = new WebClient())
            {
                wb.Headers.Add("user-agent", "Only a test!");
                var response = wb.DownloadString(missionDownloadUri);
                response = response.Split(new string[] { "\n" }, StringSplitOptions.None)[0];
                //var response = "mission.txt";
                var filename = response.Split('/').Last();

                if (File.Exists(localPath + "\\" + filename))
                {
                    /*
                    if (filename != localPath + "\\" + filename)
                    {
                        if (!File.Exists(armaPath + "\\" + filename))
                        {

                            downloadUpdater.DownloadUpdater(response, localPath, armaPath, this);
                            //Download download = new Download("test.txt", localPath, armaPath);
                            downloadUpdater.ShowDialog();
                        }

                    }
                    else
                    {
                    */MessageBox.Show("Die Missionsdatei ist auf dem aktuellsten Stand!");
                    
                }
                else
                {
                    downloadUpdater.DownloadUpdater(response, localPath, armaPath, this);
                    downloadUpdater.ShowDialog();
                }

            }
            Download downloadtexture = new Download();
            // Get newest Version
            using (var wb = new WebClient())
            {
                wb.Headers.Add("user-agent", "Only a test!");
                var response = wb.DownloadString(modDownloadUri);
                response = response.Split(new string[] { "\n" }, StringSplitOptions.None)[0];
                //var response = "mission.txt";
                var filename = response.Split('_').Last();
                String Versionnumber = filename.Split('.')[0] + "." + filename.Split('.')[1] + "." + filename.Split('.')[2] + "." + filename.Split('.')[3];
                String modpathVersion = armaPath + @"\@USALifeMod\version.txt";

                String localVersionNumber;
                if (File.Exists(modpathVersion))
                {
                    using (StreamReader sr = File.OpenText(modpathVersion))

                        localVersionNumber = sr.ReadLine();

                    // MessageBox.Show(localVersionNumber + " " + Versionnumber);
                    if (Versionnumber != localVersionNumber)
                    {
                        if (!File.Exists(armaPath + "\\" + filename))
                        {

                            downloadtexture.Downloadtexture(response, localPath, armaPath, this);
                            //Download download = new Download("test.txt", localPath, armaPath);
                            downloadtexture.ShowDialog();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Der Texturenmod ist auf dem neuesten Stand!");
                    }
                }
                else
                {
                    downloadtexture.Downloadtexture(response, localPath, armaPath, this);
                    downloadtexture.ShowDialog();
                }

            }
        }

        private void Updaterplaybutton()
        {

            Download downloadUpdater = new Download();
            // Get newest Version
            using (var wb = new WebClient())
            {
                wb.Headers.Add("user-agent", "Only a test!");
                var response = wb.DownloadString(missionDownloadUri);
                response = response.Split(new string[] { "\n" }, StringSplitOptions.None)[0];
                var filename = response.Split('/').Last();

                if (File.Exists(localPath + "\\" + filename))
                {
                    /*
                    if (filename != localPath + "\\" + filename)
                    {
                        if (!File.Exists(armaPath + "\\" + filename))
                        {
                            downloadUpdater.DownloadUpdater(response, localPath, armaPath, this);
                            //Download download = new Download("test.txt", localPath, armaPath);
                            downloadUpdater.ShowDialog();
                        }
                    }
                    else
                    {
                    //MessageBox.Show("Die Missionsdatei ist auf dem aktuellsten Stand!");
                    {*/
                }
                else
                {
                    downloadUpdater.DownloadUpdater(response, localPath, armaPath, this);
                    downloadUpdater.ShowDialog();

                }

            }
            Download downloadtexture = new Download();
            // Get newest Version
            using (var wb = new WebClient())
            {
                wb.Headers.Add("user-agent", "Only a test!");

                var response = wb.DownloadString(modDownloadUri);
                response = response.Split(new string[] { "\n" }, StringSplitOptions.None)[0];

                var filename = response.Split('_').Last();
                String Versionnumber = filename.Split('.')[0] + "." + filename.Split('.')[1] + "." + filename.Split('.')[2] + "." + filename.Split('.')[3];
                String modpathVersion = armaPath + @"\@USALifeMod\version.txt";

                String localVersionNumber;
                if (File.Exists(modpathVersion))
                {
                    using (StreamReader sr = File.OpenText(modpathVersion))

                        localVersionNumber = sr.ReadLine();

                    // MessageBox.Show(localVersionNumber + " " + Versionnumber);
                    if (Versionnumber != localVersionNumber)
                    {
                        if (!File.Exists(armaPath + "\\" + filename))
                        {

                            downloadtexture.Downloadtexture(response, localPath, armaPath, this, false);
                            //Download download = new Download("test.txt", localPath, armaPath);
                            downloadtexture.ShowDialog();
                        }

                    }
                    else
                    {
                        //MessageBox.Show("Der Texturenmod ist auf dem neuesten Stand!");
                    }
                }
                else
                {
                    downloadtexture.Downloadtexture(response, localPath, armaPath, this);
                    downloadtexture.ShowDialog();

                }

            }
        }

        private void AdaptChangelog(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
        }
        //Radioplayer
        bool getclick = false;

        private void pictureBoxOpacity3_Click(object sender, EventArgs e)
        {

            if (getclick == false)
            {
                axWindowsMediaPlayer1.URL = ("http://stream.laut.fm/usaliferpg");
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pictureBoxOpacity3.Image = Resources.stopbuttonsmall;
                pictureBoxOpacity4.Image = Resources.playingtext;
                getclick = true;
            }
            else if (getclick == true)
            {
                pictureBoxOpacity3.Image = Resources.playbuttonsmall;
                pictureBoxOpacity4.Image = Resources.overlayradio;
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                getclick = false;
            }
        }
        private void cbHyper_CheckedChanged (object sender, EventArgs e)
        {
        }
        private void cbSplash_CheckedChanged (object sender, EventArgs e)
        {
            
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        private void buttontexture_Click(object sender, EventArgs e)
        {
            Download downloadtexture = new Download();
            // Get newest Version
            using (var wb = new WebClient())
            {
                wb.Headers.Add("user-agent", "Only a test!");
                var response = wb.DownloadString(modDownloadUri);
                //var response = "mission.txt";
                var filename = response.Split('_').Last();
                String Versionnumber = filename.Split('.')[0] + "." + filename.Split('.')[1] + "." + filename.Split('.')[2] + "." + filename.Split('.')[3];
                String modpathVersion = armaPath + @"\@USALifeMod\version.txt";

                String localVersionNumber;
                if (File.Exists(modpathVersion))
                {
                    using (StreamReader sr = File.OpenText(modpathVersion))

                        localVersionNumber = sr.ReadLine();

                    // MessageBox.Show(localVersionNumber + " " + Versionnumber);
                    if (Versionnumber != localVersionNumber)
                    {
                        if (!File.Exists(armaPath + "\\" + filename))
                        {

                            downloadtexture.Downloadtexture(response, localPath, armaPath, this);
                            //Download download = new Download("test.txt", localPath, armaPath);
                            downloadtexture.ShowDialog();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Du hast bereits die neueste Version!");
                    }
                }
                else
                {
                    downloadtexture.Downloadtexture(response, localPath, armaPath, this);
                }
            }
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {

        }
    }
}
