
namespace FileSortApplication
{
    partial class appForm
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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dwdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qwdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qwdToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.qwdToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.qwdToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(42, 33);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(110, 30);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome!";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dwdToolStripMenuItem,
            this.wdToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(98, 48);
            // 
            // dwdToolStripMenuItem
            // 
            this.dwdToolStripMenuItem.Name = "dwdToolStripMenuItem";
            this.dwdToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.dwdToolStripMenuItem.Text = "dwd";
            // 
            // wdToolStripMenuItem
            // 
            this.wdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qwdToolStripMenuItem});
            this.wdToolStripMenuItem.Name = "wdToolStripMenuItem";
            this.wdToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.wdToolStripMenuItem.Text = "wd";
            // 
            // qwdToolStripMenuItem
            // 
            this.qwdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qwdToolStripMenuItem1});
            this.qwdToolStripMenuItem.Name = "qwdToolStripMenuItem";
            this.qwdToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.qwdToolStripMenuItem.Text = "qwd";
            // 
            // qwdToolStripMenuItem1
            // 
            this.qwdToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qwdToolStripMenuItem2});
            this.qwdToolStripMenuItem1.Name = "qwdToolStripMenuItem1";
            this.qwdToolStripMenuItem1.Size = new System.Drawing.Size(97, 22);
            this.qwdToolStripMenuItem1.Text = "qwd";
            // 
            // qwdToolStripMenuItem2
            // 
            this.qwdToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qwdToolStripMenuItem3});
            this.qwdToolStripMenuItem2.Name = "qwdToolStripMenuItem2";
            this.qwdToolStripMenuItem2.Size = new System.Drawing.Size(97, 22);
            this.qwdToolStripMenuItem2.Text = "qwd";
            // 
            // qwdToolStripMenuItem3
            // 
            this.qwdToolStripMenuItem3.Name = "qwdToolStripMenuItem3";
            this.qwdToolStripMenuItem3.Size = new System.Drawing.Size(97, 22);
            this.qwdToolStripMenuItem3.Text = "qwd";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // appForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_welcome);
            this.Name = "appForm";
            this.Text = "File Sorter";
            this.Load += new System.EventHandler(this.appForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dwdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qwdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qwdToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem qwdToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem qwdToolStripMenuItem3;
        private System.Windows.Forms.Button button1;
    }
}

