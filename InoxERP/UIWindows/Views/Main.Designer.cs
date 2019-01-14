using System.Drawing;

namespace InoxERP
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.tipCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tipClientesCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tipFornecedoresCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tipProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tipServicosCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tipUsuariosCadastro = new System.Windows.Forms.ToolStripMenuItem();
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
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tipEntradaCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tipSaidaCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tipGeralCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tipRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.orçamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordensDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dinheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chequeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbOSContratos = new System.Windows.Forms.GroupBox();
            this.picOrdemServico = new System.Windows.Forms.PictureBox();
            this.lblConsultaOS = new System.Windows.Forms.Label();
            this.picContratos = new System.Windows.Forms.PictureBox();
            this.lblContratos = new System.Windows.Forms.Label();
            this.gpbEntregas = new System.Windows.Forms.GroupBox();
            this.picAndamento = new System.Windows.Forms.PictureBox();
            this.lblAndamento = new System.Windows.Forms.Label();
            this.picFinalizadas = new System.Windows.Forms.PictureBox();
            this.lblFinalizadas = new System.Windows.Forms.Label();
            this.gpbContas = new System.Windows.Forms.GroupBox();
            this.picCheque = new System.Windows.Forms.PictureBox();
            this.lblCheques = new System.Windows.Forms.Label();
            this.picConsultaContas = new System.Windows.Forms.PictureBox();
            this.lblConsultaContas = new System.Windows.Forms.Label();
            this.picaReceber = new System.Windows.Forms.PictureBox();
            this.lblaReceber = new System.Windows.Forms.Label();
            this.picaPagar = new System.Windows.Forms.PictureBox();
            this.lblaPagar = new System.Windows.Forms.Label();
            this.gpbCaixa = new System.Windows.Forms.GroupBox();
            this.picGeral = new System.Windows.Forms.PictureBox();
            this.lblGeral = new System.Windows.Forms.Label();
            this.picEntradas = new System.Windows.Forms.PictureBox();
            this.lblEntradas = new System.Windows.Forms.Label();
            this.picSaidas = new System.Windows.Forms.PictureBox();
            this.lblSaidas = new System.Windows.Forms.Label();
            this.gpbRelatorios = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRelCaixaGeral = new System.Windows.Forms.Label();
            this.lblRelCheques = new System.Windows.Forms.Label();
            this.picRelCaixaGeral = new System.Windows.Forms.PictureBox();
            this.picRelCaixa = new System.Windows.Forms.PictureBox();
            this.picRelCheques = new System.Windows.Forms.PictureBox();
            this.lblRelEntregas = new System.Windows.Forms.Label();
            this.lblRelOS = new System.Windows.Forms.Label();
            this.picRelEntregas = new System.Windows.Forms.PictureBox();
            this.picRelOrcamentos = new System.Windows.Forms.PictureBox();
            this.lblRelOrcamentos = new System.Windows.Forms.Label();
            this.picRelOS = new System.Windows.Forms.PictureBox();
            this.lblBackup = new System.Windows.Forms.Label();
            this.lblLogado = new System.Windows.Forms.Label();
            this.picRestart = new System.Windows.Forms.PictureBox();
            this.picBackup = new System.Windows.Forms.PictureBox();
            this.gpbOrcamentos = new System.Windows.Forms.GroupBox();
            this.picInclusao = new System.Windows.Forms.PictureBox();
            this.lblInclusao = new System.Windows.Forms.Label();
            this.picConsulta = new System.Windows.Forms.PictureBox();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.gpbCadastros = new System.Windows.Forms.GroupBox();
            this.picClient = new System.Windows.Forms.PictureBox();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.picUsuarios = new System.Windows.Forms.PictureBox();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblServicos = new System.Windows.Forms.Label();
            this.picFornecedor = new System.Windows.Forms.PictureBox();
            this.picServicos = new System.Windows.Forms.PictureBox();
            this.lblFornecedores = new System.Windows.Forms.Label();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.picProdutos = new System.Windows.Forms.PictureBox();
            this.mnsMenu.SuspendLayout();
            this.gpbOSContratos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOrdemServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContratos)).BeginInit();
            this.gpbEntregas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAndamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinalizadas)).BeginInit();
            this.gpbContas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConsultaContas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picaReceber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picaPagar)).BeginInit();
            this.gpbCaixa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGeral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaidas)).BeginInit();
            this.gpbRelatorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRelCaixaGeral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRelCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRelCheques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRelEntregas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRelOrcamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRelOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackup)).BeginInit();
            this.gpbOrcamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInclusao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConsulta)).BeginInit();
            this.gpbCadastros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProdutos)).BeginInit();
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
            this.mnsMenu.Size = new System.Drawing.Size(966, 29);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "mnuPrincipal";
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
            this.tipClientesCadastro.Size = new System.Drawing.Size(174, 26);
            this.tipClientesCadastro.Text = "Clientes";
            this.tipClientesCadastro.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // tipFornecedoresCadastro
            // 
            this.tipFornecedoresCadastro.Name = "tipFornecedoresCadastro";
            this.tipFornecedoresCadastro.Size = new System.Drawing.Size(174, 26);
            this.tipFornecedoresCadastro.Text = "Fornecedores";
            this.tipFornecedoresCadastro.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // tipProdutos
            // 
            this.tipProdutos.Name = "tipProdutos";
            this.tipProdutos.Size = new System.Drawing.Size(174, 26);
            this.tipProdutos.Text = "Produtos";
            this.tipProdutos.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // tipServicosCadastro
            // 
            this.tipServicosCadastro.Name = "tipServicosCadastro";
            this.tipServicosCadastro.Size = new System.Drawing.Size(174, 26);
            this.tipServicosCadastro.Text = "Serviços";
            this.tipServicosCadastro.Click += new System.EventHandler(this.tipServicosCadastro_Click);
            // 
            // tipUsuariosCadastro
            // 
            this.tipUsuariosCadastro.Name = "tipUsuariosCadastro";
            this.tipUsuariosCadastro.Size = new System.Drawing.Size(174, 26);
            this.tipUsuariosCadastro.Text = "Usuários";
            this.tipUsuariosCadastro.Click += new System.EventHandler(this.tipUsuariosCadastro_Click);
            // 
            // tipOrcamento
            // 
            this.tipOrcamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipInclusao,
            this.tipConsultaOrcamento});
            this.tipOrcamento.Name = "tipOrcamento";
            this.tipOrcamento.Size = new System.Drawing.Size(107, 25);
            this.tipOrcamento.Text = "Orçamentos";
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
            this.tipEmAndamento.Size = new System.Drawing.Size(161, 26);
            this.tipEmAndamento.Text = "Andamento";
            this.tipEmAndamento.Click += new System.EventHandler(this.tipEmAndamento_Click);
            // 
            // tipEntregasFinalizadas
            // 
            this.tipEntregasFinalizadas.Name = "tipEntregasFinalizadas";
            this.tipEntregasFinalizadas.Size = new System.Drawing.Size(161, 26);
            this.tipEntregasFinalizadas.Text = "Finalizadas";
            this.tipEntregasFinalizadas.Click += new System.EventHandler(this.tipEntregasFinalizadas_Click);
            // 
            // contasToolStripMenuItem
            // 
            this.contasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aReceberToolStripMenuItem1,
            this.aPagarToolStripMenuItem,
            this.chequesToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            this.contasToolStripMenuItem.Size = new System.Drawing.Size(70, 25);
            this.contasToolStripMenuItem.Text = "Contas";
            // 
            // aReceberToolStripMenuItem1
            // 
            this.aReceberToolStripMenuItem1.Name = "aReceberToolStripMenuItem1";
            this.aReceberToolStripMenuItem1.Size = new System.Drawing.Size(150, 26);
            this.aReceberToolStripMenuItem1.Text = "A Receber";
            this.aReceberToolStripMenuItem1.Click += new System.EventHandler(this.aReceberToolStripMenuItem1_Click);
            // 
            // aPagarToolStripMenuItem
            // 
            this.aPagarToolStripMenuItem.Name = "aPagarToolStripMenuItem";
            this.aPagarToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.aPagarToolStripMenuItem.Text = "A Pagar";
            this.aPagarToolStripMenuItem.Click += new System.EventHandler(this.aPagarToolStripMenuItem_Click);
            // 
            // chequesToolStripMenuItem
            // 
            this.chequesToolStripMenuItem.Name = "chequesToolStripMenuItem";
            this.chequesToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.chequesToolStripMenuItem.Text = "Cheques";
            this.chequesToolStripMenuItem.Click += new System.EventHandler(this.chequesToolStripMenuItem_Click_1);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
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
            this.tipEntradaCaixa.Size = new System.Drawing.Size(140, 26);
            this.tipEntradaCaixa.Text = "Entradas";
            this.tipEntradaCaixa.Click += new System.EventHandler(this.entradasToolStripMenuItem1_Click);
            // 
            // tipSaidaCaixa
            // 
            this.tipSaidaCaixa.Name = "tipSaidaCaixa";
            this.tipSaidaCaixa.Size = new System.Drawing.Size(140, 26);
            this.tipSaidaCaixa.Text = "Saídas";
            this.tipSaidaCaixa.Click += new System.EventHandler(this.saídasToolStripMenuItem1_Click);
            // 
            // tipGeralCaixa
            // 
            this.tipGeralCaixa.Name = "tipGeralCaixa";
            this.tipGeralCaixa.Size = new System.Drawing.Size(140, 26);
            this.tipGeralCaixa.Text = "Geral";
            this.tipGeralCaixa.Click += new System.EventHandler(this.tipGeralCaixa_Click);
            // 
            // tipRelatorios
            // 
            this.tipRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orçamentosToolStripMenuItem,
            this.ordensDeServiçoToolStripMenuItem,
            this.entregasToolStripMenuItem,
            this.aReceberToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
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
            this.dinheiroToolStripMenuItem,
            this.chequeToolStripMenuItem,
            this.geralToolStripMenuItem});
            this.aReceberToolStripMenuItem.Name = "aReceberToolStripMenuItem";
            this.aReceberToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.aReceberToolStripMenuItem.Text = "Caixa";
            // 
            // dinheiroToolStripMenuItem
            // 
            this.dinheiroToolStripMenuItem.Name = "dinheiroToolStripMenuItem";
            this.dinheiroToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.dinheiroToolStripMenuItem.Text = "Dinheiro";
            this.dinheiroToolStripMenuItem.Click += new System.EventHandler(this.dinheiroToolStripMenuItem_Click);
            // 
            // chequeToolStripMenuItem
            // 
            this.chequeToolStripMenuItem.Name = "chequeToolStripMenuItem";
            this.chequeToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.chequeToolStripMenuItem.Text = "Cheque";
            this.chequeToolStripMenuItem.Click += new System.EventHandler(this.chequeToolStripMenuItem_Click);
            // 
            // geralToolStripMenuItem
            // 
            this.geralToolStripMenuItem.Name = "geralToolStripMenuItem";
            this.geralToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.geralToolStripMenuItem.Text = "Geral";
            this.geralToolStripMenuItem.Click += new System.EventHandler(this.geralToolStripMenuItem_Click_1);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // gpbOSContratos
            // 
            this.gpbOSContratos.BackColor = System.Drawing.Color.Transparent;
            this.gpbOSContratos.Controls.Add(this.picOrdemServico);
            this.gpbOSContratos.Controls.Add(this.lblConsultaOS);
            this.gpbOSContratos.Controls.Add(this.picContratos);
            this.gpbOSContratos.Controls.Add(this.lblContratos);
            this.gpbOSContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOSContratos.Location = new System.Drawing.Point(248, 35);
            this.gpbOSContratos.Name = "gpbOSContratos";
            this.gpbOSContratos.Size = new System.Drawing.Size(130, 182);
            this.gpbOSContratos.TabIndex = 14;
            this.gpbOSContratos.TabStop = false;
            this.gpbOSContratos.Text = "O.S./Contratos";
            // 
            // picOrdemServico
            // 
            this.picOrdemServico.Image = global::UIWindows.Properties.Resources.Budget_Search;
            this.picOrdemServico.Location = new System.Drawing.Point(15, 25);
            this.picOrdemServico.Name = "picOrdemServico";
            this.picOrdemServico.Size = new System.Drawing.Size(100, 50);
            this.picOrdemServico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOrdemServico.TabIndex = 1;
            this.picOrdemServico.TabStop = false;
            this.picOrdemServico.Click += new System.EventHandler(this.picOrdemServico_Click);
            // 
            // lblConsultaOS
            // 
            this.lblConsultaOS.AutoSize = true;
            this.lblConsultaOS.Location = new System.Drawing.Point(6, 78);
            this.lblConsultaOS.Name = "lblConsultaOS";
            this.lblConsultaOS.Size = new System.Drawing.Size(115, 17);
            this.lblConsultaOS.TabIndex = 10;
            this.lblConsultaOS.Text = "Ordem Serviço";
            // 
            // picContratos
            // 
            this.picContratos.Image = global::UIWindows.Properties.Resources.Contract1;
            this.picContratos.Location = new System.Drawing.Point(14, 101);
            this.picContratos.Name = "picContratos";
            this.picContratos.Size = new System.Drawing.Size(100, 50);
            this.picContratos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picContratos.TabIndex = 9;
            this.picContratos.TabStop = false;
            this.picContratos.Click += new System.EventHandler(this.picContratos_Click);
            // 
            // lblContratos
            // 
            this.lblContratos.AutoSize = true;
            this.lblContratos.Location = new System.Drawing.Point(26, 154);
            this.lblContratos.Name = "lblContratos";
            this.lblContratos.Size = new System.Drawing.Size(78, 17);
            this.lblContratos.TabIndex = 8;
            this.lblContratos.Text = "Contratos";
            // 
            // gpbEntregas
            // 
            this.gpbEntregas.BackColor = System.Drawing.Color.Transparent;
            this.gpbEntregas.Controls.Add(this.picAndamento);
            this.gpbEntregas.Controls.Add(this.lblAndamento);
            this.gpbEntregas.Controls.Add(this.picFinalizadas);
            this.gpbEntregas.Controls.Add(this.lblFinalizadas);
            this.gpbEntregas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEntregas.Location = new System.Drawing.Point(384, 35);
            this.gpbEntregas.Name = "gpbEntregas";
            this.gpbEntregas.Size = new System.Drawing.Size(112, 182);
            this.gpbEntregas.TabIndex = 15;
            this.gpbEntregas.TabStop = false;
            this.gpbEntregas.Text = "Entregas";
            // 
            // picAndamento
            // 
            this.picAndamento.Image = global::UIWindows.Properties.Resources.Following;
            this.picAndamento.Location = new System.Drawing.Point(6, 25);
            this.picAndamento.Name = "picAndamento";
            this.picAndamento.Size = new System.Drawing.Size(100, 50);
            this.picAndamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAndamento.TabIndex = 1;
            this.picAndamento.TabStop = false;
            this.picAndamento.Click += new System.EventHandler(this.picAndamento_Click);
            // 
            // lblAndamento
            // 
            this.lblAndamento.AutoSize = true;
            this.lblAndamento.Location = new System.Drawing.Point(11, 78);
            this.lblAndamento.Name = "lblAndamento";
            this.lblAndamento.Size = new System.Drawing.Size(89, 17);
            this.lblAndamento.TabIndex = 10;
            this.lblAndamento.Text = "Andamento";
            // 
            // picFinalizadas
            // 
            this.picFinalizadas.Image = global::UIWindows.Properties.Resources.Finished;
            this.picFinalizadas.Location = new System.Drawing.Point(6, 101);
            this.picFinalizadas.Name = "picFinalizadas";
            this.picFinalizadas.Size = new System.Drawing.Size(100, 50);
            this.picFinalizadas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFinalizadas.TabIndex = 9;
            this.picFinalizadas.TabStop = false;
            this.picFinalizadas.Click += new System.EventHandler(this.picFinalizadas_Click);
            // 
            // lblFinalizadas
            // 
            this.lblFinalizadas.AutoSize = true;
            this.lblFinalizadas.Location = new System.Drawing.Point(12, 154);
            this.lblFinalizadas.Name = "lblFinalizadas";
            this.lblFinalizadas.Size = new System.Drawing.Size(90, 17);
            this.lblFinalizadas.TabIndex = 8;
            this.lblFinalizadas.Text = "Finalizadas";
            // 
            // gpbContas
            // 
            this.gpbContas.BackColor = System.Drawing.Color.Transparent;
            this.gpbContas.Controls.Add(this.picCheque);
            this.gpbContas.Controls.Add(this.lblCheques);
            this.gpbContas.Controls.Add(this.picConsultaContas);
            this.gpbContas.Controls.Add(this.lblConsultaContas);
            this.gpbContas.Controls.Add(this.picaReceber);
            this.gpbContas.Controls.Add(this.lblaReceber);
            this.gpbContas.Controls.Add(this.picaPagar);
            this.gpbContas.Controls.Add(this.lblaPagar);
            this.gpbContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbContas.Location = new System.Drawing.Point(502, 35);
            this.gpbContas.Name = "gpbContas";
            this.gpbContas.Size = new System.Drawing.Size(112, 343);
            this.gpbContas.TabIndex = 16;
            this.gpbContas.TabStop = false;
            this.gpbContas.Text = "Contas";
            // 
            // picCheque
            // 
            this.picCheque.Image = global::UIWindows.Properties.Resources.Cheque1;
            this.picCheque.Location = new System.Drawing.Point(6, 180);
            this.picCheque.Name = "picCheque";
            this.picCheque.Size = new System.Drawing.Size(100, 50);
            this.picCheque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCheque.TabIndex = 25;
            this.picCheque.TabStop = false;
            this.picCheque.Click += new System.EventHandler(this.picCheque_Click);
            // 
            // lblCheques
            // 
            this.lblCheques.AutoSize = true;
            this.lblCheques.Location = new System.Drawing.Point(18, 233);
            this.lblCheques.Name = "lblCheques";
            this.lblCheques.Size = new System.Drawing.Size(71, 17);
            this.lblCheques.TabIndex = 24;
            this.lblCheques.Text = "Cheques";
            // 
            // picConsultaContas
            // 
            this.picConsultaContas.Image = global::UIWindows.Properties.Resources.Budget_Search;
            this.picConsultaContas.Location = new System.Drawing.Point(6, 260);
            this.picConsultaContas.Name = "picConsultaContas";
            this.picConsultaContas.Size = new System.Drawing.Size(100, 50);
            this.picConsultaContas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConsultaContas.TabIndex = 23;
            this.picConsultaContas.TabStop = false;
            this.picConsultaContas.Click += new System.EventHandler(this.picConsultaContas_Click);
            // 
            // lblConsultaContas
            // 
            this.lblConsultaContas.AutoSize = true;
            this.lblConsultaContas.Location = new System.Drawing.Point(18, 313);
            this.lblConsultaContas.Name = "lblConsultaContas";
            this.lblConsultaContas.Size = new System.Drawing.Size(79, 17);
            this.lblConsultaContas.TabIndex = 22;
            this.lblConsultaContas.Text = "Consultas";
            // 
            // picaReceber
            // 
            this.picaReceber.Image = global::UIWindows.Properties.Resources.Receive;
            this.picaReceber.Location = new System.Drawing.Point(6, 25);
            this.picaReceber.Name = "picaReceber";
            this.picaReceber.Size = new System.Drawing.Size(100, 50);
            this.picaReceber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picaReceber.TabIndex = 1;
            this.picaReceber.TabStop = false;
            this.picaReceber.Click += new System.EventHandler(this.picaReceber_Click);
            // 
            // lblaReceber
            // 
            this.lblaReceber.AutoSize = true;
            this.lblaReceber.Location = new System.Drawing.Point(15, 78);
            this.lblaReceber.Name = "lblaReceber";
            this.lblaReceber.Size = new System.Drawing.Size(84, 17);
            this.lblaReceber.TabIndex = 10;
            this.lblaReceber.Text = "A Receber";
            // 
            // picaPagar
            // 
            this.picaPagar.Image = global::UIWindows.Properties.Resources.Payable;
            this.picaPagar.Location = new System.Drawing.Point(6, 101);
            this.picaPagar.Name = "picaPagar";
            this.picaPagar.Size = new System.Drawing.Size(100, 50);
            this.picaPagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picaPagar.TabIndex = 9;
            this.picaPagar.TabStop = false;
            this.picaPagar.Click += new System.EventHandler(this.picaPagar_Click);
            // 
            // lblaPagar
            // 
            this.lblaPagar.AutoSize = true;
            this.lblaPagar.Location = new System.Drawing.Point(24, 154);
            this.lblaPagar.Name = "lblaPagar";
            this.lblaPagar.Size = new System.Drawing.Size(66, 17);
            this.lblaPagar.TabIndex = 8;
            this.lblaPagar.Text = "A Pagar";
            // 
            // gpbCaixa
            // 
            this.gpbCaixa.BackColor = System.Drawing.Color.Transparent;
            this.gpbCaixa.Controls.Add(this.picGeral);
            this.gpbCaixa.Controls.Add(this.lblGeral);
            this.gpbCaixa.Controls.Add(this.picEntradas);
            this.gpbCaixa.Controls.Add(this.lblEntradas);
            this.gpbCaixa.Controls.Add(this.picSaidas);
            this.gpbCaixa.Controls.Add(this.lblSaidas);
            this.gpbCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCaixa.Location = new System.Drawing.Point(620, 35);
            this.gpbCaixa.Name = "gpbCaixa";
            this.gpbCaixa.Size = new System.Drawing.Size(112, 255);
            this.gpbCaixa.TabIndex = 17;
            this.gpbCaixa.TabStop = false;
            this.gpbCaixa.Text = "Caixa";
            // 
            // picGeral
            // 
            this.picGeral.Image = global::UIWindows.Properties.Resources.General1;
            this.picGeral.Location = new System.Drawing.Point(6, 177);
            this.picGeral.Name = "picGeral";
            this.picGeral.Size = new System.Drawing.Size(100, 50);
            this.picGeral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGeral.TabIndex = 12;
            this.picGeral.TabStop = false;
            this.picGeral.Click += new System.EventHandler(this.picGeral_Click);
            // 
            // lblGeral
            // 
            this.lblGeral.AutoSize = true;
            this.lblGeral.Location = new System.Drawing.Point(34, 230);
            this.lblGeral.Name = "lblGeral";
            this.lblGeral.Size = new System.Drawing.Size(48, 17);
            this.lblGeral.TabIndex = 11;
            this.lblGeral.Text = "Geral";
            // 
            // picEntradas
            // 
            this.picEntradas.Image = global::UIWindows.Properties.Resources.Enter_Money;
            this.picEntradas.Location = new System.Drawing.Point(6, 25);
            this.picEntradas.Name = "picEntradas";
            this.picEntradas.Size = new System.Drawing.Size(100, 50);
            this.picEntradas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEntradas.TabIndex = 1;
            this.picEntradas.TabStop = false;
            this.picEntradas.Click += new System.EventHandler(this.picEntradas_Click);
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Location = new System.Drawing.Point(20, 78);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(73, 17);
            this.lblEntradas.TabIndex = 10;
            this.lblEntradas.Text = "Entradas";
            // 
            // picSaidas
            // 
            this.picSaidas.Image = global::UIWindows.Properties.Resources.Out_Money;
            this.picSaidas.Location = new System.Drawing.Point(6, 101);
            this.picSaidas.Name = "picSaidas";
            this.picSaidas.Size = new System.Drawing.Size(100, 50);
            this.picSaidas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSaidas.TabIndex = 9;
            this.picSaidas.TabStop = false;
            this.picSaidas.Click += new System.EventHandler(this.picSaidas_Click);
            // 
            // lblSaidas
            // 
            this.lblSaidas.AutoSize = true;
            this.lblSaidas.Location = new System.Drawing.Point(27, 154);
            this.lblSaidas.Name = "lblSaidas";
            this.lblSaidas.Size = new System.Drawing.Size(57, 17);
            this.lblSaidas.TabIndex = 8;
            this.lblSaidas.Text = "Saídas";
            // 
            // gpbRelatorios
            // 
            this.gpbRelatorios.BackColor = System.Drawing.Color.Transparent;
            this.gpbRelatorios.Controls.Add(this.label1);
            this.gpbRelatorios.Controls.Add(this.lblRelCaixaGeral);
            this.gpbRelatorios.Controls.Add(this.lblRelCheques);
            this.gpbRelatorios.Controls.Add(this.picRelCaixaGeral);
            this.gpbRelatorios.Controls.Add(this.picRelCaixa);
            this.gpbRelatorios.Controls.Add(this.picRelCheques);
            this.gpbRelatorios.Controls.Add(this.lblRelEntregas);
            this.gpbRelatorios.Controls.Add(this.lblRelOS);
            this.gpbRelatorios.Controls.Add(this.picRelEntregas);
            this.gpbRelatorios.Controls.Add(this.picRelOrcamentos);
            this.gpbRelatorios.Controls.Add(this.lblRelOrcamentos);
            this.gpbRelatorios.Controls.Add(this.picRelOS);
            this.gpbRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRelatorios.Location = new System.Drawing.Point(738, 35);
            this.gpbRelatorios.Name = "gpbRelatorios";
            this.gpbRelatorios.Size = new System.Drawing.Size(218, 255);
            this.gpbRelatorios.TabIndex = 18;
            this.gpbRelatorios.TabStop = false;
            this.gpbRelatorios.Text = "Relatórios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Contas";
            // 
            // lblRelCaixaGeral
            // 
            this.lblRelCaixaGeral.AutoSize = true;
            this.lblRelCaixaGeral.Location = new System.Drawing.Point(117, 79);
            this.lblRelCaixaGeral.Name = "lblRelCaixaGeral";
            this.lblRelCaixaGeral.Size = new System.Drawing.Size(92, 17);
            this.lblRelCaixaGeral.TabIndex = 19;
            this.lblRelCaixaGeral.Text = "Caixa Geral";
            // 
            // lblRelCheques
            // 
            this.lblRelCheques.AutoSize = true;
            this.lblRelCheques.Location = new System.Drawing.Point(127, 154);
            this.lblRelCheques.Name = "lblRelCheques";
            this.lblRelCheques.Size = new System.Drawing.Size(71, 17);
            this.lblRelCheques.TabIndex = 18;
            this.lblRelCheques.Text = "Cheques";
            // 
            // picRelCaixaGeral
            // 
            this.picRelCaixaGeral.Image = global::UIWindows.Properties.Resources.Report_General;
            this.picRelCaixaGeral.Location = new System.Drawing.Point(112, 177);
            this.picRelCaixaGeral.Name = "picRelCaixaGeral";
            this.picRelCaixaGeral.Size = new System.Drawing.Size(100, 50);
            this.picRelCaixaGeral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRelCaixaGeral.TabIndex = 17;
            this.picRelCaixaGeral.TabStop = false;
            this.picRelCaixaGeral.Click += new System.EventHandler(this.picRelContas_Click);
            // 
            // picRelCaixa
            // 
            this.picRelCaixa.Image = global::UIWindows.Properties.Resources.Report_Money;
            this.picRelCaixa.Location = new System.Drawing.Point(112, 25);
            this.picRelCaixa.Name = "picRelCaixa";
            this.picRelCaixa.Size = new System.Drawing.Size(100, 50);
            this.picRelCaixa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRelCaixa.TabIndex = 14;
            this.picRelCaixa.TabStop = false;
            this.picRelCaixa.Click += new System.EventHandler(this.picRelCaixa_Click);
            // 
            // picRelCheques
            // 
            this.picRelCheques.Image = global::UIWindows.Properties.Resources.Budget_Search;
            this.picRelCheques.Location = new System.Drawing.Point(112, 101);
            this.picRelCheques.Name = "picRelCheques";
            this.picRelCheques.Size = new System.Drawing.Size(100, 50);
            this.picRelCheques.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRelCheques.TabIndex = 15;
            this.picRelCheques.TabStop = false;
            this.picRelCheques.Click += new System.EventHandler(this.picRelCheques_Click);
            // 
            // lblRelEntregas
            // 
            this.lblRelEntregas.AutoSize = true;
            this.lblRelEntregas.Location = new System.Drawing.Point(20, 230);
            this.lblRelEntregas.Name = "lblRelEntregas";
            this.lblRelEntregas.Size = new System.Drawing.Size(73, 17);
            this.lblRelEntregas.TabIndex = 13;
            this.lblRelEntregas.Text = "Entregas";
            // 
            // lblRelOS
            // 
            this.lblRelOS.AutoSize = true;
            this.lblRelOS.Location = new System.Drawing.Point(13, 154);
            this.lblRelOS.Name = "lblRelOS";
            this.lblRelOS.Size = new System.Drawing.Size(92, 17);
            this.lblRelOS.TabIndex = 12;
            this.lblRelOS.Text = "O. Serviços";
            // 
            // picRelEntregas
            // 
            this.picRelEntregas.Image = global::UIWindows.Properties.Resources.Delivery;
            this.picRelEntregas.Location = new System.Drawing.Point(6, 177);
            this.picRelEntregas.Name = "picRelEntregas";
            this.picRelEntregas.Size = new System.Drawing.Size(100, 50);
            this.picRelEntregas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRelEntregas.TabIndex = 11;
            this.picRelEntregas.TabStop = false;
            this.picRelEntregas.Click += new System.EventHandler(this.picRelEntregas_Click);
            // 
            // picRelOrcamentos
            // 
            this.picRelOrcamentos.Image = global::UIWindows.Properties.Resources.Budget1;
            this.picRelOrcamentos.Location = new System.Drawing.Point(6, 25);
            this.picRelOrcamentos.Name = "picRelOrcamentos";
            this.picRelOrcamentos.Size = new System.Drawing.Size(100, 50);
            this.picRelOrcamentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRelOrcamentos.TabIndex = 1;
            this.picRelOrcamentos.TabStop = false;
            this.picRelOrcamentos.Click += new System.EventHandler(this.picRelOrcamentos_Click);
            // 
            // lblRelOrcamentos
            // 
            this.lblRelOrcamentos.AutoSize = true;
            this.lblRelOrcamentos.Location = new System.Drawing.Point(7, 78);
            this.lblRelOrcamentos.Name = "lblRelOrcamentos";
            this.lblRelOrcamentos.Size = new System.Drawing.Size(95, 17);
            this.lblRelOrcamentos.TabIndex = 10;
            this.lblRelOrcamentos.Text = "Orçamentos";
            // 
            // picRelOS
            // 
            this.picRelOS.Image = global::UIWindows.Properties.Resources.Report_OS;
            this.picRelOS.Location = new System.Drawing.Point(6, 101);
            this.picRelOS.Name = "picRelOS";
            this.picRelOS.Size = new System.Drawing.Size(100, 50);
            this.picRelOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRelOS.TabIndex = 9;
            this.picRelOS.TabStop = false;
            this.picRelOS.Click += new System.EventHandler(this.picRelOS_Click);
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.BackColor = System.Drawing.Color.Transparent;
            this.lblBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackup.Location = new System.Drawing.Point(871, 427);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(61, 17);
            this.lblBackup.TabIndex = 21;
            this.lblBackup.Text = "Backup";
            // 
            // lblLogado
            // 
            this.lblLogado.AutoSize = true;
            this.lblLogado.Location = new System.Drawing.Point(699, 4);
            this.lblLogado.Name = "lblLogado";
            this.lblLogado.Size = new System.Drawing.Size(37, 20);
            this.lblLogado.TabIndex = 26;
            this.lblLogado.Text = "Olá ";
            // 
            // picRestart
            // 
            this.picRestart.Image = global::UIWindows.Properties.Resources.if_121_14145;
            this.picRestart.Location = new System.Drawing.Point(937, 3);
            this.picRestart.Name = "picRestart";
            this.picRestart.Size = new System.Drawing.Size(31, 24);
            this.picRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picRestart.TabIndex = 27;
            this.picRestart.TabStop = false;
            this.picRestart.Click += new System.EventHandler(this.picRestart_Click);
            // 
            // picBackup
            // 
            this.picBackup.BackColor = System.Drawing.Color.Transparent;
            this.picBackup.Image = global::UIWindows.Properties.Resources.Backup;
            this.picBackup.Location = new System.Drawing.Point(850, 374);
            this.picBackup.Name = "picBackup";
            this.picBackup.Size = new System.Drawing.Size(100, 50);
            this.picBackup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBackup.TabIndex = 20;
            this.picBackup.TabStop = false;
            this.picBackup.Click += new System.EventHandler(this.picBackup_Click_1);
            // 
            // gpbOrcamentos
            // 
            this.gpbOrcamentos.BackColor = System.Drawing.Color.Transparent;
            this.gpbOrcamentos.Controls.Add(this.picInclusao);
            this.gpbOrcamentos.Controls.Add(this.lblInclusao);
            this.gpbOrcamentos.Controls.Add(this.picConsulta);
            this.gpbOrcamentos.Controls.Add(this.lblConsulta);
            this.gpbOrcamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOrcamentos.Location = new System.Drawing.Point(130, 35);
            this.gpbOrcamentos.Name = "gpbOrcamentos";
            this.gpbOrcamentos.Size = new System.Drawing.Size(112, 182);
            this.gpbOrcamentos.TabIndex = 13;
            this.gpbOrcamentos.TabStop = false;
            this.gpbOrcamentos.Text = "Orcamentos";
            // 
            // picInclusao
            // 
            this.picInclusao.Image = global::UIWindows.Properties.Resources.Budget1;
            this.picInclusao.Location = new System.Drawing.Point(6, 25);
            this.picInclusao.Name = "picInclusao";
            this.picInclusao.Size = new System.Drawing.Size(100, 50);
            this.picInclusao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInclusao.TabIndex = 1;
            this.picInclusao.TabStop = false;
            this.picInclusao.Click += new System.EventHandler(this.picInclusao_Click);
            // 
            // lblInclusao
            // 
            this.lblInclusao.AutoSize = true;
            this.lblInclusao.Location = new System.Drawing.Point(21, 78);
            this.lblInclusao.Name = "lblInclusao";
            this.lblInclusao.Size = new System.Drawing.Size(68, 17);
            this.lblInclusao.TabIndex = 10;
            this.lblInclusao.Text = "Inclusão";
            // 
            // picConsulta
            // 
            this.picConsulta.Image = global::UIWindows.Properties.Resources.Budget_Search;
            this.picConsulta.Location = new System.Drawing.Point(6, 101);
            this.picConsulta.Name = "picConsulta";
            this.picConsulta.Size = new System.Drawing.Size(100, 50);
            this.picConsulta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConsulta.TabIndex = 9;
            this.picConsulta.TabStop = false;
            this.picConsulta.Click += new System.EventHandler(this.picConsulta_Click);
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(18, 154);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(79, 17);
            this.lblConsulta.TabIndex = 8;
            this.lblConsulta.Text = "Consultas";
            // 
            // gpbCadastros
            // 
            this.gpbCadastros.BackColor = System.Drawing.Color.Transparent;
            this.gpbCadastros.Controls.Add(this.picClient);
            this.gpbCadastros.Controls.Add(this.lblUsuarios);
            this.gpbCadastros.Controls.Add(this.picUsuarios);
            this.gpbCadastros.Controls.Add(this.lblClientes);
            this.gpbCadastros.Controls.Add(this.lblServicos);
            this.gpbCadastros.Controls.Add(this.picFornecedor);
            this.gpbCadastros.Controls.Add(this.picServicos);
            this.gpbCadastros.Controls.Add(this.lblFornecedores);
            this.gpbCadastros.Controls.Add(this.lblProdutos);
            this.gpbCadastros.Controls.Add(this.picProdutos);
            this.gpbCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCadastros.Location = new System.Drawing.Point(12, 35);
            this.gpbCadastros.Name = "gpbCadastros";
            this.gpbCadastros.Size = new System.Drawing.Size(112, 413);
            this.gpbCadastros.TabIndex = 12;
            this.gpbCadastros.TabStop = false;
            this.gpbCadastros.Text = "Cadastros";
            // 
            // picClient
            // 
            this.picClient.Image = global::UIWindows.Properties.Resources.Client3;
            this.picClient.Location = new System.Drawing.Point(6, 25);
            this.picClient.Name = "picClient";
            this.picClient.Size = new System.Drawing.Size(100, 50);
            this.picClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClient.TabIndex = 1;
            this.picClient.TabStop = false;
            this.picClient.Click += new System.EventHandler(this.picClient_Click);
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Location = new System.Drawing.Point(23, 382);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(72, 17);
            this.lblUsuarios.TabIndex = 11;
            this.lblUsuarios.Text = "Usuários";
            // 
            // picUsuarios
            // 
            this.picUsuarios.Image = global::UIWindows.Properties.Resources.User;
            this.picUsuarios.Location = new System.Drawing.Point(6, 329);
            this.picUsuarios.Name = "picUsuarios";
            this.picUsuarios.Size = new System.Drawing.Size(100, 50);
            this.picUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUsuarios.TabIndex = 3;
            this.picUsuarios.TabStop = false;
            this.picUsuarios.Click += new System.EventHandler(this.picUsuarios_Click);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Location = new System.Drawing.Point(21, 78);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(66, 17);
            this.lblClientes.TabIndex = 10;
            this.lblClientes.Text = "Clientes";
            // 
            // lblServicos
            // 
            this.lblServicos.AutoSize = true;
            this.lblServicos.Location = new System.Drawing.Point(23, 306);
            this.lblServicos.Name = "lblServicos";
            this.lblServicos.Size = new System.Drawing.Size(70, 17);
            this.lblServicos.TabIndex = 4;
            this.lblServicos.Text = "Serviços";
            // 
            // picFornecedor
            // 
            this.picFornecedor.Image = global::UIWindows.Properties.Resources.Provider;
            this.picFornecedor.Location = new System.Drawing.Point(6, 101);
            this.picFornecedor.Name = "picFornecedor";
            this.picFornecedor.Size = new System.Drawing.Size(100, 50);
            this.picFornecedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFornecedor.TabIndex = 9;
            this.picFornecedor.TabStop = false;
            this.picFornecedor.Click += new System.EventHandler(this.picFornecedor_Click);
            // 
            // picServicos
            // 
            this.picServicos.Image = global::UIWindows.Properties.Resources.Hand_Over;
            this.picServicos.Location = new System.Drawing.Point(6, 253);
            this.picServicos.Name = "picServicos";
            this.picServicos.Size = new System.Drawing.Size(100, 50);
            this.picServicos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picServicos.TabIndex = 5;
            this.picServicos.TabStop = false;
            this.picServicos.Click += new System.EventHandler(this.picServicos_Click);
            // 
            // lblFornecedores
            // 
            this.lblFornecedores.AutoSize = true;
            this.lblFornecedores.Location = new System.Drawing.Point(2, 154);
            this.lblFornecedores.Name = "lblFornecedores";
            this.lblFornecedores.Size = new System.Drawing.Size(108, 17);
            this.lblFornecedores.TabIndex = 8;
            this.lblFornecedores.Text = "Fornecedores";
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Location = new System.Drawing.Point(21, 230);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(73, 17);
            this.lblProdutos.TabIndex = 6;
            this.lblProdutos.Text = "Produtos";
            // 
            // picProdutos
            // 
            this.picProdutos.Image = global::UIWindows.Properties.Resources.Products;
            this.picProdutos.Location = new System.Drawing.Point(6, 177);
            this.picProdutos.Name = "picProdutos";
            this.picProdutos.Size = new System.Drawing.Size(100, 50);
            this.picProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProdutos.TabIndex = 7;
            this.picProdutos.TabStop = false;
            this.picProdutos.Click += new System.EventHandler(this.picProdutos_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::UIWindows.Properties.Resources.LogoTransparent80Percent;
            this.ClientSize = new System.Drawing.Size(966, 463);
            this.Controls.Add(this.picRestart);
            this.Controls.Add(this.lblLogado);
            this.Controls.Add(this.lblBackup);
            this.Controls.Add(this.picBackup);
            this.Controls.Add(this.gpbRelatorios);
            this.Controls.Add(this.gpbCaixa);
            this.Controls.Add(this.gpbContas);
            this.Controls.Add(this.gpbEntregas);
            this.Controls.Add(this.gpbOSContratos);
            this.Controls.Add(this.gpbOrcamentos);
            this.Controls.Add(this.gpbCadastros);
            this.Controls.Add(this.mnsMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InoxERP - Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipalForm_FormClosing);
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.gpbOSContratos.ResumeLayout(false);
            this.gpbOSContratos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOrdemServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContratos)).EndInit();
            this.gpbEntregas.ResumeLayout(false);
            this.gpbEntregas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAndamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinalizadas)).EndInit();
            this.gpbContas.ResumeLayout(false);
            this.gpbContas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConsultaContas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picaReceber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picaPagar)).EndInit();
            this.gpbCaixa.ResumeLayout(false);
            this.gpbCaixa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGeral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaidas)).EndInit();
            this.gpbRelatorios.ResumeLayout(false);
            this.gpbRelatorios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRelCaixaGeral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRelCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRelCheques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRelEntregas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRelOrcamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRelOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackup)).EndInit();
            this.gpbOrcamentos.ResumeLayout(false);
            this.gpbOrcamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInclusao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConsulta)).EndInit();
            this.gpbCadastros.ResumeLayout(false);
            this.gpbCadastros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProdutos)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem chequeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dinheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aReceberToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chequesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratosToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpbOrcamentos;
        private System.Windows.Forms.PictureBox picInclusao;
        private System.Windows.Forms.Label lblInclusao;
        private System.Windows.Forms.PictureBox picConsulta;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.GroupBox gpbOSContratos;
        private System.Windows.Forms.PictureBox picOrdemServico;
        private System.Windows.Forms.Label lblConsultaOS;
        private System.Windows.Forms.PictureBox picContratos;
        private System.Windows.Forms.Label lblContratos;
        private System.Windows.Forms.GroupBox gpbEntregas;
        private System.Windows.Forms.PictureBox picAndamento;
        private System.Windows.Forms.Label lblAndamento;
        private System.Windows.Forms.PictureBox picFinalizadas;
        private System.Windows.Forms.Label lblFinalizadas;
        private System.Windows.Forms.GroupBox gpbContas;
        private System.Windows.Forms.PictureBox picaReceber;
        private System.Windows.Forms.Label lblaReceber;
        private System.Windows.Forms.PictureBox picaPagar;
        private System.Windows.Forms.Label lblaPagar;
        private System.Windows.Forms.GroupBox gpbCaixa;
        private System.Windows.Forms.PictureBox picGeral;
        private System.Windows.Forms.Label lblGeral;
        private System.Windows.Forms.PictureBox picEntradas;
        private System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.PictureBox picSaidas;
        private System.Windows.Forms.Label lblSaidas;
        private System.Windows.Forms.GroupBox gpbRelatorios;
        private System.Windows.Forms.PictureBox picRelEntregas;
        private System.Windows.Forms.PictureBox picRelOrcamentos;
        private System.Windows.Forms.PictureBox picRelOS;
        private System.Windows.Forms.Label lblRelEntregas;
        private System.Windows.Forms.Label lblRelOS;
        private System.Windows.Forms.Label lblRelOrcamentos;
        private System.Windows.Forms.Label lblRelCaixaGeral;
        private System.Windows.Forms.Label lblRelCheques;
        private System.Windows.Forms.PictureBox picRelCaixaGeral;
        private System.Windows.Forms.PictureBox picRelCaixa;
        private System.Windows.Forms.PictureBox picRelCheques;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.PictureBox picBackup;
        private System.Windows.Forms.PictureBox picConsultaContas;
        private System.Windows.Forms.Label lblConsultaContas;
        private System.Windows.Forms.PictureBox picCheque;
        private System.Windows.Forms.Label lblCheques;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.Label lblLogado;
        private System.Windows.Forms.PictureBox picRestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbCadastros;
        private System.Windows.Forms.PictureBox picClient;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.PictureBox picUsuarios;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblServicos;
        private System.Windows.Forms.PictureBox picFornecedor;
        private System.Windows.Forms.PictureBox picServicos;
        private System.Windows.Forms.Label lblFornecedores;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.PictureBox picProdutos;
    }
}

