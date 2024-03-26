using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;
using System.Reflection;

namespace AWI_Toolkit.Modules
{
    public class ShellExecutioner
    {
        public void RunShellCommand(string command)
        {
            Process process = new System.Diagnostics.Process();
            ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C " + command;
            process.StartInfo = startInfo;
            process.Start();
        }

        public void InstallFontFile()
        {
            string fontFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) 
                + @"\bin\resources\fonts\sf.ttf";

            File.Copy(fontFile, 
                Path.Combine(GetFolderPath(SpecialFolder.Windows),
                "Fonts", "sf.ttf"));

            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts");
            key.SetValue("SF Pro Text Regular (TrueType)", "sf.ttf");
            key.Close();

        }

    }
}
