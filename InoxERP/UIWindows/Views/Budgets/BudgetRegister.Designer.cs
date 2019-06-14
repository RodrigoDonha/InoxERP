namespace InoxERP.UI_Windows_Forms
{
    partial class frmBudgetsRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBudgetsRegister));
            this.btnProcurar = new System.Windows.Forms.Button();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.radIndustrial = new System.Windows.Forms.RadioButton();
            this.radResidencial = new System.Windows.Forms.RadioButton();
            this.radComercial = new System.Windows.Forms.RadioButton();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.grpProdutos_Servicos = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnServico = new System.Windows.Forms.Button();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblSubTotalValor = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.btnPeca = new System.Windows.Forms.Button();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.dAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.grpFormaPagto = new System.Windows.Forms.GroupBox();
            this.lblValorJuros = new System.Windows.Forms.Label();
            this.lblJuros = new System.Windows.Forms.Label();
            this.chkDinheiro = new System.Windows.Forms.CheckBox();
            this.chkCheque = new System.Windows.Forms.CheckBox();
            this.nudParcelas = new System.Windows.Forms.NumericUpDown();
            this.chkCombinar = new System.Windows.Forms.CheckBox();
            this.lblExibeValorTotalParcelado = new System.Windows.Forms.Label();
            this.lblValorTotalParcelado = new System.Windows.Forms.Label();
            this.lblValorPorParcela = new System.Windows.Forms.Label();
            this.lbExibeValorParcelado = new System.Windows.Forms.Label();
            this.lblParcela = new System.Windows.Forms.Label();
            this.lblContinuaJuros = new System.Windows.Forms.Label();
            this.txtPorcentJuros = new System.Windows.Forms.TextBox();
            this.chkJuros = new System.Windows.Forms.CheckBox();
            this.lblContinuaParcelamento = new System.Windows.Forms.Label();
            this.lblParcelamento = new System.Windows.Forms.Label();
            this.lblExibeValorDesconto = new System.Windows.Forms.Label();
            this.lblValorAVista = new System.Windows.Forms.Label();
            this.txtPorcentDescAVista = new System.Windows.Forms.TextBox();
            this.lblAVista = new System.Windows.Forms.Label();
            this.grpEntrega = new System.Windows.Forms.GroupBox();
            this.nudDias = new System.Windows.Forms.NumericUpDown();
            this.dtpDataPrevistaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDataPrevistaInicio = new System.Windows.Forms.Label();
            this.dtpDataPrevistaEntrega = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDataPrevistaEntrega = new System.Windows.Forms.Label();
            this.lblDiasPrevistosParaExecucao = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPrevisaoExecServ = new System.Windows.Forms.Label();
            this.lblValidadeOrcamento = new System.Windows.Forms.Label();
            this.dtpDataValidadeOrcamento = new System.Windows.Forms.DateTimePicker();
            this.btnCancelarOrcamento = new System.Windows.Forms.Button();
            this.btnGravarOrcamento = new System.Windows.Forms.Button();
            this.btnAprovar = new System.Windows.Forms.Button();
            this.grpPrazosFinalizacao = new System.Windows.Forms.GroupBox();
            this.lblTotalGeralValor = new System.Windows.Forms.Label();
            this.lblTotalGeral = new System.Windows.Forms.Label();
            this.rtfObservacoes = new System.Windows.Forms.RichTextBox();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.nudAnos = new System.Windows.Forms.NumericUpDown();
            this.lblAnos = new System.Windows.Forms.Label();
            this.lblTempoGarantia = new System.Windows.Forms.Label();
            this.grpCliente.SuspendLayout();
            this.grpProdutos_Servicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.grpFormaPagto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelas)).BeginInit();
            this.grpEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).BeginInit();
            this.grpPrazosFinalizacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcurar
            // 
            this.btnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Location = new System.Drawing.Point(8, 23);
            this.btnProcurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(122, 26);
            this.btnProcurar.TabIndex = 1;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.txtCargo);
            this.grpCliente.Controls.Add(this.lblCargo);
            this.grpCliente.Controls.Add(this.radIndustrial);
            this.grpCliente.Controls.Add(this.radResidencial);
            this.grpCliente.Controls.Add(this.radComercial);
            this.grpCliente.Controls.Add(this.txtEndereco);
            this.grpCliente.Controls.Add(this.txtTelefone);
            this.grpCliente.Controls.Add(this.txtNome);
            this.grpCliente.Controls.Add(this.lblTelefone);
            this.grpCliente.Controls.Add(this.lblEndereco);
            this.grpCliente.Controls.Add(this.btnProcurar);
            this.grpCliente.Controls.Add(this.lblNome);
            this.grpCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCliente.Location = new System.Drawing.Point(9, 5);
            this.grpCliente.Margin = new System.Windows.Forms.Padding(2);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Padding = new System.Windows.Forms.Padding(2);
            this.grpCliente.Size = new System.Drawing.Size(570, 170);
            this.grpCliente.TabIndex = 1;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Cliente";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(359, 126);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCargo.MaxLength = 100;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(195, 26);
            this.txtCargo.TabIndex = 8;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(301, 131);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(54, 17);
            this.lblCargo.TabIndex = 18;
            this.lblCargo.Text = "Cargo: ";
            this.lblCargo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radIndustrial
            // 
            this.radIndustrial.AutoSize = true;
            this.radIndustrial.Location = new System.Drawing.Point(452, 24);
            this.radIndustrial.Name = "radIndustrial";
            this.radIndustrial.Size = new System.Drawing.Size(102, 24);
            this.radIndustrial.TabIndex = 4;
            this.radIndustrial.Text = "Industrial";
            this.radIndustrial.UseVisualStyleBackColor = true;
            // 
            // radResidencial
            // 
            this.radResidencial.AutoSize = true;
            this.radResidencial.Location = new System.Drawing.Point(304, 25);
            this.radResidencial.Name = "radResidencial";
            this.radResidencial.Size = new System.Drawing.Size(120, 24);
            this.radResidencial.TabIndex = 3;
            this.radResidencial.Text = "Residêncial";
            this.radResidencial.UseVisualStyleBackColor = true;
            // 
            // radComercial
            // 
            this.radComercial.AutoSize = true;
            this.radComercial.Checked = true;
            this.radComercial.Location = new System.Drawing.Point(169, 25);
            this.radComercial.Name = "radComercial";
            this.radComercial.Size = new System.Drawing.Size(106, 24);
            this.radComercial.TabIndex = 2;
            this.radComercial.TabStop = true;
            this.radComercial.Text = "Comercial";
            this.radComercial.UseVisualStyleBackColor = true;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(76, 93);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(478, 26);
            this.txtEndereco.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(76, 126);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefone.MaxLength = 14;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(199, 26);
            this.txtTelefone.TabIndex = 7;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validationEntriesPhones);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(76, 59);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(478, 26);
            this.txtNome.TabIndex = 5;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(4, 131);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(68, 17);
            this.lblTelefone.TabIndex = 9;
            this.lblTelefone.Text = "Telefone:";
            this.lblTelefone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(4, 96);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(73, 17);
            this.lblEndereco.TabIndex = 8;
            this.lblEndereco.Text = "Endereço:";
            this.lblEndereco.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(4, 64);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpProdutos_Servicos
            // 
            this.grpProdutos_Servicos.Controls.Add(this.btnExcluir);
            this.grpProdutos_Servicos.Controls.Add(this.btnServico);
            this.grpProdutos_Servicos.Controls.Add(this.lblConsultar);
            this.grpProdutos_Servicos.Controls.Add(this.txtQuantidade);
            this.grpProdutos_Servicos.Controls.Add(this.lblSubTotalValor);
            this.grpProdutos_Servicos.Controls.Add(this.lblSubTotal);
            this.grpProdutos_Servicos.Controls.Add(this.btnPeca);
            this.grpProdutos_Servicos.Controls.Add(this.dgvItens);
            this.grpProdutos_Servicos.Controls.Add(this.btnAdicionar);
            this.grpProdutos_Servicos.Controls.Add(this.lblValorTotal);
            this.grpProdutos_Servicos.Controls.Add(this.txtValorTotal);
            this.grpProdutos_Servicos.Controls.Add(this.txtValorUnitario);
            this.grpProdutos_Servicos.Controls.Add(this.lblValorUnitario);
            this.grpProdutos_Servicos.Controls.Add(this.lblDescricao);
            this.grpProdutos_Servicos.Controls.Add(this.txtDescricao);
            this.grpProdutos_Servicos.Controls.Add(this.lblQuantidade);
            this.grpProdutos_Servicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProdutos_Servicos.Location = new System.Drawing.Point(9, 176);
            this.grpProdutos_Servicos.Margin = new System.Windows.Forms.Padding(2);
            this.grpProdutos_Servicos.Name = "grpProdutos_Servicos";
            this.grpProdutos_Servicos.Padding = new System.Windows.Forms.Padding(2);
            this.grpProdutos_Servicos.Size = new System.Drawing.Size(570, 386);
            this.grpProdutos_Servicos.TabIndex = 2;
            this.grpProdutos_Servicos.TabStop = false;
            this.grpProdutos_Servicos.Text = "Produtos / Serviços";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(8, 358);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(104, 25);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir Item";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnServico
            // 
            this.btnServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServico.Location = new System.Drawing.Point(484, 12);
            this.btnServico.Margin = new System.Windows.Forms.Padding(2);
            this.btnServico.Name = "btnServico";
            this.btnServico.Size = new System.Drawing.Size(70, 26);
            this.btnServico.TabIndex = 16;
            this.btnServico.Text = "Serviços";
            this.btnServico.UseVisualStyleBackColor = true;
            this.btnServico.Click += new System.EventHandler(this.btnServico_Click);
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultar.Location = new System.Drawing.Point(312, 16);
            this.lblConsultar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(74, 17);
            this.lblConsultar.TabIndex = 23;
            this.lblConsultar.Text = "Consultas:";
            this.lblConsultar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(9, 67);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantidade.MaxLength = 99;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(50, 26);
            this.txtQuantidade.TabIndex = 9;
            this.txtQuantidade.Tag = "";
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged_1);
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validationEntriesNumerics);
            // 
            // lblSubTotalValor
            // 
            this.lblSubTotalValor.AutoSize = true;
            this.lblSubTotalValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalValor.Location = new System.Drawing.Point(457, 360);
            this.lblSubTotalValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTotalValor.Name = "lblSubTotalValor";
            this.lblSubTotalValor.Size = new System.Drawing.Size(19, 20);
            this.lblSubTotalValor.TabIndex = 21;
            this.lblSubTotalValor.Text = "0";
            this.lblSubTotalValor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSubTotalValor.TextChanged += new System.EventHandler(this.lblSubTotalValor_TextChanged);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(356, 359);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(97, 20);
            this.lblSubTotal.TabIndex = 20;
            this.lblSubTotal.Text = "Sub-Total: ";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPeca
            // 
            this.btnPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeca.Location = new System.Drawing.Point(399, 12);
            this.btnPeca.Margin = new System.Windows.Forms.Padding(2);
            this.btnPeca.Name = "btnPeca";
            this.btnPeca.Size = new System.Drawing.Size(70, 25);
            this.btnPeca.TabIndex = 15;
            this.btnPeca.Text = "Peças";
            this.btnPeca.UseVisualStyleBackColor = true;
            this.btnPeca.Click += new System.EventHandler(this.btnPeca_Click);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dAmount,
            this.sDescription,
            this.dPrice,
            this.dTotal});
            this.dgvItens.Location = new System.Drawing.Point(8, 99);
            this.dgvItens.Margin = new System.Windows.Forms.Padding(2);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowTemplate.Height = 24;
            this.dgvItens.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(546, 255);
            this.dgvItens.TabIndex = 18;
            this.dgvItens.TabStop = false;
            this.dgvItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellClick);
            // 
            // dAmount
            // 
            this.dAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dAmount.HeaderText = "Quantidade";
            this.dAmount.Name = "dAmount";
            this.dAmount.ReadOnly = true;
            this.dAmount.Width = 127;
            // 
            // sDescription
            // 
            this.sDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sDescription.HeaderText = "Descrição";
            this.sDescription.Name = "sDescription";
            this.sDescription.ReadOnly = true;
            // 
            // dPrice
            // 
            this.dPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dPrice.HeaderText = "Valor UN";
            this.dPrice.Name = "dPrice";
            this.dPrice.ReadOnly = true;
            this.dPrice.Width = 106;
            // 
            // dTotal
            // 
            this.dTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dTotal.HeaderText = "Total";
            this.dTotal.Name = "dTotal";
            this.dTotal.ReadOnly = true;
            this.dTotal.Width = 74;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(469, 67);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(85, 26);
            this.btnAdicionar.TabIndex = 13;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(389, 49);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(77, 17);
            this.lblValorTotal.TabIndex = 17;
            this.lblValorTotal.Text = "Valor Total";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(389, 67);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorTotal.MaxLength = 18;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(76, 26);
            this.txtValorTotal.TabIndex = 12;
            this.txtValorTotal.Tag = "";
            this.txtValorTotal.Text = "0";
            this.txtValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validationEntriesNumerics);
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(305, 67);
            this.txtValorUnitario.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorUnitario.MaxLength = 18;
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(81, 26);
            this.txtValorUnitario.TabIndex = 11;
            this.txtValorUnitario.Tag = "";
            this.txtValorUnitario.TextChanged += new System.EventHandler(this.txtValorUnitario_TextChanged);
            this.txtValorUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validationEntriesNumerics);
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorUnitario.Location = new System.Drawing.Point(299, 49);
            this.lblValorUnitario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(94, 17);
            this.lblValorUnitario.TabIndex = 14;
            this.lblValorUnitario.Text = "Valor Unitário";
            this.lblValorUnitario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(139, 49);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(71, 17);
            this.lblDescricao.TabIndex = 13;
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(63, 67);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(238, 26);
            this.txtDescricao.TabIndex = 10;
            this.txtDescricao.Tag = "";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(10, 48);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(51, 17);
            this.lblQuantidade.TabIndex = 11;
            this.lblQuantidade.Text = "Quant.";
            this.lblQuantidade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpFormaPagto
            // 
            this.grpFormaPagto.Controls.Add(this.lblValorJuros);
            this.grpFormaPagto.Controls.Add(this.lblJuros);
            this.grpFormaPagto.Controls.Add(this.chkDinheiro);
            this.grpFormaPagto.Controls.Add(this.chkCheque);
            this.grpFormaPagto.Controls.Add(this.nudParcelas);
            this.grpFormaPagto.Controls.Add(this.chkCombinar);
            this.grpFormaPagto.Controls.Add(this.lblExibeValorTotalParcelado);
            this.grpFormaPagto.Controls.Add(this.lblValorTotalParcelado);
            this.grpFormaPagto.Controls.Add(this.lblValorPorParcela);
            this.grpFormaPagto.Controls.Add(this.lbExibeValorParcelado);
            this.grpFormaPagto.Controls.Add(this.lblParcela);
            this.grpFormaPagto.Controls.Add(this.lblContinuaJuros);
            this.grpFormaPagto.Controls.Add(this.txtPorcentJuros);
            this.grpFormaPagto.Controls.Add(this.chkJuros);
            this.grpFormaPagto.Controls.Add(this.lblContinuaParcelamento);
            this.grpFormaPagto.Controls.Add(this.lblParcelamento);
            this.grpFormaPagto.Controls.Add(this.lblExibeValorDesconto);
            this.grpFormaPagto.Controls.Add(this.lblValorAVista);
            this.grpFormaPagto.Controls.Add(this.txtPorcentDescAVista);
            this.grpFormaPagto.Controls.Add(this.lblAVista);
            this.grpFormaPagto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFormaPagto.Location = new System.Drawing.Point(586, 5);
            this.grpFormaPagto.Margin = new System.Windows.Forms.Padding(2);
            this.grpFormaPagto.Name = "grpFormaPagto";
            this.grpFormaPagto.Padding = new System.Windows.Forms.Padding(2);
            this.grpFormaPagto.Size = new System.Drawing.Size(543, 192);
            this.grpFormaPagto.TabIndex = 3;
            this.grpFormaPagto.TabStop = false;
            this.grpFormaPagto.Text = "Forma de Pagamento";
            // 
            // lblValorJuros
            // 
            this.lblValorJuros.AutoSize = true;
            this.lblValorJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorJuros.Location = new System.Drawing.Point(436, 131);
            this.lblValorJuros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorJuros.Name = "lblValorJuros";
            this.lblValorJuros.Size = new System.Drawing.Size(16, 17);
            this.lblValorJuros.TabIndex = 25;
            this.lblValorJuros.Text = "0";
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuros.Location = new System.Drawing.Point(299, 131);
            this.lblJuros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(104, 17);
            this.lblJuros.TabIndex = 24;
            this.lblJuros.Text = "Valor do Juros:";
            // 
            // chkDinheiro
            // 
            this.chkDinheiro.AutoSize = true;
            this.chkDinheiro.Location = new System.Drawing.Point(270, 23);
            this.chkDinheiro.Name = "chkDinheiro";
            this.chkDinheiro.Size = new System.Drawing.Size(95, 24);
            this.chkDinheiro.TabIndex = 19;
            this.chkDinheiro.Text = "Dinheiro";
            this.chkDinheiro.UseVisualStyleBackColor = true;
            // 
            // chkCheque
            // 
            this.chkCheque.AutoSize = true;
            this.chkCheque.Location = new System.Drawing.Point(155, 23);
            this.chkCheque.Name = "chkCheque";
            this.chkCheque.Size = new System.Drawing.Size(90, 24);
            this.chkCheque.TabIndex = 18;
            this.chkCheque.Text = "Cheque";
            this.chkCheque.UseVisualStyleBackColor = true;
            // 
            // nudParcelas
            // 
            this.nudParcelas.Enabled = false;
            this.nudParcelas.Location = new System.Drawing.Point(156, 92);
            this.nudParcelas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudParcelas.Name = "nudParcelas";
            this.nudParcelas.Size = new System.Drawing.Size(76, 26);
            this.nudParcelas.TabIndex = 21;
            this.nudParcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudParcelas.ValueChanged += new System.EventHandler(this.nudParcelas_ValueChanged);
            // 
            // chkCombinar
            // 
            this.chkCombinar.AutoSize = true;
            this.chkCombinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCombinar.Location = new System.Drawing.Point(13, 25);
            this.chkCombinar.Name = "chkCombinar";
            this.chkCombinar.Size = new System.Drawing.Size(121, 24);
            this.chkCombinar.TabIndex = 17;
            this.chkCombinar.Text = "A Combinar";
            this.chkCombinar.UseVisualStyleBackColor = true;
            this.chkCombinar.CheckedChanged += new System.EventHandler(this.chkCombinar_CheckedChanged);
            // 
            // lblExibeValorTotalParcelado
            // 
            this.lblExibeValorTotalParcelado.AutoSize = true;
            this.lblExibeValorTotalParcelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibeValorTotalParcelado.Location = new System.Drawing.Point(155, 165);
            this.lblExibeValorTotalParcelado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExibeValorTotalParcelado.Name = "lblExibeValorTotalParcelado";
            this.lblExibeValorTotalParcelado.Size = new System.Drawing.Size(16, 17);
            this.lblExibeValorTotalParcelado.TabIndex = 14;
            this.lblExibeValorTotalParcelado.Text = "0";
            // 
            // lblValorTotalParcelado
            // 
            this.lblValorTotalParcelado.AutoSize = true;
            this.lblValorTotalParcelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalParcelado.Location = new System.Drawing.Point(10, 165);
            this.lblValorTotalParcelado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorTotalParcelado.Name = "lblValorTotalParcelado";
            this.lblValorTotalParcelado.Size = new System.Drawing.Size(149, 17);
            this.lblValorTotalParcelado.TabIndex = 13;
            this.lblValorTotalParcelado.Text = "Valor Total Parcelado:";
            // 
            // lblValorPorParcela
            // 
            this.lblValorPorParcela.AutoSize = true;
            this.lblValorPorParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPorParcela.Location = new System.Drawing.Point(436, 96);
            this.lblValorPorParcela.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorPorParcela.Name = "lblValorPorParcela";
            this.lblValorPorParcela.Size = new System.Drawing.Size(16, 17);
            this.lblValorPorParcela.TabIndex = 12;
            this.lblValorPorParcela.Text = "0";
            // 
            // lbExibeValorParcelado
            // 
            this.lbExibeValorParcelado.AutoSize = true;
            this.lbExibeValorParcelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExibeValorParcelado.Location = new System.Drawing.Point(638, 64);
            this.lbExibeValorParcelado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbExibeValorParcelado.Name = "lbExibeValorParcelado";
            this.lbExibeValorParcelado.Size = new System.Drawing.Size(188, 17);
            this.lbExibeValorParcelado.TabIndex = 11;
            this.lbExibeValorParcelado.Text = "Aqui exibe o valor Parcelado";
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcela.Location = new System.Drawing.Point(299, 96);
            this.lblParcela.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(117, 17);
            this.lblParcela.TabIndex = 10;
            this.lblParcela.Text = "Valor da Parcela:";
            // 
            // lblContinuaJuros
            // 
            this.lblContinuaJuros.AutoSize = true;
            this.lblContinuaJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinuaJuros.Location = new System.Drawing.Point(236, 131);
            this.lblContinuaJuros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContinuaJuros.Name = "lblContinuaJuros";
            this.lblContinuaJuros.Size = new System.Drawing.Size(48, 17);
            this.lblContinuaJuros.TabIndex = 9;
            this.lblContinuaJuros.Text = "% a.n.";
            // 
            // txtPorcentJuros
            // 
            this.txtPorcentJuros.Enabled = false;
            this.txtPorcentJuros.Location = new System.Drawing.Point(156, 126);
            this.txtPorcentJuros.Margin = new System.Windows.Forms.Padding(2);
            this.txtPorcentJuros.MaxLength = 18;
            this.txtPorcentJuros.Name = "txtPorcentJuros";
            this.txtPorcentJuros.Size = new System.Drawing.Size(76, 26);
            this.txtPorcentJuros.TabIndex = 23;
            this.txtPorcentJuros.Text = "0";
            this.txtPorcentJuros.TextChanged += new System.EventHandler(this.txtPorcentJuros_TextChanged);
            this.txtPorcentJuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validationEntriesNumerics);
            // 
            // chkJuros
            // 
            this.chkJuros.AutoSize = true;
            this.chkJuros.Enabled = false;
            this.chkJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJuros.Location = new System.Drawing.Point(13, 131);
            this.chkJuros.Margin = new System.Windows.Forms.Padding(2);
            this.chkJuros.Name = "chkJuros";
            this.chkJuros.Size = new System.Drawing.Size(112, 21);
            this.chkJuros.TabIndex = 22;
            this.chkJuros.Text = "com júros de:";
            this.chkJuros.UseVisualStyleBackColor = true;
            this.chkJuros.CheckedChanged += new System.EventHandler(this.chkJuros_CheckedChanged);
            // 
            // lblContinuaParcelamento
            // 
            this.lblContinuaParcelamento.AutoSize = true;
            this.lblContinuaParcelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinuaParcelamento.Location = new System.Drawing.Point(242, 96);
            this.lblContinuaParcelamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContinuaParcelamento.Name = "lblContinuaParcelamento";
            this.lblContinuaParcelamento.Size = new System.Drawing.Size(45, 17);
            this.lblContinuaParcelamento.TabIndex = 6;
            this.lblContinuaParcelamento.Text = "vezes";
            // 
            // lblParcelamento
            // 
            this.lblParcelamento.AutoSize = true;
            this.lblParcelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcelamento.Location = new System.Drawing.Point(10, 96);
            this.lblParcelamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParcelamento.Name = "lblParcelamento";
            this.lblParcelamento.Size = new System.Drawing.Size(146, 17);
            this.lblParcelamento.TabIndex = 4;
            this.lblParcelamento.Text = "Parcelamento em até:";
            // 
            // lblExibeValorDesconto
            // 
            this.lblExibeValorDesconto.AutoSize = true;
            this.lblExibeValorDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibeValorDesconto.Location = new System.Drawing.Point(436, 61);
            this.lblExibeValorDesconto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExibeValorDesconto.Name = "lblExibeValorDesconto";
            this.lblExibeValorDesconto.Size = new System.Drawing.Size(16, 17);
            this.lblExibeValorDesconto.TabIndex = 3;
            this.lblExibeValorDesconto.Text = "0";
            // 
            // lblValorAVista
            // 
            this.lblValorAVista.AutoSize = true;
            this.lblValorAVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAVista.Location = new System.Drawing.Point(299, 61);
            this.lblValorAVista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorAVista.Name = "lblValorAVista";
            this.lblValorAVista.Size = new System.Drawing.Size(133, 17);
            this.lblValorAVista.TabIndex = 2;
            this.lblValorAVista.Text = "Valor do Desconto: ";
            // 
            // txtPorcentDescAVista
            // 
            this.txtPorcentDescAVista.Enabled = false;
            this.txtPorcentDescAVista.Location = new System.Drawing.Point(155, 56);
            this.txtPorcentDescAVista.Margin = new System.Windows.Forms.Padding(2);
            this.txtPorcentDescAVista.MaxLength = 18;
            this.txtPorcentDescAVista.Name = "txtPorcentDescAVista";
            this.txtPorcentDescAVista.Size = new System.Drawing.Size(76, 26);
            this.txtPorcentDescAVista.TabIndex = 20;
            this.txtPorcentDescAVista.Text = "0";
            this.txtPorcentDescAVista.TextChanged += new System.EventHandler(this.txtPorcentDescAVista_TextChanged);
            this.txtPorcentDescAVista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validationEntriesNumerics);
            // 
            // lblAVista
            // 
            this.lblAVista.AutoSize = true;
            this.lblAVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAVista.Location = new System.Drawing.Point(10, 61);
            this.lblAVista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAVista.Name = "lblAVista";
            this.lblAVista.Size = new System.Drawing.Size(134, 17);
            this.lblAVista.TabIndex = 0;
            this.lblAVista.Text = "Desconto % Á vista:";
            // 
            // grpEntrega
            // 
            this.grpEntrega.Controls.Add(this.nudDias);
            this.grpEntrega.Controls.Add(this.dtpDataPrevistaInicio);
            this.grpEntrega.Controls.Add(this.lblDataPrevistaInicio);
            this.grpEntrega.Controls.Add(this.dtpDataPrevistaEntrega);
            this.grpEntrega.Controls.Add(this.label5);
            this.grpEntrega.Controls.Add(this.lblDataPrevistaEntrega);
            this.grpEntrega.Controls.Add(this.lblDiasPrevistosParaExecucao);
            this.grpEntrega.Controls.Add(this.label8);
            this.grpEntrega.Controls.Add(this.lblPrevisaoExecServ);
            this.grpEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEntrega.Location = new System.Drawing.Point(586, 203);
            this.grpEntrega.Margin = new System.Windows.Forms.Padding(2);
            this.grpEntrega.Name = "grpEntrega";
            this.grpEntrega.Padding = new System.Windows.Forms.Padding(2);
            this.grpEntrega.Size = new System.Drawing.Size(543, 143);
            this.grpEntrega.TabIndex = 4;
            this.grpEntrega.TabStop = false;
            this.grpEntrega.Text = "Entrega";
            // 
            // nudDias
            // 
            this.nudDias.Location = new System.Drawing.Point(158, 24);
            this.nudDias.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDias.Name = "nudDias";
            this.nudDias.Size = new System.Drawing.Size(76, 26);
            this.nudDias.TabIndex = 24;
            this.nudDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDias.ValueChanged += new System.EventHandler(this.nudDias_ValueChanged);
            // 
            // dtpDataPrevistaInicio
            // 
            this.dtpDataPrevistaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataPrevistaInicio.Location = new System.Drawing.Point(158, 67);
            this.dtpDataPrevistaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataPrevistaInicio.Name = "dtpDataPrevistaInicio";
            this.dtpDataPrevistaInicio.Size = new System.Drawing.Size(276, 23);
            this.dtpDataPrevistaInicio.TabIndex = 25;
            this.dtpDataPrevistaInicio.ValueChanged += new System.EventHandler(this.dtpDataPrevistaInicio_ValueChanged);
            // 
            // lblDataPrevistaInicio
            // 
            this.lblDataPrevistaInicio.AutoSize = true;
            this.lblDataPrevistaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPrevistaInicio.Location = new System.Drawing.Point(8, 72);
            this.lblDataPrevistaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataPrevistaInicio.Name = "lblDataPrevistaInicio";
            this.lblDataPrevistaInicio.Size = new System.Drawing.Size(123, 17);
            this.lblDataPrevistaInicio.TabIndex = 13;
            this.lblDataPrevistaInicio.Text = "Previsão de inicio:";
            // 
            // dtpDataPrevistaEntrega
            // 
            this.dtpDataPrevistaEntrega.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataPrevistaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataPrevistaEntrega.Location = new System.Drawing.Point(158, 106);
            this.dtpDataPrevistaEntrega.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataPrevistaEntrega.Name = "dtpDataPrevistaEntrega";
            this.dtpDataPrevistaEntrega.Size = new System.Drawing.Size(276, 23);
            this.dtpDataPrevistaEntrega.TabIndex = 26;
            this.dtpDataPrevistaEntrega.ValueChanged += new System.EventHandler(this.dtpDataPrevistaEntrega_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "vezes";
            // 
            // lblDataPrevistaEntrega
            // 
            this.lblDataPrevistaEntrega.AutoSize = true;
            this.lblDataPrevistaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPrevistaEntrega.Location = new System.Drawing.Point(10, 111);
            this.lblDataPrevistaEntrega.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataPrevistaEntrega.Name = "lblDataPrevistaEntrega";
            this.lblDataPrevistaEntrega.Size = new System.Drawing.Size(141, 17);
            this.lblDataPrevistaEntrega.TabIndex = 4;
            this.lblDataPrevistaEntrega.Text = "Previsão de Entrega:";
            // 
            // lblDiasPrevistosParaExecucao
            // 
            this.lblDiasPrevistosParaExecucao.AutoSize = true;
            this.lblDiasPrevistosParaExecucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasPrevistosParaExecucao.Location = new System.Drawing.Point(242, 33);
            this.lblDiasPrevistosParaExecucao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiasPrevistosParaExecucao.Name = "lblDiasPrevistosParaExecucao";
            this.lblDiasPrevistosParaExecucao.Size = new System.Drawing.Size(68, 17);
            this.lblDiasPrevistosParaExecucao.TabIndex = 3;
            this.lblDiasPrevistosParaExecucao.Text = "dias úteis";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(299, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 2;
            // 
            // lblPrevisaoExecServ
            // 
            this.lblPrevisaoExecServ.AutoSize = true;
            this.lblPrevisaoExecServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevisaoExecServ.Location = new System.Drawing.Point(8, 33);
            this.lblPrevisaoExecServ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrevisaoExecServ.Name = "lblPrevisaoExecServ";
            this.lblPrevisaoExecServ.Size = new System.Drawing.Size(151, 17);
            this.lblPrevisaoExecServ.TabIndex = 0;
            this.lblPrevisaoExecServ.Text = "Previsão de execução:";
            // 
            // lblValidadeOrcamento
            // 
            this.lblValidadeOrcamento.AutoSize = true;
            this.lblValidadeOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidadeOrcamento.Location = new System.Drawing.Point(8, 71);
            this.lblValidadeOrcamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValidadeOrcamento.Name = "lblValidadeOrcamento";
            this.lblValidadeOrcamento.Size = new System.Drawing.Size(147, 17);
            this.lblValidadeOrcamento.TabIndex = 9;
            this.lblValidadeOrcamento.Text = "Orçamento válido até:";
            // 
            // dtpDataValidadeOrcamento
            // 
            this.dtpDataValidadeOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataValidadeOrcamento.Location = new System.Drawing.Point(158, 66);
            this.dtpDataValidadeOrcamento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataValidadeOrcamento.Name = "dtpDataValidadeOrcamento";
            this.dtpDataValidadeOrcamento.Size = new System.Drawing.Size(276, 23);
            this.dtpDataValidadeOrcamento.TabIndex = 28;
            // 
            // btnCancelarOrcamento
            // 
            this.btnCancelarOrcamento.BackColor = System.Drawing.Color.Red;
            this.btnCancelarOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarOrcamento.ForeColor = System.Drawing.Color.White;
            this.btnCancelarOrcamento.Location = new System.Drawing.Point(358, 177);
            this.btnCancelarOrcamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarOrcamento.Name = "btnCancelarOrcamento";
            this.btnCancelarOrcamento.Size = new System.Drawing.Size(122, 26);
            this.btnCancelarOrcamento.TabIndex = 32;
            this.btnCancelarOrcamento.Text = "Cancelar";
            this.btnCancelarOrcamento.UseVisualStyleBackColor = false;
            this.btnCancelarOrcamento.Click += new System.EventHandler(this.btnCancelarOrcamento_Click);
            // 
            // btnGravarOrcamento
            // 
            this.btnGravarOrcamento.BackColor = System.Drawing.Color.Green;
            this.btnGravarOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarOrcamento.ForeColor = System.Drawing.Color.White;
            this.btnGravarOrcamento.Location = new System.Drawing.Point(52, 177);
            this.btnGravarOrcamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnGravarOrcamento.Name = "btnGravarOrcamento";
            this.btnGravarOrcamento.Size = new System.Drawing.Size(122, 26);
            this.btnGravarOrcamento.TabIndex = 30;
            this.btnGravarOrcamento.Text = "Gravar";
            this.btnGravarOrcamento.UseVisualStyleBackColor = false;
            this.btnGravarOrcamento.Click += new System.EventHandler(this.btnGravarOrcamento_Click);
            // 
            // btnAprovar
            // 
            this.btnAprovar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAprovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprovar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAprovar.Location = new System.Drawing.Point(203, 177);
            this.btnAprovar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Size = new System.Drawing.Size(122, 26);
            this.btnAprovar.TabIndex = 31;
            this.btnAprovar.Text = "Aprovar";
            this.btnAprovar.UseVisualStyleBackColor = false;
            this.btnAprovar.Click += new System.EventHandler(this.btnAprovar_Click);
            // 
            // grpPrazosFinalizacao
            // 
            this.grpPrazosFinalizacao.Controls.Add(this.lblTotalGeralValor);
            this.grpPrazosFinalizacao.Controls.Add(this.lblTotalGeral);
            this.grpPrazosFinalizacao.Controls.Add(this.rtfObservacoes);
            this.grpPrazosFinalizacao.Controls.Add(this.lblObservacoes);
            this.grpPrazosFinalizacao.Controls.Add(this.nudAnos);
            this.grpPrazosFinalizacao.Controls.Add(this.lblAnos);
            this.grpPrazosFinalizacao.Controls.Add(this.lblTempoGarantia);
            this.grpPrazosFinalizacao.Controls.Add(this.lblValidadeOrcamento);
            this.grpPrazosFinalizacao.Controls.Add(this.btnAprovar);
            this.grpPrazosFinalizacao.Controls.Add(this.dtpDataValidadeOrcamento);
            this.grpPrazosFinalizacao.Controls.Add(this.btnGravarOrcamento);
            this.grpPrazosFinalizacao.Controls.Add(this.btnCancelarOrcamento);
            this.grpPrazosFinalizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPrazosFinalizacao.Location = new System.Drawing.Point(586, 352);
            this.grpPrazosFinalizacao.Margin = new System.Windows.Forms.Padding(2);
            this.grpPrazosFinalizacao.Name = "grpPrazosFinalizacao";
            this.grpPrazosFinalizacao.Padding = new System.Windows.Forms.Padding(2);
            this.grpPrazosFinalizacao.Size = new System.Drawing.Size(543, 210);
            this.grpPrazosFinalizacao.TabIndex = 5;
            this.grpPrazosFinalizacao.TabStop = false;
            this.grpPrazosFinalizacao.Text = "Prazos e Finalização";
            // 
            // lblTotalGeralValor
            // 
            this.lblTotalGeralValor.AutoSize = true;
            this.lblTotalGeralValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGeralValor.Location = new System.Drawing.Point(112, 30);
            this.lblTotalGeralValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalGeralValor.Name = "lblTotalGeralValor";
            this.lblTotalGeralValor.Size = new System.Drawing.Size(16, 17);
            this.lblTotalGeralValor.TabIndex = 34;
            this.lblTotalGeralValor.Text = "0";
            // 
            // lblTotalGeral
            // 
            this.lblTotalGeral.AutoSize = true;
            this.lblTotalGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGeral.Location = new System.Drawing.Point(10, 30);
            this.lblTotalGeral.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalGeral.Name = "lblTotalGeral";
            this.lblTotalGeral.Size = new System.Drawing.Size(100, 17);
            this.lblTotalGeral.TabIndex = 33;
            this.lblTotalGeral.Text = "Total Geral: ";
            // 
            // rtfObservacoes
            // 
            this.rtfObservacoes.Location = new System.Drawing.Point(106, 101);
            this.rtfObservacoes.MaxLength = 3990;
            this.rtfObservacoes.Name = "rtfObservacoes";
            this.rtfObservacoes.Size = new System.Drawing.Size(414, 64);
            this.rtfObservacoes.TabIndex = 29;
            this.rtfObservacoes.Text = "";
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacoes.Location = new System.Drawing.Point(10, 101);
            this.lblObservacoes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(100, 17);
            this.lblObservacoes.TabIndex = 14;
            this.lblObservacoes.Text = "Observações: ";
            // 
            // nudAnos
            // 
            this.nudAnos.Location = new System.Drawing.Point(312, 26);
            this.nudAnos.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudAnos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnos.Name = "nudAnos";
            this.nudAnos.Size = new System.Drawing.Size(77, 26);
            this.nudAnos.TabIndex = 27;
            this.nudAnos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnos.Visible = false;
            // 
            // lblAnos
            // 
            this.lblAnos.AutoSize = true;
            this.lblAnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnos.Location = new System.Drawing.Point(394, 30);
            this.lblAnos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnos.Name = "lblAnos";
            this.lblAnos.Size = new System.Drawing.Size(40, 17);
            this.lblAnos.TabIndex = 20;
            this.lblAnos.Text = "Anos";
            this.lblAnos.Visible = false;
            // 
            // lblTempoGarantia
            // 
            this.lblTempoGarantia.AutoSize = true;
            this.lblTempoGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoGarantia.Location = new System.Drawing.Point(160, 30);
            this.lblTempoGarantia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTempoGarantia.Name = "lblTempoGarantia";
            this.lblTempoGarantia.Size = new System.Drawing.Size(139, 17);
            this.lblTempoGarantia.TabIndex = 19;
            this.lblTempoGarantia.Text = "Tempo de Garantia: ";
            this.lblTempoGarantia.Visible = false;
            // 
            // frmBudgetsRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1144, 578);
            this.Controls.Add(this.grpPrazosFinalizacao);
            this.Controls.Add(this.grpEntrega);
            this.Controls.Add(this.grpFormaPagto);
            this.Controls.Add(this.grpProdutos_Servicos);
            this.Controls.Add(this.grpCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmBudgetsRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orçamentos";
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpProdutos_Servicos.ResumeLayout(false);
            this.grpProdutos_Servicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.grpFormaPagto.ResumeLayout(false);
            this.grpFormaPagto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelas)).EndInit();
            this.grpEntrega.ResumeLayout(false);
            this.grpEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).EndInit();
            this.grpPrazosFinalizacao.ResumeLayout(false);
            this.grpPrazosFinalizacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.GroupBox grpProdutos_Servicos;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.GroupBox grpFormaPagto;
        private System.Windows.Forms.CheckBox chkJuros;
        private System.Windows.Forms.Label lblContinuaParcelamento;
        private System.Windows.Forms.Label lblParcelamento;
        private System.Windows.Forms.Label lblExibeValorDesconto;
        private System.Windows.Forms.Label lblValorAVista;
        private System.Windows.Forms.TextBox txtPorcentDescAVista;
        private System.Windows.Forms.Label lblAVista;
        private System.Windows.Forms.Label lbExibeValorParcelado;
        private System.Windows.Forms.Label lblParcela;
        private System.Windows.Forms.Label lblContinuaJuros;
        private System.Windows.Forms.TextBox txtPorcentJuros;
        private System.Windows.Forms.GroupBox grpEntrega;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDataPrevistaEntrega;
        private System.Windows.Forms.Label lblDiasPrevistosParaExecucao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPrevisaoExecServ;
        private System.Windows.Forms.Label lblDataPrevistaInicio;
        private System.Windows.Forms.DateTimePicker dtpDataPrevistaEntrega;
        private System.Windows.Forms.DateTimePicker dtpDataPrevistaInicio;
        private System.Windows.Forms.Label lblValidadeOrcamento;
        private System.Windows.Forms.DateTimePicker dtpDataValidadeOrcamento;
        private System.Windows.Forms.Button btnCancelarOrcamento;
        private System.Windows.Forms.Button btnGravarOrcamento;
        private System.Windows.Forms.Button btnAprovar;
        private System.Windows.Forms.GroupBox grpPrazosFinalizacao;
        private System.Windows.Forms.Label lblExibeValorTotalParcelado;
        private System.Windows.Forms.Label lblValorTotalParcelado;
        private System.Windows.Forms.Label lblValorPorParcela;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnPeca;
        private System.Windows.Forms.RichTextBox rtfObservacoes;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.NumericUpDown nudAnos;
        private System.Windows.Forms.Label lblAnos;
        private System.Windows.Forms.Label lblTempoGarantia;
        private System.Windows.Forms.CheckBox chkCombinar;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.RadioButton radIndustrial;
        private System.Windows.Forms.RadioButton radResidencial;
        private System.Windows.Forms.RadioButton radComercial;
        private System.Windows.Forms.Label lblSubTotalValor;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.NumericUpDown nudParcelas;
        private System.Windows.Forms.NumericUpDown nudDias;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnServico;
        private System.Windows.Forms.CheckBox chkDinheiro;
        private System.Windows.Forms.CheckBox chkCheque;
        private System.Windows.Forms.Label lblTotalGeralValor;
        private System.Windows.Forms.Label lblTotalGeral;
        private System.Windows.Forms.Label lblValorJuros;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTotal;
    }
}