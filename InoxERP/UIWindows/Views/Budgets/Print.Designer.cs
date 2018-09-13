namespace UIWindows.Views.Budgets
{
    partial class Print
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
            this.tbitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conjDadosTotaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conjDadosTotais = new UIWindows.ConjDadosTotais();
            this.rptPrint = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_itemsTableAdapter = new UIWindows.ConjDadosTotaisTableAdapters.tb_itemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conjDadosTotaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conjDadosTotais)).BeginInit();
            this.SuspendLayout();
            // 
            // tbitemsBindingSource
            // 
            this.tbitemsBindingSource.DataMember = "tb_items";
            this.tbitemsBindingSource.DataSource = this.conjDadosTotaisBindingSource;
            // 
            // conjDadosTotaisBindingSource
            // 
            this.conjDadosTotaisBindingSource.DataSource = this.conjDadosTotais;
            this.conjDadosTotaisBindingSource.Position = 0;
            // 
            // conjDadosTotais
            // 
            this.conjDadosTotais.DataSetName = "ConjDadosTotais";
            this.conjDadosTotais.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptPrint
            // 
            this.rptPrint.AutoSize = true;
            this.rptPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rptPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetItemsBudget";
            reportDataSource1.Value = this.tbitemsBindingSource;
            this.rptPrint.LocalReport.DataSources.Add(reportDataSource1);
            this.rptPrint.LocalReport.ReportEmbeddedResource = "UIWindows.Business.Reports.Budget.rdlc";
            this.rptPrint.Location = new System.Drawing.Point(0, 0);
            this.rptPrint.Name = "rptPrint";
            this.rptPrint.ServerReport.BearerToken = null;
            this.rptPrint.Size = new System.Drawing.Size(800, 450);
            this.rptPrint.TabIndex = 0;
            // 
            // tb_itemsTableAdapter
            // 
            this.tb_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptPrint);
            this.Name = "Print";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conjDadosTotaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conjDadosTotais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptPrint;
        private System.Windows.Forms.BindingSource conjDadosTotaisBindingSource;
        private ConjDadosTotais conjDadosTotais;
        private System.Windows.Forms.BindingSource tbitemsBindingSource;
        private ConjDadosTotaisTableAdapters.tb_itemsTableAdapter tb_itemsTableAdapter;
    }
}