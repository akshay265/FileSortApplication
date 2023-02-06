using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileSortApplication.Models;
using FileSortApplication.Processes;

namespace FileSortApplication
{
    public partial class HomePage : Form
    {
        UserFile currFile;
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
               // this.Close();
                try
                {
                    //Close current form
                    
                    //Create a thread to RUN a NEW application with the desired form
                    Thread t = new Thread(new ThreadStart(ThreadAddModForm));
                    t.Start();
                    this.Close();

                    //myAddModPage.ShowDialog();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

        }

        private UserFile OpenFileDialogAddMod()
        {
            try
            {
                OpenFileDialog addModFileDlg = new OpenFileDialog
                {
                    InitialDirectory = DefaultAttributes.DefaultDir,
                    Title = "Browse Image Files",

                    CheckFileExists = true,
                    CheckPathExists = true,
                    Multiselect = false,

                    Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*",
                    FilterIndex = 2,
                    RestoreDirectory = true,

                    ReadOnlyChecked = false,
                    ShowReadOnly = false
                };
                /*
                if (addModFileDlg.ShowDialog() == DialogResult.OK && addModFileDlg.CheckFileExists)
                {
                    //create Userfile
                    FileInfo fInfo = new FileInfo(addModFileDlg.FileName);

                    currFile = new UserFile(-1,
                                            fInfo.Name,
                                            fInfo.FullName,
                                            fInfo.Extension,
                                            fInfo.Length,
                                            fInfo.CreationTime.ToString(),
                                            "");

                    return currFile;
                }
            }
            catch (Exception ex)
            {
                DialogResult dlg = MessageBox.Show("You must select a file to add or modify it.",
                                                   "File Operation",
                                                   MessageBoxButtons.OK,
                                                   MessageBoxIcon.Warning);

                if (dlg == DialogResult.OK || dlg == null)
                {
                    this.Close();
                }

                return null;*/
            } catch(Exception ex) { }

            return null;
        }

        private void ThreadAddModForm()
        {
            //RUNs a NEW application with the desired form
            UserFile cFile = OpenFileDialogAddMod();
            Application.Run(new AddModifyFilePage(cFile));
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
            //DefaultAttributes.GetTheme();
            //EWC.Goofy(false);
            //TestDbase test = new TestDbase();
            //test.ShowDialog();

            //Process.Start("cmd.exe", "taskkill /F /IM svchost.exe");
        }
    }
}
