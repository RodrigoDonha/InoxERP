using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InoxERP.BLL;
using InoxERP.DAL;
using InoxERP.Modelos;


namespace UIWindows
{
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        public void AtualizaUsuarios()
        {
            UsuariosBLL obj = new UsuariosBLL();
            UsuariosDGV.DataSource = obj.Listagem();
            UsuariosDGV.Columns[2].Visible = false;
        }

        private int VerificaTipoUsuario()
        {
            int tipo = 0;
            if (cbxTipo.Text == "Administrador")
                tipo = 1;
            else
                if (cbxTipo.Text == "Usuário")
                tipo = 2;
            return tipo;
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                UsuariosInformation usuario = new UsuariosInformation();
                usuario.Usuario = tbUsuario.Text;
                usuario.Senha = tbSenha.Text;
                if (VerificaTipoUsuario() == 0)
                    MessageBox.Show("Informe um Tipo de Usuário!!!");
                else
                {
                    usuario.Tipo = VerificaTipoUsuario();
                    UsuariosBLL obj = new UsuariosBLL();

                    obj.Incluir(usuario);
                    MessageBox.Show("O Usuário foi incluído com sucesso!");
                    tbIdLogin.Text = Convert.ToString(usuario.IdLogin);
                    Limpar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            AtualizaUsuarios();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "")
            {
                MessageBox.Show("Um Usuário precisa ser selecionado para alteração.");
            }
            else
                try
                {
                    UsuariosInformation usuario = new UsuariosInformation();
                    usuario.IdLogin = Convert.ToInt32(tbIdLogin.Text);
                    usuario.Usuario = tbUsuario.Text;
                    usuario.Senha = tbSenha.Text;
                    usuario.Tipo = VerificaTipoUsuario();

                    UsuariosBLL obj = new UsuariosBLL();
                    obj.Alterar(usuario);
                    MessageBox.Show("O Usuário foi atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            AtualizaUsuarios();
            Limpar();
        }

        private void Limpar()
        {
            tbIdLogin.Text = "";
            tbUsuario.Text = "";
            tbSenha.Text = "";
            cbxTipo.Text = "";
        }
        private void btlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (tbIdLogin.Text.Length == 0)
            {
                MessageBox.Show("Um usuario deve ser selecionado antes da exclusão.");
            }
            else
                try
                {
                    int codigo = Convert.ToInt32(tbIdLogin.Text);
                    UsuariosBLL obj = new UsuariosBLL();
                    obj.Excluir(codigo);
                    AtualizaUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            AtualizaUsuarios();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            AtualizaUsuarios();
        }

        private void UsuariosDGV_Click(object sender, EventArgs e)
        {
            int compara = UsuariosDGV.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (compara == 0)
            {

            }
            else
            {
                tbIdLogin.Text = Convert.ToString(UsuariosDGV[0, UsuariosDGV.CurrentRow.Index].Value.ToString());
                tbUsuario.Text = UsuariosDGV[1, UsuariosDGV.CurrentRow.Index].Value.ToString();
                tbSenha.Text = UsuariosDGV[2, UsuariosDGV.CurrentRow.Index].Value.ToString();
                int tipo = Convert.ToInt32(UsuariosDGV[3, UsuariosDGV.CurrentRow.Index].Value.ToString());
                if (tipo == 1)
                    cbxTipo.Text = "Administrador";
                else
                    cbxTipo.Text = "Usuário";
            }
        }

        private void UsuariosCadForm_Load(object sender, EventArgs e)
        {
            AtualizaUsuarios();
            tbUsuario.Focus();
        }

        private void UsuariosCadForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void UsuariosDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
