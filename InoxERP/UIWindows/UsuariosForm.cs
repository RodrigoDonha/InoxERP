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
            //UsuariosDGV.Columns[2].Visible = false;            
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

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Um Usuário precisa ser selecionado para alteração.");
            }
            else
                try
                {
                    UsuariosInformation usuario = new UsuariosInformation();
                    usuario.Cod = Convert.ToInt32(txtIdLogin.Text);
                    usuario.Usuario = txtUsuario.Text;
                    usuario.Senha = txtSenha.Text;
                    usuario.Tipo = cbxTipo.Text;
                    //usuario.Tipo = VerificaTipoUsuario();


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
            txtIdLogin.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
            cbxTipo.Text = "";
        }
        private void btlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (txtIdLogin.Text.Length == 0)
            {
                MessageBox.Show("Um usuario deve ser selecionado antes da exclusão.");
            }
            else
                try
                {
                    int codigo = Convert.ToInt32(txtIdLogin.Text);
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
                txtIdLogin.Text = Convert.ToString(UsuariosDGV[0, UsuariosDGV.CurrentRow.Index].Value.ToString());
                txtUsuario.Text = UsuariosDGV[1, UsuariosDGV.CurrentRow.Index].Value.ToString();
                txtSenha.Text = UsuariosDGV[2, UsuariosDGV.CurrentRow.Index].Value.ToString();
                String tipo = Convert.ToString(UsuariosDGV[3, UsuariosDGV.CurrentRow.Index].Value.ToString());
                cbxTipo.Text = tipo.ToString();
            }
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            AtualizaUsuarios();
            Limpar();
            txtUsuario.Focus();

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

        private void btIncluir_Click_1(object sender, EventArgs e)
        {
            UsuariosInformation user = new UsuariosInformation();

            user.Usuario = txtUsuario.Text;
            user.Senha = txtSenha.Text;
            user.Tipo = cbxTipo.Text;

            UsuariosBLL usuario = new UsuariosBLL();

            usuario.Incluir(user);
        }
    }
}