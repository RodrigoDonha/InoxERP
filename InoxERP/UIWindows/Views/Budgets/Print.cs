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
    public partial class Print : Form
    {
        static InoxErpContext ctx = new InoxErpContext();
        Budgets_OS searchBudget = new Budgets_OS();
        Budget_OSBusiness obj = new Budget_OSBusiness(ctx);

        public Print(string id)
        {
            InitializeComponent();
            if(id == "")
            {
                MessageBox.Show("Você precisa selecionar um orçamento");
                rptPrint.Dispose();
            }
            else
            {
                searchData(id);
            }            
        }

        private void Print_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'conjDadosTotais.tb_items'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_itemsTableAdapter.Fill(this.conjDadosTotais.tb_items);

            this.rptPrint.RefreshReport();
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


            rptPrint.LocalReport.SetParameters(BudgetID);
            rptPrint.LocalReport.SetParameters(Date);
            rptPrint.LocalReport.SetParameters(Name);
            rptPrint.LocalReport.SetParameters(Contact);
            rptPrint.LocalReport.SetParameters(TotalValue);
            rptPrint.LocalReport.SetParameters(Adress);

            // não está funfando esse atributo, depois vejo
            //rptPrint.LocalReport.SetParameters(Occupation);

            rptPrint.LocalReport.SetParameters(Type);
            rptPrint.LocalReport.SetParameters(PaymentForm);
            rptPrint.LocalReport.SetParameters(PercentDiscount);

            // não está funfando esse outro atributo também, depois vejo junto com o outro.
            //rptPrint.LocalReport.SetParameters(PaymentInstalment);

            rptPrint.LocalReport.SetParameters(InterestRate);
            rptPrint.LocalReport.SetParameters(PrevisionOfExecute);
            rptPrint.LocalReport.SetParameters(StartPrevision);
            rptPrint.LocalReport.SetParameters(FinalPrevision);
            rptPrint.LocalReport.SetParameters(WarrantyTime);
            rptPrint.LocalReport.SetParameters(ExpirationDate);
            rptPrint.LocalReport.SetParameters(DeliveryPrevision);

            rptPrint.RefreshReport();
        }
    }
}