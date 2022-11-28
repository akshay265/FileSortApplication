using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileSortApplication.Models;
using FileSortApplication.Processes;

namespace FileSortApplication
{
    public partial class SettingsPage : Form
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void SettingsPage_Load(object sender, EventArgs e)
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

            //Directory info
            this.txt_currDefault.Text = DefaultAttributes.DefaultDir;

        }


    }
}
