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
using UIWindows.DTO;
using UIWindows.Entities;
using UIWindows.Entities.Enum;

namespace UIWindows
{
    public partial class frmPaymentForms : Form
    {
        ValidationEntries validation = new ValidationEntries(); // CLASS TO VALIDATE CAMPS
        
        private string id { get; set; } //BRING ID TO SEARCH ON CONTEXT
        
        //LOAD FORM
        public frmPaymentForms(string id)
        {
            this.id = id;
            InitializeComponent();
            fillFrm(id);
        }

        //FILL DATA ON SCREEN
        private void fillFrm(string id)
        {
            InoxErpContext ctx = new InoxErpContext();
            Budgets_OS b = new Budgets_OS();
            Budget_OSBusiness obj = new Budget_OSBusiness(ctx);

            b = obj.ReturnByID(id);

            lblExibeValorOS.Text = b.dTotal.ToString();
            txtPorcentDescAVista.Text = b.dPercentDiscount.ToString();
            txtPorcentJuros.Text = b.dWithInterest.ToString();

            if (!txtPorcentDescAVista.Text.Equals("") && !txtPorcentDescAVista.Text.Equals("0,00"))
                radDesconto.Checked = true;
            if (!txtPorcentJuros.Text.Equals("") && !txtPorcentJuros.Text.Equals("0,00"))
                radJuros.Checked = true;

            fillValues(b);

            checkTxt();

            decimal valueRound = Convert.ToDecimal(txtValorArredondamento.Text.Replace(".", ","));
            decimal valueMoney = Convert.ToDecimal(txtValorDin.Text.Replace(".", ","));
            decimal valueCheque = Convert.ToDecimal(txtValorCheq.Text.Replace(".", ","));

            var totalValue = valueRound + valueMoney + valueCheque;

            lblValorRestante.Text = b.dTotal.ToString();

            if (valueMoney > 0)
                call("din");
            if(valueCheque > 0)
                call("cheq");
            
            lblValorTotalPago.Text = totalValue.ToString();
        }
        
        //FILL DATA ON SCREEN
        private void fillValues(Budgets_OS b)
        {
            if (b.PaymentMethods == PaymentMethods.chequeMoney)
            {
                var divided = Math.Round(b.dTotal / 2,2); //total ja vem com desc ou juros
                var installments = b.iPaymentInstallments / 2;
                decimal installmentsValue;

                installmentsValue = installments == 0 ? Math.Round(divided / 2,2) : Math.Round(divided / installments,2);
                
                txtValorDin.Text = divided.ToString();
                txtValorCheq.Text = divided.ToString();

                nudParcelasDin.Value = installments == 0 ? 1 : installments;
                nudParcelasCheq.Value = installments == 0 ? 1 : installments;

                lblValorPorParcelaDin.Text = installmentsValue.ToString();
                lblValorPorParcelaCheq.Text = installmentsValue.ToString();
            }
            else
                if (b.PaymentMethods == PaymentMethods.cheque)
                {
                    var total = b.dTotal; //total ja vem com desc ou juros
                    var installments = b.iPaymentInstallments;
                    var installmentsValue = Math.Round(total / installments,2);

                    txtValorCheq.Text = total.ToString();

                    nudParcelasCheq.Value = installments;

                    lblValorPorParcelaCheq.Text = installmentsValue.ToString();
                }
            else
                if (b.PaymentMethods == PaymentMethods.money)
                {
                    var total = b.dTotal; //total ja vem com desc ou juros
                    var installments = b.iPaymentInstallments;
                    var installmentsValue = Math.Round(total / installments,2);

                    txtValorDin.Text = total.ToString();

                    nudParcelasDin.Value = installments;

                    lblValorPorParcelaDin.Text = installmentsValue.ToString();
                }
        }
        
        //FILL EMPTY TXT'S
        private void checkTxt()
        {
            if (txtPorcentDescAVista.Text.Equals(""))
                txtPorcentDescAVista.Text = "0";

            if (txtPorcentJuros.Text.Equals(""))
                txtPorcentJuros.Text = "0";

            if (txtValorArredondamento.Text.Equals(""))
                txtValorArredondamento.Text = "0";

            if (txtEntradaDin.Text.Equals(""))
                txtEntradaDin.Text = "0";

            if (txtEntradaCheq.Text.Equals(""))
                txtEntradaCheq.Text = "0";

            if (txtValorDin.Text.Equals(""))
                txtValorDin.Text = "0";

            if (txtPrimParcDin.Text.Equals(""))
                txtPrimParcDin.Text = "0";

            if (txtValorCheq.Text.Equals(""))
                txtValorCheq.Text = "0";

            if (txtPrimParcCheq.Text.Equals(""))
                txtPrimParcCheq.Text = "0";
        }

