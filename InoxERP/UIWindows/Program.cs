using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using InoxERP;

namespace UIWindows
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmSignIn LoginValidation = new frmSignIn();

            LoginValidation.ShowDialog();

            if (LoginValidation.log)
                Application.Run(new frmMain(LoginValidation.user));

        }
    }
}
