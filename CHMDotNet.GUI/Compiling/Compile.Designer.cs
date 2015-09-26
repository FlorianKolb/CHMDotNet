namespace CHMDotNet.GUI.Compiling
{
    partial class Compile
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
            this.label1 = new System.Windows.Forms.Label();
            this.outputFile = new System.Windows.Forms.TextBox();
            this.setOutputPath = new System.Windows.Forms.Button();
            this.createCHM = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.actualProgress = new System.Windows.Forms.Label();
            this.progressListBox = new System.Windows.Forms.ListBox();
            this.openOutputFile = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ausgabedatei:";
            // 
            // outputFile
            // 
            this.outputFile.Location = new System.Drawing.Point(93, 10);
            this.outputFile.Name = "outputFile";
            this.outputFile.ReadOnly = true;
            this.outputFile.Size = new System.Drawing.Size(220, 20);
            this.outputFile.TabIndex = 1;
            // 
            // setOutputPath
            // 
            this.setOutputPath.Location = new System.Drawing.Point(319, 8);
            this.setOutputPath.Name = "setOutputPath";
            this.setOutputPath.Size = new System.Drawing.Size(56, 23);
            this.setOutputPath.TabIndex = 2;
            this.setOutputPath.Text = "...";
            this.setOutputPath.UseVisualStyleBackColor = true;
            this.setOutputPath.Click += new System.EventHandler(this.setOutputPath_Click);
            // 
            // createCHM
            // 
            this.createCHM.Location = new System.Drawing.Point(225, 234);
            this.createCHM.Name = "createCHM";
            this.createCHM.Size = new System.Drawing.Size(72, 23);
            this.createCHM.TabIndex = 3;
            this.createCHM.Text = "Erstellen";
            this.createCHM.UseVisualStyleBackColor = true;
            this.createCHM.Click += new System.EventHandler(this.createCHM_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(303, 234);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(72, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Abbrechen";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fortschritt:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(93, 61);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(220, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // actualProgress
            // 
            this.actualProgress.AutoSize = true;
            this.actualProgress.Location = new System.Drawing.Point(90, 87);
            this.actualProgress.Name = "actualProgress";
            this.actualProgress.Size = new System.Drawing.Size(10, 13);
            this.actualProgress.TabIndex = 9;
            this.actualProgress.Text = "-";
            // 
            // progressListBox
            // 
            this.progressListBox.FormattingEnabled = true;
            this.progressListBox.Location = new System.Drawing.Point(15, 107);
            this.progressListBox.Name = "progressListBox";
            this.progressListBox.Size = new System.Drawing.Size(360, 121);
            this.progressListBox.TabIndex = 10;
            // 
            // openOutputFile
            // 
            this.openOutputFile.AutoSize = true;
            this.openOutputFile.Location = new System.Drawing.Point(90, 38);
            this.openOutputFile.Name = "openOutputFile";
            this.openOutputFile.Size = new System.Drawing.Size(105, 13);
            this.openOutputFile.TabIndex = 11;
            this.openOutputFile.TabStop = true;
            this.openOutputFile.Text = "Ausgabedatei öffnen";
            this.openOutputFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openOutputFile_LinkClicked);
            // 
            // Compile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 261);
            this.Controls.Add(this.openOutputFile);
            this.Controls.Add(this.progressListBox);
            this.Controls.Add(this.actualProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.createCHM);
            this.Controls.Add(this.setOutputPath);
            this.Controls.Add(this.outputFile);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Compile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kompilieren...";
            this.Load += new System.EventHandler(this.Compile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputFile;
        private System.Windows.Forms.Button setOutputPath;
        private System.Windows.Forms.Button createCHM;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label actualProgress;
        private System.Windows.Forms.ListBox progressListBox;
        private System.Windows.Forms.LinkLabel openOutputFile;
    }
}