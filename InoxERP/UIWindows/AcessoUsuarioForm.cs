using InoxERP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWindows
{
    public partial class AcessoUsuarioForm : Form
    {
        public AcessoUsuarioForm()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        private void AcessoUsuarioForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            PrincipalForm principal = new PrincipalForm();
            this.Hide();
            principal.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
