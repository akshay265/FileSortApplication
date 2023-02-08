namespace FileSortApplication
{
    partial class SuccessPage
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
            this.btn_home = new System.Windows.Forms.Button();
            this.lbl_success = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_operationStr = new System.Windows.Forms.Label();
            this.grpBox_fileAtrb = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_currTag = new System.Windows.Forms.Label();
            this.lbl_sizeUnit = new System.Windows.Forms.Label();
            this.txt_dateCreated = new System.Windows.Forms.TextBox();
            this.lbl_dateCreated = new System.Windows.Forms.Label();
            this.txt_filePath = new System.Windows.Forms.TextBox();
            this.txt_fileType = new System.Windows.Forms.TextBox();
            this.txt_fileName = new System.Windows.Forms.TextBox();
            this.lbl_fileSize = new System.Windows.Forms.Label();
            this.lbl_fileType = new System.Windows.Forms.Label();
            this.lbl_fileName = new System.Windows.Forms.Label();
            this.lbl_filePath = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBox_fileAtrb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_home
            // 
            this.btn_home.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(641, 383);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(100, 40);
            this.btn_home.TabIndex = 26;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // lbl_success
            // 
            this.lbl_success.AutoSize = true;
            this.lbl_success.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_success.Location = new System.Drawing.Point(63, 28);
            this.lbl_success.Name = "lbl_success";
            this.lbl_success.Size = new System.Drawing.Size(235, 30);
            this.lbl_success.TabIndex = 25;
            this.lbl_success.Text = "Operations Successful!";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.IndianRed;
            this.btn_exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(59, 383);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 40);
            this.btn_exit.TabIndex = 28;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_operationStr
            // 
            this.lbl_operationStr.AutoSize = true;
            this.lbl_operationStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_operationStr.Location = new System.Drawing.Point(65, 79);
            this.lbl_operationStr.Name = "lbl_operationStr";
            this.lbl_operationStr.Size = new System.Drawing.Size(62, 20);
            this.lbl_operationStr.TabIndex = 34;
            this.lbl_operationStr.Text = "[op_str]";
            // 
            // grpBox_fileAtrb
            // 
            this.grpBox_fileAtrb.CausesValidation = false;
            this.grpBox_fileAtrb.Controls.Add(this.textBox1);
            this.grpBox_fileAtrb.Controls.Add(this.lbl_currTag);
            this.grpBox_fileAtrb.Controls.Add(this.lbl_sizeUnit);
            this.grpBox_fileAtrb.Controls.Add(this.txt_dateCreated);
            this.grpBox_fileAtrb.Controls.Add(this.lbl_dateCreated);
            this.grpBox_fileAtrb.Controls.Add(this.txt_filePath);
            this.grpBox_fileAtrb.Controls.Add(this.txt_fileType);
            this.grpBox_fileAtrb.Controls.Add(this.txt_fileName);
            this.grpBox_fileAtrb.Controls.Add(this.lbl_fileSize);
            this.grpBox_fileAtrb.Controls.Add(this.lbl_fileType);
            this.grpBox_fileAtrb.Controls.Add(this.lbl_fileName);
            this.grpBox_fileAtrb.Controls.Add(this.lbl_filePath);
            this.grpBox_fileAtrb.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpBox_fileAtrb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_fileAtrb.Location = new System.Drawing.Point(69, 155);
            this.grpBox_fileAtrb.Name = "grpBox_fileAtrb";
            this.grpBox_fileAtrb.Size = new System.Drawing.Size(652, 183);
            this.grpBox_fileAtrb.TabIndex = 35;
            this.grpBox_fileAtrb.TabStop = false;
            this.grpBox_fileAtrb.Text = "File Attributes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 147);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(528, 20);
            this.textBox1.TabIndex = 27;
            // 
            // lbl_currTag
            // 
            this.lbl_currTag.AutoSize = true;
            this.lbl_currTag.Location = new System.Drawing.Point(16, 147);
            this.lbl_currTag.Name = "lbl_currTag";
            this.lbl_currTag.Size = new System.Drawing.Size(95, 17);
            this.lbl_currTag.TabIndex = 24;
            this.lbl_currTag.Text = "Current Tags:";
            // 
            // lbl_sizeUnit
            // 
            this.lbl_sizeUnit.AutoSize = true;
            this.lbl_sizeUnit.Location = new System.Drawing.Point(87, 85);
            this.lbl_sizeUnit.Name = "lbl_sizeUnit";
            this.lbl_sizeUnit.Size = new System.Drawing.Size(12, 17);
            this.lbl_sizeUnit.TabIndex = 26;
            this.lbl_sizeUnit.Text = " ";
            // 
            // txt_dateCreated
            // 
            this.txt_dateCreated.Location = new System.Drawing.Point(121, 52);
            this.txt_dateCreated.Name = "txt_dateCreated";
            this.txt_dateCreated.ReadOnly = true;
            this.txt_dateCreated.Size = new System.Drawing.Size(525, 23);
            this.txt_dateCreated.TabIndex = 25;
            // 
            // lbl_dateCreated
            // 
            this.lbl_dateCreated.AutoSize = true;
            this.lbl_dateCreated.Location = new System.Drawing.Point(16, 55);
            this.lbl_dateCreated.Name = "lbl_dateCreated";
            this.lbl_dateCreated.Size = new System.Drawing.Size(99, 17);
            this.lbl_dateCreated.TabIndex = 24;
            this.lbl_dateCreated.Text = "Creation Date:";
            // 
            // txt_filePath
            // 
            this.txt_filePath.Location = new System.Drawing.Point(90, 112);
            this.txt_filePath.Name = "txt_filePath";
            this.txt_filePath.ReadOnly = true;
            this.txt_filePath.Size = new System.Drawing.Size(556, 23);
            this.txt_filePath.TabIndex = 23;
            // 
            // txt_fileType
            // 
            this.txt_fileType.Location = new System.Drawing.Point(286, 82);
            this.txt_fileType.Name = "txt_fileType";
            this.txt_fileType.ReadOnly = true;
            this.txt_fileType.Size = new System.Drawing.Size(108, 23);
            this.txt_fileType.TabIndex = 21;
            // 
            // txt_fileName
            // 
            this.txt_fileName.Location = new System.Drawing.Point(98, 22);
            this.txt_fileName.Name = "txt_fileName";
            this.txt_fileName.ReadOnly = true;
            this.txt_fileName.Size = new System.Drawing.Size(548, 23);
            this.txt_fileName.TabIndex = 20;
            // 
            // lbl_fileSize
            // 
            this.lbl_fileSize.AutoSize = true;
            this.lbl_fileSize.Location = new System.Drawing.Point(17, 85);
            this.lbl_fileSize.Name = "lbl_fileSize";
            this.lbl_fileSize.Size = new System.Drawing.Size(65, 17);
            this.lbl_fileSize.TabIndex = 2;
            this.lbl_fileSize.Text = "File Size:";
            // 
            // lbl_fileType
            // 
            this.lbl_fileType.AutoSize = true;
            this.lbl_fileType.Location = new System.Drawing.Point(210, 85);
            this.lbl_fileType.Name = "lbl_fileType";
            this.lbl_fileType.Size = new System.Drawing.Size(70, 17);
            this.lbl_fileType.TabIndex = 1;
            this.lbl_fileType.Text = "File Type:";
            // 
            // lbl_fileName
            // 
            this.lbl_fileName.AutoSize = true;
            this.lbl_fileName.Location = new System.Drawing.Point(17, 25);
            this.lbl_fileName.Name = "lbl_fileName";
            this.lbl_fileName.Size = new System.Drawing.Size(75, 17);
            this.lbl_fileName.TabIndex = 0;
            this.lbl_fileName.Text = "File Name:";
            // 
            // lbl_filePath
            // 
            this.lbl_filePath.AutoSize = true;
            this.lbl_filePath.Location = new System.Drawing.Point(17, 115);
            this.lbl_filePath.Name = "lbl_filePath";
            this.lbl_filePath.Size = new System.Drawing.Size(67, 17);
            this.lbl_filePath.TabIndex = 19;
            this.lbl_filePath.Text = "File Path:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FileSortApplication.Properties.Resources.green_checkmark;
            this.pictureBox1.Location = new System.Drawing.Point(621, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // SuccessPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpBox_fileAtrb);
            this.Controls.Add(this.lbl_operationStr);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.lbl_success);
            this.Name = "SuccessPage";
            this.Text = "FileSortApplication - Confirmation Page";
            this.grpBox_fileAtrb.ResumeLayout(false);
            this.grpBox_fileAtrb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Label lbl_success;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_operationStr;
        private System.Windows.Forms.GroupBox grpBox_fileAtrb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_currTag;
        private System.Windows.Forms.Label lbl_sizeUnit;
        private System.Windows.Forms.TextBox txt_dateCreated;
        private System.Windows.Forms.Label lbl_dateCreated;
        private System.Windows.Forms.TextBox txt_filePath;
        private System.Windows.Forms.TextBox txt_fileType;
        private System.Windows.Forms.TextBox txt_fileName;
        private System.Windows.Forms.Label lbl_fileSize;
        private System.Windows.Forms.Label lbl_fileType;
        private System.Windows.Forms.Label lbl_fileName;
        private System.Windows.Forms.Label lbl_filePath;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}