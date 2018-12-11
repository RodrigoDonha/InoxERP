namespace UIWindows.Views.Reports.Contracts
{
    partial class ContractPrint
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
            this.tbcontractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UIWindows.FullDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_contractsTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_contractsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbcontractsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcontractsBindingSource
            // 
            this.tbcontractsBindingSource.DataMember = "tb_contracts";
            this.tbcontractsBindingSource.DataSource = this.fullDataSet;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ContractDataSet";
            reportDataSource1.Value = this.tbcontractsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UIWindows.Business.Reports.Contract.Contract.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(632, 749);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // tb_contractsTableAdapter
            // 
            this.tb_contractsTableAdapter.ClearBeforeFill = true;
            // 
            // ContractPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 749);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ContractPrint";
            this.Text = "ContractPrint";
            this.Load += new System.EventHandler(this.ContractPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbcontractsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource tbcontractsBindingSource;
        private FullDataSetTableAdapters.tb_contractsTableAdapter tb_contractsTableAdapter;
    }
}