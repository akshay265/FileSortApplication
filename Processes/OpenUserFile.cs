using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSortApplication
{
    class OpenUserFile
    {
        public static void WindowsExplorerOpen(String path)
        {
            CommandLine(path, $"start {path}");
        }

        private static void CommandLine(String workingDirectory, String Command)
        {
            ProcessStartInfo ProcessInfo;
            Process Process;

            ProcessInfo = new ProcessStartInfo("cmd.exe", "/K " + Command + " && exit");
            ProcessInfo.WorkingDirectory = workingDirectory;
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = true;
            ProcessInfo.WindowStyle = ProcessWindowStyle.Hidden;

            Process = Process.Start(ProcessInfo);
            Process.WaitForExit();
        }
    }
}