        //CHECK TYPE OF DESC OR RATE
        private void checkDescOrRate()
        {
            InoxErpContext ctx = new InoxErpContext();
            Budgets_OS b = new Budgets_OS();
            Budget_OSBusiness obj = new Budget_OSBusiness(ctx);

            b = obj.ReturnByID(id);

            if (chkLimpar.Checked)
            {
                radDesconto.Checked = false;
                radJuros.Checked = false;
                txtPorcentDescAVista.Enabled = false;
                txtPorcentJuros.Enabled = false;
                chkLimpar.Checked = false;

                txtPorcentJuros.Text = "0,00";
                txtPorcentDescAVista.Text = "0,00";

                cleanBeforeFill();
                fillFrm(this.id);
            }else
            if (radDesconto.Checked)
            {
                lblExibeValorOS.Text = b.dTotal.ToString();

                radJuros.Checked = false;
                txtPorcentJuros.Enabled = false;
                txtPorcentJuros.Text = "0,00";

                txtPorcentDescAVista.Enabled = true;

            }else
            if (radJuros.Checked)
            {
                lblExibeValorOS.Text = b.dTotal.ToString();

                radDesconto.Checked = false;
                txtPorcentDescAVista.Enabled = false;
                txtPorcentDescAVista.Text = "0,00";

                txtPorcentJuros.Enabled = true;

            }
        }

        //CLEAR ALL CAMPS BEFORE FILL DATA
        private void cleanBeforeFill()
        {
            txtValorArredondamento.Clear();

            txtEntradaDin.Clear();
            txtEntradaCheq.Clear();

            lblValorRestante.Text = "0";

            txtValorDin.Clear();
            nudParcelasDin.Value = 1;
            nudPrazoDin.Value = 0;
            txtPrimParcDin.Clear();
            lblValorPorParcelaDin.Text = "0";
            
            txtValorCheq.Clear();
            nudParcelasCheq.Value = 1;
            nudPrazoCheq.Value = 0;
            txtPrimParcCheq.Clear();
            lblValorPorParcelaCheq.Text = "0";

            lblValorTotalPago.Text = "0";
        }
        
        //CALC DISCOUNT
        private string calcDesc()
        {
            InoxErpContext ctx = new InoxErpContext();
            Budgets_OS b = new Budgets_OS();
            Budget_OSBusiness obj = new Budget_OSBusiness(ctx);

            b = obj.ReturnByID(id);

           if (!txtPorcentDescAVista.Text.Equals(""))
            {
                decimal valueTotal = b.Items.Sum(i => i.dTotal);
                decimal desc = Convert.ToDecimal(txtPorcentDescAVista.Text.Replace(".", ","));
                decimal final = Math.Round(valueTotal - (valueTotal * (desc/100)), 2);
                lblValorRestante.Text = final.ToString();
                return lblExibeValorOS.Text = final.ToString();
            }
            else
                return lblExibeValorOS.Text = b.dTotal.ToString();
        }

        //CALC RATE
        private string calcRate()
        {
            InoxErpContext ctx = new InoxErpContext();
            Budgets_OS b = new Budgets_OS();
            Budget_OSBusiness obj = new Budget_OSBusiness(ctx);

            b = obj.ReturnByID(id);
            
            if (!txtPorcentJuros.Text.Equals(""))
            {
                decimal valueTotal = b.Items.Sum(i => i.dTotal);
                decimal rate = Convert.ToDecimal(txtPorcentJuros.Text.Replace(".", ","));
                decimal final = Math.Round(valueTotal + (valueTotal * (rate / 100)), 2);
                lblValorRestante.Text = final.ToString();
                return lblExibeValorOS.Text = final.ToString();
            }
            else
                return lblExibeValorOS.Text = b.dTotal.ToString();
        }
        
