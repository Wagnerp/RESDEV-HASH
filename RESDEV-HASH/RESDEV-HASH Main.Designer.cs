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
            this.components = new System.ComponentModel.Container();
            this.MainTab_ctl = new System.Windows.Forms.TabControl();
            this.HashOneFile = new System.Windows.Forms.TabPage();
            this.about_llbl = new System.Windows.Forms.LinkLabel();
            this.hashprogress_pb = new System.Windows.Forms.ProgressBar();
            this.hashoutput_tb = new System.Windows.Forms.TextBox();
            this.about_btn = new System.Windows.Forms.Button();
            this.selectfile_btn = new System.Windows.Forms.Button();
            this.Hashes_cb = new System.Windows.Forms.ComboBox();
            this.hash_lbl = new System.Windows.Forms.Label();
            this.CompareFiles = new System.Windows.Forms.TabPage();
            this.TabToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.MainTab_ctl.SuspendLayout();
            this.HashOneFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab_ctl
            // 
            this.MainTab_ctl.Controls.Add(this.HashOneFile);
            this.MainTab_ctl.Controls.Add(this.CompareFiles);
            this.MainTab_ctl.Location = new System.Drawing.Point(-2, -2);
            this.MainTab_ctl.Name = "MainTab_ctl";
            this.MainTab_ctl.SelectedIndex = 0;
            this.MainTab_ctl.Size = new System.Drawing.Size(512, 497);
            this.MainTab_ctl.TabIndex = 0;
            // 
            // HashOneFile
            // 
            this.HashOneFile.Controls.Add(this.about_llbl);
            this.HashOneFile.Controls.Add(this.hashprogress_pb);
            this.HashOneFile.Controls.Add(this.hashoutput_tb);
            this.HashOneFile.Controls.Add(this.about_btn);
            this.HashOneFile.Controls.Add(this.selectfile_btn);
            this.HashOneFile.Controls.Add(this.Hashes_cb);
            this.HashOneFile.Controls.Add(this.hash_lbl);
            this.HashOneFile.Location = new System.Drawing.Point(4, 22);
            this.HashOneFile.Name = "HashOneFile";
            this.HashOneFile.Padding = new System.Windows.Forms.Padding(3);
            this.HashOneFile.Size = new System.Drawing.Size(504, 471);
            this.HashOneFile.TabIndex = 0;
            this.HashOneFile.Text = "Hash Single File";
            this.HashOneFile.UseVisualStyleBackColor = true;
            // 
            // about_llbl
            // 
            this.about_llbl.AutoSize = true;
            this.about_llbl.Location = new System.Drawing.Point(367, 453);
            this.about_llbl.Name = "about_llbl";
            this.about_llbl.Size = new System.Drawing.Size(134, 13);
            this.about_llbl.TabIndex = 6;
            this.about_llbl.TabStop = true;
            this.about_llbl.Text = "About RESDEV-Hash Tool";
            // 
            // hashprogress_pb
            // 
            this.hashprogress_pb.Location = new System.Drawing.Point(6, 418);
            this.hashprogress_pb.Name = "hashprogress_pb";
            this.hashprogress_pb.Size = new System.Drawing.Size(492, 23);
            this.hashprogress_pb.Step = 5;
            this.hashprogress_pb.TabIndex = 5;
            // 
            // hashoutput_tb
            // 
            this.hashoutput_tb.Location = new System.Drawing.Point(8, 51);
            this.hashoutput_tb.Multiline = true;
            this.hashoutput_tb.Name = "hashoutput_tb";
            this.hashoutput_tb.ReadOnly = true;
            this.hashoutput_tb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.hashoutput_tb.Size = new System.Drawing.Size(490, 361);
            this.hashoutput_tb.TabIndex = 4;
            // 
            // about_btn
            // 
            this.about_btn.Location = new System.Drawing.Point(421, 10);
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(75, 23);
            this.about_btn.TabIndex = 3;
            this.about_btn.Text = "Abort";
            this.TabToolTips.SetToolTip(this.about_btn, "Abort Current Opperation");
            this.about_btn.UseVisualStyleBackColor = true;
            // 
            // selectfile_btn
            // 
            this.selectfile_btn.Location = new System.Drawing.Point(194, 10);
            this.selectfile_btn.Name = "selectfile_btn";
            this.selectfile_btn.Size = new System.Drawing.Size(196, 23);
            this.selectfile_btn.TabIndex = 2;
            this.selectfile_btn.Text = "Select File && Go";
            this.TabToolTips.SetToolTip(this.selectfile_btn, "Compute Hash of Single File");
            this.selectfile_btn.UseVisualStyleBackColor = true;
            this.selectfile_btn.Click += new System.EventHandler(this.selectfile_btn_Click);
            // 
            // Hashes_cb
            // 
            this.Hashes_cb.FormattingEnabled = true;
            this.Hashes_cb.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "SHA256",
            "SHA512"});
            this.Hashes_cb.Location = new System.Drawing.Point(51, 12);
            this.Hashes_cb.Name = "Hashes_cb";
            this.Hashes_cb.Size = new System.Drawing.Size(121, 21);
            this.Hashes_cb.TabIndex = 1;
            this.TabToolTips.SetToolTip(this.Hashes_cb, "Select the type of Hash you would like to use");
            // 
            // hash_lbl
            // 
            this.hash_lbl.AutoSize = true;
            this.hash_lbl.Location = new System.Drawing.Point(10, 15);
            this.hash_lbl.Name = "hash_lbl";
            this.hash_lbl.Size = new System.Drawing.Size(35, 13);
            this.hash_lbl.TabIndex = 0;
            this.hash_lbl.Text = "Hash:";
            this.hash_lbl.Click += new System.EventHandler(this.hash_lbl_Click);
            // 
            // CompareFiles
            // 
            this.CompareFiles.Location = new System.Drawing.Point(4, 22);
            this.CompareFiles.Name = "CompareFiles";
            this.CompareFiles.Padding = new System.Windows.Forms.Padding(3);
            this.CompareFiles.Size = new System.Drawing.Size(504, 471);
            this.CompareFiles.TabIndex = 1;
            this.CompareFiles.Text = "Compare File Hashes";
            this.CompareFiles.UseVisualStyleBackColor = true;
            // 
            // bgw
            // 
            this.bgw.WorkerReportsProgress = true;
            this.bgw.WorkerSupportsCancellation = true;
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
            this.HashOneFile.ResumeLayout(false);
            this.HashOneFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab_ctl;
        private System.Windows.Forms.TabPage HashOneFile;
        private System.Windows.Forms.TabPage CompareFiles;
        private System.Windows.Forms.Button selectfile_btn;
        private System.Windows.Forms.ComboBox Hashes_cb;
        private System.Windows.Forms.ToolTip TabToolTips;
        private System.Windows.Forms.Label hash_lbl;
        private System.Windows.Forms.Button about_btn;
        private System.Windows.Forms.ProgressBar hashprogress_pb;
        private System.Windows.Forms.TextBox hashoutput_tb;
        private System.Windows.Forms.LinkLabel about_llbl;
        private System.ComponentModel.BackgroundWorker bgw;
    }
}

