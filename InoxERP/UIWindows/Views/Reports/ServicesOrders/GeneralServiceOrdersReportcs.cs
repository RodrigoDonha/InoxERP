﻿using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace UIWindows.Views.Reports.ServicesOrders
{
    public partial class GeneralServiceOrdersReportcs : Form
    {
        string typeReport, startDateReport, endDateReport, situationReport;

        public GeneralServiceOrdersReportcs(string type, string startDate, string endDate, string situation)
        {
            typeReport = type;
            startDateReport = startDate;
            endDateReport = endDate;
            situationReport = situation;

            InitializeComponent();            

            searchData();
        }

        private void GeneralServiceOrdersReportcs_Load(object sender, EventArgs e)
        {

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
            var startDateString = new ReportParameter();
            var endDateString = new ReportParameter();

            type.Name = "type";
            issueDate.Name = "issueDate";
            startDate.Name = "startDate";
            endDate.Name = "endDate";
            situation.Name = "situation";
            startDateString.Name = "startDateString";
            endDateString.Name = "endDateString";

            type.Values.Add(typeReport.ToString());
            issueDate.Values.Add(DateTime.Today.Date.ToShortDateString());
            startDate.Values.Add(startDateReport);
            endDate.Values.Add(endDateReport);
            situation.Values.Add(situationReport.ToString());
            startDateString.Values.Add(startDateReport);
            endDateString.Values.Add(endDateReport);

            reportViewer1.LocalReport.SetParameters(type);
            reportViewer1.LocalReport.SetParameters(issueDate);
            reportViewer1.LocalReport.SetParameters(startDate);
            reportViewer1.LocalReport.SetParameters(endDate);
            reportViewer1.LocalReport.SetParameters(situation);
            reportViewer1.LocalReport.SetParameters(startDateString);
            reportViewer1.LocalReport.SetParameters(endDateString);

            reportViewer1.RefreshReport();
        }
    }
}