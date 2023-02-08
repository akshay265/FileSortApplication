using FileSortApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSortApplication
{
    public partial class AddTagPage : Form
    {
        FileTag newTag = null;

        public AddTagPage()
        {
            InitializeComponent();
            SetControls();

        }

        public void SetControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.BackColor = Color.WhiteSmoke;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_createTag_Click(object sender, EventArgs e)
        {
            //check if string is valid
            if (CheckStr(this.txt_name.Text))
            {
                newTag = new FileTag(this.txt_name.Text, this.txt_ID.Text);
                DbaseConnection.AddTag(newTag);
            }
        }
        
        private bool CheckStr(string str)
        {
            var r = new Regex(@"^[a - zA - Z0 - 9]{ 4, 10 }$");
            return r.IsMatch(str);  
        }

        private void AddTagPage_Load(object sender, EventArgs e)
        {
            //DbaseConnection.ConnectToDatabase();
        }
    }
}
