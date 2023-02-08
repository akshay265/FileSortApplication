using FileSortApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSortApplication
{
    public partial class SuccessPage : Form
    {
        bool isSuccessful;
        string operationStr;
        public SuccessPage(bool isSuccessful, string operationStr)
        {
            InitializeComponent();
            
            this.isSuccessful = isSuccessful;
            this.operationStr = operationStr;

            SetControls();
        }

        private void SetControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.BackColor = Color.WhiteSmoke;
            
            if (isSuccessful)
            {
                this.lbl_success.Text = "Changes Successful";
            }
            else
            {
                this.lbl_success.Text = "Changes Unsuccessful";
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(ThreadHomePageForm));
            t.Start();
            this.Close();
            this.Dispose();
        }

        private void ThreadHomePageForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new HomePage());
        }
    }
}
