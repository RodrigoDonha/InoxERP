using System;
using System.Collections.Generic;
using System.Linq;
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
        Providers providers = new Providers();

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
            fillDataSet();
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (radNome.Checked)
                searchByName();
            else if (radCPF_CNPJ.Checked)
                searchByCPF_CNPJ();
        }

        public void searchByName()
        {
            var search = from p in ctx.Providers where p.sName.StartsWith(txtPesquisa.Text) select p;

            if (search.ToList().Count.Equals(0))
            {
                txtPesquisa.Clear();
                MessageBox.Show("Nenhum Fornecedor Encontrado");
                txtPesquisa.Focus();
            }
            else
            {
                List<Providers> b = search.ToList();
                txtPesquisa.Clear();
                dgvFornecedores.DataSource = b.ToList();
            }
        }

        public void searchByCPF_CNPJ()
        {
            var search = from p in ctx.Providers where p.sCpfCnpj.StartsWith(txtPesquisa.Text) select p;

            if (search.ToList().Count.Equals(0))
            {
                txtPesquisa.Clear();
                MessageBox.Show("Nenhum Fornecedor Encontrado");
                txtPesquisa.Focus();
            }
            else
            {
                List<Providers> b = search.ToList();
                txtPesquisa.Clear();
                dgvFornecedores.DataSource = b.ToList();
            }
        }

        //SEARCH FOR OPEN FORMS
        public static bool OpenForm(Type frmType)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Equals(frmType))
                    return true;
            }
            return false;
        }

        //GET PROVIDER DATA
        private void dgvFornecedores_DoubleClick(object sender, EventArgs e)
        {
            if (OpenForm(typeof(frmBudgetsRegister)) || OpenForm(typeof(frmProductsRegisterSearch)) || OpenForm(typeof(frmCashOut)))
            {
                try
                {
                    returnProviders = obj.returnById(selectProviders());
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Não foi possível selecionar o Fornecedor, tente selecionar novamente.");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            string getId = "";

            if (dgvFornecedores.CurrentRow != null)
            {
                getId = Convert.ToString(dgvFornecedores[0, dgvFornecedores.CurrentRow.Index].Value.ToString());

                if (messageYesNo("Exclude") == DialogResult.Yes)
                {
                    obj.Delete(getId);

                    var ok = obj.Search.FirstOrDefault(b => b.sID == providers.sID);

                    if (ok != null)
                        MessageBox.Show("Erro ao Excluir o Orçamento !!!");
                    else
                        MessageBox.Show("Orçamento Excluido com Sucesso !!!");
                }
                fillDataSet();
            }
            else
            {
                MessageBox.Show("Não foi possível selecionar o orçamento, tente selecionar novamente.");
            }
        }

        //validator YesNo
        public DialogResult messageYesNo(string type)
        {
            switch (type)
            {
                case "Exclude":
                    return MessageBox.Show("**ATENÇÃO** \r\n A exclusão deste Fornecedor fará com que todos os produtos que estão referenciados a ele percam sua referencia. \r\n Confirma exclusão?", "Fornecedor", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            return DialogResult.No;
        }

        //overrid FILL DATASET
        public void fillDataSet()
        {
            this.tb_providersTableAdapter.Fill(this.fullDataSet.tb_providers);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                returnProviders = obj.returnById(selectProviders());
                frmProviderRegister provider = new frmProviderRegister();
                provider.completeRegister(selectProviders());
                Dispose();
                provider.Show();
            }
            catch
            {
                MessageBox.Show("Não foi possível selecionar o Fornecedor, tente selecionar novamente.");
            }
        }
    }
}
