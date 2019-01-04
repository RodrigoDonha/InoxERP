﻿using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace UIWindows.Views.Reports.Accounts
{
    public partial class ParcialReceiveReport : Form
    {
        string typeReport, startDateReport, endDateReport, typeLaunchReport;

        public ParcialReceiveReport(string type, string startDate, string endDate, string typeLaunch)
        {
            typeReport = type;
            startDateReport = startDate;
            endDateReport = endDate;
            typeLaunchReport = typeLaunch;

            InitializeComponent();

            searchData();
        }

        private void ParcialReceiveReport_Load(object sender, EventArgs e)
        {
            this.tb_accountsToReceiveTableAdapter.Fill(this.fullDataSet.tb_accountsToReceive);
            this.reportViewer1.RefreshReport();
        }

        public void searchData()
        {
            var type = new ReportParameter();
            var issueDate = new ReportParameter();
            var startDate = new ReportParameter();
            var endDate = new ReportParameter();
            var typeLaunch = new ReportParameter();
            var startDateString = new ReportParameter();
            var endDateString = new ReportParameter();

            type.Name = "type";
            issueDate.Name = "issueDate";
            startDate.Name = "startDate";
            endDate.Name = "endDate";
            typeLaunch.Name = "typeLaunch";
            startDateString.Name = "startDateString";
            endDateString.Name = "endDateString";

            type.Values.Add(typeReport.ToString());
            issueDate.Values.Add(DateTime.Today.Date.ToShortDateString());
            startDate.Values.Add(startDateReport);
            endDate.Values.Add(endDateReport);
            typeLaunch.Values.Add(typeLaunchReport.ToString());
            startDateString.Values.Add(startDateReport);
            endDateString.Values.Add(endDateReport);

            reportViewer1.LocalReport.SetParameters(type);
            reportViewer1.LocalReport.SetParameters(issueDate);
            reportViewer1.LocalReport.SetParameters(startDate);
            reportViewer1.LocalReport.SetParameters(endDate);
            reportViewer1.LocalReport.SetParameters(typeLaunch);
            reportViewer1.LocalReport.SetParameters(startDateString);
            reportViewer1.LocalReport.SetParameters(endDateString);

            reportViewer1.RefreshReport();
        }
    }
}