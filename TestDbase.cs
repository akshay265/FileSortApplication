using FileSortApplication.Models;
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
    public partial class TestDbase : Form
    {
        public TestDbase()
        {
            InitializeComponent();
        }

        private void TestDbase_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            this.dgFileList.DataSource = DbaseConnection.GetFileListData();
        }
    }
}
