
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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.grpBox_currDirectory = new System.Windows.Forms.GroupBox();
            this.grpBox_currDirectory.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_currDefault
            // 
            this.txt_currDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currDefault.Location = new System.Drawing.Point(19, 35);
            this.txt_currDefault.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_currDefault.Name = "txt_currDefault";
            this.txt_currDefault.ReadOnly = true;
            this.txt_currDefault.Size = new System.Drawing.Size(350, 26);
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
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(53, 33);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(93, 30);
            this.lbl_welcome.TabIndex = 8;
            this.lbl_welcome.Text = "Settings";
            // 
            // grpBox_currDirectory
            // 
            this.grpBox_currDirectory.Controls.Add(this.txt_currDefault);
            this.grpBox_currDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_currDirectory.Location = new System.Drawing.Point(58, 93);
            this.grpBox_currDirectory.Name = "grpBox_currDirectory";
            this.grpBox_currDirectory.Size = new System.Drawing.Size(686, 113);
            this.grpBox_currDirectory.TabIndex = 15;
            this.grpBox_currDirectory.TabStop = false;
            this.grpBox_currDirectory.Text = "Current Default Directory";
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.grpBox_currDirectory);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_welcome);
            this.Name = "SettingsPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            this.grpBox_currDirectory.ResumeLayout(false);
            this.grpBox_currDirectory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_currDefault;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.GroupBox grpBox_currDirectory;
    }
}