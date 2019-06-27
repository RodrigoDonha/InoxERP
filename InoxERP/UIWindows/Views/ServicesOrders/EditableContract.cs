using System;
using System.Linq;
using System.Windows.Forms;
using InoxERP.UI_Windows_Forms;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;
using UIWindows.Entities.Enum;
using UIWindows.Views.Reports.Contracts;

namespace UIWindows.Views.ServicesOrders
{
    public partial class EditableContract : Form
    {
        ValidationEntries validation = new ValidationEntries();
        Contracts contract = new Contracts();

        static InoxErpContext ctx = new InoxErpContext();
        Budgets_OS searchBudget = new Budgets_OS();
        Budget_OSBusiness obj = new Budget_OSBusiness(ctx);

        private string getId;

        public EditableContract(string id, string type)
        {
            InitializeComponent();
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

        // data client
        string nomeC;
        string cpfC;
        string rgC;
        string cepC;
        string enderecoC;
        string numeroEnderecoC;
        string bairroEnderecoC;
        string cidadeEnderecoC;
        string estadoEnderecoC;

        string valores;
        string warrant;
        string prize;

        public void fillContractOfObject()
        {
            

            if (searchBudget.IdClients != null)
            {
                Clients cli = new Clients();
                ClientsBusiness clients = new ClientsBusiness(ctx);

                string idClient = searchBudget.IdClients;
                cli = clients.ReturnByID(idClient);

                nomeC = cli.sName.ToUpper();
                cpfC = cli.sCpfCnpj;
                rgC = cli.sRg;
                cepC = cli.sCEP;
                enderecoC = cli.sAdress.ToUpper();
                numeroEnderecoC = cli.iNumber.ToString();
                bairroEnderecoC = cli.sDistrict.ToUpper();
                cidadeEnderecoC = cli.sCity.ToUpper();
                estadoEnderecoC = cli.Estate.ToString();
                // colocar este depois se precisar:-> cbxEstateContratado.SelectedIndex = 24;
            }
            else
            {
                nomeC = searchBudget.sName.ToUpper();
                enderecoC = searchBudget.sAdress.ToUpper();
            }

            // colocar a string description no local dos itens e descrição no contrato
            string description = "";
            description += "ITEMS:\r\n\r\n";
            foreach (var line in searchBudget.Items.ToList()) // math.round(var,2)
            {
                description += line.dAmount + " - " + line.sDescription + " - " + line.dPrice + " - " + line.dTotal + " \r\n ";
            }
            description += "\r\nDESCRIÇÃO DO SERVIÇO:\r\n" + "\r\n" + searchBudget.sObservation;

            //txtContract.Text = description;
            //if (description.Length > 3500)
            //{
            //    MessageBox.Show("A Descrição atingiu o limite máximo de caracteres, verifique e resuma a descrição.");
            //}
            
            valores = searchBudget.dTotal.ToString();
            
            string obligations = "Forma de pagamento: " + paymentForm(searchBudget.PaymentMethods) + " - Parcelamento: " + searchBudget.iPaymentInstallments;
            
            // colocar a string obligations no local das obrigações do contrato.
            //txtObrigacoesContratante.Text = obligations;
            //txtObrigacoesContratante1.Text = obligations;

            warrant = searchBudget.iWarrantyTime.ToString();

            prize = Convert.ToString(searchBudget.iPrevisionOfExecute);
            //txtPrazo2.Text = Convert.ToString(searchBudget.iPrevisionOfExecute);
            
            // não estava no contrato, pode excluir.
            //string cidade = searchBudget.Clients.sCity;
            //txtCidade.Text = cidade;
        }

        public void fillContractOfObjectClientAltered(string idBudget, Clients cli)
        {
            Budgets_OS searchBudgetAltered = new Budgets_OS();
            Budget_OSBusiness objAltered = new Budget_OSBusiness(ctx);

            if (idBudget != "")
            {
                searchBudgetAltered = objAltered.ReturnByID(idBudget);

                string idClient = searchBudgetAltered.IdClients;

                nomeC = cli.sName.ToUpper();
                cpfC = cli.sCpfCnpj;
                rgC = cli.sRg;
                cepC = cli.sCEP;
                enderecoC = cli.sAdress.ToUpper();
                numeroEnderecoC = cli.iNumber.ToString();
                bairroEnderecoC = cli.sDistrict.ToUpper();
                cidadeEnderecoC = cli.sCity.ToUpper();
                //cbxEstate.Text = cli.Estate.ToString();
            }
            else
            {
                nomeC = searchBudgetAltered.sName.ToUpper();
                enderecoC = searchBudgetAltered.sAdress.ToUpper();
            }

            // colocar a string description no local dos itens e descrição no contrato
            string description = "";
            description += "ITEMS:\r\n\r\n";
            foreach (var line in searchBudgetAltered.Items.ToList()) // math.round(var,2)
            {
                description += line.dAmount + " - " + line.sDescription + " - " + line.dPrice + " - " + line.dTotal + " \r\n ";
            }
            description += "\r\nDESCRIÇÃO DO SERVIÇO:\r\n" + "\r\n" + searchBudget.sObservation;

            //txtDescription.Text = description;
            //if (description.Length > 3500)
            //{
            //    MessageBox.Show("A Descrição atingiu o limite máximo de caracteres, verifique e resuma a descrição.");
            //}

            valores = searchBudgetAltered.dTotal.ToString();
            //txtValores1.Text = searchBudgetAltered.dTotal.ToString();
            string obligations = "Forma de pagamento: " + paymentForm(searchBudgetAltered.PaymentMethods) + " - Parcelamento: " + searchBudgetAltered.iPaymentInstallments;

            //txtObrigacoesContratante.Text = obligations;
            //txtObrigacoesContratante1.Text = obligations;

            warrant = searchBudgetAltered.iWarrantyTime.ToString();
            prize = Convert.ToString(searchBudget.iPrevisionOfExecute);
            //txtPrazo2.Text = Convert.ToString(searchBudget.iPrevisionOfExecute);
            
            
            //string cidade = searchBudget.Clients.sCity;
            //txtCidade.Text = cidade;
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
                txtCepContratado.Text = "19045-333";
                txtEnderecoContratado.Text = "RUA ROTARY CLUBE DE PRESIDENTE PRUDENTE-ALVOR";
                txtNumeroContratado.Text = "25";
                txtBairroContratado.Text = "VILA ROTARIA \"ARCH C. KLUMPH\"";
                txtCidadeContratado.Text = "PRESIDENTE PRUDENTE";
                cbxEstateContratado.SelectedIndex = 24; // SP
            }
            else
            {
                txtNomeContratado.Text = "LUCAS BEIRIGO REGGIANI 09396759945";
                txtCpfCnpjContratado.Text = "30.286.217/0001-70";
                txtRgContratado.Text = "562.431.339.111"; //"093967599-45";
                txtCepContratado.Text = "19065-510";
                txtEnderecoContratado.Text = "AV. DAS FLORES";
                txtNumeroContratado.Text = "210";
                txtBairroContratado.Text = "CECAP";
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
    }
}