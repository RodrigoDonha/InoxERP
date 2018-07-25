using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            AcessoUsuarioForm openUser = new AcessoUsuarioForm();
            openUser.ShowDialog();

            if (openUser.logado)
            Application.Run(new InoxERP.PrincipalForm(openUser.tipo, openUser.nome));

            //DateTime dataAtual = DateTime.Now;
            //DateTime dataExpira = Convert.ToDateTime("17/03/2018");

            //if (openUser.logado)
            //{
            //    if (dataAtual.Date <= dataExpira)
            //        Application.Run(new MainForm(openUser.tipo, openUser.nome));
            //    else
            //        if (openUser.tipo == 0)
            //        Application.Run(new MainForm(openUser.tipo, openUser.nome));
            //    else
            //    {
            //        MessageBox.Show("Sua licensa expirou em " + dataExpira);
            //        Application.Exit();
            //    }
            //}


        }
    }
}
