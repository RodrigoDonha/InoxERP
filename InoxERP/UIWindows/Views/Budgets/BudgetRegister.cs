using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WebForms;
using UIWindows;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;
using UIWindows.Entities.Enum;
using UIWindows.Views.Budgets;

namespace InoxERP.UI_Windows_Forms
{
    public partial class frmBudgetsRegister : Form
    {
        public decimal test = 0;
        static InoxErpContext ctx = new InoxErpContext();
        Budgets_OS budget = new Budgets_OS();
        Budget_OSBusiness obj = new Budget_OSBusiness(ctx);
        frmClientsSearch client = new frmClientsSearch();
        frmProductsRegisterSearch product = new frmProductsRegisterSearch();
        
        private decimal subTotal = 0;
        private string getID;
        private string getIdClient;
        private string getIdProduct;

        public frmBudgetsRegister(String Id)
        {
            InitializeComponent();
            getID = Id;
            btnProcurar.Focus();
            btnAprovar.Enabled = false;
            setDateService();
        }

        static Budgets_OS budgetAlter = new Budgets_OS();

        //INSERT
        private void btnGravarOrcamento_Click(object sender, EventArgs e)
        {
            if (btnGravarOrcamento.Text == "Alterar")
            {
                if (messageYesNo("Alter") == DialogResult.Yes)
                {
                    if (!validationCamps())
                        MessageBox.Show("Por Favor preencha as informações Corretamente");
                    else
                    {
                        //procura o orçamento para alteração
                        budgetAlter = obj.ReturnByID(getID);

                        //preenche os dados do orçamento
                        budgetAlter.dtDate = DateTime.Now;
                        budgetAlter.ClientType = clientType();
                        budgetAlter.sName = txtNome.Text;
                        budgetAlter.sAdress = txtEndereco.Text;
                        budgetAlter.sTelephone = txtTelefone.Text;
                        budgetAlter.sOccupation = txtCargo.Text;

                        //preenche items
                        checkToAlter(budgetAlter.Items.ToList());

                        budgetAlter.PaymentMethods = paymentMethods();
                        budgetAlter.bPaymentToMatch = checkPaymentForm("combine");
                        budgetAlter.dPercentDiscount = Convert.ToDecimal(txtPorcentDescAVista.Text);
                        budgetAlter.iPaymentInstallments = Convert.ToInt32(nudParcelas.Value);
                        budgetAlter.bInterestRate = checkPaymentForm("rate");
                        budgetAlter.dWithInterest = Convert.ToDecimal(txtPorcentJuros.Text);
                        budgetAlter.iPrevisionOfExecute = Convert.ToInt32(nudDias.Value);
                        budgetAlter.dtStartPrevision = dtpDataPrevistaInicio.Value;
                        budgetAlter.dtFinalPrevision = dtpDataPrevistaEntrega.Value;
                        budgetAlter.iWarrantyTime = Convert.ToInt32(nudAnos.Value);
                        budgetAlter.dtBudgetExpirationDate = dtpDataValidadeOrcamento.Value;
                        budgetAlter.sObservation = rtfObservacoes.Text;
                        budgetAlter.dTotal = Convert.ToDecimal(0.00);
                        budgetAlter.dTotal = Convert.ToDecimal(lblTotalGeralValor.Text);

                        //properts dont fill for default, needs to change to null

                        budgetAlter.bServiceOrderApproved = false;
                        budgetAlter.bRegisterFinished = false;
                        budgetAlter.dtDateServiceOrderApproved = DateTime.Now;
                        budgetAlter.dtDateRegisterFinished = DateTime.Now;

                        if (getIdClient != "")
                        {
                            budgetAlter.IdClients = getIdClient;
                        }

                        //atualiza
                        obj.Update(budgetAlter);

                        //verifica se o orçamento foi atualizado com sucesso
                        var ok = obj.Search.FirstOrDefault(b => b.sID == budgetAlter.sID);

                        if (ok == null)
                            MessageBox.Show("Erro ao Atualizar o Orçamento !!!");
                        else
                        {
                            MessageBox.Show("Orçamento Atualizado com Sucesso !!!");
                            btnGravarOrcamento.Text = "Gravar";

                            cleanScreen();

                            //fecha a tela de alteração
                            Dispose();

                            PrintingBudget(ok.sID);

                            //abre tela de consulta novamente
                            new frmBudgetSearch().Show();
                        }
                    }
                }
            }
            else
            {
                if (validationCamps())
                {
                    if (messageYesNo("Save") == DialogResult.Yes)
                    {
                        Budgets_OS budgetPersist = new Budgets_OS();

                        //gera id unico para o orçamento
                        budgetPersist.sID = Guid.NewGuid().ToString();

                        //preenche os dados do orçamento
                        budgetPersist.dtDate = DateTime.Now;
                        budgetPersist.ClientType = clientType();
                        budgetPersist.sName = txtNome.Text;
                        budgetPersist.sAdress = txtEndereco.Text;
                        budgetPersist.sTelephone = txtTelefone.Text;
                        budgetPersist.sOccupation = txtCargo.Text;

                        //preenche itens no orçamento
                        budgetPersist.Items = fillItemsOnBudgets_OS();

                        budgetPersist.PaymentMethods = paymentMethods();
                        budgetPersist.bPaymentToMatch = checkPaymentForm("combine");
                        budgetPersist.dPercentDiscount = Convert.ToDecimal(txtPorcentDescAVista.Text);
                        budgetPersist.iPaymentInstallments = Convert.ToInt32(nudParcelas.Value);
                        budgetPersist.bInterestRate = checkPaymentForm("rate");
                        budgetPersist.dWithInterest = Convert.ToDecimal(txtPorcentJuros.Text);
                        budgetPersist.iPrevisionOfExecute = Convert.ToInt32(nudDias.Value);
                        budgetPersist.dtStartPrevision = dtpDataPrevistaInicio.Value;
                        budgetPersist.dtFinalPrevision = dtpDataPrevistaEntrega.Value;
                        budgetPersist.iWarrantyTime = Convert.ToInt32(nudAnos.Value);
                        budgetPersist.dtBudgetExpirationDate = dtpDataValidadeOrcamento.Value;
                        budgetPersist.sObservation = rtfObservacoes.Text;
                        budgetPersist.dTotal = Convert.ToDecimal(lblTotalGeralValor.Text);
                        budgetPersist.bServiceOrderDelivered = false;
                        budgetPersist.bServiceOrderApproved = false;
                        budgetPersist.bRegisterFinished = false;

                        //properts dont fill for default, needs to change to null
                        budgetPersist.dtDateServiceOrderDelivered = DateTime.Now;
                        budgetPersist.dtDateServiceOrderApproved = DateTime.Now;
                        budgetPersist.dtDateRegisterFinished = DateTime.Now;


                        //criar variavel para receber codigo
                        int cod = 0;

                        //Incrementa o Cod do orçamento para ser usado na view
                        try
                        {
                            cod = obj.Search.Max(b => b.iCod); //busca ultimo cod inserido no banco
                        }
                        catch
                        {
                            cod = 0; //se for o 1º orçamento a ser feito cod recebe 0 para que no increment nao de erro;
                        }

                        budgetPersist.iCod = cod + 1;

                        if (getIdClient != "")
                        {
                            budgetPersist.IdClients = getIdClient;
                        }

                        //salva
                        ctx.Budgets_OS.Add(budgetPersist);
                        ctx.SaveChanges();
                        
                        //verifica se o orçamento foi salvo com sucesso
                        var ok = obj.Search.FirstOrDefault(b => b.sID == budgetPersist.sID);

                        if (ok != null)
                        {
                            MessageBox.Show("Orçamento Salvo com Sucesso !!!");

                            cleanScreen();

                            //colocar impressao aqui
                            string Cod = ok.sID.ToString();

                            PrintingBudget(budgetPersist.sID);
                        }
                        else
                            MessageBox.Show("Erro ao Salvar o Orçamento !!!");
                    }
                }
            }
        }

