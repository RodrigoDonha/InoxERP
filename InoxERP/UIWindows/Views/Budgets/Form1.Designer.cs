namespace UIWindows.Views.Budgets
{
    partial class Form1
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
            this.generalDataSet = new UIWindows.GeneralDataSet();
            this.generalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_itemsTableAdapter = new UIWindows.GeneralDataSetTableAdapters.tb_itemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.generalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbitemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetBudgetWihtPrice";
            reportDataSource1.Value = this.tbitemsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UIWindows.Business.Reports.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(31, 40);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbitemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private GeneralDataSet generalDataSet;
        private System.Windows.Forms.BindingSource generalDataSetBindingSource;
        private System.Windows.Forms.BindingSource tbitemsBindingSource;
        private GeneralDataSetTableAdapters.tb_itemsTableAdapter tb_itemsTableAdapter;
    }
}