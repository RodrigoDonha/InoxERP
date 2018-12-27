using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWindows.Business;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;
using UIWindows.Entities.Enum;

namespace UIWindows
{
    public partial class frmCashOut : Form
    {
        static InoxErpContext ctx = new InoxErpContext();

        CashBusiness objCashO = new CashBusiness(ctx);
        ClientsBusiness objClient = new ClientsBusiness(ctx);
        ProviderBusiness objProvider = new ProviderBusiness(ctx);
        Budget_OSBusiness objBudget = new Budget_OSBusiness(ctx);

        ValidationEntries validation = new ValidationEntries();
        MessageBoxTimer msg = new MessageBoxTimer();

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
                lblId.Text = grdSaidas[0, grdSaidas.CurrentRow.Index].Value.ToString();
                
                string id = grdSaidas[1, grdSaidas.CurrentRow.Index].Value.ToString();

                try
                {
                    txtNFOS.Text = objBudget.Search
                        .FirstOrDefault(c => c.sID == id).iCod.ToString();
                }
                catch (Exception)
                {
                    txtNFOS.Text = "";
                }

                string cli = grdSaidas[2, grdSaidas.CurrentRow.Index].Value.ToString();
                try
                {
                    txtNomeClieForn.Text = objProvider.Search
                        .FirstOrDefault(c => c.sID == cli).sName;
                }
                catch (Exception)
                {
                    txtNomeClieForn.Text = objClient.Search
                        .FirstOrDefault(c => c.sID == cli).sName;
                }
               

                txtValor.Text = grdSaidas[4, grdSaidas.CurrentRow.Index].Value.ToString();
                dtpData.Text = grdSaidas[3, grdSaidas.CurrentRow.Index].Value.ToString();
                string num = grdSaidas[7, grdSaidas.CurrentRow.Index].Value.ToString();
                try
                {
                    string[] parts = num.Split('-');

                    txtC1.Text = parts[0];
                    txtC2.Text = parts[1];
                    txtC3.Text = parts[2];
                }
                catch (Exception)
                {
                    txtC1.Text = "0";
                    txtC2.Text = "0";
                    txtC3.Text = "0";
                    //msg.Show("Cheque", "Número do Cheque Não Encontrado", 0, 1000);
                }
                txtReferenteA.Text = grdSaidas[5, grdSaidas.CurrentRow.Index].Value.ToString();
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

            if (txtC1.Text.Length.Equals(0))
            {
                txtC1.Text = "0";
            }

            if (txtC2.Text.Length.Equals(0))
            {
                txtC2.Text = "0";
            }

            if (txtC3.Text.Length.Equals(0))
            {
                txtC3.Text = "0";
            }

            if (txtReferenteA.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um Referencia/Motivo para o Lançamento");
                txtReferenteA.Focus();
                return false;
            }

            return true;
        }

        private string returnId()
        {
            string id = txtNomeClieForn.Text == "" ? "0" : txtNomeClieForn.Text;
            try
            {
                var searchC = from p in ctx.Clients where p.sName.Contains(id) select p;

                if (!searchC.ToList().Count.Equals(0))
                {
                    List<Clients> c = new List<Clients>();

                    c = searchC.ToList();

                    id = c[0].sID;
                }
                else
                    try
                    {
                        var searchP = from p in ctx.Providers where p.sName.Contains(id) select p;

                        if (!searchP.ToList().Count.Equals(0))
                        {
                            List<Providers> c = new List<Providers>();

                            c = searchP.ToList();

                            id = c[0].sID;
                        }
                        else
                            id = objClient.Search.FirstOrDefault(c => c.sName.Contains("CONSUMIDOR")).sID;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(
                            "Antes de concluir este Lançamento Voçê tem que Cadastrar um Cliente CONSUMIDOR para continuar");
                    }

            }
            catch (Exception)
            { }
            return id;
        }

        private string returnOS()
        {
            int os = txtNFOS.Text == "" ? -1 : Convert.ToInt32(txtNFOS.Text);
            Budgets_OS retID = new Budgets_OS();
            try
            {
                retID = objBudget.Search.FirstOrDefault(c => c.iCod == os);
                if (retID.Equals(null))
                    return null;
            }
            catch (Exception)
            {
                retID = new Budgets_OS();
                retID.sID = "";
                //msg.Show("Ordem de Serviço", "Não foi possivel encontrar a O.S. Informada, o Sistema irá prosseguir com valores Padrões", 0, 4000);
            }
            return retID.sID;
        }

