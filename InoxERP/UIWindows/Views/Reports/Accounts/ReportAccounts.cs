using System;
using System.Windows.Forms;
using UIWindows.Views.Reports.Accounts;

namespace UIWindows
{
    public partial class frmReportAccounts : Form
    {
        public frmReportAccounts()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string type = "";
            DateTime startDate = Convert.ToDateTime(dtpInicio.Text);
            DateTime endDate = Convert.ToDateTime(dtpFim.Text);
            string typeLaunch = "";

            if (radContasGeraisAPagar.Checked)
            {
                type = "Gerais A Pagar, Pagas Parcial ou Total";
                typeLaunch = "";
                new GeneralAccountsReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), typeLaunch).Show();
            }
            //if (radGeral.Checked)
            //{
            //    type = "Geral";
            //    typeLaunch = "";
            //    new GeneralAccountsReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), typeLaunch).Show();
            //}
            //if (radBaixados.Checked)
            //{
            //    type = "Baixados";
            //    situation = "True";
            //    new SituationChequesReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), situation).Show();
            //}
            //if (radNaoBaixados.Checked)
            //{
            //    type = "Não Baixados";
            //    situation = "False";
            //    new SituationChequesReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), situation).Show();
            //}
        }
    }
}
