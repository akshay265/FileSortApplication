
namespace FileSortApplication
{
    partial class SettingsPage
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
            this.txt_currDefault = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_settings = new System.Windows.Forms.Label();
            this.grpBox_currDirectory = new System.Windows.Forms.GroupBox();
            this.grpBox_changeDirectory = new System.Windows.Forms.GroupBox();
            this.txt_manualEdit = new System.Windows.Forms.TextBox();
            this.lbl_or = new System.Windows.Forms.Label();
            this.btn_changeDirectory = new System.Windows.Forms.Button();
            this.grpBox_currDirectory.SuspendLayout();
            this.grpBox_changeDirectory.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_currDefault
            // 
            this.txt_currDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currDefault.Location = new System.Drawing.Point(19, 35);
            this.txt_currDefault.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_currDefault.Name = "txt_currDefault";
            this.txt_currDefault.ReadOnly = true;
            this.txt_currDefault.Size = new System.Drawing.Size(654, 26);
            this.txt_currDefault.TabIndex = 13;
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
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(631, 388);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 40);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_settings
            // 
            this.lbl_settings.AutoSize = true;
            this.lbl_settings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_settings.Location = new System.Drawing.Point(53, 33);
            this.lbl_settings.Name = "lbl_settings";
            this.lbl_settings.Size = new System.Drawing.Size(93, 30);
            this.lbl_settings.TabIndex = 8;
            this.lbl_settings.Text = "Settings";
            // 
            // grpBox_currDirectory
            // 
            this.grpBox_currDirectory.Controls.Add(this.txt_currDefault);
            this.grpBox_currDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_currDirectory.Location = new System.Drawing.Point(58, 93);
            this.grpBox_currDirectory.Name = "grpBox_currDirectory";
            this.grpBox_currDirectory.Size = new System.Drawing.Size(686, 78);
            this.grpBox_currDirectory.TabIndex = 15;
            this.grpBox_currDirectory.TabStop = false;
            this.grpBox_currDirectory.Text = "Current Default Directory";
            // 
            // grpBox_changeDirectory
            // 
            this.grpBox_changeDirectory.Controls.Add(this.txt_manualEdit);
            this.grpBox_changeDirectory.Controls.Add(this.lbl_or);
            this.grpBox_changeDirectory.Controls.Add(this.btn_changeDirectory);
            this.grpBox_changeDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_changeDirectory.Location = new System.Drawing.Point(58, 198);
            this.grpBox_changeDirectory.Name = "grpBox_changeDirectory";
            this.grpBox_changeDirectory.Size = new System.Drawing.Size(686, 163);
            this.grpBox_changeDirectory.TabIndex = 16;
            this.grpBox_changeDirectory.TabStop = false;
            this.grpBox_changeDirectory.Text = "Change Default Directory";
            // 
            // txt_manualEdit
            // 
            this.txt_manualEdit.AcceptsReturn = true;
            this.txt_manualEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_manualEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txt_manualEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manualEdit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_manualEdit.Location = new System.Drawing.Point(19, 115);
            this.txt_manualEdit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_manualEdit.Name = "txt_manualEdit";
            this.txt_manualEdit.Size = new System.Drawing.Size(654, 24);
            this.txt_manualEdit.TabIndex = 14;
            this.txt_manualEdit.Text = "Add Directory Path Here";
            this.txt_manualEdit.Click += new System.EventHandler(this.txt_manualEdit_Click);
            // 
            // lbl_or
            // 
            this.lbl_or.AutoSize = true;
            this.lbl_or.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_or.Location = new System.Drawing.Point(331, 78);
            this.lbl_or.Name = "lbl_or";
            this.lbl_or.Size = new System.Drawing.Size(62, 24);
            this.lbl_or.TabIndex = 18;
            this.lbl_or.Text = "--OR--";
            // 
            // btn_changeDirectory
            // 
            this.btn_changeDirectory.Location = new System.Drawing.Point(291, 37);
            this.btn_changeDirectory.Name = "btn_changeDirectory";
            this.btn_changeDirectory.Size = new System.Drawing.Size(158, 30);
            this.btn_changeDirectory.TabIndex = 17;
            this.btn_changeDirectory.Text = "Choose Folder";
            this.btn_changeDirectory.UseVisualStyleBackColor = true;
            this.btn_changeDirectory.Click += new System.EventHandler(this.btn_changeDirectory_Click);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.grpBox_changeDirectory);
            this.Controls.Add(this.grpBox_currDirectory);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_settings);
            this.Name = "SettingsPage";
            this.Text = "File Sort App - Settings";
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            this.grpBox_currDirectory.ResumeLayout(false);
            this.grpBox_currDirectory.PerformLayout();
            this.grpBox_changeDirectory.ResumeLayout(false);
            this.grpBox_changeDirectory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_currDefault;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_settings;
        private System.Windows.Forms.GroupBox grpBox_currDirectory;
        private System.Windows.Forms.GroupBox grpBox_changeDirectory;
        private System.Windows.Forms.TextBox txt_manualEdit;
        private System.Windows.Forms.Label lbl_or;
        private System.Windows.Forms.Button btn_changeDirectory;
    }
}