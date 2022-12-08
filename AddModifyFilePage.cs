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
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,

                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (addModFileDlg.ShowDialog() == DialogResult.OK)
            {
                //populate prevFileVars + display vals and file
                String prevFileName = addModFileDlg.FileName;
                FileInfo fInfo = new FileInfo(prevFileName);

                prevFileVars.Add(prevFileName);
                prevFileVars.Add(fInfo.Name);
                prevFileVars.Add(fInfo.Extension);
                prevFileVars.Add(fInfo.Length);
                prevFileVars.Add(fInfo.CreationTime);
                //prevFileVars.Add(fInfo.)

                picBox_file.SizeMode = PictureBoxSizeMode.Zoom;
                picBox_file.Image = new Bitmap(prevFileName);
            }
        }

    }
}
