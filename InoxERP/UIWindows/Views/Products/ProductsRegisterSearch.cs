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

namespace UIWindows
{
    //Para facilitar o preenchimento dos produtos,
    //o cadatro de produtos terá o preço unitário e total,
    //quando ele escolher o item e adicionar já será calculado o lucro de 100% em cima do valor do produto.

    public partial class frmProductsRegisterSearch : Form
    {
        static InoxErpContext ctx = new InoxErpContext();
        Products product = new Products();
        ProductBusiness obj = new  ProductBusiness(ctx);

        public frmProductsRegisterSearch()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        public bool validationCamps()
        {
            if (txtPeca.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um NOME para o Produto / Peça");
                txtPeca.Focus();
                return false;
            }

            if (nudQuantidade.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe a quantidade para o Produto / Peça");
                nudQuantidade.Focus();
                return false;
            }

            if (!radUN.Checked | !radKG.Checked | !radMT.Checked)
            {
                MessageBox.Show("Informe uma unidade de medida para o Produto / Peça");
                radMT.Focus();
                return false;
            }

            if (txtValorUnitario.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe o valor unitário para o Produto / Peça");
                txtValorUnitario.Focus();
                return false;
            }

            if (txtValorTotal.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe o valor total para o Produto / Peça");
                return false;
            }

            if (txtFornecedor.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um Fornecedor para o Produto / Peça");
                return false;
            }

            return true;
        }

        public void valueTotal()
        {
            decimal i;
            decimal d;

            if (!decimal.TryParse(nudQuantidade.Text, out i))
            {
                if (nudQuantidade.Text == "")
                {}
                else
                {
                    nudQuantidade.Focus();
                    nudQuantidade.Text = "0";
                }

                // implementar aqui a validação do campo valor unitário e demais.
            }
        }
    }
}
