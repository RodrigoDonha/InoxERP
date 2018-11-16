using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;

namespace UIWindows.Views.ServicesOrders
{
    public partial class ServiceOrdersPrint : Form
    {
        private string idOS;
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
            this.reportViewer1.RefreshReport();
        }

        public void searchData(string id)
        {
            InoxErpContext ctx = new InoxErpContext();

            Budgets_OS searchBudget = new Budgets_OS();
            Budget_OSBusiness obj = new Budget_OSBusiness(ctx);

            searchBudget = obj.ReturnByID(id);

            var sID = new ReportParameter();
            var Cod = new ReportParameter();
            var Name = new ReportParameter();
            var Telephone = new ReportParameter();
            var DateApproved = new ReportParameter();
            var StartPrevision = new ReportParameter();
            var FinalPrevision = new ReportParameter();
            var PrevisionOfExecute = new ReportParameter();
            var Observation = new ReportParameter();
            
            sID.Name = "sID";
            Cod.Name = "Cod";
            Name.Name = "Name";
            Telephone.Name = "Telephone";
            DateApproved.Name = "DateServiceOrderApproved";
            StartPrevision.Name = "StartPrevision";
            FinalPrevision.Name = "FinalPrevision";
            PrevisionOfExecute.Name = "PrevisionOfExecute";
            Observation.Name = "Observation";

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
            
            reportViewer1.LocalReport.SetParameters(sID);
            reportViewer1.LocalReport.SetParameters(Cod);
            reportViewer1.LocalReport.SetParameters(DateApproved);
            reportViewer1.LocalReport.SetParameters(Name);
            reportViewer1.LocalReport.SetParameters(Telephone);
            reportViewer1.LocalReport.SetParameters(PrevisionOfExecute);
            reportViewer1.LocalReport.SetParameters(StartPrevision);
            reportViewer1.LocalReport.SetParameters(FinalPrevision);
            reportViewer1.LocalReport.SetParameters(Observation);

            reportViewer1.RefreshReport();
        }
    }
}
