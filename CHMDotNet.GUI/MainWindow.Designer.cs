namespace CHMDotNet.GUI
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesProjektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektSpeichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektSchließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.zuletztGeöffnetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kompilierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fensterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.alleMaximierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alleWiederherstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alleMinimierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.horizontalAnordnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vertikalAnordnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hintereinanderAnordnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.infoÜberCHMDotNetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newProjectBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileBtn = new System.Windows.Forms.ToolStripButton();
            this.saveProjectBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.compileBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutBtn = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.projektToolStripMenuItem,
            this.extrasToolStripMenuItem,
            this.fensterToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesProjektToolStripMenuItem,
            this.projektÖffnenToolStripMenuItem,
            this.projektSpeichernToolStripMenuItem,
            this.projektSchließenToolStripMenuItem,
            this.toolStripMenuItem1,
            this.zuletztGeöffnetToolStripMenuItem,
            this.toolStripSeparator1,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuesProjektToolStripMenuItem
            // 
            this.neuesProjektToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("neuesProjektToolStripMenuItem.Image")));
            this.neuesProjektToolStripMenuItem.Name = "neuesProjektToolStripMenuItem";
            this.neuesProjektToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.neuesProjektToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.neuesProjektToolStripMenuItem.Text = "Neues Projekt";
            this.neuesProjektToolStripMenuItem.Click += new System.EventHandler(this.neuesProjektToolStripMenuItem_Click);
            // 
            // projektÖffnenToolStripMenuItem
            // 
            this.projektÖffnenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("projektÖffnenToolStripMenuItem.Image")));
            this.projektÖffnenToolStripMenuItem.Name = "projektÖffnenToolStripMenuItem";
            this.projektÖffnenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.projektÖffnenToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.projektÖffnenToolStripMenuItem.Text = "Projekt öffnen...";
            this.projektÖffnenToolStripMenuItem.Click += new System.EventHandler(this.projektÖffnenToolStripMenuItem_Click);
            // 
            // projektSpeichernToolStripMenuItem
            // 
            this.projektSpeichernToolStripMenuItem.Enabled = false;
            this.projektSpeichernToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("projektSpeichernToolStripMenuItem.Image")));
            this.projektSpeichernToolStripMenuItem.Name = "projektSpeichernToolStripMenuItem";
            this.projektSpeichernToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.projektSpeichernToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.projektSpeichernToolStripMenuItem.Text = "Projekt speichern";
            this.projektSpeichernToolStripMenuItem.Click += new System.EventHandler(this.projektSpeichernToolStripMenuItem_Click);
            // 
            // projektSchließenToolStripMenuItem
            // 
            this.projektSchließenToolStripMenuItem.Name = "projektSchließenToolStripMenuItem";
            this.projektSchließenToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.projektSchließenToolStripMenuItem.Text = "Projekt schließen";
            this.projektSchließenToolStripMenuItem.Click += new System.EventHandler(this.projektSchließenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(202, 6);
            // 
            // zuletztGeöffnetToolStripMenuItem
            // 
            this.zuletztGeöffnetToolStripMenuItem.Name = "zuletztGeöffnetToolStripMenuItem";
            this.zuletztGeöffnetToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.zuletztGeöffnetToolStripMenuItem.Text = "Zuletzt geöffnet";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // projektToolStripMenuItem
            // 
            this.projektToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kompilierenToolStripMenuItem});
            this.projektToolStripMenuItem.Name = "projektToolStripMenuItem";
            this.projektToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projektToolStripMenuItem.Text = "Projekt";
            // 
            // kompilierenToolStripMenuItem
            // 
            this.kompilierenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kompilierenToolStripMenuItem.Image")));
            this.kompilierenToolStripMenuItem.Name = "kompilierenToolStripMenuItem";
            this.kompilierenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.kompilierenToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.kompilierenToolStripMenuItem.Text = "Kompilieren...";
            this.kompilierenToolStripMenuItem.Click += new System.EventHandler(this.kompilierenToolStripMenuItem_Click);
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionenToolStripMenuItem});
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.extrasToolStripMenuItem.Text = "Extras";
            // 
            // optionenToolStripMenuItem
            // 
            this.optionenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("optionenToolStripMenuItem.Image")));
            this.optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
            this.optionenToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.optionenToolStripMenuItem.Text = "Einstellungen";
            this.optionenToolStripMenuItem.Click += new System.EventHandler(this.optionenToolStripMenuItem_Click);
            // 
            // fensterToolStripMenuItem
            // 
            this.fensterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.alleMaximierenToolStripMenuItem,
            this.alleWiederherstellenToolStripMenuItem,
            this.alleMinimierenToolStripMenuItem,
            this.toolStripMenuItem2,
            this.horizontalAnordnenToolStripMenuItem,
            this.vertikalAnordnenToolStripMenuItem,
            this.hintereinanderAnordnenToolStripMenuItem});
            this.fensterToolStripMenuItem.Name = "fensterToolStripMenuItem";
            this.fensterToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.fensterToolStripMenuItem.Text = "Fenster";
            this.fensterToolStripMenuItem.DropDownOpening += new System.EventHandler(this.fensterToolStripMenuItem_DropDownOpening);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(204, 6);
            // 
            // alleMaximierenToolStripMenuItem
            // 
            this.alleMaximierenToolStripMenuItem.Name = "alleMaximierenToolStripMenuItem";
            this.alleMaximierenToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.alleMaximierenToolStripMenuItem.Text = "Alle maximieren";
            this.alleMaximierenToolStripMenuItem.Click += new System.EventHandler(this.alleMaximierenToolStripMenuItem_Click);
            // 
            // alleWiederherstellenToolStripMenuItem
            // 
            this.alleWiederherstellenToolStripMenuItem.Name = "alleWiederherstellenToolStripMenuItem";
            this.alleWiederherstellenToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.alleWiederherstellenToolStripMenuItem.Text = "Alle wiederherstellen";
            this.alleWiederherstellenToolStripMenuItem.Click += new System.EventHandler(this.alleWiederherstellenToolStripMenuItem_Click);
            // 
            // alleMinimierenToolStripMenuItem
            // 
            this.alleMinimierenToolStripMenuItem.Name = "alleMinimierenToolStripMenuItem";
            this.alleMinimierenToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.alleMinimierenToolStripMenuItem.Text = "Alle minimieren";
            this.alleMinimierenToolStripMenuItem.Click += new System.EventHandler(this.alleMinimierenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(204, 6);
            // 
            // horizontalAnordnenToolStripMenuItem
            // 
            this.horizontalAnordnenToolStripMenuItem.Name = "horizontalAnordnenToolStripMenuItem";
            this.horizontalAnordnenToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.horizontalAnordnenToolStripMenuItem.Text = "Horizontal anordnen";
            this.horizontalAnordnenToolStripMenuItem.Click += new System.EventHandler(this.horizontalAnordnenToolStripMenuItem_Click);
            // 
            // vertikalAnordnenToolStripMenuItem
            // 
            this.vertikalAnordnenToolStripMenuItem.Name = "vertikalAnordnenToolStripMenuItem";
            this.vertikalAnordnenToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.vertikalAnordnenToolStripMenuItem.Text = "Vertikal anordnen";
            this.vertikalAnordnenToolStripMenuItem.Click += new System.EventHandler(this.vertikalAnordnenToolStripMenuItem_Click);
            // 
            // hintereinanderAnordnenToolStripMenuItem
            // 
            this.hintereinanderAnordnenToolStripMenuItem.Name = "hintereinanderAnordnenToolStripMenuItem";
            this.hintereinanderAnordnenToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.hintereinanderAnordnenToolStripMenuItem.Text = "Hintereinander anordnen";
            this.hintereinanderAnordnenToolStripMenuItem.Click += new System.EventHandler(this.hintereinanderAnordnenToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hilfeToolStripMenuItem1,
            this.toolStripMenuItem4,
            this.infoÜberCHMDotNetToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // hilfeToolStripMenuItem1
            // 
            this.hilfeToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("hilfeToolStripMenuItem1.Image")));
            this.hilfeToolStripMenuItem1.Name = "hilfeToolStripMenuItem1";
            this.hilfeToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.hilfeToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.hilfeToolStripMenuItem1.Text = "Hilfe";
            this.hilfeToolStripMenuItem1.Click += new System.EventHandler(this.hilfeToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(188, 6);
            // 
            // infoÜberCHMDotNetToolStripMenuItem
            // 
            this.infoÜberCHMDotNetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("infoÜberCHMDotNetToolStripMenuItem.Image")));
            this.infoÜberCHMDotNetToolStripMenuItem.Name = "infoÜberCHMDotNetToolStripMenuItem";
            this.infoÜberCHMDotNetToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.infoÜberCHMDotNetToolStripMenuItem.Text = "Info über CHMDotNet";
            this.infoÜberCHMDotNetToolStripMenuItem.Click += new System.EventHandler(this.infoÜberCHMDotNetToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 356);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(699, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectBtn,
            this.toolStripSeparator2,
            this.openFileBtn,
            this.saveProjectBtn,
            this.toolStripSeparator3,
            this.compileBtn,
            this.toolStripSeparator4,
            this.preferencesBtn,
            this.toolStripSeparator5,
            this.aboutBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(699, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newProjectBtn
            // 
            this.newProjectBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newProjectBtn.Image = ((System.Drawing.Image)(resources.GetObject("newProjectBtn.Image")));
            this.newProjectBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newProjectBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newProjectBtn.Name = "newProjectBtn";
            this.newProjectBtn.Size = new System.Drawing.Size(23, 22);
            this.newProjectBtn.ToolTipText = "Neues Projekt";
            this.newProjectBtn.Click += new System.EventHandler(this.newProjectBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // openFileBtn
            // 
            this.openFileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("openFileBtn.Image")));
            this.openFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(23, 22);
            this.openFileBtn.ToolTipText = "Projekt öffnen";
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // saveProjectBtn
            // 
            this.saveProjectBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveProjectBtn.Enabled = false;
            this.saveProjectBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveProjectBtn.Image")));
            this.saveProjectBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveProjectBtn.Name = "saveProjectBtn";
            this.saveProjectBtn.Size = new System.Drawing.Size(23, 22);
            this.saveProjectBtn.ToolTipText = "Projekt speichern";
            this.saveProjectBtn.Click += new System.EventHandler(this.saveProjectBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // compileBtn
            // 
            this.compileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.compileBtn.Image = ((System.Drawing.Image)(resources.GetObject("compileBtn.Image")));
            this.compileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.compileBtn.Name = "compileBtn";
            this.compileBtn.Size = new System.Drawing.Size(23, 22);
            this.compileBtn.ToolTipText = "Kompilieren";
            this.compileBtn.Click += new System.EventHandler(this.compileBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // preferencesBtn
            // 
            this.preferencesBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.preferencesBtn.Image = ((System.Drawing.Image)(resources.GetObject("preferencesBtn.Image")));
            this.preferencesBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.preferencesBtn.Name = "preferencesBtn";
            this.preferencesBtn.Size = new System.Drawing.Size(23, 22);
            this.preferencesBtn.ToolTipText = "Einstellungen";
            this.preferencesBtn.Click += new System.EventHandler(this.preferencesBtn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // aboutBtn
            // 
            this.aboutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutBtn.Image = ((System.Drawing.Image)(resources.GetObject("aboutBtn.Image")));
            this.aboutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(23, 22);
            this.aboutBtn.ToolTipText = "Über CHMDotNet";
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 378);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHMDotNet";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kompilierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoÜberCHMDotNetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuesProjektToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektÖffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektSpeichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zuletztGeöffnetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem projektSchließenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fensterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalAnordnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vertikalAnordnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hintereinanderAnordnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alleMaximierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alleMinimierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem alleWiederherstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newProjectBtn;
        private System.Windows.Forms.ToolStripButton openFileBtn;
        private System.Windows.Forms.ToolStripButton saveProjectBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton compileBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton preferencesBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton aboutBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem1;
    }
}

