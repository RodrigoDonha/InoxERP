using System;
using System.Windows.Forms;
using UIWindows;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;
using UIWindows.Entities.Enum;

namespace InoxERP.UI_Windows_Forms
{
    public partial class frmBudgetsRegister : Form
    {
        static InoxErpContext ctx = new InoxErpContext();

        // daqui pra baixo muda tudo
        UsersBusiness obj = new UsersBusiness(ctx);
        Users userLog = new Users();
        Users user = new Users();


        public frmBudgetsRegister()
        {
            InitializeComponent();
            btnProcurar.Focus();
        }

        private void OrcamentosForm_Load(object sender, EventArgs e)
        {

        }

        private void tbPrevDiasExec_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPeca_Click(object sender, EventArgs e)
        {
            new frmProductsRegisterSearch().Show();
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            new frmServicesRegisterSearch().Show();
        }

        //validators CAMPS
        public bool validationCamps()
        {
            if (txtNome.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um nome para o cliente ***");
                txtNome.Focus();
                return false;
            }

            if (txtEndereco.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um endereço para o cliente ***");
                txtEndereco.Focus();
                return false;
            }

            if (txtTelefone.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um telefone para o cliente ***");
                txtTelefone.Focus();
                return false;
            }

            if (txtCargo.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um cargo para o cliente ***");
                txtCargo.Focus();
                return false;
            }

            int compare = dgvItens.Rows.Count; // conta linhas da tabela
            if (compare == 0)
            {
                MessageBox.Show("Nenhum Item adicionado ao orçamento ***");
                txtQuantidade.Focus();
                return false;
            }

            if (!chkCombinar.Checked && !chkCheque.Checked && !chkDinheiro.Checked)
            {
                MessageBox.Show("Informe a forma de pagamento ***");
                chkCombinar.Focus();
                return false;
            }

            return true;
        }

        public bool validatorAdd()
        {
            if (txtQuantidade.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe a quantidade ***");
                txtQuantidade.Focus();
                return false;
            }

            if (txtDescricao.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe a descrição do produto ***");
                txtDescricao.Focus();
                return false;
            }

            if (txtValorUnitario.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe o Valor Unitário ***");
                txtValorUnitario.Focus();
                return false;
            }

            return true;
        }

        private void btnGravarOrcamento_Click(object sender, EventArgs e)
        {
            if (!validationCamps())
                MessageBox.Show("erro");
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            new frmClientsSearch().Show();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!validatorAdd())
                MessageBox.Show("erro");
            else
            {
                decimal total = Convert.ToDecimal(txtQuantidade.Text) * Convert.ToDecimal(txtValorUnitario.Text);
                dgvItens.Rows.Add(txtQuantidade.Text, txtDescricao.Text, txtValorUnitario.Text, Convert.ToString(total));
            }
        }

        //validator Calc values
        public void valueTotal()
        {
            if (txtValorUnitario.Text.Length.Equals(0))
            {
                txtValorTotal.Text = "0";
                txtValorUnitario.Text = "0";
            }
            if (txtQuantidade.Text.Length.Equals(0))
            {
                txtQuantidade.Text = "0";
            }
            else
            {
                decimal total = Convert.ToDecimal(txtQuantidade.Text) * Convert.ToDecimal(txtValorUnitario.Text);
                txtValorTotal.Text = Convert.ToString(total);
            }
        }
        
        private void txtValorUnitario_TextChanged(object sender, EventArgs e)
        {
            valueTotal();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var row = dgvItens.SelectedRows;
            //dgvItens.Rows.Remove();
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            valueTotal();
        }

        private void txtQuantidade_TextChanged_1(object sender, EventArgs e)
        {
            valueTotal();
        }
    }    
}
