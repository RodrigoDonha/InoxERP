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
    public partial class frmClientsSearch : Form
    {
        static InoxErpContext ctx = new InoxErpContext();
        Clients client = new Clients();
        ClientsBusiness obj = new ClientsBusiness(ctx);
        ValidationEntries validation = new ValidationEntries();

        String getId;

        public Clients ReturnClients { get; set; }

        public frmClientsSearch()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmClientsRegister obj = new frmClientsRegister(selectClients(), "Clients", "");
            this.Dispose(true);
            obj.Show();
        }

        private void frmClientsSearch_Load(object sender, EventArgs e)
        {
            fillDataSet();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                frmClientsRegister client = new frmClientsRegister(selectClients(), "Clients", "");
                client.completeRegister(selectClients());
                Dispose();
                client.Show();
            }
            catch
            {
                MessageBox.Show("Não foi possível selecionar o Cliente, tente selecionar novamente.");
            }
        }

        public string selectClients()
        {
            getId = "";

            if (grdClientes.CurrentRow != null)
            {
                getId = Convert.ToString(grdClientes[0, grdClientes.CurrentRow.Index].Value.ToString());
                txtPesquisa.Text = Convert.ToString(grdClientes[1, grdClientes.CurrentRow.Index].Value.ToString());
            }

            return getId;
        }

        private void grdClientes_Click(object sender, EventArgs e)
        {
            if (grdClientes.CurrentRow != null)
            {
                getId = "";
                getId = selectClients();
            }
            else
            {
                MessageBox.Show("Não foi possível selecionar o Fornecedor, tente selecionar novamente.");
                txtPesquisa.Text = "";
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            getId = "";

            if (grdClientes.CurrentRow != null)
            {
                getId = Convert.ToString(grdClientes[0, grdClientes.CurrentRow.Index].Value.ToString());

                if (messageYesNo("Exclude") == DialogResult.Yes)
                {
                    obj.Delete(getId);

                    var ok = obj.Search.FirstOrDefault(b => b.sID == client.sID);

                    if (ok != null)
                        MessageBox.Show("Erro ao Excluir o Orçamento !!!");
                    else
                        MessageBox.Show("Orçamento Excluido com Susseço !!!");
                }
                fillDataSet();
            }
            else
            {
                MessageBox.Show("Não foi possível selecionar o orçamento, tente selecionar novamente.");
            }
        }
        
        //overrid FILL DATASET
        public void fillDataSet()
        {
            this.tb_clientsTableAdapter.Fill(this.fullDataSet.tb_clients);
        }

        //validator YesNo
        public DialogResult messageYesNo(string type)
        {
            switch (type)
            {
                case "Exclude":
                    return MessageBox.Show("**ATENÇÃO** \r\n A exclusão deste Cliente fará com que todos os Orçamentos, Ordens de Serviço e etc que estão referenciados a ele percam sua referencia. \r\n Confirma exclusão?", "Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "Approve":
                    return MessageBox.Show("Confirma aprovação deste orçamento?", "Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "Price":
                    return MessageBox.Show("Deseja Exibir / Imprimir o orçamento com preço nos itens?", "Exibir Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            return DialogResult.No;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (radNome.Checked)
                searchByName();
            else if (radCPF_CNPJ.Checked)
                searchByCPF_CNPJ();
        }

        // SEARCH BY NAME CLIENT
        public void searchByName()
        {
            var search = from p in ctx.Clients where p.sName.StartsWith(txtPesquisa.Text) select p;
            
            if (search.ToList().Count.Equals(0))
            {
                txtPesquisa.Clear();
                MessageBox.Show("Nenhum Cliente Encontrado");
                txtPesquisa.Focus();
            }
            else
            {
                List<Clients> b = search.ToList();
                txtPesquisa.Clear();
                grdClientes.DataSource = b.ToList();
            }
        }

        public void searchByCPF_CNPJ()
        {
            var search = from p in ctx.Clients where p.sCpfCnpj.StartsWith(txtPesquisa.Text) select p;

            if (search.ToList().Count.Equals(0))
            {
                txtPesquisa.Clear();
                MessageBox.Show("Nenhum Cliente Encontrado");
                txtPesquisa.Focus();
            }
            else
            {
                List<Clients> b = search.ToList();
                txtPesquisa.Clear();
                grdClientes.DataSource = b.ToList();
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

        //GET CLIENT DATA
        private void grdClientes_DoubleClick(object sender, EventArgs e)
        {
            if (OpenForm(typeof(frmBudgetsRegister)) || OpenForm(typeof(frmCashEntry)) || OpenForm(typeof(frmAccountsCheque)) || OpenForm(typeof(frmAccountsToReceive)) || OpenForm(typeof(frmServiceOrderSearch)))
            {
                try
                {
                    ReturnClients = obj.ReturnByID(selectClients());
                    Hide();
                }
                catch
                {
                    MessageBox.Show(
                        "Não foi possível selecionar o Cliente, tente selecionar novamente, dando um clique duplo em cima do cliente desejado.");
                }
            }
        }


        // precisa acertar para ele trocar de validação quando mudar o rad de cpf / cnpj para nome

        public void validationEntriesCPFandCNPJonSearch(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyCPFandCNPJ(sender, e);
        }

        private void validationEntriesCPFandCNPJ(object sender, EventArgs e)
        {
            if (radCPF_CNPJ.Checked)
            {
                this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validationEntriesCPFandCNPJonSearch);
            }

            if (radNome.Checked)
            {
                this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cleanValidation);
            }
        }

        private void cleanValidation(object sender, KeyPressEventArgs e)
        {

        }
    }
}
