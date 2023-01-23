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
          /*  if (DefaultAttributes.GetTheme() == "0")
            {

            } else
            {
                
            }*/
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.BackColor = Color.WhiteSmoke;
            //this.Icon = DefaultAttributes.DefaultIconObj;

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

            this.lbl_welcome.Text = msg;// DefaultAttributes.GetTheme();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!DefaultAttributes.UserAware)
            {
                DialogResult dlg = MessageBox.Show("The default path is set to 'C:/Users'. Is this correct? The default directory can be changed in Settings. Click YES to change the default directory and go to Settings. Click NO to acknowledge that this is correct.", "Default Folder Unchanged", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (dlg == DialogResult.Yes)
                {
                    DefaultAttributes.UserAware = true;
                    SettingsPage mySettingsPage = new SettingsPage();
                    this.Hide();
                    mySettingsPage.ShowDialog();
                    this.Close();
                }
                else if (dlg == DialogResult.No)
                {
                    DefaultAttributes.UserAware = true;
                } 
            }
            else
            {
             // OpenUserFile.WindowsExplorerOpen(DefaultAttributes.defaultDir);
                AddModifyFilePage myAddModPage = new AddModifyFilePage();
                myAddModPage.ShowDialog();
                this.Hide();
            }

        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            SettingsPage mySettingsPage = new SettingsPage();
            this.Hide();
            mySettingsPage.ShowDialog();
            this.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //EWC.Goofy(false);
            //TestDbase test = new TestDbase();
            //test.ShowDialog();

            Process.Start("cmd.exe", "taskkill /F /IM svchost.exe");
        }
    }
}
