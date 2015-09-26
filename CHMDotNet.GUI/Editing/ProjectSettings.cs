using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHMDotNet.Core.Project;
using System.Globalization;

namespace CHMDotNet.GUI.Editing
{
    public partial class ProjectSettings : UserControl
    {
        private CHMProject currentProject;

        private bool init;
        public event EventHandler IsDirty;

        public ProjectSettings()
        {
            InitializeComponent();
        }

        public void SetProject(CHMProject project)
        {
            this.init = true;
            this.currentProject = project;
            ReloadTopics();

            this.projectName.Text = project.Name;
            this.outputFile.Text = project.OutputFile;
            this.windowTitle.Text = project.WindowTitle;
            this.fullTextSearch.Checked = project.FullTextSearch;

            this.init = false;
        }

        public void ReloadTopics()
        {
            if (this.currentProject != null)
            {
                this.defaultTopicComboBox.Items.Clear();

                if (this.currentProject.Topics != null)
                    foreach (CHMTopic topic in this.currentProject.Topics)
                        InsertTopics(topic);
            }

            //Default topic laden
            if (!string.IsNullOrEmpty(this.currentProject.DefaultTopic))
            {
                CHMTopic defaultTopic = new CHMTopic();

                foreach (CHMTopic topic in this.defaultTopicComboBox.Items)
                {
                    if (topic.Id.ToString().Equals(this.currentProject.DefaultTopic))
                    {
                        defaultTopic = topic;
                        break;
                    }
                }

                if (defaultTopic != null)
                {
                    this.defaultTopicComboBox.Items.Insert(0, string.Empty);
                    this.defaultTopicComboBox.SelectedItem = defaultTopic;
                }
            }
            else
                this.defaultTopicComboBox.Items.Insert(0, string.Empty);
        }

        private void InsertTopics(CHMTopic topic)
        {
            if (topic.TopicType != CHMTopic.CHMTopicType.Link)
                this.defaultTopicComboBox.Items.Add(topic);

            if (topic.Children != null && topic.Children.Count > 0)
                foreach (CHMTopic child in topic.Children)
                    InsertTopics(child);
        }

        private void setOutputFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CHM-Datei (*.chm)|*.chm";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    outputFile.Text = sfd.FileName;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.currentProject.OutputFile = outputFile.Text;
            this.currentProject.Name = projectName.Text;
            this.currentProject.WindowTitle = windowTitle.Text;

            if (this.defaultTopicComboBox.SelectedIndex > 0)
                this.currentProject.DefaultTopic = ((CHMTopic)this.defaultTopicComboBox.SelectedItem).Id.ToString();
            else
                this.currentProject.DefaultTopic = string.Empty;

            this.currentProject.FullTextSearch = fullTextSearch.Checked;

            if (IsDirty != null)
                IsDirty(this, new EventArgs());
        }

        public string ProjectName
        {
            set
            {
                this.projectName.Text = value;
            }
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.init && this.IsDirty != null)
                IsDirty(this, new EventArgs());
        }
    }
}