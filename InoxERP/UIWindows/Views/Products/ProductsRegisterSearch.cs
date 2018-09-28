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
    //Para facilitar o preenchimento dos produtos,
    //o cadatro de produtos terá o preço unitário e total,
    //quando ele escolher o item e adicionar já será calculado o lucro de 100% em cima do valor do produto.

    public partial class frmProductsRegisterSearch : Form
    {
        static InoxErpContext ctx = new InoxErpContext();
        ProductBusiness obj = new  ProductBusiness(ctx);

        public frmProductsRegisterSearch()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!validationCamps())
                MessageBox.Show("Por Favor preencha as informações Corretamente");
            else
            {
                Products productPersist = new Products();

                productPersist.sID = Guid.NewGuid().ToString();

                productPersist.sDescription = txtPeca.Text;
                productPersist.dAmount = Convert.ToDouble(nudQuantidade.Text);
                productPersist.Type = UnityType();
                productPersist.dPrice = Convert.ToDecimal(txtValorUnitario.Text);
                productPersist.dTotal = Convert.ToDecimal(txtValorTotal.Text);
                productPersist.sObservation = txtObservacao.Text;

                if (messageYesNo("insert") == DialogResult.Yes)
                {
                    obj.Insert(productPersist);


                    var ok = obj.Search.FirstOrDefault(b => b.sID == productPersist.sID);

                    if (ok == null)
                        MessageBox.Show("Erro ao Cadastrar o Produto !!!");
                    else
                        MessageBox.Show("Produto Cadastrado com Sucesso !!!");

                    afterAction();
                }
            }
        }

        public UnityType UnityType()
        {
            if (radUN.Checked)
                return Entities.Enum.UnityType.UN;
            if (radMT.Checked)
                return Entities.Enum.UnityType.MT;
            if (radKG.Checked)
                return Entities.Enum.UnityType.KG;
            return 0;
        }

        public DialogResult messageYesNo(string type)
        {
            switch (type)
            {
                case "insert":
                    return MessageBox.Show("Confirma a inclusão ?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "update":
                    return MessageBox.Show("Confirma a atualização ?", "Atualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "delete":
                    return MessageBox.Show("Confirma a Exclusão ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }

            return DialogResult.No;
        }

        public void afterAction()
        {
            fillDataSet();
            cleanCamps();
        }

        //CLEAN
        public void cleanCamps()
        {
            txtPeca.Clear();
            nudQuantidade.Value = 0;
            radUN.Checked = false;
            radMT.Checked = false;
            radKG.Checked = false;
            txtValorUnitario.Clear();
            txtValorTotal.Clear();
            txtFornecedor.Clear();
            txtObservacao.Clear();
            txtConsultaPeca.Clear(); // limpa até o campo de consulta.
        }

        //overrid FILL DATASET
        public void fillDataSet()
        {
            // TODO: esta linha de código carrega dados na tabela 'fullDataSet.tb_products'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_productsTableAdapter.Fill(this.fullDataSet.tb_products);
        }

        public bool validationCamps()
        {
            if (txtPeca.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um Nome para o Produto / Peça");
                txtPeca.Focus();
                return false;
            }

            if (nudQuantidade.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe a quantidade para o Produto / Peça");
                nudQuantidade.Focus();
                return false;
            }

            if (!radUN.Checked & !radKG.Checked & !radMT.Checked)
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
            if (!decimal.TryParse(txtValorUnitario.Text, out d)) // validator of numbers
            {
                if (txtValorUnitario.Text == "")
                { }
                else
                {
                    txtValorUnitario.Focus();
                    txtValorUnitario.Text = "";
                }
            }
            else
            if (nudQuantidade.Text.Length.Equals(0))
            {
                nudQuantidade.Text = "0";
            }
            else
            if (txtValorUnitario.Text.Length.Equals(0))
            {
                txtValorUnitario.Text = "";
                txtValorTotal.Text = "0";

            }
            else
            {
                //decimal total = stringReplacePoint(Convert.ToDecimal(txtQuantidade.Text.Replace(",","."))) * stringReplacePoint(Convert.ToDecimal(txtValorUnitario.Text.Replace(",",".")));
                decimal total = Convert.ToDecimal(nudQuantidade.Text.Replace(".", ",")) * Convert.ToDecimal(txtValorUnitario.Text.Replace(".", ","));
                txtValorTotal.Text = Convert.ToString(total);
            }

        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {
            if (nudQuantidade.Text != "")
                valueTotal();
        }

        private void txtValorUnitario_TextChanged(object sender, EventArgs e)
        {
            if (txtValorUnitario.Text != "")
                valueTotal();
        }

        private void frmProductsRegisterSearch_Load(object sender, EventArgs e)
        {
            fillDataSet();
        }
    }
}
