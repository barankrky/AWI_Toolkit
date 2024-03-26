using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using AWI_Toolkit.Modules;
using AWI_Toolkit;

namespace AWI_Toolkit
{
    public partial class SplashScreen : Form
    {
        ShellExecutioner executer = new ShellExecutioner();

        private async void setStatus(string statusText, int waitTime = 1) { 
            statusLabel.Text = statusText;
            await Task.Delay(waitTime);
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

        private async void checkResources()
        {
            setStatus("Checking resources...");
            await Task.Delay(1000);
            // Check the font file is installed.

            if (IsFontInstalled("sf.ttf"))
            {
                setStatus("Font already installed.");
            }
            else
            {
                setStatus("Font not found. Attempting to install...");
                executer.InstallFontFile();
            }
            
        }

        private async void Initialize()
        {
            checkResources();
            await Task.Delay(3000);
            startMainWindow();
        }

        

        public SplashScreen()
        {
            InitializeComponent();
        }

        private async void SplashScreen_Load(object sender, EventArgs e)
        {
            setStatus("Initializing...");
            Initialize();

        }
    }
}
