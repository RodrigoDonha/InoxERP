namespace UIWindows.Views.Budgets
{
    partial class frmPrintBudgets
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
            this.rptBudgetPrint = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptBudgetPrint
            // 
            this.rptBudgetPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptBudgetPrint.LocalReport.ReportEmbeddedResource = "UIWindows.Business.Reports.rptBudgetPrint.rdlc";
            this.rptBudgetPrint.Location = new System.Drawing.Point(0, 0);
            this.rptBudgetPrint.Name = "rptBudgetPrint";
            this.rptBudgetPrint.ServerReport.BearerToken = null;
            this.rptBudgetPrint.Size = new System.Drawing.Size(800, 770);
            this.rptBudgetPrint.TabIndex = 0;
            // 
            // frmPrintBudgets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 770);
            this.Controls.Add(this.rptBudgetPrint);
            this.Name = "frmPrintBudgets";
            this.Text = "Impressão do Orçamento";
            this.Load += new System.EventHandler(this.frmPrintBudgets_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptBudgetPrint;
    }
}