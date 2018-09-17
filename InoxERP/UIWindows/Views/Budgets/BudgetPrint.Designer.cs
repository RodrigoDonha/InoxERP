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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rptPrint = new Microsoft.Reporting.WinForms.ReportViewer();
            this.generalDataSet = new UIWindows.GeneralDataSet();
            this.generalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_itemsTableAdapter = new UIWindows.GeneralDataSetTableAdapters.tb_itemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.generalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbitemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptPrint
            // 
            reportDataSource1.Name = "DataSetBudgetWithoutPrice"; // nome do data set do conjunto de dados do arquivo rdlc
            reportDataSource1.Value = this.tbitemsBindingSource;
            this.rptPrint.LocalReport.DataSources.Add(reportDataSource1); // essa linha deve ser a mais importante, eu acho
            this.rptPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptPrint.LocalReport.ReportEmbeddedResource = "UIWindows.Business.Reports.Budget.rdlc";
            this.rptPrint.Location = new System.Drawing.Point(0, 0);
            this.rptPrint.Name = "rptPrint";
            this.rptPrint.ServerReport.BearerToken = null;
            this.rptPrint.Size = new System.Drawing.Size(632, 749);
            this.rptPrint.TabIndex = 0;
            this.rptPrint.AutoSize = true;
            this.rptPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rptPrint.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // generalDataSet
            // 
            this.generalDataSet.DataSetName = "GeneralDataSet";
            this.generalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generalDataSetBindingSource
            // 
            this.generalDataSetBindingSource.DataSource = this.generalDataSet;
            this.generalDataSetBindingSource.Position = 0;
            // 
            // tbitemsBindingSource
            // 
            this.tbitemsBindingSource.DataMember = "tb_items";
            this.tbitemsBindingSource.DataSource = this.generalDataSetBindingSource;
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
            this.Load += new System.EventHandler(this.Print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbitemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptPrint;
        private GeneralDataSet generalDataSet;
        private System.Windows.Forms.BindingSource generalDataSetBindingSource;
        private System.Windows.Forms.BindingSource tbitemsBindingSource;
        private GeneralDataSetTableAdapters.tb_itemsTableAdapter tb_itemsTableAdapter;
    }
}