
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
            this.txt_searchBar = new System.Windows.Forms.TextBox();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_done = new System.Windows.Forms.Button();
            this.lbl_fileOps = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_searchBar
            // 
            this.txt_searchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchBar.Location = new System.Drawing.Point(211, 190);
            this.txt_searchBar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_searchBar.Name = "txt_searchBar";
            this.txt_searchBar.Size = new System.Drawing.Size(318, 26);
            this.txt_searchBar.TabIndex = 13;
            this.txt_searchBar.Text = "Search for files here...";
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(656, 33);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(75, 23);
            this.btn_settings.TabIndex = 12;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(535, 190);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 26);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
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
            // AddModifyFilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_searchBar);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.lbl_fileOps);
            this.Name = "AddModifyFilePage";
            this.Text = "File Sort App - Add/Modify File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_searchBar;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Label lbl_fileOps;
        private System.Windows.Forms.Button btn_delete;
    }
}