        // chama a impressão do orçamento, se vai imprimir com preço nos itens ou não.
        public void PrintingBudget(string id)
        {
            if (messageYesNo("Price") == DialogResult.Yes)
            {
                new ReportParameter().Values.Clear();
                new BudgetPrintWithPrice(id).Show();
            }
            else
            {
                new BudgetPrint(id).Show();
            }
        }

        //verifica na alteração se o item ja esta na lista caso esteja nao inclui novamente
        public List<Items> checkToAlter(List<Items> list)
        {
            List<Items> newList = new List<Items>(); //cria lista para receber os dados da gridview

            List<Items> currentList = new List<Items>(); //recebe lista para comparar se inseriu mais items

            List<Items> mainList = list; // popula a lista principal
            
            foreach (DataGridViewRow line in dgvItens.Rows)
            {
                newList.Add(
                        new Items
                        {
                            sID = Guid.NewGuid().ToString(),
                            dAmount = Convert.ToDouble(line.Cells["dAmount"].Value),
                            sDescription = line.Cells["sDescription"].Value.ToString(),
                            dPrice = Convert.ToDecimal(line.Cells["dPrice"].Value),
                            dTotal = Convert.ToDecimal(line.Cells["dTotal"].Value)
                        });
            }


            foreach (var newLine in newList)
            {
                if (!mainList.Contains(newLine))
                {
                    mainList.Add(
                        new Items
                        {
                            sID = Guid.NewGuid().ToString(),
                            dAmount = newLine.dAmount,
                            sDescription = newLine.sDescription,
                            dPrice = newLine.dPrice,
                            dTotal = newLine.dTotal
                        });
                }
            }
        
            currentList = newList.Except(mainList).ToList();

            budget.Items = currentList.ToList();

            return budget.Items.ToList();
        }


