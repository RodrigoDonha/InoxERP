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

            //decimal valueDesc = Convert.ToDecimal(txtPorcentDescAVista.Text.Replace(".",","));
            //decimal valuerate = Convert.ToDecimal(txtPorcentJuros.Text.Replace(".", ","));

            decimal valueRound = Convert.ToDecimal(txtValorArredondamento.Text.Replace(".", ","));
            decimal valueMoney = Convert.ToDecimal(txtValorDin.Text.Replace(".", ","));
            decimal valueCheque = Convert.ToDecimal(txtValorCheq.Text.Replace(".", ","));

            var totalValue = valueRound + valueMoney + valueCheque;

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

        //CALC ROUNDING
        private void calcRound(string value)
        {
            InoxErpContext ctx = new InoxErpContext();
            Budgets_OS b = new Budgets_OS();
            Budget_OSBusiness obj = new Budget_OSBusiness(ctx);

            b = obj.ReturnByID(id);

            if (!txtValorArredondamento.Text.Equals(""))
            {
                decimal valueTotal = 0;
                valueTotal = value.Equals("0") ? b.dTotal : Convert.ToDecimal(value); //IF Ternário
                decimal round = Convert.ToDecimal(txtValorArredondamento.Text.Replace(".", ","));
                decimal final = Math.Round(valueTotal - round, 2);
                lblExibeValorOS.Text = final.ToString();
            }
            else
                lblExibeValorOS.Text = b.dTotal.ToString();
        }

        //CALC DISCOUNT
        private void calcDesc()
        {
            InoxErpContext ctx = new InoxErpContext();
            Budgets_OS b = new Budgets_OS();
            Budget_OSBusiness obj = new Budget_OSBusiness(ctx);

            b = obj.ReturnByID(id);

           if (!txtPorcentDescAVista.Text.Equals(""))
            {
                decimal valueTotal = b.dTotal;
                decimal desc = Convert.ToDecimal(txtPorcentDescAVista.Text.Replace(".", ","));
                decimal final = Math.Round(valueTotal - (valueTotal * (desc/100)), 2);
                lblExibeValorOS.Text = final.ToString();
            }
            else
                lblExibeValorOS.Text = b.dTotal.ToString();
        }

        //CALC RATE
        private void calcRate()
        {
            InoxErpContext ctx = new InoxErpContext();
            Budgets_OS b = new Budgets_OS();
            Budget_OSBusiness obj = new Budget_OSBusiness(ctx);

            b = obj.ReturnByID(id);
            
            if (!txtPorcentJuros.Text.Equals(""))
            {
                decimal valueTotal = b.dTotal;
                decimal rate = Convert.ToDecimal(txtPorcentJuros.Text.Replace(".", ","));
                decimal final = Math.Round(valueTotal + (valueTotal * (rate / 100)), 2);
                lblExibeValorOS.Text = final.ToString();
            }
            else
                lblExibeValorOS.Text = b.dTotal.ToString();
        }
        
        //CALC ENTRY DIN CHEQ
        private void calcEntryDinCheq()
        {
            checkTxt();

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

            return totalEntry;
        }

        //CALC PAYMENT ON MONEY
        private void calcPaymentDin(string valueTotalOS)
        {
            checkTxt();

            decimal valueOS = Convert.ToDecimal(valueTotalOS.Replace(".", ",")); //valor total

            decimal entry = returnEntry(); //valor da entrada

            decimal totalRest = valueOS - entry; // valor que falta pagar

            decimal valueDin = Convert.ToDecimal(txtValorDin.Text.Replace(".", ",")); //valor informado em dinheiro

            if(valueDin > totalRest) //compara se nao é maior que o restante
                if (messageYesNo("valueMax") == DialogResult.No)
                    valueDin = 0;

            //arrumar aqui****
            decimal valuePaied = Convert.ToDecimal(lblValorTotalPago.Text.Replace(".", ",")); // pega valor já pago

            decimal installments = nudParcelasDin.Value; // quantidade de parcelas
            
            decimal firstInstallment = Convert.ToDecimal(txtPrimParcDin.Text.Replace(".", ",")); // valor da 1º parcela

            if (firstInstallment > valueDin) //compara se nao é maior que o valor em dinheiro informado
                if (messageYesNo("valueMax") == DialogResult.No)
                    firstInstallment = 0;

            decimal valueByInstallments = Math.Round((valueDin - firstInstallment) / installments, 2); // valor por parcela

            lblValorPorParcelaDin.Text = valueByInstallments.ToString(); //exibe valor por parcela

            decimal totalPaied = valuePaied + valueDin; //calcula total já pago

            lblValorTotalPago.Text = totalPaied.ToString(); // exibe/atualiza valor total pago

        }

        //DIALOG OPTIONS
        public DialogResult messageYesNo(string type)
        {
            switch (type)
            {
                case "Confirm":
                    return MessageBox.Show("Confirma a Aprovação do Orçamento e os Lançamentos no Caixa ?", "Apovar Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "valueMax":
                    return MessageBox.Show("O Valor Informado é Maior que o valor do Orçamento, Confirma ?", "Valor Maior", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            return DialogResult.No;
        }

        //WHEN KEY IS PRESS ON txtPorcentDescAVista
        private void txtPorcentDescAVista_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);

            if (e.KeyChar == 13)
            {
                calcDesc();
            }
        }

        //WHEN KEY IS PRESS ON txtPorcentJuros
        private void txtPorcentJuros_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);

            if (e.KeyChar == 13)
            {
                calcRate();
            }
        }

        //WHEN KEY IS PRESS ON txtValorArredondamento
        private void txtValorArredondamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);

            if (e.KeyChar == 13)
            {
                if (radDesconto.Checked)
                    calcRound(lblExibeValorOS.Text);
                else if(radJuros.Checked)
                    calcRound(lblExibeValorOS.Text);
                else
                    calcRound("0");
            }
        }

        //WHEN KEY IS PRESS ON txtEntradaDin
        private void txtEntradaDin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);

            if (e.KeyChar == 13)
            {
               calcEntryDinCheq();
            }
        }

        //WHEN KEY IS PRESS ON txtEntradaCheq
        private void txtEntradaCheq_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);

            if (e.KeyChar == 13)
            {
                calcEntryDinCheq();
            }
        }

        //WHEN KEY IS PRESS ON txtValorDin
        private void txtValorDin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);

            if (e.KeyChar == 13)
            {
                calcPaymentDin(lblExibeValorOS.Text);
            }
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
    }
}
