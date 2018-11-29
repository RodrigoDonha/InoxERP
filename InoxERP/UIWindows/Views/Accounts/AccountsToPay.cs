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

namespace UIWindows
{
    public partial class frmAccountsToPay : Form
    {
        static InoxErpContext ctx = new InoxErpContext();

        AccountsToPayBusiness objAcPag = new AccountsToPayBusiness(ctx);
        ClientsBusiness objClient = new ClientsBusiness(ctx);
        Budget_OSBusiness objBudget = new Budget_OSBusiness(ctx);

        ValidationEntries validation = new ValidationEntries();

        public frmAccountsToPay()
        {
            InitializeComponent();
        }

        private void frmAccountsToPay_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void fillGrid()
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_accountsToPay' table. You can move, or remove it, as needed.
            this.tb_accountsToPayTableAdapter.FillByAccountsToPay(this.fullDataSet.tb_accountsToPay);
        }

        private void txtNomeFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorLetters(sender,e);
        }

        private void txtOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorNumbers(sender,e);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender,e);
        }

        private void grdAPagar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int compare = grdAPagar.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (compare == 0)
            { }
            else
            {
                string cli = grdAPagar[2, grdAPagar.CurrentRow.Index].Value.ToString();
                txtNomeFornecedor.Text = objClient.Search
                    .FirstOrDefault(c => c.sID == cli).sName.ToString();

                string id = grdAPagar[1, grdAPagar.CurrentRow.Index].Value.ToString();
                txtOS.Text = objBudget.Search
                    .FirstOrDefault(c => c.sID == id).iCod.ToString();

                dtpData.Text = grdAPagar[3, grdAPagar.CurrentRow.Index].Value.ToString();
                txtValor.Text = grdAPagar[5, grdAPagar.CurrentRow.Index].Value.ToString();
                nudParcelas.Value = Convert.ToDecimal(grdAPagar[6, grdAPagar.CurrentRow.Index].Value);
                txtReferenteA.Text = grdAPagar[9, grdAPagar.CurrentRow.Index].Value.ToString();
            }
        }
    }
}
