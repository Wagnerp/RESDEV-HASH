using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RESDEV_HASH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void hash_lbl_Click(object sender, EventArgs e)
        {

        }

        private void selectfile_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog(); //Change this to a file browser dialouge
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                

            }

        }
    }
}
