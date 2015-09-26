using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CHMDotNet.GUI.Editing
{
    public partial class LinkSettings : UserControl
    {
        public event EventHandler AddressChanged;

        public LinkSettings()
        {
            InitializeComponent();
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddressChanged != null)
                AddressChanged(this, new EventArgs());
        }

        public string Address
        {
            get { return addressTextBox.Text; }
            set
            {
                addressTextBox.Text = value;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(addressTextBox.Text);
        }

        private void addressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                webBrowser1.Navigate(addressTextBox.Text);
        }
    }
}
