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
    public partial class frmCashOut : Form
    {
        static InoxErpContext ctx = new InoxErpContext();

        CashBusiness objCashO = new CashBusiness(ctx);
        ClientsBusiness objClient = new ClientsBusiness(ctx);
        Budget_OSBusiness objBudget = new Budget_OSBusiness(ctx);

        ValidationEntries validation = new ValidationEntries();

        public frmCashOut()
        {
            InitializeComponent();
        }

        public void validationEntriesNumerics(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }

        private void frmCashOut_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void fillGrid()
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_cash' table. You can move, or remove it, as needed.
            this.tb_cashTableAdapter.FillByCashOut(this.fullDataSet.tb_cash);
        }

        private void txtNFOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorNumbers(sender,e);
        }

        private void txtNomeClieForn_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorLetters(sender,e);
        }

        private void txtNumCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorNumbersCheque(sender,e);
        }

        private void grdSaidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int compare = grdSaidas.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (compare == 0)
            { }
            else
            {
                string id = grdSaidas[1, grdSaidas.CurrentRow.Index].Value.ToString();
                txtNFOS.Text = objBudget.Search
                    .FirstOrDefault(c => c.sID == id).iCod.ToString();

                string cli = grdSaidas[2, grdSaidas.CurrentRow.Index].Value.ToString();
                txtNomeClieForn.Text = objClient.Search
                    .FirstOrDefault(c => c.sID == cli).sName.ToString();

                txtValor.Text = grdSaidas[4, grdSaidas.CurrentRow.Index].Value.ToString();
                dtpData.Text = grdSaidas[3, grdSaidas.CurrentRow.Index].Value.ToString();
                txtNumCheque.Text = grdSaidas[7, grdSaidas.CurrentRow.Index].Value.ToString();
                txtReferenteA.Text = grdSaidas[5, grdSaidas.CurrentRow.Index].Value.ToString();
            }
        }
    }
}
