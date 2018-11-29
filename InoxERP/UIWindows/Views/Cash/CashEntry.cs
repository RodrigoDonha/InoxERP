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
    public partial class frmCashEntry : Form
    {
        static InoxErpContext ctx = new InoxErpContext();

        CashGeneralBusiness objCashE = new CashGeneralBusiness(ctx);
        ClientsBusiness objClient = new ClientsBusiness(ctx);
        Budget_OSBusiness objBudget = new Budget_OSBusiness(ctx);

        ValidationEntries validation = new ValidationEntries();

        public frmCashEntry()
        {
            InitializeComponent();
        }

        public void validationEntriesNumerics(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }

        private void frmCashEntry_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void fillGrid()
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_cash' table. You can move, or remove it, as needed.
            this.tb_cashTableAdapter.FillByCashEntry(this.fullDataSet.tb_cash);
        }

        private void txtOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorNumbers(sender,e);
        }

        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorLetters(sender,e);
        }

        private void txtNumCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorNumbersCheque(sender,e);
        }

        private void grdEntradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int compare = grdEntradas.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (compare == 0)
            { }
            else
            {
                string id = grdEntradas[1, grdEntradas.CurrentRow.Index].Value.ToString();
                txtOS.Text = objBudget.Search
                    .FirstOrDefault(c => c.sID == id).iCod.ToString();

                string cli = grdEntradas[2, grdEntradas.CurrentRow.Index].Value.ToString();
                txtNomeCliente.Text = objClient.Search
                    .FirstOrDefault(c => c.sID == cli).sName.ToString();
                
                txtValor.Text = grdEntradas[4, grdEntradas.CurrentRow.Index].Value.ToString();
                dtpData.Text = grdEntradas[3, grdEntradas.CurrentRow.Index].Value.ToString();
                txtNumCheque.Text = grdEntradas[7, grdEntradas.CurrentRow.Index].Value.ToString();
                txtReferenteA.Text = grdEntradas[5, grdEntradas.CurrentRow.Index].Value.ToString();
            }
        }
    }
}
