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
            this.btnProcurarFornecedor = new System.Windows.Forms.Button();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
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
            this.fullDataSet = new UIWindows.FullDataSet();
            this.tbproductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_productsTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_productsTableAdapter();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sObservationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProvidersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCadastroProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.tbcConsultaValores.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpConsultarProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaPecas)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbproductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCadastroProdutos
            // 
            this.grpCadastroProdutos.Controls.Add(this.btnProcurarFornecedor);
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
            this.grpCadastroProdutos.Size = new System.Drawing.Size(507, 430);
            this.grpCadastroProdutos.TabIndex = 0;
            this.grpCadastroProdutos.TabStop = false;
            this.grpCadastroProdutos.Text = "Cadastro de Produtos";
            // 
            // btnProcurarFornecedor
            // 
            this.btnProcurarFornecedor.Location = new System.Drawing.Point(364, 151);
            this.btnProcurarFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProcurarFornecedor.Name = "btnProcurarFornecedor";
            this.btnProcurarFornecedor.Size = new System.Drawing.Size(125, 30);
            this.btnProcurarFornecedor.TabIndex = 16;
            this.btnProcurarFornecedor.Text = "Procurar";
            this.btnProcurarFornecedor.UseVisualStyleBackColor = true;
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
            this.txtFornecedor.Size = new System.Drawing.Size(228, 23);
            this.txtFornecedor.TabIndex = 14;
            // 
            // radKG
            // 
            this.radKG.AutoSize = true;
            this.radKG.Location = new System.Drawing.Point(443, 69);
            this.radKG.Name = "radKG";
            this.radKG.Size = new System.Drawing.Size(46, 21);
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
            this.radMT.Size = new System.Drawing.Size(46, 21);
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
            this.radUN.Size = new System.Drawing.Size(46, 21);
            this.radUN.TabIndex = 11;
            this.radUN.TabStop = true;
            this.radUN.Text = "UN";
            this.radUN.UseVisualStyleBackColor = true;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(112, 69);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(120, 23);
            this.nudQuantidade.TabIndex = 10;
            this.nudQuantidade.ValueChanged += new System.EventHandler(this.nudQuantidade_ValueChanged);
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
            this.lblObservacao.Size = new System.Drawing.Size(89, 17);
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
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(364, 109);
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
            this.txtValorUnitario.Size = new System.Drawing.Size(125, 23);
            this.txtValorUnitario.TabIndex = 6;
            this.txtValorUnitario.TextChanged += new System.EventHandler(this.txtValorUnitario_TextChanged);
            // 
            // txtPeca
            // 
            this.txtPeca.Location = new System.Drawing.Point(112, 30);
            this.txtPeca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPeca.Name = "txtPeca";
            this.txtPeca.Size = new System.Drawing.Size(377, 23);
            this.txtPeca.TabIndex = 4;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(259, 112);
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
            this.tbcConsultaValores.Controls.Add(this.tabPage2);
            this.tbcConsultaValores.Controls.Add(this.tabPage1);
            this.tbcConsultaValores.Location = new System.Drawing.Point(5, 7);
            this.tbcConsultaValores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcConsultaValores.Name = "tbcConsultaValores";
            this.tbcConsultaValores.SelectedIndex = 0;
            this.tbcConsultaValores.Size = new System.Drawing.Size(512, 466);
            this.tbcConsultaValores.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpConsultarProdutos);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(504, 437);
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
            this.grpConsultarProdutos.Size = new System.Drawing.Size(491, 435);
            this.grpConsultarProdutos.TabIndex = 1;
            this.grpConsultarProdutos.TabStop = false;
            this.grpConsultarProdutos.Text = "Consultar Produtos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(407, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 32);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // grdConsultaPecas
            // 
            this.grdConsultaPecas.AllowUserToAddRows = false;
            this.grdConsultaPecas.AllowUserToDeleteRows = false;
            this.grdConsultaPecas.AutoGenerateColumns = false;
            this.grdConsultaPecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultaPecas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.dAmountDataGridViewTextBoxColumn,
            this.sDescriptionDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.dPriceDataGridViewTextBoxColumn,
            this.dTotalDataGridViewTextBoxColumn,
            this.sObservationDataGridViewTextBoxColumn,
            this.idProvidersDataGridViewTextBoxColumn,
            this.idItemsDataGridViewTextBoxColumn});
            this.grdConsultaPecas.DataSource = this.tbproductsBindingSource;
            this.grdConsultaPecas.Location = new System.Drawing.Point(9, 69);
            this.grdConsultaPecas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdConsultaPecas.Name = "grdConsultaPecas";
            this.grdConsultaPecas.ReadOnly = true;
            this.grdConsultaPecas.RowTemplate.Height = 24;
            this.grdConsultaPecas.Size = new System.Drawing.Size(473, 354);
            this.grdConsultaPecas.TabIndex = 7;
            // 
            // txtConsultaPeca
            // 
            this.txtConsultaPeca.Location = new System.Drawing.Point(56, 30);
            this.txtConsultaPeca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConsultaPeca.Name = "txtConsultaPeca";
            this.txtConsultaPeca.Size = new System.Drawing.Size(345, 23);
            this.txtConsultaPeca.TabIndex = 6;
            // 
            // lblConsultaPeca
            // 
            this.lblConsultaPeca.AutoSize = true;
            this.lblConsultaPeca.Location = new System.Drawing.Point(5, 33);
            this.lblConsultaPeca.Name = "lblConsultaPeca";
            this.lblConsultaPeca.Size = new System.Drawing.Size(44, 17);
            this.lblConsultaPeca.TabIndex = 5;
            this.lblConsultaPeca.Text = "Peça:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpCadastroProdutos);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(504, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbproductsBindingSource
            // 
            this.tbproductsBindingSource.DataMember = "tb_products";
            this.tbproductsBindingSource.DataSource = this.fullDataSet;
            // 
            // tb_productsTableAdapter
            // 
            this.tb_productsTableAdapter.ClearBeforeFill = true;
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
            this.dAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dAmountDataGridViewTextBoxColumn.DataPropertyName = "dAmount";
            this.dAmountDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.dAmountDataGridViewTextBoxColumn.Name = "dAmountDataGridViewTextBoxColumn";
            this.dAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.dAmountDataGridViewTextBoxColumn.Width = 107;
            // 
            // sDescriptionDataGridViewTextBoxColumn
            // 
            this.sDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sDescriptionDataGridViewTextBoxColumn.DataPropertyName = "sDescription";
            this.sDescriptionDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.sDescriptionDataGridViewTextBoxColumn.Name = "sDescriptionDataGridViewTextBoxColumn";
            this.sDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDescriptionDataGridViewTextBoxColumn.Width = 96;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Medida";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 79;
            // 
            // dPriceDataGridViewTextBoxColumn
            // 
            this.dPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dPriceDataGridViewTextBoxColumn.DataPropertyName = "dPrice";
            this.dPriceDataGridViewTextBoxColumn.HeaderText = "Valor Unitário";
            this.dPriceDataGridViewTextBoxColumn.Name = "dPriceDataGridViewTextBoxColumn";
            this.dPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.dPriceDataGridViewTextBoxColumn.Width = 119;
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
            // frmProductsRegisterSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 484);
            this.Controls.Add(this.tbcConsultaValores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProductsRegisterSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Consulta de Produtos";
            this.Load += new System.EventHandler(this.frmProductsRegisterSearch_Load);
            this.grpCadastroProdutos.ResumeLayout(false);
            this.grpCadastroProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.tbcConsultaValores.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.grpConsultarProdutos.ResumeLayout(false);
            this.grpConsultarProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaPecas)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbproductsBindingSource)).EndInit();
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
    }
}