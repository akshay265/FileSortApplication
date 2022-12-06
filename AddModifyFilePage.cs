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
    public partial class AddModifyFilePage : Form
    {
        
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
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            /*
            OpenFileDialog addModFileDlg = new OpenFileDialog();
            addModFileDlg.ShowDialog();

            addModFileDlg.InitialDirectory = DefaultAttributes.DefaultDir;
            addModFileDlg.Title = "Browse for Pictures";
            addModFileDlg.Multiselect = false;
            addModFileDlg.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";*/

            txt_fileName.Text = addModFileDlg.FileName;
        }
    }
}
