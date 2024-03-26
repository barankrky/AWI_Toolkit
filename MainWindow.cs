using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AWI_Toolkit.Controls;

namespace AWI_Toolkit
{
    public partial class mainWindow : Form
    {
        Cleanup cleanup = new Cleanup();
        About about = new About();

        #region Draggable Top Bar
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        private void showControl(UserControl control)
        {
            appContainer.Controls.Clear();
            appContainer.Controls.Add(control);
        }


        public mainWindow()
        {
            InitializeComponent();
            showControl(about);
        }

        private void appMinimize_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; }
        private void appClose_Click(object sender, EventArgs e) { Application.Exit(); }
        private void btnCleanup_Click(object sender, EventArgs e) { showControl(cleanup); }
        private void btnAbout_Click(object sender, EventArgs e) { showControl(about); }

        private void appTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
