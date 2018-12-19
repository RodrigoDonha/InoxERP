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
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string type = "";
            DateTime startDate = Convert.ToDateTime(dtpInicio.Text);
            DateTime endDate = Convert.ToDateTime(dtpFim.Text);
            int typeLaunch;
            if (radGeral.Checked)
            {
                type = "Geral";
                new GeneralCashReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), type).Show();
            }

            if (radSaidas.Checked)
            {
                type = "Saida";
                typeLaunch = 2;
                new TypeLaunchCashReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), typeLaunch).Show();
            }

            if (radEntradas.Checked)
            {
                type = "Entrada";
                typeLaunch = 1;
                new TypeLaunchCashReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), typeLaunch).Show();
            }

            //if (radRecebidos.Checked)
            //{
            //    type = "Recebidos";
            //    situation = "False";
            //    //new SituationServiceOrdersReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), situation).Show();
            //}

            //if (radAReceber.Checked)
            //{
            //    type = "A Receber";
            //    situation = "False";
            //    //new SituationServiceOrdersReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), situation).Show();
            //}

        }
    }
}
