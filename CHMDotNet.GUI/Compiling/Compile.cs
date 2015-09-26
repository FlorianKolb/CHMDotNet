using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHMDotNet.Core.Compiling;
using CHMDotNet.Core.Project;
using System.IO;
using System.Diagnostics;

namespace CHMDotNet.GUI.Compiling
{
    public partial class Compile : Form
    {
        private bool canCompile;
        private CHMProject chmProject;

        public Compile(bool canCompile, CHMProject project)
        {
            InitializeComponent();
            this.canCompile = canCompile;
            this.chmProject = project;
            this.progressListBox.Items.Clear();
            HHCWrapper.FinishedBuild -= HHCWrapper_FinishedBuild;
            HHCWrapper.FinishedBuild += HHCWrapper_FinishedBuild;
            HHCWrapper.StartBuild -= HHCWrapper_StartBuild;
            HHCWrapper.StartBuild += HHCWrapper_StartBuild;
            HHCWrapper.CreateTemporaryFiles -= HHCWrapper_CreateTemporaryFiles;
            HHCWrapper.CreateTemporaryFiles += HHCWrapper_CreateTemporaryFiles;
            HHCWrapper.CreateTOC -= HHCWrapper_CreateTOC;
            HHCWrapper.CreateTOC += HHCWrapper_CreateTOC;
            HHCWrapper.CreateHHP -= HHCWrapper_CreateHHP;
            HHCWrapper.CreateHHP += HHCWrapper_CreateHHP;
            HHCWrapper.ProgressBuild += HHCWrapper_ProgressBuild;

            if (project != null && !string.IsNullOrEmpty(project.OutputFile))
                this.outputFile.Text = project.OutputFile;
        }

        private void HHCWrapper_ProgressBuild(string progress)
        {
            string[] lines = progress.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            if (this.InvokeRequired)
            {
                foreach (string line in lines)
                    this.BeginInvoke(new Action(delegate()
                    {
                        progressListBox.Items.Add(line);
                    }));
            }
            else
            {
                foreach (string line in lines)
                    progressListBox.Items.Add(line);
            }
        }

        private void HHCWrapper_CreateHHP(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(delegate()
                {
                    actualProgress.Text = "Create hhp file";
                    progressBar1.Value = 60;
                }));
            }
            else
            {
                actualProgress.Text = "Create hhp file";
                progressBar1.Value = 60;
            }
        }

        private void HHCWrapper_CreateTOC(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(delegate()
                {
                    actualProgress.Text = "Create toc file";
                    progressBar1.Value = 40;
                }));
            }
            else
            {
                actualProgress.Text = "Create toc file";
                progressBar1.Value = 40;
            }
        }

        private void HHCWrapper_CreateTemporaryFiles(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(delegate()
                {
                    actualProgress.Text = "Create temporary files";
                    progressBar1.Value = 20;
                }));
            }
            else
            {
                actualProgress.Text = "Create temporary files";
                progressBar1.Value = 20;
            }
        }

        private void HHCWrapper_StartBuild(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(delegate()
                {
                    progressBar1.Value = 80;
                    actualProgress.Text = "Execute HTML Help Compiler";
                }));
            }
            else
            {
                progressBar1.Value = 80;
                actualProgress.Text = "Execute HTML Help Compiler";
            }
        }

        private void setOutputPath_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CHM-Datei (*.chm)|*.chm";

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    outputFile.Text = sfd.FileName;
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createCHM_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.outputFile.Text))
            {
                this.progressListBox.Items.Clear();
                actualProgress.Text = "-";
                progressBar1.Value = 0;
                createCHM.Enabled = false;
                openOutputFile.Enabled = false;
                HHCWrapper.CallHHC(this.chmProject, this.outputFile.Text);
            }
            else
            {
                MessageBox.Show("Es muss eine Ausgabedatei gewählt werden!", "CHMDotNet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HHCWrapper_FinishedBuild(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(delegate()
                {
                    actualProgress.Text = "Finished";
                    progressBar1.Value = 100;
                    createCHM.Enabled = true;
                    openOutputFile.Enabled = true;
                    this.Focus();
                }));
            }
            else
            {
                actualProgress.Text = "Finished";
                progressBar1.Value = 100;
                createCHM.Enabled = true;
                openOutputFile.Enabled = true;
                this.Focus();
            }
        }

        private void Compile_Load(object sender, EventArgs e)
        {
            if (!this.canCompile)
            {
                setOutputPath.Enabled = false;
                createCHM.Enabled = false;
                openOutputFile.Enabled = false;
            }
            else
            {
                setOutputPath.Enabled = true;
                createCHM.Enabled = true;
                openOutputFile.Enabled = true;
            }
        }

        private void openOutputFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (File.Exists(outputFile.Text))
            {
                using (Process p = new Process())
                {
                    p.StartInfo.FileName = outputFile.Text;
                    p.Start();
                }
            }
        }
    }
}