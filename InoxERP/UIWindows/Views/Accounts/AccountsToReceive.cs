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
    public partial class frmAccountsToReceive : Form
    {
        static InoxErpContext ctx = new InoxErpContext();

        ClientsBusiness objClient = new ClientsBusiness(ctx);
        Budget_OSBusiness objBudget = new Budget_OSBusiness(ctx);

        ValidationEntries validation = new ValidationEntries();
        MessageBoxTimer msg = new MessageBoxTimer();

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
            validation.characterValidatorNumbers(sender, e);
        }
        
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }

        private void grdAReceber_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int compare = grdAReceber.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (compare == 0)
            { }
            else
            {
                lblId.Text = grdAReceber[0, grdAReceber.CurrentRow.Index].Value.ToString();

                InoxErpContext ctxC = new InoxErpContext();

                ClientsBusiness objC = new ClientsBusiness(ctxC);

                string cli = grdAReceber[2, grdAReceber.CurrentRow.Index].Value.ToString();
                try
                {
                    txtNomeCliente.Text = objC.Search
                        .FirstOrDefault(c => c.sID == cli).sName;
                }
                catch (Exception)
                {
                    txtNomeCliente.Text = "";
                }

                string id = grdAReceber[1, grdAReceber.CurrentRow.Index].Value.ToString();
                try
                {
                    txtOS.Text = objBudget.Search
                        .FirstOrDefault(c => c.sID == id).iCod.ToString();
                }
                catch (Exception)
                {
                    txtOS.Text = "";
                }

                dtpData.Text = grdAReceber[3, grdAReceber.CurrentRow.Index].Value.ToString();
                txtValor.Text = grdAReceber[13, grdAReceber.CurrentRow.Index].Value.ToString();
                nudParcelas.Value = Convert.ToDecimal(grdAReceber[7, grdAReceber.CurrentRow.Index].Value);
                txtReferenteA.Text = grdAReceber[10, grdAReceber.CurrentRow.Index].Value.ToString();
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
            string id = txtNomeCliente.Text == "" ? "0" : txtNomeCliente.Text;
            try
            {
                var search = from p in ctx.Clients where p.sName.Contains(id) select p;

                if (!search.ToList().Count.Equals(0))
                {
                    List<Clients> c = new List<Clients>();

                    c = search.ToList();

                    id = c[0].sID;
                }
                else
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
            { }
            return id;
        }

        private void cleanCamps()
        {
            lblId.Text = "";
            txtNomeCliente.Clear();
            txtOS.Clear();
            txtValor.Clear();
            dtpData.Value = DateTime.Now;
            nudParcelas.Value = 1;
            nudPrazo.Value = 0;
            txtReferenteA.Clear();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (validationCamps())
                if (messageYesNo("confirm") == DialogResult.Yes)
                {
                    InoxErpContext ctxP = new InoxErpContext();
                    AccountsToReceiveBusiness objPersist = new AccountsToReceiveBusiness(ctxP);

                    DateTime date = dtpData.Value;

                    for (int i = 0; i < nudParcelas.Value; i++)
                    {
                        AccountsToReceive accPersist = new AccountsToReceive
                        {
                            sID = Guid.NewGuid().ToString(),

                            sId_Budgets_OS = returnOS(),
                            sId_Client = returnId(),
                            dtIssue = DateTime.Now,
                            dValue = Convert.ToDecimal(txtValor.Text.Replace(".", ",")),
                            dRemaing = Convert.ToDecimal(txtValor.Text.Replace(".", ",")),
                            dPaid = 0,
                            dtDueDate = returnDueDate(i, date),
                            dtReceiveDate = DateTime.Now,
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
                    AccountsToReceiveBusiness objAlter = new AccountsToReceiveBusiness(ctxA);
                    AccountsToReceive accAlter = new AccountsToReceive();

                    accAlter = objAlter.ReturnByID(lblId.Text);

                    accAlter.sId_Budgets_OS = returnOS();
                    accAlter.sId_Client = returnId();
                    accAlter.dValue = Convert.ToDecimal(txtValor.Text.Replace(".", ","));
                    accAlter.dtDueDate = dtpData.Value.Date;
                    accAlter.sReferentTo = txtReferenteA.Text;

                    objAlter.Update(accAlter);

                    var ok = objAlter.Search.FirstOrDefault(b => b.sID == accAlter.sID);

                    MessageBox.Show(ok == null ? "Erro ao Alterar a Conta !!!" : "Conta Alterada com Sucesso !!!");

                }

            cleanCamps();
            fillGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string id = lblId.Text;

            if (id.Equals(""))
                MessageBox.Show("Selecione uma Conta para Exclusão !!!");
            else if (messageYesNo("delete") == DialogResult.Yes)
                {
                    InoxErpContext ctxD = new InoxErpContext();
                    AccountsToReceiveBusiness objDel = new AccountsToReceiveBusiness(ctxD);

                    objDel.Delete(lblId.Text);

                    var ok = objDel.Search.FirstOrDefault(b => b.sID == lblId.Text);

                    MessageBox.Show(ok != null ? "Erro ao Excluir a Conta !!!" : "Conta Excluída com Sucesso !!!");
                }

            cleanCamps();
            fillGrid();
        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            if (validationCamps())
                if (messageYesNo("cash") == DialogResult.Yes)
                {
                    InoxErpContext ctxC = new InoxErpContext();
                    AccountsToReceiveBusiness objCash = new AccountsToReceiveBusiness(ctxC);
                    AccountsToReceive accCash = new AccountsToReceive();

                    accCash = objCash.ReturnByID(lblId.Text);

                    accCash = calcPayment(accCash, Convert.ToDecimal(txtValor.Text.Replace(".", ",")));

                    CashBusiness objPersist = new CashBusiness(ctxC);
                    Cash cashPersist = new Cash
                    {
                        sID = Guid.NewGuid().ToString(),

                        sId_Budgets_OS = accCash.sId_Budgets_OS,
                        sId_Client = accCash.sId_Client,
                        dtDate = DateTime.Now,
                        sChequeNumber = "0",
                        sReferentTo = accCash.sReferentTo,
                        CashType = CashType.Enter
                    };

                    decimal valueP = Convert.ToDecimal(txtValor.Text.Replace(".", ","));

                    cashPersist.dValue = valueP;
                    cashPersist.sReferentTo = "Baixa Parcial: " + accCash.sReferentTo;

                    if (valueP >= accCash.dRemaing && accCash.dPaid == accCash.dValue) //quando paga valor maior que o q falta o saldo recebe o valor faltante
                    {
                        valueP = accCash.dRemaing;
                        cashPersist.dValue = valueP;
                        cashPersist.sReferentTo = "Conta Fechada: " + accCash.sReferentTo;
                        accCash.dRemaing = 0;
                    }

                    cashPersist.dBalance = objPersist.returnBalance(valueP);

                    objCash.Update(accCash);

                    objPersist.Insert(cashPersist);

                    var okCash = objPersist.Search.FirstOrDefault(b => b.sID == cashPersist.sID);

                    var okAcc = objCash.Search.FirstOrDefault(b => b.sID == accCash.sID);

                    MessageBox.Show(okCash == null || okAcc == null ? "Erro ao Baixar a Conta !!!" : "Conta Baixada com Sucesso !!!");
                }

            cleanCamps();
            fillGrid();
        }

        private AccountsToReceive calcPayment(AccountsToReceive acc, decimal txtValue)
        {
            if (acc.dRemaing > txtValue)
            {
                acc.dRemaing = acc.dRemaing - txtValue;
                acc.dPaid = acc.dPaid + txtValue;
            }
            else if (acc.dRemaing <= txtValue)
            {
                acc.dPaid = acc.dValue;
                acc.dtReceiveDate = DateTime.Now;
                acc.bReceivePaid = true;
                if ((txtValue - acc.dRemaing) != 0)
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

        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorLetters(sender, e);

            if (e.KeyChar == 13)
                searcByLike();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            searchByName();
        }

        private void searcByLike()
        {
            string name = txtNomeCliente.Text;

            var cliName = from p in ctx.Clients where p.sName.Contains(name) select p.sID;

            var cliAcc = from p in ctx.AccountsToReceive where p.sId_Client.Equals(cliName.FirstOrDefault()) where p.bReceivePaid.Equals(false) select p;

            if (cliAcc.ToList().Count.Equals(0))
            {
                msg.Show("Lançamento Não Encontrado", "Não foi Encontrado Lançamentos para este Cliente", 0, 2000);
                fillGrid();
                txtNomeCliente.Focus();
            }
            else
            {
                if (txtNomeCliente.Text.Equals(""))
                    cliAcc = from p in ctx.AccountsToReceive where p.bReceivePaid.Equals(false) orderby p.dtDueDate descending select p;

                List<AccountsToReceive> acc = cliAcc.ToList();
                grdAReceber.DataSource = acc.ToList();
            }
        }

        private void searchByName()
        {
            string idClient = "";
            frmClientsSearch clientsSearch = new frmClientsSearch();

            foreach (Control cliControl in clientsSearch.Controls)
            {
                if (cliControl.Name == "btnAbrirAlterar" || cliControl.Name == "btnExcluir" || cliControl.Name == "btnCadastrar")
                    cliControl.Enabled = false;
            }

            clientsSearch.ShowDialog();

            if (clientsSearch.ReturnClients != null)
                idClient = clientsSearch.ReturnClients.sID;

            var acc = from p in ctx.AccountsToReceive where p.sId_Client.Equals(idClient) where p.bReceivePaid.Equals(false) select p;

            if (acc.ToList().Count.Equals(0))
            {
                if (clientsSearch.ReturnClients == null)
                {
                    msg.Show("Cliente Não Encontrado", "Não foi Encontrado Cliente para este lançamento", 0, 2000);
                }
                else
                {
                    txtNomeCliente.Text = clientsSearch.ReturnClients.sName;
                }

                msg.Show("Lançamento Não Encontrado", "Não foi Encontrado Lançamentos para este Cliente", 0, 2000);
                txtNomeCliente.Focus();
            }
            else
            {
                List<AccountsToReceive> s = acc.ToList();
                txtNomeCliente.Text = clientsSearch.ReturnClients.sName;
                grdAReceber.DataSource = s.ToList();
            }
        }

    }
}