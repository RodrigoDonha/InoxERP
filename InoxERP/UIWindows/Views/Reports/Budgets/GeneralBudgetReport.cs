using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace UIWindows.Views.Reports.Budgets
{
    public partial class GeneralBudgetReport : Form
    {
        string typeReport, startDateReport, endDateReport, situationReport;
        
        public GeneralBudgetReport(string type, string startDate, string endDate, string situation)
        {
            typeReport = type;
            startDateReport = startDate;
            endDateReport = endDate;
            situationReport = situation;

            InitializeComponent();

            searchData();
        }

        private void GeneralBudgetReport_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fullDataSet.tb_items'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_budgets_osTableAdapter.Fill(this.fullDataSet.tb_budgets_os);
            this.reportViewer1.RefreshReport();
        }

        public void searchData()
        {
            var type = new ReportParameter();
            var issueDate = new ReportParameter();
            var startDate = new ReportParameter();
            var endDate = new ReportParameter();
            var situation = new ReportParameter();

            type.Name = "type";
            issueDate.Name = "issueDate";
            startDate.Name = "startDate";
            endDate.Name = "endDate";
            situation.Name = "situation";

            type.Values.Add(typeReport);
            issueDate.Values.Add(DateTime.Today.Date.ToShortDateString());
            startDate.Values.Add(startDateReport);
            endDate.Values.Add(endDateReport);
            situation.Values.Add(situationReport.ToString());
            
            reportViewer1.LocalReport.SetParameters(type);
            reportViewer1.LocalReport.SetParameters(issueDate);
            reportViewer1.LocalReport.SetParameters(startDate);
            reportViewer1.LocalReport.SetParameters(endDate);
            reportViewer1.LocalReport.SetParameters(situation);

            reportViewer1.RefreshReport();
        }
    }
}
