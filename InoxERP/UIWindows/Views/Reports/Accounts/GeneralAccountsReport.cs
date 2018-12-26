﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;

namespace UIWindows.Views.Reports.Accounts
{
    public partial class GeneralAccountsReport : Form
    {
        string typeReport, startDateReport, endDateReport, typeLaunchReport;

        public GeneralAccountsReport(string type, string startDate, string endDate, string typeLaunch)
        {
            typeReport = type;
            startDateReport = startDate;
            endDateReport = endDate;
            typeLaunchReport = typeLaunch;

            InitializeComponent();

            searchData();
        }

        private void GeneralAccountsReport_Load(object sender, EventArgs e)
        {
            this.tb_accountsToPayTableAdapter.Fill(this.fullDataSet.tb_accountsToPay);
            this.tb_accountsToReceiveTableAdapter.Fill(this.fullDataSet.tb_accountsToReceive);

            // hook
            this.reportViewer1.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
            
            this.reportViewer1.RefreshReport();
        }

        // alimenta dados dos pagamentos parciais
        void LocalReport_SubreportProcessing(object sender, Microsoft.Reporting.WinForms.SubreportProcessingEventArgs e)
        {
            InoxErpContext ctx = new InoxErpContext();

            //ParcialPay
            ParcialToPayBusiness objPay = new ParcialToPayBusiness(ctx);
            List<ParcialPay> listPay = new List<ParcialPay>();
            listPay =  objPay.ReturnAll().ToList();
            DataTable pListPay = new DataTable();
            pListPay = ConvertToDataTable(listPay);
            e.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("GeneralParcialPay", (DataTable) pListPay));

            // ParcialReceive
            ParcialToReceiveBusiness objReceive = new ParcialToReceiveBusiness(ctx);
            List<ParcialReceive> listReceive = new List<ParcialReceive>();
            listReceive = objReceive.ReturnAll().ToList();
            DataTable pListReceive = new DataTable();
            pListReceive = ConvertToDataTable(listReceive);
            e.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("ParcialReceiveDataSet", (DataTable) pListReceive));
        }

        // converter lista em datatable
        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
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