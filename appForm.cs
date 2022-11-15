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
            this.BackColor = Color.Fuchsia;

            //TextBox Settings
            String time = DateTime.Now.ToString("HH:mm:ss");
            int[] timeInts = Array.ConvertAll(time.Split(new char[] { ':' }), int.Parse);
            String msg = "";
            if (timeInts[0] >= 5 && timeInts[0] < 12)
            {
                msg = "Good Morning!";
            } else if (timeInts[0] > 12 && timeInts[0] < )
            {
                msg = "Good Afternoon!";
            } else if ()

            this.lbl_welcome.Text = msg;
        }
    }
}
