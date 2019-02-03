using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InoxERP.UI_Windows_Forms;
using UIWindows.Business.Concrete;

namespace UIWindows.Views.Budgets
{
    public partial class frmServiceCalc : Form
    {
        ValidationEntries validation = new ValidationEntries();

        private decimal porcent { get; set; }
        private decimal valueProducts { get; set; }
        public decimal finalValue { get; set; }

        private decimal lblProducts = 0;

        public frmServiceCalc(decimal lblProducts)
        {
            this.lblProducts = lblProducts;
            InitializeComponent();
            lblValordosProdutos.Text = Convert.ToString(lblProducts);
            txtTotal.Text = Convert.ToString(lblProducts);
            txtPorcentagem.Focus();
        }

        private void txtPorcent_TextChanged(object sender, EventArgs e)
        {
            validationNumbers();
            calcService();
        }

        public void calcService()
        {
            if (txtPorcentagem.Text == "")
                porcent = 0;
            else
                porcent = Convert.ToDecimal(txtPorcentagem.Text.Replace(".", ",")) / 100;

            valueProducts = Convert.ToDecimal(lblValordosProdutos.Text.Replace(".", ",")); ;
            finalValue = (valueProducts * 2 * porcent) + valueProducts;

            txtTotal.Text = Convert.ToString(Math.Round(finalValue,2));
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            finalValue = Convert.ToDecimal(txtTotal.Text);
            Dispose();
        }

        public void validationNumbers()
        {
            decimal d;

            if (!decimal.TryParse(txtPorcentagem.Text, out d)) // validator of numbers
            {
                if (txtPorcentagem.Text == "")
                {
                }
                else
                {
                    txtPorcentagem.Focus();
                    txtPorcentagem.Text = "";
                }
            }
        }

        public DialogResult messageYesNo(string type)
        {
            switch (type)
            {
                case "Confirm":
                    return MessageBox.Show("Confirma a Mão de Obra Informada?", "Lançar Mão de Obra", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            return DialogResult.No;
        }

        public void validationEntriesNumerics(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbersAndComma(sender, e);
        }
    }
}
