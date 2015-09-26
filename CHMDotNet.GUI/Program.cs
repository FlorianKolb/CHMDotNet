using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CHMDotNet.GUI
{
    static class Program
    {
        private static MainWindow mainWnd;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainWnd = new MainWindow();
            mainWnd.FormClosing += mainWnd_FormClosing;
            Application.Run(mainWnd);
        }

        private static void mainWnd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CheckIfDirty())
                e.Cancel = true;
        }

        public static bool CheckIfDirty()
        {
            if (mainWnd.Dirty)
            {
                //Meldung anzeigen
                if (MessageBox.Show("Möchten Sie das Projekt/die Projekte wirklich schließen? Es sind ungespeicherte Änderungen vorhanden.", "CHMDotNet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    return true;
                else
                    return false;
            }

            return true;
        }
    }
}