using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace AWI_Toolkit.Controls
{
    public partial class About : UserControl
    {

        public About()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            InitializeComponent();
            String appName = AWI_Toolkit.Properties.Resources.appName;
            String appAuthor = AWI_Toolkit.Properties.Resources.appAuthor;
            String appVersion = AWI_Toolkit.Properties.Resources.appVersion;

            label1.Text = appName;
            label2.Text = appVersion + " by " + appAuthor;

            string changelogFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) + @"\barankrky\awi_toolkit\changelog.txt";

            try
            {
                txtChangelog.Text = File.ReadAllText(changelogFile);
            }
            catch (Exception ex)
            {
                txtChangelog.Text = ex.Message;
            }
            

        }
    }
}
