using System;
using System.Windows.Forms;
using UIWindows.Views.Reports.Budgets;
using UIWindows.Views.Reports.ServicesOrders;

namespace UIWindows
{
    public partial class frmReportServicesOrder : Form
    {
        public frmReportServicesOrder()
        {
            InitializeComponent();
            radGeral.Focus();
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
                new GeneralServiceOrdersReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), situation).Show();
            }

            if (radFinalizadas.Checked)
            {
                type = "Finalizada";
                situation = "True";
                new SituationServiceOrdersReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), situation).Show();
            }

            if (radEmAndamento.Checked)
            {
                type = "Em Andamento";
                situation = "False";
                new SituationServiceOrdersReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), situation).Show();
            }
        }
    }
}
