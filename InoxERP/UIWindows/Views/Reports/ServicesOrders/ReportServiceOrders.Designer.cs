namespace UIWindows
{
    partial class frmReportServicesOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportServicesOrder));
            this.btnGerar = new System.Windows.Forms.Button();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.lblAte = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.grpPeriodo = new System.Windows.Forms.GroupBox();
            this.lblDe = new System.Windows.Forms.Label();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.radGeral = new System.Windows.Forms.RadioButton();
            this.radFinalizadas = new System.Windows.Forms.RadioButton();
            this.radEmAndamento = new System.Windows.Forms.RadioButton();
            this.grpPeriodo.SuspendLayout();
            this.grpTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(477, 146);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(80, 30);
            this.btnGerar.TabIndex = 5;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // dtpFim
            // 
            this.dtpFim.Location = new System.Drawing.Point(59, 79);
            this.dtpFim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(303, 23);
            this.dtpFim.TabIndex = 2;
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Location = new System.Drawing.Point(5, 81);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(33, 17);
            this.lblAte.TabIndex = 4;
            this.lblAte.Text = "Até:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(59, 37);
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
            this.grpPeriodo.Location = new System.Drawing.Point(172, 12);
            this.grpPeriodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPeriodo.Name = "grpPeriodo";
            this.grpPeriodo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPeriodo.Size = new System.Drawing.Size(385, 129);
            this.grpPeriodo.TabIndex = 5;
            this.grpPeriodo.TabStop = false;
            this.grpPeriodo.Text = "Período";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(5, 38);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(30, 17);
            this.lblDe.TabIndex = 3;
            this.lblDe.Text = "De:";
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.radGeral);
            this.grpTipo.Controls.Add(this.radFinalizadas);
            this.grpTipo.Controls.Add(this.radEmAndamento);
            this.grpTipo.Location = new System.Drawing.Point(12, 12);
            this.grpTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTipo.Size = new System.Drawing.Size(149, 129);
            this.grpTipo.TabIndex = 6;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo";
            // 
            // radGeral
            // 
            this.radGeral.AutoSize = true;
            this.radGeral.Checked = true;
            this.radGeral.Location = new System.Drawing.Point(25, 34);
            this.radGeral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radGeral.Name = "radGeral";
            this.radGeral.Size = new System.Drawing.Size(61, 21);
            this.radGeral.TabIndex = 2;
            this.radGeral.TabStop = true;
            this.radGeral.Text = "Geral";
            this.radGeral.UseVisualStyleBackColor = true;
            // 
            // radFinalizadas
            // 
            this.radFinalizadas.AutoSize = true;
            this.radFinalizadas.Location = new System.Drawing.Point(25, 89);
            this.radFinalizadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radFinalizadas.Name = "radFinalizadas";
            this.radFinalizadas.Size = new System.Drawing.Size(97, 21);
            this.radFinalizadas.TabIndex = 1;
            this.radFinalizadas.Text = "Finalizadas";
            this.radFinalizadas.UseVisualStyleBackColor = true;
            // 
            // radEmAndamento
            // 
            this.radEmAndamento.AutoSize = true;
            this.radEmAndamento.Location = new System.Drawing.Point(25, 62);
            this.radEmAndamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radEmAndamento.Name = "radEmAndamento";
            this.radEmAndamento.Size = new System.Drawing.Size(122, 21);
            this.radEmAndamento.TabIndex = 0;
            this.radEmAndamento.Text = "Em Andamento";
            this.radEmAndamento.UseVisualStyleBackColor = true;
            // 
            // frmReportServicesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 186);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.grpPeriodo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReportServicesOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios de Ordens de Servico";
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
        private System.Windows.Forms.RadioButton radGeral;
        private System.Windows.Forms.RadioButton radFinalizadas;
        private System.Windows.Forms.RadioButton radEmAndamento;
    }
}