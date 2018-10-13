namespace UIWindows
{
    partial class frmCashGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashGeneral));
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtReferenteA = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.grdExtratoGeral = new System.Windows.Forms.DataGridView();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblReferenteA = new System.Windows.Forms.Label();
            this.lblExtratoGeral = new System.Windows.Forms.Label();
            this.lblSaldoFinal = new System.Windows.Forms.Label();
            this.lblExibeSaldoFinal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdExtratoGeral)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(109, 63);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.MaxLength = 18;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(132, 23);
            this.txtValor.TabIndex = 21;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validationEntriesNumerics);
            // 
            // txtReferenteA
            // 
            this.txtReferenteA.Enabled = false;
            this.txtReferenteA.Location = new System.Drawing.Point(109, 95);
            this.txtReferenteA.Margin = new System.Windows.Forms.Padding(4);
            this.txtReferenteA.MaxLength = 100;
            this.txtReferenteA.Name = "txtReferenteA";
            this.txtReferenteA.Size = new System.Drawing.Size(381, 23);
            this.txtReferenteA.TabIndex = 20;
            // 
            // dtpData
            // 
            this.dtpData.Enabled = false;
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(368, 60);
            this.dtpData.Margin = new System.Windows.Forms.Padding(4);
            this.dtpData.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(123, 23);
            this.dtpData.TabIndex = 19;
            // 
            // grdExtratoGeral
            // 
            this.grdExtratoGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExtratoGeral.Location = new System.Drawing.Point(23, 128);
            this.grdExtratoGeral.Margin = new System.Windows.Forms.Padding(4);
            this.grdExtratoGeral.Name = "grdExtratoGeral";
            this.grdExtratoGeral.Size = new System.Drawing.Size(469, 233);
            this.grdExtratoGeral.TabIndex = 18;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(23, 68);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(49, 17);
            this.lblValor.TabIndex = 17;
            this.lblValor.Text = "Valor: ";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(312, 68);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(46, 17);
            this.lblData.TabIndex = 16;
            this.lblData.Text = "Data: ";
            // 
            // lblReferenteA
            // 
            this.lblReferenteA.AutoSize = true;
            this.lblReferenteA.Location = new System.Drawing.Point(23, 98);
            this.lblReferenteA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReferenteA.Name = "lblReferenteA";
            this.lblReferenteA.Size = new System.Drawing.Size(91, 17);
            this.lblReferenteA.TabIndex = 15;
            this.lblReferenteA.Text = "Referente a: ";
            // 
            // lblExtratoGeral
            // 
            this.lblExtratoGeral.AutoSize = true;
            this.lblExtratoGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtratoGeral.Location = new System.Drawing.Point(179, 11);
            this.lblExtratoGeral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtratoGeral.Name = "lblExtratoGeral";
            this.lblExtratoGeral.Size = new System.Drawing.Size(118, 24);
            this.lblExtratoGeral.TabIndex = 14;
            this.lblExtratoGeral.Text = "Extrato Geral";
            // 
            // lblSaldoFinal
            // 
            this.lblSaldoFinal.AutoSize = true;
            this.lblSaldoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoFinal.Location = new System.Drawing.Point(179, 374);
            this.lblSaldoFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoFinal.Name = "lblSaldoFinal";
            this.lblSaldoFinal.Size = new System.Drawing.Size(63, 24);
            this.lblSaldoFinal.TabIndex = 22;
            this.lblSaldoFinal.Text = "Saldo:";
            // 
            // lblExibeSaldoFinal
            // 
            this.lblExibeSaldoFinal.AutoSize = true;
            this.lblExibeSaldoFinal.Location = new System.Drawing.Point(249, 380);
            this.lblExibeSaldoFinal.Name = "lblExibeSaldoFinal";
            this.lblExibeSaldoFinal.Size = new System.Drawing.Size(114, 17);
            this.lblExibeSaldoFinal.TabIndex = 23;
            this.lblExibeSaldoFinal.Text = "Exibir Saldo Aqui";
            // 
            // frmCashGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 407);
            this.Controls.Add(this.lblExibeSaldoFinal);
            this.Controls.Add(this.lblSaldoFinal);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtReferenteA);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.grdExtratoGeral);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblReferenteA);
            this.Controls.Add(this.lblExtratoGeral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCashGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa Geral";
            ((System.ComponentModel.ISupportInitialize)(this.grdExtratoGeral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtReferenteA;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DataGridView grdExtratoGeral;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblReferenteA;
        private System.Windows.Forms.Label lblExtratoGeral;
        private System.Windows.Forms.Label lblSaldoFinal;
        private System.Windows.Forms.Label lblExibeSaldoFinal;
    }
}