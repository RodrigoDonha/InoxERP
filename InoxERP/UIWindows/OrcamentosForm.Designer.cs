namespace InoxERP.UI_Windows_Forms
{
    partial class OrcamentosForm
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
            this.btnCliente = new System.Windows.Forms.Button();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.grpProdutos_Servicos = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grdItens = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.mkdQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.grpFormaPagto = new System.Windows.Forms.GroupBox();
            this.lblExibeValorTotalParcelado = new System.Windows.Forms.Label();
            this.lblValorTotalParcelado = new System.Windows.Forms.Label();
            this.lblExibeValorPorParcela = new System.Windows.Forms.Label();
            this.lbExibeValorParcelado = new System.Windows.Forms.Label();
            this.lblValorParcelado = new System.Windows.Forms.Label();
            this.lblContinuaJuros = new System.Windows.Forms.Label();
            this.txtPorcentJuros = new System.Windows.Forms.TextBox();
            this.chkJuros = new System.Windows.Forms.CheckBox();
            this.lblContinuaParcelamento = new System.Windows.Forms.Label();
            this.txtParacelamento = new System.Windows.Forms.TextBox();
            this.lblParcelamento = new System.Windows.Forms.Label();
            this.lblExibeValorAVista = new System.Windows.Forms.Label();
            this.lblValorAVista = new System.Windows.Forms.Label();
            this.txtPorcentDescAVista = new System.Windows.Forms.TextBox();
            this.lblAVista = new System.Windows.Forms.Label();
            this.grpEntrega = new System.Windows.Forms.GroupBox();
            this.dtpDataPrevistaEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblDataPrevistaInicio = new System.Windows.Forms.Label();
            this.dtpDataPrevistaInicioServico = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDataPrevistaEntrega = new System.Windows.Forms.Label();
            this.lblDiasPrevistosParaExecucao = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrevDiasExec = new System.Windows.Forms.TextBox();
            this.lblPrevisaoExecServ = new System.Windows.Forms.Label();
            this.lblValidadeOrcamento = new System.Windows.Forms.Label();
            this.dtpDataValidadeOrcamento = new System.Windows.Forms.DateTimePicker();
            this.btnCancelarOrcamento = new System.Windows.Forms.Button();
            this.btnGravarOrcamento = new System.Windows.Forms.Button();
            this.btnAprovar = new System.Windows.Forms.Button();
            this.grpPrazosFinalizacao = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpCliente.SuspendLayout();
            this.grpProdutos_Servicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItens)).BeginInit();
            this.grpFormaPagto.SuspendLayout();
            this.grpEntrega.SuspendLayout();
            this.grpPrazosFinalizacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(90, 28);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(162, 32);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.txtEndereco);
            this.grpCliente.Controls.Add(this.txtTelefone);
            this.grpCliente.Controls.Add(this.txtNome);
            this.grpCliente.Controls.Add(this.lblTelefone);
            this.grpCliente.Controls.Add(this.lblEndereco);
            this.grpCliente.Controls.Add(this.btnCliente);
            this.grpCliente.Controls.Add(this.lblNome);
            this.grpCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCliente.Location = new System.Drawing.Point(12, 6);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(760, 209);
            this.grpCliente.TabIndex = 1;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Cliente";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(90, 114);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(653, 30);
            this.txtEndereco.TabIndex = 14;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(90, 155);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(271, 30);
            this.txtTelefone.TabIndex = 13;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(90, 73);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(653, 30);
            this.txtNome.TabIndex = 12;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(6, 161);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(78, 20);
            this.lblTelefone.TabIndex = 9;
            this.lblTelefone.Text = "Telefone:";
            this.lblTelefone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(6, 118);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(85, 20);
            this.lblEndereco.TabIndex = 8;
            this.lblEndereco.Text = "Endereço:";
            this.lblEndereco.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 79);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 20);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpProdutos_Servicos
            // 
            this.grpProdutos_Servicos.Controls.Add(this.btnConsultar);
            this.grpProdutos_Servicos.Controls.Add(this.grdItens);
            this.grpProdutos_Servicos.Controls.Add(this.btnAdicionar);
            this.grpProdutos_Servicos.Controls.Add(this.lblValorTotal);
            this.grpProdutos_Servicos.Controls.Add(this.txtValorTotal);
            this.grpProdutos_Servicos.Controls.Add(this.txtValorUnitario);
            this.grpProdutos_Servicos.Controls.Add(this.lblValorUnitario);
            this.grpProdutos_Servicos.Controls.Add(this.lblDescricao);
            this.grpProdutos_Servicos.Controls.Add(this.txtDescricao);
            this.grpProdutos_Servicos.Controls.Add(this.mkdQuantidade);
            this.grpProdutos_Servicos.Controls.Add(this.lblQuantidade);
            this.grpProdutos_Servicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProdutos_Servicos.Location = new System.Drawing.Point(12, 216);
            this.grpProdutos_Servicos.Name = "grpProdutos_Servicos";
            this.grpProdutos_Servicos.Size = new System.Drawing.Size(760, 475);
            this.grpProdutos_Servicos.TabIndex = 2;
            this.grpProdutos_Servicos.TabStop = false;
            this.grpProdutos_Servicos.Text = "Produtos / Serviços";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(624, 21);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(119, 33);
            this.btnConsultar.TabIndex = 19;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // grdItens
            // 
            this.grdItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItens.Location = new System.Drawing.Point(10, 113);
            this.grdItens.Name = "grdItens";
            this.grdItens.RowTemplate.Height = 24;
            this.grdItens.Size = new System.Drawing.Size(733, 346);
            this.grdItens.TabIndex = 18;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(624, 61);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(119, 33);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(515, 39);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(90, 20);
            this.lblValorTotal.TabIndex = 17;
            this.lblValorTotal.Text = "Valor Total";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(518, 62);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(100, 30);
            this.txtValorTotal.TabIndex = 5;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(405, 62);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(107, 30);
            this.txtValorUnitario.TabIndex = 4;
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorUnitario.Location = new System.Drawing.Point(401, 39);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(111, 20);
            this.lblValorUnitario.TabIndex = 14;
            this.lblValorUnitario.Text = "Valor Unitário";
            this.lblValorUnitario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(79, 39);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(86, 20);
            this.lblDescricao.TabIndex = 13;
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(83, 62);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(316, 30);
            this.txtDescricao.TabIndex = 3;
            // 
            // mkdQuantidade
            // 
            this.mkdQuantidade.Location = new System.Drawing.Point(9, 62);
            this.mkdQuantidade.Mask = "00,00";
            this.mkdQuantidade.Name = "mkdQuantidade";
            this.mkdQuantidade.Size = new System.Drawing.Size(69, 30);
            this.mkdQuantidade.TabIndex = 2;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(6, 39);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(58, 20);
            this.lblQuantidade.TabIndex = 11;
            this.lblQuantidade.Text = "Quant.";
            this.lblQuantidade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpFormaPagto
            // 
            this.grpFormaPagto.Controls.Add(this.lblExibeValorTotalParcelado);
            this.grpFormaPagto.Controls.Add(this.lblValorTotalParcelado);
            this.grpFormaPagto.Controls.Add(this.lblExibeValorPorParcela);
            this.grpFormaPagto.Controls.Add(this.lbExibeValorParcelado);
            this.grpFormaPagto.Controls.Add(this.lblValorParcelado);
            this.grpFormaPagto.Controls.Add(this.lblContinuaJuros);
            this.grpFormaPagto.Controls.Add(this.txtPorcentJuros);
            this.grpFormaPagto.Controls.Add(this.chkJuros);
            this.grpFormaPagto.Controls.Add(this.lblContinuaParcelamento);
            this.grpFormaPagto.Controls.Add(this.txtParacelamento);
            this.grpFormaPagto.Controls.Add(this.lblParcelamento);
            this.grpFormaPagto.Controls.Add(this.lblExibeValorAVista);
            this.grpFormaPagto.Controls.Add(this.lblValorAVista);
            this.grpFormaPagto.Controls.Add(this.txtPorcentDescAVista);
            this.grpFormaPagto.Controls.Add(this.lblAVista);
            this.grpFormaPagto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFormaPagto.Location = new System.Drawing.Point(782, 6);
            this.grpFormaPagto.Name = "grpFormaPagto";
            this.grpFormaPagto.Size = new System.Drawing.Size(724, 209);
            this.grpFormaPagto.TabIndex = 3;
            this.grpFormaPagto.TabStop = false;
            this.grpFormaPagto.Text = "Forma de Pagamento";
            // 
            // lblExibeValorTotalParcelado
            // 
            this.lblExibeValorTotalParcelado.AutoSize = true;
            this.lblExibeValorTotalParcelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibeValorTotalParcelado.Location = new System.Drawing.Point(207, 168);
            this.lblExibeValorTotalParcelado.Name = "lblExibeValorTotalParcelado";
            this.lblExibeValorTotalParcelado.Size = new System.Drawing.Size(263, 20);
            this.lblExibeValorTotalParcelado.TabIndex = 14;
            this.lblExibeValorTotalParcelado.Text = "Aqui exibe o valor Total Parcelado";
            // 
            // lblValorTotalParcelado
            // 
            this.lblValorTotalParcelado.AutoSize = true;
            this.lblValorTotalParcelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalParcelado.Location = new System.Drawing.Point(13, 168);
            this.lblValorTotalParcelado.Name = "lblValorTotalParcelado";
            this.lblValorTotalParcelado.Size = new System.Drawing.Size(175, 20);
            this.lblValorTotalParcelado.TabIndex = 13;
            this.lblValorTotalParcelado.Text = "Valor Total Parcelado:";
            // 
            // lblExibeValorPorParcela
            // 
            this.lblExibeValorPorParcela.AutoSize = true;
            this.lblExibeValorPorParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibeValorPorParcela.Location = new System.Drawing.Point(539, 126);
            this.lblExibeValorPorParcela.Name = "lblExibeValorPorParcela";
            this.lblExibeValorPorParcela.Size = new System.Drawing.Size(226, 20);
            this.lblExibeValorPorParcela.TabIndex = 12;
            this.lblExibeValorPorParcela.Text = "Aqui exibe o valor da Parcela";
            // 
            // lbExibeValorParcelado
            // 
            this.lbExibeValorParcelado.AutoSize = true;
            this.lbExibeValorParcelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExibeValorParcelado.Location = new System.Drawing.Point(851, 79);
            this.lbExibeValorParcelado.Name = "lbExibeValorParcelado";
            this.lbExibeValorParcelado.Size = new System.Drawing.Size(221, 20);
            this.lbExibeValorParcelado.TabIndex = 11;
            this.lbExibeValorParcelado.Text = "Aqui exibe o valor Parcelado";
            // 
            // lblValorParcelado
            // 
            this.lblValorParcelado.AutoSize = true;
            this.lblValorParcelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorParcelado.Location = new System.Drawing.Point(388, 125);
            this.lblValorParcelado.Name = "lblValorParcelado";
            this.lblValorParcelado.Size = new System.Drawing.Size(138, 20);
            this.lblValorParcelado.TabIndex = 10;
            this.lblValorParcelado.Text = "Valor da Parcela:";
            // 
            // lblContinuaJuros
            // 
            this.lblContinuaJuros.AutoSize = true;
            this.lblContinuaJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinuaJuros.Location = new System.Drawing.Point(314, 125);
            this.lblContinuaJuros.Name = "lblContinuaJuros";
            this.lblContinuaJuros.Size = new System.Drawing.Size(60, 20);
            this.lblContinuaJuros.TabIndex = 9;
            this.lblContinuaJuros.Text = "% a.m.";
            // 
            // txtPorcentJuros
            // 
            this.txtPorcentJuros.Location = new System.Drawing.Point(208, 119);
            this.txtPorcentJuros.Name = "txtPorcentJuros";
            this.txtPorcentJuros.Size = new System.Drawing.Size(100, 30);
            this.txtPorcentJuros.TabIndex = 10;
            // 
            // chkJuros
            // 
            this.chkJuros.AutoSize = true;
            this.chkJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJuros.Location = new System.Drawing.Point(17, 125);
            this.chkJuros.Name = "chkJuros";
            this.chkJuros.Size = new System.Drawing.Size(133, 24);
            this.chkJuros.TabIndex = 9;
            this.chkJuros.Text = "com júros de:";
            this.chkJuros.UseVisualStyleBackColor = true;
            // 
            // lblContinuaParcelamento
            // 
            this.lblContinuaParcelamento.AutoSize = true;
            this.lblContinuaParcelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinuaParcelamento.Location = new System.Drawing.Point(322, 82);
            this.lblContinuaParcelamento.Name = "lblContinuaParcelamento";
            this.lblContinuaParcelamento.Size = new System.Drawing.Size(53, 20);
            this.lblContinuaParcelamento.TabIndex = 6;
            this.lblContinuaParcelamento.Text = "vezes";
            // 
            // txtParacelamento
            // 
            this.txtParacelamento.Location = new System.Drawing.Point(207, 76);
            this.txtParacelamento.Name = "txtParacelamento";
            this.txtParacelamento.Size = new System.Drawing.Size(100, 30);
            this.txtParacelamento.TabIndex = 8;
            // 
            // lblParcelamento
            // 
            this.lblParcelamento.AutoSize = true;
            this.lblParcelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcelamento.Location = new System.Drawing.Point(13, 82);
            this.lblParcelamento.Name = "lblParcelamento";
            this.lblParcelamento.Size = new System.Drawing.Size(173, 20);
            this.lblParcelamento.TabIndex = 4;
            this.lblParcelamento.Text = "Parcelamento em até:";
            // 
            // lblExibeValorAVista
            // 
            this.lblExibeValorAVista.AutoSize = true;
            this.lblExibeValorAVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibeValorAVista.Location = new System.Drawing.Point(439, 40);
            this.lblExibeValorAVista.Name = "lblExibeValorAVista";
            this.lblExibeValorAVista.Size = new System.Drawing.Size(200, 20);
            this.lblExibeValorAVista.TabIndex = 3;
            this.lblExibeValorAVista.Text = "Aqui exibe o valor Á Vista";
            // 
            // lblValorAVista
            // 
            this.lblValorAVista.AutoSize = true;
            this.lblValorAVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAVista.Location = new System.Drawing.Point(316, 40);
            this.lblValorAVista.Name = "lblValorAVista";
            this.lblValorAVista.Size = new System.Drawing.Size(112, 20);
            this.lblValorAVista.TabIndex = 2;
            this.lblValorAVista.Text = "Valor Á Vista:";
            // 
            // txtPorcentDescAVista
            // 
            this.txtPorcentDescAVista.Location = new System.Drawing.Point(207, 33);
            this.txtPorcentDescAVista.Name = "txtPorcentDescAVista";
            this.txtPorcentDescAVista.Size = new System.Drawing.Size(100, 30);
            this.txtPorcentDescAVista.TabIndex = 7;
            // 
            // lblAVista
            // 
            this.lblAVista.AutoSize = true;
            this.lblAVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAVista.Location = new System.Drawing.Point(13, 40);
            this.lblAVista.Name = "lblAVista";
            this.lblAVista.Size = new System.Drawing.Size(162, 20);
            this.lblAVista.TabIndex = 0;
            this.lblAVista.Text = "Desconto % Á vista:";
            // 
            // grpEntrega
            // 
            this.grpEntrega.Controls.Add(this.dtpDataPrevistaEntrega);
            this.grpEntrega.Controls.Add(this.lblDataPrevistaInicio);
            this.grpEntrega.Controls.Add(this.dtpDataPrevistaInicioServico);
            this.grpEntrega.Controls.Add(this.label5);
            this.grpEntrega.Controls.Add(this.lblDataPrevistaEntrega);
            this.grpEntrega.Controls.Add(this.lblDiasPrevistosParaExecucao);
            this.grpEntrega.Controls.Add(this.label8);
            this.grpEntrega.Controls.Add(this.txtPrevDiasExec);
            this.grpEntrega.Controls.Add(this.lblPrevisaoExecServ);
            this.grpEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEntrega.Location = new System.Drawing.Point(782, 216);
            this.grpEntrega.Name = "grpEntrega";
            this.grpEntrega.Size = new System.Drawing.Size(724, 200);
            this.grpEntrega.TabIndex = 4;
            this.grpEntrega.TabStop = false;
            this.grpEntrega.Text = "Entrega";
            // 
            // dtpDataPrevistaEntrega
            // 
            this.dtpDataPrevistaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataPrevistaEntrega.Location = new System.Drawing.Point(211, 83);
            this.dtpDataPrevistaEntrega.Name = "dtpDataPrevistaEntrega";
            this.dtpDataPrevistaEntrega.Size = new System.Drawing.Size(366, 27);
            this.dtpDataPrevistaEntrega.TabIndex = 12;
            // 
            // lblDataPrevistaInicio
            // 
            this.lblDataPrevistaInicio.AutoSize = true;
            this.lblDataPrevistaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPrevistaInicio.Location = new System.Drawing.Point(17, 87);
            this.lblDataPrevistaInicio.Name = "lblDataPrevistaInicio";
            this.lblDataPrevistaInicio.Size = new System.Drawing.Size(146, 20);
            this.lblDataPrevistaInicio.TabIndex = 13;
            this.lblDataPrevistaInicio.Text = "Previsão de inicio:";
            // 
            // dtpDataPrevistaInicioServico
            // 
            this.dtpDataPrevistaInicioServico.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataPrevistaInicioServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataPrevistaInicioServico.Location = new System.Drawing.Point(210, 131);
            this.dtpDataPrevistaInicioServico.Name = "dtpDataPrevistaInicioServico";
            this.dtpDataPrevistaInicioServico.Size = new System.Drawing.Size(367, 27);
            this.dtpDataPrevistaInicioServico.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(451, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "vezes";
            // 
            // lblDataPrevistaEntrega
            // 
            this.lblDataPrevistaEntrega.AutoSize = true;
            this.lblDataPrevistaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPrevistaEntrega.Location = new System.Drawing.Point(17, 137);
            this.lblDataPrevistaEntrega.Name = "lblDataPrevistaEntrega";
            this.lblDataPrevistaEntrega.Size = new System.Drawing.Size(165, 20);
            this.lblDataPrevistaEntrega.TabIndex = 4;
            this.lblDataPrevistaEntrega.Text = "Previsão de Entrega:";
            // 
            // lblDiasPrevistosParaExecucao
            // 
            this.lblDiasPrevistosParaExecucao.AutoSize = true;
            this.lblDiasPrevistosParaExecucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasPrevistosParaExecucao.Location = new System.Drawing.Point(322, 43);
            this.lblDiasPrevistosParaExecucao.Name = "lblDiasPrevistosParaExecucao";
            this.lblDiasPrevistosParaExecucao.Size = new System.Drawing.Size(44, 20);
            this.lblDiasPrevistosParaExecucao.TabIndex = 3;
            this.lblDiasPrevistosParaExecucao.Text = "dias.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(399, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 2;
            // 
            // txtPrevDiasExec
            // 
            this.txtPrevDiasExec.Location = new System.Drawing.Point(211, 33);
            this.txtPrevDiasExec.Name = "txtPrevDiasExec";
            this.txtPrevDiasExec.Size = new System.Drawing.Size(95, 30);
            this.txtPrevDiasExec.TabIndex = 11;
            this.txtPrevDiasExec.TextChanged += new System.EventHandler(this.tbPrevDiasExec_TextChanged);
            // 
            // lblPrevisaoExecServ
            // 
            this.lblPrevisaoExecServ.AutoSize = true;
            this.lblPrevisaoExecServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevisaoExecServ.Location = new System.Drawing.Point(13, 40);
            this.lblPrevisaoExecServ.Name = "lblPrevisaoExecServ";
            this.lblPrevisaoExecServ.Size = new System.Drawing.Size(178, 20);
            this.lblPrevisaoExecServ.TabIndex = 0;
            this.lblPrevisaoExecServ.Text = "Previsão de execução:";
            // 
            // lblValidadeOrcamento
            // 
            this.lblValidadeOrcamento.AutoSize = true;
            this.lblValidadeOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidadeOrcamento.Location = new System.Drawing.Point(21, 58);
            this.lblValidadeOrcamento.Name = "lblValidadeOrcamento";
            this.lblValidadeOrcamento.Size = new System.Drawing.Size(173, 20);
            this.lblValidadeOrcamento.TabIndex = 9;
            this.lblValidadeOrcamento.Text = "Orçamento válido até:";
            // 
            // dtpDataValidadeOrcamento
            // 
            this.dtpDataValidadeOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataValidadeOrcamento.Location = new System.Drawing.Point(211, 53);
            this.dtpDataValidadeOrcamento.Name = "dtpDataValidadeOrcamento";
            this.dtpDataValidadeOrcamento.Size = new System.Drawing.Size(367, 27);
            this.dtpDataValidadeOrcamento.TabIndex = 14;
            // 
            // btnCancelarOrcamento
            // 
            this.btnCancelarOrcamento.BackColor = System.Drawing.Color.Red;
            this.btnCancelarOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarOrcamento.ForeColor = System.Drawing.Color.White;
            this.btnCancelarOrcamento.Location = new System.Drawing.Point(477, 165);
            this.btnCancelarOrcamento.Name = "btnCancelarOrcamento";
            this.btnCancelarOrcamento.Size = new System.Drawing.Size(162, 32);
            this.btnCancelarOrcamento.TabIndex = 15;
            this.btnCancelarOrcamento.Text = "Cancelar";
            this.btnCancelarOrcamento.UseVisualStyleBackColor = false;
            // 
            // btnGravarOrcamento
            // 
            this.btnGravarOrcamento.BackColor = System.Drawing.Color.Green;
            this.btnGravarOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarOrcamento.ForeColor = System.Drawing.Color.White;
            this.btnGravarOrcamento.Location = new System.Drawing.Point(70, 165);
            this.btnGravarOrcamento.Name = "btnGravarOrcamento";
            this.btnGravarOrcamento.Size = new System.Drawing.Size(162, 32);
            this.btnGravarOrcamento.TabIndex = 16;
            this.btnGravarOrcamento.Text = "Gravar";
            this.btnGravarOrcamento.UseVisualStyleBackColor = false;
            // 
            // btnAprovar
            // 
            this.btnAprovar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAprovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprovar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAprovar.Location = new System.Drawing.Point(271, 165);
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Size = new System.Drawing.Size(162, 32);
            this.btnAprovar.TabIndex = 17;
            this.btnAprovar.Text = "Aprovar";
            this.btnAprovar.UseVisualStyleBackColor = false;
            // 
            // grpPrazosFinalizacao
            // 
            this.grpPrazosFinalizacao.Controls.Add(this.btnSair);
            this.grpPrazosFinalizacao.Controls.Add(this.lblValidadeOrcamento);
            this.grpPrazosFinalizacao.Controls.Add(this.btnAprovar);
            this.grpPrazosFinalizacao.Controls.Add(this.dtpDataValidadeOrcamento);
            this.grpPrazosFinalizacao.Controls.Add(this.btnGravarOrcamento);
            this.grpPrazosFinalizacao.Controls.Add(this.btnCancelarOrcamento);
            this.grpPrazosFinalizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPrazosFinalizacao.Location = new System.Drawing.Point(782, 417);
            this.grpPrazosFinalizacao.Name = "grpPrazosFinalizacao";
            this.grpPrazosFinalizacao.Size = new System.Drawing.Size(724, 275);
            this.grpPrazosFinalizacao.TabIndex = 5;
            this.grpPrazosFinalizacao.TabStop = false;
            this.grpPrazosFinalizacao.Text = "Prazos e Finalização";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(556, 237);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(162, 32);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // OrcamentosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1521, 712);
            this.Controls.Add(this.grpPrazosFinalizacao);
            this.Controls.Add(this.grpEntrega);
            this.Controls.Add(this.grpFormaPagto);
            this.Controls.Add(this.grpProdutos_Servicos);
            this.Controls.Add(this.grpCliente);
            this.Name = "OrcamentosForm";
            this.Text = "Orçamentos";
            this.Load += new System.EventHandler(this.OrcamentosForm_Load);
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpProdutos_Servicos.ResumeLayout(false);
            this.grpProdutos_Servicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItens)).EndInit();
            this.grpFormaPagto.ResumeLayout(false);
            this.grpFormaPagto.PerformLayout();
            this.grpEntrega.ResumeLayout(false);
            this.grpEntrega.PerformLayout();
            this.grpPrazosFinalizacao.ResumeLayout(false);
            this.grpPrazosFinalizacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.GroupBox grpProdutos_Servicos;
        private System.Windows.Forms.MaskedTextBox mkdQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView grdItens;
        private System.Windows.Forms.GroupBox grpFormaPagto;
        private System.Windows.Forms.CheckBox chkJuros;
        private System.Windows.Forms.Label lblContinuaParcelamento;
        private System.Windows.Forms.TextBox txtParacelamento;
        private System.Windows.Forms.Label lblParcelamento;
        private System.Windows.Forms.Label lblExibeValorAVista;
        private System.Windows.Forms.Label lblValorAVista;
        private System.Windows.Forms.TextBox txtPorcentDescAVista;
        private System.Windows.Forms.Label lblAVista;
        private System.Windows.Forms.Label lbExibeValorParcelado;
        private System.Windows.Forms.Label lblValorParcelado;
        private System.Windows.Forms.Label lblContinuaJuros;
        private System.Windows.Forms.TextBox txtPorcentJuros;
        private System.Windows.Forms.GroupBox grpEntrega;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDataPrevistaEntrega;
        private System.Windows.Forms.Label lblDiasPrevistosParaExecucao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrevDiasExec;
        private System.Windows.Forms.Label lblPrevisaoExecServ;
        private System.Windows.Forms.Label lblDataPrevistaInicio;
        private System.Windows.Forms.DateTimePicker dtpDataPrevistaInicioServico;
        private System.Windows.Forms.DateTimePicker dtpDataPrevistaEntrega;
        private System.Windows.Forms.Label lblValidadeOrcamento;
        private System.Windows.Forms.DateTimePicker dtpDataValidadeOrcamento;
        private System.Windows.Forms.Button btnCancelarOrcamento;
        private System.Windows.Forms.Button btnGravarOrcamento;
        private System.Windows.Forms.Button btnAprovar;
        private System.Windows.Forms.GroupBox grpPrazosFinalizacao;
        private System.Windows.Forms.Label lblExibeValorTotalParcelado;
        private System.Windows.Forms.Label lblValorTotalParcelado;
        private System.Windows.Forms.Label lblExibeValorPorParcela;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSair;
    }
}