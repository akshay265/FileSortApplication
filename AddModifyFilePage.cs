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
using System.Collections;
using System.IO;
using System.Data.OleDb;
using System.Threading;
using Microsoft.VisualBasic;

namespace FileSortApplication
{

    public partial class AddModifyFilePage : Form
    {
        ArrayList prevFileVars = new ArrayList();
        UserFile currFile;
        bool isSuccessful;
        string operationStr;
        /*
         * OleDbConnection dbaseConnection = new OleDbConnection();
         * OleDbDataAdapter dbaseAdapter;
         * DataTable localFileTable = new DataTable();
         * int rowPos = 0, rowNum = 0;
         */
        Bitmap b;
        // HomePage hpage;

        
        public AddModifyFilePage(UserFile cFile)
        {
            if (cFile != null)
            {
                this.currFile = cFile;

                InitializeComponent();
                CenterToScreen();
                SetControls();

                try
                {
                    PopulateFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a file to add or modify.");
                /*
                //Create a thread to RUN a NEW application with the desired form
                Thread t = new Thread(new ThreadStart(ThreadHomePageForm));
                //t.Start();
                ThreadScheduler.AbortThread(0);
                ThreadScheduler.AbortThread(1);
                ThreadScheduler.AbortThread(2);


                t.SetApartmentState(ApartmentState.STA);
                ThreadScheduler.AddThread(t, 1);
                //ThreadScheduler.StartThread(1);
                this.Close();
                this.Dispose();
               // ThreadScheduler.AbortThread(0);
                //this.Close();*/
            }
        }

        [STAThread]
        private void AddModifyFilePage_Load(object sender, EventArgs e)
        {
            //DbaseConnection.ConnectToDatabase();
        }

        [STAThread]
        private void ThreadHomePageForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new HomePage());
        }

        private void SetControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.BackColor = Color.WhiteSmoke;
        }
        /*
        private void OpenDialog()
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

                String prevFileName = "";
                if (addModFileDlg.ShowDialog() == DialogResult.OK)
                {
                    //populate prevFileVars
                    prevFileName = addModFileDlg.FileName;
                    FileInfo fInfo = new FileInfo(prevFileName);

                    prevFileVars.Add(prevFileName);
                    prevFileVars.Add(fInfo.Name);
                    prevFileVars.Add(fInfo.Extension);
                    prevFileVars.Add(fInfo.Length);
                    prevFileVars.Add(fInfo.CreationTime);
                    prevFileVars.Add(fInfo.FullName);
                }



                currFile = new UserFile(-1,                         // id
                                        prevFileName[0].ToString(), // name
                                        prevFileVars[5].ToString(), // full path
                                        prevFileVars[2].ToString(), // extension
                                        long.Parse(prevFileVars[3].ToString()), // size
                                        prevFileVars[4].ToString(), // creation date
                                        "");
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
            }
        }*/

        [STAThread]
        private void PopulateFields()
        {
            this.txt_fileName.Text = currFile.Name; // prevFileVars[0].ToString();
            this.txt_fileType.Text = currFile.Type; // prevFileVars[2].ToString();

            long s = currFile.Size; //long.Parse(prevFileVars[3].ToString());
            if (s > 1000000000000) //TB
            {
                double res = s / 1000000000000.0;
                this.lbl_sizeUnit.Text = String.Format("{0:#,###,###.##}", res) + " TB";
            } 
            else if (s > 1000000000) //GB
            {
                double res = s / 1000000000.0;
                this.lbl_sizeUnit.Text = String.Format("{0:#,###,###.##}", res) + " GB";
            } 
            else if (s > 1000000) //MB
            {
                double res = s / 1000000.0;
                this.lbl_sizeUnit.Text = String.Format("{0:#,###,###.##}", res) + " MB";
            }
            else if (s > 1000) //KB
            {
                double res = s / 1000.0;
                this.lbl_sizeUnit.Text = String.Format("{0:#,###,###.##}", res) + " KB";
            }
            else
            {
                this.lbl_sizeUnit.Text = s.ToString("#,##0") + " bytes";
            }

            this.txt_dateCreated.Text = currFile.DateCreated; //prevFileVars[4].ToString();
            this.txt_filePath.Text = currFile.Path; //prevFileVars[5].ToString();

            picBox_file.SizeMode = PictureBoxSizeMode.Zoom;
            b = new Bitmap(this.txt_filePath.Text);
            picBox_file.Image = b;
        }

        [STAThread]
        public void GoToFinalPage()
        {
            this.Hide();
            SuccessPage mySuccessPage = new SuccessPage(isSuccessful, operationStr);
            mySuccessPage.ShowDialog();
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            String m = "Are you sure you want to exit this page? All changes will be lost.";
            DialogResult dlg = MessageBox.Show(m, "Page Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dlg == DialogResult.Yes)
            {
                this.Hide();
                HomePage myHomePage = new HomePage();
                myHomePage.ShowDialog();
                this.Close();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            String m = "Are you sure you want to delete '" + currFile.Name + "'?";
            DialogResult dlg = MessageBox.Show(m,"File Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (dlg == DialogResult.Yes)
            {
                isSuccessful = currFile.Delete(b);
            }
            else if (dlg == DialogResult.No)
            {
                //nothing
            }

            GoToFinalPage();
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            try
            {
                currFile.MoveToDbase();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_addTag_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_createTag_Click(object sender, EventArgs e)
        {
            String tagStr = Interaction.InputBox("Tag Name", "Create New Tag", "");
            if (!tagStr.Equals(""))
            {
                DbaseConnection.AddTag(new FileTag(tagStr));
            }


            /*
             AddTagPage myAddTagPage = new AddTagPage();
             myAddTagPage.ShowDialog();*/
        }
    }
}
