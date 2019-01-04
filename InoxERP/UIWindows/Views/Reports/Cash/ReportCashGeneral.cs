using System;
using System.Windows.Forms;
using UIWindows.Views.Reports.Cash;

namespace UIWindows
{
    public partial class frmReportCashGeneral : Form
    {
        public frmReportCashGeneral()
        {
            InitializeComponent();
            radGeral.Focus();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string type = "";
            DateTime startDate = Convert.ToDateTime(dtpInicio.Text);
            DateTime endDate = Convert.ToDateTime(dtpFim.Text);
            int typeLaunch;
            
            if (radGeral.Checked)
            {
                type = "Caixa Geral";
                new GeneralCashReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), type).Show();
            }

            if (radSaidas.Checked)
            {
                type = "Saida de Caixa";
                typeLaunch = 2;
                new TypeLaunchCashReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), typeLaunch).Show();
            }

            if (radEntradas.Checked)
            {
                type = "Entrada de Caixa";
                typeLaunch = 1;
                new TypeLaunchCashReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), typeLaunch).Show();
            }
        }
    }
}
