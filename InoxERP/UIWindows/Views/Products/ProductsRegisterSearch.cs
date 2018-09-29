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
    public partial class frmProductsRegisterSearch : Form
    {
        static InoxErpContext ctx = new InoxErpContext();
        ProductBusiness obj = new  ProductBusiness(ctx);

        private string id;

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
                productPersist.dAmount = Convert.ToDouble(txtQuantidade.Text);
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
            txtQuantidade.Clear();
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

            if (txtQuantidade.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe a quantidade para o Produto / Peça");
                txtQuantidade.Focus();
                return false;
            }

            if (txtQuantidade.Text == "0")
            {
                MessageBox.Show("Você informou 0 na Quantidade");
                txtQuantidade.Focus();
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

            if (!decimal.TryParse(txtQuantidade.Text, out d)) // validator of numbers
            {
                if (txtQuantidade.Text == "")
                {}
                else
                {
                    txtQuantidade.Focus();
                    txtQuantidade.Text = "0";
                }
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
            if (txtQuantidade.Text.Length.Equals(0))
            {
                txtQuantidade.Text = "0";
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
                decimal total = Convert.ToDecimal(txtQuantidade.Text.Replace(".", ",")) * Convert.ToDecimal(txtValorUnitario.Text.Replace(".", ","));
                txtValorTotal.Text = Convert.ToString(total);
            }
        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {
            if (txtQuantidade.Text != "")
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!validationCamps())
                MessageBox.Show("Por Favor preencha as informações Corretamente");
            else
            {
                Products productsAlter = new Products();

                productsAlter = obj.ReturnByID(id);

                productsAlter.sDescription = txtPeca.Text;
                productsAlter.dAmount = Convert.ToDouble(txtQuantidade.Text);
                productsAlter.Type = UnityType();
                productsAlter.dPrice = Convert.ToDecimal(txtValorUnitario.Text);
                productsAlter.dTotal = Convert.ToDecimal(txtValorTotal.Text);
                // colocar aqui o nome do fornecedor quando a crud fornecedor estiver funfando.
                productsAlter.sObservation = txtObservacao.Text;

                if (messageYesNo("update") == DialogResult.Yes)
                {
                    obj.Update(productsAlter);

                    var ok = obj.Search.FirstOrDefault(b => b.sID == productsAlter.sID);

                    if (ok == null)
                        MessageBox.Show("Erro ao Atualizar o Produto !!!");
                    else
                        MessageBox.Show("Produto Atualizado com Sucesso !!!");

                    afterAction();

                    tbcConsultaValores.SelectedTab = Consulta;
                }
            }
        }

        private void grdConsultaPecas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = "";
            Providers providers = new Providers();
            
            int compare = grdConsultaPecas.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (compare == 0)
            { }
            else
            {
                tbcConsultaValores.SelectedTab = Cadastro;
                txtPeca.Focus();
                cleanCamps();
                id = grdConsultaPecas[0, grdConsultaPecas.CurrentRow.Index].Value.ToString();
                txtPeca.Text = grdConsultaPecas[2, grdConsultaPecas.CurrentRow.Index].Value.ToString();
                txtQuantidade.Text = grdConsultaPecas[1, grdConsultaPecas.CurrentRow.Index].Value.ToString();
                int unitType = Convert.ToInt32(grdConsultaPecas[3, grdConsultaPecas.CurrentRow.Index].Value.ToString());
                switch (unitType)
                {
                    case 1: radUN.Checked = true;
                        break;
                    case 2: radMT.Checked = true;
                        break;
                    case 3: radKG.Checked = true;
                        break;
                }
                txtValorUnitario.Text = grdConsultaPecas[4, grdConsultaPecas.CurrentRow.Index].Value.ToString();
                txtValorTotal.Text = grdConsultaPecas[5, grdConsultaPecas.CurrentRow.Index].Value.ToString();
                txtObservacao.Text = grdConsultaPecas[6, grdConsultaPecas.CurrentRow.Index].Value.ToString();
                string idProvider = grdConsultaPecas[7, grdConsultaPecas.CurrentRow.Index].Value.ToString();
                // após fazer crud de Providers, pegar o nome do Provider e passar na txtProvider.
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (id.Equals(""))
                MessageBox.Show("Selecione um Produto Primeiro");
            else if (messageYesNo("delete") == DialogResult.Yes)
            {
                obj.Delete(id);
                afterAction();
                MessageBox.Show("Excluído");
                tbcConsultaValores.SelectedTab = Consulta;
            }
        }
    }
}
