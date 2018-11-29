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
    public partial class frmAccountsCheque : Form
    {
        static InoxErpContext ctx = new InoxErpContext();

        ChequesBusiness objCheq = new ChequesBusiness(ctx);
        ClientsBusiness objClient = new ClientsBusiness(ctx);
        Budget_OSBusiness objBudget = new Budget_OSBusiness(ctx);

        ValidationEntries validation = new ValidationEntries();

        public frmAccountsCheque()
        {
            InitializeComponent();
        }

        private void frmAccountsCheque_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void fillGrid()
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_cheques' table. You can move, or remove it, as needed.
            this.tb_chequesTableAdapter.FillByCheque(this.fullDataSet.tb_cheques);
        }

        private void txtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorLetters(sender,e);
        }

        private void txtOrcamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorNumbers(sender,e);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender,e);
        }

        private void txtNumeroCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorNumbersCheque(sender,e);
        }

        private void grdCheques_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int compare = grdCheques.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (compare == 0)
            { }
            else
            {
                string cli = grdCheques[2, grdCheques.CurrentRow.Index].Value.ToString();
                txtNomeCliente.Text = objClient.Search
                    .FirstOrDefault(c => c.sID == cli).sName.ToString();

                string id = grdCheques[1, grdCheques.CurrentRow.Index].Value.ToString();
                txtOS.Text = objBudget.Search
                    .FirstOrDefault(c => c.sID == id).iCod.ToString();

                dtpData.Text = grdCheques[3, grdCheques.CurrentRow.Index].Value.ToString();
                txtValor.Text = grdCheques[5, grdCheques.CurrentRow.Index].Value.ToString();
                nudParcelas.Value = Convert.ToDecimal(grdCheques[6, grdCheques.CurrentRow.Index].Value);
                txtNumeroCheque.Text = grdCheques[10, grdCheques.CurrentRow.Index].Value.ToString();
                txtReferenteA.Text = grdCheques[9, grdCheques.CurrentRow.Index].Value.ToString();
            }
        }
    }
}
