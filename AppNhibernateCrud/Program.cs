using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNhibernateCrud
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
            frmLogin f  = new frmLogin();
            f.ShowDialog();
            if ( f.logado ==true) {

                Application.Run(new frmPrincipal());
            }
           
        }
    }
}
