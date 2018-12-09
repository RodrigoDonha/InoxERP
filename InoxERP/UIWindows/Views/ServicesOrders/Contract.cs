using System;
using System.Linq;
using System.Windows.Forms;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;
using UIWindows.Entities.Enum;
using UIWindows.Views.Reports.Contracts;

namespace UIWindows
{
    public partial class frmContract : Form
    {
        ValidationEntries validation = new ValidationEntries();

        static InoxErpContext ctx = new InoxErpContext();
        Budgets_OS searchBudget = new Budgets_OS();
        Budget_OSBusiness obj = new Budget_OSBusiness(ctx);

        Clients cli = new Clients();
        ClientsBusiness clients = new ClientsBusiness(ctx);

        private string getId;

        public frmContract(string id)
        {
            getId = id;
            InitializeComponent();

            getData();
            fillContractOfObject();
            btnProximo.Text = "Próximo";
            btnVoltar.Visible = false;
        }

        public void getData()
        {
            searchBudget = obj.ReturnByID(getId);
        }

        public void validationEntriesCPFandCNPJ(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyCPFandCNPJ(sender, e);
        }

        public void validationEntriesCEP(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyCEP(sender, e);
        }

        public void validationEntriesNumerics(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }

        public void validationEntriesPhones(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyPhones(sender, e);
        }

        public void fillContractOfObject()
        {
            if (searchBudget.IdClients != null)
            {
                string idClient = searchBudget.IdClients;
                cli = clients.ReturnByID(idClient);
                txtNomeC.Text = cli.sName.ToUpper();
                txtCpfCnpjC.Text = cli.sCpfCnpj;
                txtRgC.Text = cli.sRg;
                txtCepC.Text = cli.sCEP;
                txtEnderecoC.Text = cli.sAdress.ToUpper();
                txtNumeroC.Text = cli.iNumber.ToString();
                txtBairroC.Text = cli.sDistrict.ToUpper();
                txtCidadeC.Text = cli.sCity.ToUpper();
                cbxEstate.Text = cli.Estate.ToString();
                cbxEstateContratado.SelectedIndex = 24;
            }
            else
            {
                txtNomeC.Text = searchBudget.sName.ToUpper();
                txtEnderecoC.Text = searchBudget.sAdress.ToUpper();
            }
            txtDescription.Text += "ITEMS:\r\n\r\n";
            foreach (var line in searchBudget.Items.ToList()) // math.round(var,2)
            {
                txtDescription.Text += line.dAmount.ToString() + " - " + line.sDescription + " - " + line.dPrice + " - " + line.dTotal + " \r\n ";
            }
            txtDescription.Text += "\r\nDESCRIÇÃO DO SERVIÇO:\r\n" + "\r\n" + searchBudget.sObservation;
            txtValores.Text = searchBudget.dTotal.ToString();
            txtValores1.Text = searchBudget.dTotal.ToString();
            string obligations = "Forma de pagamento: " + paymentForm(searchBudget.PaymentMethods) + " - Parcelamento: " + searchBudget.iPaymentInstallments;
            txtObrigacoesContratante.Text = obligations;
            txtObrigacoesContratante1.Text = obligations;
            txtPrazoGarantia.Text = searchBudget.iWarrantyTime.ToString();
            txtPrazo1.Text = Convert.ToString(searchBudget.iPrevisionOfExecute);
            txtPrazo2.Text = Convert.ToString(searchBudget.iPrevisionOfExecute);
            string cidade = searchBudget.Clients.sCity;
            txtCidade.Text = cidade;
        }

        private string paymentForm(PaymentMethods payment)
        {
            if (payment == PaymentMethods.chequeMoney)
                return "Dinheiro e Cheque";
            if (payment == PaymentMethods.money)
                return "Dinheiro";
            if (payment == PaymentMethods.cheque)
                return "Cheque";
            if (payment == PaymentMethods.toMatch)
                return "À Combinar";
            return "";
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            ConfirmPositionTabToNext();
        }

