using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHMDotNet.Core.Project;
using CHMDotNet.GUI.Project;
using CHMDotNet.GUI.Editing;
using System.Xml.Linq;
using CHMDotNet.GUI.Compiling;
using CHMDotNet.GUI.Help;
using CHMDotNet.Core;
using System.Reflection;
using System.IO;
using CHMDotNet.Core.Configuration.FileHistory;
using System.Diagnostics;
using CHMDotNet.GUI.Properties;

namespace CHMDotNet.GUI
{
    public partial class MainWindow : Form
    {
        MdiClient mdi_client;

        public MainWindow()
        {
            InitializeComponent();
            mdi_client = this.Controls.OfType<MdiClient>().FirstOrDefault();
            mdi_client.AllowDrop = true;
            mdi_client.DragEnter += MainWindow_DragEnter;
            mdi_client.DragDrop += MainWindow_DragDrop;
            this.MdiChildActivate += MainWindow_MdiChildActivate;
        }

        private void PreferencesCommand()
        {
            Preferences preferences = new Preferences();
            preferences.ShowDialog();
        }

        private void optionenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferencesCommand();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            FileHistoryManager.FinishedLoading += FileHistoryManager_FinishedLoading;
            FileHistoryManager.FileAdded += FileHistoryManager_FileAdded;
            FileHistoryManager.Load();

            ProjectManager.OpenProjectError += ProjectManager_OpenProjectError;

            string application = Assembly.GetExecutingAssembly().Location;
            string icon = application.Replace(Path.GetFileName(application), "cdn.ico");
            Helper.Associate(".cdn", "CHMDotNet", "CHMDotNet Projekt", icon, application);

            if (Environment.GetCommandLineArgs().Count() > 1)
                OpenProject(Environment.GetCommandLineArgs()[1]);
        }

        private void FileHistoryManager_FileAdded(object sender, EventArgs e)
        {
            ResetFileHistoryMenuItems();
        }

        private void FileHistoryManager_FinishedLoading(object sender, EventArgs e)
        {
            ResetFileHistoryMenuItems();
        }

        private void ResetFileHistoryMenuItems()
        {
            if (FileHistoryManager.Files != null)
            {
                zuletztGeöffnetToolStripMenuItem.DropDownItems.Clear();

                foreach (string file in FileHistoryManager.Files)
                {
                    ToolStripMenuItem menuItem = new ToolStripMenuItem();
                    menuItem.Name = Guid.NewGuid().ToString();
                    menuItem.Tag = file;
                    menuItem.Image = Resources.project.ToBitmap();
                    menuItem.Text = Helper.PathShortener(file, 40);

                    if (!menuItem.Text.Equals(file))
                        menuItem.ToolTipText = file;

                    menuItem.Click += RecentFileClick;

                    zuletztGeöffnetToolStripMenuItem.DropDownItems.Add(menuItem);
                }
            }
        }

        private void RecentFileClick(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;

            if (File.Exists(menuItem.Tag.ToString()))
            {
                OpenProject(menuItem.Tag.ToString());
            }
            else
            {
                if (MessageBox.Show("Das Projekt ist nicht mehr vorhanden. Soll der Verweis darauf gelöscht werden?", "CHMDotNet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    FileHistoryManager.RemoveFile(menuItem.Tag.ToString());
            }
        }

        private void ProjectManager_OpenProjectError(object sender, EventArgs e)
        {
            MessageBox.Show("Die Datei konnte nicht geöffnet werden, " +
                "da es sich nicht um eine gültige CHMDotNet Projektdatei handelt!",
                "CHMDotNet", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewProjectCommand()
        {
            NewProject newProject = new NewProject(this);
            newProject.ShowDialog();
        }

        private void neuesProjektToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProjectCommand();
        }

        private void projektSchließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null && !this.Dirty)
            {
                this.ActiveMdiChild.Close();
            }
            else
            {
                if (!Program.CheckIfDirty())
                {
                    this.ActiveMdiChild.Close();
                }
            }
        }

        private void horizontalAnordnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void vertikalAnordnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void hintereinanderAnordnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void alleMaximierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiChildren;

            foreach (Form chform in charr)
                chform.WindowState = FormWindowState.Maximized;
        }

        private void alleMinimierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiChildren;