        //CALC ROUNDING
        private string calcRound()
        {
            InoxErpContext ctx = new InoxErpContext();
            Budgets_OS b = new Budgets_OS();
            Budget_OSBusiness obj = new Budget_OSBusiness(ctx);

            b = obj.ReturnByID(id);

            checkTxt();

            calcDesc();
            calcRate();

            if (!txtValorArredondamento.Text.Equals(""))
            {
                decimal valueTotal = b.Items.Sum(i => i.dTotal);

                decimal desc = Convert.ToDecimal(calcDesc().Replace(".", ",")) - valueTotal;

                decimal rate = Convert.ToDecimal(calcRate().Replace(".", ",")) - valueTotal;

                decimal round = Convert.ToDecimal(txtValorArredondamento.Text.Replace(".", ","));

                decimal final = Math.Round(valueTotal + desc + rate - round, 2);

                lblValorRestante.Text = final.ToString();

                return lblExibeValorOS.Text = final.ToString();
            }
            else
                return lblExibeValorOS.Text = b.dTotal.ToString();
        }

        //CALC ENTRY DIN CHEQ
        private void calcEntryDinCheq()
        {
            checkTxt();

            calcRound();

            lblValorTotalPago.Text = returnEntry().ToString();
        }

        //RETURN CALCULED ENTRY
        private decimal returnEntry()
        {
            decimal din = Convert.ToDecimal(txtEntradaDin.Text.Replace(".", ","));
            decimal cheq = Convert.ToDecimal(txtEntradaCheq.Text.Replace(".", ","));

            decimal totalEntry = Math.Round(din + cheq, 2);

            decimal totalOS = Convert.ToDecimal(lblExibeValorOS.Text.Replace(".", ","));
            
            lblValorRestante.Text = (totalOS - totalEntry).ToString();

            return totalEntry;
        }

        private bool checkValueMax(decimal valueOS, decimal value)
        {
            if (value > valueOS)
                if (messageYesNo("valueMax") == DialogResult.No)
                    return false;

            return true;
        }

        //CALC PAYMENT ON MONEY
        private decimal calcPaymentDin(decimal valueRemaing, decimal valuePaied)
        {
            decimal totalRest = valueRemaing; //valor restante
            
            decimal valueDin = Convert.ToDecimal(txtValorDin.Text.Replace(".", ",")); //valor informado em dinheiro

            decimal paied = valuePaied; // pega valor já pago

            decimal installments = nudParcelasDin.Value; // quantidade de parcelas
            
            decimal firstInstallment = Convert.ToDecimal(txtPrimParcDin.Text.Replace(".", ",")); // valor da 1º parcela

            decimal valueByInstallments = 0; // valor por parcela

            if (firstInstallment != 0 && installments == 2)
                valueByInstallments = Math.Round(valueDin - firstInstallment);
            else if (firstInstallment != 0)
            {
                if (installments == 1)
                {
                    txtPrimParcDin.Text = "0";
                    valueByInstallments = valueDin;
                }
                else
                {
                    installments = installments - 1;
                    valueByInstallments = Math.Round((valueDin - firstInstallment) / installments, 2); // valor por parcela
                }
            }
            else
                valueByInstallments = Math.Round((valueDin - firstInstallment) / installments, 2); // valor por parcela

            lblValorPorParcelaDin.Text = valueByInstallments.ToString(); //exibe valor por parcela

            decimal totalPaied = paied + valueDin; //calcula total já pago

            lblValorTotalPago.Text = totalPaied.ToString(); // exibe/atualiza valor total pago

            lblValorRestante.Text = (totalRest - valueDin).ToString();

            return valueDin;
        }

        //CALC PAYMENT ON CHEQUE
        private decimal calcPaymentCheq(decimal valueRemaing, decimal valuePaied)
        {
            decimal totalRest = valueRemaing; //valor restante

            decimal valueCheq = Convert.ToDecimal(txtValorCheq.Text.Replace(".", ",")); 

            decimal paied = valuePaied; // pega valor já pago

            decimal installments = nudParcelasCheq.Value; // quantidade de parcelas

            decimal firstInstallment = Convert.ToDecimal(txtPrimParcCheq.Text.Replace(".", ",")); // valor da 1º parcela

            decimal valueByInstallments = 0;

            if (firstInstallment != 0 && installments == 2)
                valueByInstallments = Math.Round(valueCheq - firstInstallment);
            else if (firstInstallment != 0)
                {
                    if (installments == 1)
                    {
                        txtPrimParcCheq.Text = "0";
                        valueByInstallments = valueCheq;
                    }else
                    {
                        installments = installments - 1;
                        valueByInstallments = Math.Round((valueCheq - firstInstallment) / installments, 2); // valor por parcela
                    }
                }else
                    valueByInstallments =  Math.Round((valueCheq - firstInstallment) / installments, 2); // valor por parcela

            lblValorPorParcelaCheq.Text = valueByInstallments.ToString(); //exibe valor por parcela

            decimal totalPaied = paied + valueCheq; //calcula total já pago

            lblValorTotalPago.Text = totalPaied.ToString(); // exibe/atualiza valor total pago

            lblValorRestante.Text = (totalRest - valueCheq).ToString();

            return valueCheq;
        }

