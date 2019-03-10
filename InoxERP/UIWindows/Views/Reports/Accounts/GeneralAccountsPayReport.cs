using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace UIWindows.Views.Reports.Accounts
{
    public partial class GeneralAccountsPayReport : Form
    {
        string typeReport, startDateReport, endDateReport, typeLaunchReport;

        public GeneralAccountsPayReport(string type, string startDate, string endDate, string typeLaunch)
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
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            // SUB REPORT EXAMPLE
            //// hook
            //this.reportViewer1.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;

            this.reportViewer1.RefreshReport();
        }

        // SUB REPORT EXAMPLE
        // alimenta dados dos pagamentos parciais
        //void LocalReport_SubreportProcessing(object sender, Microsoft.Reporting.WinForms.SubreportProcessingEventArgs e)
        //{
        //    InoxErpContext ctx = new InoxErpContext();

        //    //ParcialPay
        //    ParcialToPayBusiness objPay = new ParcialToPayBusiness(ctx);
        //    List<ParcialPay> listPay = new List<ParcialPay>();
        //    listPay =  objPay.ReturnAll().ToList();
        //    DataTable pListPay = new DataTable();
        //    pListPay = ConvertToDataTable(listPay);
        //    e.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("GeneralParcialPay", (DataTable) pListPay));

        //    // ParcialReceive
        //    ParcialToReceiveBusiness objReceive = new ParcialToReceiveBusiness(ctx);
        //    List<ParcialReceive> listReceive = new List<ParcialReceive>();
        //    listReceive = objReceive.ReturnAll().ToList();
        //    DataTable pListReceive = new DataTable();
        //    pListReceive = ConvertToDataTable(listReceive);
        //    e.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("ParcialReceiveDataSet", (DataTable) pListReceive));
        //}

        //// converter lista em datatable
        //public DataTable ConvertToDataTable<T>(IList<T> data)
        //{
        //    PropertyDescriptorCollection properties =
        //        TypeDescriptor.GetProperties(typeof(T));
        //    DataTable table = new DataTable();
        //    foreach (PropertyDescriptor prop in properties)
        //        table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
        //    foreach (T item in data)
        //    {
        //        DataRow row = table.NewRow();
        //        foreach (PropertyDescriptor prop in properties)
        //            row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
        //        table.Rows.Add(row);
        //    }
        //    return table;
        //}

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

            DateTime start = Convert.ToDateTime(startDateReport).AddDays(-1);
            DateTime end = Convert.ToDateTime(endDateReport).AddDays(+1);

            type.Values.Add(typeReport.ToString());
            issueDate.Values.Add(DateTime.Today.Date.ToShortDateString());
            startDate.Values.Add(start.ToString());
            endDate.Values.Add(end.ToString());
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

            reportViewer1.LocalReport.DisplayName = "Relatorio de " +
                                                    typeReport +
                                                    " - " +
                                                    DateTime.Now.Date.ToShortDateString()
                                                        .Replace("/",
                                                            "-");

            reportViewer1.RefreshReport();
        }
    }
}
