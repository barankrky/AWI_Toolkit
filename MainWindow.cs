using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AWI_Toolkit.Controls;

namespace AWI_Toolkit
{
    public partial class mainWindow : Form
    {

        public mainWindow()
        {
            InitializeComponent();

            about about = new about();
            appContainer.Controls.Add(about);
        }

        private void appMinimize_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; }
        private void appClose_Click(object sender, EventArgs e) { Application.Exit(); }
    }
}
