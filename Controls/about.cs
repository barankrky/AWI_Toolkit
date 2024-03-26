using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

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

            string changelogURL = @"https://raw.githubusercontent.com/barankrky/AWI_Toolkit/master/changelog.txt";

            try
            {
                WebClient client = new WebClient();
                string reply = client.DownloadString(changelogURL);
                txtChangelog.Text = reply;
            }
            catch (Exception ex)
            {
                txtChangelog.Text = ex.Message;
            }
            

        }
    }
}
