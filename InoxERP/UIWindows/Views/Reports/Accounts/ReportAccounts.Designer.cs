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
            this.radPagas = new System.Windows.Forms.RadioButton();
            this.radAPagar = new System.Windows.Forms.RadioButton();
            this.radAReceber = new System.Windows.Forms.RadioButton();
            this.radRecebidos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.grpPeriodo.SuspendLayout();
            this.grpTipo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(517, 285);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(80, 30);
            this.btnGerar.TabIndex = 10;
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
            this.dtpFim.TabIndex = 2;
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
            this.dtpInicio.TabIndex = 1;
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
            this.grpPeriodo.Size = new System.Drawing.Size(374, 266);
            this.grpPeriodo.TabIndex = 11;
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
            this.grpTipo.Controls.Add(this.radioButton4);
            this.grpTipo.Controls.Add(this.radioButton3);
            this.grpTipo.Controls.Add(this.groupBox1);
            this.grpTipo.Controls.Add(this.radPagas);
            this.grpTipo.Controls.Add(this.radAPagar);
            this.grpTipo.Controls.Add(this.radAReceber);
            this.grpTipo.Controls.Add(this.radRecebidos);
            this.grpTipo.Location = new System.Drawing.Point(12, 12);
            this.grpTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTipo.Size = new System.Drawing.Size(205, 265);
            this.grpTipo.TabIndex = 12;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo";
            // 
            // radPagas
            // 
            this.radPagas.AutoSize = true;
            this.radPagas.Location = new System.Drawing.Point(24, 111);
            this.radPagas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radPagas.Name = "radPagas";
            this.radPagas.Size = new System.Drawing.Size(66, 21);
            this.radPagas.TabIndex = 4;
            this.radPagas.TabStop = true;
            this.radPagas.Text = "Pagas";
            this.radPagas.UseVisualStyleBackColor = true;
            // 
            // radAPagar
            // 
            this.radAPagar.AutoSize = true;
            this.radAPagar.Location = new System.Drawing.Point(24, 136);
            this.radAPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radAPagar.Name = "radAPagar";
            this.radAPagar.Size = new System.Drawing.Size(77, 21);
            this.radAPagar.TabIndex = 3;
            this.radAPagar.TabStop = true;
            this.radAPagar.Text = "A Pagar";
            this.radAPagar.UseVisualStyleBackColor = true;
            // 
            // radAReceber
            // 
            this.radAReceber.AutoSize = true;
            this.radAReceber.Location = new System.Drawing.Point(24, 186);
            this.radAReceber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radAReceber.Name = "radAReceber";
            this.radAReceber.Size = new System.Drawing.Size(93, 21);
            this.radAReceber.TabIndex = 1;
            this.radAReceber.TabStop = true;
            this.radAReceber.Text = "A Receber";
            this.radAReceber.UseVisualStyleBackColor = true;
            // 
            // radRecebidos
            // 
            this.radRecebidos.AutoSize = true;
            this.radRecebidos.Location = new System.Drawing.Point(24, 161);
            this.radRecebidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radRecebidos.Name = "radRecebidos";
            this.radRecebidos.Size = new System.Drawing.Size(93, 21);
            this.radRecebidos.TabIndex = 0;
            this.radRecebidos.TabStop = true;
            this.radRecebidos.Text = "Recebidos";
            this.radRecebidos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(15, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 82);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geral";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 21);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(124, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Contas a Pagar";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 46);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(140, 21);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Contas a Receber";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(23, 236);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(179, 21);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Recebidos Parcialmente";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(23, 211);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(152, 21);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Pagos Parcialmente";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // frmReportAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 323);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.grpPeriodo);
            this.Controls.Add(this.grpTipo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReportAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de Contas";
            this.grpPeriodo.ResumeLayout(false);
            this.grpPeriodo.PerformLayout();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}