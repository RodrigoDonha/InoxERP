using System;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;
using UIWindows.Entities.Enum;

namespace UIWindows.Views.ServicesOrders
{
    public partial class ServiceOrdersPrint : Form
    {
        public ServiceOrdersPrint(string id)
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

        private void ServiceOrdersPrint_Load(object sender, EventArgs e)
        {
            this.tb_itemsTableAdapter.Fill(this.fullDataSet.tb_items);
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            //this.reportViewer1.PrinterSettings.DefaultPageSettings.PrinterSettings.DefaultPageSettings.Margins = new Margins(0,0,0,0);
            this.reportViewer1.RefreshReport();
        }

        public void searchData(string id)
        {
            InoxErpContext ctx = new InoxErpContext();

            Budgets_OS searchBudget = new Budgets_OS();
            Budget_OSBusiness obj = new Budget_OSBusiness(ctx);

            Contracts searchContract = new Contracts();
            ContractBusiness objContracts = new ContractBusiness(ctx);


            searchBudget = obj.ReturnByID(id);
            searchContract = objContracts.returnByBudgetOSId(id);

            var sID = new ReportParameter();
            var Cod = new ReportParameter();
            var Name = new ReportParameter();
            var Telephone = new ReportParameter();
            var DateApproved = new ReportParameter();
            var StartPrevision = new ReportParameter();
            var FinalPrevision = new ReportParameter();
            var PrevisionOfExecute = new ReportParameter();
            var Observation = new ReportParameter();
            var PayementForm = new ReportParameter();
            
            sID.Name = "sID";
            Cod.Name = "Cod";
            Name.Name = "Name";
            Telephone.Name = "Telephone";
            DateApproved.Name = "DateServiceOrderApproved";
            StartPrevision.Name = "StartPrevision";
            FinalPrevision.Name = "FinalPrevision";
            PrevisionOfExecute.Name = "PrevisionOfExecute";
            Observation.Name = "Observation";
            PayementForm.Name = "PayementForm";

            DateTime dateApproved = Convert.ToDateTime(searchBudget.dtDateServiceOrderApproved);
            DateTime dateStartPrevision = Convert.ToDateTime(searchBudget.dtStartPrevision);
            DateTime dateFinalPrevision = Convert.ToDateTime(searchBudget.dtFinalPrevision);

            string dateApprovedString = dateApproved.ToShortDateString();
            string dateStartPrevisionString = dateStartPrevision.ToShortDateString();
            string dateFinalPrevisionString = dateFinalPrevision.ToShortDateString();

            sID.Values.Add(searchBudget.sID);
            Cod.Values.Add(searchBudget.iCod.ToString());
            DateApproved.Values.Add(dateApprovedString); //ok
            Name.Values.Add(searchBudget.sName);
            Telephone.Values.Add(searchBudget.sTelephone);

            PrevisionOfExecute.Values.Add(searchBudget.iPrevisionOfExecute.ToString());
            StartPrevision.Values.Add(dateStartPrevisionString);
            FinalPrevision.Values.Add(dateFinalPrevisionString);
            Observation.Values.Add(searchBudget.sObservation);

            string payement = "";

            if (searchBudget.bContractRegistred)
            {
                payement = searchContract.sPaymentForm;
                PayementForm.Values.Add(payement);
            }
            else
            {
                payement = paymentForm(searchBudget.PaymentMethods) + " - Parcelamento: " + searchBudget.iPaymentInstallments;
                PayementForm.Values.Add(payement);
            }
            
            string paymentForm(PaymentMethods payment)
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

            reportViewer1.LocalReport.SetParameters(sID);
            reportViewer1.LocalReport.SetParameters(Cod);
            reportViewer1.LocalReport.SetParameters(DateApproved);
            reportViewer1.LocalReport.SetParameters(Name);
            reportViewer1.LocalReport.SetParameters(Telephone);
            reportViewer1.LocalReport.SetParameters(PrevisionOfExecute);
            reportViewer1.LocalReport.SetParameters(StartPrevision);
            reportViewer1.LocalReport.SetParameters(FinalPrevision);
            reportViewer1.LocalReport.SetParameters(Observation);
            reportViewer1.LocalReport.SetParameters(PayementForm);

            reportViewer1.RefreshReport();
        }
    }
}
