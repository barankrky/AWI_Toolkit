using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var info = new ProcessStartInfo()
            {
                FileName = @"bin\resources\fonts\FontReg.exe",
                Arguments = "/copy",
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden
            };
            Process.Start(info);
        }

    }
}
