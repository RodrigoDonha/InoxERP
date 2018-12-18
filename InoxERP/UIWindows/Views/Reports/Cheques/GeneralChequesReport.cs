using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWindows.Views.Reports.Cheques
{
    public partial class GeneralChequesReport : Form
    {
        public GeneralChequesReport()
        {
            InitializeComponent();
        }

        private void GeneralChequesReport_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fullDataSet.tb_chequesReport'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_chequesReportTableAdapter.Fill(this.fullDataSet.tb_chequesReport);

            this.reportViewer1.RefreshReport();
        }
    }
}
