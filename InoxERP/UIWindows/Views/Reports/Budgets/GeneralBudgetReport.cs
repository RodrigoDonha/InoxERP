using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;

namespace UIWindows.Views.Reports.Budgets
{
    public partial class GeneralBudgetReport : Form
    {
        string typeReport;
        DateTime starDateReport;
        DateTime endDateReport;

        public GeneralBudgetReport(string type, string startDate, string endDate)
        {
            typeReport = type;
            starDateReport = Convert.ToDateTime(startDate).Date;
            endDateReport = Convert.ToDateTime(endDate).Date;

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

            type.Name = "type";
            issueDate.Name = "issueDate";
            startDate.Name = "startDate";
            endDate.Name = "endDate";

            type.Values.Add(typeReport);
            issueDate.Values.Add(DateTime.Today.Date.ToShortDateString());
            startDate.Values.Add(starDateReport.Date.ToShortDateString());
            endDate.Values.Add(endDateReport.Date.ToShortDateString());
            
            reportViewer1.LocalReport.SetParameters(type);
            reportViewer1.LocalReport.SetParameters(issueDate);
            reportViewer1.LocalReport.SetParameters(startDate);
            reportViewer1.LocalReport.SetParameters(endDate);

            reportViewer1.RefreshReport();
        }
    }
}
