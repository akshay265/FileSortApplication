namespace FileSortApplication
{
    partial class AddTagPage
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
            this.btn_createTag = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_tagName = new System.Windows.Forms.Label();
            this.lbl_addTag = new System.Windows.Forms.Label();
            this.lbl_tagID = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_createTag
            // 
            this.btn_createTag.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createTag.Location = new System.Drawing.Point(222, 209);
            this.btn_createTag.Name = "btn_createTag";
            this.btn_createTag.Size = new System.Drawing.Size(100, 40);
            this.btn_createTag.TabIndex = 27;
            this.btn_createTag.Text = "Create Tag";
            this.btn_createTag.UseVisualStyleBackColor = true;
            this.btn_createTag.Click += new System.EventHandler(this.btn_createTag_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(52, 209);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 40);
            this.btn_back.TabIndex = 28;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_tagName
            // 
            this.lbl_tagName.AutoSize = true;
            this.lbl_tagName.Location = new System.Drawing.Point(49, 79);
            this.lbl_tagName.Name = "lbl_tagName";
            this.lbl_tagName.Size = new System.Drawing.Size(60, 13);
            this.lbl_tagName.TabIndex = 29;
            this.lbl_tagName.Text = "Tag Name:";
            // 
            // lbl_addTag
            // 
            this.lbl_addTag.AutoSize = true;
            this.lbl_addTag.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addTag.Location = new System.Drawing.Point(47, 26);
            this.lbl_addTag.Name = "lbl_addTag";
            this.lbl_addTag.Size = new System.Drawing.Size(132, 30);
            this.lbl_addTag.TabIndex = 30;
            this.lbl_addTag.Text = "Create a Tag";
            // 
            // lbl_tagID
            // 
            this.lbl_tagID.AutoSize = true;
            this.lbl_tagID.Location = new System.Drawing.Point(49, 130);
            this.lbl_tagID.Name = "lbl_tagID";
            this.lbl_tagID.Size = new System.Drawing.Size(75, 13);
            this.lbl_tagID.TabIndex = 31;
            this.lbl_tagID.Text = "Tag ID will be:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(115, 76);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(207, 20);
            this.txt_name.TabIndex = 32;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(130, 127);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(192, 20);
            this.txt_ID.TabIndex = 33;
            // 
            // AddTagPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_tagID);
            this.Controls.Add(this.lbl_addTag);
            this.Controls.Add(this.lbl_tagName);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_createTag);
            this.Name = "AddTagPage";
            this.Text = "File Sort App - Add Tag Page";
            this.Load += new System.EventHandler(this.AddTagPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_createTag;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_tagName;
        private System.Windows.Forms.Label lbl_addTag;
        private System.Windows.Forms.Label lbl_tagID;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_ID;
    }
}