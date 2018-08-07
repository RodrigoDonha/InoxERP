namespace UIWindows
{
    partial class ContasaPagarForm
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
            this.lblExibirCodigo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblDebitos = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtReferenteA = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.grdSaidas = new System.Windows.Forms.DataGridView();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblReferenteA = new System.Windows.Forms.Label();
            this.lblSaidas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdSaidas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExibirCodigo
            // 
            this.lblExibirCodigo.AutoSize = true;
            this.lblExibirCodigo.Location = new System.Drawing.Point(97, 50);
            this.lblExibirCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExibirCodigo.Name = "lblExibirCodigo";
            this.lblExibirCodigo.Size = new System.Drawing.Size(34, 13);
            this.lblExibirCodigo.TabIndex = 41;
            this.lblExibirCodigo.Text = "0000 ";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(14, 50);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 40;
            this.lblCodigo.Text = "Código: ";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(384, 163);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 28);
            this.btnExcluir.TabIndex = 39;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(202, 163);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 28);
            this.btnAlterar.TabIndex = 38;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // lblDebitos
            // 
            this.lblDebitos.AutoSize = true;
            this.lblDebitos.Location = new System.Drawing.Point(424, 50);
            this.lblDebitos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDebitos.Name = "lblDebitos";
            this.lblDebitos.Size = new System.Drawing.Size(43, 13);
            this.lblDebitos.TabIndex = 37;
            this.lblDebitos.Text = "Débitos";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(18, 163);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(100, 28);
            this.btnIncluir.TabIndex = 36;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(101, 84);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(132, 20);
            this.txtValor.TabIndex = 35;
            // 
            // txtReferenteA
            // 
            this.txtReferenteA.Location = new System.Drawing.Point(101, 116);
            this.txtReferenteA.Margin = new System.Windows.Forms.Padding(4);
            this.txtReferenteA.Name = "txtReferenteA";
            this.txtReferenteA.Size = new System.Drawing.Size(381, 20);
            this.txtReferenteA.TabIndex = 34;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(360, 82);
            this.dtpData.Margin = new System.Windows.Forms.Padding(4);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(123, 20);
            this.dtpData.TabIndex = 33;
            // 
            // grdSaidas
            // 
            this.grdSaidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSaidas.Location = new System.Drawing.Point(14, 208);
            this.grdSaidas.Margin = new System.Windows.Forms.Padding(4);
            this.grdSaidas.Name = "grdSaidas";
            this.grdSaidas.Size = new System.Drawing.Size(469, 185);
            this.grdSaidas.TabIndex = 32;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(14, 89);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 13);
            this.lblValor.TabIndex = 31;
            this.lblValor.Text = "Valor: ";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(304, 89);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 13);
            this.lblData.TabIndex = 30;
            this.lblData.Text = "Data: ";
            // 
            // lblReferenteA
            // 
            this.lblReferenteA.AutoSize = true;
            this.lblReferenteA.Location = new System.Drawing.Point(14, 120);
            this.lblReferenteA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReferenteA.Name = "lblReferenteA";
            this.lblReferenteA.Size = new System.Drawing.Size(69, 13);
            this.lblReferenteA.TabIndex = 29;
            this.lblReferenteA.Text = "Referente a: ";
            // 
            // lblSaidas
            // 
            this.lblSaidas.AutoSize = true;
            this.lblSaidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaidas.Location = new System.Drawing.Point(181, 9);
            this.lblSaidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaidas.Name = "lblSaidas";
            this.lblSaidas.Size = new System.Drawing.Size(137, 24);
            this.lblSaidas.TabIndex = 28;
            this.lblSaidas.Text = "Contas a Pagar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 401);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 42;
            this.button1.Text = "Baixar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ContasaPagarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblExibirCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblDebitos);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtReferenteA);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.grdSaidas);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblReferenteA);
            this.Controls.Add(this.lblSaidas);
            this.Name = "ContasaPagarForm";
            this.Text = "ContasaPagarForm";
            ((System.ComponentModel.ISupportInitialize)(this.grdSaidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExibirCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblDebitos;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtReferenteA;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DataGridView grdSaidas;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblReferenteA;
        private System.Windows.Forms.Label lblSaidas;
        private System.Windows.Forms.Button button1;
    }
}