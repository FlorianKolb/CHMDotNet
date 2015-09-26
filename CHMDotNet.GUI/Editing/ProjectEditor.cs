using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHMDotNet.Core.Project;
using System.IO;
using CHMDotNet.Core.Settings;
using System.Drawing.Imaging;

namespace CHMDotNet.GUI.Editing
{
    public partial class ProjectEditor : UserControl
    {
        private const int FOLDER_CLOSED = 5;
        private const int FOLDER_OPEN = 6;
        private const int PAGE = 11;
        private const int LINK = 15;
        private const int PROJECT = 0;

        private TreeNode rootNode;
        private CHMProject openedProject;
        private CHMTopic currentEditedTopic;
        private bool init;

        public ProjectEditor()
        {
            InitializeComponent();
            chmTreeMenu.ImageList = chmTreeImageList;
            toolStrip1.ImageList = chmTreeImageList;
            ParseCntImages();
            newFolderBtn.ImageIndex = FOLDER_CLOSED;
            newTopicBtn.ImageIndex = PAGE;
            newLink.ImageIndex = LINK;
            neuerLinkToolStripMenuItem.ImageIndex = LINK;
            neuerOrdnerToolStripMenuItem.ImageIndex = FOLDER_CLOSED;
            neuerUntereintragToolStripMenuItem.ImageIndex = PAGE;
            htmlEditor1.HtmlChanged += htmlEditor1_HtmlChanged;
            htmlEditor1.TopicNameChanged += htmlEditor1_TopicNameChanged;
            htmlEditor1.SaveTopic += htmlEditor1_SaveTopic;
            linkSettings1.AddressChanged += linkSettings1_AddressChanged;
            projectSettings1.IsDirty += projectSettings1_IsDirty;
        }

        private void htmlEditor1_SaveTopic(object sender, EventArgs e)
        {
            ProjectManager.SaveProject(this.GetCHMProject(), this.ParentForm.Tag.ToString());
            this.Dirty = false;
        }

        private void projectSettings1_IsDirty(object sender, EventArgs e)
        {
            ProjectManager.SaveProject(this.openedProject, this.ParentForm.Tag.ToString());
        }

        private void htmlEditor1_TopicNameChanged(object sender, EventArgs e)
        {
            currentEditedTopic.TopicName = htmlEditor1.TopicName;
            this.Dirty = true;
        }

        private void linkSettings1_AddressChanged(object sender, EventArgs e)
        {
            if (!this.init)
            {
                currentEditedTopic.LinkAddress = linkSettings1.Address;
                this.Dirty = true;
            }
        }

        private void htmlEditor1_HtmlChanged(object sender, EventArgs e)
        {
            if (htmlEditor1 != null)
            {
                currentEditedTopic.Html = htmlEditor1.Html;
                this.Dirty = true;
            }
        }

        private void ParseCntImages()
        {
            iconÄndernToolStripMenuItem.DropDownItems.Add("(Auto)");

            string imagePath = Path.Combine(
                Path.Combine(RegistryManager.GetHHWInstallPath(), "java"), "cntimage.gif");

            Image cntImage = Image.FromFile(imagePath);

            using (MemoryStream stream = new MemoryStream())
            {
                cntImage.Save(stream, ImageFormat.Jpeg);

                int counter = 0;

                for (int i = 0; i < cntImage.Width; i += 16)
                {
                    Bitmap current = new Bitmap(16, 16);
                    Graphics cnt = Graphics.FromImage(current);
                    cnt.Clear(Color.White);

                    Rectangle rect = new Rectangle(new Point(i, 0), new Size(16, 16));

                    cnt.DrawImage(cntImage,
                        new Rectangle(new Point(0, 0), new Size(16, 16)), rect, GraphicsUnit.Pixel);

                    Bitmap img = Bitmap.FromHbitmap(current.GetHbitmap());
                    chmTreeImageList.Images.Add(img);
                    iconÄndernToolStripMenuItem.DropDown.Items.Add(img);
                    iconÄndernToolStripMenuItem.DropDownItems[counter].Width = 17;
                    iconÄndernToolStripMenuItem.DropDownItems[counter].Tag = counter;
                    iconÄndernToolStripMenuItem.DropDownItems[counter].Click += ChangeIcon_Click;

                    counter++;
                }
            }
        }

