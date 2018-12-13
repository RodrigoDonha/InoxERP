namespace UIWindows.Views.Budgets
{
    partial class BudgetPrint
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UIWindows.FullDataSet();
            this.rptPrint = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_itemsTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_itemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbitemsBindingSource
            // 
            this.tbitemsBindingSource.DataMember = "tb_items";
            this.tbitemsBindingSource.DataSource = this.fullDataSet;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptPrint
            // 
            this.rptPrint.AutoSize = true;
            this.rptPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rptPrint.Dock = System.Windows.Forms.DockStyle.Fill;

            reportDataSource2.Name = "DataSetBudgetWithoutPrice";
            reportDataSource2.Value = this.tbitemsBindingSource;

            this.rptPrint.LocalReport.DataSources.Clear();
            this.rptPrint.LocalReport.DataSources.Add(reportDataSource2);
            this.rptPrint.LocalReport.ReportEmbeddedResource = "UIWindows.Business.Reports.Budgets.Budget.rdlc";
            this.rptPrint.Location = new System.Drawing.Point(0, 0);
            this.rptPrint.Name = "rptPrint";
            this.rptPrint.ServerReport.BearerToken = null;
            this.rptPrint.Size = new System.Drawing.Size(632, 749);
            this.rptPrint.TabIndex = 0;
            this.rptPrint.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // tb_itemsTableAdapter
            // 
            this.tb_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // BudgetPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 749);
            this.Controls.Add(this.rptPrint);
            this.Name = "BudgetPrint";
            this.Text = "Impressão de Orçamento";
            this.Load += new System.EventHandler(this.BudgetPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptPrint;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource tbitemsBindingSource;
        private FullDataSetTableAdapters.tb_itemsTableAdapter tb_itemsTableAdapter;
    }
}