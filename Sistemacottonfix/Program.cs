using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemacottonfix
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmprincipal());

 
            frmsplash Form1= new frmsplash();

            if (Form1.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmprincipal());
            }

        }
    }
}
