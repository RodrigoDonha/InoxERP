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
                type = "Contas Gerais A Pagar, Pagas Parcial ou Total";
                typeLaunch = "";
                new GeneralAccountsPayReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), typeLaunch).Show();
            }

            if (radContasGeraisAReceber.Checked)
            {
                type = "Contas Gerais A Receber, Recebidas Parcial ou Total";
                typeLaunch = "";
                new GeneralAccountsReceiveReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), typeLaunch).Show();
            }

            if (radPagas.Checked)
            {
                type = "Contas Pagas Totalmente";
                typeLaunch = "";
                new AccountsPaymentsReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), typeLaunch).Show();
            }

            if (radAPagar.Checked)
            {
                type = "Contas A Pagar ";
                typeLaunch = "";
                new AccountsPayableReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), typeLaunch).Show();
            }

            if (radRecebidos.Checked)
            {
                type = "Contas Recebidas ";
                typeLaunch = "";
                new AccountsReceivedReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), typeLaunch).Show();
            }

            if (radAReceber.Checked)
            {
                type = "Contas A Receber ";
                typeLaunch = "";
                new AccountsReceivableReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), typeLaunch).Show();
            }

            if (radPagosParcialmente.Checked)
            {
                type = "Contas Pagas Parcialmente";
                typeLaunch = "";
                new ParcialPayReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), typeLaunch).Show();
            }

            if (radRecebidosParcialemnte.Checked)
            {
                type = "Contas Pagas Parcialmente";
                typeLaunch = "";
                new ParcialReceiveReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), typeLaunch).Show();
            }
        }
    }
}
