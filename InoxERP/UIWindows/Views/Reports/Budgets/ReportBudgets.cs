using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            DateTime startDate = Convert.ToDateTime(dtpInicio.Text);
            DateTime endDate = Convert.ToDateTime(dtpFim.Text);
            string type;
            if (radGeral.Checked)
            {
                type = "Geral";
                new GeneralBudgetReport(type, startDate.ToShortDateString(), endDate.ToShortDateString()).Show();
            }
            if (radAprovados.Checked)
            {
                type = "Aprovados";
            }
            if (radEmAberto.Checked)
            {
                type = "Em Aberto";
            }
        }
    }
}
