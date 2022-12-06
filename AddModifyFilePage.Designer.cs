
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
            this.btn_fileName = new System.Windows.Forms.Label();
            this.btn_date = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_fileName = new System.Windows.Forms.TextBox();
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
            // 
            // btn_fileName
            // 
            this.btn_fileName.AutoSize = true;
            this.btn_fileName.Location = new System.Drawing.Point(88, 95);
            this.btn_fileName.Name = "btn_fileName";
            this.btn_fileName.Size = new System.Drawing.Size(57, 13);
            this.btn_fileName.TabIndex = 15;
            this.btn_fileName.Text = "File Name:";
            // 
            // btn_date
            // 
            this.btn_date.AutoSize = true;
            this.btn_date.Location = new System.Drawing.Point(88, 132);
            this.btn_date.Name = "btn_date";
            this.btn_date.Size = new System.Drawing.Size(67, 13);
            this.btn_date.TabIndex = 16;
            this.btn_date.Text = "Date Taken:";
            // 
            // btn_add
            // 
            this.btn_add.AutoSize = true;
            this.btn_add.Location = new System.Drawing.Point(91, 169);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(56, 13);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "Add Tags:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Create Tags:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Current File Path:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "New File Path:";
            // 
            // txt_fileName
            // 
            this.txt_fileName.Location = new System.Drawing.Point(151, 92);
            this.txt_fileName.Name = "txt_fileName";
            this.txt_fileName.Size = new System.Drawing.Size(100, 20);
            this.txt_fileName.TabIndex = 21;
            // 
            // AddModifyFilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.txt_fileName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_date);
            this.Controls.Add(this.btn_fileName);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.lbl_fileOps);
            this.Name = "AddModifyFilePage";
            this.Text = "File Sort App - Add/Modify File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Label lbl_fileOps;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label btn_fileName;
        private System.Windows.Forms.Label btn_date;
        private System.Windows.Forms.Label btn_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_fileName;
    }
}