        private void call(string type)
        {
            InoxErpContext ctx = new InoxErpContext();
            Budgets_OS b = new Budgets_OS();
            Budget_OSBusiness obj = new Budget_OSBusiness(ctx);

            b = obj.ReturnByID(id);

            checkTxt(); //verifica campos vazios

            //recebe todos os dados
            decimal totalOS = b.Items.Sum(i => i.dTotal);

            decimal desc = Convert.ToDecimal(calcDesc().Replace(".", ",")) - totalOS;

            decimal rate = Convert.ToDecimal(calcRate().Replace(".", ",")) - totalOS;

            decimal round = Convert.ToDecimal(txtValorArredondamento.Text.Replace(".", ","));
            
            decimal entry = returnEntry();

            decimal rest = Math.Round(totalOS + desc + rate - round - entry, 2); //valor que falta pagar

            if (type.Equals("din"))
            {
                decimal cheq = calcPaymentCheq(rest, entry);
                decimal final = rest - cheq;
                calcPaymentDin(final, entry + cheq);
            }

            if (type.Equals("cheq"))
            {
                decimal din = calcPaymentDin(rest, entry);
                decimal final = rest - din;
                calcPaymentCheq(final, entry + din);
            }

            lblExibeValorOS.Text = (totalOS + desc + rate - round).ToString();
        }

