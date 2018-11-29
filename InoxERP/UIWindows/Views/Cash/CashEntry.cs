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
    public partial class frmCashEntry : Form
    {
        static InoxErpContext ctx = new InoxErpContext();

        CashBusiness objCashE = new CashBusiness(ctx);
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
                try
                {
                    txtOS.Text = objBudget.Search
                        .FirstOrDefault(c => c.sID == id).iCod.ToString();
                }
                catch (Exception)
                {
                    txtOS.Text = "";
                }

                string cli = grdEntradas[2, grdEntradas.CurrentRow.Index].Value.ToString();
                txtNomeCliente.Text = objClient.Search
                    .FirstOrDefault(c => c.sID == cli).sName.ToString();
                
                txtValor.Text = grdEntradas[4, grdEntradas.CurrentRow.Index].Value.ToString();
                dtpData.Text = grdEntradas[3, grdEntradas.CurrentRow.Index].Value.ToString();
                txtNumCheque.Text = grdEntradas[7, grdEntradas.CurrentRow.Index].Value.ToString();
                txtReferenteA.Text = grdEntradas[5, grdEntradas.CurrentRow.Index].Value.ToString();
            }
        }


        //validators CAMPS frm
        private bool validationCamps()
        {
            if (txtValor.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um Valor para o Lançamento");
                txtValor.Focus();
                return false;
            }

            if (txtValor.Text.Equals("0"))
            {
                MessageBox.Show("Informe um Valor Maior Que Zero");
                txtValor.Focus();
                return false;
            }

            if (txtNumCheque.Text.Length.Equals(0))
            {
                txtNumCheque.Text = "0";
            }

            if (txtReferenteA.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um Referencia/Motivo para o Lançamento");
                txtReferenteA.Focus();
                return false;
            }

            return true;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (validationCamps())
                if(messageYesNo("confirm") == DialogResult.Yes)
                {
                    InoxErpContext ctx = new InoxErpContext();
                    CashBusiness objPersist = new CashBusiness(ctx);
                    Cash cashPersist = new Cash();

                    cashPersist.sID = Guid.NewGuid().ToString();

                    cashPersist.sId_Budgets_OS = returnOS();
                    cashPersist.sId_Client = returnId();
                    cashPersist.dValue = Convert.ToDecimal(txtValor.Text.Replace(".", ","));
                    cashPersist.dtDate = dtpData.Value;
                    cashPersist.sChequeNumber = txtNumCheque.Text;
                    cashPersist.sReferentTo = txtReferenteA.Text;
                    cashPersist.CashType = CashType.Enter;

                    objPersist.Insert(cashPersist);

                    var ok = objPersist.Search.FirstOrDefault(b => b.sID == cashPersist.sID);

                    if (ok == null)
                        MessageBox.Show("Erro ao Lançar Entrada no Caixa !!!");
                    else
                        MessageBox.Show("Entrada Lançada com Sucesso !!!");

                    cleanCamps();
                    fillGrid();
                }
        }

        private string returnId()
        {
            string id = txtNomeCliente.Text == "" ? "0" : txtNomeCliente.Text;
            try
            {
                var search = from p in ctx.Clients where p.sName.Contains(id) select p;

                if (!search.ToList().Count.Equals(0))
                {
                    List<Clients> c = new List<Clients>();

                    c = search.ToList();

                    id = c[0].sID;
                }else
                    try
                    {
                        id = objClient.Search.FirstOrDefault(c => c.sName.Contains("CONSUMIDOR")).sID;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(
                            "Antes de concluir este Lançamento Voçê tem que Cadastrar um Cliente CONSUMIDOR para continuar");
                    }

            }
            catch (Exception)
            {}
            return id;
        }

        private string returnOS()
        {
            string os = txtOS.Text;
            try
            {
                os = objBudget.Search.FirstOrDefault(c => c.iCod == Convert.ToInt32(os)).sID;
            }
            catch (Exception)
            {
                os = "";
            }
            return os;
        }

        private void cleanCamps()
        {
            txtOS.Clear();
            txtNomeCliente.Clear();
            txtValor.Clear();
            dtpData.Value = DateTime.Now;
            txtNumCheque.Clear();
            txtReferenteA.Clear();
        }

        //DIALOG OPTIONS
        public DialogResult messageYesNo(string type)
        {
            switch (type)
            {
                case "confirm":
                    return MessageBox.Show("Confirma o Lançamento no Caixa ?", "Concluir Lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "alter":
                    return MessageBox.Show("Confirma a Alteração do Lançamento no Caixa ?", "Alterar Lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "delete":
                    return MessageBox.Show("Confirma a Exclusçao do Lançamento no Caixa ? \n ***Isso Gera Automaticamente um E" +
                                           "storno no Extrato", "Excluir Lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            return DialogResult.No;
        }
    }
}
