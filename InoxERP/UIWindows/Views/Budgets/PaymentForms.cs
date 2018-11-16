﻿using System;
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
        
        public List<DTOPaymentForm> releases { get; set; }

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
                var installmentsValue = Math.Round(divided / installments,2);

                txtValorDin.Text = divided.ToString();
                txtValorCheq.Text = divided.ToString();

                nudParcelasDin.Value = installments;
                nudParcelasCheq.Value = installments;

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

            if(totalEntry > totalOS)
                if (messageYesNo("valueMax") == DialogResult.No)
                    return totalEntry = 0;

            lblValorRestante.Text = (totalOS - totalEntry).ToString();

            return totalEntry;
        }

        //CALC PAYMENT ON MONEY
        private decimal calcPaymentDin(decimal valueRemaing, decimal valuePaied)
        {
            decimal totalRest = valueRemaing; //valor restante
            
            decimal valueDin = Convert.ToDecimal(txtValorDin.Text.Replace(".", ",")); //valor informado em dinheiro

            if(valueDin > totalRest) //compara se nao é maior que o restante
                if (messageYesNo("valueMax") == DialogResult.No)
                    valueDin = 0;

            decimal paied = valuePaied; // pega valor já pago

            decimal installments = nudParcelasDin.Value; // quantidade de parcelas
            
            decimal firstInstallment = Convert.ToDecimal(txtPrimParcDin.Text.Replace(".", ",")); // valor da 1º parcela

            if (firstInstallment > valueDin) //compara se nao é maior que o valor em dinheiro informado
                if (messageYesNo("valueMax") == DialogResult.No)
                    firstInstallment = 0;

            decimal valueByInstallments = Math.Round((valueDin - firstInstallment) / installments, 2); // valor por parcela

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

            decimal valueCheq = Convert.ToDecimal(txtValorCheq.Text.Replace(".", ",")); //valor informado em dinheiro

            if (valueCheq > totalRest) //compara se nao é maior que o restante
                if (messageYesNo("valueMax") == DialogResult.No)
                    valueCheq = 0;

            decimal paied = valuePaied; // pega valor já pago

            decimal installments = nudParcelasCheq.Value; // quantidade de parcelas

            decimal firstInstallment = Convert.ToDecimal(txtPrimParcCheq.Text.Replace(".", ",")); // valor da 1º parcela

            if (firstInstallment > valueCheq) //compara se nao é maior que o valor em dinheiro informado
                if (messageYesNo("valueMax") == DialogResult.No)
                    firstInstallment = 0;

            decimal valueByInstallments = Math.Round((valueCheq - firstInstallment) / installments, 2); // valor por parcela

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
            }
            return DialogResult.No;
        }

        //WHEN KEY IS PRESS ON txtPorcentDescAVista
        private void txtPorcentDescAVista_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }

        //WHEN KEY IS PRESS ON txtPorcentJuros
        private void txtPorcentJuros_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }

        //WHEN KEY IS PRESS ON txtValorArredondamento
        private void txtValorArredondamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }

        //WHEN KEY IS PRESS ON txtEntradaDin
        private void txtEntradaDin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }

        //WHEN KEY IS PRESS ON txtEntradaCheq
        private void txtEntradaCheq_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }

        //WHEN KEY IS PRESS ON txtValorDin
        private void txtValorDin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }

        //WHEN KEY IS PRESS ON txtPrimParcDin
        private void txtPrimParcDin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }

        //WHEN KEY IS PRESS ON txtValorCheq
        private void txtValorCheq_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }

        //WHEN KEY IS PRESS ON txtPrimParcCheq
        private void txtPrimParcCheq_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);

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
            
            return true;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            call("din");
            if(checkValuestoApprove())
                if (messageYesNo("confirm") == DialogResult.Yes)
                    doReleases();
                else
                    MessageBox.Show("Orçamento NÃO foi Aprovado, Lançamentos A Receber Cancelados !!!");
        }

        private void doReleases()
        {
            MessageBoxTimer msg = new MessageBoxTimer(); // TITULO , MSG , TIPO , TEMPO
            msg.Show("Lançamentos","Por Favor Aguarde... Fazendo Lançamentos À Receber ...",0,3000);

           
            cacthValues();


            //TROCO: 
            //decimal valueRemaing = Convert.ToDecimal(lblValorRestante.Text.Replace(".", ","));

            //if (valueRemaing < 0)
            //    MessageBox.Show("Valor do Troco: " + (valueRemaing * -1));

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

            fillPayment(eDin,vDin,iDin,ppDin,pDin,eCheq,vCheq,iCheq,ppCheq,pCheq);

        }

        private void fillPayment(decimal eDin, decimal vDin, decimal iDin, decimal ppDin, decimal pDin, decimal eCheq, decimal vCheq, decimal iCheq, decimal ppCheq, decimal pCheq)
        {
            InoxErpContext ctx = new InoxErpContext();
            Budgets_OS b = new Budgets_OS();
            Budget_OSBusiness obj = new Budget_OSBusiness(ctx);

            //criar listas de contas a receber, cheques e caixa entrada
            //colocar todos ja em seus respectivos lugares
            
            b = obj.ReturnByID(id);

            List<AccountsToReceive> listReceives = fillListReceive(b,vDin,iDin,ppDin,pDin);
            List<Cheques> listCheques = fillListCheques(b, vCheq, iCheq, ppCheq, pCheq);
            List<Cash> listCashs = fillListCash(b, eDin, eCheq);
            
        }

        private List<AccountsToReceive> fillListReceive(Budgets_OS budget, decimal vDin, decimal iDin, decimal ppDin, decimal pDin)
        {
            List<AccountsToReceive> list = new List<AccountsToReceive>();
            //AccountsToReceive receive = new AccountsToReceive();

            ////this properts don't change:
            //receive.sId_Budgets_OS = budget.sID;
            //receive.sId_Client = budget.IdClients;
            //receive.dtReceiveDate = DateTime.Today;
            //receive.bReceivePaid = false;
            //receive.sReferentTo = budget.iCod.ToString();
            //receive.Budgets_OS = budget;

            //tratar: 1º parcela, tratar qtd de parcelas senao manda parcela unica

            if (iDin == 1)
            {
                AccountsToReceive receive = new AccountsToReceive();

                //this properts don't change:
                receive.sId_Budgets_OS = budget.sID;
                receive.sId_Client = budget.IdClients;
                receive.dtReceiveDate = DateTime.Today;
                receive.bReceivePaid = false;
                receive.sReferentTo = budget.iCod.ToString();
                receive.Budgets_OS = budget;

                receive.dValue = vDin;
                receive.dtDueDate = DateTime.Today.AddDays(Convert.ToDouble(pDin));
                receive.iInstallment = Convert.ToInt32(iDin);
                receive.iAmountInstallment = Convert.ToInt32(iDin);

                list.Add(receive);
            }else if (iDin > 1)
            {
                DateTime due = DateTime.Today;
                
                for (int i = 1; i <= iDin; i++)
                {
                    if (ppDin > 0)
                    {
                        AccountsToReceive receive2 = new AccountsToReceive();

                        //this properts don't change:
                        receive2.sId_Budgets_OS = budget.sID;
                        receive2.sId_Client = budget.IdClients;
                        receive2.dtReceiveDate = DateTime.Today;
                        receive2.bReceivePaid = false;
                        receive2.sReferentTo = budget.iCod.ToString();
                        receive2.Budgets_OS = budget;

                        receive2.dValue = ppDin;
                        receive2.dtDueDate = due.AddDays(Convert.ToDouble(pDin));
                        receive2.iInstallment = i;
                        receive2.iAmountInstallment = Convert.ToInt32(iDin);

                        list.Add(receive2);

                        ppDin = 0;
                    }else
                    {
                        AccountsToReceive receive3 = new AccountsToReceive();

                        //this properts don't change:
                        receive3.sId_Budgets_OS = budget.sID;
                        receive3.sId_Client = budget.IdClients;
                        receive3.dtReceiveDate = DateTime.Today;
                        receive3.bReceivePaid = false;
                        receive3.sReferentTo = budget.iCod.ToString();
                        receive3.Budgets_OS = budget;

                        receive3.dValue = vDin/iDin;
                        due = due.AddDays(Convert.ToDouble(pDin));
                        receive3.dtDueDate = due;
                        receive3.iInstallment = i;
                        receive3.iAmountInstallment = Convert.ToInt32(iDin);

                        list.Add(receive3);
                    }
                }
            }
                

            return list;
        }

        private List<Cheques> fillListCheques(Budgets_OS budget, decimal vCheq, decimal iCheq, decimal ppCheq, decimal pCheq)
        {
            List<Cheques> list = new List<Cheques>();
            Cheques cheque = new Cheques();



            return list;
        }

        private List<Cash> fillListCash(Budgets_OS budget, decimal eDin, decimal eCheq)
        {
            List<Cash> list = new List<Cash>();
            Cash cash = new Cash();



            return list;
        }

        private void btnOkDin_Click(object sender, EventArgs e)
        {
            call("din");
        }

        private void btnOkCheq_Click(object sender, EventArgs e)
        {
            call("cheq");
        }

        private void btnOkArredondamento_Click(object sender, EventArgs e)
        {
            calcRound();
        }

        private void btnOkEntrada_Click(object sender, EventArgs e)
        {
            calcEntryDinCheq();
        }

        private void txtPorcentDescAVista_TextChanged(object sender, EventArgs e)
        {
            calcDesc();
        }

        private void txtPorcentJuros_TextChanged(object sender, EventArgs e)
        {
            calcRate();
        }
    }
}
