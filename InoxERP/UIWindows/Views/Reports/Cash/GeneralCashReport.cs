using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWindows.Views.Reports.Cash
{
    public partial class GeneralCashReport : Form
    {
        public GeneralCashReport()
        {
            InitializeComponent();
        }

        private void GeneralCashReport_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fullDataSet.tb_cash'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_cashTableAdapter.Fill(this.fullDataSet.tb_cash);

            this.reportViewer1.RefreshReport();
        }
    }
}