        public void ConfirmPositionTabToNext()
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                btnProximo.Text = "Próximo";
                tabControl1.SelectedTab = tabPage2;
                btnVoltar.Visible = true;

            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                btnProximo.Text = "Próximo";
                tabControl1.SelectedTab = tabPage3;
                btnVoltar.Visible = true;
            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                btnProximo.Text = "Gravar";
                tabControl1.SelectedTab = tabPage4;
                btnVoltar.Visible = true;
            }
            else if (tabControl1.SelectedTab == tabPage4)
            {
                btnVoltar.Visible = true;
                // implementar aqui o gravar contrato
                gravarContrato();
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                btnProximo.Text = "Próximo";
                btnVoltar.Visible = false;
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                btnProximo.Text = "Próximo";
                btnVoltar.Visible = true;
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                btnProximo.Text = "Próximo";
                btnVoltar.Visible = true;
            }
            if (tabControl1.SelectedTab == tabPage4)
            {
                btnProximo.Text = "Gravar";
                btnVoltar.Visible = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ConfirmPositionTabToBack();
        }

        public void ConfirmPositionTabToBack()
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                btnVoltar.Visible = false;

            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                btnProximo.Text = "Próximo";
                tabControl1.SelectedTab = tabPage1;
                btnVoltar.Visible = false;
            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                btnProximo.Text = "Próximo";
                tabControl1.SelectedTab = tabPage2;
                btnVoltar.Visible = true;
            }
            else if (tabControl1.SelectedTab == tabPage4)
            {
                btnProximo.Text = "Próximo";
                tabControl1.SelectedTab = tabPage3;
                btnVoltar.Visible = true;
            }
        }

        private void btnAlterarContratado_Click(object sender, EventArgs e)
        {
            if (txtNomeContratado.Text == "LUCAS BEIRIGO REGGIANI")
            {
                txtNomeContratado.Text = "RICHARD CARLOS REGGIANI";
                txtCpfCnpjContratado.Text = "31.210.732/0001-30";
                txtRgContratado.Text = "";
                txtCepContratado.Text = "19045-333";
                txtEnderecoContratado.Text = "RUA ROTARY CLUBE DE PRESIDENTE PRUDENTE-ALVOR";
                txtNumeroContratado.Text = "25";
                txtBairroContratado.Text = "VILA ROTARIA \"ARCH C. KLUMPH\"";
                txtCidadeContratado.Text = "PRESIDENTE PRUDENTE";
                cbxEstateContratado.Text = "SP";
            }
            else
            {
                txtNomeContratado.Text = "LUCAS BEIRIGO REGGIANI";
                txtCpfCnpjContratado.Text = "30.286.217/0001-70";
                txtRgContratado.Text = "093967599-45";
                txtCepContratado.Text = "19065-510";
                txtEnderecoContratado.Text = "AV. DAS FLORES";
                txtNumeroContratado.Text = "210";
                txtBairroContratado.Text = "CECAP";
                txtCidadeContratado.Text = "PRESIDENTE PRUDENTE";
                cbxEstateContratado.Text = "SP";
            }
        }

        public void gravarContrato()
        {
            //if (btnGravarOrcamento.Text == "Alterar")
            //{
            //    if (messageYesNo("Alter") == DialogResult.Yes)
            //    {
            //        if (!validationCamps())
            //            MessageBox.Show("Por Favor preencha as informações Corretamente");
            //        else
            //        {
            //            InoxErpContext ctxAlter = new InoxErpContext();
            //            Budget_OSBusiness objAlter = new Budget_OSBusiness(ctxAlter);

            //            Budgets_OS budgetAlter = new Budgets_OS();

            //            //procura o orçamento para alteração
            //            budgetAlter = objAlter.ReturnByID(getID);

            //            //preenche os dados do orçamento
            //            budgetAlter.dtDate = DateTime.Now;
            //            budgetAlter.ClientType = clientType();
            //            budgetAlter.sName = txtNome.Text;
            //            budgetAlter.sAdress = txtEndereco.Text;
            //            budgetAlter.sTelephone = txtTelefone.Text;
            //            budgetAlter.sOccupation = txtCargo.Text;

            //            //preenche items
            //            checkToAlter(budgetAlter.Items.ToList());

            //            budgetAlter.PaymentMethods = paymentMethods();
            //            budgetAlter.bPaymentToMatch = checkPaymentForm("combine");
            //            budgetAlter.dPercentDiscount = Convert.ToDecimal(txtPorcentDescAVista.Text);
            //            budgetAlter.iPaymentInstallments = Convert.ToInt32(nudParcelas.Value);
            //            budgetAlter.bInterestRate = checkPaymentForm("rate");
            //            budgetAlter.dWithInterest = Convert.ToDecimal(txtPorcentJuros.Text);
            //            budgetAlter.iPrevisionOfExecute = Convert.ToInt32(nudDias.Value);
            //            budgetAlter.dtStartPrevision = dtpDataPrevistaInicio.Value;
            //            budgetAlter.dtFinalPrevision = dtpDataPrevistaEntrega.Value;
            //            budgetAlter.iWarrantyTime = Convert.ToInt32(nudAnos.Value);
            //            budgetAlter.dtBudgetExpirationDate = dtpDataValidadeOrcamento.Value;
            //            budgetAlter.sObservation = rtfObservacoes.Text;
            //            budgetAlter.dTotal = Convert.ToDecimal(0.00);
            //            budgetAlter.dTotal = Convert.ToDecimal(lblTotalGeralValor.Text);

            //            //properts dont fill for default, needs to change to null

            //            budgetAlter.bServiceOrderApproved = false;
            //            budgetAlter.bRegisterFinished = false;
            //            budgetAlter.dtDateServiceOrderApproved = DateTime.Now;
            //            budgetAlter.dtDateRegisterFinished = DateTime.Now;

            //            try
            //            {
            //                ClientsBusiness idCliente = new ClientsBusiness(ctxAlter);
            //                budgetAlter.IdClients =
            //                    idCliente.Search.FirstOrDefault(c => c.sName.Contains(txtNome.Text)).sID;
            //            }
            //            catch (Exception)
            //            {
            //                try
            //                {
            //                    ClientsBusiness idCliente = new ClientsBusiness(ctxAlter);
            //                    budgetAlter.IdClients =
            //                        idCliente.Search.FirstOrDefault(c => c.sName.Contains("CONSUMIDOR")).sID;
            //                }
            //                catch (Exception)
            //                {
            //                    MessageBox.Show(
            //                        "Antes de concluir este Orçamento Voçê tem que Cadastrar um Cliente CONSUMIDOR para continuar");
            //                }
            //            }

            //            //atualiza
            //            objAlter.Update(budgetAlter);

            //            //verifica se o orçamento foi atualizado com sucesso
            //            var ok = objAlter.Search.FirstOrDefault(b => b.sID == budgetAlter.sID);

            //            if (ok == null)
            //                MessageBox.Show("Erro ao Atualizar o Orçamento !!!");
            //            else
            //            {
            //                MessageBox.Show("Orçamento Atualizado com Sucesso !!!");
            //                btnGravarOrcamento.Text = "Gravar";

            //                cleanScreen();

            //                //fecha a tela de alteração
            //                Dispose();

            //                PrintingBudget(ok.sID);

            //                //abre tela de consulta novamente
            //                new frmBudgetSearch().Show();
            //            }
            //        }
            //    }
            //}
            //else
            //{
            if (validationCamps())
            {
                if (messageYesNo("Save") == DialogResult.Yes)
                {
                    InoxErpContext ctxPersist = new InoxErpContext();
                    ContractBusiness objPersist = new ContractBusiness(ctxPersist);
                    Contracts contractPersist = new Contracts();

                    //gera id unico para o orçamento
                    contractPersist.sID = Guid.NewGuid().ToString();

                    //FILL DATA CONTRACT

                    //data client
                    contractPersist.sClientName = txtNomeC.Text;
                    contractPersist.sClientCpfCnpj = txtCpfCnpjC.Text;
                    contractPersist.sClientRg = txtRgC.Text;
                    contractPersist.sClientCep = txtCepC.Text;
                    contractPersist.sClientAdress = txtEnderecoC.Text;
                    contractPersist.sClientNumberAdress = txtNumeroC.Text;
                    contractPersist.sClientDistrict = txtBairroC.Text;
                    contractPersist.sClientCity = txtCidadeC.Text;
                    contractPersist.ClientEstate = validation.estate(cbxEstate.SelectedIndex);

                    // data provider
                    contractPersist.sProviderName = txtNomeContratado.Text;
                    contractPersist.sProviderCpfCnpj = txtCpfCnpjContratado.Text;
                    //contractPersist.providerRg = txtRgContratado.Text; pegar rg ou inscr estadual
                    contractPersist.sProviderCep = txtCepContratado.Text;
                    contractPersist.sProviderAdress = txtEnderecoContratado.Text;
                    contractPersist.sProviderNumberAdress = txtNumeroContratado.Text;
                    contractPersist.sProviderDistrict = txtBairroContratado.Text;
                    contractPersist.sProviderCity = txtCidadeContratado.Text;
                    contractPersist.ProviderEstate = validation.estate(cbxEstateContratado.SelectedIndex);

                    // data contract general
                    contractPersist.dtContractDate = Convert.ToDateTime(dtpDataAtual.Value);
                    contractPersist.dtStartExecution = DateTime.Today;
                    contractPersist.sClientObjectContract = txtDescription.Text;
                    contractPersist.dTotalValue = Convert.ToDecimal(txtValores.Text);
                    contractPersist.sPaymentForm = txtObrigacoesContratante.Text;
                    contractPersist.iDeadline = Convert.ToInt32(txtPrazo1.Text);
                    contractPersist.iWarrantyTime = Convert.ToInt32(txtPrazoGarantia.Text);
                    contractPersist.sCity = txtCidade.Text;

                    contractPersist.sIdBudget_OS = searchBudget.sID;

                    //salva
                    objPersist.Insert(contractPersist);

                    //verifica se o orçamento foi salvo com sucesso
                    var ok = objPersist.Search.FirstOrDefault(b => b.sID == contractPersist.sID);

                    if (ok != null)
                    {
                        MessageBox.Show("Contrato Salvo com Sucesso !!!");

                        cleanScreen();

                        searchBudget.bContractRegistred = true;

                        obj.Update(searchBudget);
                        //colocar impressao aqui

                        //string Cod = ok.sID.ToString();

                        new ContractPrint(contractPersist.sID).Show();
                        
                    }
                    else
                        MessageBox.Show("Erro ao Salvar o Contrato !!!");
                }
            }
        }

        //validator YesNo
        public DialogResult messageYesNo(string type)
        {
            switch (type)
            {
                case "Save":
                    return MessageBox.Show("Deseja Gravar o Orçamento com os Dados Informados?", "Gravar Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            return DialogResult.No;
        }

        //validators CAMPS frm
        public bool validationCamps()
        {
            //if (txtNome.Text.Length.Equals(0))
            //{
            //    MessageBox.Show("Informe um NOME para o cliente");
            //    txtNome.Focus();
            //    return false;
            //}

            //if (txtEndereco.Text.Length.Equals(0))
            //{
            //    MessageBox.Show("Informe um ENDEREÇO para o cliente");
            //    txtEndereco.Focus();
            //    return false;
            //}

            //if (txtTelefone.Text.Length.Equals(0))
            //{
            //    MessageBox.Show("Informe um TELEFONE para o cliente");
            //    txtTelefone.Focus();
            //    return false;
            //}

            //if (txtCargo.Text.Length.Equals(0))
            //{
            //    MessageBox.Show("Informe um CARGO para o cliente");
            //    txtCargo.Focus();
            //    return false;
            //}

            //int compare = dgvItens.Rows.Count;
            //if (compare == 0)
            //{
            //    MessageBox.Show("Nenhum Item Adicionado ao Orçamento");
            //    txtQuantidade.Focus();
            //    return false;
            //}

            //if (!chkCombinar.Checked && !chkCheque.Checked && !chkDinheiro.Checked)
            //{
            //    MessageBox.Show("Informe a FORMA de pagamento");
            //    chkCombinar.Focus();
            //    return false;
            //}

            //if (txtPorcentDescAVista.Text == "")
            //    txtPorcentDescAVista.Text = "0";

            //if (txtPorcentJuros.Text == "")
            //    txtPorcentJuros.Text = "0";

            return true;
        }

        // CLEAN ALL DATA OF VIEW
        public void cleanScreen()
        {
            ////CLIENT
            //radComercial.Checked = true;
            //txtNome.Clear();
            //txtEndereco.Clear();
            //txtTelefone.Clear();
            //txtCargo.Clear();
            ////DGVITEMS
            //txtQuantidade.Text = "";
            //txtDescricao.Text = "";
            //txtValorUnitario.Text = "";
            //txtValorTotal.Text = "0";
            //lblSubTotalValor.Text = "0";
            //dgvItens.Rows.Clear();
            //subTotal = 0;
            ////PAYMENTS
            //chkCombinar.Checked = false;
            //chkCheque.Checked = false;
            //chkDinheiro.Checked = false;
            //txtPorcentDescAVista.Text = "0";
            //lblExibeValorDesconto.Text = "0";
            //nudParcelas.Value = 1;
            //lblValorPorParcela.Text = "0";
            //chkJuros.Checked = false;
            //txtPorcentJuros.Text = "0";
            //lblValorJuros.Text = "0";
            //lblExibeValorTotalParcelado.Text = "0";
            ////DELIVERY
            //nudDias.Value = 1;
            ////WARRANTY
            //nudAnos.Value = 1;
            //rtfObservacoes.Clear();
            //lblTotalGeralValor.Text = "0";
        }
    }
}
