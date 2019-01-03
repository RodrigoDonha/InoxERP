namespace UIWindows.Views.Reports.Accounts
{
    partial class GeneralAccountsPayReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fullDataSet = new UIWindows.FullDataSet();
            this.tb_accountsToPayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_accountsToPayTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_accountsToPayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_accountsToPayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AccountsToPay";
            reportDataSource1.Value = this.tb_accountsToPayBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UIWindows.Business.Reports.Accounts.GeneralAccounts.GeneralAccountsPay.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(632, 749);
            this.reportViewer1.TabIndex = 0;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;

            // 
            // tbAccountsToPayBindingSource
            // 
            this.tb_accountsToPayBindingSource.DataMember = "tb_accountsToPay";
            this.tb_accountsToPayBindingSource.DataSource = this.fullDataSet;
            // 
            // GeneralAccountsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 749);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GeneralAccountsPayReport";
            this.Text = "Impressão de Relatório";
            this.Load += new System.EventHandler(this.GeneralAccountsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_accountsToPayBindingSource)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource tb_accountsToPayBindingSource;
        private FullDataSetTableAdapters.tb_accountsToPayTableAdapter tb_accountsToPayTableAdapter;
    }
}