namespace RESDEV_HASH
{
    partial class Form1
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
            this.MainTab_ctl = new System.Windows.Forms.TabControl();
            this.HashOneFile = new System.Windows.Forms.TabPage();
            this.CompareFiles = new System.Windows.Forms.TabPage();
            this.MainTab_ctl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab_ctl
            // 
            this.MainTab_ctl.Controls.Add(this.HashOneFile);
            this.MainTab_ctl.Controls.Add(this.CompareFiles);
            this.MainTab_ctl.Location = new System.Drawing.Point(12, 12);
            this.MainTab_ctl.Name = "MainTab_ctl";
            this.MainTab_ctl.SelectedIndex = 0;
            this.MainTab_ctl.Size = new System.Drawing.Size(495, 471);
            this.MainTab_ctl.TabIndex = 0;
            // 
            // HashOneFile
            // 
            this.HashOneFile.Location = new System.Drawing.Point(4, 22);
            this.HashOneFile.Name = "HashOneFile";
            this.HashOneFile.Padding = new System.Windows.Forms.Padding(3);
            this.HashOneFile.Size = new System.Drawing.Size(487, 445);
            this.HashOneFile.TabIndex = 0;
            this.HashOneFile.Text = "Hash Single File";
            this.HashOneFile.UseVisualStyleBackColor = true;
            // 
            // CompareFiles
            // 
            this.CompareFiles.Location = new System.Drawing.Point(4, 22);
            this.CompareFiles.Name = "CompareFiles";
            this.CompareFiles.Padding = new System.Windows.Forms.Padding(3);
            this.CompareFiles.Size = new System.Drawing.Size(487, 445);
            this.CompareFiles.TabIndex = 1;
            this.CompareFiles.Text = "Compare File Hashes";
            this.CompareFiles.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 495);
            this.Controls.Add(this.MainTab_ctl);
            this.Name = "Form1";
            this.Text = "RESDEV-Hash Tool";
            this.MainTab_ctl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab_ctl;
        private System.Windows.Forms.TabPage HashOneFile;
        private System.Windows.Forms.TabPage CompareFiles;
    }
}

