using ByteSizeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USALauncher.Properties;
using System.IO.Compression;

namespace USALauncher
{
    public partial class Download : Form
    {
        public string Fehlercode4;
        public string Fehlercode5;
        public string Fehlercode6;
        public string Fehlercode7;
        private bool showDownloadSuccess;
        private string localArma;
        private string armaPath;
        //private string downloadPath = "http://usa-life.net/download";
        private string downloadPath = null;
        private string downloadPathTexture = null;
        string Administrationtxt = "Bitte wenden Sie sich an die Administration in unserem Teamspeak3.";
        private string newestVersion;
        private MainFrame parent;

        public Download()
        {

        }
        public Download(string newestVersion, string localArmaPath, string armaPath, MainFrame parent)
        {
            
            localArma = localArmaPath;
            this.newestVersion = newestVersion.Split('/').Last();
            this.armaPath = armaPath;
            this.parent = parent;

            InitializeComponent();

            Icon = Resources.TaskbarIconWhite;

            CenterToScreen();

            lblVersion.Text = this.newestVersion;

            startDownload(newestVersion);


        }
        public void DownloadUpdater(string newestVersion, string localArmaPath, string armaPath, MainFrame parent)
        {

            localArma = localArmaPath;
            this.newestVersion = newestVersion.Split('/').Last();
            this.armaPath = armaPath;
            this.parent = parent;

            InitializeComponent();

            Icon = Resources.TaskbarIconWhite;

            CenterToScreen();

            lblVersion.Text = this.newestVersion;

            startDownloadUpdater(newestVersion);


        }
        public void Downloadtexture(string newestVersion, string localArmaPath, string armaPath, MainFrame parent, bool ShowDownloadSuccess = true)
        {
            this.showDownloadSuccess = ShowDownloadSuccess;
            localArma = localArmaPath;
            this.newestVersion = newestVersion.Split('_').Last();
            this.armaPath = armaPath;
            this.parent = parent;

            InitializeComponent();

            Icon = Resources.TaskbarIconWhite;

            CenterToScreen();

            lblVersion.Text = this.newestVersion;
            if (Directory.Exists(armaPath + @"\@USALifeMod"))
            {
                try
                {
                    Directory.Delete(armaPath + @"\@USALifeMod", true);
                }
                catch (Exception)
                {
                    lblStatus.Text = "FEHLER";
                    MessageBox.Show("Keine Berechtigung beim Updaten der Modfile (Fehlercode: #4)" + "\n" + "Sie müssen ihr Arma3 geschlossen haben, um die Mod vollständig upzudaten." + "\n" +
                    Administrationtxt + "\n" + "(URL:" + downloadPath + "/" + newestVersion + ")", 
                    "Kann die Datei nicht herunterladen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                startDownloadTexture(newestVersion);
            }
            else
            {
                
                startDownloadTexture(newestVersion);
                lblVersion.Text = this.newestVersion;
            }
        }

        private void startDownload(string downloadLink)
        {
            //filename = "test.txt";
            //Retrieve the path from the input textbox
            var filename = downloadLink.Split('/').Last();
            string filepath = localArma + "\\" + filename;
            
            lblStatus.Text = "Starte Download...";
            //Create a WebClient to use as our download proxy for the program.
            WebClient webClient = new WebClient();
            webClient.Headers.Add("user-agent", "Only a test!");
            //Attach the DownloadFileCompleted event to your new AsyncCompletedEventHandler Completed
            //so when the event occurs the method is called.
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);

            //Attach the DownloadProgressChanged event to your DownloadProgressChangedEventHandler ProgressChanged,
            //so again when the event occurs the method is called.
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

            //Attempt to actually download the file, this is where the error that you
            //won't see is probably occurring, this is because it checks the url in 
            //the blocking function internally and won't execute the download itself 
            //until this clears.
            
            webClient.DownloadFileAsync(new Uri(downloadLink), filepath);
        }
        
        private void startDownloadUpdater(string downloadLink)
        {
            var filename = downloadLink.Split('/').Last();
            string filepath = localArma + "\\" + filename;

            lblStatus.Text = "Starte Download...";
            WebClient webClient = new WebClient();
            webClient.Headers.Add("user-agent", "Only a test!");
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedUpdater);

            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

            webClient.DownloadFileAsync(new Uri(downloadLink), filepath);
        }

