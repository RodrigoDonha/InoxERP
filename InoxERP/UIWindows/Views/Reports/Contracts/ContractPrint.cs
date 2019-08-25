using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;


namespace UIWindows.Views.Reports.Contracts
{
    public partial class ContractPrint : Form
    {
        public ContractPrint(string id)
        {
            InitializeComponent();

            if (id == "")
            {
                MessageBox.Show("Você precisa selecionar uma Ordem de Serviço");

                reportViewer1.Dispose();
            }
            else
            {
                searchData(id);
            }
        }

        public void searchData(string id)
        {
            InoxErpContext ctx = new InoxErpContext();
            Entities.Contracts searchContracts = new Entities.Contracts();
            ContractBusiness obj = new ContractBusiness(ctx);

            searchContracts = obj.ReturnByID(id);
            //string pulaLinha = "\r\n";

            string contratanteString = "Nome: " + searchContracts.sClientName +
                                       ", CPF/CNPJ: " + searchContracts.sClientCpfCnpj +
                                       ", RG/Inscr. Est.: " + searchContracts.sClientRg +
                                       ", Endereço: " + searchContracts.sClientAdress + 
                                       " Nº. " + searchContracts.sClientNumberAdress +
                                       ", Bairro: " + searchContracts.sClientDistrict + 
                                       ", Cidade: " + searchContracts.sClientCity + 
                                       "/" + searchContracts.ClientEstate;

            string contratadoString = "Nome: " + searchContracts.sProviderName +
                                      ", CPF/CNPJ: " + searchContracts.sProviderCpfCnpj +
                                      ", Endereço: " + searchContracts.sProviderAdress + 
                                      " Nº. " + searchContracts.sProviderNumberAdress +
                                      ", Bairro: " + searchContracts.sProviderDistrict + 
                                      ", Cidade: " + searchContracts.sProviderCity + 
                                      "/" + searchContracts.ProviderEstate;
            string cnpjProvider = searchContracts.sProviderCpfCnpj;

            string objetoString = searchContracts.sClientObjectContract;
            string valorString = searchContracts.dTotalValue.ToString();
            string formaString = searchContracts.sPaymentForm;
            string execucaoString = searchContracts.iDeadline.ToString(); //deadline = data limite
            string entregaString = searchContracts.iDeadline.ToString();
            string garantiaString = searchContracts.iWarrantyTime.ToString();
            string cidadeString = searchContracts.sCity;
            string dataString = searchContracts.dtContractDate.ToLongDateString();
            string proprietarioString = searchContracts.sProviderName;
            
            var contratante = new ReportParameter();
            var contratado = new ReportParameter();
            var objeto = new ReportParameter();
            var valor = new ReportParameter();
            var forma = new ReportParameter();
            var execucao = new ReportParameter();
            var entrega = new ReportParameter();
            var garantia = new ReportParameter();
            var cidade = new ReportParameter();
            var data = new ReportParameter();
            var proprietario = new ReportParameter();
            var cnpjProviderRodape = new ReportParameter();
            
            contratante.Name = "contratante";
            contratado.Name = "contratado";
            objeto.Name = "objeto";
            valor.Name = "valor";
            forma.Name = "forma";
            execucao.Name = "execucao";
            entrega.Name = "entrega";
            garantia.Name = "garantia";
            cidade.Name = "cidade";
            data.Name = "data";
            proprietario.Name = "proprietario";
            cnpjProviderRodape.Name = "cnpjProvider";
            
            contratante.Values.Add(contratanteString);
            contratado.Values.Add(contratadoString);
            objeto.Values.Add(objetoString);
            valor.Values.Add(valorString);
            forma.Values.Add(formaString);
            execucao.Values.Add(execucaoString);
            entrega.Values.Add(entregaString);
            garantia.Values.Add(garantiaString);
            cidade.Values.Add(cidadeString);
            data.Values.Add(dataString);
            proprietario.Values.Add(proprietarioString);
            cnpjProviderRodape.Values.Add(cnpjProvider);
            
            reportViewer1.LocalReport.SetParameters(contratante);
            reportViewer1.LocalReport.SetParameters(contratado);
            reportViewer1.LocalReport.SetParameters(objeto);
            reportViewer1.LocalReport.SetParameters(valor);
            reportViewer1.LocalReport.SetParameters(forma);
            reportViewer1.LocalReport.SetParameters(execucao);
            reportViewer1.LocalReport.SetParameters(entrega);
            reportViewer1.LocalReport.SetParameters(garantia);
            reportViewer1.LocalReport.SetParameters(cidade);
            reportViewer1.LocalReport.SetParameters(data);
            reportViewer1.LocalReport.SetParameters(proprietario);
            reportViewer1.LocalReport.SetParameters(cnpjProviderRodape);

            reportViewer1.LocalReport.DisplayName = searchContracts.sClientName +
                                                    " - " +
                                                    DateTime.Now.Date.ToShortDateString()
                                                        .Replace("/",
                                                            "-");
            reportViewer1.RefreshReport();
        }

        private void ContractPrint_Load(object sender, EventArgs e)
        {
            this.tb_contractsTableAdapter.Fill(this.fullDataSet.tb_contracts);
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
        }
    }
}
