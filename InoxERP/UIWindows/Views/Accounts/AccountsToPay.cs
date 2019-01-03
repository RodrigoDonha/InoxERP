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
using UIWindows.Views.Accounts;

namespace UIWindows
{
    public partial class frmAccountsToPay : Form
    {
        static InoxErpContext ctx = new InoxErpContext();

        AccountsToPayBusiness objAcPag = new AccountsToPayBusiness(ctx);
        ClientsBusiness objClient = new ClientsBusiness(ctx);
        Budget_OSBusiness objBudget = new Budget_OSBusiness(ctx);

        ValidationEntries validation = new ValidationEntries();
        MessageBoxTimer msg = new MessageBoxTimer();

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
            validation.characterValidatorLetters(sender, e);

            if (e.KeyChar == 13)
                searcByLike();
        }

        private void txtOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorNumbers(sender, e);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }

        private void grdAPagar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int compare = grdAPagar.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (compare == 0)
            { }
            else
            {
                lblId.Text = grdAPagar[0, grdAPagar.CurrentRow.Index].Value.ToString();

                ClientsBusiness objC = new ClientsBusiness(ctx);
                ProviderBusiness objP = new ProviderBusiness(ctx);

                string cli = grdAPagar[2, grdAPagar.CurrentRow.Index].Value.ToString();
                try
                {
                    txtNomeFornecedor.Text = objC.Search
                        .FirstOrDefault(c => c.sID == cli).sName;
                }
                catch (Exception)
                {
                    try
                    {
                        txtNomeFornecedor.Text = objP.Search
                            .FirstOrDefault(c => c.sID == cli).sName;
                    }
                    catch (Exception)
                    {
                        txtNomeFornecedor.Text = "";
                    }
                }

                string id = grdAPagar[1, grdAPagar.CurrentRow.Index].Value.ToString();
                try
                {
                    txtOS.Text = objBudget.Search
                        .FirstOrDefault(c => c.sID == id).iCod.ToString();
                }
                catch (Exception)
                {
                    txtOS.Text = "";
                }

                dtpData.Text = grdAPagar[3, grdAPagar.CurrentRow.Index].Value.ToString();
                txtValor.Text = grdAPagar[5, grdAPagar.CurrentRow.Index].Value.ToString();
                lblValorAPagar.Text = grdAPagar[13, grdAPagar.CurrentRow.Index].Value.ToString();
                nudParcelas.Value = Convert.ToDecimal(grdAPagar[7, grdAPagar.CurrentRow.Index].Value);
                txtReferenteA.Text = grdAPagar[10, grdAPagar.CurrentRow.Index].Value.ToString();
            }
        }

        //DIALOG OPTIONS
        public DialogResult messageYesNo(string type)
        {
            switch (type)
            {
                case "confirm":
                    return MessageBox.Show("Confirma o Lançamento da Conta ?", "Concluir Lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "alter":
                    return MessageBox.Show("Confirma a Alteração da Conta ?", "Alterar Lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "delete":
                    return MessageBox.Show("Confirma a Exclusão da Conta ?", "Excluir Lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "cash":
                    return MessageBox.Show("Confirma a Baixa da Conta ?", "Baixar Lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            }
            return DialogResult.No;
        }

        private string returnOS()
        {
            int os = txtOS.Text == "" ? -1 : Convert.ToInt32(txtOS.Text);
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

        private DateTime returnDueDate(int instalments, DateTime date)
        {
            DateTime due = date.Date;
            int prazo = Convert.ToInt32(nudPrazo.Value);

            if (instalments == 0 && prazo == 0 && due.Equals(DateTime.Today)) //conta a vista
                return DateTime.Today;

            if (instalments == 0 && prazo == 0 && !due.Equals(DateTime.Today)) //conta pré 1 parcela unica dia fixo
                return due;

            if (instalments == 0 && prazo != 0) //conta pré 1 parcela unica com dias especificados
                return due.AddDays(Convert.ToDouble(prazo));

            if (instalments > 0 && prazo == 0) //conta pré com varias parcelas em dias fixos nos meses
            {
                due = due.AddMonths(instalments);
                return due;
            }

            if (instalments > 0 && prazo != 0) //conta pré com varias parcelas com calculo dos dias conforme valor informado
            {
                int i = instalments + 1;
                due = due.AddDays(Convert.ToDouble(prazo * i));
                return due;
            }

            return DateTime.Now;
        }

        private string returnId()
        {
            string id = txtNomeFornecedor.Text == "" ? "0" : txtNomeFornecedor.Text;
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

        private void cleanCamps()
        {
            lblId.Text = "";
            txtNomeFornecedor.Clear();
            txtOS.Clear();
            txtValor.Clear();
            dtpData.Value = DateTime.Now;
            nudParcelas.Value = 1;
            nudPrazo.Value = 0;
            txtReferenteA.Clear();
            lblValorAPagar.Text = "";
            txtValorBaixa.Clear();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (validationCamps())
                if (messageYesNo("confirm") == DialogResult.Yes)
                {
                    InoxErpContext ctxP = new InoxErpContext();
                    AccountsToPayBusiness objPersist = new AccountsToPayBusiness(ctxP);

                    DateTime date = dtpData.Value;

                    for (int i = 0; i < nudParcelas.Value; i++)
                    {
                        AccountsToPay accPersist = new AccountsToPay
                        {
                            sID = Guid.NewGuid().ToString(),

                            sId_Budgets_OS = returnOS(),
                            sId_Client = returnId(),
                            dtIssue = DateTime.Now,
                            dValue = Convert.ToDecimal(txtValor.Text.Replace(".", ",")),
                            dRemaing = Convert.ToDecimal(txtValor.Text.Replace(".", ",")),
                            dPaid = 0,
                            dtDueDate = returnDueDate(i, date),
                            dtPayDate = DateTime.Now,
                            bReceivePaid = false,
                            iInstallment = i + 1,
                            iAmountInstallment = Convert.ToInt32(nudParcelas.Value),
                            sReferentTo = txtReferenteA.Text
                        };

                        objPersist.Insert(accPersist);

                        var ok = objPersist.Search.FirstOrDefault(b => b.sID == accPersist.sID);

                        if (ok == null)
                            MessageBox.Show("Erro ao Lançar a Conta !!!");
                        else if (i + 1 == nudParcelas.Value)
                            MessageBox.Show("Contas Lançadas com Sucesso !!!");

                    }
                    cleanCamps();
                }
            fillGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (validationCamps())
                if (messageYesNo("alter") == DialogResult.Yes)
                {
                    InoxErpContext ctxA = new InoxErpContext();
                    AccountsToPayBusiness objAlter = new AccountsToPayBusiness(ctxA);
                    AccountsToPay accAlter = new AccountsToPay();

                    accAlter = objAlter.ReturnByID(lblId.Text);

                    accAlter.sId_Budgets_OS = returnOS();
                    accAlter.sId_Client = returnId();
                    accAlter.dtDueDate = dtpData.Value;
                    accAlter.sReferentTo = txtReferenteA.Text;

                    decimal txtValue = Convert.ToDecimal(txtValor.Text.Replace(".", ","));

                    if (accAlter.dValue != txtValue)
                        accAlter = calcParcialPayment(accAlter, txtValue);
                    else
                        accAlter.dValue = txtValue;
                    
                    objAlter.Update(accAlter);

                    var ok = objAlter.Search.FirstOrDefault(b => b.sID == accAlter.sID);

                    if (ok.bReceivePaid)
                        MessageBox.Show("A Conta foi Baixada Automaticamente");
                    else
                        MessageBox.Show(ok == null ? "Erro ao Alterar a Conta !!!" : "Conta Alterada com Sucesso !!!");

                    cleanCamps();
                }

            fillGrid();
        }

        private AccountsToPay calcParcialPayment(AccountsToPay acc, decimal txtValue)
        {
            decimal diff = txtValue - acc.dValue;
            
            if (diff > 0) //se aumentar o valor
            {
                acc.dValue = txtValue;
                acc.dRemaing = acc.dRemaing + diff; //aumenta o restante a pagar
            }
            else if (diff < 0) // se for menor o valor
            {
                diff = diff * -1;

                if (txtValue == acc.dPaid)
                {
                    acc.dValue = txtValue;
                    acc.dPaid = txtValue;
                    acc.dtPayDate = DateTime.Now;
                    acc.bReceivePaid = true;
                    acc.dRemaing = 0;
                }
                else if ((acc.dPaid + diff - acc.dValue) > 0)// se o q foi pago + a diferença menor for maior que valor da conta
                {                                   // gera uma devolução no caixa (entrada)
                    decimal refund = (acc.dPaid + diff) - acc.dValue;

                    acc.dValue = txtValue;
                    acc.dPaid = txtValue;
                    acc.dtPayDate = DateTime.Now;
                    acc.bReceivePaid = true;
                    acc.dRemaing = 0;
                    
                    if (refund > 0)
                    {
                        MessageBox.Show("A Alteração de Conta gerou uma Devolução, será incluída uma Entrada no Caixa !!!");

                        InoxErpContext ctxC = new InoxErpContext();
                        CashBusiness objPersist = new CashBusiness(ctxC);
                        Cash cashPersist = new Cash
                        {
                            sID = Guid.NewGuid().ToString(),

                            sId_Budgets_OS = acc.sId_Budgets_OS,
                            sId_Client = acc.sId_Client,
                            dValue = refund,
                            dtDate = DateTime.Now,
                            dBalance = objPersist.returnBalance(refund),
                            sChequeNumber = "0-0-0",
                            sReferentTo = "Devolução: " + acc.sReferentTo,
                            CashType = CashType.Enter
                        };

                        objPersist.Insert(cashPersist);

                        var okCash = objPersist.Search.FirstOrDefault(b => b.sID == cashPersist.sID);

                        if (okCash == null)
                            MessageBox.Show("Erro ao Incluir a Devolução no Caixa !!!");
                    }
                }
                else
                {
                    acc.dValue = txtValue;
                    acc.dRemaing = acc.dRemaing - diff; //diminui o restante a pagar
                }
            }

            return acc;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string id = lblId.Text;

            if(id.Equals(""))
                MessageBox.Show("Selecione uma Conta para Exclusão !!!");
            else{
                frmConfirmationDelete confirmation = new frmConfirmationDelete();

                confirmation.ShowDialog();

                if (!confirmation.user)
                    {
                        MessageBox.Show("Login de Administrador NÃO foi confirmado, Exclusão Cancelada !!!");
                    }
                    else if(messageYesNo("delete") == DialogResult.Yes)
                        {
                            InoxErpContext ctxD = new InoxErpContext();
                            AccountsToPayBusiness objDel = new AccountsToPayBusiness(ctxD);

                            objDel.Delete(lblId.Text);

                            var ok = objDel.Search.FirstOrDefault(b => b.sID == lblId.Text);

                            MessageBox.Show(ok != null ? "Erro ao Excluir a Conta !!!" : "Conta Excluída com Sucesso !!!");

                            cleanCamps();
                        }
                }

            fillGrid();
        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            if (validationCamps())
                if(!txtValorBaixa.Text.Equals("") && !txtValorBaixa.Text.Equals("0"))
                    if (messageYesNo("cash") == DialogResult.Yes)
                    {
                        InoxErpContext ctxC = new InoxErpContext();
                        AccountsToPayBusiness objCash = new AccountsToPayBusiness(ctxC);
                        AccountsToPay accCash = new AccountsToPay();

                        accCash = objCash.ReturnByID(lblId.Text);

                        accCash = calcPayment(accCash, Convert.ToDecimal(txtValorBaixa.Text.Replace(".", ",")));
                        
                        CashBusiness objPersist = new CashBusiness(ctxC);
                        Cash cashPersist = new Cash
                        {
                            sID = Guid.NewGuid().ToString(),

                            sId_Budgets_OS = accCash.sId_Budgets_OS,
                            sId_Client = accCash.sId_Client,
                            dtDate = DateTime.Now,
                            sChequeNumber = "0",
                            sReferentTo = accCash.sReferentTo,
                            CashType = CashType.Out
                        };

                        decimal valueP = Convert.ToDecimal(txtValorBaixa.Text.Replace(".", ","));

                        cashPersist.dValue = valueP;
                        cashPersist.sReferentTo = "Baixa Parcial: " + accCash.sReferentTo;

                        if (valueP >= accCash.dRemaing && accCash.dPaid == accCash.dValue)
                        {
                            valueP = accCash.dRemaing;
                            cashPersist.dValue = valueP;
                            cashPersist.sReferentTo = "Conta Fechada: " + accCash.sReferentTo;
                            accCash.dRemaing = 0;
                        }

                        cashPersist.dBalance = objPersist.returnBalance(-valueP);

                        objCash.Update(accCash);

                        objPersist.Insert(cashPersist);

                        var okCash = objPersist.Search.FirstOrDefault(b => b.sID == cashPersist.sID);

                        var okAcc = objCash.Search.FirstOrDefault(b => b.sID == accCash.sID);

                        MessageBox.Show(okCash == null || okAcc == null ? "Erro ao Baixar a Conta !!!" : "Conta Baixada com Sucesso !!!");

                        cleanCamps();
                    }

            fillGrid();
        }

        private AccountsToPay calcPayment(AccountsToPay acc, decimal txtValue)
        {
            if (acc.dRemaing > txtValue)
            {
                acc.dRemaing = acc.dRemaing - txtValue;
                acc.dPaid = acc.dPaid + txtValue;
            }
            else if (acc.dRemaing <= txtValue)
            {
                acc.dPaid = acc.dValue;
                acc.dtPayDate = DateTime.Now;
                acc.bReceivePaid = true;
                if ((txtValue-acc.dRemaing) != 0)
                    msg.Show("Troco de Pagamento", "Troco: " + (txtValue - acc.dRemaing), 0, 3000);
            }

            return acc;
        }

        private bool validationCamps()
        {
            if (!validation.returnCampsEmpty(txtValor, "Valor"))
                return false;
            if (!validation.returnCampsEmpty(txtReferenteA, "Referente"))
                return false;

            return true;
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            searchByName();
        }

        private void searcByLike()
        {
            string name = txtNomeFornecedor.Text;

            //procura contas nos fornecedores
            var provName = from p in ctx.Providers where p.sName.Contains(name) select p.sID;

            var provAcc = from p in ctx.AccountsToPay where p.sId_Client.Equals(provName.FirstOrDefault()) where p.bReceivePaid.Equals(false) select p;

            //procura contas nos clientes
            var cliName = from p in ctx.Clients where p.sName.Contains(name) select p.sID;

            var cliAcc = from p in ctx.AccountsToPay where p.sId_Client.Equals(cliName.FirstOrDefault()) where p.bReceivePaid.Equals(false) select p;

            if (provAcc.ToList().Count.Equals(0) && cliAcc.ToList().Count.Equals(0) && !txtNomeFornecedor.Text.Equals(""))
            {
                msg.Show("Lançamento Não Encontrado", "Não foi Encontrado Lançamentos para este Cliente / Fornecedor", 0, 2000);
                //fillGrid();
                txtNomeFornecedor.Focus();
            }
            else
            {
                List<AccountsToPay> acc = new List<AccountsToPay>();

                if (!provAcc.ToList().Count.Equals(0))
                    acc = provAcc.ToList();
                else if (!cliAcc.ToList().Count.Equals(0))
                {
                    acc = cliAcc.ToList();
                    msg.Show("Contas a Pagar", "A busca retornou somente Contas a Pagar de Clientes", 0, 2000);
                }
                else if (txtNomeFornecedor.Text.Equals(""))
                {
                    txtNomeFornecedor.Focus();
                    var t = from p in ctx.AccountsToPay where p.bReceivePaid.Equals(false) orderby p.dtDueDate descending select p;
                    acc = t.ToList();
                }

                grdAPagar.DataSource = acc.ToList();
            }
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

            var acc = from p in ctx.AccountsToPay where p.sId_Client.Equals(idProvider) where p.bReceivePaid.Equals(false) select p;

            if (acc.ToList().Count.Equals(0))
            {
                if (providerSearch.returnProviders == null)
                {
                    msg.Show("Fornecedor Não Encontrado", "Não foi Encontrado Fornecedor para este lançamento", 0, 2000);
                }
                else
                {
                    txtNomeFornecedor.Text = providerSearch.returnProviders.sName;
                }

                msg.Show("Lançamento Não Encontrado", "Não foi Encontrado Lançamentos para este Fornecedor", 0, 2000);
                txtNomeFornecedor.Focus();
            }
            else
            {
                List<AccountsToPay> accG = acc.ToList();
                txtNomeFornecedor.Text = providerSearch.returnProviders.sName;
                grdAPagar.DataSource = accG.ToList();
            }
        }

        private void txtValorBaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }
    }
}