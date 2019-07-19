using System;
using System.Linq;
using System.Windows.Forms;
using InoxERP.UI_Windows_Forms;
using SqlContracts;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;
using UIWindows.Entities.Enum;
using UIWindows.Views.Reports.Contracts;

namespace UIWindows.Views.ServicesOrders
{
    public partial class frmEditableContract : Form
    {
        ValidationEntries validation = new ValidationEntries();
        Contracts contract = new Contracts();

        static InoxErpContext ctx = new InoxErpContext();
        Budgets_OS searchBudget = new Budgets_OS();
        Budget_OSBusiness obj = new Budget_OSBusiness(ctx);

        Hired hrd = new Hired();

        private string getId;

        // data client
        private string nomeC;
        private string cpfCnpjC;
        private string rgIncrEstC;
        private string cepC;
        private string enderecoC;
        private string numeroEnderecoC;
        private string bairroEnderecoC;
        private string cidadeEnderecoC;
        private string estadoEnderecoC;

        private string description;
        private string obligations;
        private string valores;
        private string warrant;
        private string prize;

        private string contractStandard = "";

        public frmEditableContract(string id, string type)
        {
            getId = id;

            frmSelectProvider slcProv = new frmSelectProvider("frmEditableContract");
            slcProv.ShowDialog();
            hrd = slcProv.Returns();
            
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
        
        public void fillContractOfObject()
        {
            if (searchBudget.IdClients != null)
            {
                Clients cli = new Clients();
                ClientsBusiness clients = new ClientsBusiness(ctx);

                string idClient = searchBudget.IdClients;
                cli = clients.ReturnByID(idClient);

                nomeC = cli.sName.ToUpper();
                cpfCnpjC = cli.sCpfCnpj;
                rgIncrEstC = cli.sRg;
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
            
            obligations = "Forma de pagamento: " + paymentForm(searchBudget.PaymentMethods) + " - Parcelamento: " + searchBudget.iPaymentInstallments;
            
            // colocar a string obligations no local das obrigações do contrato.
            //txtObrigacoesContratante.Text = obligations;
            //txtObrigacoesContratante1.Text = obligations;

            warrant = searchBudget.iWarrantyTime.ToString();

            prize = Convert.ToString(searchBudget.iPrevisionOfExecute);
            //txtPrazo2.Text = Convert.ToString(searchBudget.iPrevisionOfExecute);

            // não estava no contrato, pode excluir.
            //string cidade = searchBudget.Clients.sCity;
            //txtCidade.Text = cidade;

            contractStandard = "IDENTIFICAÇÃO DAS PARTES CONTRATADAS" + "\r\n" +
                                "CONTRATANTE: Nome: " + nomeC + ", CPF/CNPJ: " + cpfCnpjC + ", RG/Inscr. Est.: " + rgIncrEstC + ", Endereço: " + enderecoC + " Nº. " + numeroEnderecoC + ", Bairro: " +
                                bairroEnderecoC + ", Cidade: " + cidadeEnderecoC + "/" + estadoEnderecoC + "." + "\r\n" + "\r\n" +

                                "CONTRATADO: Nome: " + hrd.Name + ", CPF/CNPJ: " + hrd.CpfCnpj + ", Endereço: " + hrd.Adress + " Nº: "
                                + hrd.Number + " Bairro: " + hrd.District + "Cidade: " + hrd.City + "/" + hrd.Estate +
                                "\r\n" +
                                "DO OBJETO DO CONTRATO" + "\r\n" +
                                "CLÁUSULA 1ª:" + "\r\n" +
                                "É objeto do presente contrato a prestação de serviços de:" + "\r\n" +
                                "Descrição:" + "\r\n" +
                                "ITEMS:" + "\r\n" +
                                description + "\r\n" +
                                "\r\n" +

                                "DAS OBRIGAÇÕES" + "\r\n" +
                                "CLÁUSULA 2ª:" + "\r\n" +
                                "O CONTRATANTE deve fornecer ao CONTRATADO as condições essenciais à realização do serviço." + "\r\n" + "\r\n" +
                                "CLÁUSULA 3ª:" + "\r\n" +
                                "O CONTRATANTE efetuará ao CONTRATADO o pagamento pelo serviço realizado nos valores, no prazo, na forma e nas condições estabelecidas na cláusula 5ª." + "\r\n" +
                                "DOS VALORES E CONDIÇÕES DE PAGAMENTO" + "\r\n" +
                                "CLÁUSULA 4ª:" + "\r\n" +
                                "Pela realização dos serviços descritos neste contrato, o CONTRATANTE remunerará o CONTRATADO com o valor de R$ " + valores + " a serem pagos via Forma de pagamento: " + obligations + "." + "\r\n" + 
                                "\r\n" +
                                "DO PRAZO" + "\r\n" +
                                "CLÁUSULA 5ª:" + "\r\n" +
                                "O presente contrato de prestação de serviços terá vigência por prazo de 1, podendo ser prorrogado por condições climáticas inadequadas, má condições do ambiente onde será executado o serviço ou motivo de força maior por mais 10 dias úteis, por solicitação do CONTRATADO e mediante comunicação ao CONTRATANTE." + "\r\n" +
                                 "\r\n" +
                                "DA MULTA" + "\r\n" +
                                "CLÁUSULA 6ª:" + "\r\n" +
                                "Caso não ocorra o pagamento na data pactuada pelas partes acordadas o CONTRATANTE poderá ser protestado e será tomadas as medidas cabíveis para recebimento arcando com todas as despesas." + "\r\n" +
                                 "\r\n" +
                                 "CLÁUSULA 7ª:" + "\r\n" +
                                "Caso o serviço prestado não seja entregue na data pactuada pelas partes acordadas o CONTRATADO poderá ser protestado e será tomado as medidas cabíveis , arcando com as eventuais despesas." + "\r\n" +
                                 "\r\n" +
                                "Valor total do serviço prestado: R$ " + valores + ", sendo: Forma de pagamento: " + obligations + "." + "\r\n" +
                                 "\r\n" +
                                "Referente ao prazo de entrega de: " + prize + " dia(s) útil(úteis), a partir da data de pagamento da Entrada." +
                                "\r\n" + "(Informe a Cidade Local Aqui)";
            //txtContract.Text = contractStandard;
            rtfContract.Text = contractStandard;
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
                cpfCnpjC = cli.sCpfCnpj;
                rgIncrEstC = cli.sRg;
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
            
        }

        public void gravarContrato()
        {
            if (messageYesNo("Save") == DialogResult.Yes)
            {
                // Alterar
                if (getId == "1") // implementar depois.
                {
                    InoxErpContext ctxAlter = new InoxErpContext();
                    ContractBusiness objAlter = new ContractBusiness(ctxAlter);
                    Contracts contractAlter = new Contracts();
                    Contracts contractBudgetId = new Contracts();
                    Budget_OSBusiness objAlterBudget = new Budget_OSBusiness(ctxAlter);

                    contractAlter = objAlter.ReturnByID(getId);

                    contractAlter.sID = getId;

                    //FILL DATA CONTRACT

                    //data client
                    contractAlter.sClientName = nomeC;
                    contractAlter.sClientCpfCnpj = cpfCnpjC;
                    contractAlter.sClientRg = rgIncrEstC;
                    contractAlter.sClientCep = cepC;
                    contractAlter.sClientAdress = enderecoC;
                    contractAlter.sClientNumberAdress = numeroEnderecoC;
                    contractAlter.sClientDistrict = bairroEnderecoC;
                    contractAlter.sClientCity = cidadeEnderecoC;
                    //contractAlter.ClientEstate = validation.estate(cbxEstate.SelectedIndex);

                    // data provider
                    //contractAlter.sProviderName = nomeContratado;
                    //contractAlter.sProviderCpfCnpj = cpfCnpjContratado;
                    //contractAlter.sRegistStateRg = rgContratado;
                    //contractAlter.sProviderCep = cepContratado;
                    //contractAlter.sProviderAdress = enderecoContratado;
                    //contractAlter.sProviderNumberAdress = numeroContratado;
                    //contractAlter.sProviderDistrict = bairroContratado;
                    //contractAlter.sProviderCity = cidadeContratado;
                    //contractAlter.ProviderEstate = validation.estate(cbxEstateContratado.SelectedIndex);

                    // data contract general
                    contractAlter.dtContractDate = DateTime.Now;
                    contractAlter.dtStartExecution = DateTime.Today;
                    contractAlter.sClientObjectContract = description;
                    contractAlter.dTotalValue = Convert.ToDecimal(valores);
                    contractAlter.sPaymentForm = obligations;
                    contractAlter.iDeadline = Convert.ToInt16(prize);
                    contractAlter.iWarrantyTime = Convert.ToInt32(warrant);
                    //contractAlter.sCity = cidadeContratado;

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
                    contractPersist.sClientName = nomeC;
                    contractPersist.sClientCpfCnpj = cpfCnpjC;
                    contractPersist.sClientRg = rgIncrEstC;
                    contractPersist.sClientCep = cepC;
                    contractPersist.sClientAdress = enderecoC;
                    contractPersist.sClientNumberAdress = numeroEnderecoC;
                    contractPersist.sClientDistrict = bairroEnderecoC;
                    contractPersist.sClientCity = cidadeEnderecoC;
                    //contractPersist.ClientEstate = cidadeEnderecoC; //validation.estate(cbxEstate.SelectedIndex);

                    // data provider
                    contractPersist.sProviderName = hrd.Name;
                    contractPersist.sProviderCpfCnpj = hrd.CpfCnpj;
                    contractPersist.sRegistStateRg = hrd.InscrEst;
                    contractPersist.sProviderCep = hrd.CEP;
                    contractPersist.sProviderAdress = hrd.Adress;
                    contractPersist.sProviderNumberAdress = hrd.Number;
                    contractPersist.sProviderDistrict = hrd.District;
                    contractPersist.sProviderCity = hrd.City;
                    //contractPersist.ProviderEstate = validation.estate(cbxEstateContratado.SelectedIndex);

                    // data contract general
                    contractPersist.dtContractDate = Convert.ToDateTime(dtpDate.Text);
                    contractPersist.dtStartExecution = Convert.ToDateTime(dtpDate.Text);
                    contractPersist.sClientObjectContract = description;
                    contractPersist.dTotalValue = Convert.ToDecimal(valores);
                    contractPersist.sPaymentForm = obligations;
                    contractPersist.iDeadline = Convert.ToInt32(prize);
                    contractPersist.iWarrantyTime = Convert.ToInt32(warrant);
                    contractPersist.sCity = "";

                    contractPersist.sEditableContract = rtfContract.Text + ", " + dtpDate.Text;

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
                        new EditableContractPrint(contractPersist.sID).Show();
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

        public void ContractData(string id)
        {
            InoxErpContext ctxData = new InoxErpContext();
            ContractBusiness objData = new ContractBusiness(ctxData);
            contract = null;

            contract = objData.returnById(id);
            //fillContractOfObjectSearch(contract);
        }

        //public void fillContractOfObjectSearch(Contracts c)
        //{
        //    if (c.sID != null)
        //    {
        //        txtIdContract.Text = c.sID;
        //        txtNomeC.Text = c.sClientName.ToUpper();
        //        txtCpfCnpjC.Text = c.sClientCpfCnpj;
        //        txtRgC.Text = c.sClientRg;
        //        txtCepC.Text = c.sClientCep;
        //        txtEnderecoC.Text = c.sClientAdress.ToUpper();
        //        txtNumeroC.Text = c.sClientNumberAdress;
        //        txtBairroC.Text = c.sClientDistrict.ToUpper();
        //        txtCidadeC.Text = c.sClientCity.ToUpper();
        //        cbxEstate.Text = c.ClientEstate.ToString();
        //        txtNomeContratado.Text = c.sProviderName;
        //        txtCpfCnpjContratado.Text = c.sProviderCpfCnpj;
        //        txtRgContratado.Text = c.sRegistStateRg;
        //        txtCepContratado.Text = c.sProviderCep;
        //        txtEnderecoContratado.Text = c.sProviderAdress;
        //        txtNumeroContratado.Text = c.sProviderNumberAdress;
        //        txtBairroContratado.Text = c.sProviderDistrict;
        //        txtCidadeContratado.Text = c.sProviderCity;
        //        cbxEstateContratado.SelectedIndex = 24;
        //        txtDescription.Text = c.sClientObjectContract;
        //        txtValores.Text = c.dTotalValue.ToString();
        //        txtValores1.Text = c.dTotalValue.ToString();
        //        txtObrigacoesContratante.Text = c.sPaymentForm;
        //        txtObrigacoesContratante1.Text = c.sPaymentForm;
        //        txtPrazoGarantia.Text = c.iWarrantyTime.ToString();
        //        txtPrazo1.Text = c.iDeadline.ToString();
        //        txtPrazo2.Text = c.iDeadline.ToString();
        //        txtCidade.Text = c.sCity;
        //        dtpDataAtual.Text = c.dtContractDate.ToString();
        //    }
        //}

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

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            gravarContrato();
        }
    }
}