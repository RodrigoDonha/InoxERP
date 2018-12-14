namespace UIWindows.Views.Reports.Cash
{
    partial class GeneralCashReport
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
            this.fullDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UIWindows.FullDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbcashBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_cashReportTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_cashReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcashBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fullDataSetBindingSource
            // 
            this.fullDataSetBindingSource.DataSource = this.fullDataSet;
            this.fullDataSetBindingSource.Position = 0;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "GeneralDataSet";
            reportDataSource1.Value = this.tbcashBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UIWindows.Business.Reports.Cash.GeneralCash.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbcashBindingSource
            // 
            this.tbcashBindingSource.DataMember = "tb_cashReport";
            this.tbcashBindingSource.DataSource = this.fullDataSetBindingSource;
            // 
            // tb_cashTableAdapter
            // 
            this.tb_cashReportTableAdapter.ClearBeforeFill = true;
            // 
            // GeneralCashReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GeneralCashReport";
            this.Text = "GeneralCashReport";
            this.Load += new System.EventHandler(this.GeneralCashReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcashBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource fullDataSetBindingSource;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource tbcashBindingSource;
        private FullDataSetTableAdapters.tb_cashReportTableAdapter tb_cashReportTableAdapter;
    }
}