        public void SetRootTreeNode(CHMProject project, string name)
        {
            this.rootNode = new TreeNode(name);
            this.rootNode.ImageIndex = PROJECT;
            this.rootNode.SelectedImageIndex = PROJECT;
            chmTreeEditor.Nodes.Add(this.rootNode);

            if (project.Topics != null)
            {
                foreach (CHMTopic topic in project.Topics)
                {
                    AddTreeNodes(null, topic, true);
                }
            }

            this.chmTreeEditor.ExpandAll();
            this.openedProject = project;
            projectSettings1.SetProject(this.openedProject);
            htmlEditor1.Project = project;

            this.chmTreeEditor.SelectedNode = this.rootNode;
        }

        public void OpenProject(CHMProject chmProject)
        {
            if (chmProject != null)
                this.SetRootTreeNode(chmProject, chmProject.Name);
        }

        private void NewTopicCommand()
        {
            if (chmTreeEditor.SelectedNode != null && chmTreeEditor.SelectedNode.ImageIndex != PAGE)
            {
                TreeNode node = new TreeNode();
                node.Tag = new CHMTopic() { Name = "Neue Seite", TopicType = CHMTopic.CHMTopicType.Page, Id = Guid.NewGuid() };
                node.ImageIndex = PAGE;
                node.SelectedImageIndex = PAGE;
                node.Text = "Neue Seite";
                node.ToolTipText = BuildToolTipText((CHMTopic)node.Tag);
                chmTreeEditor.SelectedNode.Nodes.Add(node);
                projectSettings1.Visible = false;
                topicEditor.Visible = true;
                linkSettings1.Visible = false;
                chmTreeEditor.SelectedNode.Expand();
                node.BeginEdit();
                this.Dirty = true;
            }
        }

        private void NewLinkCommand()
        {
            if (chmTreeEditor.SelectedNode != null && chmTreeEditor.SelectedNode.ImageIndex != PAGE)
            {
                TreeNode node = new TreeNode();
                node.Tag = new CHMTopic() { Name = "Neuer Link", ImageNumber = LINK, TopicType = CHMTopic.CHMTopicType.Link, Id = Guid.NewGuid() };
                node.ImageIndex = LINK;
                node.SelectedImageIndex = LINK;
                node.Text = "Neuer Link";
                node.ToolTipText = BuildToolTipText((CHMTopic)node.Tag);

                projectSettings1.Visible = false;
                topicEditor.Visible = false;
                linkSettings1.Visible = true;

                chmTreeEditor.SelectedNode.Nodes.Add(node);
                chmTreeEditor.SelectedNode.Expand();
                node.BeginEdit();
                this.Dirty = true;
            }
        }

        private void neuerUntereintragToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTopicCommand();
        }