        //DIALOG OPTIONS
        public DialogResult messageYesNo(string type)
        {
            switch (type)
            {
                case "confirm":
                    return MessageBox.Show("Confirma a Aprovação do Orçamento e os Lançamentos no Caixa ?", "Aprovar Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "valueMax":
                    return MessageBox.Show("O Valor Informado é Maior que o valor do Orçamento, Confirma ?", "Valor Maior", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "change":
                    return MessageBox.Show("O Valor do TROCO é referente a CHEQUE ?", "Troco", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            return DialogResult.No;
        }

        

        private bool checkValuestoApprove()
        {
            decimal valueOS = Convert.ToDecimal(lblExibeValorOS.Text.Replace(".", ","));
            decimal valuePaied = Convert.ToDecimal(lblValorTotalPago.Text.Replace(".", ","));

            if (valuePaied < valueOS)
            {
                MessageBox.Show("***   Valor total do Orçamento ainda NÃO foi pago   ***");
                return false;
            }

            if (!checkValueMax(valueOS, valuePaied))
                return false;

            return true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //call("din");
            if(checkValuestoApprove())
                if (messageYesNo("confirm") == DialogResult.Yes)
                {
                    doReleases();
                    Dispose();
                }
                else
                    MessageBox.Show("Orçamento NÃO foi Aprovado, Lançamentos A Receber Cancelados !!!");
        }

        private void doReleases()
        {
            MessageBoxTimer msg = new MessageBoxTimer(); // TITULO , MSG , TIPO , TEMPO
            msg.Show("Lançamentos","Por Favor Aguarde... Fazendo Lançamentos À Receber ...",0,3000);
           
            cacthValues();

            decimal valueRemaing = Convert.ToDecimal(lblValorRestante.Text.Replace(".", ","));

            if (valueRemaing < 0)
            {
                msg.Show("Troco do Cliente","Valor do Troco: " + (valueRemaing * -1),0,5000);
                if (messageYesNo("change") == DialogResult.Yes)
                {
                    throwOut(valueRemaing);
                    msg.Show("Lançamento de Saída", "Saída incluida no Caixa", 0, 3000);
                }
            }

            msg.Show("Aprovação de Orçamento", "Orçamento Aprovado e Lançamentos Concluidos", 0, 5000);
        }

        private void throwOut(decimal valueRemaing)
        {
            InoxErpContext ctx = new InoxErpContext();

            Budget_OSBusiness objBud = new Budget_OSBusiness(ctx);
            CashBusiness objCash = new CashBusiness(ctx);

            Budgets_OS b = objBud.ReturnByID(id);
            
            Cash cash = new Cash
            {
                sID = Guid.NewGuid().ToString(),

                sId_Budgets_OS = b.sID,
                sId_Client = b.IdClients,
                dValue = -valueRemaing,
                dtDate = DateTime.Now,
                dBalance = objCash.returnBalance(-valueRemaing),
                sReferentTo = "TROCO O.S.  " + b.iCod.ToString(),
                CashType = CashType.Out
            };

            objCash.Insert(cash);
        }

        private void cacthValues()
        {
            //entrada
            decimal eDin = Convert.ToDecimal(txtEntradaDin.Text.Replace(".", ","));
            decimal eCheq = Convert.ToDecimal(txtEntradaCheq.Text.Replace(".", ","));

            //pagtos
            decimal vDin = 0;
            decimal vCheq = 0;

            //parcelamentos
            decimal iDin = nudParcelasDin.Value;
            decimal iCheq = nudParcelasCheq.Value;

            //primeira parcela
            decimal ppDin = 0;
            decimal ppCheq = 0;

            //prazos
            decimal pDin = nudPrazoDin.Value;
            decimal pCheq = nudPrazoCheq.Value;
            
            if (!txtValorDin.Text.Equals("") && !txtValorDin.Text.Equals("0"))
                vDin = Convert.ToDecimal(txtValorDin.Text.Replace(".", ","));

            if (!txtValorCheq.Text.Equals("") && !txtValorCheq.Text.Equals("0"))
                vCheq = Convert.ToDecimal(txtValorCheq.Text.Replace(".", ","));
            
            if (!txtPrimParcDin.Text.Equals("") && !txtPrimParcDin.Text.Equals("0"))
                ppDin = Convert.ToDecimal(txtPrimParcDin.Text.Replace(".", ","));

            if (!txtPrimParcCheq.Text.Equals("") && !txtPrimParcCheq.Text.Equals("0"))
                ppCheq = Convert.ToDecimal(txtPrimParcCheq.Text.Replace(".", ","));

            decimal valueOS = Convert.ToDecimal(lblExibeValorOS.Text.Replace(".", ","));

            fillPayment(valueOS,eDin,vDin,iDin,ppDin,pDin,eCheq,vCheq,iCheq,ppCheq,pCheq);

        }

        private void fillPayment(decimal valueOS, decimal eDin, decimal vDin, decimal iDin, decimal ppDin, decimal pDin, decimal eCheq, decimal vCheq, decimal iCheq, decimal ppCheq, decimal pCheq)
        {
            InoxErpContext ctx = new InoxErpContext();
            Budgets_OS b = new Budgets_OS();
            Budget_OSBusiness objBud = new Budget_OSBusiness(ctx);
            
            b = objBud.ReturnByID(id);

            AccountsToReceiveBusiness objAcr = new AccountsToReceiveBusiness(ctx);
            ChequesBusiness objChq = new ChequesBusiness(ctx);
            CashBusiness objCash = new CashBusiness(ctx);

            List<Cash> listCashs = fillListCash(b, eDin, eCheq, valueOS);
            List<AccountsToReceive> listReceives = fillListReceive(b,vDin,iDin,ppDin,pDin);
            List<Cheques> listCheques = fillListCheques(b, vCheq, iCheq, ppCheq, pCheq);

            if (listCashs.Count > 0)
                foreach (var cash in listCashs)
                    objCash.Insert(cash);

            if (listReceives.Count > 0)
                foreach (var receive in listReceives)
                    objAcr.Insert(receive);

            if (listCheques.Count > 0)
                foreach (var cheque in listCheques)
                    objChq.Insert(cheque);

            b.bServiceOrderApproved = true;
            b.dtDateServiceOrderApproved = DateTime.Now;
            b.dtStartPrevision = DateTime.Now;
            b.dtFinalPrevision = DateTime.Now.AddDays(b.iPrevisionOfExecute);
            objBud.Update(b);
        }

        private List<AccountsToReceive> fillListReceive(Budgets_OS budget, decimal vDin, decimal iDin, decimal ppDin, decimal pDin)
        {
            List<AccountsToReceive> list = new List<AccountsToReceive>();
            
            if (iDin == 1)
            {
                if (vDin > 0)
                {
                    AccountsToReceive receive1 = new AccountsToReceive();

                    receive1.sID = Guid.NewGuid().ToString();

                    receive1.sId_Budgets_OS = budget.sID;
                    receive1.sId_Client = budget.IdClients;
                    receive1.dtIssue = DateTime.Now;
                    receive1.dtReceiveDate = DateTime.Now;
                    receive1.bReceivePaid = false;
                    receive1.sReferentTo = "O.S.  " + budget.iCod;
                    receive1.Budgets_OS = budget;

                    receive1.dValue = vDin;
                    receive1.dRemaing = vDin;
                    receive1.dPaid = 0;
                    receive1.dtDueDate = DateTime.Today.AddDays(Convert.ToDouble(pDin));
                    receive1.iInstallment = Convert.ToInt32(iDin);
                    receive1.iAmountInstallment = Convert.ToInt32(iDin);

                    list.Add(receive1);
                }
            }else if (iDin > 1)
            {
                if (vDin > 0)
                {
                    DateTime due = DateTime.Today;
                    decimal ppDinAux = ppDin;

                    for (int i = 1; i <= iDin; i++)
                    {
                        if (ppDinAux > 0)
                        {
                            AccountsToReceive receive2 = new AccountsToReceive();

                            receive2.sID = Guid.NewGuid().ToString();

                            receive2.sId_Budgets_OS = budget.sID;
                            receive2.sId_Client = budget.IdClients;
                            receive2.dtIssue = DateTime.Now;
                            receive2.dtReceiveDate = DateTime.Now;
                            receive2.bReceivePaid = false;
                            receive2.sReferentTo = "O.S.  " + budget.iCod;
                            receive2.Budgets_OS = budget;

                            receive2.dValue = ppDin;
                            receive2.dRemaing = ppDin;
                            receive2.dPaid = 0;
                            due = due.AddDays(Convert.ToDouble(pDin));
                            receive2.dtDueDate = due;
                            receive2.iInstallment = i;
                            receive2.iAmountInstallment = Convert.ToInt32(iDin);

                            list.Add(receive2);

                            ppDinAux = 0;
                        }
                        else
                        {
                            AccountsToReceive receive3 = new AccountsToReceive();

                            receive3.sID = Guid.NewGuid().ToString();

                            receive3.sId_Budgets_OS = budget.sID;
                            receive3.sId_Client = budget.IdClients;
                            receive3.dtIssue = DateTime.Now;
                            receive3.dtReceiveDate = DateTime.Now;
                            receive3.bReceivePaid = false;
                            receive3.sReferentTo = "O.S.  " + budget.iCod;
                            receive3.Budgets_OS = budget;
                            receive3.dPaid = 0;
                            due = due.AddDays(Convert.ToDouble(pDin));
                            receive3.dtDueDate = due;
                            receive3.iInstallment = i;
                            receive3.iAmountInstallment = Convert.ToInt32(iDin);

                            

                            if (ppDin != 0 && iDin == 2)
                            {
                                receive3.dValue = vDin - ppDin;
                            }
                            else if (iDin != 0)
                            {
                                decimal j = iDin - 1;
                                receive3.dValue = (vDin - ppDin) / j;
                                receive3.dRemaing = (vDin - ppDin) / j;
                            }
                            else
                            {
                                receive3.dValue = (vDin - ppDin) / iDin;
                                receive3.dRemaing = (vDin - ppDin) / iDin;
                            }

                            list.Add(receive3);
                        }
                    }
                }
            }

            return list;
        }

        private List<Cheques> fillListCheques(Budgets_OS budget, decimal vCheq, decimal iCheq, decimal ppCheq, decimal pCheq)
        {
            List<Cheques> list = new List<Cheques>();

            if (iCheq == 1)
            {
                if (vCheq > 0)
                {
                    Cheques cheque1 = new Cheques();

                    cheque1.sID = Guid.NewGuid().ToString();

                    cheque1.sId_Budgets_OS = budget.sID;
                    cheque1.sId_Client = budget.IdClients;
                    cheque1.dtIssue = DateTime.Now;
                    cheque1.dtPayDate = DateTime.Now;
                    cheque1.bChequePaid = false;
                    cheque1.sChequeNumber = "0";
                    cheque1.sReferentTo = "O.S.  " + budget.iCod.ToString();

                    cheque1.dValue = vCheq;
                    cheque1.dtDueDate = DateTime.Today.AddDays(Convert.ToDouble(pCheq));
                    cheque1.iInstallment = Convert.ToInt32(iCheq);
                    cheque1.iAmountInstallment = Convert.ToInt32(iCheq);

                    list.Add(cheque1);
                }
            }
            else if (iCheq > 1)
            {
                if (vCheq > 0)
                {
                    DateTime due = DateTime.Today;
                    decimal ppCheqAux = ppCheq;

                    for (int i = 1; i <= iCheq; i++)
                    {
                        if (ppCheqAux > 0)
                        {
                            Cheques cheque2 = new Cheques();

                            cheque2.sID = Guid.NewGuid().ToString();

                            cheque2.sId_Budgets_OS = budget.sID;
                            cheque2.sId_Client = budget.IdClients;
                            cheque2.dtIssue = DateTime.Now;
                            cheque2.dtPayDate = DateTime.Now;
                            cheque2.bChequePaid = false;
                            cheque2.sChequeNumber = "0";
                            cheque2.sReferentTo = "O.S.  " + budget.iCod.ToString();

                            cheque2.dValue = ppCheq;
                            due = due.AddDays(Convert.ToDouble(pCheq));
                            cheque2.dtDueDate = due;
                            cheque2.iInstallment = i;
                            cheque2.iAmountInstallment = Convert.ToInt32(iCheq);

                            list.Add(cheque2);

                            ppCheqAux = 0;
                        }
                        else
                        {
                            Cheques cheque3 = new Cheques();

                            cheque3.sID = Guid.NewGuid().ToString();

                            cheque3.sId_Budgets_OS = budget.sID;
                            cheque3.sId_Client = budget.IdClients;
                            cheque3.dtIssue = DateTime.Now;
                            cheque3.dtPayDate = DateTime.Now;
                            cheque3.bChequePaid = false;
                            cheque3.sChequeNumber = "0";
                            cheque3.sReferentTo = "O.S.  " + budget.iCod.ToString();
                            due = due.AddDays(Convert.ToDouble(pCheq));
                            cheque3.dtDueDate = due;
                            cheque3.iInstallment = i;
                            cheque3.iAmountInstallment = Convert.ToInt32(iCheq);

                            if (ppCheq != 0 && iCheq == 2)
                                cheque3.dValue = vCheq - ppCheq;
                            else if (iCheq != 0)
                            {
                                decimal j = iCheq - 1;
                                cheque3.dValue = (vCheq - ppCheq) / j; // valor por parcela
                            }
                            else
                                cheque3.dValue = (vCheq - ppCheq) / iCheq; // valor por parcela

                            list.Add(cheque3);
                        }
                    }
                }
            }

            return list;
        }

        private List<Cash> fillListCash(Budgets_OS budget, decimal eDin, decimal eCheq, decimal valueOS)
        {
            InoxErpContext ctxP = new InoxErpContext();
            CashBusiness objPersist = new CashBusiness(ctxP);
            
            List<Cash> list = new List<Cash>();

            if (eDin > valueOS)
                eDin = valueOS;

            if (eDin > 0)
            {
                Cash cash1 = new Cash();

                cash1.sID = Guid.NewGuid().ToString();

                cash1.sId_Budgets_OS = budget.sID;
                cash1.sId_Client = budget.IdClients;
                cash1.dValue = eDin;
                cash1.dBalance = objPersist.returnBalance(eDin);
                cash1.dtDate = DateTime.Now;
                cash1.sReferentTo = "O.S.  " + budget.iCod;
                cash1.CashType = CashType.Enter;

                list.Add(cash1);
            }

            if (eCheq > 0)
            {
                Cash cash2 = new Cash();

                cash2.sID = Guid.NewGuid().ToString();

                cash2.sId_Budgets_OS = budget.sID;
                cash2.sId_Client = budget.IdClients;
                cash2.dValue = eCheq;
                cash2.dBalance = objPersist.returnBalance(eDin);
                cash2.dtDate = DateTime.Now;
                cash2.sReferentTo = "O.S.  " + budget.iCod;
                cash2.CashType = CashType.Enter;

                list.Add(cash2);
            }

            return list;
        }
        
        private void txtPorcentDescAVista_TextChanged(object sender, EventArgs e)
        {
            calcDesc();
        }

        private void txtPorcentJuros_TextChanged(object sender, EventArgs e)
        {
            calcRate();
        }

        private void txtValorArredondamento_Leave(object sender, EventArgs e)
        {
            calcRound();

            if (!txtEntradaDin.Text.Equals("") || !txtEntradaCheq.Text.Equals("0"))
                calcEntryDinCheq();
            if (!txtValorDin.Text.Equals("") || !txtValorDin.Text.Equals("0"))
                call("din");
            if (!txtValorCheq.Text.Equals("") || !txtValorCheq.Text.Equals("0"))
                call("cheq");
        }

        private void txtEntradaDin_Leave(object sender, EventArgs e)
        {
            calcEntryDinCheq();

            if (!txtValorDin.Text.Equals("") || !txtValorDin.Text.Equals("0"))
                call("din");
            if (!txtValorCheq.Text.Equals("") || !txtValorCheq.Text.Equals("0"))
                call("cheq");
        }

        private void txtEntradaCheq_Leave(object sender, EventArgs e)
        {
            calcEntryDinCheq();

            if (!txtValorDin.Text.Equals("") || !txtValorDin.Text.Equals("0"))
                call("din");
            if (!txtValorCheq.Text.Equals("") || !txtValorCheq.Text.Equals("0"))
                call("cheq");
        }

        private void txtValorDin_Leave(object sender, EventArgs e)
        {
            call("din");
        }
        
        private void nudParcelasDin_Leave(object sender, EventArgs e)
        {
            call("din");
        }

        private void txtPrimParcDin_Leave(object sender, EventArgs e)
        {
            call("din");
        }

        private void txtValorCheq_Leave(object sender, EventArgs e)
        {
            call("cheq");
        }

        private void nudParcelasCheq_Leave(object sender, EventArgs e)
        {
            call("cheq");
        }

        private void txtPrimParcCheq_Leave(object sender, EventArgs e)
        {
            call("cheq");
        }

        private void nudParcelasCheq_ValueChanged(object sender, EventArgs e)
        {
            call("cheq");
        }

        private void nudParcelasDin_ValueChanged(object sender, EventArgs e)
        {
            call("din");
        }

        //WHEN KEY IS PRESS ON txtPorcentDescAVista
        private void txtPorcentDescAVista_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbersAndComma(sender, e);
        }

        //WHEN KEY IS PRESS ON txtPorcentJuros
        private void txtPorcentJuros_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbersAndComma(sender, e);
        }

        //WHEN KEY IS PRESS ON txtValorArredondamento
        private void txtValorArredondamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbersAndComma(sender, e);

            if ((Keys) e.KeyChar == Keys.Enter)
            {
                calcRound();
                if(!txtEntradaDin.Text.Equals("") || !txtEntradaCheq.Text.Equals("0"))
                    calcEntryDinCheq();
                if(!txtValorDin.Text.Equals("") || !txtValorDin.Text.Equals("0"))
                    call("din");
                if (!txtValorCheq.Text.Equals("") || !txtValorCheq.Text.Equals("0"))
                    call("cheq");
            }
        }

        //WHEN KEY IS PRESS ON txtEntradaDin
        private void txtEntradaDin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbersAndComma(sender, e);

            if ((Keys) e.KeyChar == Keys.Enter)
            {
                calcEntryDinCheq();
                
                if (!txtValorDin.Text.Equals("") || !txtValorDin.Text.Equals("0"))
                    call("din");
                if (!txtValorCheq.Text.Equals("") || !txtValorCheq.Text.Equals("0"))
                    call("cheq");
            }
        }

