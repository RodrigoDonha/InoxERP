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
            this.BudgetsPrint = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // BudgetsPrint
            // 
            this.BudgetsPrint.LocalReport.ReportEmbeddedResource = "UIWindows.Business.Reports.rptBudgetPrint.rdlc";
            this.BudgetsPrint.Location = new System.Drawing.Point(12, 12);
            this.BudgetsPrint.Name = "BudgetsPrint";
            this.BudgetsPrint.ServerReport.BearerToken = null;
            this.BudgetsPrint.Size = new System.Drawing.Size(751, 746);
            this.BudgetsPrint.TabIndex = 0;
            // 
            // frmPrintBudgets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 770);
            this.Controls.Add(this.BudgetsPrint);
            this.Name = "frmPrintBudgets";
            this.Text = "Impressão do Orçamento";
            this.Load += new System.EventHandler(this.frmPrintBudgets_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer BudgetsPrint;
    }
}