using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWindows.Views.Reports.Contracts;

namespace UIWindows
{
    public partial class frmContractSearch : Form
    {
        private string getId;
        public frmContractSearch()
        {
            InitializeComponent();
        }

        //overrid FILL DATASET
        public void fillDataSet()
        {
            this.tb_contractsTableAdapter.Fill(this.fullDataSet.tb_contracts);
        }

        private void frmContractSearch_Load(object sender, EventArgs e)
        {
            fillDataSet();
        }

        public void getIdGrigView()
        {
            getId = "";
            if (grdContratos.CurrentRow != null)
            {
                getId = Convert.ToString(grdContratos[0, grdContratos.CurrentRow.Index].Value.ToString());
                txtPesquisa.Text = Convert.ToString(grdContratos[2, grdContratos.CurrentRow.Index].Value.ToString());
            }
            else
            {
                MessageBox.Show("Não foi possível selecionar o contrato, tente selecionar novamente.");
                return;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            getIdGrigView();
            new ContractPrint(getId).Show();
        }

        private void grdContratos_Click(object sender, EventArgs e)
        {
            getIdGrigView();
        }
    }
}
