using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHMDotNet.Core.Project;
using CHMDotNet.GUI.Editing;
using CHMDotNet.Core.Configuration.FileHistory;
using CHMDotNet.GUI.Properties;

namespace CHMDotNet.GUI.Project
{
    public partial class NewProject : Form
    {
        private Form mWindow;

        public NewProject(Form window)
        {
            InitializeComponent();
            this.mWindow = window;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(projectName.Text))
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "CHMDotNet Projektdatei (*.cdn)|*.cdn";
                    sfd.FileName = projectName.Text;

                    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        CHMProject project = ProjectManager.NewProject(projectName.Text, sfd.FileName);

                        FileHistoryManager.AddFile(sfd.FileName);

                        Form projectForm = new Form();
                        projectForm.ShowIcon = true;
                        projectForm.Tag = projectName.Text;
                        ProjectEditor editor = new ProjectEditor();
                        editor.Dock = DockStyle.Fill;
                        editor.SetRootTreeNode(project, projectName.Text);
                        projectForm.Controls.Add(editor);
                        projectForm.ShowIcon = false;
                        projectForm.Text = projectName.Text;

                        projectForm.Icon = Resources.project;
                        projectForm.MdiParent = this.mWindow;
                        projectForm.Show();
                        projectForm.WindowState = FormWindowState.Maximized;

                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Es muss ein Projektname festgelegt werden!", "CHMDotNet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
