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

namespace FileSortApplication
{
    public partial class AddModifyFilePage : Form
    {
        ArrayList prevFileVars = new ArrayList();
        
        public AddModifyFilePage()
        {
            InitializeComponent();
            CenterToScreen();
            SetControls();
            OpenDialog();
            PopulateFields();
        }

        private void SetControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.BackColor = Color.WhiteSmoke;
        }

        private void OpenDialog()
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

            if (addModFileDlg.ShowDialog() == DialogResult.OK)
            {
                //populate prevFileVars
                String prevFileName = addModFileDlg.FileName;
                FileInfo fInfo = new FileInfo(prevFileName);

                prevFileVars.Add(prevFileName);
                prevFileVars.Add(fInfo.Name);
                prevFileVars.Add(fInfo.Extension);
                prevFileVars.Add(fInfo.Length);
                prevFileVars.Add(fInfo.CreationTime);
                prevFileVars.Add(fInfo.FullName);
            }


        }

        private void PopulateFields()
        {
            this.txt_fileName.Text = prevFileVars[1].ToString();
            this.txt_fileType.Text = prevFileVars[2].ToString();

            long s = long.Parse(prevFileVars[3].ToString());
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
            
            this.txt_dateCreated.Text = prevFileVars[4].ToString();
            this.txt_filePath.Text = prevFileVars[5].ToString();

            picBox_file.SizeMode = PictureBoxSizeMode.Zoom;
            picBox_file.Image = new Bitmap(this.txt_filePath.Text);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            String m = "Are you sure you want to delete '" + prevFileVars[10].ToString() + "'?";
            DialogResult dlg = MessageBox.Show(m,"File Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dlg == DialogResult.Yes)
            {
                
            }
            else if (dlg == DialogResult.No)
            {
                DataBindings.Clear();
            }
        }
    }
}
