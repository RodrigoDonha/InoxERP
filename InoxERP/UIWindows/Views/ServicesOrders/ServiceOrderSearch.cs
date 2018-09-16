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
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;

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

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (getId == null)
            {
                MessageBox.Show("Selecione um orçmento na lista acima.");
            }
            else
            {
                frmBudgetsRegister bud = new frmBudgetsRegister(getId);
                bud.BudgetData();
                bud.Show();
            }
        }

        private void btnGerarContrato_Click(object sender, EventArgs e)
        {
            new frmContract().Show();
        }

        private void frmServiceOrderSearch_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'inoxErpDBDataSet3ServiceOrdersApprovedGidView.tb_budgets_os1'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_budgets_os1TableAdapter.Fill(this.inoxErpDBDataSet3ServiceOrdersApprovedGidView.tb_budgets_os1);
        }

        private void grdOrdemServico_Click(object sender, EventArgs e)
        {
            getId = "";
            if (grdOrdemServico.CurrentRow != null)
            {
                getId = Convert.ToString(grdOrdemServico[8, grdOrdemServico.CurrentRow.Index].Value.ToString());
            }
            else
            {
                MessageBox.Show("Não foi possível selecionar o orçamento, tente selecionar novamente.");
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
            this.tb_budgets_os1TableAdapter.Fill(this.inoxErpDBDataSet3ServiceOrdersApprovedGidView.tb_budgets_os1);
        }

        private void btnDespaprovar_Click(object sender, EventArgs e)
        {
            getId = "";
            if (grdOrdemServico.CurrentRow != null)
            {
                getId = Convert.ToString(grdOrdemServico[8, grdOrdemServico.CurrentRow.Index].Value.ToString());
                searchBudget = obj.ReturnByID(getId);
                if (messageYesNo("Desapprove") == DialogResult.Yes)
                {
                    searchBudget.bServiceOrderApproved = false;
                    searchBudget.dtDateServiceOrderApproved = DateTime.Now;

                    obj.Update(searchBudget);
                    MessageBox.Show("Desaprovado");

                    fillDataSet();
                }
            }
            else
            {
                MessageBox.Show("Não foi possível selecionar o orçamento, tente selecionar novamente.");
            }
        }

        private void btnFinlizar_Click(object sender, EventArgs e)
        {
            getId = "";
            if (grdOrdemServico.CurrentRow != null)
            {
                getId = Convert.ToString(grdOrdemServico[8, grdOrdemServico.CurrentRow.Index].Value.ToString());
                searchBudget = obj.ReturnByID(getId);
                if (messageYesNo("Finished") == DialogResult.Yes)
                {
                    searchBudget.bRegisterFinished = true;
                    searchBudget.dtDateRegisterFinished = DateTime.Now;

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
    }
}
