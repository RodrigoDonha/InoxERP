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
            radContasGeraisAPagar.Focus();
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
                new GeneralAccountsPayReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), typeLaunch).Show();
            }

            if (radContasGeraisAReceber.Checked)
            {
                type = "Gerais A Receber, Recebidas Parcial ou Total";
                typeLaunch = "";
                new GeneralAccountsReceiveReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), typeLaunch).Show();
            }

            if (radPagosParcialmente.Checked)
            {
                type = "Pagas Parcialmente";
                typeLaunch = "";
                new ParcialPayReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), typeLaunch).Show();
            }

            if (radPagas.Checked)
            {
                type = "Pagas Totalmente";
                typeLaunch = "";
                new AccountsPaymentsReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), typeLaunch).Show();
            }
        }
    }
}
