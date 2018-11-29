using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;

namespace UIWindows
{
    public partial class frmAccountsToReceive : Form
    {
        static InoxErpContext ctx = new InoxErpContext();

        AccountsToReceiveBusiness objAcRec = new AccountsToReceiveBusiness(ctx);
        ClientsBusiness objClient = new ClientsBusiness(ctx);
        Budget_OSBusiness objBudget = new Budget_OSBusiness(ctx);

        ValidationEntries validation = new ValidationEntries();

        public frmAccountsToReceive()
        {
            InitializeComponent();
        }

        private void frmAccountsToReceive_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void fillGrid()
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_accountsToReceive' table. You can move, or remove it, as needed.
            this.tb_accountsToReceiveTableAdapter.FillByAccountsToReceive(this.fullDataSet.tb_accountsToReceive);
        }

        private void txtOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorNumbers(sender,e);
        }

        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorLetters(sender,e);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender,e);
        }

        private void grdAReceber_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int compare = grdAReceber.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (compare == 0)
            { }
            else
            {
                string cli = grdAReceber[2, grdAReceber.CurrentRow.Index].Value.ToString();
                txtNomeCliente.Text = objClient.Search
                    .FirstOrDefault(c => c.sID == cli).sName.ToString();

                string id = grdAReceber[1, grdAReceber.CurrentRow.Index].Value.ToString();
                txtOS.Text = objBudget.Search
                    .FirstOrDefault(c => c.sID == id).iCod.ToString();

                dtpData.Text = grdAReceber[3, grdAReceber.CurrentRow.Index].Value.ToString();
                txtValor.Text = grdAReceber[5, grdAReceber.CurrentRow.Index].Value.ToString();
                nudParcelas.Value = Convert.ToDecimal(grdAReceber[6, grdAReceber.CurrentRow.Index].Value);
                txtReferenteA.Text = grdAReceber[9, grdAReceber.CurrentRow.Index].Value.ToString();
            }
        }
    }
}
