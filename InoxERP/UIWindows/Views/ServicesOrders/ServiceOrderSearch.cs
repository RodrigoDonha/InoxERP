using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InoxERP.UI_Windows_Forms;
using Microsoft.ReportingServices.Interfaces;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;
using UIWindows.Views.ServicesOrders;

namespace UIWindows
{
    public partial class frmServiceOrderSearch : Form
    {

        static InoxErpContext ctx = new InoxErpContext();
        Budgets_OS searchBudget = new Budgets_OS();
        Budget_OSBusiness obj = new Budget_OSBusiness(ctx);
        ItemsBusiness item = new ItemsBusiness(ctx);

        String getId;

        public frmServiceOrderSearch()
        {
            InitializeComponent();
        }


        // Events

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            getIdGrigView();
            if (!getId.Equals(""))
            {
                frmBudgetsRegister bud = new frmBudgetsRegister(getId);

                /////FUNCTION TO DISABLE BUTTONS
                foreach (Control budControl in bud.Controls)
                {
                    foreach (Control btn in budControl.Controls)
                    {
                        if (btn.Name == "btnGravarOrcamento" || btn.Name == "btnExcluir" || btn.Name == "btnCancelarOrcamento")
                            btn.Enabled = false;
                        if (btn.Name == "btnAprovar")
                            btn.Enabled = true;
                    }
                }
                bud.BudgetData();
                bud.Show();
            }
        }

        private void btnDesaprovar_Click(object sender, EventArgs e)
        {
            //getIdGrigView();
            //if (dgvOrdemServico.CurrentRow != null)
            //{
            //    searchBudget = obj.ReturnByID(getId);
            //    if (messageYesNo("Desapprove") == DialogResult.Yes)
            //    {
            //        searchBudget.bServiceOrderApproved = false;
            //        searchBudget.dtDateServiceOrderApproved = DateTime.Now;

            //        obj.Update(searchBudget);
            //        MessageBox.Show("Desaprovado");

            //        fillDataSet();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Não foi possível selecionar o orçamento, tente selecionar novamente.");
            //}
        }

        private void btnFinlizar_Click(object sender, EventArgs e)
        {
            getIdGrigView();
            if (dgvOrdemServico.CurrentRow != null)
            {
                searchBudget = obj.ReturnByID(getId);
                if (messageYesNo("Finished") == DialogResult.Yes)
                {
                    searchBudget.bRegisterFinished = true;
                    searchBudget.dtDateRegisterFinished = DateTime.Now;
                    searchBudget.bServiceOrderDelivered = true;
                    searchBudget.dtDateServiceOrderDelivered = DateTime.Now;

                    obj.Update(searchBudget);
                    MessageBox.Show("Serviço Finalizado");

                    fillDataSet();
                }
            }
            else
            {
                MessageBox.Show("Não foi possível selecionar o orçamento, tente selecionar novamente.");
            }
        }

        private void btnGerarContrato_Click(object sender, EventArgs e)
        {
            new frmContract().Show();
            // implementar quando o Lucas apresentar o contrato
        }

        private void grdOrdemServico_Click(object sender, EventArgs e)
        {
            getIdGrigView();
        }

        private void radData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informe a data no formato dd/mm/aaaa, exemplo: 01/09/2018");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (radNome.Checked)
                searchByName();
            else if (radCPF_CNPJ.Checked)
                searchByCPF_CNPJ();
            else if (radData.Checked)
                searchByDate();
        }

        // Parameters Ready, Validations and Verifications down
        public void getIdGrigView()
        {
            getId = "";
            if (dgvOrdemServico.CurrentRow != null)
            {
                getId = Convert.ToString(dgvOrdemServico[0, dgvOrdemServico.CurrentRow.Index].Value.ToString());
                txtPesquisa.Text = Convert.ToString(dgvOrdemServico[2, dgvOrdemServico.CurrentRow.Index].Value.ToString());
            }
            else
            {
                MessageBox.Show("Não foi possível selecionar o orçamento, tente selecionar novamente.");
                return;
            }
        }
        
        // SEARCH BY NAME CLIENT
        public void searchByName() 
        {
            var search = from p in ctx.Budgets_OS
                where p.sName.StartsWith(txtPesquisa.Text)
                where p.bServiceOrderApproved.Equals(true)
                where p.bRegisterFinished.Equals(false)
                select p;

            if (search.ToList().Count.Equals(0))
            {
                txtPesquisa.Clear();
                MessageBox.Show("Nenhuma Ordem de Serviço Encontrada");
                txtPesquisa.Focus();
            }
            else
            {
                List<Budgets_OS> s = search.ToList();
                txtPesquisa.Clear();
                dgvOrdemServico.DataSource = s.ToList();
            }
        }

        public void searchByCPF_CNPJ()
        {
            var search = from p in ctx.Budgets_OS
                where p.Clients.sCpfCnpj.StartsWith(txtPesquisa.Text)
                where p.bServiceOrderApproved.Equals(true)
                where p.bRegisterFinished.Equals(false)
                select p;

            if (search.ToList().Count.Equals(0))
            {
                txtPesquisa.Clear();
                MessageBox.Show("Nenhum Cliente Encontrado");
                txtPesquisa.Focus();
            }
            else
            {
                List<Budgets_OS> b = search.ToList();
                txtPesquisa.Clear();
                dgvOrdemServico.DataSource = b.ToList();
            }
        }

        public void searchByDate()
        {
            var query = from p in ctx.Budgets_OS
                where p.bServiceOrderApproved.Equals(true)
                where p.bRegisterFinished.Equals(false)
                select p;

            if (txtPesquisa.Text == "")
            {
                dgvOrdemServico.DataSource = query.ToList();
            }
            else
            {
                List<Budgets_OS> list = new List<Budgets_OS>();

                foreach (var line in query.ToList())
                {
                    if (line.dtDate.Date.ToShortDateString().Contains(txtPesquisa.Text))
                    {
                        list.Add(line);
                    }
                }
                dgvOrdemServico.DataSource = list.ToList();
            }
        }

        public DialogResult messageYesNo(string type)
        {
            switch (type)
            {
                case "Exclude":
                    return MessageBox.Show("Confirma excluisão?", "Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "Desapprove":
                    return MessageBox.Show("Confirma a Desaprovação deste orçamento?", "Ordem de Serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "Finished":
                    return MessageBox.Show("Confirma a Finalização do Serviço?", "Finalizar Serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            return DialogResult.No;
        }

        //overrid FILL DATASET
        public void fillDataSet()
        {
            this.tb_budgets_osTableAdapter.FillByOrderServiceApproved(this.fullDataSet.tb_budgets_os);
        }

        private void frmServiceOrderSearch_Load(object sender, EventArgs e)
        {
            this.tb_budgets_osTableAdapter.FillByOrderServiceApproved(this.fullDataSet.tb_budgets_os);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            new ServiceOrdersPrint(getId).Show();
        }
    }
}
