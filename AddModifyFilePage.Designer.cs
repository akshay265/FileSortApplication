
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
            this.components = new System.ComponentModel.Container();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_done = new System.Windows.Forms.Button();
            this.lbl_fileOps = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
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
            this.btn_move = new System.Windows.Forms.Button();
            this.lbl_currTag = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_createTag = new System.Windows.Forms.Button();
            this.btn_addTag = new System.Windows.Forms.Button();
            this.grpBox_fileAtrb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_file)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
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
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(358, 286);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 48);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            this.grpBox_fileAtrb.Location = new System.Drawing.Point(58, 84);
            this.grpBox_fileAtrb.Name = "grpBox_fileAtrb";
            this.grpBox_fileAtrb.Size = new System.Drawing.Size(400, 183);
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
            // btn_move
            // 
            this.btn_move.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_move.Location = new System.Drawing.Point(245, 286);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(107, 48);
            this.btn_move.TabIndex = 23;
            this.btn_move.Text = "Move to File Sort Folder";
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 147);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 20);
            this.textBox1.TabIndex = 27;
            // 
            // btn_createTag
            // 
            this.btn_createTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createTag.Location = new System.Drawing.Point(58, 286);
            this.btn_createTag.Name = "btn_createTag";
            this.btn_createTag.Size = new System.Drawing.Size(82, 48);
            this.btn_createTag.TabIndex = 24;
            this.btn_createTag.Text = "Create Tags";
            this.btn_createTag.UseVisualStyleBackColor = true;
            // 
            // btn_addTag
            // 
            this.btn_addTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addTag.Location = new System.Drawing.Point(148, 286);
            this.btn_addTag.Name = "btn_addTag";
            this.btn_addTag.Size = new System.Drawing.Size(66, 48);
            this.btn_addTag.TabIndex = 25;
            this.btn_addTag.Text = "Add Tags";
            this.btn_addTag.UseVisualStyleBackColor = true;
            // 
            // AddModifyFilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_addTag);
            this.Controls.Add(this.btn_createTag);
            this.Controls.Add(this.picBox_file);
            this.Controls.Add(this.grpBox_fileAtrb);
            this.Controls.Add(this.btn_move);
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Label lbl_fileOps;
        private System.Windows.Forms.Button btn_delete;
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
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Label lbl_currTag;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_createTag;
        private System.Windows.Forms.Button btn_addTag;
    }
}