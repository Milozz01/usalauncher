using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using USALauncher.Properties;
using System.Net.NetworkInformation;

namespace USALauncher
{
    
    static class Program
    {
        
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send("usa-life.net", 1000);
                if (reply != null)
                {
                    //Console.WriteLine(reply.ToString());
                }
            }
            catch
            {
                MessageBox.Show("usa-life.net konnte nicht erreicht werden", "Fehler beim Starten",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Console.Read();
            

            // Migrate config
            if (Settings.Default.UpgradeRequired)
            {
                Settings.Default.Upgrade();
                Settings.Default.UpgradeRequired = false;
                Settings.Default.Save();
            }

            // Check for update
            using (var wb = new WebClient())
                {
                try
                {

                    wb.Headers.Add("user-agent", "Only a test!");
                    var response = wb.DownloadString("https://download.usa-life.net/launcherversion.txt");
                    response = response.Replace("&auml;", "ä");
                    response = response.Replace("&ouml;", "ö");
                    response = response.Replace("&uuml;", "ü");
                    response = response.Replace("&Auml;", "Ä");
                    response = response.Replace("&Ouml;", "Ö");
                    response = response.Replace("&Uuml;", "Ü");

                    var newestVersion = response.Split(new string[] { "\n" }, StringSplitOptions.None)[0];
                    var description = response.Split(new string[] { "\n" }, StringSplitOptions.None)[1];
                    var downloadPath = response.Split(new string[] { "\n" }, StringSplitOptions.None)[2];

                    if (newestVersion != Assembly.GetExecutingAssembly().GetName().Version.ToString())
                    {
                        MessageBox.Show(
                            "Es ist eine neue Version des USA.LIFE Launchers verfügbar.\n" +
                            "Aktuell installiert: " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\n" +
                            "Aktuellste Version: " + newestVersion + "\n" +
                            description.Replace("<br>", "\n"),
                            "Neue Version verfügbar!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        if (downloadPath.StartsWith("https://") || downloadPath.StartsWith("http://"))
                        {
                            Process.Start(downloadPath);
                            Environment.Exit(0);
                        }
                    }
                    //  }
                }
                catch
                {
                    MessageBox.Show("Fehler beim Updaten des Launchers (Fehlercode: #2)" + "\n" + "Bitte wende dich an die Administration.", "Fehler beim Starten",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrame());
        }
    }
}
