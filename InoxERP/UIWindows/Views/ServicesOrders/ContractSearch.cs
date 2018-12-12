using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;
using UIWindows.Views.Reports.Contracts;

namespace UIWindows
{
    public partial class frmContractSearch : Form
    {
        static InoxErpContext ctx = new InoxErpContext();
        
        private string getId;
        public frmContractSearch()
        {
            InitializeComponent();

            // botoes que não serão implementados no momento
            btnExcluir.Visible = false;
            btnVisualizar.Visible = false;
        }

        //overrid FILL DATASET
        public void fillDataSet()
        {
            this.tb_contractsTableAdapter.Fill(this.fullDataSet.tb_contracts);
        }

        private void frmContractSearch_Load(object sender, EventArgs e)
        {
            fillDataSet();
        }

        public void getIdGrigView()
        {
            getId = "";
            if (grdContratos.CurrentRow != null)
            {
                getId = Convert.ToString(grdContratos[0, grdContratos.CurrentRow.Index].Value.ToString());
                txtPesquisa.Text = Convert.ToString(grdContratos[2, grdContratos.CurrentRow.Index].Value.ToString());
            }
            else
            {
                MessageBox.Show("Não foi possível selecionar o contrato, tente selecionar novamente.");
                return;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            getIdGrigView();
            new ContractPrint(getId).Show();
        }

        private void grdContratos_Click(object sender, EventArgs e)
        {
            getIdGrigView();
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
            var search = from p in ctx.Contracts
                where p.sClientName.StartsWith(txtPesquisa.Text)
                select p;

            if (search.ToList().Count.Equals(0))
            {
                txtPesquisa.Clear();
                MessageBox.Show("Nenhum Contrato Encontrado");
                txtPesquisa.Focus();
            }
            else
            {
                List<Contracts> s = search.ToList();
                txtPesquisa.Clear();
                grdContratos.DataSource = s.ToList();
            }
        }

        public void searchByCPF_CNPJ()
        {
            var search = from p in ctx.Contracts
                where p.sClientCpfCnpj.StartsWith(txtPesquisa.Text)
                select p;

            if (search.ToList().Count.Equals(0))
            {
                txtPesquisa.Clear();
                MessageBox.Show("Nenhum Contrato Encontrado");
                txtPesquisa.Focus();
            }
            else
            {
                List<Contracts> b = search.ToList();
                txtPesquisa.Clear();
                grdContratos.DataSource = b.ToList();
            }
        }
    }
}
