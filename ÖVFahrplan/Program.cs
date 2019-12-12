using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖVFahrplan
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch
            {
                MessageBox.Show("Starten sie das Programm neu", "Ein Problem ist aufgetreten!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
