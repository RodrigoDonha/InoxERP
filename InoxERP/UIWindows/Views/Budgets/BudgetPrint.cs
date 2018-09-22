﻿using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;

namespace UIWindows.Views.Budgets
{
    public partial class BudgetPrint : Form
    {
        static InoxErpContext ctx = new InoxErpContext();
        Budgets_OS searchBudget = new Budgets_OS();
        Budget_OSBusiness obj = new Budget_OSBusiness(ctx);

        public BudgetPrint(string id)
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
            this.rptPrint.RefreshReport();
        }

        public void searchData(string id)
        {
            searchBudget = obj.ReturnByID(id);

            var BudgetID = new ReportParameter();
            var Cod = new ReportParameter();
            var Name = new ReportParameter();
            var Adress = new ReportParameter();
            var Contact = new ReportParameter();
            var Date = new ReportParameter();
            var Type = new ReportParameter();
            var Occupation = new ReportParameter();
            var PaymentForm = new ReportParameter();
            var PaymentInstalments = new ReportParameter();
            var InterestRate = new ReportParameter();
            var DiscountValues = new ReportParameter();
            var TotalValue = new ReportParameter();
            var StartPrevision = new ReportParameter();
            var FinalPrevision = new ReportParameter();
            var PrevisionOfExecute = new ReportParameter();
            var DeliveryPrevision = new ReportParameter();
            var WarrantyTime = new ReportParameter();
            var ExpirationDate = new ReportParameter();
            var Observation = new ReportParameter();
            var ColunaValorTotal = new ReportParameter();

            BudgetID.Name = "BudgetID";
            Cod.Name = "Cod";
            Name.Name = "Name";
            Adress.Name = "Adress";
            Contact.Name = "Contact";
            Date.Name = "Date";
            Type.Name = "Type";
            Occupation.Name = "Occupation";
            PaymentForm.Name = "PaymentForm";
            PaymentInstalments.Name = "PaymentInstalments";
            InterestRate.Name = "InterestRate";
            DiscountValues.Name = "DiscountValues";
            TotalValue.Name = "TotalValue";
            StartPrevision.Name = "StartPrevision";
            FinalPrevision.Name = "FinalPrevision";
            PrevisionOfExecute.Name = "PrevisionOfExecute";
            DeliveryPrevision.Name = "DeliveryPrevision";
            WarrantyTime.Name = "WarrantyTime";
            ExpirationDate.Name = "ExpirationDate";
            Observation.Name = "Observation";
            ColunaValorTotal.Name = "ColunaValorTotal";

            BudgetID.Values.Add(searchBudget.sID);
            Cod.Values.Add(searchBudget.iCod.ToString());
            Date.Values.Add(searchBudget.dtDate.ToShortDateString());
            Name.Values.Add(searchBudget.sName);
            Contact.Values.Add(searchBudget.sTelephone);
            TotalValue.Values.Add(Convert.ToString(searchBudget.dTotal)); // dTotal convertido para ToString na tentativa de corrigir bug do valor
            Adress.Values.Add(searchBudget.sAdress);
            Occupation.Values.Add(searchBudget.sOccupation);
            Type.Values.Add(searchBudget.ClientType.ToString());
            PaymentForm.Values.Add(searchBudget.PaymentMethods.ToString());

            // calcula o valor do desconto pela porcentagem
            decimal value = Convert.ToDecimal(searchBudget.dTotal);
            decimal discount = Convert.ToDecimal(searchBudget.dPercentDiscount);
            decimal revert = value + discount;
            decimal Result =  (revert * discount)  / 100;

            DiscountValues.Values.Add(Convert.ToString(Result));
            PaymentInstalments.Values.Add(searchBudget.iPaymentInstallments.ToString());
            InterestRate.Values.Add(searchBudget.dWithInterest.ToString());
            PrevisionOfExecute.Values.Add(searchBudget.iPrevisionOfExecute.ToString());
            StartPrevision.Values.Add(searchBudget.dtStartPrevision.ToShortDateString());
            FinalPrevision.Values.Add(searchBudget.dtFinalPrevision.ToShortDateString());
            WarrantyTime.Values.Add(searchBudget.iWarrantyTime.ToString());
            ExpirationDate.Values.Add(searchBudget.dtBudgetExpirationDate.ToShortDateString());
            //DeliveryPrevision não tem essa previsão no orçamento, fica com a data de finalização
            DeliveryPrevision.Values.Add(searchBudget.dtFinalPrevision.ToShortDateString());
            Observation.Values.Add(searchBudget.sObservation);
            rptPrint.LocalReport.SetParameters(BudgetID);
            rptPrint.LocalReport.SetParameters(Cod);
            rptPrint.LocalReport.SetParameters(Date);
            rptPrint.LocalReport.SetParameters(Name);
            rptPrint.LocalReport.SetParameters(Contact);
            rptPrint.LocalReport.SetParameters(TotalValue);
            rptPrint.LocalReport.SetParameters(Adress);
            
            if (Occupation.Values.Equals(""))
            {
                Occupation.Values.Clear();
                Occupation.Values.Add("");
            }
            else
            {
                Occupation.Values.Clear();
                Occupation.Values.Add(" / " + searchBudget.sOccupation.ToString());
            }
            rptPrint.LocalReport.SetParameters(Occupation);
            rptPrint.LocalReport.SetParameters(Type);

            switch (searchBudget.PaymentMethods.ToString())
            {
                case "toMatch":
                    PaymentForm.Values.Clear();
                    PaymentForm.Values.Add("A Combinar");
                    break;
                case "cheque":
                    PaymentForm.Values.Clear();
                    PaymentForm.Values.Add("Cheque");
                    break;
                case "money":
                    PaymentForm.Values.Clear();
                    PaymentForm.Values.Add("Dinheiro");
                    break;
                case "chequeMoney":
                    PaymentForm.Values.Clear();
                    PaymentForm.Values.Add("Cheque e Dinheiro");
                    break;
            }
            
            rptPrint.LocalReport.SetParameters(PaymentForm);
            rptPrint.LocalReport.SetParameters(DiscountValues);
            rptPrint.LocalReport.SetParameters(PaymentInstalments);
            rptPrint.LocalReport.SetParameters(InterestRate);
            rptPrint.LocalReport.SetParameters(PrevisionOfExecute);
            rptPrint.LocalReport.SetParameters(StartPrevision);
            rptPrint.LocalReport.SetParameters(FinalPrevision);
            rptPrint.LocalReport.SetParameters(WarrantyTime);
            rptPrint.LocalReport.SetParameters(ExpirationDate);
            rptPrint.LocalReport.SetParameters(DeliveryPrevision);
            rptPrint.LocalReport.SetParameters(Observation);

            rptPrint.RefreshReport();
        }
    }
}