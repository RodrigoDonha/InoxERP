namespace UIWindows
{
    partial class CaixaChequesForm
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
            this.lblExibeCodigo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtOrcamento = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.grdCheques = new System.Windows.Forms.DataGridView();
            this.lblData = new System.Windows.Forms.Label();
            this.lblOrcamento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.radSim = new System.Windows.Forms.RadioButton();
            this.radNao = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdCheques)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExibeCodigo
            // 
            this.lblExibeCodigo.AutoSize = true;
            this.lblExibeCodigo.Location = new System.Drawing.Point(104, 52);
            this.lblExibeCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExibeCodigo.Name = "lblExibeCodigo";
            this.lblExibeCodigo.Size = new System.Drawing.Size(50, 20);
            this.lblExibeCodigo.TabIndex = 26;
            this.lblExibeCodigo.Text = "0000 ";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(21, 52);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(71, 20);
            this.lblCodigo.TabIndex = 25;
            this.lblCodigo.Text = "Código: ";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(391, 165);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 28);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(209, 165);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 28);
            this.btnAlterar.TabIndex = 23;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(25, 165);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(100, 28);
            this.btnIncluir.TabIndex = 21;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(108, 86);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(132, 26);
            this.txtValor.TabIndex = 20;
            // 
            // txtOrcamento
            // 
            this.txtOrcamento.Location = new System.Drawing.Point(108, 118);
            this.txtOrcamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrcamento.Name = "txtOrcamento";
            this.txtOrcamento.Size = new System.Drawing.Size(132, 26);
            this.txtOrcamento.TabIndex = 19;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(367, 82);
            this.dtpData.Margin = new System.Windows.Forms.Padding(4);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(123, 26);
            this.dtpData.TabIndex = 18;
            // 
            // grdCheques
            // 
            this.grdCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCheques.Location = new System.Drawing.Point(21, 210);
            this.grdCheques.Margin = new System.Windows.Forms.Padding(4);
            this.grdCheques.Name = "grdCheques";
            this.grdCheques.Size = new System.Drawing.Size(469, 185);
            this.grdCheques.TabIndex = 17;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(311, 90);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(55, 20);
            this.lblData.TabIndex = 16;
            this.lblData.Text = "Data: ";
            // 
            // lblOrcamento
            // 
            this.lblOrcamento.AutoSize = true;
            this.lblOrcamento.Location = new System.Drawing.Point(21, 122);
            this.lblOrcamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrcamento.Name = "lblOrcamento";
            this.lblOrcamento.Size = new System.Drawing.Size(102, 20);
            this.lblOrcamento.TabIndex = 15;
            this.lblOrcamento.Text = "Orçamento: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cheques";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(21, 90);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(58, 20);
            this.lblValor.TabIndex = 27;
            this.lblValor.Text = "Valor: ";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(308, 122);
            this.lblPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(57, 20);
            this.lblPago.TabIndex = 28;
            this.lblPago.Text = "Pago: ";
            // 
            // radSim
            // 
            this.radSim.AutoSize = true;
            this.radSim.Location = new System.Drawing.Point(367, 119);
            this.radSim.Margin = new System.Windows.Forms.Padding(4);
            this.radSim.Name = "radSim";
            this.radSim.Size = new System.Drawing.Size(59, 24);
            this.radSim.TabIndex = 29;
            this.radSim.TabStop = true;
            this.radSim.Text = "Sim";
            this.radSim.UseVisualStyleBackColor = true;
            // 
            // radNao
            // 
            this.radNao.AutoSize = true;
            this.radNao.Location = new System.Drawing.Point(431, 119);
            this.radNao.Margin = new System.Windows.Forms.Padding(4);
            this.radNao.Name = "radNao";
            this.radNao.Size = new System.Drawing.Size(60, 24);
            this.radNao.TabIndex = 30;
            this.radNao.TabStop = true;
            this.radNao.Text = "Não";
            this.radNao.UseVisualStyleBackColor = true;
            // 
            // CaixaChequesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 407);
            this.Controls.Add(this.radNao);
            this.Controls.Add(this.radSim);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblExibeCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtOrcamento);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.grdCheques);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblOrcamento);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CaixaChequesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa Cheques";
            ((System.ComponentModel.ISupportInitialize)(this.grdCheques)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExibeCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtOrcamento;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DataGridView grdCheques;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblOrcamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.RadioButton radSim;
        private System.Windows.Forms.RadioButton radNao;
    }
}