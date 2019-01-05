using System;
using System.Windows.Forms;
using UIWindows.Views.Reports.Cheques;

namespace UIWindows
{
    public partial class frmReportCashCheque : Form
    {
        public frmReportCashCheque()
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
                new GeneralChequesReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), situation).Show();
            }
            if (radBaixados.Checked)
            {
                type = "Baixados";
                situation = "True";
                new SituationChequesReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), situation).Show();
            }
            if (radNaoBaixados.Checked)
            {
                type = "Não Baixados";
                situation = "False";
                new SituationChequesReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), situation).Show();
            }
        }
    }
}
