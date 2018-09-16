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
    public partial class frmDeliveryFollowing : Form
    {
        static InoxErpContext ctx = new InoxErpContext();
        Budgets_OS searchBudget = new Budgets_OS();
        Budget_OSBusiness obj = new Budget_OSBusiness(ctx);
        ItemsBusiness item = new ItemsBusiness(ctx);

        String getId;

        public frmDeliveryFollowing()
        {
            InitializeComponent();
        }

        private void frmDeliveryFollowing_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'inoxErpDBDataSet3ServiceOrdersApprovedGidView.tb_delivery_opened'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_delivery_openedTableAdapter.Fill(this.inoxErpDBDataSet3ServiceOrdersApprovedGidView.tb_delivery_opened);

        }

        private void btnAbrirAlterar_Click(object sender, EventArgs e)
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

        private void grdEntregas_Click(object sender, EventArgs e)
        {
            getId = "";
            if (grdEntregas.CurrentRow != null)
            {
                getId = Convert.ToString(grdEntregas[7, grdEntregas.CurrentRow.Index].Value.ToString());
            }
            else
            {
                MessageBox.Show("Não foi possível selecionar o orçamento, tente selecionar novamente.");
            }
        }
    }
}
