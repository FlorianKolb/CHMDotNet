using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHMDotNet.Core.Settings;
using CHMDotNet.Core;

namespace CHMDotNet.GUI
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RegistryManager.GetHHWInstallPath()))
                hhwPath.Text = Helper.GetHHWInstallDirectory();
            else
                hhwPath.Text = RegistryManager.GetHHWInstallPath();
        }

        private void changeHHWPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (!string.IsNullOrEmpty(hhwPath.Text))
                    fbd.SelectedPath = hhwPath.Text;

                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    hhwPath.Text = fbd.SelectedPath;
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            RegistryManager.SetHHWInstallPath(hhwPath.Text);

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}