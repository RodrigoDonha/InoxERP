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

namespace UIWindows.Views.Budgets
{
    public partial class frmServiceCalc : Form
    {
        private decimal lblProducts = 0;
        public frmServiceCalc(decimal lblProducts)
        {
            this.lblProducts = lblProducts;
            InitializeComponent();
            lblValueProducts.Text = Convert.ToString(lblProducts);
        }

        private void txtPorcent_TextChanged(object sender, EventArgs e)
        {
            calcService();
        }

        public void calcService()
        {
            decimal porcent;

            if (txtPorcent.Text == "")
                porcent = 0;
            else
                porcent = Convert.ToDecimal(txtPorcent.Text.Replace(".", ",")) / 100;

            decimal valueProducts = Convert.ToDecimal(lblValueProducts.Text.Replace(".", ",")); ;
            decimal finalValue = valueProducts * porcent;

            txtTotal.Text = Convert.ToString(Math.Round(finalValue,2));
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (messageYesNo("Confirm") == DialogResult.Yes)
            {
                //frmBudgetsRegister a = new frmBudgetsRegister("");
                //a.test = Convert.ToDecimal(txtTotal.Text);

                //dgvItens.Rows.Add(1, "MÃO DE OBRA", test, test);

                Dispose();
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
    }
}
