using System;
using System.Windows.Forms;
using UIWindows.Views.Reports.ServicesOrders;

namespace UIWindows
{
    public partial class frmReportServicesOrder : Form
    {
        public frmReportServicesOrder()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string type = "";
            DateTime startDate = Convert.ToDateTime(dtpInicio.Text);
            DateTime endDate = Convert.ToDateTime(dtpFim.Text);
            string situation = "";
            if (radGeral.Checked)
            {
                type = "Geral";
                situation = "";
                new GeneralServiceOrdersReportcs(type, startDate.ToShortDateString(), endDate.ToShortDateString(), situation).Show();
                            }
            if (radFinalizadas.Checked)
            {
                type = "Aprovados";
                situation = "True";
                //new SituationBudgetsReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), situation).Show();
            }
            if (radEmAndamento.Checked)
            {
                type = "Em Aberto";
                situation = "False";
                //new SituationBudgetsReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), situation).Show();
            }
        }
    }
}
