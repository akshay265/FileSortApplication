using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileSortApplication.Models;

namespace FileSortApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread t = new Thread(new ThreadStart(ThreadHomePage));
            ThreadScheduler.AddThread(t, 0);
            //ThreadScheduler.StartThread(0);
        }

        private static void ThreadHomePage()
        {
            Application.Run(new HomePage());
        }
    }
}
