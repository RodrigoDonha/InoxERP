using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWindows
{
    public partial class frmAccountsSearch : Form
    {
        public frmAccountsSearch()
        {
            InitializeComponent();
        }

        private void frmAccountsSearch_Load(object sender, EventArgs e)
        {
            fillByReceived();
            fillByPaied();
            fillByCheque();
        }

        private void fillByCheque()
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_cheques' table. You can move, or remove it, as needed.
            this.tb_chequesTableAdapter.FillByChequesReveiced(this.fullDataSet.tb_cheques);
            dgvCheques.Columns[0].Visible = false;
        }

        private void fillByPaied()
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_accountsToPay' table. You can move, or remove it, as needed.
            this.tb_accountsToPayTableAdapter.FillByAccountsPaied(this.fullDataSet.tb_accountsToPay);
            dgvPagos.Columns[0].Visible = false;
        }

        private void fillByReceived()
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_accountsToReceive' table. You can move, or remove it, as needed.
            this.tb_accountsToReceiveTableAdapter.FillByAccountReceived(this.fullDataSet.tb_accountsToReceive);
            dgvRecebidos.Columns[0].Visible = false;
        }

    }
}
