namespace UIWindows
{
    partial class ConsultaServicosForm
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpConsultarValores = new System.Windows.Forms.GroupBox();
            this.lblConsultaPeca = new System.Windows.Forms.Label();
            this.txtConsultaPeca = new System.Windows.Forms.TextBox();
            this.grdConsultaPecas = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpConsultaValores = new System.Windows.Forms.GroupBox();
            this.lblPeca = new System.Windows.Forms.Label();
            this.lblMedidas = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tbcConsultaValores = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.grpConsultarValores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaPecas)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.grpConsultaValores.SuspendLayout();
            this.tbcConsultaValores.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpConsultarValores);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(545, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpConsultarValores
            // 
            this.grpConsultarValores.Controls.Add(this.grdConsultaPecas);
            this.grpConsultarValores.Controls.Add(this.txtConsultaPeca);
            this.grpConsultarValores.Controls.Add(this.lblConsultaPeca);
            this.grpConsultarValores.Location = new System.Drawing.Point(5, 6);
            this.grpConsultarValores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConsultarValores.Name = "grpConsultarValores";
            this.grpConsultarValores.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConsultarValores.Size = new System.Drawing.Size(533, 430);
            this.grpConsultarValores.TabIndex = 1;
            this.grpConsultarValores.TabStop = false;
            this.grpConsultarValores.Text = "Consultar Serviços";
            // 
            // lblConsultaPeca
            // 
            this.lblConsultaPeca.AutoSize = true;
            this.lblConsultaPeca.Location = new System.Drawing.Point(5, 33);
            this.lblConsultaPeca.Name = "lblConsultaPeca";
            this.lblConsultaPeca.Size = new System.Drawing.Size(59, 17);
            this.lblConsultaPeca.TabIndex = 5;
            this.lblConsultaPeca.Text = "Serviço:";
            // 
            // txtConsultaPeca
            // 
            this.txtConsultaPeca.Location = new System.Drawing.Point(71, 30);
            this.txtConsultaPeca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConsultaPeca.Name = "txtConsultaPeca";
            this.txtConsultaPeca.Size = new System.Drawing.Size(456, 23);
            this.txtConsultaPeca.TabIndex = 6;
            // 
            // grdConsultaPecas
            // 
            this.grdConsultaPecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultaPecas.Location = new System.Drawing.Point(9, 69);
            this.grdConsultaPecas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdConsultaPecas.Name = "grdConsultaPecas";
            this.grdConsultaPecas.RowTemplate.Height = 24;
            this.grdConsultaPecas.Size = new System.Drawing.Size(517, 354);
            this.grdConsultaPecas.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpConsultaValores);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(545, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpConsultaValores
            // 
            this.grpConsultaValores.Controls.Add(this.btnExcluir);
            this.grpConsultaValores.Controls.Add(this.lblObservacao);
            this.grpConsultaValores.Controls.Add(this.btnAlterar);
            this.grpConsultaValores.Controls.Add(this.txtObservacao);
            this.grpConsultaValores.Controls.Add(this.btnGravar);
            this.grpConsultaValores.Controls.Add(this.txtValorTotal);
            this.grpConsultaValores.Controls.Add(this.txtHoras);
            this.grpConsultaValores.Controls.Add(this.txtServico);
            this.grpConsultaValores.Controls.Add(this.lblValorTotal);
            this.grpConsultaValores.Controls.Add(this.lblMedidas);
            this.grpConsultaValores.Controls.Add(this.lblPeca);
            this.grpConsultaValores.Location = new System.Drawing.Point(5, 6);
            this.grpConsultaValores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConsultaValores.Name = "grpConsultaValores";
            this.grpConsultaValores.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConsultaValores.Size = new System.Drawing.Size(527, 430);
            this.grpConsultaValores.TabIndex = 0;
            this.grpConsultaValores.TabStop = false;
            this.grpConsultaValores.Text = "Cadastro de Serviços";
            // 
            // lblPeca
            // 
            this.lblPeca.AutoSize = true;
            this.lblPeca.Location = new System.Drawing.Point(5, 33);
            this.lblPeca.Name = "lblPeca";
            this.lblPeca.Size = new System.Drawing.Size(59, 17);
            this.lblPeca.TabIndex = 0;
            this.lblPeca.Text = "Serviço:";
            // 
            // lblMedidas
            // 
            this.lblMedidas.AutoSize = true;
            this.lblMedidas.Location = new System.Drawing.Point(5, 71);
            this.lblMedidas.Name = "lblMedidas";
            this.lblMedidas.Size = new System.Drawing.Size(56, 17);
            this.lblMedidas.TabIndex = 1;
            this.lblMedidas.Text = "Tempo:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(262, 74);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(81, 17);
            this.lblValorTotal.TabIndex = 3;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // txtServico
            // 
            this.txtServico.Location = new System.Drawing.Point(85, 30);
            this.txtServico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(407, 23);
            this.txtServico.TabIndex = 4;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(85, 68);
            this.txtHoras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(125, 23);
            this.txtHoras.TabIndex = 5;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(367, 71);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(125, 23);
            this.txtValorTotal.TabIndex = 7;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(65, 330);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 30);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(8, 138);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(480, 92);
            this.txtObservacao.TabIndex = 8;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(221, 330);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(73, 30);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(6, 119);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(89, 17);
            this.lblObservacao.TabIndex = 9;
            this.lblObservacao.Text = "Observação:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(372, 330);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(73, 30);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // tbcConsultaValores
            // 
            this.tbcConsultaValores.Controls.Add(this.tabPage1);
            this.tbcConsultaValores.Controls.Add(this.tabPage2);
            this.tbcConsultaValores.Location = new System.Drawing.Point(5, 7);
            this.tbcConsultaValores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcConsultaValores.Name = "tbcConsultaValores";
            this.tbcConsultaValores.SelectedIndex = 0;
            this.tbcConsultaValores.Size = new System.Drawing.Size(553, 471);
            this.tbcConsultaValores.TabIndex = 3;
            // 
            // ConsultaServicosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 486);
            this.Controls.Add(this.tbcConsultaValores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConsultaServicosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Consulta de Servicos";
            this.tabPage2.ResumeLayout(false);
            this.grpConsultarValores.ResumeLayout(false);
            this.grpConsultarValores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaPecas)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.grpConsultaValores.ResumeLayout(false);
            this.grpConsultaValores.PerformLayout();
            this.tbcConsultaValores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpConsultarValores;
        private System.Windows.Forms.DataGridView grdConsultaPecas;
        private System.Windows.Forms.TextBox txtConsultaPeca;
        private System.Windows.Forms.Label lblConsultaPeca;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpConsultaValores;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblMedidas;
        private System.Windows.Forms.Label lblPeca;
        private System.Windows.Forms.TabControl tbcConsultaValores;
    }
}