namespace UIWindows
{
    partial class frmReportAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportAccounts));
            this.btnGerar = new System.Windows.Forms.Button();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.lblAte = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.grpPeriodo = new System.Windows.Forms.GroupBox();
            this.lblDe = new System.Windows.Forms.Label();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radContasGeraisAReceber = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radPagosParcialmente = new System.Windows.Forms.RadioButton();
            this.radContasGeraisAPagar = new System.Windows.Forms.RadioButton();
            this.radRecebidosParcialemnte = new System.Windows.Forms.RadioButton();
            this.radPagas = new System.Windows.Forms.RadioButton();
            this.radAPagar = new System.Windows.Forms.RadioButton();
            this.radAReceber = new System.Windows.Forms.RadioButton();
            this.radRecebidos = new System.Windows.Forms.RadioButton();
            this.grpPeriodo.SuspendLayout();
            this.grpTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(517, 298);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(80, 30);
            this.btnGerar.TabIndex = 11;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // dtpFim
            // 
            this.dtpFim.Location = new System.Drawing.Point(59, 156);
            this.dtpFim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(303, 23);
            this.dtpFim.TabIndex = 10;
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Location = new System.Drawing.Point(5, 158);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(33, 17);
            this.lblAte.TabIndex = 4;
            this.lblAte.Text = "Até:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(59, 101);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(303, 23);
            this.dtpInicio.TabIndex = 9;
            // 
            // grpPeriodo
            // 
            this.grpPeriodo.Controls.Add(this.dtpFim);
            this.grpPeriodo.Controls.Add(this.lblAte);
            this.grpPeriodo.Controls.Add(this.lblDe);
            this.grpPeriodo.Controls.Add(this.dtpInicio);
            this.grpPeriodo.Location = new System.Drawing.Point(223, 12);
            this.grpPeriodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPeriodo.Name = "grpPeriodo";
            this.grpPeriodo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPeriodo.Size = new System.Drawing.Size(374, 282);
            this.grpPeriodo.TabIndex = 2;
            this.grpPeriodo.TabStop = false;
            this.grpPeriodo.Text = "Período";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(5, 102);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(30, 17);
            this.lblDe.TabIndex = 3;
            this.lblDe.Text = "De:";
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.label2);
            this.grpTipo.Controls.Add(this.radContasGeraisAReceber);
            this.grpTipo.Controls.Add(this.label1);
            this.grpTipo.Controls.Add(this.radPagosParcialmente);
            this.grpTipo.Controls.Add(this.radContasGeraisAPagar);
            this.grpTipo.Controls.Add(this.radRecebidosParcialemnte);
            this.grpTipo.Controls.Add(this.radPagas);
            this.grpTipo.Controls.Add(this.radAPagar);
            this.grpTipo.Controls.Add(this.radAReceber);
            this.grpTipo.Controls.Add(this.radRecebidos);
            this.grpTipo.Location = new System.Drawing.Point(12, 12);
            this.grpTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTipo.Size = new System.Drawing.Size(205, 282);
            this.grpTipo.TabIndex = 1;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Por Situação";
            // 
            // radContasGeraisAReceber
            // 
            this.radContasGeraisAReceber.AutoSize = true;
            this.radContasGeraisAReceber.Location = new System.Drawing.Point(24, 72);
            this.radContasGeraisAReceber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radContasGeraisAReceber.Name = "radContasGeraisAReceber";
            this.radContasGeraisAReceber.Size = new System.Drawing.Size(140, 21);
            this.radContasGeraisAReceber.TabIndex = 2;
            this.radContasGeraisAReceber.TabStop = true;
            this.radContasGeraisAReceber.Text = "Contas a Receber";
            this.radContasGeraisAReceber.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Geral";
            // 
            // radPagosParcialmente
            // 
            this.radPagosParcialmente.AutoSize = true;
            this.radPagosParcialmente.Location = new System.Drawing.Point(23, 227);
            this.radPagosParcialmente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radPagosParcialmente.Name = "radPagosParcialmente";
            this.radPagosParcialmente.Size = new System.Drawing.Size(152, 21);
            this.radPagosParcialmente.TabIndex = 7;
            this.radPagosParcialmente.TabStop = true;
            this.radPagosParcialmente.Text = "Pagos Parcialmente";
            this.radPagosParcialmente.UseVisualStyleBackColor = true;
            // 
            // radContasGeraisAPagar
            // 
            this.radContasGeraisAPagar.AutoSize = true;
            this.radContasGeraisAPagar.Location = new System.Drawing.Point(25, 47);
            this.radContasGeraisAPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radContasGeraisAPagar.Name = "radContasGeraisAPagar";
            this.radContasGeraisAPagar.Size = new System.Drawing.Size(124, 21);
            this.radContasGeraisAPagar.TabIndex = 1;
            this.radContasGeraisAPagar.TabStop = true;
            this.radContasGeraisAPagar.Text = "Contas a Pagar";
            this.radContasGeraisAPagar.UseVisualStyleBackColor = true;
            // 
            // radRecebidosParcialemnte
            // 
            this.radRecebidosParcialemnte.AutoSize = true;
            this.radRecebidosParcialemnte.Location = new System.Drawing.Point(23, 252);
            this.radRecebidosParcialemnte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radRecebidosParcialemnte.Name = "radRecebidosParcialemnte";
            this.radRecebidosParcialemnte.Size = new System.Drawing.Size(179, 21);
            this.radRecebidosParcialemnte.TabIndex = 8;
            this.radRecebidosParcialemnte.TabStop = true;
            this.radRecebidosParcialemnte.Text = "Recebidos Parcialmente";
            this.radRecebidosParcialemnte.UseVisualStyleBackColor = true;
            // 
            // radPagas
            // 
            this.radPagas.AutoSize = true;
            this.radPagas.Location = new System.Drawing.Point(24, 127);
            this.radPagas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radPagas.Name = "radPagas";
            this.radPagas.Size = new System.Drawing.Size(66, 21);
            this.radPagas.TabIndex = 3;
            this.radPagas.TabStop = true;
            this.radPagas.Text = "Pagas";
            this.radPagas.UseVisualStyleBackColor = true;
            // 
            // radAPagar
            // 
            this.radAPagar.AutoSize = true;
            this.radAPagar.Location = new System.Drawing.Point(24, 152);
            this.radAPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radAPagar.Name = "radAPagar";
            this.radAPagar.Size = new System.Drawing.Size(77, 21);
            this.radAPagar.TabIndex = 4;
            this.radAPagar.TabStop = true;
            this.radAPagar.Text = "A Pagar";
            this.radAPagar.UseVisualStyleBackColor = true;
            // 
            // radAReceber
            // 
            this.radAReceber.AutoSize = true;
            this.radAReceber.Location = new System.Drawing.Point(24, 202);
            this.radAReceber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radAReceber.Name = "radAReceber";
            this.radAReceber.Size = new System.Drawing.Size(93, 21);
            this.radAReceber.TabIndex = 6;
            this.radAReceber.TabStop = true;
            this.radAReceber.Text = "A Receber";
            this.radAReceber.UseVisualStyleBackColor = true;
            // 
            // radRecebidos
            // 
            this.radRecebidos.AutoSize = true;
            this.radRecebidos.Location = new System.Drawing.Point(24, 177);
            this.radRecebidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radRecebidos.Name = "radRecebidos";
            this.radRecebidos.Size = new System.Drawing.Size(93, 21);
            this.radRecebidos.TabIndex = 5;
            this.radRecebidos.TabStop = true;
            this.radRecebidos.Text = "Recebidos";
            this.radRecebidos.UseVisualStyleBackColor = true;
            // 
            // frmReportAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 333);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.grpPeriodo);
            this.Controls.Add(this.grpTipo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmReportAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de Contas";
            this.grpPeriodo.ResumeLayout(false);
            this.grpPeriodo.PerformLayout();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.GroupBox grpPeriodo;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton radPagas;
        private System.Windows.Forms.RadioButton radAPagar;
        private System.Windows.Forms.RadioButton radAReceber;
        private System.Windows.Forms.RadioButton radRecebidos;
        private System.Windows.Forms.RadioButton radPagosParcialmente;
        private System.Windows.Forms.RadioButton radRecebidosParcialemnte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radContasGeraisAReceber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radContasGeraisAPagar;
    }
}