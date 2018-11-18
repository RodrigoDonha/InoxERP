﻿namespace UIWindows.Views.ServicesOrders
{
    partial class ServiceOrdersPrint
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
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
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;

            reportDataSource2.Name = "DataSetItemsPrint";
            reportDataSource2.Value = this.tbitemsBindingSource;

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UIWindows.Business.Reports.ServicesOrders.ServiceOrdersPrint.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(632, 749);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // tb_itemsTableAdapter
            // 
            this.tb_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // ServiceOrdersPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 749);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ServiceOrdersPrint";
            this.Text = "Impressão de Ordem de Serviço";
            this.Load += new System.EventHandler(this.ServiceOrdersPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource tbitemsBindingSource;
        private FullDataSetTableAdapters.tb_itemsTableAdapter tb_itemsTableAdapter;
    }
}