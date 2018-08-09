﻿namespace InoxERP
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
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.tipOrcamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tipInclusao = new System.Windows.Forms.ToolStripMenuItem();
            this.tipConsultaOrcamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tipOrdemServico = new System.Windows.Forms.ToolStripMenuItem();
            this.tipConsultaOS = new System.Windows.Forms.ToolStripMenuItem();
            this.contratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipEntregas = new System.Windows.Forms.ToolStripMenuItem();
            this.tipEmAndamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tipEntregasFinalizadas = new System.Windows.Forms.ToolStripMenuItem();
            this.contasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aReceberToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chequesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tipEntradaCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tipSaidaCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tipGeralCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tipRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.orçamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordensDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recebidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recebíveisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tipClientesCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tipFornecedoresCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tipProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tipServicosCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tipUsuariosCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenu
            // 
            this.mnsMenu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipCadastro,
            this.tipOrcamento,
            this.tipOrdemServico,
            this.tipEntregas,
            this.contasToolStripMenuItem,
            this.tipCaixa,
            this.tipRelatorios});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(763, 29);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "mnuPrincipal";
            // 
            // tipOrcamento
            // 
            this.tipOrcamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipInclusao,
            this.tipConsultaOrcamento});
            this.tipOrcamento.Name = "tipOrcamento";
            this.tipOrcamento.Size = new System.Drawing.Size(107, 25);
            this.tipOrcamento.Text = "Orçamentos";
            this.tipOrcamento.Click += new System.EventHandler(this.orçamentoToolStripMenuItem_Click);
            // 
            // tipInclusao
            // 
            this.tipInclusao.Name = "tipInclusao";
            this.tipInclusao.Size = new System.Drawing.Size(141, 26);
            this.tipInclusao.Text = "Inclusão";
            this.tipInclusao.Click += new System.EventHandler(this.inclusãoToolStripMenuItem_Click);
            // 
            // tipConsultaOrcamento
            // 
            this.tipConsultaOrcamento.Name = "tipConsultaOrcamento";
            this.tipConsultaOrcamento.Size = new System.Drawing.Size(141, 26);
            this.tipConsultaOrcamento.Text = "Consulta";
            this.tipConsultaOrcamento.Click += new System.EventHandler(this.tipConsultaOrcamento_Click);
            // 
            // tipOrdemServico
            // 
            this.tipOrdemServico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipConsultaOS,
            this.contratosToolStripMenuItem});
            this.tipOrdemServico.Name = "tipOrdemServico";
            this.tipOrdemServico.Size = new System.Drawing.Size(149, 25);
            this.tipOrdemServico.Text = "Ordens de Serviço";
            // 
            // tipConsultaOS
            // 
            this.tipConsultaOS.Name = "tipConsultaOS";
            this.tipConsultaOS.Size = new System.Drawing.Size(180, 26);
            this.tipConsultaOS.Text = "Consulta";
            this.tipConsultaOS.Click += new System.EventHandler(this.tipConsultaOS_Click);
            // 
            // contratosToolStripMenuItem
            // 
            this.contratosToolStripMenuItem.Name = "contratosToolStripMenuItem";
            this.contratosToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.contratosToolStripMenuItem.Text = "Contratos";
            this.contratosToolStripMenuItem.Click += new System.EventHandler(this.contratosToolStripMenuItem_Click);
            // 
            // tipEntregas
            // 
            this.tipEntregas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipEmAndamento,
            this.tipEntregasFinalizadas});
            this.tipEntregas.Name = "tipEntregas";
            this.tipEntregas.Size = new System.Drawing.Size(82, 25);
            this.tipEntregas.Text = "Entregas";
            // 
            // tipEmAndamento
            // 
            this.tipEmAndamento.Name = "tipEmAndamento";
            this.tipEmAndamento.Size = new System.Drawing.Size(180, 26);
            this.tipEmAndamento.Text = "Andamento";
            this.tipEmAndamento.Click += new System.EventHandler(this.tipEmAndamento_Click);
            // 
            // tipEntregasFinalizadas
            // 
            this.tipEntregasFinalizadas.Name = "tipEntregasFinalizadas";
            this.tipEntregasFinalizadas.Size = new System.Drawing.Size(180, 26);
            this.tipEntregasFinalizadas.Text = "Finalizadas";
            this.tipEntregasFinalizadas.Click += new System.EventHandler(this.tipEntregasFinalizadas_Click);
            // 
            // contasToolStripMenuItem
            // 
            this.contasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aReceberToolStripMenuItem1,
            this.aPagarToolStripMenuItem,
            this.chequesToolStripMenuItem});
            this.contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            this.contasToolStripMenuItem.Size = new System.Drawing.Size(70, 25);
            this.contasToolStripMenuItem.Text = "Contas";
            // 
            // aReceberToolStripMenuItem1
            // 
            this.aReceberToolStripMenuItem1.Name = "aReceberToolStripMenuItem1";
            this.aReceberToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.aReceberToolStripMenuItem1.Text = "A Receber";
            this.aReceberToolStripMenuItem1.Click += new System.EventHandler(this.aReceberToolStripMenuItem1_Click);
            // 
            // aPagarToolStripMenuItem
            // 
            this.aPagarToolStripMenuItem.Name = "aPagarToolStripMenuItem";
            this.aPagarToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.aPagarToolStripMenuItem.Text = "A Pagar";
            this.aPagarToolStripMenuItem.Click += new System.EventHandler(this.aPagarToolStripMenuItem_Click);
            // 
            // chequesToolStripMenuItem
            // 
            this.chequesToolStripMenuItem.Name = "chequesToolStripMenuItem";
            this.chequesToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.chequesToolStripMenuItem.Text = "Cheques";
            this.chequesToolStripMenuItem.Click += new System.EventHandler(this.chequesToolStripMenuItem_Click_1);
            // 
            // tipCaixa
            // 
            this.tipCaixa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipEntradaCaixa,
            this.tipSaidaCaixa,
            this.tipGeralCaixa});
            this.tipCaixa.Name = "tipCaixa";
            this.tipCaixa.Size = new System.Drawing.Size(59, 25);
            this.tipCaixa.Text = "Caixa";
            // 
            // tipEntradaCaixa
            // 
            this.tipEntradaCaixa.Name = "tipEntradaCaixa";
            this.tipEntradaCaixa.Size = new System.Drawing.Size(180, 26);
            this.tipEntradaCaixa.Text = "Entradas";
            this.tipEntradaCaixa.Click += new System.EventHandler(this.entradasToolStripMenuItem1_Click);
            // 
            // tipSaidaCaixa
            // 
            this.tipSaidaCaixa.Name = "tipSaidaCaixa";
            this.tipSaidaCaixa.Size = new System.Drawing.Size(180, 26);
            this.tipSaidaCaixa.Text = "Saídas";
            this.tipSaidaCaixa.Click += new System.EventHandler(this.saídasToolStripMenuItem1_Click);
            // 
            // tipGeralCaixa
            // 
            this.tipGeralCaixa.Name = "tipGeralCaixa";
            this.tipGeralCaixa.Size = new System.Drawing.Size(180, 26);
            this.tipGeralCaixa.Text = "Geral";
            this.tipGeralCaixa.Click += new System.EventHandler(this.geralToolStripMenuItem_Click);
            // 
            // tipRelatorios
            // 
            this.tipRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orçamentosToolStripMenuItem,
            this.ordensDeServiçoToolStripMenuItem,
            this.entregasToolStripMenuItem,
            this.aReceberToolStripMenuItem});
            this.tipRelatorios.Name = "tipRelatorios";
            this.tipRelatorios.Size = new System.Drawing.Size(92, 25);
            this.tipRelatorios.Text = "Relatórios";
            // 
            // orçamentosToolStripMenuItem
            // 
            this.orçamentosToolStripMenuItem.Name = "orçamentosToolStripMenuItem";
            this.orçamentosToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.orçamentosToolStripMenuItem.Text = "Orçamentos";
            this.orçamentosToolStripMenuItem.Click += new System.EventHandler(this.orçamentosToolStripMenuItem_Click);
            // 
            // ordensDeServiçoToolStripMenuItem
            // 
            this.ordensDeServiçoToolStripMenuItem.Name = "ordensDeServiçoToolStripMenuItem";
            this.ordensDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.ordensDeServiçoToolStripMenuItem.Text = "Ordens de Serviço";
            this.ordensDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.ordensDeServiçoToolStripMenuItem_Click);
            // 
            // entregasToolStripMenuItem
            // 
            this.entregasToolStripMenuItem.Name = "entregasToolStripMenuItem";
            this.entregasToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.entregasToolStripMenuItem.Text = "Entregas";
            this.entregasToolStripMenuItem.Click += new System.EventHandler(this.entregasToolStripMenuItem_Click);
            // 
            // aReceberToolStripMenuItem
            // 
            this.aReceberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recebidosToolStripMenuItem,
            this.recebíveisToolStripMenuItem,
            this.geralToolStripMenuItem});
            this.aReceberToolStripMenuItem.Name = "aReceberToolStripMenuItem";
            this.aReceberToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.aReceberToolStripMenuItem.Text = "Caixa";
            // 
            // recebidosToolStripMenuItem
            // 
            this.recebidosToolStripMenuItem.Name = "recebidosToolStripMenuItem";
            this.recebidosToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.recebidosToolStripMenuItem.Text = "Cheque";
            this.recebidosToolStripMenuItem.Click += new System.EventHandler(this.recebidosToolStripMenuItem_Click);
            // 
            // recebíveisToolStripMenuItem
            // 
            this.recebíveisToolStripMenuItem.Name = "recebíveisToolStripMenuItem";
            this.recebíveisToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.recebíveisToolStripMenuItem.Text = "Dinheiro";
            this.recebíveisToolStripMenuItem.Click += new System.EventHandler(this.recebíveisToolStripMenuItem_Click);
            // 
            // geralToolStripMenuItem
            // 
            this.geralToolStripMenuItem.Name = "geralToolStripMenuItem";
            this.geralToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.geralToolStripMenuItem.Text = "Geral";
            this.geralToolStripMenuItem.Click += new System.EventHandler(this.geralToolStripMenuItem_Click_1);
            // 
            // tipCadastro
            // 
            this.tipCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipClientesCadastro,
            this.tipFornecedoresCadastro,
            this.tipProdutos,
            this.tipServicosCadastro,
            this.tipUsuariosCadastro});
            this.tipCadastro.Name = "tipCadastro";
            this.tipCadastro.Size = new System.Drawing.Size(84, 25);
            this.tipCadastro.Text = "Cadastro";
            // 
            // tipClientesCadastro
            // 
            this.tipClientesCadastro.Name = "tipClientesCadastro";
            this.tipClientesCadastro.Size = new System.Drawing.Size(180, 26);
            this.tipClientesCadastro.Text = "Clientes";
            this.tipClientesCadastro.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // tipFornecedoresCadastro
            // 
            this.tipFornecedoresCadastro.Name = "tipFornecedoresCadastro";
            this.tipFornecedoresCadastro.Size = new System.Drawing.Size(180, 26);
            this.tipFornecedoresCadastro.Text = "Fornecedores";
            this.tipFornecedoresCadastro.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // tipProdutos
            // 
            this.tipProdutos.Name = "tipProdutos";
            this.tipProdutos.Size = new System.Drawing.Size(180, 26);
            this.tipProdutos.Text = "Produtos";
            this.tipProdutos.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // tipServicosCadastro
            // 
            this.tipServicosCadastro.Name = "tipServicosCadastro";
            this.tipServicosCadastro.Size = new System.Drawing.Size(180, 26);
            this.tipServicosCadastro.Text = "Serviços";
            this.tipServicosCadastro.Click += new System.EventHandler(this.tipServicosCadastro_Click);
            // 
            // tipUsuariosCadastro
            // 
            this.tipUsuariosCadastro.Name = "tipUsuariosCadastro";
            this.tipUsuariosCadastro.Size = new System.Drawing.Size(180, 26);
            this.tipUsuariosCadastro.Text = "Usuários";
            this.tipUsuariosCadastro.Click += new System.EventHandler(this.tipUsuariosCadastro_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 546);
            this.Controls.Add(this.mnsMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnsMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InoxERP - Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipalForm_FormClosing);
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem tipOrcamento;
        private System.Windows.Forms.ToolStripMenuItem tipRelatorios;
        private System.Windows.Forms.ToolStripMenuItem tipCadastro;
        private System.Windows.Forms.ToolStripMenuItem tipUsuariosCadastro;
        private System.Windows.Forms.ToolStripMenuItem tipProdutos;
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
        private System.Windows.Forms.ToolStripMenuItem tipEntregasFinalizadas;
        private System.Windows.Forms.ToolStripMenuItem orçamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordensDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recebidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recebíveisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aReceberToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chequesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratosToolStripMenuItem;
    }
}

