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

        //INSERT
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!validationCamps())
            { }
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

        //UPDATE
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!validationCamps())
            { }
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

        //DELETE
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (id.Equals(""))
                MessageBox.Show("Selecione um Produto Primeiro");
            else if (messageYesNo("delete") == DialogResult.Yes)
            {
                obj.Delete(id);

                var ok = obj.Search.FirstOrDefault(b => b.sID == id);

                if (ok != null)
                    MessageBox.Show("Erro ao Excluir o Produto !!!");
                else
                    MessageBox.Show("Produto Excluido com Sucesso !!!");

                afterAction();

                tbcConsultaValores.SelectedTab = Consulta;
            }
        }

        public void afterAction()
        {
            fillDataSet();
            cleanCamps();
        }
        
        //RETURN TYPE OF PRODUCT
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

        // VALIDATOR MESSAGE DIALOG
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

        //VALIDATORS CAMPS
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

        //CALC VALUE TOTAL OF PRODUCTS
        public void valueTotal()
        {
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
            {  decimal total = Convert.ToDecimal(txtQuantidade.Text.Replace(".", ",")) * Convert.ToDecimal(txtValorUnitario.Text.Replace(".", ","));
                txtValorTotal.Text = Convert.ToString(total);
            }
        }
        
        //WHEN TXTVALORUNITARIO IS CHANGED
        private void txtValorUnitario_TextChanged(object sender, EventArgs e)
        {
            if (txtValorUnitario.Text != "")
                valueTotal();
        }


        //FILLS

        //FILL DATASET
        private void frmProductsRegisterSearch_Load(object sender, EventArgs e)
        {
            fillDataSet();
        }

        //overrid FILL DATASET
        public void fillDataSet()
        {
            this.tb_productsTableAdapter.Fill(this.fullDataSet.tb_products);
        }

        //FILL TAB PRODUCTS
        private void grdConsultaPecas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = "";
            Providers providers = new Providers();
            
            int compare = dgvConsultaPecas.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (compare == 0)
            { }
            else
            {
                tbcConsultaValores.SelectedTab = Cadastro;
                txtPeca.Focus();
                cleanCamps();
                id = dgvConsultaPecas[0, dgvConsultaPecas.CurrentRow.Index].Value.ToString();
                txtPeca.Text = dgvConsultaPecas[2, dgvConsultaPecas.CurrentRow.Index].Value.ToString();
                txtQuantidade.Text = dgvConsultaPecas[1, dgvConsultaPecas.CurrentRow.Index].Value.ToString();
                int unitType = Convert.ToInt32(dgvConsultaPecas[3, dgvConsultaPecas.CurrentRow.Index].Value.ToString());
                switch (unitType)
                {
                    case 1: radUN.Checked = true;
                        break;
                    case 2: radMT.Checked = true;
                        break;
                    case 3: radKG.Checked = true;
                        break;
                }
                txtValorUnitario.Text = dgvConsultaPecas[4, dgvConsultaPecas.CurrentRow.Index].Value.ToString();
                txtValorTotal.Text = dgvConsultaPecas[5, dgvConsultaPecas.CurrentRow.Index].Value.ToString();
                txtObservacao.Text = dgvConsultaPecas[6, dgvConsultaPecas.CurrentRow.Index].Value.ToString();
                string idProvider = dgvConsultaPecas[7, dgvConsultaPecas.CurrentRow.Index].Value.ToString();
                // após fazer crud de Providers, pegar o nome do Provider e passar na txtProvider.
            }
        }

        //SEARCH
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            searchByName();
        }

        //SEARCH BY NAME
        public void searchByName()
        {
            var search = from g in ctx.Products where g.sDescription.StartsWith(txtConsultaPeca.Text) select g;

            if (search.ToList().Count.Equals(0))
            {
                txtConsultaPeca.Clear();
                MessageBox.Show("Produto Não Encontrado");
            }
            else
            {
                txtConsultaPeca.Clear();
                dgvConsultaPecas.DataSource = search.ToList();
            }
        }
    }
}
