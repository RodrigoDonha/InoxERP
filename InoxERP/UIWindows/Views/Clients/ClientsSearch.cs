using System;
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

        String getId;

        public Clients ReturnClients { get; set; }

        public frmClientsSearch()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmClientsRegister obj = new frmClientsRegister();
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
                ReturnClients = obj.ReturnByID(selectClients());
                Dispose();
            }
            catch
            {
                MessageBox.Show("Não foi possível selecionar o Fornecedor, tente selecionar novamente.");
            }
        }

        public string selectClients()
        {
            string getId = "";

            if (grdClientes.CurrentRow != null)
            {
                getId = Convert.ToString(grdClientes[0, grdClientes.CurrentRow.Index].Value.ToString());
                txtPesquisa.Text = Convert.ToString(grdClientes[1, grdClientes.CurrentRow.Index].Value.ToString());
            }

            return getId;
        }

        private void grdClientes_Click(object sender, EventArgs e)
        {
            string getId = "";

            if (grdClientes.CurrentRow != null)
            {
                getId = Convert.ToString(grdClientes[0, grdClientes.CurrentRow.Index].Value.ToString());
                txtPesquisa.Text = Convert.ToString(grdClientes[1, grdClientes.CurrentRow.Index].Value.ToString());
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
                    return MessageBox.Show("Confirma excluisão?", "Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "Approve":
                    return MessageBox.Show("Confirma aprovação deste orçamento?", "Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "Price":
                    return MessageBox.Show("Deseja Exibir / Imprimir o orçamento com preço nos itens?", "Exibir Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            return DialogResult.No;
        }

    }
}