            foreach (Form chform in charr)
                chform.WindowState = FormWindowState.Minimized;
        }

        private void alleWiederherstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiChildren;

            foreach (Form chform in charr)
                chform.WindowState = FormWindowState.Normal;
        }

        private void OpenProjectCommand()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "CHMDotNet Projektdatei (*.cdn)|*.cdn";

                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    OpenProject(ofd.FileName);
                }
            }
        }

        private void OpenProject(string filename)
        {
            CHMProject chmProject = ProjectManager.OpenProject(filename);

            if (chmProject != null)
            {
                FileHistoryManager.AddFile(filename);

                Form projectForm = new Form();
                projectForm.Tag = filename;
                ProjectEditor editor = new ProjectEditor();
                editor.Dock = DockStyle.Fill;
                editor.OpenProject(chmProject);
                projectForm.Controls.Add(editor);
                projectForm.ShowIcon = true;
                projectForm.Icon = Resources.project;
                projectForm.Text = chmProject.Name;
                projectForm.MdiParent = this;
                projectForm.Show();
                projectForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void projektÖffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenProjectCommand();
        }

        private void SaveProjectCommand()
        {
            if (this.ActiveMdiChild != null)
            {
                string filename = this.ActiveMdiChild.Tag.ToString();

                CHMProject currentProject = ((ProjectEditor)this.ActiveMdiChild.Controls[0]).GetCHMProject();
                ProjectManager.SaveProject(currentProject, filename);
                ((ProjectEditor)this.ActiveMdiChild.Controls[0]).Dirty = false;
            }
        }

        private void MainWindow_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.Dirty = ((ProjectEditor)this.ActiveMdiChild.Controls[0]).Dirty;
        }

        public bool Dirty
        {
            get { return saveProjectBtn.Enabled; }
            set
            {
                saveProjectBtn.Enabled = value;
                projektSpeichernToolStripMenuItem.Enabled = value;
            }
        }

        private void projektSpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveProjectCommand();
        }

        private void CompileCommand()
        {
            Compile compile = new Compile(this.ActiveMdiChild != null,
                this.ActiveMdiChild != null ?
                ((ProjectEditor)this.ActiveMdiChild.Controls[0]).GetCHMProject()
                : null);
            compile.ShowDialog();
        }

        private void kompilierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompileCommand();
        }

        private void fensterToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            Form[] charr = this.MdiChildren;

            List<ToolStripItem> items = new List<ToolStripItem>();

            foreach (ToolStripItem menuItem in fensterToolStripMenuItem.DropDownItems)
            {
                if (menuItem.Tag != null && menuItem.Tag.ToString().Equals("MDI_CHILD"))
                    items.Add(menuItem);
            }

            foreach (ToolStripItem item in items)
                fensterToolStripMenuItem.DropDownItems.Remove(item);

            foreach (Form chform in charr)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = chform.Text;
                item.Tag = "MDI_CHILD";
                item.Click += delegate
                {
                    Form tmp = this.MdiChildren.Where(p => p.Text.Equals(item.Text)).First();
                    tmp.Select();
                };

                fensterToolStripMenuItem.DropDownItems.Insert(0, item);
            }
        }

        private void AboutCommand()
        {
            About aboutBox = new About();
            aboutBox.ShowDialog();
        }

        private void infoÜberCHMDotNetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutCommand();
        }

        private void newProjectBtn_Click(object sender, EventArgs e)
        {
            NewProjectCommand();
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            OpenProjectCommand();
        }

        private void compileBtn_Click(object sender, EventArgs e)
        {
            CompileCommand();
        }

        private void preferencesBtn_Click(object sender, EventArgs e)
        {
            PreferencesCommand();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            AboutCommand();
        }

        private void saveProjectBtn_Click(object sender, EventArgs e)
        {
            SaveProjectCommand();
        }

        private void MainWindow_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void MainWindow_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (string file in files)
                OpenProject(file);
        }

        private void hilfeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string helpFile = Path.Combine(dir, "Hilfe.chm");

            if (File.Exists(helpFile))
            {
                using (Process p = new Process())
                {
                    p.StartInfo.FileName = helpFile;
                    p.Start();
                }
            }
            else
                MessageBox.Show("Die Hilfedatei konnte nicht gefunden werden!",
                    "CHMDotNet", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}