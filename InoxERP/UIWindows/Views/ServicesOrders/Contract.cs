using System;
using System.Linq;
using System.Windows.Forms;
using InoxERP.UI_Windows_Forms;
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
        Contracts contract = new Contracts();

        static InoxErpContext ctx = new InoxErpContext();
        Budgets_OS searchBudget = new Budgets_OS();

        //Clients cli = new Clients();
        //ClientsBusiness clients = new ClientsBusiness(ctx);

        private string getId;
        
        public frmContract(string id, string type)
        {
            getId = id;
            InitializeComponent();

            if (type == "Budget")
            {
                getData();
                fillContractOfObject();
            }

            if (type == "Contract")
            {

            }

            btnProximo.Text = "Próximo";
            btnVoltar.Visible = false;
            FillDataHired();
            cbxEstateContratado.SelectedIndex = 24;
        }

        public void getData()
        {
            InoxErpContext ctx = new InoxErpContext();
            Budgets_OS searchBudgetNew = new Budgets_OS();
            Budget_OSBusiness obj = new Budget_OSBusiness(ctx);

            searchBudgetNew = obj.ReturnByID(getId);
            searchBudget = null;
            searchBudget = searchBudgetNew;
        }

        public void fillContractOfObject()
        {
            if (searchBudget.IdClients != null)
            {
                    Clients cli = new Clients();
                    ClientsBusiness clients = new ClientsBusiness(ctx);
                    
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

            string description = "";
            description += "ITEMS:\r\n\r\n";
            foreach (var line in searchBudget.Items.ToList()) // math.round(var,2)
            {
                description += line.dAmount + " - " + line.sDescription + " - " + line.dPrice + " - " + line.dTotal + " \r\n ";
            }
            description += "\r\nDESCRIÇÃO DO SERVIÇO:\r\n" + "\r\n" + searchBudget.sObservation;
            txtDescription.Text = description;
            if (description.Length > 3500)
            {
                MessageBox.Show("A Descrição atingiu o limite máximo de caracteres, verifique e resuma a descrição.");
            }

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

        public void fillContractOfObjectClientAltered(string idBudget, Clients cli)
        {
            Budgets_OS searchBudgetAltered = new Budgets_OS();
            Budget_OSBusiness objAltered = new Budget_OSBusiness(ctx);

            if (idBudget != "")
            {
                searchBudgetAltered = objAltered.ReturnByID(idBudget);

                string idClient = searchBudgetAltered.IdClients;
                
                txtNomeC.Text = cli.sName.ToUpper();
                txtCpfCnpjC.Text = cli.sCpfCnpj;
                txtRgC.Text = cli.sRg;
                txtCepC.Text = cli.sCEP;
                txtEnderecoC.Text = cli.sAdress.ToUpper();
                txtNumeroC.Text = cli.iNumber.ToString();
                txtBairroC.Text = cli.sDistrict.ToUpper();
                txtCidadeC.Text = cli.sCity.ToUpper();
                cbxEstate.Text = cli.Estate.ToString();
            }
            else
            {
                txtNomeC.Text = searchBudgetAltered.sName.ToUpper();
                txtEnderecoC.Text = searchBudgetAltered.sAdress.ToUpper();
            }

            string description = "";
            description += "ITEMS:\r\n\r\n";
            foreach (var line in searchBudgetAltered.Items.ToList()) // math.round(var,2)
            {
                description += line.dAmount + " - " + line.sDescription + " - " + line.dPrice + " - " + line.dTotal + " \r\n ";
            }
            description += "\r\nDESCRIÇÃO DO SERVIÇO:\r\n" + "\r\n" + searchBudget.sObservation;
            txtDescription.Text = description;
            if (description.Length > 3500)
            {
                MessageBox.Show("A Descrição atingiu o limite máximo de caracteres, verifique e resuma a descrição.");
            }

            txtValores.Text = searchBudgetAltered.dTotal.ToString();
            txtValores1.Text = searchBudgetAltered.dTotal.ToString();
            string obligations = "Forma de pagamento: " + paymentForm(searchBudgetAltered.PaymentMethods) + " - Parcelamento: " + searchBudgetAltered.iPaymentInstallments;
            txtObrigacoesContratante.Text = obligations;
            txtObrigacoesContratante1.Text = obligations;
            txtPrazoGarantia.Text = searchBudgetAltered.iWarrantyTime.ToString();
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
            if (validationCampsClient())
                ConfirmPositionTabToNext();
        }

        public void ConfirmPositionTabToNext()
        {
            if (validationCampsClient())
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
                    txtObrigacoesContratante1.Text = txtObrigacoesContratante.Text;
                    txtValores1.Text = txtValores.Text;
                    btnProximo.Text = "Próximo";
                    tabControl1.SelectedTab = tabPage4;
                    btnVoltar.Visible = true;
                }
                else if (tabControl1.SelectedTab == tabPage4)
                {
                    btnProximo.Text = "Gravar";
                    tabControl1.SelectedTab = tabPage5;
                    btnVoltar.Visible = true;
                }
                else if (tabControl1.SelectedTab == tabPage5)
                {
                    btnVoltar.Visible = true;
                    // implementar aqui o gravar contrato
                    gravarContrato();
                }
            }
                
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (validationCampsClient())
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
                    btnProximo.Text = "Próximo";
                    btnVoltar.Visible = true;
                }
                if (tabControl1.SelectedTab == tabPage5)
                {
                    btnProximo.Text = "Gravar";
                    btnVoltar.Visible = true;
                }
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
            else if (tabControl1.SelectedTab == tabPage5)
            {
                btnProximo.Text = "Gravar";
                tabControl1.SelectedTab = tabPage4;
                btnVoltar.Visible = true;
            }
        }

        private void btnAlterarContratado_Click(object sender, EventArgs e)
        {
            FillDataHired();
        }

        private void FillDataHired()
        {
            if (txtNomeContratado.Text == "LUCAS BEIRIGO REGGIANI 09396759945")
            {
                txtNomeContratado.Text = "RICHARD CARLOS REGGIANI 16479617851";
                txtCpfCnpjContratado.Text = "31.210.732/0001-30";
                txtRgContratado.Text = "562.439.989.118";
                txtCepContratado.Text = "19046-070";
                txtEnderecoContratado.Text = "RUA MENDES DE MORAIS";
                txtNumeroContratado.Text = "1871";
                txtBairroContratado.Text = "VILA PAULO ROBERTO";
                txtCidadeContratado.Text = "PRESIDENTE PRUDENTE";
                cbxEstateContratado.SelectedIndex = 24; // SP
            }
            else
            {
                txtNomeContratado.Text = "LUCAS BEIRIGO REGGIANI 09396759945";
                txtCpfCnpjContratado.Text = "30.286.217/0001-70";
                txtRgContratado.Text = "562.431.339.111"; //"093967599-45";
                txtCepContratado.Text = "19046-070";
                txtEnderecoContratado.Text = "RUA MENDES DE MORAIS";
                txtNumeroContratado.Text = "1871";
                txtBairroContratado.Text = "VILA PAULO ROBERTO";
                txtCidadeContratado.Text = "PRESIDENTE PRUDENTE";
                cbxEstateContratado.SelectedIndex = 24; // SP
            }
        }

        public void gravarContrato()
        {
            if (validationCamps())
            {
                if (messageYesNo("Save") == DialogResult.Yes)
                {
                    // Alterar
                    if (txtIdContract.Text == getId)
                    {
                        InoxErpContext ctxAlter = new InoxErpContext();
                        ContractBusiness objAlter = new ContractBusiness(ctxAlter);
                        Contracts contractAlter = new Contracts();
                        Contracts contractBudgetId = new Contracts();
                        Budget_OSBusiness objAlterBudget = new Budget_OSBusiness(ctxAlter);

                        contractAlter = objAlter.ReturnByID(getId);

                        contractAlter.sID = txtIdContract.Text;

                        //FILL DATA CONTRACT

                        //data client
                        contractAlter.sClientName = txtNomeC.Text;
                        contractAlter.sClientCpfCnpj = txtCpfCnpjC.Text;
                        contractAlter.sClientRg = txtRgC.Text;
                        contractAlter.sClientCep = txtCepC.Text;
                        contractAlter.sClientAdress = txtEnderecoC.Text;
                        contractAlter.sClientNumberAdress = txtNumeroC.Text;
                        contractAlter.sClientDistrict = txtBairroC.Text;
                        contractAlter.sClientCity = txtCidadeC.Text;
                        contractAlter.ClientEstate = validation.estate(cbxEstate.SelectedIndex);

                        // data provider
                        contractAlter.sProviderName = txtNomeContratado.Text;
                        contractAlter.sProviderCpfCnpj = txtCpfCnpjContratado.Text;
                        contractAlter.sRegistStateRg = txtRgContratado.Text;
                        contractAlter.sProviderCep = txtCepContratado.Text;
                        contractAlter.sProviderAdress = txtEnderecoContratado.Text;
                        contractAlter.sProviderNumberAdress = txtNumeroContratado.Text;
                        contractAlter.sProviderDistrict = txtBairroContratado.Text;
                        contractAlter.sProviderCity = txtCidadeContratado.Text;
                        contractAlter.ProviderEstate = validation.estate(cbxEstateContratado.SelectedIndex);

                        // data contract general
                        contractAlter.dtContractDate = Convert.ToDateTime(dtpDataAtual.Value);
                        contractAlter.dtStartExecution = DateTime.Today;
                        contractAlter.sClientObjectContract = txtDescription.Text;
                        contractAlter.dTotalValue = Convert.ToDecimal(txtValores.Text);
                        contractAlter.sPaymentForm = txtObrigacoesContratante.Text;
                        contractAlter.iDeadline = Convert.ToInt32(txtPrazo1.Text);
                        contractAlter.iWarrantyTime = Convert.ToInt32(txtPrazoGarantia.Text);
                        contractAlter.sCity = txtCidade.Text;

                        contractAlter.sIdBudget_OS = contractBudgetId.sID;
                        contractAlter.sIdBudget_OS = getId;
                        contractAlter.bEditableContract = false;
                        contractAlter.sEditableContract = ".";
                        //contractAlter.Budgets_OS = contractBudgetId;
                        getId = "";

                        //salva
                        objAlter.Update(contractAlter);

                        //verifica se o orçamento foi salvo com sucesso
                        var okAlter = objAlter.Search.FirstOrDefault(b => b.sID == contractAlter.sID);

                        if (okAlter != null)
                        {
                            MessageBox.Show("Contrato Alterado com Sucesso !!!");

                            this.Dispose();

                            // impressao
                            new ContractPrint(contractAlter.sID).Show();
                        }
                        else
                            MessageBox.Show("Erro ao Alterar o Contrato !!!");
                    }
                    else
                    {   // Gravar
                        InoxErpContext ctxPersist = new InoxErpContext();
                        ContractBusiness objPersist = new ContractBusiness(ctxPersist);
                        Contracts contractPersist = new Contracts();

                        Budgets_OS searchBud = new Budgets_OS();
                        Budget_OSBusiness obj = new Budget_OSBusiness(ctx);

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
                        contractPersist.sRegistStateRg = txtRgContratado.Text;
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


                        //contractPersist.sIdBudget_OS = searchBudget.sID;
                        contractPersist.sIdBudget_OS = getId;
                        contractPersist.bEditableContract = false;
                        contractPersist.sEditableContract = ".";
                        getId = "";

                        //salva
                        objPersist.Insert(contractPersist);

                        //verifica se o orçamento foi salvo com sucesso
                        var ok = objPersist.Search.FirstOrDefault(b => b.sID == contractPersist.sID);

                        if (ok != null)
                        {
                            MessageBox.Show("Contrato Salvo com Sucesso !!!");

                            searchBud = obj.ReturnByID(contractPersist.sIdBudget_OS);

                            searchBud.bContractRegistred = true;

                            obj.Update(searchBud);

                            this.Dispose();

                            // impressao
                            new ContractPrint(contractPersist.sID).Show();
                        }
                        else
                            MessageBox.Show("Erro ao Salvar o Contrato !!!");
                    }
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
            // CONTRATANTE
            if (txtNomeC.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um NOME para o cliente");
                txtNomeC.Focus();
                return false;
            }

            if (txtCpfCnpjC.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um CPF/CNPJ para o cliente");
                txtEnderecoC.Focus();
                return false;
            }

            if (txtRgC.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um RG / INSCR EST. para o cliente");
                txtEnderecoC.Focus();
                return false;
            }

            if (txtCepC.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um CEP para o cliente");
                txtEnderecoC.Focus();
                return false;
            }

            if (txtEnderecoC.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um ENDEREÇO para o cliente");
                txtEnderecoC.Focus();
                return false;
            }

            if (txtNumeroC.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um NÚMERO para o cliente");
                txtEnderecoC.Focus();
                return false;
            }

            if (txtBairroC.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um BAIRRO para o cliente");
                txtEnderecoC.Focus();
                return false;
            }

            if (txtCidadeC.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um CIDADE para o cliente");
                txtEnderecoC.Focus();
                return false;
            }

            if (cbxEstate.SelectedIndex < 0)
            {
                MessageBox.Show("Informe um ESTADO para o cliente");
                txtEnderecoC.Focus();
                return false;
            }

            // CONTRATADO
            if (txtNomeC.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um NOME para o cliente");
                txtNomeC.Focus();
                return false;
            }

            if (txtCpfCnpjContratado.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um CPF/CNPJ para o Contratado");
                txtEnderecoContratado.Focus();
                return false;
            }

            if (txtRgContratado.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um RG / INSCR EST. para o Contratado");
                txtEnderecoContratado.Focus();
                return false;
            }

            if (txtCepContratado.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um CEP para o Contratado");
                txtEnderecoContratado.Focus();
                return false;
            }

            if (txtEnderecoContratado.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um ENDEREÇO para o Contratado");
                txtEnderecoContratado.Focus();
                return false;
            }

            if (txtNumeroContratado.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um NÚMERO para o Contratado");
                txtEnderecoContratado.Focus();
                return false;
            }

            if (txtBairroContratado.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um BAIRRO para o Contratado");
                txtEnderecoContratado.Focus();
                return false;
            }

            if (txtCidadeContratado.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um CIDADE para o Contratado");
                txtEnderecoContratado.Focus();
                return false;
            }

            if (cbxEstateContratado.SelectedIndex < 0)
            {
                MessageBox.Show("Informe um ESTADO para o Contratado");
                txtEnderecoContratado.Focus();
                return false;
            }

            // OBJETO, FORMAS DE PAGAMENTO E PRAZOS

            if (txtDescription.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um OBJETO para o Contrato");
                txtDescription.Focus();
                return false;
            }

            if (txtValores.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um VALOR para o Contrato na aba 3");
                txtValores.Focus();
                return false;
            }

            if (txtObrigacoesContratante.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe as OBRIGAÇÕES para o Contratante");
                txtObrigacoesContratante.Focus();
                return false;
            }

            if (txtPrazo1.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe os PRAZO DE VIGENCIA para o Contrato na aba 4, Clausula 5º");
                txtPrazo1.Focus();
                return false;
            }

            if (txtValores1.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe o VALORE para o Contrato na aba 4, Clausula 6º");
                txtValores1.Focus();
                return false;
            }

            if (txtObrigacoesContratante1.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe as OBRIGAÇÕES para o Contratante na aba 4, Clausula 6º");
                txtObrigacoesContratante1.Focus();
                return false;
            }

            if (txtPrazo2.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe o PRAZO DE ENTREGA para o Produto na aba 4, Clausula 6º");
                txtPrazo2.Focus();
                return false;
            }

            if (txtPrazoGarantia.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe o PRAZO DE GARANTIA do Produto na aba 4, Clausula 6º");
                txtPrazoGarantia.Focus();
                return false;
            }

            if (txtCidade.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe a CIDADE DE EMISSÃO do Contrato na aba 4");
                txtCidade.Focus();
                return false;
            }

            return true;
        }

        // valida numeros e virgula, só permite lançar 1 vez a vírgula
        public void validationEntriesNumericsAndComma(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbersAndComma(sender, e);
        }

        public void validationEntriesPhones(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyPhones(sender, e);
        }

        public void validationEntriesCPFandRG(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyCPFandCNPJ(sender, e);
        }

        public void validationEntriesCEP(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyCEP(sender, e);
        }

        public void validationOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorNumbers(sender, e);
        }

        public void ContractData(string id)
        {
            InoxErpContext ctxData = new InoxErpContext();
            ContractBusiness objData = new ContractBusiness(ctxData);
            contract = null;

            contract = objData.returnById(id);
            fillContractOfObjectSearch(contract);
        }

        public void fillContractOfObjectSearch(Contracts c)
        {
            if (c.sID != null)
            {
                txtIdContract.Text = c.sID;
                txtNomeC.Text = c.sClientName.ToUpper();
                txtCpfCnpjC.Text = c.sClientCpfCnpj;
                txtRgC.Text = c.sClientRg;
                txtCepC.Text = c.sClientCep;
                txtEnderecoC.Text = c.sClientAdress.ToUpper();
                txtNumeroC.Text = c.sClientNumberAdress;
                txtBairroC.Text = c.sClientDistrict.ToUpper();
                txtCidadeC.Text = c.sClientCity.ToUpper();
                cbxEstate.Text = c.ClientEstate.ToString();
                txtNomeContratado.Text = c.sProviderName;
                txtCpfCnpjContratado.Text = c.sProviderCpfCnpj;
                txtRgContratado.Text = c.sRegistStateRg;
                txtCepContratado.Text = c.sProviderCep;
                txtEnderecoContratado.Text = c.sProviderAdress;
                txtNumeroContratado.Text = c.sProviderNumberAdress;
                txtBairroContratado.Text = c.sProviderDistrict;
                txtCidadeContratado.Text = c.sProviderCity;
                cbxEstateContratado.SelectedIndex = 24;
                txtDescription.Text = c.sClientObjectContract;
                txtValores.Text = c.dTotalValue.ToString();
                txtValores1.Text = c.dTotalValue.ToString();
                txtObrigacoesContratante.Text = c.sPaymentForm;
                txtObrigacoesContratante1.Text = c.sPaymentForm;
                txtPrazoGarantia.Text = c.iWarrantyTime.ToString();
                txtPrazo1.Text = c.iDeadline.ToString();
                txtPrazo2.Text = c.iDeadline.ToString();
                txtCidade.Text = c.sCity;
                dtpDataAtual.Text = c.dtContractDate.ToString();
            }
        }

        public bool validationCampsClient()
        {
            // CONTRATANTE
            if (txtNomeC.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um NOME para o cliente");
                txtNomeC.Focus();
                Clients();
                return false;
            }

            if (txtCpfCnpjC.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um CPF/CNPJ para o cliente");
                txtEnderecoC.Focus();
                Clients();
                return false;
            }

            if (txtRgC.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um RG / INSCR EST. para o cliente");
                txtEnderecoC.Focus();
                Clients();
                return false;
            }

            if (txtCepC.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um CEP para o cliente");
                txtEnderecoC.Focus();
                Clients();
                return false;
            }

            if (txtEnderecoC.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um ENDEREÇO para o cliente");
                txtEnderecoC.Focus();
                Clients();
                return false;
            }

            if (txtNumeroC.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um NÚMERO para o cliente");
                txtEnderecoC.Focus();
                Clients();
                return false;
            }

            if (txtBairroC.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um BAIRRO para o cliente");
                txtEnderecoC.Focus();
                Clients();
                return false;
            }

            if (txtCidadeC.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um CIDADE para o cliente");
                txtEnderecoC.Focus();
                Clients();
                return false;
            }

            if (cbxEstate.SelectedIndex < 0)
            {
                MessageBox.Show("Informe um ESTADO para o cliente");
                txtEnderecoC.Focus();
                Clients();
                return false;
            }

            return true;
        }

        public void Clients()
        {
            try
            {
                frmClientsRegister client = new frmClientsRegister(searchBudget.IdClients, "Contract", searchBudget.sID);
                client.completeRegister(searchBudget.IdClients);
                searchBudget = null;
                Close();
                client.Show();
            }
            catch
            {
                MessageBox.Show("Não foi possível selecionar o Cliente, tente selecionar novamente.");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
