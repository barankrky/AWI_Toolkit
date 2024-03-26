using AWI_Toolkit.Modules;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWI_Toolkit
{
    public  partial class SplashScreen : Form
    {
        ShellExecutioner executer = new ShellExecutioner();

        private async void setStatus(string statusText, int waitTime = 5) { 
            statusLabel.Text = statusText;
            await Task.Delay(waitTime * 100);
        }

        private void startMainWindow()
        {
            Hide();
            mainWindow main = new mainWindow();
            main.Show();
        }

        public bool IsFontInstalled(string ContentFontName)
        {
            return File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), ContentFontName.ToUpper()));
        }

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void checkFontFile()
        {
            // Check the font file is installed.

            if (IsFontInstalled("sf.ttf"))
            {
                setStatus("Font already installed.");
            }
            else
            {
                setStatus("Font not found. Attempting to install...");
                executer.InstallFontFile();
                setStatus("Font installed. Restarting application...", 15);
                Application.Restart();
                Environment.Exit(0);
            }

        }
        private void checkChangelog()
        {
            // Get latest changelog from github and save to disk.

            setStatus("Getting latest changelog from github.com");

            string appdataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) + @"\barankrky\awi_toolkit";

            if (Directory.Exists(appdataPath))
            {
                // Directory exists.
            }
            else
            {
                Directory.CreateDirectory(appdataPath);
            }
            string changelogFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) + @"\barankrky\awi_toolkit\changelog.txt";

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string changelogURL = @"https://raw.githubusercontent.com/barankrky/AWI_Toolkit/master/changelog.txt";

            try
            {
                WebClient client = new WebClient();
                string reply = client.DownloadString(changelogURL);
                File.WriteAllText(changelogFile, reply);
            }
            catch (Exception ex)
            {
                setStatus(ex.Message);
            }
        }

        private async void SplashScreen_Load(object sender, EventArgs e)
        {
            setStatus("Loading..."); 
            await Task.Delay(1000);
            setStatus("Initializing...");
            await Task.Delay(500);
            setStatus("Checking resources...");
            await Task.Delay(500);
            checkFontFile();
            await Task.Delay(500);
            checkChangelog();
            await Task.Delay(500);
            setStatus("Loading...");
            await Task.Delay(1500);
            startMainWindow();
        }
    }
}
