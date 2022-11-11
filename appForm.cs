using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSortApplication
{
    public partial class appForm : Form
    {

        public appForm()
        {
            InitializeComponent();
        }

        private void appForm_Load(object sender, EventArgs e)
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

            //TextBox Settings
            this.txtZIP.MaxLength = 5;
            this.txtZIP.Text = "78758";
            this.txtCity.Text = "";
            this.txtCloud.Text = "";
            this.txtFeelLike.Text = "";
            this.txtHighTemp.Text = "";
            this.txtLatitude.Text = "";
            this.txtLongitude.Text = "";
            this.txtLowTemp.Text = "";
            this.txtTemp.Text = "";
            this.txtWind.Text = "";
            this.txtCity.Enabled = false;
            this.txtCloud.Enabled = false;
            this.txtFeelLike.Enabled = false;
            this.txtHighTemp.Enabled = false;
            this.txtLatitude.Enabled = false;
            this.txtLongitude.Enabled = false;
            this.txtLowTemp.Enabled = false;
            this.txtTemp.Enabled = false;
            this.txtWind.Enabled = false;
        }
    }
}
