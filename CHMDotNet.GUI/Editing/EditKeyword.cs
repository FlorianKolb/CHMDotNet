using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHMDotNet.Core.Project;

namespace CHMDotNet.GUI.Editing
{
    public partial class EditKeyword : Form
    {
        private CHMKeyword currentKeyword;

        public delegate void KeywordEditedEventHandler(bool changed, CHMKeyword oldKeyword, CHMKeyword newKeyword);
        public event KeywordEditedEventHandler KeywordEdited;

        public EditKeyword(CHMKeyword keyword)
        {
            InitializeComponent();
            this.currentKeyword = keyword;

            keywordTextbox.Text = keyword.Keyword;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (KeywordEdited != null)
                KeywordEdited(false, this.currentKeyword, this.currentKeyword);

            this.Close();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(keywordTextbox.Text))
            {
                CHMKeyword keyword = new CHMKeyword();
                keyword.Id = this.currentKeyword.Id;
                keyword.Keyword = keywordTextbox.Text;

                if (KeywordEdited != null)
                    KeywordEdited(true, this.currentKeyword, keyword);

                this.Close();
            }
            else
                MessageBox.Show("Der neue Inhalt des Keywords darf nicht leer sein!", 
                    "CHMDotNet", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
