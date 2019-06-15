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
    public partial class ContractEmptyPrint : Form
    {
        public ContractEmptyPrint(string provider, string cnpj)
        {
            InitializeComponent();
            searchData(provider, cnpj);
        }

        public void searchData(string provider, string cnpj)
        {
            
            var contratado = new ReportParameter();
            var cnpjProviderRodape = new ReportParameter();

            contratado.Name = "contratado";
            cnpjProviderRodape.Name = "cnpjProvider";

            contratado.Values.Add(provider);
            cnpjProviderRodape.Values.Add(cnpj);

            reportViewer1.LocalReport.SetParameters(contratado);
            reportViewer1.LocalReport.SetParameters(cnpjProviderRodape);

            reportViewer1.LocalReport.DisplayName = "ContratoEmBranco" +
                                                    " - " +
                                                    DateTime.Now.Date.ToShortDateString()
                                                        .Replace("/",
                                                            "-");

            reportViewer1.RefreshReport();
        }

        private void ContractEmptyPrint_Load(object sender, EventArgs e)
        {
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            //this.reportViewer1.RefreshReport();
        }
    }
}
