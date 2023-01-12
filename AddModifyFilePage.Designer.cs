
namespace FileSortApplication
{
    partial class AddModifyFilePage
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_done = new System.Windows.Forms.Button();
            this.lbl_fileOps = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_filePath = new System.Windows.Forms.Label();
            this.grpBox_fileAtrb = new System.Windows.Forms.GroupBox();
            this.lbl_sizeUnit = new System.Windows.Forms.Label();
            this.txt_dateCreated = new System.Windows.Forms.TextBox();
            this.lbl_dateCreated = new System.Windows.Forms.Label();
            this.txt_filePath = new System.Windows.Forms.TextBox();
            this.txt_fileType = new System.Windows.Forms.TextBox();
            this.txt_fileName = new System.Windows.Forms.TextBox();
            this.lbl_fileSize = new System.Windows.Forms.Label();
            this.lbl_fileType = new System.Windows.Forms.Label();
            this.lbl_fileName = new System.Windows.Forms.Label();
            this.picBox_file = new System.Windows.Forms.PictureBox();
            this.grpBox_fileAtrb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_file)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(496, 388);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 40);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_done
            // 
            this.btn_done.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done.Location = new System.Drawing.Point(631, 388);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(100, 40);
            this.btn_done.TabIndex = 9;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = true;
            // 
            // lbl_fileOps
            // 
            this.lbl_fileOps.AutoSize = true;
            this.lbl_fileOps.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fileOps.Location = new System.Drawing.Point(53, 33);
            this.lbl_fileOps.Name = "lbl_fileOps";
            this.lbl_fileOps.Size = new System.Drawing.Size(161, 30);
            this.lbl_fileOps.TabIndex = 8;
            this.lbl_fileOps.Text = "File Operations";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btn_delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(49, 388);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 40);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.AutoSize = true;
            this.btn_add.Location = new System.Drawing.Point(212, 256);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(56, 13);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "Add Tags:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Create Tags:";
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
            // grpBox_fileAtrb
            // 
            this.grpBox_fileAtrb.CausesValidation = false;
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
            this.grpBox_fileAtrb.Location = new System.Drawing.Point(58, 84);
            this.grpBox_fileAtrb.Name = "grpBox_fileAtrb";
            this.grpBox_fileAtrb.Size = new System.Drawing.Size(400, 150);
            this.grpBox_fileAtrb.TabIndex = 21;
            this.grpBox_fileAtrb.TabStop = false;
            this.grpBox_fileAtrb.Text = "Edit File Attributes";
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
            this.txt_dateCreated.Size = new System.Drawing.Size(273, 23);
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
            this.txt_filePath.Size = new System.Drawing.Size(304, 23);
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
            this.txt_fileName.Size = new System.Drawing.Size(296, 23);
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
            // picBox_file
            // 
            this.picBox_file.Location = new System.Drawing.Point(477, 63);
            this.picBox_file.Name = "picBox_file";
            this.picBox_file.Size = new System.Drawing.Size(254, 271);
            this.picBox_file.TabIndex = 22;
            this.picBox_file.TabStop = false;
            // 
            // AddModifyFilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.picBox_file);
            this.Controls.Add(this.grpBox_fileAtrb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.lbl_fileOps);
            this.Name = "AddModifyFilePage";
            this.Text = "File Sort App - Add/Modify File";
            this.Load += new System.EventHandler(this.AddModifyFilePage_Load);
            this.grpBox_fileAtrb.ResumeLayout(false);
            this.grpBox_fileAtrb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_file)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Label lbl_fileOps;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label btn_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_filePath;
        private System.Windows.Forms.GroupBox grpBox_fileAtrb;
        private System.Windows.Forms.PictureBox picBox_file;
        private System.Windows.Forms.Label lbl_fileSize;
        private System.Windows.Forms.Label lbl_fileType;
        private System.Windows.Forms.Label lbl_fileName;
        private System.Windows.Forms.TextBox txt_filePath;
        private System.Windows.Forms.TextBox txt_fileType;
        private System.Windows.Forms.TextBox txt_fileName;
        private System.Windows.Forms.TextBox txt_dateCreated;
        private System.Windows.Forms.Label lbl_dateCreated;
        private System.Windows.Forms.Label lbl_sizeUnit;
    }
}