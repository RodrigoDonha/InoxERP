namespace UIWindows
{
    partial class ConsultaProdutosForm
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
            this.grpCadastroProdutos = new System.Windows.Forms.GroupBox();
            this.radKG = new System.Windows.Forms.RadioButton();
            this.radMT = new System.Windows.Forms.RadioButton();
            this.radUN = new System.Windows.Forms.RadioButton();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.txtPeca = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPeca = new System.Windows.Forms.Label();
            this.tbcConsultaValores = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpConsultarProdutos = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grdConsultaPecas = new System.Windows.Forms.DataGridView();
            this.txtConsultaPeca = new System.Windows.Forms.TextBox();
            this.lblConsultaPeca = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.grpCadastroProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.tbcConsultaValores.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpConsultarProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaPecas)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCadastroProdutos
            // 
            this.grpCadastroProdutos.Controls.Add(this.lblFornecedor);
            this.grpCadastroProdutos.Controls.Add(this.txtFornecedor);
            this.grpCadastroProdutos.Controls.Add(this.radKG);
            this.grpCadastroProdutos.Controls.Add(this.radMT);
            this.grpCadastroProdutos.Controls.Add(this.radUN);
            this.grpCadastroProdutos.Controls.Add(this.nudQuantidade);
            this.grpCadastroProdutos.Controls.Add(this.btnExcluir);
            this.grpCadastroProdutos.Controls.Add(this.lblObservacao);
            this.grpCadastroProdutos.Controls.Add(this.btnAlterar);
            this.grpCadastroProdutos.Controls.Add(this.txtObservacao);
            this.grpCadastroProdutos.Controls.Add(this.btnGravar);
            this.grpCadastroProdutos.Controls.Add(this.txtValorTotal);
            this.grpCadastroProdutos.Controls.Add(this.txtValorUnitario);
            this.grpCadastroProdutos.Controls.Add(this.txtPeca);
            this.grpCadastroProdutos.Controls.Add(this.lblValorTotal);
            this.grpCadastroProdutos.Controls.Add(this.lblValorUnitario);
            this.grpCadastroProdutos.Controls.Add(this.lblQuantidade);
            this.grpCadastroProdutos.Controls.Add(this.lblPeca);
            this.grpCadastroProdutos.Location = new System.Drawing.Point(5, 6);
            this.grpCadastroProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCadastroProdutos.Name = "grpCadastroProdutos";
            this.grpCadastroProdutos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCadastroProdutos.Size = new System.Drawing.Size(527, 430);
            this.grpCadastroProdutos.TabIndex = 0;
            this.grpCadastroProdutos.TabStop = false;
            this.grpCadastroProdutos.Text = "Cadastro de Produtos";
            // 
            // radKG
            // 
            this.radKG.AutoSize = true;
            this.radKG.Location = new System.Drawing.Point(443, 69);
            this.radKG.Name = "radKG";
            this.radKG.Size = new System.Drawing.Size(54, 24);
            this.radKG.TabIndex = 13;
            this.radKG.TabStop = true;
            this.radKG.Text = "KG";
            this.radKG.UseVisualStyleBackColor = true;
            // 
            // radMT
            // 
            this.radMT.AutoSize = true;
            this.radMT.Location = new System.Drawing.Point(355, 69);
            this.radMT.Name = "radMT";
            this.radMT.Size = new System.Drawing.Size(54, 24);
            this.radMT.TabIndex = 12;
            this.radMT.TabStop = true;
            this.radMT.Text = "MT";
            this.radMT.UseVisualStyleBackColor = true;
            // 
            // radUN
            // 
            this.radUN.AutoSize = true;
            this.radUN.Location = new System.Drawing.Point(262, 69);
            this.radUN.Name = "radUN";
            this.radUN.Size = new System.Drawing.Size(54, 24);
            this.radUN.TabIndex = 11;
            this.radUN.TabStop = true;
            this.radUN.Text = "UN";
            this.radUN.UseVisualStyleBackColor = true;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(112, 69);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(120, 26);
            this.nudQuantidade.TabIndex = 10;
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
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(5, 195);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(104, 20);
            this.lblObservacao.TabIndex = 9;
            this.lblObservacao.Text = "Observação:";
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
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(9, 220);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(480, 82);
            this.txtObservacao.TabIndex = 8;
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
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(364, 107);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(125, 26);
            this.txtValorTotal.TabIndex = 7;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(112, 107);
            this.txtValorUnitario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(125, 26);
            this.txtValorUnitario.TabIndex = 6;
            // 
            // txtPeca
            // 
            this.txtPeca.Location = new System.Drawing.Point(112, 30);
            this.txtPeca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPeca.Name = "txtPeca";
            this.txtPeca.Size = new System.Drawing.Size(377, 26);
            this.txtPeca.TabIndex = 4;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(259, 110);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(95, 20);
            this.lblValorTotal.TabIndex = 3;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Location = new System.Drawing.Point(5, 110);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(116, 20);
            this.lblValorUnitario.TabIndex = 2;
            this.lblValorUnitario.Text = "Valor Unitário:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(5, 71);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(99, 20);
            this.lblQuantidade.TabIndex = 1;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblPeca
            // 
            this.lblPeca.AutoSize = true;
            this.lblPeca.Location = new System.Drawing.Point(5, 33);
            this.lblPeca.Name = "lblPeca";
            this.lblPeca.Size = new System.Drawing.Size(52, 20);
            this.lblPeca.TabIndex = 0;
            this.lblPeca.Text = "Peça:";
            // 
            // tbcConsultaValores
            // 
            this.tbcConsultaValores.Controls.Add(this.tabPage2);
            this.tbcConsultaValores.Controls.Add(this.tabPage1);
            this.tbcConsultaValores.Location = new System.Drawing.Point(5, 7);
            this.tbcConsultaValores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcConsultaValores.Name = "tbcConsultaValores";
            this.tbcConsultaValores.SelectedIndex = 0;
            this.tbcConsultaValores.Size = new System.Drawing.Size(553, 466);
            this.tbcConsultaValores.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpConsultarProdutos);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(545, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpConsultarProdutos
            // 
            this.grpConsultarProdutos.Controls.Add(this.btnBuscar);
            this.grpConsultarProdutos.Controls.Add(this.grdConsultaPecas);
            this.grpConsultarProdutos.Controls.Add(this.txtConsultaPeca);
            this.grpConsultarProdutos.Controls.Add(this.lblConsultaPeca);
            this.grpConsultarProdutos.Location = new System.Drawing.Point(5, 6);
            this.grpConsultarProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConsultarProdutos.Name = "grpConsultarProdutos";
            this.grpConsultarProdutos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConsultarProdutos.Size = new System.Drawing.Size(533, 435);
            this.grpConsultarProdutos.TabIndex = 1;
            this.grpConsultarProdutos.TabStop = false;
            this.grpConsultarProdutos.Text = "Consultar Produtos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(451, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 32);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
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
            // txtConsultaPeca
            // 
            this.txtConsultaPeca.Location = new System.Drawing.Point(56, 30);
            this.txtConsultaPeca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConsultaPeca.Name = "txtConsultaPeca";
            this.txtConsultaPeca.Size = new System.Drawing.Size(389, 26);
            this.txtConsultaPeca.TabIndex = 6;
            // 
            // lblConsultaPeca
            // 
            this.lblConsultaPeca.AutoSize = true;
            this.lblConsultaPeca.Location = new System.Drawing.Point(5, 33);
            this.lblConsultaPeca.Name = "lblConsultaPeca";
            this.lblConsultaPeca.Size = new System.Drawing.Size(52, 20);
            this.lblConsultaPeca.TabIndex = 5;
            this.lblConsultaPeca.Text = "Peça:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpCadastroProdutos);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(545, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(112, 157);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(377, 26);
            this.txtFornecedor.TabIndex = 14;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(6, 160);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(99, 20);
            this.lblFornecedor.TabIndex = 15;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // ConsultaProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 484);
            this.Controls.Add(this.tbcConsultaValores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConsultaProdutosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Consulta de Produtos";
            this.grpCadastroProdutos.ResumeLayout(false);
            this.grpCadastroProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.tbcConsultaValores.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.grpConsultarProdutos.ResumeLayout(false);
            this.grpConsultarProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaPecas)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCadastroProdutos;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.TextBox txtPeca;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblPeca;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TabControl tbcConsultaValores;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton radKG;
        private System.Windows.Forms.RadioButton radMT;
        private System.Windows.Forms.RadioButton radUN;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.GroupBox grpConsultarProdutos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView grdConsultaPecas;
        private System.Windows.Forms.TextBox txtConsultaPeca;
        private System.Windows.Forms.Label lblConsultaPeca;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtFornecedor;
    }
}