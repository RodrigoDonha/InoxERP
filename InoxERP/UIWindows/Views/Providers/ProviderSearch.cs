using System;
using System.Windows.Forms;
using InoxERP.UI_Windows_Forms;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;

namespace UIWindows
{
    public partial class frmProviderSearch : Form
    {
        static InoxErpContext ctx = new InoxErpContext();
        ProviderBusiness obj = new ProviderBusiness(ctx);

        public Providers returnProviders { get; set; }

        public frmProviderSearch()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
            frmProviderRegister obj = new frmProviderRegister();
            obj.Show();
        }

        private void frmProviderSearch_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fullDataSet.tb_providers'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_providersTableAdapter.Fill(this.fullDataSet.tb_providers);

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                returnProviders = obj.returnById(selectProviders());
                Dispose();
            }
            catch
            {
                MessageBox.Show("Não foi possível selecionar o Fornecedor, tente selecionar novamente.");
            }
        }

        private void dgvFornecedores_Click(object sender, EventArgs e)
        {
            string getId = "";

            if (dgvFornecedores.CurrentRow != null)
            {
                getId = Convert.ToString(dgvFornecedores[0, dgvFornecedores.CurrentRow.Index].Value.ToString());
                txtPesquisa.Text = Convert.ToString(dgvFornecedores[1, dgvFornecedores.CurrentRow.Index].Value.ToString());
            }
            else
            {
                MessageBox.Show("Não foi possível selecionar o Fornecedor, tente selecionar novamente.");
                txtPesquisa.Text = "";
            }
        }

        public string selectProviders()
        {
            string getId = "";

            if (dgvFornecedores.CurrentRow != null)
            {
                getId = Convert.ToString(dgvFornecedores[0, dgvFornecedores.CurrentRow.Index].Value.ToString());
                txtPesquisa.Text = Convert.ToString(dgvFornecedores[1, dgvFornecedores.CurrentRow.Index].Value.ToString());
            }

            return getId;
        }
    }
}
