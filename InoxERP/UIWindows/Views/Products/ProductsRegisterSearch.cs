
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InoxERP.UI_Windows_Forms;
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
        frmProviderSearch provider = new frmProviderSearch();
        ValidationEntries validation = new ValidationEntries();

        public Products ReturnProducts { get; set; }

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
            else if(findEqualsProducts())
                {
                    Products productPersist = new Products();

                    productPersist.sID = Guid.NewGuid().ToString();

                    productPersist.sDescription = txtPeca.Text;
                    productPersist.dAmount = Convert.ToDouble(txtQuantidade.Text);
                    productPersist.Type = UnityType();
                    productPersist.dPrice = Convert.ToDecimal(txtValorUnitario.Text);
                    productPersist.dTotal = Convert.ToDecimal(txtValorTotal.Text);
                    if (provider.returnProviders != null)
                        productPersist.IdProviders = provider.returnProviders.sID;
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
                if(provider.returnProviders != null)
                    productsAlter.IdProviders = provider.returnProviders.sID;
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
            searchByName();
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

        //FIND PRODUCTS ALREADY REGISTRADED
        private bool findEqualsProducts()
        {
            var result = from p in ctx.Products where p.sDescription.Contains(txtPeca.Text) select p;
            if (result.ToList().Count > 0)
                if (messageYesNo("equals") == DialogResult.Yes)
                    return true;
                else
                    return false;

            return true;
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
                case "provider":
                    return MessageBox.Show("Confirma o Fornecedor ?", "Fornecedor", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "equals":
                    return MessageBox.Show("Produto com o Mesmo Nome Já Cadastrado, Confirma Nova Inclusão ?", "Produto Igual Encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
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
            searchByName();
        }

        //overrid FILL DATASET
        public void fillDataSet()
        {
            this.tb_productsTableAdapter.Fill(this.fullDataSet.tb_products);
        }

        //SEARCH FOR OPEN FORMS
        public static bool OpenForm(Type frmType)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Equals(frmType))
                    return true;
            }
            return false;
        }

        //GET PRODUCTS DATA
        private void grdConsultaPecas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OpenForm(typeof(frmBudgetsRegister)))
            {
                try
                {
                    ReturnProducts = obj.ReturnByID(selectProducts());
                    Hide();
                }
                catch
                {
                    MessageBox.Show("Não foi possível selecionar o Produto, tente selecionar novamente.");
                }
            }
            else
                fillDataOnTab();
            
        }

        //SEARCH
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            searchByName();
        }

        //SEARCH BY NAME
        public void searchByName()// ESSA FUNÇÃO FOI CRIADA DEVIDO AO FILL TRAZER AS MEDIDAS COMO NUMEROS, ESTA TRAZ CERTO
        {
           var search = from g in ctx.Products where g.sDescription.StartsWith(txtConsultaPeca.Text) select g;

            if (search.ToList().Count.Equals(0))
            {
                txtConsultaPeca.Clear();
                MessageBox.Show("Produto Não Encontrado");
                txtConsultaPeca.Focus();
                searchByName();
            }
            else
            {
                List<Products> p = search.ToList();
                txtConsultaPeca.Clear();
                dgvConsultaPecas.DataSource = p.ToList();
            }
        }

        //SELECT PROVIDER FRM
        private void btnProcurarFornecedor_Click(object sender, EventArgs e)
        {
            provider.ShowDialog();

            if(provider.returnProviders != null)
                if (messageYesNo("provider") == DialogResult.Yes)
                {
                    txtFornecedor.Text = provider.returnProviders.sName;
                }
        }

        //FILL PRODUCTS ON TAB
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            fillDataOnTab();
        }

        public void fillDataOnTab()
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
                string unitType = dgvConsultaPecas[3, dgvConsultaPecas.CurrentRow.Index].Value.ToString();
                switch (unitType)
                {
                    case "UN":
                        radUN.Checked = true;
                        break;
                    case "MT":
                        radMT.Checked = true;
                        break;
                    case "KG":
                        radKG.Checked = true;
                        break;
                }
                txtValorUnitario.Text = dgvConsultaPecas[4, dgvConsultaPecas.CurrentRow.Index].Value.ToString();
                txtValorTotal.Text = dgvConsultaPecas[5, dgvConsultaPecas.CurrentRow.Index].Value.ToString();
                txtObservacao.Text = dgvConsultaPecas[6, dgvConsultaPecas.CurrentRow.Index].Value.ToString();
                try
                {
                    string idProvider = dgvConsultaPecas[7, dgvConsultaPecas.CurrentRow.Index].Value.ToString();

                    ProviderBusiness objProv = new ProviderBusiness(ctx);
                    txtFornecedor.Text = objProv.ReturnByID(idProvider).sName;
                }
                catch
                {

                }
            }
        }

        //RETURN ID PRODUCT
        public string selectProducts()
        {
            id = "";

            if (dgvConsultaPecas.CurrentRow != null)
            {
                id = Convert.ToString(dgvConsultaPecas[0, dgvConsultaPecas.CurrentRow.Index].Value.ToString());
                txtConsultaPeca.Text = Convert.ToString(dgvConsultaPecas[1, dgvConsultaPecas.CurrentRow.Index].Value.ToString());
            }

            return id;
        }

        public void validationEntriesNumerics(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }
    }
}
