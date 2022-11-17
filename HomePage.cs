using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileSortApplication.Models;
using FileSortApplication.Processes;

namespace FileSortApplication
{
    public partial class HomePage : Form
    {

        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.BackColor = Color.WhiteSmoke;

            //Top Label Text
            String time = DateTime.Now.ToString("HH:mm:ss");
            int[] timeInts = Array.ConvertAll(time.Split(new char[] { ':' }), int.Parse);
            String msg = "";
            if (timeInts[0] >= 5 && timeInts[0] < 12)
            {
                msg = "Good Morning!";
            } 
            else if (timeInts[0] >= 1 && timeInts[0] <= 5)
            {
                msg = "Good Afternoon!";
            } 
            else if (timeInts[0] >= 7 && timeInts[0] <= 11)
            {
                msg = "Good Evening!";
            } 
            else
            {
                msg = "Welcome!";
            }

            this.lbl_welcome.Text = msg;

            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           // Process.Start("explorer.exe", DefaultAttributes.defaultDir);

            OpenUserFile.WindowsExplorerOpen(DefaultAttributes.defaultDir);

        }
    }
}
