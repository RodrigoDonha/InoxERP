using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Windows.Forms;
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
        static InoxErpContext ctx = new InoxErpContext();
        Budgets_OS budget = new Budgets_OS();
        Budget_OSBusiness obj = new Budget_OSBusiness(ctx);
        ItemsBusiness items = new ItemsBusiness(ctx);

        private decimal subTotal = 0;
        private string getID;

        public frmBudgetsRegister(String Id)
        {
            InitializeComponent();
            getID = Id;
            btnProcurar.Focus();
            btnAprovar.Enabled = false;
        }

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
                        budget = obj.ReturnByID(getID);

                        //preenche os dados do orçamento
                        fillBudget_OS();

                        //atualiza
                        obj.Update(budget);

                        //verifica se o orçamento foi atualizado com sucesso
                        var ok = obj.Search.FirstOrDefault(b => b.sID == budget.sID);

                        if (ok == null)
                            MessageBox.Show("Erro ao Atualizar o Orçamento !!!");
                        else
                        {
                            MessageBox.Show("Orçamento Atualizado com Susseço !!!");
                            btnGravarOrcamento.Text = "Gravar";


                            cleanScreen();

                            new BudgetPrint(getID).Show();
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
                        //gera id unico para o orçamento
                        budget.sID = Guid.NewGuid().ToString();

                        //preenche os dados do orçamento
                        fillBudget_OS();

                        //Incrementa o Cod do orçamento para ser usado na view
                        var cod = obj.Search.Max(b => b.iCod); //busca ultimo cod inserido no banco

                        //se for o 1º orçamento a ser feito cod recebe 0 para que no increment nao de erro;
                        if (cod.ToString().Equals(""))
                            cod = 0;
                        budget.iCod = cod + 1;

                        //salva
                        ctx.Budgets_OS.Add(budget);
                        ctx.SaveChanges();
                        
                        //verifica se o orçamento foi salvo com sucesso
                        var ok = obj.Search.FirstOrDefault(b => b.sID == budget.sID);

                        if (ok != null)
                        {
                            MessageBox.Show("Orçamento Salvo com Sucesso !!!");

                            cleanScreen();

                            //colocar impressao aqui
                            string Cod = ok.sID.ToString();
                            new BudgetPrint(Cod).Show();
                        }
                        else
                            MessageBox.Show("Erro ao Salvar o Orçamento !!!");
                    }
                }
            }
        }

        //fill Budget_OS data
        private void fillBudget_OS()
        {
            budget.dtDate = DateTime.Now;
            budget.ClientType = clientType();
            budget.sName = txtNome.Text;
            budget.sAdress = txtEndereco.Text;
            budget.sTelephone = txtTelefone.Text;
            budget.sOccupation = txtCargo.Text;
            fillItemsOnBudgets_OS();
            budget.PaymentMethods = paymentMethods();
            budget.bPaymentToMatch = checkPaymentForm("combine");
            budget.dPercentDiscount = Convert.ToDecimal(txtPorcentDescAVista.Text);
            budget.iPaymentInstallments = Convert.ToInt32(nudParcelas.Value);
            budget.bInterestRate = checkPaymentForm("rate");
            budget.dWithInterest = Convert.ToDecimal(txtPorcentJuros.Text);
            budget.iPrevisionOfExecute = Convert.ToInt32(nudDias.Value);
            budget.dtStartPrevision = dtpDataPrevistaInicio.Value;
            budget.dtFinalPrevision = dtpDataPrevistaEntrega.Value;
            budget.iWarrantyTime = Convert.ToInt32(nudAnos.Value);
            budget.dtBudgetExpirationDate = dtpDataValidadeOrcamento.Value;
            budget.sObservation = rtfObservacoes.Text;
            budget.dTotal = Convert.ToDecimal(lblTotalGeralValor.Text);

            //properts dont fill for default, needs to change to null

            budget.bServiceOrderApproved = false;
            budget.bRegisterFinished = false;
            budget.dtDateServiceOrderApproved = DateTime.Now;
            budget.dtDateRegisterFinished = DateTime.Now;
        }

        // fill Collection<items> on Budgets_OS
        private void fillItemsOnBudgets_OS()
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
        private void btnAdicionar_Click(object sender, EventArgs e)
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
                    dgvItens.Rows.Add(txtQuantidade.Text.Replace(".", ","), txtDescricao.Text, txtValorUnitario.Text.Replace(".", ","),
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
                // não consegui tratar a exclusão no data grid view, apresenta erro no tratamento da iBidingList, então não permiti alteração e exclusão nos itens
                // até que seja resolvido o erro.
                //if (btnGravarOrcamento.Text == "Alterar")
                //{
                //    MessageBox.Show("Você não pode excluir, nem alterar itens do orçamento já gravado, caso necessite fazer isso, exclua o orçamento e lance outro com os dados corretos.");
                //}
                //else
                //{
                    var row = dgvItens.SelectedRows[0].Index;
                    subTotal = subTotal - Convert.ToDecimal(dgvItens[3, row].Value.ToString());
                    lblSubTotalValor.Text = Convert.ToString(subTotal);
                    dgvItens.Rows.RemoveAt(row);
                    txtQuantidade.Focus();
                    if (compare.Equals(1))
                        clearCampsPayment();
                //}
            }
        }

        //FUNCTIONS OF DATA GRID VIEW ITEMS

        // SEARCH FOR EQUALS ITEMS
        public bool checkEqualsItems()
        {
            foreach (DataGridViewRow line in dgvItens.Rows)
            {
                if (line.Cells["sDescription"].Value.Equals(txtDescricao.Text))
                    if (messageYesNo("Add") == DialogResult.Yes)
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
                case "Alter":
                    return MessageBox.Show("Deseja Alterar o Orçamento com os Dados Informados?", "Alterar Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "Approve":
                    return MessageBox.Show("Deseja Aprovar o orçamento?", "Aprovar Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            return DialogResult.No;
        }

        // CALLS

        // CALLS VIEW PRODUCTS
        private void btnPeca_Click(object sender, EventArgs e)
        {
            //new frmProductsRegisterSearch().Show();
        }

        // CALLS VIEW SERVICES
        private void btnServico_Click(object sender, EventArgs e)
        {
            //new frmServicesRegisterSearch().Show();
        }

        // CALL VIEW CLIENTS
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            //new frmClientsSearch().Show();
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
            if (!lblSubTotalValor.Text.Length.Equals(0) && !txtPorcentDescAVista.Text.Length.Equals(0))
            {
                var descValue = Convert.ToDecimal(lblSubTotalValor.Text) - (Convert.ToDecimal(lblSubTotalValor.Text) * (Convert.ToDecimal(txtPorcentDescAVista.Text)/100));

                lblExibeValorAVista.Text = Convert.ToString(descValue);
                lblTotalGeralValor.Text = lblExibeValorAVista.Text;
                nudParcelas.Enabled = false;
                chkJuros.Enabled = false;
            }
            else
            {
                lblExibeValorAVista.Text = lblSubTotalValor.Text;
                lblTotalGeralValor.Text = lblSubTotalValor.Text;
                if (!chkCombinar.Checked.Equals(true))
                {
                    nudParcelas.Enabled = true;
                    chkJuros.Enabled = true;
                }
            }

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
            txtPorcentJuros.Text = "0";
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
            //PAYMENTS
            chkCombinar.Checked = false;
            chkCheque.Checked = false;
            chkDinheiro.Checked = false;
            txtPorcentDescAVista.Text = "0";
            lblExibeValorAVista.Text = "0";
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
                lblExibeValorAVista.Text = lblSubTotalValor.Text;
                nudParcelas.Enabled = true;
                chkJuros.Enabled = true;
                chkCombinar.Enabled = true;
                chkCheque.Enabled = true;
                chkDinheiro.Enabled = true;

            }
            else
            {
                txtPorcentDescAVista.Enabled = false;
                lblExibeValorAVista.Text = "0";
                nudParcelas.Enabled = false;
                chkJuros.Enabled = false;
                chkCombinar.Enabled = false;
                chkCheque.Enabled = false;
                chkDinheiro.Enabled = false;
            }
            lblTotalGeralValor.Text = lblSubTotalValor.Text;
        }

        //SET VALUE OF RATE
        public void calcValueRate()
        {
            if (!lblSubTotalValor.Text.Length.Equals(0) && !txtPorcentJuros.Text.Length.Equals(0) && !nudParcelas.Value.Equals(0))
            {
                decimal percentByTimes = 0;

                if (!nudParcelas.Value.Equals(1))
                    percentByTimes = Convert.ToDecimal(txtPorcentJuros.Text) / 100;

                var valueOfInstallmentTimes = Math.Round(Convert.ToDecimal(lblSubTotalValor.Text) / Convert.ToDecimal(nudParcelas.Value),2);
                var valueRate = Math.Round(percentByTimes * valueOfInstallmentTimes, 2);
                var valueRatePerTimes = Math.Round(valueOfInstallmentTimes + valueRate, 2);
                var valueTotalWithRate = Math.Round(valueRatePerTimes * Convert.ToDecimal(nudParcelas.Value));

                lblValorPorParcela.Text = Convert.ToString(valueRatePerTimes);

                lblValorJuros.Text = Convert.ToString(valueRate * Convert.ToDecimal(nudParcelas.Value));

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
            //getID = null;
            // brings the data of the budget recorded in the database
            budget = obj.ReturnByID(getID);
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

            var search = budget.Items.ToList();
            decimal subTotal = 0;
            decimal total = 0;

            foreach (var line in budget.Items.ToList())
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