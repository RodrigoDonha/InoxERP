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
using InoxERP.DAL;
using MySql.Data.MySqlClient;
using InoxERP.Modelos;
using InoxERP.BLL;

namespace UIWindows
{
    public partial class AcessoUsuarioForm : Form
    {

        public bool logado = false;
        public int tipo = 1;
        public string nome = "";

        public AcessoUsuarioForm()
        {
            InitializeComponent();
        }

        private void AcessoUsuarioForm_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void ValidarUsuario()
        {
            UsuariosInformation user = new UsuariosInformation();
            user.Usuario = txtUsuario.Text;
            user.Senha = txtSenha.Text;

            UsuariosList listUser = new UsuariosList();

            UsuariosBLL usuario = new UsuariosBLL();

            listUser = usuario.ConsultaID(user);

            if (listUser.Count == 0)
            {
                MessageBox.Show("Usuario Inválido");
                logado = false;
                Limpar();
                txtUsuario.Focus();
            }
            else
            {
                foreach (Object obj in listUser)
                {
                    UsuariosInformation usu = (UsuariosInformation)obj;
                    tipo = usu.Tipo;
                    nome = usu.Usuario;
                }
                logado = true;
                this.Dispose();
            }
        }

        private void Limpar()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            ValidarUsuario();

            //PrincipalForm principal = new PrincipalForm();
            //this.Hide();
            //principal.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
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
                ValidarUsuario();
            }
        }
    }
}