        private void startDownloadTexture(string downloadLink)
        {
            //filename = "test.txt";
            //Retrieve the path from the input textbox

            var filename = downloadLink.Split('/').Last();
            downloadPathTexture = armaPath + "\\" + filename;

            lblStatus.Text = "Starte Download...";

           
            WebClient webClient = new WebClient();
            webClient.Headers.Add("user-agent", "Only a test!");
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedTexture);
            
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

            webClient.DownloadFileAsync(new Uri(downloadLink), downloadPathTexture);

           
            
        }

        //Method that just increments the progressBar every time the DownloadProgressChangedEvent from webClient fires.
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            pgbDownload.Value = e.ProgressPercentage;
            lblStatus.Text = "Download: " + ByteSize.FromBytes(e.BytesReceived).ToString() + "/" + ByteSize.FromBytes(e.TotalBytesToReceive).ToString();
        }
        
        //This is your method that will pop when the AsyncCompletedEvent is fired,
        //this doesn't mean that the download was successful though which is why
        //it's misleading, it just means that the Async process completed.
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            pgbDownload.Value = 100;
            if (e.Error == null)
            {
                lblStatus.Text = "Download abgeschlossen. Starte ArmA...";
                //Process.Start(armaPath + "\arma3launcher.exe -noLauncher");
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = Path.GetFileName(armaPath + "\\arma3launcher.exe");
                psi.WorkingDirectory = Path.GetDirectoryName(armaPath + "\\arma3launcher.exe");
                psi.Arguments = " -noLauncher -connect=s.usa-life.net -useBE";
                Process.Start(psi);
                parent.disableLaunchButton();
                Close();
            } else
            {
                string filepath = localArma + "\\" + newestVersion;
                try {
                    File.Delete(filepath);
                } catch (Exception)
                {

                }
                lblStatus.Text = "Download fehlgeschlagen.";
                MessageBox.Show("Die Datei konnte nicht geladen werden (Fehlercode: #5)" + "\n" + "Schließe bitte dein Arma3" + "\n" +
                    Administrationtxt + "\n" +
                    "(URL:" + downloadPath + "/" + newestVersion + ")", "Kann die Datei nicht herunterladen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        private void CompletedUpdater(object sender, AsyncCompletedEventArgs e)
        {
            pgbDownload.Value = 100;
            if (e.Error == null)
            {   

                MessageBox.Show("Die Dateien wurden aktualisiert!");
                lblStatus.Text = "Download abgeschlossen";
                Close();
            }
            else
            {
                string filepath = localArma + "\\" + newestVersion;
                try
                {
                    File.Delete(filepath);
                }
                catch (Exception)
                {

                }
                lblStatus.Text = "Download fehlgeschlagen.";
                MessageBox.Show("Die Dateien konnte nicht heruntergeladen werden (Fehlercode: #6)" + "\n" + Administrationtxt + "\n" +
                    "(URL:" + downloadPath + "/" + newestVersion + ")", "Kann die Datei nicht herunterladen :C", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        private void CompletedTexture(object sender, AsyncCompletedEventArgs e)
        {
            pgbDownload.Value = 100;
            if (e.Error == null)
            {
                
                string zipPath = downloadPathTexture;
                string extractPath = armaPath;
                ZipFile.ExtractToDirectory(zipPath, extractPath);

                if (showDownloadSuccess == true) {
                    lblStatus.Text = "Download abgeschlossen";
                    MessageBox.Show("Download abgeschlossen" + "\n" + "\n" + "Der Texturenmod ist auf dem neuesten Stand!");

                    Close();
                }
            }
            else
            {
                downloadPathTexture = localArma + "\\" + newestVersion;
                try
                {
                    File.Delete(downloadPathTexture);
                }
                catch (Exception)
                {

                }
                lblStatus.Text = "Download fehlgeschlagen.";
                MessageBox.Show(Fehlercode7 + 
                    Administrationtxt + "(URL:" + downloadPath + "/" + newestVersion + ")", "Kann die Datei nicht herunterladen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void lblVersion_Click(object sender, EventArgs e)
        {

        }
    }
}
