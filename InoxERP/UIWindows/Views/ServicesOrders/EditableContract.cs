using System;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Threading;
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

        // verificar se salvou alterações ou não ao sair
        private int confirmaAlteracoes;
        
        public frmEditableContract(string id, string type)
        {
            getId = id;
            
            InitializeComponent();

            if (type == "Budget")
            {
                frmSelectProvider slcProv = new frmSelectProvider("frmEditableContract");
                slcProv.ShowDialog();
                hrd = slcProv.Returns();
                getData();
                fillContractOfObject();
            }

            if (type == "Contract")
            {
                getDataEditableObject();
                fillContractEditable();
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

            description += "ITEMS:\r\n\r\n";
            foreach (var line in searchBudget.Items.ToList()) // math.round(var,2)
            {
                description += line.dAmount + " - " + line.sDescription + " - " + line.dPrice + " - " + line.dTotal + " \r\n ";
            }
            description += "\r\nDESCRIÇÃO DO SERVIÇO:\r\n" + "\r\n" + searchBudget.sObservation;

            valores = searchBudget.dTotal.ToString();
            
            obligations = "Forma de pagamento: " + paymentForm(searchBudget.PaymentMethods) + " - Parcelamento: " + searchBudget.iPaymentInstallments;
            
            warrant = searchBudget.iWarrantyTime.ToString();

            prize = Convert.ToString(searchBudget.iPrevisionOfExecute);
            
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
            rtfContract.Text = contractStandard;
        }

        private void getDataEditableObject()
        {
            InoxErpContext ctx = new InoxErpContext();
            Entities.Contracts ctrNew = new Contracts();
            ContractBusiness objCtr = new ContractBusiness(ctx);

            ctrNew = objCtr.returnById(getId);
            contract = null;
            contract = ctrNew;
        }

        private void fillContractEditable()
        {
            int lengthDate = contract.dtContractDate.ToLongDateString().Length;
            lengthDate = lengthDate + 2;
            contract.sEditableContract = contract.sEditableContract.Remove(contract.sEditableContract.Length - lengthDate);
            confirmaAlteracoes = contract.sEditableContract.Length;

            dtpDate.Text = contract.dtContractDate.ToString();
            
            rtfContract.Text = "";
            rtfContract.Text = contract.sEditableContract;
            
            MessageBox.Show("Cuidado ao alterar dados do contrato, pois não será alterado no Orçamento e Ordem de Serviço, obrigando-o a Alterar esses dados lá também.");
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

        public void gravarContrato(string type)
        {
            bool validation;
            if (type == "Ao Fechar")
            {
                validation = true;
            }
            else
            {
                if (messageYesNo("Save") == DialogResult.Yes)
                {
                    validation = true;
                }
                else
                {
                    validation = false;
                }
            }

            if (validation)
            {
                validation = false;

                // Alterar
                if (getId == contract.sID) // implementar depois.
                {
                    InoxErpContext ctxAlter = new InoxErpContext();
                    ContractBusiness objAlter = new ContractBusiness(ctxAlter);
                    Contracts contractAlter = new Contracts();

                    contractAlter = objAlter.ReturnByID(getId);
                    contractAlter.sID = getId;

                    // data contract general
                    contractAlter.dtContractDate = dtpDate.Value;
                    contractAlter.dtStartExecution = dtpDate.Value;
                    contractAlter.sClientObjectContract = ".";
                    contractAlter.dTotalValue = Convert.ToDecimal(valores);
                    contractAlter.sPaymentForm = obligations;
                    contractAlter.iDeadline = Convert.ToInt16(prize);
                    contractAlter.iWarrantyTime = Convert.ToInt32(warrant);
                    //contractAlter.sCity = cidadeContratado;
                    
                    contractAlter.sEditableContract = rtfContract.Text + ", " + dtpDate.Text;
                    contract.bEditableContract = true;

                    getId = "";

                    //salva
                    objAlter.Update(contractAlter);

                    //verifica se o orçamento foi salvo com sucesso
                    var okAlter = objAlter.Search.FirstOrDefault(b => b.sID == contractAlter.sID);

                    if (okAlter != null)
                    {
                        MessageBox.Show("Contrato Alterado com Sucesso !!!");

                        this.DestroyHandle();
                        this.Dispose();

                        // impressao
                        new EditableContractPrint(contractAlter.sID).Show();
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
                    contract.bEditableContract = true;

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
            gravarContrato("");
        }

        private void imprimirToolStripButton_Click(object sender, EventArgs e)
        {
            new EditableContractPrint(getId).Show();
        }

        private void copiarToolStripButton_Click(object sender, EventArgs e)
        {
            if (rtfContract.SelectedText != "")
            {
                SendKeys.Send("^(C)");
            }
        }

        private void colarToolStripButton_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^(V)");
        }

        private void recortarToolStripButton_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^(X)");
        }

        private void frmEditableContract_FormClosing(object sender, FormClosingEventArgs e)
        {
            int length = rtfContract.TextLength;
            if (!confirmaAlteracoes.Equals(length))
            {
                DialogResult dr = MessageBox.Show("Deseja Salvar as Alterações"
                    , "Salvar e Sair"
                    , MessageBoxButtons.YesNoCancel
                    , MessageBoxIcon.Warning);

                
                if (dr == DialogResult.Yes)
                {
                    gravarContrato("Ao Fechar");
                }
                else if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (dr == DialogResult.No)
                {
                    
                }
            }
        }
    }
}