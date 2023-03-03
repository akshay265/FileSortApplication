using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSortApplication.Models
{
    public static class ThreadScheduler
    {
        private static Thread[] thrdLs = new Thread[3];

        //public ThreadScheduler() { }
        
        [STAThread]
        public static void AddThread(Thread t, int i)
        {
            if (thrdLs[i] != null)
            {
                AbortThread(i);
            }

            thrdLs[i] = t;

            StartThread(i);
            //MessageBox.Show("Thread added at " + i);
        }

        [STAThread]
        public static void StartThread(int i)
        {
            thrdLs[i].Start();
            thrdLs[i].Join();
            //MessageBox.Show("Thread started at " + i);

        }

        [STAThread]
        public static void AbortThread(int i)
        {
            thrdLs[i].Abort();
            //MessageBox.Show("Thread aborted at " + i);

        }


    }
}
