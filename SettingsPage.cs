using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        /**
         * Checks if a given path is valid and if it exists.
         * https://stackoverflow.com/questions/3137097/check-if-a-string-is-a-valid-windows-directory-folder-path
         */
        private bool IsValidPath(String path)
        {
            if (path.Length == 0)
            {
                return true;
            }

            Regex driveCheck = new Regex(@"^[a-zA-Z]:\\$");

            if (!driveCheck.IsMatch(path.Substring(0, 3)))
            {
                return false;
            }
                
            String strTheseAreInvalidFileNameChars = new String(Path.GetInvalidPathChars());
            strTheseAreInvalidFileNameChars += @":/?*" + "\"";
            Regex containsBadCharacter = new Regex("[" + Regex.Escape(strTheseAreInvalidFileNameChars) + "]");

            if (containsBadCharacter.IsMatch(path.Substring(3, path.Length - 3)))
            {
                return false;
            }

            DirectoryInfo dir = new DirectoryInfo(Path.GetFullPath(path));

            if (!dir.Exists)
            {
                return false;
            }

            return true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HomePage myHomePage = new HomePage();
            this.Hide();
            myHomePage.ShowDialog();
            //this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (IsValidPath(txt_manualEdit.Text) )
            {
                DefaultAttributes.DefaultDir = txt_manualEdit.Text;

                HomePage myHomePage = new HomePage();
                this.Hide();
                myHomePage.ShowDialog();
                //this.Close();
            }
            else
            {
                MessageBox.Show("The path entered is not a valid path string or does not exist in this PC's filesystem.", "Invalid Path",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void txt_manualEdit_Click(object sender, EventArgs e)
        {
            if (txt_manualEdit.Text.Equals("Add Directory Path Here"))
            {
                txt_manualEdit.Text = "";
            }
        }

        private void btn_changeDirectory_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe");
        }
        

    }
}
