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
using UIWindows.Entities.Enum;

namespace UIWindows
{
    public partial class frmCashGeneral : Form
    {
        public frmCashGeneral()
        {
            InitializeComponent();
        }

        private void frmCashGeneral_Load(object sender, EventArgs e)
        {
            fillFrm();
            colorRows();
            returnValue();
        }

        private void fillFrm()
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_cash' table. You can move, or remove it, as needed.
            this.tb_cashTableAdapter.FillByGeneralCash(this.fullDataSet.tb_cash);

            //ordenar direto na grid
            //grdExtratoGeral.Sort(grdExtratoGeral.Columns[3],ListSortDirection.Descending);
        }

        private void returnValue()
        {
            InoxErpContext ctx = new InoxErpContext();
            CashBusiness cashGen = new CashBusiness(ctx);

            decimal enterC = 0;
            decimal outC = 0;
            decimal totalC = 0;

            List<Cash> list = cashGen.ReturnAll().ToList();

            foreach (var linha in list)
            {
                if (linha.CashType == CashType.Enter)
                    enterC = enterC + linha.dValue;
                else
                    outC = outC + linha.dValue;
            }

            totalC = enterC - outC;
            if (totalC < 0)
            {
                lblExibeSaldoFinal.Text = totalC.ToString();
                lblExibeSaldoFinal.ForeColor = Color.Red;
            }
            else
                lblExibeSaldoFinal.Text = totalC.ToString();
        }

        private void grdExtratoGeral_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int compare = grdExtratoGeral.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (compare == 0)
            { }
            else
            {
                txtValor.Text = grdExtratoGeral[5, grdExtratoGeral.CurrentRow.Index].Value.ToString();
                dtpData.Text = grdExtratoGeral[3, grdExtratoGeral.CurrentRow.Index].Value.ToString();
                txtReferenteA.Text = grdExtratoGeral[4, grdExtratoGeral.CurrentRow.Index].Value.ToString();
            }
        }

        private void colorRows()
        {
            DataGridView dgv = grdExtratoGeral;
            grdExtratoGeral.RowHeadersVisible = false; //tirar a primeira coluna vazia default da DGV

            foreach (DataGridViewRow linha in dgv.Rows)
            {
                decimal value = Convert.ToDecimal(linha.Cells[5].Value);
                if (value < 0)
                    linha.DefaultCellStyle.ForeColor = Color.Red;
                else
                    linha.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
            }
        }

        private void grdExtratoGeral_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView gridView;
            gridView = (DataGridView)sender;
            gridView.ClearSelection();
        }
    }
}
