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
using System.Threading;
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
            this.Icon = DefaultAttributes.DefaultIconObj;

            //Directory info
            this.txt_currDefault.Text = DefaultAttributes.DefaultDir;

        }

        /**
         * Checks if a given path is valid and if it exists.
         * https://stackoverflow.com/questions/3137097/check-if-a-string-is-a-valid-windows-directory-folder-path
         */

        private bool IsValidPath(String path)
        {
            if (path.Length == 0 || path.Equals("Add Directory Path Here"))
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

            Thread t = new Thread(new ThreadStart(ThreadHomePage));
            ThreadScheduler.AddThread(t, 0);
            ThreadScheduler.StartThread(0);
            /*
            HomePage myHomePage = new HomePage();
            this.Hide();
            myHomePage.ShowDialog();*/
            this.Close();
            this.Dispose();
            ThreadScheduler.AbortThread(1);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (IsValidPath(txt_manualEdit.Text) )
            {
                if (!txt_manualEdit.Text.Equals("Add Directory Path Here"))
                {
                    DefaultAttributes.DefaultDir = txt_manualEdit.Text;

                }

                Thread t = new Thread(new ThreadStart(ThreadHomePage));
                ThreadScheduler.AddThread(t, 0);
                ThreadScheduler.StartThread(0);

                this.Close();
                this.Dispose();
                ThreadScheduler.AbortThread(1);
                /*HomePage myHomePage = new HomePage();
                this.Hide();
                myHomePage.ShowDialog();
                //this.Close();*/
            }
            else
            {
                MessageBox.Show("The path entered is not a valid path string or does not exist in this PC's filesystem.", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;

            DialogResult box = folderDlg.ShowDialog();

            if (box == DialogResult.OK)
            {
                txt_manualEdit.Text = folderDlg.SelectedPath;
                folderDlg.Dispose();
            }
        }

        private void ThreadHomePage()
        {
            Application.Run(new HomePage());
        }
        

    }
}