        // fill Collection<items> on Budgets_OS
        private List<Items> fillItemsOnBudgets_OS()
        {
            budget.Items = new List<Items>();

            foreach (DataGridViewRow line in dgvItens.Rows)
            {
                budget.Items.Add(
                    new Items
                    {
                        sID = Guid.NewGuid().ToString(),
                        dAmount = Convert.ToDouble(line.Cells["dAmount"].Value),
                        sDescription = line.Cells["sDescription"].Value.ToString(),
                        dPrice = Convert.ToDecimal(line.Cells["dPrice"].Value),
                        dTotal = Convert.ToDecimal(line.Cells["dTotal"].Value)
                    });
            }

            return budget.Items.ToList();
        }

        //CHECK if payment is Checked
        public bool checkPaymentForm(string form)
        {
            if (chkCheque.Checked && chkDinheiro.Checked)
                form = "2forms";

            switch (form)
            {
                case "combine":
                    if (chkCombinar.Checked)
                        return true;
                    else return false;
                case "cheque":
                    if (chkCheque.Checked)
                        return true;
                    else return false;
                case "money":
                    if (chkDinheiro.Checked)
                        return true;
                    else return false;
                case "rate":
                    if(chkJuros.Checked)
                        return true;
                    else return false;
                    
                //case "2forms":
                //    return new frmTwoPaymentForms().Show();
            }
            return false;
        }

        
        //RETURN paymentMethods
        public PaymentMethods paymentMethods()
        {
            if (chkCombinar.Checked)
                return PaymentMethods.toMatch;
            if (chkCheque.Checked)
                return PaymentMethods.cheque;
            if (chkDinheiro.Checked)
                return PaymentMethods.money;
            if (chkCheque.Checked && chkDinheiro.Checked)
                return PaymentMethods.chequeMoney;

            return 0;
        }

        //RETURN ClientType
        public ClientType clientType()
        {
            if (radComercial.Checked)
                return ClientType.Comercial;
            if (radIndustrial.Checked)
                return ClientType.Industrial;
            if (radResidencial.Checked)
                return ClientType.Residencial;

            return 0;
        }

