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
        ValidationEntries validation = new ValidationEntries();

        private string id { get; set; }
        
        public frmPaymentForms(string id)
        {
            this.id = id;
            InitializeComponent();
            fillFrm(id);
        }

        public void validationEntriesNumerics(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }

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
        
        private void checkTxt()
        {
            if (txtPorcentDescAVista.Text.Equals(""))
                txtPorcentDescAVista.Text = "0";

            if (txtPorcentJuros.Text.Equals(""))
                txtPorcentJuros.Text = "0";

            if (txtValorArredondamento.Text.Equals(""))
                txtValorArredondamento.Text = "0";

            if (txtValorDin.Text.Equals(""))
                txtValorDin.Text = "0";

            if (txtValorCheq.Text.Equals(""))
                txtValorCheq.Text = "0";
        }

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

        public void checkDescOrRate()
        {
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
                radJuros.Checked = false;
                txtPorcentJuros.Enabled = false;
                txtPorcentJuros.Text = "0,00";

                txtPorcentDescAVista.Enabled = true;

            }else
            if (radJuros.Checked)
            {
                radDesconto.Checked = false;
                txtPorcentDescAVista.Enabled = false;
                txtPorcentDescAVista.Text = "0,00";

                txtPorcentJuros.Enabled = true;

            }
        }

        private void radDesconto_CheckedChanged(object sender, EventArgs e)
        {
            checkDescOrRate();
        }

        private void radJuros_CheckedChanged(object sender, EventArgs e)
        {
            checkDescOrRate();
        }

        private void chkLimpar_CheckedChanged(object sender, EventArgs e)
        {
            checkDescOrRate();
        }
        
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

        private void calcRound()
        {
            InoxErpContext ctx = new InoxErpContext();
            Budgets_OS b = new Budgets_OS();
            Budget_OSBusiness obj = new Budget_OSBusiness(ctx);

            b = obj.ReturnByID(id);

            if (!txtValorArredondamento.Text.Equals(""))
            {
                decimal valueTotal = b.dTotal;
                decimal round = Convert.ToDecimal(txtValorArredondamento.Text.Replace(".", ","));
                decimal final = Math.Round(valueTotal - round, 2);
                lblExibeValorOS.Text = final.ToString();
            }
            else
                lblExibeValorOS.Text = b.dTotal.ToString();
        }

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

        private void txtPorcentDescAVista_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);

            if (e.KeyChar == 13)
            {
                calcDesc();
            }

        }

        private void txtPorcentJuros_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);

        }

        private void txtValorArredondamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);

            if (e.KeyChar == 13)
            {
                calcRound();
            }
        }

        private void txtEntradaDin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);

        }

        private void txtEntradaCheq_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);

        }

        private void txtValorDin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);

        }

        private void txtPrimParcDin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);

        }

        private void txtValorCheq_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);

        }

        private void txtPrimParcCheq_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);

        }
    }
}