        private void chmTreeEditor_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null)
            {
                if (!string.Equals(e.Node.Text, e.Label))
                {
                    //Beim Bearbeiten des obersten Knotens den Namen des Projektes neu setzen
                    if (e.Node.Parent == null)
                    {
                        this.openedProject.Name = e.Label;
                        this.projectSettings1.ProjectName = e.Label;
                        this.Parent.Text = e.Label;
                    }
                    else
                    {
                        CHMTopic topic = (CHMTopic)e.Node.Tag;
                        topic.Name = e.Label;
                    }

                    e.CancelEdit = false;
                    this.Dirty = true;
                }
                else
                    e.CancelEdit = true;
            }
        }

        private void DeleteItemCommand()
        {
            if (chmTreeEditor.SelectedNode != null && chmTreeEditor.SelectedNode.Parent != null)
            {
                CHMTopic topic = (CHMTopic)chmTreeEditor.SelectedNode.Tag;
                if (MessageBox.Show(string.Concat("Soll \"", topic.Name, "\" wirklich gelöscht werden?" +
                    " Der Inhalt ist nicht wiederherstellbar!"), "CHMDotNet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Wenn Keywords für das Topic gesetzt sind, diese Keywords
                    //aus dem Projekt löschen
                    if (openedProject.Keywords != null)
                        RemoveKeywords(topic);

                    //Topic löschen
                    chmTreeEditor.Nodes.Remove(chmTreeEditor.SelectedNode);
                    this.Dirty = true;
                }
            }
        }

        private void RemoveKeywords(CHMTopic topic)
        {
            openedProject.Keywords = openedProject.Keywords.Where(p => !p.Id.Equals(topic.Id)).ToList();

            if (topic.Children != null && topic.Children.Count > 0)
                foreach (CHMTopic child in topic.Children)
                    RemoveKeywords(child);
        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItemCommand();
        }

        public CHMProject GetCHMProject()
        {
            this.openedProject.Name = chmTreeEditor.Nodes[0].Text;
            this.openedProject.Topics = ConvertTreeNodesToCHMTopics(chmTreeEditor.Nodes[0]);
            return this.openedProject;
        }

        private List<CHMTopic> ConvertTreeNodesToCHMTopics(TreeNode parent)
        {
            List<CHMTopic> result = new List<CHMTopic>();

            foreach (TreeNode node in parent.Nodes)
            {
                CHMTopic topic = (CHMTopic)node.Tag;
                topic.Name = node.Text;
                topic.TopicType = ((CHMTopic)node.Tag).TopicType;

                topic.Children = new List<CHMTopic>();

                if (node.Nodes.Count > 0)
                    topic.Children = ConvertTreeNodesToCHMTopics(node);

                result.Add(topic);
            }

            return result;
        }

        private string BuildToolTipText(CHMTopic topic)
        {
            string type = string.Empty;
            switch (topic.TopicType)
            {
                case CHMTopic.CHMTopicType.Folder:
                    type = "Ordner";
                    break;
                case CHMTopic.CHMTopicType.Link:
                    type = "Link";
                    break;
                case CHMTopic.CHMTopicType.Page:
                    type = "Seite";
                    break;
            }

            return string.Concat("Typ: ", type, "\nURL: ", topic.Id.ToString(), ".htm");
        }

        private void AddTreeNodes(TreeNode parent, CHMTopic topic, bool first)
        {
            if (first)
            {
                TreeNode current = new TreeNode(topic.Name);
                current.ToolTipText = BuildToolTipText(topic);
                chmTreeEditor.Nodes[0].Nodes.Add(current);

                if (topic.TopicType == CHMTopic.CHMTopicType.Folder)
                {
                    current.Tag = topic;

                    if (topic.ImageNumber == 0)
                    {
                        current.ImageIndex = FOLDER_OPEN;
                        current.SelectedImageIndex = FOLDER_OPEN;
                    }
                    else
                    {
                        current.ImageIndex = topic.ImageNumber;
                        current.SelectedImageIndex = topic.ImageNumber;
                    }

                    foreach (CHMTopic child in topic.Children)
                        AddTreeNodes(current, child, false);
                }
                else if (topic.TopicType == CHMTopic.CHMTopicType.Page)
                {
                    current.Tag = topic;

                    if (topic.ImageNumber == 0)
                    {
                        current.ImageIndex = PAGE;
                        current.SelectedImageIndex = PAGE;
                    }
                    else
                    {
                        current.ImageIndex = topic.ImageNumber;
                        current.SelectedImageIndex = topic.ImageNumber;
                    }
                }
                else if (topic.TopicType == CHMTopic.CHMTopicType.Link)
                {
                    current.Tag = topic;

                    if (topic.ImageNumber == 0)
                    {
                        current.ImageIndex = LINK;
                        current.SelectedImageIndex = LINK;
                    }
                    else
                    {
                        current.ImageIndex = topic.ImageNumber;
                        current.SelectedImageIndex = topic.ImageNumber;
                    }
                }
            }
            else
            {
                TreeNode current = new TreeNode(topic.Name);
                current.ToolTipText = BuildToolTipText(topic);

                parent.Nodes.Add(current);

                if (topic.TopicType == CHMTopic.CHMTopicType.Folder)
                {
                    current.Tag = topic;

                    if (topic.ImageNumber == 0)
                    {
                        current.ImageIndex = FOLDER_OPEN;
                        current.SelectedImageIndex = FOLDER_OPEN;
                    }
                    else
                    {
                        current.ImageIndex = topic.ImageNumber;
                        current.SelectedImageIndex = topic.ImageNumber;
                    }

                    foreach (CHMTopic child in topic.Children)
                        AddTreeNodes(current, child, false);
                }
                else if (topic.TopicType == CHMTopic.CHMTopicType.Page)
                {
                    current.Tag = topic;

                    if (topic.ImageNumber == 0)
                    {
                        current.ImageIndex = PAGE;
                        current.SelectedImageIndex = PAGE;
                    }
                    else
                    {
                        current.ImageIndex = topic.ImageNumber;
                        current.SelectedImageIndex = topic.ImageNumber;
                    }
                }
                else if (topic.TopicType == CHMTopic.CHMTopicType.Link)
                {
                    current.Tag = topic;

                    if (topic.ImageNumber == 0)
                    {
                        current.ImageIndex = LINK;
                        current.SelectedImageIndex = LINK;
                    }
                    else
                    {
                        current.ImageIndex = topic.ImageNumber;
                        current.SelectedImageIndex = topic.ImageNumber;
                    }
                }
            }
        }

        private void NewFolderCommand()
        {
            if (chmTreeEditor.SelectedNode != null && chmTreeEditor.SelectedNode.ImageIndex != PAGE)
            {
                TreeNode node = new TreeNode();
                node.ImageIndex = FOLDER_CLOSED;
                node.SelectedImageIndex = FOLDER_CLOSED;
                node.Tag = new CHMTopic() { Name = "Neuer Ordner", TopicType = CHMTopic.CHMTopicType.Folder, Id = Guid.NewGuid() };
                node.Text = "Neuer Ordner";
                node.ToolTipText = BuildToolTipText((CHMTopic)node.Tag);
                chmTreeEditor.SelectedNode.Nodes.Add(node);
                projectSettings1.Visible = false;
                topicEditor.Visible = true;
                linkSettings1.Visible = false;
                chmTreeEditor.SelectedNode.Expand();
                node.BeginEdit();
                this.Dirty = true;
            }
        }

        private void neuerOrdnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFolderCommand();
        }

        private void chmTreeEditor_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.ImageIndex == FOLDER_CLOSED)
            {
                e.Node.ImageIndex = FOLDER_OPEN;
                e.Node.SelectedImageIndex = FOLDER_OPEN;
            }
        }

        private void chmTreeEditor_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.ImageIndex == FOLDER_OPEN)
            {
                e.Node.ImageIndex = FOLDER_CLOSED;
                e.Node.SelectedImageIndex = FOLDER_CLOSED;
            }
        }

        private void RenameCommand()
        {
            if (chmTreeEditor.SelectedNode != null)
                chmTreeEditor.SelectedNode.BeginEdit();
        }

        private void umbenennenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenameCommand();
        }

        private void newTopicBtn_Click(object sender, EventArgs e)
        {
            NewTopicCommand();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteItemCommand();
        }

        private void renameBtn_Click(object sender, EventArgs e)
        {
            RenameCommand();
        }

        private bool isDirty;
        public bool Dirty
        {
            get { return this.isDirty; }
            set
            {
                if (!this.init && this.ParentForm != null)
                {
                    this.isDirty = value;

                    if (value)
                        projectSettings1.ReloadTopics();

                    if (!value && currentEditedTopic != null && currentEditedTopic.TopicType != CHMTopic.CHMTopicType.Link)
                        htmlEditor1.Saved();

                    if (!this.ParentForm.Text.EndsWith("*") && value)
                        this.ParentForm.Text += "*";

                    if (this.ParentForm.Text.EndsWith("*") && !value)
                        this.ParentForm.Text = this.ParentForm.Text.Remove(this.ParentForm.Text.Length - 1, 1);

                    ((MainWindow)this.ParentForm.ParentForm).Dirty = value;
                }
            }
        }

        private void newFolderBtn_Click(object sender, EventArgs e)
        {
            NewFolderCommand();
        }

        private void chmTreeEditor_AfterSelect(object sender, TreeViewEventArgs e)
        {
            CHMTopic topic = (CHMTopic)e.Node.Tag;

            if (e.Node.Parent != null)
            {
                this.init = true;
                projectSettings1.Visible = false;

                neuerOrdnerToolStripMenuItem.Enabled = topic.TopicType == CHMTopic.CHMTopicType.Folder;
                neuerUntereintragToolStripMenuItem.Enabled = topic.TopicType == CHMTopic.CHMTopicType.Folder;
                newFolderBtn.Enabled = topic.TopicType == CHMTopic.CHMTopicType.Folder;
                newTopicBtn.Enabled = topic.TopicType == CHMTopic.CHMTopicType.Folder;
                newLink.Enabled = topic.TopicType == CHMTopic.CHMTopicType.Folder;
                neuerLinkToolStripMenuItem.Enabled = topic.TopicType == CHMTopic.CHMTopicType.Folder;

                löschenToolStripMenuItem.Enabled = true;
                deleteBtn.Enabled = true;

                if (topic.TopicType != CHMTopic.CHMTopicType.Link)
                {
                    linkSettings1.Visible = false;
                    topicEditor.Visible = true;
                    htmlEditor1.InitEditor(topic.Html, topic.TopicName);
                }
                else if (topic.TopicType == CHMTopic.CHMTopicType.Link)
                {
                    linkSettings1.Visible = true;

                    if (!string.IsNullOrEmpty(topic.LinkAddress))
                        linkSettings1.Address = topic.LinkAddress;
                    topicEditor.Visible = false;
                }

                this.currentEditedTopic = topic;
                topicEditor.Enabled = true;
                iconÄndernToolStripMenuItem.Enabled = true;

                keywordsListBox.Items.Clear();
                keywordTextbox.Text = string.Empty;

                if (this.openedProject.Keywords != null && topic.TopicType != CHMTopic.CHMTopicType.Link)
                    foreach (CHMKeyword keyword in this.openedProject.Keywords.Where(p => p.Id.Equals(this.currentEditedTopic.Id)))
                        keywordsListBox.Items.Add(keyword);

                if (topic.TopicType != CHMTopic.CHMTopicType.Link)
                    htmlEditor1.StartDirtTracking();
                this.init = false;
            }
            else
            {
                projectSettings1.Visible = true;
                topicEditor.Visible = false;
                linkSettings1.Visible = false;

                neuerOrdnerToolStripMenuItem.Enabled = true;
                neuerUntereintragToolStripMenuItem.Enabled = true;
                löschenToolStripMenuItem.Enabled = false;
                deleteBtn.Enabled = false;
                newFolderBtn.Enabled = true;
                newTopicBtn.Enabled = true;
                iconÄndernToolStripMenuItem.Enabled = false;
                neuerLinkToolStripMenuItem.Enabled = true;
                newLink.Enabled = true;

                htmlEditor1.StopDirtTracking();
            }
        }

        private void addKeyword_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(keywordTextbox.Text))
            {
                CHMKeyword keyword = new CHMKeyword() { Keyword = keywordTextbox.Text, Id = currentEditedTopic.Id };
                keywordsListBox.Items.Add(keyword);

                if (openedProject.Keywords == null)
                    openedProject.Keywords = new List<CHMKeyword>();

                openedProject.Keywords.Add(keyword);
                this.Dirty = true;
            }
        }

        private void chmTreeEditor_ItemDrag(object sender, ItemDragEventArgs e)
        {
            TreeNode selectedNode = (TreeNode)e.Item;

            if (selectedNode.Parent != null)
                DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void chmTreeEditor_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void chmTreeEditor_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                Point pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
                TreeNode DestinationNode = ((TreeView)sender).GetNodeAt(pt);
                NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

                CHMTopic dest = null;
                CHMTopic source = (CHMTopic)NewNode.Tag;

                if (DestinationNode.Parent != null)
                    dest = (CHMTopic)DestinationNode.Tag;

                if (DestinationNode.TreeView == NewNode.TreeView
                    && (dest != null && dest.TopicType == CHMTopic.CHMTopicType.Folder) || dest == null)
                {
                    DestinationNode.Nodes.Add((TreeNode)NewNode.Clone());
                    DestinationNode.Expand();
                    //Remove Original Node
                    NewNode.Remove();

                    this.Dirty = true;
                }
            }
        }

        private void ChangeIcon_Click(object sender, EventArgs e)
        {
            ToolStripItem current = (ToolStripItem)sender;

            if (currentEditedTopic != null)
            {
                currentEditedTopic.ImageNumber = (int)current.Tag;

                TreeNode selectedNode = chmTreeEditor.SelectedNode;
                if ((int)current.Tag > 0)
                {
                    selectedNode.SelectedImageIndex = (int)current.Tag;
                    selectedNode.ImageIndex = (int)current.Tag;
                }
                else
                {
                    if (currentEditedTopic.TopicType == CHMTopic.CHMTopicType.Folder && selectedNode.IsExpanded)
                    {
                        selectedNode.ImageIndex = FOLDER_OPEN;
                        selectedNode.SelectedImageIndex = FOLDER_OPEN;
                    }
                    else if (currentEditedTopic.TopicType == CHMTopic.CHMTopicType.Folder && !selectedNode.IsExpanded)
                    {
                        selectedNode.ImageIndex = FOLDER_CLOSED;
                        selectedNode.SelectedImageIndex = FOLDER_CLOSED;
                    }
                    else if (currentEditedTopic.TopicType == CHMTopic.CHMTopicType.Link)
                    {
                        selectedNode.ImageIndex = LINK;
                        selectedNode.SelectedImageIndex = LINK;
                        currentEditedTopic.ImageNumber = LINK;
                    }
                    else
                    {
                        selectedNode.ImageIndex = PAGE;
                        selectedNode.SelectedImageIndex = PAGE;
                    }
                }

                this.Dirty = true;
            }
        }

        private void deleteKeyword_Click(object sender, EventArgs e)
        {
            if (keywordsListBox.SelectedItem != null)
            {
                openedProject.Keywords.Remove((CHMKeyword)keywordsListBox.SelectedItem);
                keywordsListBox.Items.Remove(keywordsListBox.SelectedItem);
                this.Dirty = true;
            }
        }

        private void newLink_Click(object sender, EventArgs e)
        {
            NewLinkCommand();
        }

        private void neuerLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLinkCommand();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (keywordsListBox.SelectedItem != null)
            {
                EditKeyword edit = new EditKeyword((CHMKeyword)keywordsListBox.SelectedItem);
                edit.KeywordEdited -= edit_KeywordEdited;
                edit.KeywordEdited += edit_KeywordEdited;
                edit.ShowDialog();
            }
        }

        private void edit_KeywordEdited(bool changed, CHMKeyword oldKeyword, CHMKeyword newKeyword)
        {
            if (changed)
            {
                openedProject.Keywords[openedProject.Keywords.IndexOf(oldKeyword)] = newKeyword;
                keywordsListBox.Items[keywordsListBox.Items.IndexOf(oldKeyword)] = newKeyword;
                this.Dirty = true;
            }
        }
    }
}