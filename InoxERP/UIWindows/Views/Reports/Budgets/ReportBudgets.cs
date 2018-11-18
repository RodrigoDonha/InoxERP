using System;
using System.Windows.Forms;
using UIWindows.Views.Reports.Budgets;

namespace UIWindows
{
    public partial class frmReportBudgets : Form
    {
        public frmReportBudgets()
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
                new GeneralBudgetReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), situation).Show();
            }
            if (radAprovados.Checked)
            {
                type = "Aprovados";
                situation = "True";
                new SituationBudgetsReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), situation).Show();
            }
            if (radEmAberto.Checked)
            {
                type = "Em Aberto";
                situation = "False";
                new SituationBudgetsReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), situation).Show();
            }
        }
    }
}