        //INSERT ITEM ON dgvItens
        public void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!validatorAdd()) // verifica se os campo de adicionar estão preenchidos
            {
            }
            else if (checkEqualsItems()) // verifica se o produto/serviço a ser inserido já esta na gridview 
            {
                decimal total = Convert.ToDecimal(txtQuantidade.Text.Replace(".", ",")) * Convert.ToDecimal(txtValorUnitario.Text.Replace(".", ","));
                if (total == 0)
                {
                    MessageBox.Show("Quantidade do Produto/Serviço deve ser maior que Zero");
                }
                else
                {
                    dgvItens.Rows.Add(txtQuantidade.Text.Replace(".", ","), txtDescricao.Text.ToUpper(), txtValorUnitario.Text.Replace(".", ","),
                        Convert.ToString(total));
                    subTotal = subTotal + total;
                    lblSubTotalValor.Text = Convert.ToString(subTotal);
                    clearItensLine();
                    txtQuantidade.Focus();
                }
            }
        }

        //DELETE ITEM ON dgvItens
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int compare = dgvItens.Rows.Count; // conta linhas da tabela
            if (compare == 0)
            {
            }
            else
            {
                if (messageYesNo("Delete") == DialogResult.Yes)
                {
                    var row = dgvItens.SelectedRows[0].Index;
                    subTotal = subTotal - Convert.ToDecimal(dgvItens[3, row].Value.ToString());
                    lblSubTotalValor.Text = Convert.ToString(subTotal);
                    dgvItens.Rows.RemoveAt(row);
                    txtQuantidade.Focus();

                    if (compare.Equals(1))
                        clearCampsPayment();
                }
                clearItensLine();
            }
        }

        //FUNCTIONS OF DATA GRID VIEW ITEMS

        // SEARCH FOR EQUALS ITEMS
        public bool checkEqualsItems()
        {
            foreach (DataGridViewRow line in dgvItens.Rows)
            {
                if (line.Cells["sDescription"].Value.Equals(txtDescricao.Text)) // verifica item igual
                    if (messageYesNo("Add") == DialogResult.Yes)
                        return true;
                    else
                        return false;

                if (line.Cells["sDescription"].Value.Equals("MÃO DE OBRA")) // verifica se mao de obra ja foi lançada
                    if (messageYesNo("HandWork") == DialogResult.Yes)
                        return true;
                    else
                        return false;
            }

            return true;
        }

        // WHEN CLICK DVGITENS LINE
        private void dgvItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                selectedItem();
        }

        //FILL PRODUCTS/SERVICES ON VIEW
        public void selectedItem()
        {
            txtQuantidade.Text = dgvItens[0, dgvItens.CurrentRow.Index].Value.ToString();
            txtDescricao.Text = dgvItens[1, dgvItens.CurrentRow.Index].Value.ToString();
            txtValorUnitario.Text = dgvItens[2, dgvItens.CurrentRow.Index].Value.ToString();
            txtValorTotal.Text = dgvItens[3, dgvItens.CurrentRow.Index].Value.ToString();
        }
        

        // VALIDATORS

        //validators CAMPS frm
        public bool validationCamps()
        {
            if (txtNome.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um NOME para o cliente");
                txtNome.Focus();
                return false;
            }

            if (txtEndereco.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um ENDEREÇO para o cliente");
                txtEndereco.Focus();
                return false;
            }

            if (txtTelefone.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um TELEFONE para o cliente");
                txtTelefone.Focus();
                return false;
            }

            if (txtCargo.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um CARGO para o cliente");
                txtCargo.Focus();
                return false;
            }

            int compare = dgvItens.Rows.Count; 
            if (compare == 0)
            {
                MessageBox.Show("Nenhum Item Adicionado ao Orçamento");
                txtQuantidade.Focus();
                return false;
            }

            if (!chkCombinar.Checked && !chkCheque.Checked && !chkDinheiro.Checked)
            {
                MessageBox.Show("Informe a FORMA de pagamento");
                chkCombinar.Focus();
                return false;
            }

            if (txtPorcentDescAVista.Text == "")
                txtPorcentDescAVista.Text = "0";

            if (txtPorcentJuros.Text == "")
                txtPorcentJuros.Text = "0";

            return true;
        }

        //validator ADD on DataGridView
        public bool validatorAdd()
        {
            if (txtQuantidade.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe a quantidade");
                txtQuantidade.Focus();
                return false;
            }

            if (txtDescricao.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe a descrição do Produto/Serviço");
                txtDescricao.Focus();
                return false;
            }

            if (txtValorUnitario.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe o Valor Unitário");
                txtValorUnitario.Focus();
                return false;
            }

            return true;
        }
        
        //validator Calc values
        public void valueTotal()
        {
            decimal i;
            decimal d;

            if (!decimal.TryParse(txtQuantidade.Text, out i)) // validator of numbers
            {
                if (txtQuantidade.Text == "")
                { }
                else
                {
                    txtQuantidade.Focus();
                    txtQuantidade.Text = "";
                }
            }
            if (!decimal.TryParse(txtValorUnitario.Text, out d)) // validator of numbers
            {
                if(txtValorUnitario.Text == "")
                { }
                else
                {
                    txtValorUnitario.Focus();
                    txtValorUnitario.Text = "";
                }
            }else
            if (txtQuantidade.Text.Length.Equals(0))
            {
                txtQuantidade.Text = "";
            }else
            if (txtValorUnitario.Text.Length.Equals(0))
            {
                txtValorUnitario.Text = "";
                txtValorTotal.Text = "0";
                
            }else
            {
                //decimal total = stringReplacePoint(Convert.ToDecimal(txtQuantidade.Text.Replace(",","."))) * stringReplacePoint(Convert.ToDecimal(txtValorUnitario.Text.Replace(",",".")));
                decimal total = Convert.ToDecimal(txtQuantidade.Text.Replace(".",",")) * Convert.ToDecimal(txtValorUnitario.Text.Replace(".",","));
                txtValorTotal.Text = Convert.ToString(total);
            }
        }

        //validator YesNo
        public DialogResult messageYesNo(string type)
        {
            switch (type)
            {
                case "Cancel": 
                    return MessageBox.Show("Deseja Canelar o Orçamento?", "Cancelar Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "Save":
                    return MessageBox.Show("Deseja Gravar o Orçamento com os Dados Informados?", "Gravar Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "Add":
                    return MessageBox.Show("Já existe um Produto / Serviço lançando igual, Deseja Continuar?", "Produto Igual Encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "Delete":
                    return MessageBox.Show("Confirma a Exclusão do Produto?", "Excluir Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "HandWork":
                    return MessageBox.Show("A Mão de Obra já foi Calculada para este Orçamento, Deseja Continuar?", "Mão de Obra Lançada", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "Alter":
                    return MessageBox.Show("Deseja Alterar o Orçamento com os Dados Informados?", "Alterar Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "Approve":
                    return MessageBox.Show("Deseja Aprovar o orçamento?", "Aprovar Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "Price":
                    return MessageBox.Show("Deseja Exibir / Imprimir o orçamento com preço nos itens?", "Exibir Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "client":
                    return MessageBox.Show("Confirma o Cliente ?", "Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "product":
                    return MessageBox.Show("Confirma a escolha do Produto ?", "Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "productValue":
                    return MessageBox.Show("Deseja aplicar o cálculo do valor unitário do Produto / Peça agora?", "Preço do Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            return DialogResult.No;
        }

        // CALLS

        // CALLS VIEW PRODUCTS
        private void btnPeca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Na próxima tela, você pode pode escolher o produto clicando uma vez com o botão esquerdo do mouse sobre ele e clicar no botão selecionar.");
            product.ShowDialog();
            if (product.ReturnProducts != null)
                if (messageYesNo("product") == DialogResult.Yes)
                {
                    getIdProduct = "";
                    getIdProduct = product.ReturnProducts.sID;
                    txtQuantidade.Text = product.ReturnProducts.dAmount.ToString();
                    txtDescricao.Text = product.ReturnProducts.sDescription;
                    if (messageYesNo("productValue") == DialogResult.Yes)
                    {
                        decimal price = ((product.ReturnProducts.dPrice * 60) / 100) + product.ReturnProducts.dPrice;
                        txtValorUnitario.Text = price.ToString();
                    }
                    else
                    {
                        txtValorUnitario.Text = product.ReturnProducts.dPrice.ToString();
                    }
                }
        }

        // CALLS VIEW SERVICES
        private void btnServico_Click(object sender, EventArgs e)
        {
            decimal value;
            if (lblSubTotalValor.Text == "0")
            { MessageBox.Show("Você precisa ter ao menos um Produto / Peça cadastrado no orçamento para que o lançamento de Serviço / Mão de Obra seja liberado."); }
            else
            if(checkEqualsItems())
            {
                value = subTotal; // 100% em cima das peças

                frmServiceCalc calc = new frmServiceCalc(value); //instancia o form

                calc.ShowDialog(); // exibe o form

                if(calc.finalValue != 0 && calc.finalValue > value)
                    if (calc.messageYesNo("Confirm") == DialogResult.Yes) //confirma mão de obra
                    {
                        dgvItens.Rows.Add(1, "MÃO DE OBRA", calc.finalValue, calc.finalValue); // adiciona direto na DGV

                        subTotal = subTotal + calc.finalValue;
                        lblSubTotalValor.Text = Convert.ToString(subTotal); // atualiza o subTotal
                    }
            }
        }

        // CALL VIEW CLIENTS
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Na próxima tela, você pode dar um duplo clique do mouse em cima do cliente desejado para selecioná-lo.");
            client.ShowDialog();
            if (client.ReturnClients != null)
                if (messageYesNo("client") == DialogResult.Yes)
                {
                    getIdClient = "";
                    getIdClient = client.ReturnClients.sID;
                    if (client.ReturnClients.ClientType == ClientType.Residencial)
                    {
                        radResidencial.Checked = true;
                    }
                    else if (client.ReturnClients.ClientType == ClientType.Industrial)
                    {
                        radIndustrial.Checked = true;
                    }
                    else if (client.ReturnClients.ClientType == ClientType.Comercial)
                    {
                        radComercial.Checked = true;
                    }
                    txtNome.Text = client.ReturnClients.sName;
                    txtEndereco.Text = client.ReturnClients.sAdress + " ," + client.ReturnClients.iNumber + " ," +
                                       client.ReturnClients.sDistrict + " ," + client.ReturnClients.sCity + " ," +
                                       client.ReturnClients.Estate;
                    txtTelefone.Text = client.ReturnClients.sPhoneResidencial + " ," + client.ReturnClients.sPhoneCelularOne;
                    txtCargo.Text = client.ReturnClients.sOccupation;
                    txtQuantidade.Focus();
                }
        }


        // CALL FUNCTION VALUETOTAL() WHERE CAMP QUANTIDADE IS CHANGED
        private void txtQuantidade_TextChanged_1(object sender, EventArgs e)
        {
            if(txtQuantidade.Text != "")
                valueTotal();
        }
        
        // CALL FUNCTION VALUETOTAL() WHERE CAMP VALOR UNITARIO IS CHANGED
        private void txtValorUnitario_TextChanged(object sender, EventArgs e)
        {
            if (txtValorUnitario.Text != "")
                valueTotal();
        }

        
        //STATES OF OBJECTS

        // WHEN PAYMENT FORM IS CHANGED BY TO COMBINE
        private void chkCombinar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCombinar.Checked)
            {
                chkJuros.CheckState = CheckState.Unchecked;
                if (txtPorcentDescAVista.Enabled.Equals(true))
                    txtPorcentDescAVista.Enabled = false;
                nudParcelas.Enabled = false;
                chkJuros.Enabled = false;
                if(txtPorcentJuros.Enabled.Equals(true))
                    txtPorcentJuros.Enabled = false;
                clearCampsPayment();
                chkCheque.Enabled = false;
                chkDinheiro.Enabled = false;
            }
            else
            {
                if (lblSubTotalValor.Text != "0")
                {
                    txtPorcentDescAVista.Enabled = true;
                    nudParcelas.Enabled = true;
                }
                chkJuros.Enabled = true;
                chkCheque.Enabled = true;
                chkDinheiro.Enabled = true;

                if (chkJuros.Checked)
                    txtPorcentJuros.Enabled = true;
            }
        }

        // WHEN RATE FORM IS CHANGED BY TRUE
        private void chkJuros_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJuros.Checked)
            {
                txtPorcentJuros.Enabled = true;
                txtPorcentDescAVista.Enabled = false;
            }
            else
            {
                txtPorcentJuros.Enabled = false;
                txtPorcentDescAVista.Enabled = true;
                clearCampsPayment();
            }

        }
        
        // WHEN NUM OF DAYS IS CHANGED
        private void nudDias_ValueChanged(object sender, EventArgs e)
        {
           setDateService();
        }

        // WHEN INITIAL DATE IS CHANGED
        private void dtpDataPrevistaInicio_ValueChanged(object sender, EventArgs e)
        {
            setDateService();
        }

        //WHEN FINAL DATE IS CHANGED
        private void dtpDataPrevistaEntrega_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDataPrevistaEntrega.Value >= DateTime.Today) // se a data final escolhida for maior que data atual
            {
                var days = dtpDataPrevistaEntrega.Value.Date - dtpDataPrevistaInicio.Value.Date; // calcula diferença de dias
                if (days.Days >= 0)
                    nudDias.Value = days.Days; //preenche o nuddias
            }
            else
                dtpDataPrevistaEntrega.Value = DateTime.Today; // senao ele ignora a data anterior e coloca a data atual
        }

        //WHEN SET DATE TO DELIVERY
        public void setDateService()
        {
            if (!nudDias.Value.Equals(0)) // se o valor do nuddias for maior que 0
            {
                var days = Convert.ToDouble(nudDias.Value);
                dtpDataPrevistaEntrega.Value =
                    dtpDataPrevistaInicio.Value.AddDays(days); // data final recebe data de inicio + dias

            }
            else
                dtpDataPrevistaEntrega.Value = dtpDataPrevistaInicio.Value; // senao ele ignora a data anterior e coloca a data atual
        }

        //WHEN SET DESCONT TO VALUE
        private void txtPorcentDescAVista_TextChanged(object sender, EventArgs e)
        {
            calcValueDiscount();
        }

        //WHEN NUDPARCELAS IS CHANGED
        private void nudParcelas_ValueChanged(object sender, EventArgs e)
        {
            calcValueRate();
        }

        //WHEN PORCENTJUROS IS CHANGED
        private void txtPorcentJuros_TextChanged(object sender, EventArgs e)
        {
            calcValueRate();
        }


        //CLEANS


        // CLEAN CAMPS OF ADD ITEMS
        public void clearItensLine()
        {
            txtQuantidade.Text = "";
            txtDescricao.Text = "";
            txtValorUnitario.Text = "";
            txtValorTotal.Text = "0";
        }

        // CLEAN CAMPS OF PAYMENTS
        public void clearCampsPayment()
        {
            txtPorcentDescAVista.Text = "0";
            lblValorPorParcela.Text = "0";
            lblValorJuros.Text = "0";
            lblExibeValorTotalParcelado.Text = "0";
            nudParcelas.Value = 1;
            //txtPorcentJuros.Text = "0";
            lblTotalGeralValor.Text = lblSubTotalValor.Text;
        }

        // CLEAN ALL DATA OF VIEW
        public void cleanScreen()
        {
            //CLIENT
            radComercial.Checked = true;
            txtNome.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtCargo.Clear();
            //DGVITEMS
            txtQuantidade.Text = "";
            txtDescricao.Text = "";
            txtValorUnitario.Text = "";
            txtValorTotal.Text = "0";
            lblSubTotalValor.Text = "0";
            dgvItens.Rows.Clear();
            subTotal = 0;
            //PAYMENTS
            chkCombinar.Checked = false;
            chkCheque.Checked = false;
            chkDinheiro.Checked = false;
            txtPorcentDescAVista.Text = "0";
            lblExibeValorDesconto.Text = "0";
            nudParcelas.Value = 1;
            lblValorPorParcela.Text = "0";
            chkJuros.Checked = false;
            txtPorcentJuros.Text = "0";
            lblValorJuros.Text = "0";
            lblExibeValorTotalParcelado.Text = "0";
            //DELIVERY
            nudDias.Value = 1;
            //WARRANTY
            nudAnos.Value = 1;
            rtfObservacoes.Clear();
            lblTotalGeralValor.Text = "0";
        }

        // SETS

        //SET TOTAL GENERAL
        private void lblSubTotalValor_TextChanged(object sender, EventArgs e)
        {
            if (lblSubTotalValor.Text != "0")
            {
                txtPorcentDescAVista.Enabled = true;
                nudParcelas.Enabled = true;
                chkJuros.Enabled = true;
                chkCombinar.Enabled = true;
                chkCheque.Enabled = true;
                chkDinheiro.Enabled = true;
            }
            else
            {
                txtPorcentDescAVista.Enabled = false;
                lblExibeValorDesconto.Text = "0";
                nudParcelas.Enabled = false;
                chkJuros.Enabled = false;
                chkCombinar.Enabled = false;
                chkCheque.Enabled = false;
                chkDinheiro.Enabled = false;
            }
            lblTotalGeralValor.Text = lblSubTotalValor.Text;
        }

        //SET DISCOUNT PERCENT
        public void calcValueDiscount()
        {
            decimal porcentDesc;
            decimal subTotalValue;

            if (txtPorcentDescAVista.Text == "")
                porcentDesc = 0;
            else
                porcentDesc= Convert.ToDecimal(txtPorcentDescAVista.Text);

            subTotalValue = Convert.ToDecimal(lblSubTotalValor.Text);

            if (!porcentDesc.Equals(0) && !subTotalValue.Equals(0))
            {
                var desc = subTotalValue * (porcentDesc / 100);
                var descTotalValue = subTotalValue - desc;

                lblExibeValorDesconto.Text = Convert.ToString(Math.Round(desc,2));
                lblTotalGeralValor.Text = Convert.ToString(Math.Round(descTotalValue,2));
                nudParcelas.Enabled = false;
                chkJuros.Enabled = false;
            }
            else
            {
                lblExibeValorDesconto.Text = "0";
                lblTotalGeralValor.Text = lblSubTotalValor.Text;
                if (!chkCombinar.Checked.Equals(true))
                {
                    nudParcelas.Enabled = true;
                    chkJuros.Enabled = true;
                }
            }
        }

        //SET VALUE OF RATE
        public void calcValueRate()
        {
            decimal porcentRate;
            decimal subTotalValue;
            decimal installments;
            

            if (txtPorcentJuros.Text == "")
                porcentRate = 0;
            else
                porcentRate = Convert.ToDecimal(txtPorcentJuros.Text);

            subTotalValue = Convert.ToDecimal(lblSubTotalValor.Text);

            installments = Convert.ToDecimal(nudParcelas.Value);

            if (!subTotalValue.Equals(0) && !porcentRate.Equals("") && !nudParcelas.Value.Equals(0))
            {
                decimal percentByTimes = 0;

                //if (!nudParcelas.Value.Equals(1))
                    percentByTimes = porcentRate / 100;

                var valueOfInstallmentTimes = Math.Round(subTotalValue / installments,2);
                var valueRate = Math.Round(percentByTimes * valueOfInstallmentTimes, 2);
                var valueRatePerTimes = Math.Round(valueOfInstallmentTimes + valueRate, 2);
                var valueTotalWithRate = Math.Round(valueRatePerTimes * installments);

                lblValorPorParcela.Text = Convert.ToString(valueRatePerTimes);

                lblValorJuros.Text = Convert.ToString(valueRate * installments);

                lblExibeValorTotalParcelado.Text = Convert.ToString(valueTotalWithRate);

                lblTotalGeralValor.Text = lblExibeValorTotalParcelado.Text;
            }
            else
            {
                clearCampsPayment();
            }
        }


        // CLOSE FORM
        private void btnCancelarOrcamento_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals(""))
            {
                if (messageYesNo("Cancel") == DialogResult.Yes)
                    Dispose();
            }
            else
                Dispose();
        }

        public void bringsDataIdBudget()
        {
            budget = obj.ReturnByID(getID);
            //getID = null;
            // brings the data of the budget recorded in the database
        }

        public void BudgetData()
        {
            bringsDataIdBudget();

            if (budget.ClientType == ClientType.Residencial)
            {
                radResidencial.Checked = true;
            } else if (budget.ClientType == ClientType.Industrial)
            {
                radIndustrial.Checked = true;
            }else if (budget.ClientType == ClientType.Comercial)
            {
                radComercial.Checked = true;
            }

            txtNome.Text = budget.sName.ToString();
            txtEndereco.Text = budget.sAdress.ToString();
            txtTelefone.Text = budget.sTelephone.ToString();
            txtCargo.Text = budget.sOccupation.ToString();

            // preenche a grid view

            //decimal subTotal = 0;
            decimal total = 0;

            foreach (var line in budget.Items.ToList()) // math.round(var,2)
            {
                dgvItens.Rows.Add(line.dAmount.ToString(), line.sDescription.ToString(), line.dPrice.ToString(), line.dTotal.ToString());
                total = Convert.ToDecimal(line.dAmount.ToString()) * Convert.ToDecimal(line.dPrice.ToString());
                subTotal = subTotal + total;
            }


            lblSubTotalValor.Text = Convert.ToString(subTotal);
            clearItensLine();
            txtQuantidade.Focus();

            if (budget.PaymentMethods == PaymentMethods.toMatch)
            {
                chkCombinar.Checked = true;
            }
            else if (budget.PaymentMethods == PaymentMethods.toMatch)
            {
                chkCombinar.Checked = true;
            }
            else if (budget.PaymentMethods == PaymentMethods.cheque)
            {
                chkCheque.Checked = true;
            } else if (budget.PaymentMethods == PaymentMethods.toMatch)
            {
                chkCombinar.Checked = true;
            }
            else if (budget.PaymentMethods == PaymentMethods.money)
            {
                chkDinheiro.Checked = true;
            }
            else if (budget.PaymentMethods == PaymentMethods.chequeMoney)
            {
                chkCheque.Checked = true;
                chkDinheiro.Checked = true;
            }

            txtPorcentDescAVista.Text = budget.dPercentDiscount.ToString();
            nudParcelas.Text = budget.iPaymentInstallments.ToString();

            if (budget.bInterestRate)
            {
                chkJuros.Checked = true;
                txtPorcentJuros.Text = budget.dWithInterest.ToString();
                //txtPorcentJuros.Enabled = true;
            }

            nudDias.Text = budget.iPrevisionOfExecute.ToString();
            dtpDataPrevistaInicio.Text = budget.dtStartPrevision.ToString();
            dtpDataPrevistaEntrega.Text = budget.dtFinalPrevision.ToString();
            nudAnos.Text = budget.iWarrantyTime.ToString();
            dtpDataValidadeOrcamento.Text = budget.dtBudgetExpirationDate.ToString();
            rtfObservacoes.Text = budget.sObservation.ToString();
            //txtPorcentDescAVista.Enabled = true;
            nudParcelas.Enabled = true;

            btnGravarOrcamento.Text = "Alterar";
            if (btnAprovar.Enabled)
                btnAprovar.Enabled = false;
            else
                btnAprovar.Enabled = true;
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            bringsDataIdBudget();
            budget = obj.ReturnByID(getID);
            if (messageYesNo("Approve") == DialogResult.Yes)
            {
                budget.bServiceOrderApproved = true;
                budget.dtDateServiceOrderApproved = DateTime.Now;

                obj.Update(budget);
                MessageBox.Show("Aprovado");
            }
        }
    }
}