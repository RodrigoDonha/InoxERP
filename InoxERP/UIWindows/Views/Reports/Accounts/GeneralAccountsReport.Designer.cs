namespace UIWindows.Views.Reports.Accounts
{
    partial class GeneralAccountsReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fullDataSet = new UIWindows.FullDataSet();

            this.tb_accountsToPayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_accountsToRecieveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_parcialPayRecieveBindingSource = new System.Windows.Forms.BindingSource(this.components);

            this.tb_accountsToPayTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_accountsToPayTableAdapter();
            this.tb_accountsToReceiveTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_accountsToReceiveTableAdapter();
            this.tb_parcialPayTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_parcialPayTableAdapter();


            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.tb_accountsToPayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_accountsToRecieveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_parcialPayRecieveBindingSource)).BeginInit();

            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;

            reportDataSource1.Name = "AccountsToPay";
            reportDataSource2.Name = "AccountsToReceive";
            reportDataSource3.Name = "parcialPay";
            
            reportDataSource1.Value = this.tb_accountsToPayBindingSource;
            reportDataSource2.Value = this.tb_accountsToRecieveBindingSource;
            reportDataSource3.Value = this.tb_parcialPayRecieveBindingSource;
            
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UIWindows.Business.Reports.Accounts.GeneralAccounts.rdlc";
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
            // tbAccountsToRecieveBindingSource
            // 
            this.tb_accountsToRecieveBindingSource.DataMember = "tb_accountstoReceive";
            this.tb_accountsToRecieveBindingSource.DataSource = this.fullDataSet;
            // 
            // tb_parcialPayRecieveBindingSource
            // 
            this.tb_parcialPayRecieveBindingSource.DataMember = "tb_parcialPay";
            this.tb_parcialPayRecieveBindingSource.DataSource = this.fullDataSet;

            // 
            // GeneralAccountsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 749);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GeneralAccountsReport";
            this.Text = "Impressão de Relatório";
            this.Load += new System.EventHandler(this.GeneralAccountsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.tb_accountsToPayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_accountsToRecieveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_parcialPayRecieveBindingSource)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FullDataSet fullDataSet;

        // contas a pagar
        private System.Windows.Forms.BindingSource tb_accountsToPayBindingSource;
        private FullDataSetTableAdapters.tb_accountsToPayTableAdapter tb_accountsToPayTableAdapter;

        // contar a receber 
        private System.Windows.Forms.BindingSource tb_accountsToRecieveBindingSource;
        private FullDataSetTableAdapters.tb_accountsToReceiveTableAdapter tb_accountsToReceiveTableAdapter;

        // pagtos parciais
        private System.Windows.Forms.BindingSource tb_parcialPayRecieveBindingSource;
        private FullDataSetTableAdapters.tb_parcialPayTableAdapter tb_parcialPayTableAdapter;
    }
}