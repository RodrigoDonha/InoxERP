namespace UIWindows
{
    partial class frmProductsRegisterSearch
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
            this.components = new System.ComponentModel.Container();
            this.grpCadastroProdutos = new System.Windows.Forms.GroupBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnProcurarFornecedor = new System.Windows.Forms.Button();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.radKG = new System.Windows.Forms.RadioButton();
            this.radMT = new System.Windows.Forms.RadioButton();
            this.radUN = new System.Windows.Forms.RadioButton();
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
            this.Consulta = new System.Windows.Forms.TabPage();
            this.grpConsultarProdutos = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvConsultaPecas = new System.Windows.Forms.DataGridView();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sObservationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProvidersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbproductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UIWindows.FullDataSet();
            this.txtConsultaPeca = new System.Windows.Forms.TextBox();
            this.lblConsultaPeca = new System.Windows.Forms.Label();
            this.Cadastro = new System.Windows.Forms.TabPage();
            this.tb_productsTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_productsTableAdapter();
            this.grpCadastroProdutos.SuspendLayout();
            this.tbcConsultaValores.SuspendLayout();
            this.Consulta.SuspendLayout();
            this.grpConsultarProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbproductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            this.Cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCadastroProdutos
            // 
            this.grpCadastroProdutos.Controls.Add(this.txtQuantidade);
            this.grpCadastroProdutos.Controls.Add(this.btnProcurarFornecedor);
            this.grpCadastroProdutos.Controls.Add(this.lblFornecedor);
            this.grpCadastroProdutos.Controls.Add(this.txtFornecedor);
            this.grpCadastroProdutos.Controls.Add(this.radKG);
            this.grpCadastroProdutos.Controls.Add(this.radMT);
            this.grpCadastroProdutos.Controls.Add(this.radUN);
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
            this.grpCadastroProdutos.Size = new System.Drawing.Size(566, 430);
            this.grpCadastroProdutos.TabIndex = 0;
            this.grpCadastroProdutos.TabStop = false;
            this.grpCadastroProdutos.Text = "Cadastro de Produtos";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(112, 65);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(146, 23);
            this.txtQuantidade.TabIndex = 2;
            // 
            // btnProcurarFornecedor
            // 
            this.btnProcurarFornecedor.Location = new System.Drawing.Point(435, 151);
            this.btnProcurarFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProcurarFornecedor.Name = "btnProcurarFornecedor";
            this.btnProcurarFornecedor.Size = new System.Drawing.Size(125, 30);
            this.btnProcurarFornecedor.TabIndex = 9;
            this.btnProcurarFornecedor.Text = "Procurar";
            this.btnProcurarFornecedor.UseVisualStyleBackColor = true;
            this.btnProcurarFornecedor.Click += new System.EventHandler(this.btnProcurarFornecedor_Click);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(6, 158);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(85, 17);
            this.lblFornecedor.TabIndex = 15;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(112, 155);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(317, 23);
            this.txtFornecedor.TabIndex = 8;
            // 
            // radKG
            // 
            this.radKG.AutoSize = true;
            this.radKG.Location = new System.Drawing.Point(514, 69);
            this.radKG.Name = "radKG";
            this.radKG.Size = new System.Drawing.Size(46, 21);
            this.radKG.TabIndex = 5;
            this.radKG.Text = "KG";
            this.radKG.UseVisualStyleBackColor = true;
            // 
            // radMT
            // 
            this.radMT.AutoSize = true;
            this.radMT.Location = new System.Drawing.Point(426, 69);
            this.radMT.Name = "radMT";
            this.radMT.Size = new System.Drawing.Size(46, 21);
            this.radMT.TabIndex = 4;
            this.radMT.Text = "MT";
            this.radMT.UseVisualStyleBackColor = true;
            // 
            // radUN
            // 
            this.radUN.AutoSize = true;
            this.radUN.Checked = true;
            this.radUN.Location = new System.Drawing.Point(333, 69);
            this.radUN.Name = "radUN";
            this.radUN.Size = new System.Drawing.Size(46, 21);
            this.radUN.TabIndex = 3;
            this.radUN.TabStop = true;
            this.radUN.Text = "UN";
            this.radUN.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(399, 330);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(73, 30);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(5, 195);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(89, 17);
            this.lblObservacao.TabIndex = 9;
            this.lblObservacao.Text = "Observação:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(245, 330);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(73, 30);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(9, 220);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(551, 82);
            this.txtObservacao.TabIndex = 10;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(65, 330);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 30);
            this.btnGravar.TabIndex = 11;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(435, 109);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(125, 23);
            this.txtValorTotal.TabIndex = 7;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(112, 109);
            this.txtValorUnitario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(146, 23);
            this.txtValorUnitario.TabIndex = 6;
            this.txtValorUnitario.TextChanged += new System.EventHandler(this.txtValorUnitario_TextChanged);
            // 
            // txtPeca
            // 
            this.txtPeca.Location = new System.Drawing.Point(112, 30);
            this.txtPeca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPeca.Name = "txtPeca";
            this.txtPeca.Size = new System.Drawing.Size(448, 23);
            this.txtPeca.TabIndex = 1;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(330, 112);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(81, 17);
            this.lblValorTotal.TabIndex = 3;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Location = new System.Drawing.Point(5, 112);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(98, 17);
            this.lblValorUnitario.TabIndex = 2;
            this.lblValorUnitario.Text = "Valor Unitário:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(5, 71);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(86, 17);
            this.lblQuantidade.TabIndex = 1;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblPeca
            // 
            this.lblPeca.AutoSize = true;
            this.lblPeca.Location = new System.Drawing.Point(5, 33);
            this.lblPeca.Name = "lblPeca";
            this.lblPeca.Size = new System.Drawing.Size(44, 17);
            this.lblPeca.TabIndex = 0;
            this.lblPeca.Text = "Peça:";
            // 
            // tbcConsultaValores
            // 
            this.tbcConsultaValores.Controls.Add(this.Consulta);
            this.tbcConsultaValores.Controls.Add(this.Cadastro);
            this.tbcConsultaValores.Location = new System.Drawing.Point(5, 7);
            this.tbcConsultaValores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcConsultaValores.Name = "tbcConsultaValores";
            this.tbcConsultaValores.SelectedIndex = 0;
            this.tbcConsultaValores.Size = new System.Drawing.Size(585, 466);
            this.tbcConsultaValores.TabIndex = 2;
            // 
            // Consulta
            // 
            this.Consulta.Controls.Add(this.grpConsultarProdutos);
            this.Consulta.Location = new System.Drawing.Point(4, 25);
            this.Consulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Consulta.Name = "Consulta";
            this.Consulta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Consulta.Size = new System.Drawing.Size(577, 437);
            this.Consulta.TabIndex = 1;
            this.Consulta.Text = "Consulta";
            this.Consulta.UseVisualStyleBackColor = true;
            // 
            // grpConsultarProdutos
            // 
            this.grpConsultarProdutos.Controls.Add(this.btnBuscar);
            this.grpConsultarProdutos.Controls.Add(this.dgvConsultaPecas);
            this.grpConsultarProdutos.Controls.Add(this.txtConsultaPeca);
            this.grpConsultarProdutos.Controls.Add(this.lblConsultaPeca);
            this.grpConsultarProdutos.Location = new System.Drawing.Point(5, 5);
            this.grpConsultarProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConsultarProdutos.Name = "grpConsultarProdutos";
            this.grpConsultarProdutos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConsultarProdutos.Size = new System.Drawing.Size(576, 437);
            this.grpConsultarProdutos.TabIndex = 1;
            this.grpConsultarProdutos.TabStop = false;
            this.grpConsultarProdutos.Text = "Consultar Produtos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(482, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 32);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvConsultaPecas
            // 
            this.dgvConsultaPecas.AllowUserToAddRows = false;
            this.dgvConsultaPecas.AllowUserToDeleteRows = false;
            this.dgvConsultaPecas.AutoGenerateColumns = false;
            this.dgvConsultaPecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaPecas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.dAmountDataGridViewTextBoxColumn,
            this.sDescriptionDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.dPriceDataGridViewTextBoxColumn,
            this.dTotalDataGridViewTextBoxColumn,
            this.sObservationDataGridViewTextBoxColumn,
            this.idProvidersDataGridViewTextBoxColumn,
            this.idItemsDataGridViewTextBoxColumn});
            this.dgvConsultaPecas.DataSource = this.tbproductsBindingSource;
            this.dgvConsultaPecas.Location = new System.Drawing.Point(9, 69);
            this.dgvConsultaPecas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvConsultaPecas.Name = "dgvConsultaPecas";
            this.dgvConsultaPecas.ReadOnly = true;
            this.dgvConsultaPecas.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvConsultaPecas.RowTemplate.Height = 24;
            this.dgvConsultaPecas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaPecas.Size = new System.Drawing.Size(548, 354);
            this.dgvConsultaPecas.TabIndex = 7;
            this.dgvConsultaPecas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsultaPecas_CellDoubleClick);
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "sID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "sID";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            this.sIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dAmountDataGridViewTextBoxColumn
            // 
            this.dAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dAmountDataGridViewTextBoxColumn.DataPropertyName = "dAmount";
            this.dAmountDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.dAmountDataGridViewTextBoxColumn.Name = "dAmountDataGridViewTextBoxColumn";
            this.dAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.dAmountDataGridViewTextBoxColumn.Width = 107;
            // 
            // sDescriptionDataGridViewTextBoxColumn
            // 
            this.sDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sDescriptionDataGridViewTextBoxColumn.DataPropertyName = "sDescription";
            this.sDescriptionDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.sDescriptionDataGridViewTextBoxColumn.Name = "sDescriptionDataGridViewTextBoxColumn";
            this.sDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Medida";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 79;
            // 
            // dPriceDataGridViewTextBoxColumn
            // 
            this.dPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dPriceDataGridViewTextBoxColumn.DataPropertyName = "dPrice";
            this.dPriceDataGridViewTextBoxColumn.HeaderText = "Valor UN";
            this.dPriceDataGridViewTextBoxColumn.Name = "dPriceDataGridViewTextBoxColumn";
            this.dPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.dPriceDataGridViewTextBoxColumn.Width = 90;
            // 
            // dTotalDataGridViewTextBoxColumn
            // 
            this.dTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dTotalDataGridViewTextBoxColumn.DataPropertyName = "dTotal";
            this.dTotalDataGridViewTextBoxColumn.HeaderText = "Valor Total";
            this.dTotalDataGridViewTextBoxColumn.Name = "dTotalDataGridViewTextBoxColumn";
            this.dTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.dTotalDataGridViewTextBoxColumn.Width = 102;
            // 
            // sObservationDataGridViewTextBoxColumn
            // 
            this.sObservationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sObservationDataGridViewTextBoxColumn.DataPropertyName = "sObservation";
            this.sObservationDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.sObservationDataGridViewTextBoxColumn.Name = "sObservationDataGridViewTextBoxColumn";
            this.sObservationDataGridViewTextBoxColumn.ReadOnly = true;
            this.sObservationDataGridViewTextBoxColumn.Visible = false;
            // 
            // idProvidersDataGridViewTextBoxColumn
            // 
            this.idProvidersDataGridViewTextBoxColumn.DataPropertyName = "IdProviders";
            this.idProvidersDataGridViewTextBoxColumn.HeaderText = "IdProviders";
            this.idProvidersDataGridViewTextBoxColumn.Name = "idProvidersDataGridViewTextBoxColumn";
            this.idProvidersDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProvidersDataGridViewTextBoxColumn.Visible = false;
            // 
            // idItemsDataGridViewTextBoxColumn
            // 
            this.idItemsDataGridViewTextBoxColumn.DataPropertyName = "IdItems";
            this.idItemsDataGridViewTextBoxColumn.HeaderText = "IdItems";
            this.idItemsDataGridViewTextBoxColumn.Name = "idItemsDataGridViewTextBoxColumn";
            this.idItemsDataGridViewTextBoxColumn.ReadOnly = true;
            this.idItemsDataGridViewTextBoxColumn.Visible = false;
            // 
            // tbproductsBindingSource
            // 
            this.tbproductsBindingSource.DataMember = "tb_products";
            this.tbproductsBindingSource.DataSource = this.fullDataSet;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtConsultaPeca
            // 
            this.txtConsultaPeca.Location = new System.Drawing.Point(71, 31);
            this.txtConsultaPeca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConsultaPeca.Name = "txtConsultaPeca";
            this.txtConsultaPeca.Size = new System.Drawing.Size(405, 23);
            this.txtConsultaPeca.TabIndex = 1;
            // 
            // lblConsultaPeca
            // 
            this.lblConsultaPeca.AutoSize = true;
            this.lblConsultaPeca.Location = new System.Drawing.Point(6, 33);
            this.lblConsultaPeca.Name = "lblConsultaPeca";
            this.lblConsultaPeca.Size = new System.Drawing.Size(44, 17);
            this.lblConsultaPeca.TabIndex = 5;
            this.lblConsultaPeca.Text = "Peça:";
            // 
            // Cadastro
            // 
            this.Cadastro.Controls.Add(this.grpCadastroProdutos);
            this.Cadastro.Location = new System.Drawing.Point(4, 25);
            this.Cadastro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cadastro.Size = new System.Drawing.Size(577, 437);
            this.Cadastro.TabIndex = 0;
            this.Cadastro.Text = "Cadastro";
            this.Cadastro.UseVisualStyleBackColor = true;
            // 
            // tb_productsTableAdapter
            // 
            this.tb_productsTableAdapter.ClearBeforeFill = true;
            // 
            // frmProductsRegisterSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 484);
            this.Controls.Add(this.tbcConsultaValores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProductsRegisterSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Consulta de Produtos";
            this.Load += new System.EventHandler(this.frmProductsRegisterSearch_Load);
            this.grpCadastroProdutos.ResumeLayout(false);
            this.grpCadastroProdutos.PerformLayout();
            this.tbcConsultaValores.ResumeLayout(false);
            this.Consulta.ResumeLayout(false);
            this.grpConsultarProdutos.ResumeLayout(false);
            this.grpConsultarProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbproductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            this.Cadastro.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage Cadastro;
        private System.Windows.Forms.TabPage Consulta;
        private System.Windows.Forms.RadioButton radKG;
        private System.Windows.Forms.RadioButton radMT;
        private System.Windows.Forms.RadioButton radUN;
        private System.Windows.Forms.GroupBox grpConsultarProdutos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvConsultaPecas;
        private System.Windows.Forms.TextBox txtConsultaPeca;
        private System.Windows.Forms.Label lblConsultaPeca;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Button btnProcurarFornecedor;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource tbproductsBindingSource;
        private FullDataSetTableAdapters.tb_productsTableAdapter tb_productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sObservationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProvidersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtQuantidade;
    }
}