        //WHEN KEY IS PRESS ON txtEntradaCheq
        private void txtEntradaCheq_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbersAndComma(sender, e);

            if ((Keys) e.KeyChar == Keys.Enter)
            {
                calcEntryDinCheq();

                if (!txtValorDin.Text.Equals("") || !txtValorDin.Text.Equals("0"))
                    call("din");
                if (!txtValorCheq.Text.Equals("") || !txtValorCheq.Text.Equals("0"))
                    call("cheq");
            }
        }

        //WHEN KEY IS PRESS ON txtValorDin
        private void txtValorDin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbersAndComma(sender, e);

            if ((Keys)e.KeyChar == Keys.Enter)
                call("din");
        }

        //WHEN KEY IS PRESS ON txtPrimParcDin
        private void txtPrimParcDin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbersAndComma(sender, e);

            if ((Keys)e.KeyChar == Keys.Enter)
                call("din");
        }

        //WHEN KEY IS PRESS ON txtValorCheq
        private void txtValorCheq_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbersAndComma(sender, e);

            if ((Keys)e.KeyChar == Keys.Enter)
                call("cheq");
        }

        //WHEN KEY IS PRESS ON txtPrimParcCheq
        private void txtPrimParcCheq_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbersAndComma(sender, e);

            if ((Keys)e.KeyChar == Keys.Enter)
                call("cheq");
        }

        //WHEN RADDESCONTO IS SELECTED
        private void radDesconto_CheckedChanged(object sender, EventArgs e)
        {
            checkDescOrRate();
        }

        //WHEN RADDJUROS IS SELECTED
        private void radJuros_CheckedChanged(object sender, EventArgs e)
        {
            checkDescOrRate();
        }

        //WHEN CHKLIMPAR IS CHECKED
        private void chkLimpar_CheckedChanged(object sender, EventArgs e)
        {
            checkDescOrRate();
        }
    }
}
