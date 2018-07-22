namespace InoxERP
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tipOrcamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tipInclusao = new System.Windows.Forms.ToolStripMenuItem();
            this.tipConsultaOrcamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tipOrdemServico = new System.Windows.Forms.ToolStripMenuItem();
            this.tipConsultaOS = new System.Windows.Forms.ToolStripMenuItem();
            this.tipEntregas = new System.Windows.Forms.ToolStripMenuItem();
            this.tipEmAndamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tipConfirmarPagto = new System.Windows.Forms.ToolStripMenuItem();
            this.tipEntregasFinalizadas = new System.Windows.Forms.ToolStripMenuItem();
            this.tipCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tipEntradaCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tipSaidaCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tipChequesCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tipGeralCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tipRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.tipCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tipClientesCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tipProdutosValores = new System.Windows.Forms.ToolStripMenuItem();
            this.tipServicosCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tipUsuariosCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tipFornecedoresCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipOrcamento,
            this.tipOrdemServico,
            this.tipEntregas,
            this.tipCaixa,
            this.tipRelatorios,
            this.tipCadastro});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(678, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mnuPrincipal";
            // 
            // tipOrcamento
            // 
            this.tipOrcamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipInclusao,
            this.tipConsultaOrcamento});
            this.tipOrcamento.Name = "tipOrcamento";
            this.tipOrcamento.Size = new System.Drawing.Size(101, 24);
            this.tipOrcamento.Text = "Orçamentos";
            this.tipOrcamento.Click += new System.EventHandler(this.orçamentoToolStripMenuItem_Click);
            // 
            // tipInclusao
            // 
            this.tipInclusao.Name = "tipInclusao";
            this.tipInclusao.Size = new System.Drawing.Size(216, 26);
            this.tipInclusao.Text = "Inclusão";
            this.tipInclusao.Click += new System.EventHandler(this.inclusãoToolStripMenuItem_Click);
            // 
            // tipConsultaOrcamento
            // 
            this.tipConsultaOrcamento.Name = "tipConsultaOrcamento";
            this.tipConsultaOrcamento.Size = new System.Drawing.Size(216, 26);
            this.tipConsultaOrcamento.Text = "consulta";
            // 
            // tipOrdemServico
            // 
            this.tipOrdemServico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipConsultaOS});
            this.tipOrdemServico.Name = "tipOrdemServico";
            this.tipOrdemServico.Size = new System.Drawing.Size(141, 24);
            this.tipOrdemServico.Text = "Ordens de Serviço";
            // 
            // tipConsultaOS
            // 
            this.tipConsultaOS.Name = "tipConsultaOS";
            this.tipConsultaOS.Size = new System.Drawing.Size(216, 26);
            this.tipConsultaOS.Text = "Consulta";
            // 
            // tipEntregas
            // 
            this.tipEntregas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipEmAndamento,
            this.tipEntregasFinalizadas});
            this.tipEntregas.Name = "tipEntregas";
            this.tipEntregas.Size = new System.Drawing.Size(78, 24);
            this.tipEntregas.Text = "Entregas";
            // 
            // tipEmAndamento
            // 
            this.tipEmAndamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipConfirmarPagto});
            this.tipEmAndamento.Name = "tipEmAndamento";
            this.tipEmAndamento.Size = new System.Drawing.Size(216, 26);
            this.tipEmAndamento.Text = "Em Andamento";
            // 
            // tipConfirmarPagto
            // 
            this.tipConfirmarPagto.Name = "tipConfirmarPagto";
            this.tipConfirmarPagto.Size = new System.Drawing.Size(216, 26);
            this.tipConfirmarPagto.Text = "confirmar pagto";
            // 
            // tipEntregasFinalizadas
            // 
            this.tipEntregasFinalizadas.Name = "tipEntregasFinalizadas";
            this.tipEntregasFinalizadas.Size = new System.Drawing.Size(216, 26);
            this.tipEntregasFinalizadas.Text = "Finalizadas";
            // 
            // tipCaixa
            // 
            this.tipCaixa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipEntradaCaixa,
            this.tipSaidaCaixa,
            this.tipChequesCaixa,
            this.tipGeralCaixa});
            this.tipCaixa.Name = "tipCaixa";
            this.tipCaixa.Size = new System.Drawing.Size(57, 24);
            this.tipCaixa.Text = "Caixa";
            // 
            // tipEntradaCaixa
            // 
            this.tipEntradaCaixa.Name = "tipEntradaCaixa";
            this.tipEntradaCaixa.Size = new System.Drawing.Size(216, 26);
            this.tipEntradaCaixa.Text = "Entradas";
            this.tipEntradaCaixa.Click += new System.EventHandler(this.entradasToolStripMenuItem1_Click);
            // 
            // tipSaidaCaixa
            // 
            this.tipSaidaCaixa.Name = "tipSaidaCaixa";
            this.tipSaidaCaixa.Size = new System.Drawing.Size(216, 26);
            this.tipSaidaCaixa.Text = "Saídas";
            this.tipSaidaCaixa.Click += new System.EventHandler(this.saídasToolStripMenuItem1_Click);
            // 
            // tipChequesCaixa
            // 
            this.tipChequesCaixa.Name = "tipChequesCaixa";
            this.tipChequesCaixa.Size = new System.Drawing.Size(216, 26);
            this.tipChequesCaixa.Text = "Cheques";
            this.tipChequesCaixa.Click += new System.EventHandler(this.chequesToolStripMenuItem_Click);
            // 
            // tipGeralCaixa
            // 
            this.tipGeralCaixa.Name = "tipGeralCaixa";
            this.tipGeralCaixa.Size = new System.Drawing.Size(216, 26);
            this.tipGeralCaixa.Text = "Geral";
            this.tipGeralCaixa.Click += new System.EventHandler(this.geralToolStripMenuItem_Click);
            // 
            // tipRelatorios
            // 
            this.tipRelatorios.Name = "tipRelatorios";
            this.tipRelatorios.Size = new System.Drawing.Size(88, 24);
            this.tipRelatorios.Text = "Relatórios";
            // 
            // tipCadastro
            // 
            this.tipCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipClientesCadastro,
            this.tipProdutosValores,
            this.tipServicosCadastro,
            this.tipUsuariosCadastro,
            this.tipFornecedoresCadastro});
            this.tipCadastro.Name = "tipCadastro";
            this.tipCadastro.Size = new System.Drawing.Size(80, 24);
            this.tipCadastro.Text = "Cadastro";
            // 
            // tipClientesCadastro
            // 
            this.tipClientesCadastro.Name = "tipClientesCadastro";
            this.tipClientesCadastro.Size = new System.Drawing.Size(216, 26);
            this.tipClientesCadastro.Text = "Clientes";
            this.tipClientesCadastro.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // tipProdutosValores
            // 
            this.tipProdutosValores.Name = "tipProdutosValores";
            this.tipProdutosValores.Size = new System.Drawing.Size(216, 26);
            this.tipProdutosValores.Text = "Produtos e Valores";
            this.tipProdutosValores.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // tipServicosCadastro
            // 
            this.tipServicosCadastro.Name = "tipServicosCadastro";
            this.tipServicosCadastro.Size = new System.Drawing.Size(216, 26);
            this.tipServicosCadastro.Text = "Serviços";
            // 
            // tipUsuariosCadastro
            // 
            this.tipUsuariosCadastro.Name = "tipUsuariosCadastro";
            this.tipUsuariosCadastro.Size = new System.Drawing.Size(216, 26);
            this.tipUsuariosCadastro.Text = "Usuários";
            // 
            // tipFornecedoresCadastro
            // 
            this.tipFornecedoresCadastro.Name = "tipFornecedoresCadastro";
            this.tipFornecedoresCadastro.Size = new System.Drawing.Size(216, 26);
            this.tipFornecedoresCadastro.Text = "Fornecedores";
            this.tipFornecedoresCadastro.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 437);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InoxERP - Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tipOrcamento;
        private System.Windows.Forms.ToolStripMenuItem tipRelatorios;
        private System.Windows.Forms.ToolStripMenuItem tipCadastro;
        private System.Windows.Forms.ToolStripMenuItem tipUsuariosCadastro;
        private System.Windows.Forms.ToolStripMenuItem tipProdutosValores;
        private System.Windows.Forms.ToolStripMenuItem tipServicosCadastro;
        private System.Windows.Forms.ToolStripMenuItem tipInclusao;
        private System.Windows.Forms.ToolStripMenuItem tipConsultaOrcamento;
        private System.Windows.Forms.ToolStripMenuItem tipClientesCadastro;
        private System.Windows.Forms.ToolStripMenuItem tipOrdemServico;
        private System.Windows.Forms.ToolStripMenuItem tipConsultaOS;
        private System.Windows.Forms.ToolStripMenuItem tipEntregas;
        private System.Windows.Forms.ToolStripMenuItem tipCaixa;
        private System.Windows.Forms.ToolStripMenuItem tipEntradaCaixa;
        private System.Windows.Forms.ToolStripMenuItem tipSaidaCaixa;
        private System.Windows.Forms.ToolStripMenuItem tipGeralCaixa;
        private System.Windows.Forms.ToolStripMenuItem tipFornecedoresCadastro;
        private System.Windows.Forms.ToolStripMenuItem tipEmAndamento;
        private System.Windows.Forms.ToolStripMenuItem tipConfirmarPagto;
        private System.Windows.Forms.ToolStripMenuItem tipEntregasFinalizadas;
        private System.Windows.Forms.ToolStripMenuItem tipChequesCaixa;
    }
}

