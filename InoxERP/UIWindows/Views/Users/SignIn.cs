using InoxERP;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UIWindows
{
    public partial class frmSignIn : Form
    {

        public frmSignIn()
        {
            InitializeComponent();
        }

       private void btnAcessar_Click(object sender, EventArgs e)
        {
            new frmMain("Administrador","Jefter").Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                
            }
        }
    }
}
