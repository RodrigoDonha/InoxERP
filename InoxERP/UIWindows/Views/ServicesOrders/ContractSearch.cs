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
using UIWindows.Views.ServicesOrders;

namespace UIWindows
{
    public partial class frmContractSearch : Form
    {
        InoxErpContext ctx = new InoxErpContext();

        Contracts ctr = new Contracts();

        private string getId;

        public frmContractSearch()
        {
            InitializeComponent();
        }

        //overrid FILL DATASET
        public void fillDataSet()
        {
            this.tb_contractsTableAdapter.Fill(this.fullDataSet.tb_contracts);
            grdContratos.Sort(grdContratos.Columns[1], ListSortDirection.Descending);
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
            if (GetIdIsNull())
            {
                new ContractPrint(getId).Show();
                getId = null;
            }
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

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            getIdGrigView();
            InoxErpContext c = new InoxErpContext();
            ContractBusiness ct = new ContractBusiness(c);
            ctr = ct.returnById(getId);

            if (GetIdIsNull())
            {
                if (ctr.bEditableContract == false)
                {
                    frmContract contract = new frmContract(getId, "Contract");

                    contract.ContractData(getId);
                    contract.Show();
                    getId = null;
                    this.Dispose();
                }
                else
                {
                    new frmEditableContract(getId, "Contract").Show();
                    this.Dispose();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (GetIdIsNull())
            {
                if (messageYesNo("Exclude") == DialogResult.Yes)
                {
                    InoxErpContext ctx = new InoxErpContext();
                    ContractBusiness obj = new ContractBusiness(ctx);
                    Contracts contracts = new Contracts();
                    contracts = obj.returnById(getId);

                    Budget_OSBusiness objBud = new Budget_OSBusiness(ctx);
                    Budgets_OS bud = new Budgets_OS();
                    bud = objBud.ReturnByID(contracts.sIdBudget_OS);
                    bud.bContractRegistred = false;
                    objBud.Update(bud);

                    obj.Delete(getId);

                    var ok = obj.Search.FirstOrDefault(b => b.sID == contracts.sID);

                    if (ok != null)
                        MessageBox.Show("Erro ao Excluir o Contrato !!!");
                    else
                        MessageBox.Show("Contrato Excluido com Susseço !!!");
                }
            }
            fillDataSet();
            getId = null;
        }

        //validator YesNo
        public DialogResult messageYesNo(string type)
        {
            switch (type)
            {
                case "Exclude":
                    return MessageBox.Show("Confirma exclusão?", "Contrato", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            return DialogResult.No;
        }

        private bool GetIdIsNull()
        {
            if (getId == null)
            {
                MessageBox.Show("Você precisa selecionar um contrato na lista");
                return false;
            }
            return true;
        }

        private void BtnEmpytContract_Click(object sender, EventArgs e)
        {
            frmSelectProvider empyt = new frmSelectProvider("");

            empyt.ShowDialog();

        }
    }
}
