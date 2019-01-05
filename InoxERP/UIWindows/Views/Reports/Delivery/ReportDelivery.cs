using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWindows.Views.Reports.Delivery;
using UIWindows.Views.Reports.ServicesOrders;

namespace UIWindows
{
    public partial class frmReportDelivery : Form
    {
        public frmReportDelivery()
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
                new GeneralDeliveryReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), situation).Show();
            }

            if (radEntregues.Checked)
            {
                type = "Entregue";
                situation = "True";
                new SituationDeliveryReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), situation).Show();
            }

            if (radEmAberto.Checked)
            {
                type = "Não Entregue";
                situation = "False";
                new SituationDeliveryReport(type, startDate.ToShortDateString(), endDate.ToShortDateString(), situation).Show();
            }
        }
    }
}
