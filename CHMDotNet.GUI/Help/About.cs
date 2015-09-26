using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace CHMDotNet.GUI.Help
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void tidyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Process p = new Process())
            {
                p.StartInfo.FileName = tidyLink.Text;
                p.Start();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Process p = new Process())
            {
                p.StartInfo.FileName = "http://famfamfam.com";
                p.Start();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Process p = new Process())
            {
                p.StartInfo.FileName = "http://nahas-pro.deviantart.com/";
                p.Start();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
