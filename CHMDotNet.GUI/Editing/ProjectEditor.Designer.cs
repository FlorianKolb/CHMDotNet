namespace CHMDotNet.GUI.Editing
{
    partial class ProjectEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectEditor));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newFolderBtn = new System.Windows.Forms.ToolStripButton();
            this.newTopicBtn = new System.Windows.Forms.ToolStripButton();
            this.newLink = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.renameBtn = new System.Windows.Forms.ToolStripButton();
            this.chmTreeEditor = new System.Windows.Forms.TreeView();
            this.chmTreeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.neuerOrdnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuerUntereintragToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuerLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.iconÄndernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.umbenennenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chmTreeImageList = new System.Windows.Forms.ImageList(this.components);
            this.topicEditor = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteKeyword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addKeyword = new System.Windows.Forms.Button();
            this.keywordTextbox = new System.Windows.Forms.TextBox();
            this.keywordsListBox = new System.Windows.Forms.ListBox();
            this.htmlEditor1 = new CHMDotNet.HtmlEditor.HtmlEditor();
            this.linkSettings1 = new CHMDotNet.GUI.Editing.LinkSettings();
            this.projectSettings1 = new CHMDotNet.GUI.Editing.ProjectSettings();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.chmTreeMenu.SuspendLayout();
            this.topicEditor.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.linkSettings1);
            this.splitContainer1.Panel2.Controls.Add(this.topicEditor);
            this.splitContainer1.Panel2.Controls.Add(this.projectSettings1);
            this.splitContainer1.Size = new System.Drawing.Size(646, 399);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.chmTreeEditor);
            this.splitContainer3.Size = new System.Drawing.Size(215, 399);
            this.splitContainer3.SplitterDistance = 26;
            this.splitContainer3.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFolderBtn,
            this.newTopicBtn,
            this.newLink,
            this.toolStripSeparator2,
            this.deleteBtn,
            this.toolStripSeparator3,
            this.renameBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(215, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newFolderBtn
            // 
            this.newFolderBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newFolderBtn.Image = ((System.Drawing.Image)(resources.GetObject("newFolderBtn.Image")));
            this.newFolderBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFolderBtn.Name = "newFolderBtn";
            this.newFolderBtn.Size = new System.Drawing.Size(23, 23);
            this.newFolderBtn.ToolTipText = "Neuer Ordner";
            this.newFolderBtn.Click += new System.EventHandler(this.newFolderBtn_Click);
            // 
            // newTopicBtn
            // 
            this.newTopicBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newTopicBtn.Image = ((System.Drawing.Image)(resources.GetObject("newTopicBtn.Image")));
            this.newTopicBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newTopicBtn.Name = "newTopicBtn";
            this.newTopicBtn.Size = new System.Drawing.Size(23, 23);
            this.newTopicBtn.ToolTipText = "Neue Seite";
            this.newTopicBtn.Click += new System.EventHandler(this.newTopicBtn_Click);
            // 
            // newLink
            // 
            this.newLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newLink.Image = ((System.Drawing.Image)(resources.GetObject("newLink.Image")));
            this.newLink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newLink.Name = "newLink";
            this.newLink.Size = new System.Drawing.Size(23, 23);
            this.newLink.ToolTipText = "Neuer Link";
            this.newLink.Click += new System.EventHandler(this.newLink_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // deleteBtn
            // 
            this.deleteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(23, 23);
            this.deleteBtn.ToolTipText = "Löschen";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // renameBtn
            // 
            this.renameBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.renameBtn.Image = ((System.Drawing.Image)(resources.GetObject("renameBtn.Image")));
            this.renameBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.renameBtn.Name = "renameBtn";
            this.renameBtn.Size = new System.Drawing.Size(23, 23);
            this.renameBtn.ToolTipText = "Umbenennen";
            this.renameBtn.Click += new System.EventHandler(this.renameBtn_Click);
            // 
            // chmTreeEditor
            // 
            this.chmTreeEditor.AllowDrop = true;
            this.chmTreeEditor.ContextMenuStrip = this.chmTreeMenu;
            this.chmTreeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chmTreeEditor.ImageIndex = 0;
            this.chmTreeEditor.ImageList = this.chmTreeImageList;
            this.chmTreeEditor.LabelEdit = true;
            this.chmTreeEditor.Location = new System.Drawing.Point(0, 0);
            this.chmTreeEditor.Name = "chmTreeEditor";
            this.chmTreeEditor.SelectedImageIndex = 0;
            this.chmTreeEditor.ShowNodeToolTips = true;
            this.chmTreeEditor.Size = new System.Drawing.Size(215, 369);
            this.chmTreeEditor.TabIndex = 0;
            this.chmTreeEditor.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.chmTreeEditor_AfterLabelEdit);
            this.chmTreeEditor.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.chmTreeEditor_BeforeCollapse);
            this.chmTreeEditor.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.chmTreeEditor_BeforeExpand);
            this.chmTreeEditor.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.chmTreeEditor_ItemDrag);
            this.chmTreeEditor.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.chmTreeEditor_AfterSelect);
            this.chmTreeEditor.DragDrop += new System.Windows.Forms.DragEventHandler(this.chmTreeEditor_DragDrop);
            this.chmTreeEditor.DragEnter += new System.Windows.Forms.DragEventHandler(this.chmTreeEditor_DragEnter);
            // 
            // chmTreeMenu
            // 
            this.chmTreeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuerOrdnerToolStripMenuItem,
            this.neuerUntereintragToolStripMenuItem,
            this.neuerLinkToolStripMenuItem,
            this.toolStripMenuItem2,
            this.iconÄndernToolStripMenuItem,
            this.toolStripSeparator1,
            this.löschenToolStripMenuItem,
            this.toolStripMenuItem1,
            this.umbenennenToolStripMenuItem});
            this.chmTreeMenu.Name = "chmTreeMenu";
            this.chmTreeMenu.Size = new System.Drawing.Size(166, 154);
            // 
            // neuerOrdnerToolStripMenuItem
            // 
            this.neuerOrdnerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("neuerOrdnerToolStripMenuItem.Image")));
            this.neuerOrdnerToolStripMenuItem.Name = "neuerOrdnerToolStripMenuItem";
            this.neuerOrdnerToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.neuerOrdnerToolStripMenuItem.Text = "Neuer Ordner";
            this.neuerOrdnerToolStripMenuItem.Click += new System.EventHandler(this.neuerOrdnerToolStripMenuItem_Click);
            // 
            // neuerUntereintragToolStripMenuItem
            // 
            this.neuerUntereintragToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("neuerUntereintragToolStripMenuItem.Image")));
            this.neuerUntereintragToolStripMenuItem.Name = "neuerUntereintragToolStripMenuItem";
            this.neuerUntereintragToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.neuerUntereintragToolStripMenuItem.Text = "Neue Seite";
            this.neuerUntereintragToolStripMenuItem.Click += new System.EventHandler(this.neuerUntereintragToolStripMenuItem_Click);
            // 
            // neuerLinkToolStripMenuItem
            // 
            this.neuerLinkToolStripMenuItem.Name = "neuerLinkToolStripMenuItem";
            this.neuerLinkToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.neuerLinkToolStripMenuItem.Text = "Neuer Link";
            this.neuerLinkToolStripMenuItem.Click += new System.EventHandler(this.neuerLinkToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 6);
            // 
            // iconÄndernToolStripMenuItem
            // 
            this.iconÄndernToolStripMenuItem.Name = "iconÄndernToolStripMenuItem";
            this.iconÄndernToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.iconÄndernToolStripMenuItem.Text = "Icon ändern";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("löschenToolStripMenuItem.Image")));
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 6);
            // 
            // umbenennenToolStripMenuItem
            // 
            this.umbenennenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("umbenennenToolStripMenuItem.Image")));
            this.umbenennenToolStripMenuItem.Name = "umbenennenToolStripMenuItem";
            this.umbenennenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.umbenennenToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.umbenennenToolStripMenuItem.Text = "Umbenennen";
            this.umbenennenToolStripMenuItem.Click += new System.EventHandler(this.umbenennenToolStripMenuItem_Click);
            // 
            // chmTreeImageList
            // 
            this.chmTreeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("chmTreeImageList.ImageStream")));
            this.chmTreeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.chmTreeImageList.Images.SetKeyName(0, "project.png");
            // 
            // topicEditor
            // 
            this.topicEditor.Controls.Add(this.tab1);
            this.topicEditor.Controls.Add(this.tabPage2);
            this.topicEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topicEditor.Location = new System.Drawing.Point(0, 0);
            this.topicEditor.Name = "topicEditor";
            this.topicEditor.SelectedIndex = 0;
            this.topicEditor.Size = new System.Drawing.Size(427, 399);
            this.topicEditor.TabIndex = 2;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.htmlEditor1);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(419, 373);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Inhalt";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.editBtn);
            this.tabPage2.Controls.Add(this.deleteKeyword);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.addKeyword);
            this.tabPage2.Controls.Add(this.keywordTextbox);
            this.tabPage2.Controls.Add(this.keywordsListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(419, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Keywords";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBtn.Location = new System.Drawing.Point(250, 120);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(68, 23);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Ändern";
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteKeyword
            // 
            this.deleteKeyword.Image = ((System.Drawing.Image)(resources.GetObject("deleteKeyword.Image")));
            this.deleteKeyword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteKeyword.Location = new System.Drawing.Point(323, 120);
            this.deleteKeyword.Name = "deleteKeyword";
            this.deleteKeyword.Size = new System.Drawing.Size(75, 23);
            this.deleteKeyword.TabIndex = 4;
            this.deleteKeyword.Text = "Löschen";
            this.deleteKeyword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteKeyword.UseVisualStyleBackColor = true;
            this.deleteKeyword.Click += new System.EventHandler(this.deleteKeyword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Keyword:";
            // 
            // addKeyword
            // 
            this.addKeyword.Image = ((System.Drawing.Image)(resources.GetObject("addKeyword.Image")));
            this.addKeyword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addKeyword.Location = new System.Drawing.Point(159, 120);
            this.addKeyword.Name = "addKeyword";
            this.addKeyword.Size = new System.Drawing.Size(85, 23);
            this.addKeyword.TabIndex = 2;
            this.addKeyword.Text = "Hinzufügen";
            this.addKeyword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addKeyword.UseVisualStyleBackColor = true;
            this.addKeyword.Click += new System.EventHandler(this.addKeyword_Click);
            // 
            // keywordTextbox
            // 
            this.keywordTextbox.Location = new System.Drawing.Point(63, 122);
            this.keywordTextbox.Name = "keywordTextbox";
            this.keywordTextbox.Size = new System.Drawing.Size(90, 20);
            this.keywordTextbox.TabIndex = 1;
            // 
            // keywordsListBox
            // 
            this.keywordsListBox.FormattingEnabled = true;
            this.keywordsListBox.Location = new System.Drawing.Point(8, 8);
            this.keywordsListBox.Name = "keywordsListBox";
            this.keywordsListBox.Size = new System.Drawing.Size(390, 108);
            this.keywordsListBox.TabIndex = 0;
            // 
            // htmlEditor1
            // 
            this.htmlEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlEditor1.Init = false;
            this.htmlEditor1.Location = new System.Drawing.Point(3, 3);
            this.htmlEditor1.Name = "htmlEditor1";
            this.htmlEditor1.Project = null;
            this.htmlEditor1.Size = new System.Drawing.Size(413, 367);
            this.htmlEditor1.TabIndex = 0;
            // 
            // linkSettings1
            // 
            this.linkSettings1.Address = "";
            this.linkSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkSettings1.Location = new System.Drawing.Point(0, 0);
            this.linkSettings1.Name = "linkSettings1";
            this.linkSettings1.Size = new System.Drawing.Size(427, 399);
            this.linkSettings1.TabIndex = 1;
            this.linkSettings1.Visible = false;
            // 
            // projectSettings1
            // 
            this.projectSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectSettings1.Location = new System.Drawing.Point(0, 0);
            this.projectSettings1.Name = "projectSettings1";
            this.projectSettings1.Size = new System.Drawing.Size(427, 399);
            this.projectSettings1.TabIndex = 1;
            // 
            // ProjectEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ProjectEditor";
            this.Size = new System.Drawing.Size(646, 399);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.chmTreeMenu.ResumeLayout(false);
            this.topicEditor.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView chmTreeEditor;
        private System.Windows.Forms.ContextMenuStrip chmTreeMenu;
        private System.Windows.Forms.ToolStripMenuItem neuerUntereintragToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuerOrdnerToolStripMenuItem;
        private System.Windows.Forms.ImageList chmTreeImageList;
        private System.Windows.Forms.ToolStripMenuItem umbenennenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newFolderBtn;
        private System.Windows.Forms.ToolStripButton newTopicBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton deleteBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton renameBtn;
        private CHMDotNet.HtmlEditor.HtmlEditor htmlEditor1;
        private System.Windows.Forms.Button addKeyword;
        private System.Windows.Forms.TextBox keywordTextbox;
        private System.Windows.Forms.ListBox keywordsListBox;
        private ProjectSettings projectSettings1;
        private System.Windows.Forms.TabControl topicEditor;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem iconÄndernToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteKeyword;
        private System.Windows.Forms.ToolStripButton newLink;
        private System.Windows.Forms.ToolStripMenuItem neuerLinkToolStripMenuItem;
        private LinkSettings linkSettings1;
        private System.Windows.Forms.Button editBtn;
    }
}
