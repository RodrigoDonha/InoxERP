﻿namespace UIWindows.Views.Reports.Delivery
{
    partial class GeneralDeliveryReport
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
            this.tbbudgetsosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UIWindows.FullDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_budgets_osTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_budgets_osTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbbudgetsosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbbudgetsosBindingSource
            // 
            this.tbbudgetsosBindingSource.DataMember = "tb_budgets_os";
            this.tbbudgetsosBindingSource.DataSource = this.fullDataSet;
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
            reportDataSource1.Name = "GeneralDataSet";
            reportDataSource1.Value = this.tbbudgetsosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UIWindows.Business.Reports.Delivery.GeneralDelivery.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(632, 749);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // tb_budgets_osTableAdapter
            // 
            this.tb_budgets_osTableAdapter.ClearBeforeFill = true;
            // 
            // GeneralDeliveryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 749);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GeneralDeliveryReport";
            this.Text = "Impressão de Relatório";
            this.Load += new System.EventHandler(this.GeneralDeliveryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbbudgetsosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource tbbudgetsosBindingSource;
        private FullDataSetTableAdapters.tb_budgets_osTableAdapter tb_budgets_osTableAdapter;
    }
}