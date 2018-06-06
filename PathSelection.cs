using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using USALauncher.Properties;

namespace USALauncher
{
    public partial class PathSelection : Form
    {

        string defaultPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Arma 3";
        string localPath = Environment.GetEnvironmentVariable("localappdata") + "\\Arma 3\\MPMissionsCache";
        bool success = false;

        public PathSelection()
        {
            InitializeComponent();

            Icon = Resources.TaskbarIconWhite;

            Closing += DataWindow_Closing;

            CenterToScreen();

            if (!string.IsNullOrEmpty((string)Settings.Default["armaPath"]))
            {
                fbdSelectPath.SelectedPath = (string)Settings.Default["armaPath"];
                txtPath.Text = (string)Settings.Default["armaPath"];
                return;
            }

            if (Directory.Exists(defaultPath))
            {
                fbdSelectPath.SelectedPath = defaultPath;
                txtPath.Text = defaultPath;
                lblErkannt.Visible = true;
            } else
            {
                fbdSelectPath.SelectedPath = "C:\\";
                lblErkannt.Visible = false;
            }
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            fbdSelectPath.SelectedPath = txtPath.Text;
            DialogResult result = fbdSelectPath.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtPath.Text = fbdSelectPath.SelectedPath;
            }
        }

        private void DataWindow_Closing(object sender, CancelEventArgs e)
        {
            if (!success)
            {
                Application.Exit();
            }
        }

        private bool isValidArmaDirectory(string directory)
        {
            if (!Directory.Exists(localPath))
            {
                Directory.CreateDirectory(localPath);
            }

            if (Directory.Exists(directory))
            {
                if (File.Exists(directory + "\\arma3.exe") && Directory.Exists(localPath))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnWeiter_Click(object sender, EventArgs e)
        {

            if (isValidArmaDirectory(txtPath.Text))
            {
                success = true;
                Settings.Default.armaPath = fbdSelectPath.SelectedPath;
                Settings.Default.Save();
                Settings.Default.Reload();
                Close();
            } else
            {
                MessageBox.Show("Du hast kein valider Pfad ausgewählt, oder hast Arma nicht richtig installiert. Melde dich bei weiteren Problemen im Forum unter http://forum.usa-life.net.", "Pfad nicht gefunden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fbdSelectPath_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