        private void cleanCamps()
        {
            lblId.Text = "";
            txtNFOS.Clear();
            txtNomeClieForn.Clear();
            txtValor.Clear();
            dtpData.Value = DateTime.Now;
            txtC1.Clear();
            txtC2.Clear();
            txtC3.Clear();
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
                case "refund":
                    return MessageBox.Show("Confirma a Exclusão do Lançamento no Caixa ? \n ***Isso Gera Automaticamente um E" +
                                           "storno no Extrato", "Excluir Lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            return DialogResult.No;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (validationCamps())
                if (messageYesNo("confirm") == DialogResult.Yes)
                {
                    InoxErpContext ctx = new InoxErpContext();
                    CashBusiness objPersist = new CashBusiness(ctx);
                    Cash cashPersist = new Cash
                    {
                        sID = Guid.NewGuid().ToString(),

                        sId_Budgets_OS = returnOS(),
                        sId_Client = returnId(),
                        dValue = Convert.ToDecimal(txtValor.Text.Replace(".", ",")),
                        dtDate = dtpData.Value,
                        dBalance = objPersist.returnBalance(-Convert.ToDecimal(txtValor.Text.Replace(".", ","))),
                        sChequeNumber = txtC1.Text + "-" + txtC2.Text + "-" + txtC3.Text,
                        sReferentTo = txtReferenteA.Text,
                        CashType = CashType.Out
                    };

                    objPersist.Insert(cashPersist);

                    var ok = objPersist.Search.FirstOrDefault(b => b.sID == cashPersist.sID);

                    MessageBox.Show(
                        ok == null ? "Erro ao Lançar a Saída no Caixa !!!" : "Saída Lançada com Sucesso !!!");

                    cleanCamps();
                    fillGrid();
                }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (validationCamps())
                if (!checkRefund())
                    if (messageYesNo("alter") == DialogResult.Yes)
                    {
                        InoxErpContext ctxA = new InoxErpContext();
                        CashBusiness objALter = new CashBusiness(ctxA);
                        Cash cashAlter = new Cash();


                        cashAlter = objALter.ReturnByID(getIdGRD());

                        cashAlter.sId_Budgets_OS = returnOS();
                        cashAlter.sId_Client = returnId();
                        cashAlter.dValue = Convert.ToDecimal(txtValor.Text.Replace(".", ","));
                        cashAlter.dtDate = dtpData.Value;
                        cashAlter.sChequeNumber = txtC1.Text + "-" + txtC2.Text + "-" + txtC3.Text;
                        cashAlter.sReferentTo = txtReferenteA.Text;
                        cashAlter.CashType = CashType.Out;
                        
                        objALter.Update(cashAlter);

                        var ok = objALter.Search.FirstOrDefault(b => b.sID == cashAlter.sID);

                        if (ok == null)
                            MessageBox.Show("Erro ao Alterar a Saída no Caixa !!!");
                        else
                            MessageBox.Show("Saída Alterada com Sucesso !!!");

                        cleanCamps();
                        fillGrid();
                    }
        }

        private bool checkRefund()
        {
            string text = grdSaidas[5, grdSaidas.CurrentRow.Index].Value.ToString();
            if (text.Contains("ESTORNADO") || text.Contains("ESTORNO"))
            {
                msg.Show("Exclusão de Estorno", "Não é possível Alterar ou Excluir um ESTORNO DE LANÇAMENTO", 0, 2000);
                return true;
            }
            return false;
        }

        private string getIdGRD()
        {
            string id = lblId.Text;

            return id;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            searchByName();
        }

        private void searchByName()
        {
            string idProvider = "";
            frmProviderSearch providerSearch = new frmProviderSearch();

            foreach (Control proControl in providerSearch.Controls)
            {
                if (proControl.Name == "btnAlterar" || proControl.Name == "btnExcluir" || proControl.Name == "btnCadastrar")
                    proControl.Enabled = false;
            }

            providerSearch.ShowDialog();

            if (providerSearch.returnProviders != null)
                idProvider = providerSearch.returnProviders.sID;

            var cash = from p in ctx.Cash where p.sId_Client.Equals(idProvider) where p.CashType == CashType.Out select p;

            if (cash.ToList().Count.Equals(0))
            {
                if (providerSearch.returnProviders == null)
                {
                    msg.Show("Fornecedor Não Encontrado", "Não foi Encontrado Fornecedor para este lançamento", 0, 2000);
                }else
                {
                    txtNomeClieForn.Text = providerSearch.returnProviders.sName;
                }

                msg.Show("Lançamento Não Encontrado", "Não foi Encontrado Lançamentos para este Fornecedor", 0, 2000);
                txtNomeClieForn.Focus();
            }
            else
            {
                List<Cash> s = cash.ToList();
                txtNomeClieForn.Text = providerSearch.returnProviders.sName;
                grdSaidas.DataSource = s.ToList();
            }
        }

        private void btnEstornar_Click(object sender, EventArgs e)
        {
            if (lblId.Text.Equals(""))
                MessageBox.Show("Selecione um Lançamento Primeiro");
            else if (!checkRefund())
                if (messageYesNo("refund") == DialogResult.Yes)
                {
                    InoxErpContext ctxD = new InoxErpContext();
                    CashBusiness objDel = new CashBusiness(ctxD);
                    Cash cashDel = new Cash();

                    cashDel = objDel.ReturnByID(getIdGRD());

                    cashDel.sReferentTo = "LANÇAMENTO ESTORNADO: " + txtReferenteA.Text;
                    
                    objDel.Update(cashDel);

                    Cash cashOut = new Cash
                    {
                        sId_Budgets_OS = returnOS(),
                        sId_Client = returnId(),
                        dValue = Convert.ToDecimal(txtValor.Text.Replace(".", ",")),
                        dtDate = DateTime.Now,
                        dBalance = objDel.returnBalance(Convert.ToDecimal(txtValor.Text.Replace(".", ","))),
                        sChequeNumber = txtC1.Text + "-" + txtC2.Text + "-" + txtC3.Text,
                        sReferentTo = "ESTORNO REFERENTE: " + txtReferenteA.Text,
                        CashType = CashType.Enter,
                        sID = Guid.NewGuid().ToString()
                    };

                    objDel.Insert(cashOut);

                    var up = objDel.Search.FirstOrDefault(b => b.sID == lblId.Text);

                    var ins = objDel.Search.FirstOrDefault(b => b.sID == lblId.Text);

                    if (up == null || ins == null)
                        MessageBox.Show("Erro ao Estornar a Saída !!!");
                    else
                        MessageBox.Show("Saída Estornada com Sucesso !!!");

                    cleanCamps();

                    fillGrid();
                }
        }
    }
}
