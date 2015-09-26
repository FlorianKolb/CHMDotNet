namespace CHMDotNet.GUI.Editing
{
    partial class ProjectSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fullTextSearch = new System.Windows.Forms.CheckBox();
            this.defaultTopicComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.windowTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.acceptChanges = new System.Windows.Forms.Button();
            this.setOutputFile = new System.Windows.Forms.Button();
            this.outputFile = new System.Windows.Forms.TextBox();
            this.outputFileLbl = new System.Windows.Forms.Label();
            this.projectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fullTextSearch);
            this.groupBox1.Controls.Add(this.defaultTopicComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.windowTitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.acceptChanges);
            this.groupBox1.Controls.Add(this.setOutputFile);
            this.groupBox1.Controls.Add(this.outputFile);
            this.groupBox1.Controls.Add(this.outputFileLbl);
            this.groupBox1.Controls.Add(this.projectName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projekteinstellungen";
            // 
            // fullTextSearch
            // 
            this.fullTextSearch.AutoSize = true;
            this.fullTextSearch.Location = new System.Drawing.Point(14, 140);
            this.fullTextSearch.Name = "fullTextSearch";
            this.fullTextSearch.Size = new System.Drawing.Size(148, 17);
            this.fullTextSearch.TabIndex = 10;
            this.fullTextSearch.Text = "Volltextsuche bereitstellen";
            this.fullTextSearch.UseVisualStyleBackColor = true;
            // 
            // defaultTopicComboBox
            // 
            this.defaultTopicComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultTopicComboBox.FormattingEnabled = true;
            this.defaultTopicComboBox.Location = new System.Drawing.Point(115, 113);
            this.defaultTopicComboBox.Name = "defaultTopicComboBox";
            this.defaultTopicComboBox.Size = new System.Drawing.Size(175, 21);
            this.defaultTopicComboBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Startseite:";
            // 
            // windowTitle
            // 
            this.windowTitle.Location = new System.Drawing.Point(115, 85);
            this.windowTitle.Name = "windowTitle";
            this.windowTitle.Size = new System.Drawing.Size(175, 20);
            this.windowTitle.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Titel der CHM-Datei:";
            // 
            // acceptChanges
            // 
            this.acceptChanges.Location = new System.Drawing.Point(223, 160);
            this.acceptChanges.Name = "acceptChanges";
            this.acceptChanges.Size = new System.Drawing.Size(136, 23);
            this.acceptChanges.TabIndex = 5;
            this.acceptChanges.Text = "Änderungen übernehmen";
            this.acceptChanges.UseVisualStyleBackColor = true;
            this.acceptChanges.Click += new System.EventHandler(this.button1_Click);
            // 
            // setOutputFile
            // 
            this.setOutputFile.Location = new System.Drawing.Point(296, 52);
            this.setOutputFile.Name = "setOutputFile";
            this.setOutputFile.Size = new System.Drawing.Size(49, 23);
            this.setOutputFile.TabIndex = 4;
            this.setOutputFile.Text = "...";
            this.setOutputFile.UseVisualStyleBackColor = true;
            this.setOutputFile.Click += new System.EventHandler(this.setOutputFile_Click);
            // 
            // outputFile
            // 
            this.outputFile.Location = new System.Drawing.Point(115, 54);
            this.outputFile.Name = "outputFile";
            this.outputFile.ReadOnly = true;
            this.outputFile.Size = new System.Drawing.Size(175, 20);
            this.outputFile.TabIndex = 3;
            // 
            // outputFileLbl
            // 
            this.outputFileLbl.AutoSize = true;
            this.outputFileLbl.Location = new System.Drawing.Point(11, 57);
            this.outputFileLbl.Name = "outputFileLbl";
            this.outputFileLbl.Size = new System.Drawing.Size(75, 13);
            this.outputFileLbl.TabIndex = 2;
            this.outputFileLbl.Text = "Ausgabedatei:";
            // 
            // projectName
            // 
            this.projectName.Location = new System.Drawing.Point(115, 22);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(175, 20);
            this.projectName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projektname:";
            // 
            // ProjectSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ProjectSettings";
            this.Size = new System.Drawing.Size(365, 191);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button setOutputFile;
        private System.Windows.Forms.TextBox outputFile;
        private System.Windows.Forms.Label outputFileLbl;
        private System.Windows.Forms.TextBox projectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button acceptChanges;
        private System.Windows.Forms.TextBox windowTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox defaultTopicComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox fullTextSearch;
    }
}
