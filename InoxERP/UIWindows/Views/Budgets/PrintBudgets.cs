using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;

namespace UIWindows.Views.Budgets
{
    public partial class frmPrintBudgets : Form
    {
        static InoxErpContext ctx = new InoxErpContext();
        Budgets_OS searchBudget = new Budgets_OS();
        Budget_OSBusiness obj = new Budget_OSBusiness(ctx);

        public frmPrintBudgets(string id)
        {
            InitializeComponent();
            searchData(id);
        }

        private void frmPrintBudgets_Load(object sender, EventArgs e)
        {
            this.BudgetsPrint.RefreshReport();            
        }

        public void searchData(string id)
        {
            searchBudget = obj.ReturnByID(id);

            var BudgetID = new Microsoft.Reporting.WinForms.ReportParameter();
            var Name = new Microsoft.Reporting.WinForms.ReportParameter();
            var Adress = new Microsoft.Reporting.WinForms.ReportParameter();
            var Contact = new Microsoft.Reporting.WinForms.ReportParameter();
            var Date = new Microsoft.Reporting.WinForms.ReportParameter();
            var Type = new Microsoft.Reporting.WinForms.ReportParameter();
            var Occupation = new Microsoft.Reporting.WinForms.ReportParameter();
            var PaymentForm = new Microsoft.Reporting.WinForms.ReportParameter();
            var PaymentInstalment = new Microsoft.Reporting.WinForms.ReportParameter();
            var InterestRate = new Microsoft.Reporting.WinForms.ReportParameter();
            var PercentDiscount = new Microsoft.Reporting.WinForms.ReportParameter();
            var TotalValue = new Microsoft.Reporting.WinForms.ReportParameter();
            var StartPrevision = new Microsoft.Reporting.WinForms.ReportParameter();
            var FinalPrevision = new Microsoft.Reporting.WinForms.ReportParameter();
            var PrevisionOfExecute = new Microsoft.Reporting.WinForms.ReportParameter();
            var DeliveryPrevision = new Microsoft.Reporting.WinForms.ReportParameter();
            var WarrantyTime = new Microsoft.Reporting.WinForms.ReportParameter();
            var ExpirationDate = new Microsoft.Reporting.WinForms.ReportParameter();

            BudgetID.Name = "BudgetID";
            Name.Name = "Name";
            Adress.Name = "Adress";
            Contact.Name = "Contact";
            Date.Name = "Date";
            Type.Name = "Type";
            Occupation.Name = "Office";
            PaymentForm.Name = "PaymentForm";
            PaymentInstalment.Name = "PaymentInstalment";
            InterestRate.Name = "InterestRate";
            PercentDiscount.Name = "PercentDiscount";
            TotalValue.Name = "TotalValue";
            StartPrevision.Name = "StartPrevision";
            FinalPrevision.Name = "FinalPrevision";
            PrevisionOfExecute.Name = "PrevisionOfExecute";
            DeliveryPrevision.Name = "DeliveryPrevision";
            WarrantyTime.Name = "WarrantyTime";
            ExpirationDate.Name = "ExpirationDate";

            BudgetID.Values.Add(searchBudget.sID);
            Date.Values.Add(searchBudget.dtDate.ToShortDateString());
            Name.Values.Add(searchBudget.sName);
            Contact.Values.Add(searchBudget.sTelephone);
            TotalValue.Values.Add(searchBudget.dTotal.ToString());
            Adress.Values.Add(searchBudget.sAdress);
            Occupation.Values.Add(searchBudget.sOccupation);
            Type.Values.Add(searchBudget.ClientType.ToString());
            PaymentForm.Values.Add(searchBudget.bPaymentToMatch.ToString());
            PercentDiscount.Values.Add(searchBudget.dPercentDiscount.ToString());
            PaymentInstalment.Values.Add(searchBudget.iPaymentInstallments.ToString());
            InterestRate.Values.Add(searchBudget.dWithInterest.ToString());         
            PrevisionOfExecute.Values.Add(searchBudget.iPrevisionOfExecute.ToString());
            StartPrevision.Values.Add(searchBudget.dtStartPrevision.ToShortDateString());
            FinalPrevision.Values.Add(searchBudget.dtFinalPrevision.ToShortDateString());
            WarrantyTime.Values.Add(searchBudget.iWarrantyTime.ToString());
            ExpirationDate.Values.Add(searchBudget.dtBudgetExpirationDate.ToShortDateString());
            //DeliveryPrevision não tem essa previsão no orçamento, fica com a data de finalização
            DeliveryPrevision.Values.Add(searchBudget.dtFinalPrevision.ToShortDateString());

            
            BudgetsPrint.LocalReport.SetParameters(BudgetID);
            BudgetsPrint.LocalReport.SetParameters(Date);
            BudgetsPrint.LocalReport.SetParameters(Name);
            BudgetsPrint.LocalReport.SetParameters(Contact);
            BudgetsPrint.LocalReport.SetParameters(TotalValue);
            BudgetsPrint.LocalReport.SetParameters(Adress);

            // não está funfando esse atributo, depois vejo
            //BudgetsPrint.LocalReport.SetParameters(Occupation);

            BudgetsPrint.LocalReport.SetParameters(Type);
            BudgetsPrint.LocalReport.SetParameters(PaymentForm);
            BudgetsPrint.LocalReport.SetParameters(PercentDiscount);

            // não está funfando esse outro atributo também, depois vejo junto com o outro.
            //BudgetsPrint.LocalReport.SetParameters(PaymentInstalment);

            BudgetsPrint.LocalReport.SetParameters(InterestRate);
            BudgetsPrint.LocalReport.SetParameters(PrevisionOfExecute);
            BudgetsPrint.LocalReport.SetParameters(StartPrevision);
            BudgetsPrint.LocalReport.SetParameters(FinalPrevision);
            BudgetsPrint.LocalReport.SetParameters(WarrantyTime);
            BudgetsPrint.LocalReport.SetParameters(ExpirationDate);
            BudgetsPrint.LocalReport.SetParameters(DeliveryPrevision);

            BudgetsPrint.RefreshReport();
        }
    }
}
