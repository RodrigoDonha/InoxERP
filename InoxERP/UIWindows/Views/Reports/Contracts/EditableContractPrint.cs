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
    public partial class EditableContractPrint : Form
    {
        public EditableContractPrint(string id)
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

            string bodyText = searchContracts.sEditableContract;
            string cnpjProvider = searchContracts.sProviderCpfCnpj;

            var body = new ReportParameter();
            var cnpjProviderFooter = new ReportParameter();

            body.Name = "body";
            cnpjProviderFooter.Name = "cnpjProviderFooter";

            body.Values.Add(bodyText);
            cnpjProviderFooter.Values.Add(cnpjProvider);

            reportViewer1.LocalReport.SetParameters(body);
            reportViewer1.LocalReport.SetParameters(cnpjProviderFooter);

            reportViewer1.LocalReport.DisplayName = searchContracts.sClientName +
                                                    " - " +
                                                    DateTime.Now.Date.ToShortDateString()
                                                        .Replace("/",
                                                            "-");

            reportViewer1.RefreshReport();
        }

        private void EditableContractPrint_Load(object sender, EventArgs e)
        {

            this.tb_contractsTableAdapter.Fill(this.fullDataSet.tb_contracts);
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
        }
    }
}
