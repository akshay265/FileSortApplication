
namespace FileSortApplication
{
    partial class TestDbase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgFileList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgFileList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFileList
            // 
            this.dgFileList.AllowUserToAddRows = false;
            this.dgFileList.AllowUserToDeleteRows = false;
            this.dgFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFileList.Location = new System.Drawing.Point(34, 87);
            this.dgFileList.Name = "dgFileList";
            this.dgFileList.ReadOnly = true;
            this.dgFileList.Size = new System.Drawing.Size(730, 207);
            this.dgFileList.TabIndex = 0;
            // 
            // TestDbase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgFileList);
            this.Name = "TestDbase";
            this.Text = "TestDbase";
            this.Load += new System.EventHandler(this.TestDbase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFileList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFileList;
    }
}