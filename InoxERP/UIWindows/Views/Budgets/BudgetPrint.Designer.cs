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
            this.fullDataSet = new UIWindows.FullDataSet();
            this.fullDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptPrint
            // 
            reportDataSource1.Name = "DataSetBudgetWithoutPrice"; // nome do data set do conjunto de dados do arquivo rdlc
            reportDataSource1.Value = this.fullDataSetBindingSource;
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
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fullDataSetBindingSource
            // 
            this.fullDataSetBindingSource.DataSource = this.fullDataSet;
            this.fullDataSetBindingSource.Position = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptPrint;
        private System.Windows.Forms.BindingSource fullDataSetBindingSource;
        private FullDataSet fullDataSet;
    }
}