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
            this.btCliente = new System.Windows.Forms.Button();
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.bpbProdutos_Servicos = new System.Windows.Forms.GroupBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.tbValorTotal = new System.Windows.Forms.TextBox();
            this.tbValorUnitario = new System.Windows.Forms.TextBox();
            this.lbValorUnitario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.mktbQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.gpbFormaPagto = new System.Windows.Forms.GroupBox();
            this.lbExibeValorTotalParcelado = new System.Windows.Forms.Label();
            this.lbValorTotalParcelado = new System.Windows.Forms.Label();
            this.lbExibeValorPorParcela = new System.Windows.Forms.Label();
            this.lbExibeValorParcelado = new System.Windows.Forms.Label();
            this.lbValorParcelado = new System.Windows.Forms.Label();
            this.lbContinuaJuros = new System.Windows.Forms.Label();
            this.tbPorcentJuros = new System.Windows.Forms.TextBox();
            this.chkbJuros = new System.Windows.Forms.CheckBox();
            this.lbContinuaParcelamento = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbParcelamento = new System.Windows.Forms.Label();
            this.lvExibeValorAVista = new System.Windows.Forms.Label();
            this.lbValorAVista = new System.Windows.Forms.Label();
            this.tbPorcentDescAVista = new System.Windows.Forms.TextBox();
            this.lbAVista = new System.Windows.Forms.Label();
            this.gpbEntrega = new System.Windows.Forms.GroupBox();
            this.dtpDataPrevistaEntrega = new System.Windows.Forms.DateTimePicker();
            this.lbDataPrevistaInicio = new System.Windows.Forms.Label();
            this.dtpDataPrevistaInicioServico = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDataPrevistaEntrega = new System.Windows.Forms.Label();
            this.lbDiasPrevistosParaExecucao = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPrevDiasExec = new System.Windows.Forms.TextBox();
            this.lbPrevisaoExecServ = new System.Windows.Forms.Label();
            this.lbValidadeOrcamento = new System.Windows.Forms.Label();
            this.dtpDataValidadeOrcamento = new System.Windows.Forms.DateTimePicker();
            this.btCancelarOrcamento = new System.Windows.Forms.Button();
            this.btGravarOrcamento = new System.Windows.Forms.Button();
            this.btSairOrcamento = new System.Windows.Forms.Button();
            this.gpbPrazosFinalizacao = new System.Windows.Forms.GroupBox();
            this.gpbCliente.SuspendLayout();
            this.bpbProdutos_Servicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbFormaPagto.SuspendLayout();
            this.gpbEntrega.SuspendLayout();
            this.gpbPrazosFinalizacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCliente
            // 
            this.btCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCliente.Location = new System.Drawing.Point(90, 28);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(162, 32);
            this.btCliente.TabIndex = 1;
            this.btCliente.Text = "Cliente";
            this.btCliente.UseVisualStyleBackColor = true;
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.textBox2);
            this.gpbCliente.Controls.Add(this.textBox4);
            this.gpbCliente.Controls.Add(this.textBox3);
            this.gpbCliente.Controls.Add(this.lbTelefone);
            this.gpbCliente.Controls.Add(this.lbEndereco);
            this.gpbCliente.Controls.Add(this.btCliente);
            this.gpbCliente.Controls.Add(this.lbNomeCliente);
            this.gpbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCliente.Location = new System.Drawing.Point(12, 6);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(760, 209);
            this.gpbCliente.TabIndex = 1;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Cliente";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(653, 30);
            this.textBox2.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(90, 155);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(271, 30);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(653, 30);
            this.textBox3.TabIndex = 12;
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.Location = new System.Drawing.Point(6, 161);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(78, 20);
            this.lbTelefone.TabIndex = 9;
            this.lbTelefone.Text = "Telefone:";
            this.lbTelefone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndereco.Location = new System.Drawing.Point(6, 118);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(85, 20);
            this.lbEndereco.TabIndex = 8;
            this.lbEndereco.Text = "Endereço:";
            this.lbEndereco.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCliente.Location = new System.Drawing.Point(6, 79);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(58, 20);
            this.lbNomeCliente.TabIndex = 3;
            this.lbNomeCliente.Text = "Nome:";
            this.lbNomeCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bpbProdutos_Servicos
            // 
            this.bpbProdutos_Servicos.Controls.Add(this.btConsultar);
            this.bpbProdutos_Servicos.Controls.Add(this.dataGridView1);
            this.bpbProdutos_Servicos.Controls.Add(this.btAdicionar);
            this.bpbProdutos_Servicos.Controls.Add(this.lbValorTotal);
            this.bpbProdutos_Servicos.Controls.Add(this.tbValorTotal);
            this.bpbProdutos_Servicos.Controls.Add(this.tbValorUnitario);
            this.bpbProdutos_Servicos.Controls.Add(this.lbValorUnitario);
            this.bpbProdutos_Servicos.Controls.Add(this.label1);
            this.bpbProdutos_Servicos.Controls.Add(this.tbDescricao);
            this.bpbProdutos_Servicos.Controls.Add(this.mktbQuantidade);
            this.bpbProdutos_Servicos.Controls.Add(this.lbQuantidade);
            this.bpbProdutos_Servicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpbProdutos_Servicos.Location = new System.Drawing.Point(12, 216);
            this.bpbProdutos_Servicos.Name = "bpbProdutos_Servicos";
            this.bpbProdutos_Servicos.Size = new System.Drawing.Size(760, 475);
            this.bpbProdutos_Servicos.TabIndex = 2;
            this.bpbProdutos_Servicos.TabStop = false;
            this.bpbProdutos_Servicos.Text = "Produtos / Serviços";
            // 
            // btConsultar
            // 
            this.btConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.Location = new System.Drawing.Point(624, 21);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(119, 33);
            this.btConsultar.TabIndex = 19;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(733, 346);
            this.dataGridView1.TabIndex = 18;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionar.Location = new System.Drawing.Point(624, 61);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(119, 33);
            this.btAdicionar.TabIndex = 6;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotal.Location = new System.Drawing.Point(515, 39);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(90, 20);
            this.lbValorTotal.TabIndex = 17;
            this.lbValorTotal.Text = "Valor Total";
            this.lbValorTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbValorTotal
            // 
            this.tbValorTotal.Location = new System.Drawing.Point(518, 62);
            this.tbValorTotal.Name = "tbValorTotal";
            this.tbValorTotal.Size = new System.Drawing.Size(100, 30);
            this.tbValorTotal.TabIndex = 5;
            // 
            // tbValorUnitario
            // 
            this.tbValorUnitario.Location = new System.Drawing.Point(405, 62);
            this.tbValorUnitario.Name = "tbValorUnitario";
            this.tbValorUnitario.Size = new System.Drawing.Size(107, 30);
            this.tbValorUnitario.TabIndex = 4;
            // 
            // lbValorUnitario
            // 
            this.lbValorUnitario.AutoSize = true;
            this.lbValorUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorUnitario.Location = new System.Drawing.Point(401, 39);
            this.lbValorUnitario.Name = "lbValorUnitario";
            this.lbValorUnitario.Size = new System.Drawing.Size(111, 20);
            this.lbValorUnitario.TabIndex = 14;
            this.lbValorUnitario.Text = "Valor Unitário";
            this.lbValorUnitario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descrição";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(83, 62);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(316, 30);
            this.tbDescricao.TabIndex = 3;
            // 
            // mktbQuantidade
            // 
            this.mktbQuantidade.Location = new System.Drawing.Point(9, 62);
            this.mktbQuantidade.Mask = "00,00";
            this.mktbQuantidade.Name = "mktbQuantidade";
            this.mktbQuantidade.Size = new System.Drawing.Size(69, 30);
            this.mktbQuantidade.TabIndex = 2;
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidade.Location = new System.Drawing.Point(6, 39);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(58, 20);
            this.lbQuantidade.TabIndex = 11;
            this.lbQuantidade.Text = "Quant.";
            this.lbQuantidade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gpbFormaPagto
            // 
            this.gpbFormaPagto.Controls.Add(this.lbExibeValorTotalParcelado);
            this.gpbFormaPagto.Controls.Add(this.lbValorTotalParcelado);
            this.gpbFormaPagto.Controls.Add(this.lbExibeValorPorParcela);
            this.gpbFormaPagto.Controls.Add(this.lbExibeValorParcelado);
            this.gpbFormaPagto.Controls.Add(this.lbValorParcelado);
            this.gpbFormaPagto.Controls.Add(this.lbContinuaJuros);
            this.gpbFormaPagto.Controls.Add(this.tbPorcentJuros);
            this.gpbFormaPagto.Controls.Add(this.chkbJuros);
            this.gpbFormaPagto.Controls.Add(this.lbContinuaParcelamento);
            this.gpbFormaPagto.Controls.Add(this.textBox1);
            this.gpbFormaPagto.Controls.Add(this.lbParcelamento);
            this.gpbFormaPagto.Controls.Add(this.lvExibeValorAVista);
            this.gpbFormaPagto.Controls.Add(this.lbValorAVista);
            this.gpbFormaPagto.Controls.Add(this.tbPorcentDescAVista);
            this.gpbFormaPagto.Controls.Add(this.lbAVista);
            this.gpbFormaPagto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFormaPagto.Location = new System.Drawing.Point(782, 6);
            this.gpbFormaPagto.Name = "gpbFormaPagto";
            this.gpbFormaPagto.Size = new System.Drawing.Size(724, 209);
            this.gpbFormaPagto.TabIndex = 3;
            this.gpbFormaPagto.TabStop = false;
            this.gpbFormaPagto.Text = "Forma de Pagamento";
            // 
            // lbExibeValorTotalParcelado
            // 
            this.lbExibeValorTotalParcelado.AutoSize = true;
            this.lbExibeValorTotalParcelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExibeValorTotalParcelado.Location = new System.Drawing.Point(207, 168);
            this.lbExibeValorTotalParcelado.Name = "lbExibeValorTotalParcelado";
            this.lbExibeValorTotalParcelado.Size = new System.Drawing.Size(263, 20);
            this.lbExibeValorTotalParcelado.TabIndex = 14;
            this.lbExibeValorTotalParcelado.Text = "Aqui exibe o valor Total Parcelado";
            // 
            // lbValorTotalParcelado
            // 
            this.lbValorTotalParcelado.AutoSize = true;
            this.lbValorTotalParcelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotalParcelado.Location = new System.Drawing.Point(13, 168);
            this.lbValorTotalParcelado.Name = "lbValorTotalParcelado";
            this.lbValorTotalParcelado.Size = new System.Drawing.Size(175, 20);
            this.lbValorTotalParcelado.TabIndex = 13;
            this.lbValorTotalParcelado.Text = "Valor Total Parcelado:";
            // 
            // lbExibeValorPorParcela
            // 
            this.lbExibeValorPorParcela.AutoSize = true;
            this.lbExibeValorPorParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExibeValorPorParcela.Location = new System.Drawing.Point(539, 126);
            this.lbExibeValorPorParcela.Name = "lbExibeValorPorParcela";
            this.lbExibeValorPorParcela.Size = new System.Drawing.Size(226, 20);
            this.lbExibeValorPorParcela.TabIndex = 12;
            this.lbExibeValorPorParcela.Text = "Aqui exibe o valor da Parcela";
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
            // lbValorParcelado
            // 
            this.lbValorParcelado.AutoSize = true;
            this.lbValorParcelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorParcelado.Location = new System.Drawing.Point(388, 125);
            this.lbValorParcelado.Name = "lbValorParcelado";
            this.lbValorParcelado.Size = new System.Drawing.Size(138, 20);
            this.lbValorParcelado.TabIndex = 10;
            this.lbValorParcelado.Text = "Valor da Parcela:";
            // 
            // lbContinuaJuros
            // 
            this.lbContinuaJuros.AutoSize = true;
            this.lbContinuaJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContinuaJuros.Location = new System.Drawing.Point(314, 125);
            this.lbContinuaJuros.Name = "lbContinuaJuros";
            this.lbContinuaJuros.Size = new System.Drawing.Size(60, 20);
            this.lbContinuaJuros.TabIndex = 9;
            this.lbContinuaJuros.Text = "% a.m.";
            // 
            // tbPorcentJuros
            // 
            this.tbPorcentJuros.Location = new System.Drawing.Point(208, 119);
            this.tbPorcentJuros.Name = "tbPorcentJuros";
            this.tbPorcentJuros.Size = new System.Drawing.Size(100, 30);
            this.tbPorcentJuros.TabIndex = 10;
            // 
            // chkbJuros
            // 
            this.chkbJuros.AutoSize = true;
            this.chkbJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbJuros.Location = new System.Drawing.Point(17, 125);
            this.chkbJuros.Name = "chkbJuros";
            this.chkbJuros.Size = new System.Drawing.Size(133, 24);
            this.chkbJuros.TabIndex = 9;
            this.chkbJuros.Text = "com júros de:";
            this.chkbJuros.UseVisualStyleBackColor = true;
            // 
            // lbContinuaParcelamento
            // 
            this.lbContinuaParcelamento.AutoSize = true;
            this.lbContinuaParcelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContinuaParcelamento.Location = new System.Drawing.Point(322, 82);
            this.lbContinuaParcelamento.Name = "lbContinuaParcelamento";
            this.lbContinuaParcelamento.Size = new System.Drawing.Size(53, 20);
            this.lbContinuaParcelamento.TabIndex = 6;
            this.lbContinuaParcelamento.Text = "vezes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 8;
            // 
            // lbParcelamento
            // 
            this.lbParcelamento.AutoSize = true;
            this.lbParcelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParcelamento.Location = new System.Drawing.Point(13, 82);
            this.lbParcelamento.Name = "lbParcelamento";
            this.lbParcelamento.Size = new System.Drawing.Size(173, 20);
            this.lbParcelamento.TabIndex = 4;
            this.lbParcelamento.Text = "Parcelamento em até:";
            // 
            // lvExibeValorAVista
            // 
            this.lvExibeValorAVista.AutoSize = true;
            this.lvExibeValorAVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvExibeValorAVista.Location = new System.Drawing.Point(439, 40);
            this.lvExibeValorAVista.Name = "lvExibeValorAVista";
            this.lvExibeValorAVista.Size = new System.Drawing.Size(200, 20);
            this.lvExibeValorAVista.TabIndex = 3;
            this.lvExibeValorAVista.Text = "Aqui exibe o valor Á Vista";
            // 
            // lbValorAVista
            // 
            this.lbValorAVista.AutoSize = true;
            this.lbValorAVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorAVista.Location = new System.Drawing.Point(316, 40);
            this.lbValorAVista.Name = "lbValorAVista";
            this.lbValorAVista.Size = new System.Drawing.Size(112, 20);
            this.lbValorAVista.TabIndex = 2;
            this.lbValorAVista.Text = "Valor Á Vista:";
            // 
            // tbPorcentDescAVista
            // 
            this.tbPorcentDescAVista.Location = new System.Drawing.Point(207, 33);
            this.tbPorcentDescAVista.Name = "tbPorcentDescAVista";
            this.tbPorcentDescAVista.Size = new System.Drawing.Size(100, 30);
            this.tbPorcentDescAVista.TabIndex = 7;
            // 
            // lbAVista
            // 
            this.lbAVista.AutoSize = true;
            this.lbAVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAVista.Location = new System.Drawing.Point(13, 40);
            this.lbAVista.Name = "lbAVista";
            this.lbAVista.Size = new System.Drawing.Size(162, 20);
            this.lbAVista.TabIndex = 0;
            this.lbAVista.Text = "Desconto % Á vista:";
            // 
            // gpbEntrega
            // 
            this.gpbEntrega.Controls.Add(this.dtpDataPrevistaEntrega);
            this.gpbEntrega.Controls.Add(this.lbDataPrevistaInicio);
            this.gpbEntrega.Controls.Add(this.dtpDataPrevistaInicioServico);
            this.gpbEntrega.Controls.Add(this.label5);
            this.gpbEntrega.Controls.Add(this.lbDataPrevistaEntrega);
            this.gpbEntrega.Controls.Add(this.lbDiasPrevistosParaExecucao);
            this.gpbEntrega.Controls.Add(this.label8);
            this.gpbEntrega.Controls.Add(this.tbPrevDiasExec);
            this.gpbEntrega.Controls.Add(this.lbPrevisaoExecServ);
            this.gpbEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEntrega.Location = new System.Drawing.Point(782, 216);
            this.gpbEntrega.Name = "gpbEntrega";
            this.gpbEntrega.Size = new System.Drawing.Size(724, 200);
            this.gpbEntrega.TabIndex = 4;
            this.gpbEntrega.TabStop = false;
            this.gpbEntrega.Text = "Entrega";
            // 
            // dtpDataPrevistaEntrega
            // 
            this.dtpDataPrevistaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataPrevistaEntrega.Location = new System.Drawing.Point(211, 83);
            this.dtpDataPrevistaEntrega.Name = "dtpDataPrevistaEntrega";
            this.dtpDataPrevistaEntrega.Size = new System.Drawing.Size(366, 27);
            this.dtpDataPrevistaEntrega.TabIndex = 12;
            // 
            // lbDataPrevistaInicio
            // 
            this.lbDataPrevistaInicio.AutoSize = true;
            this.lbDataPrevistaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataPrevistaInicio.Location = new System.Drawing.Point(17, 87);
            this.lbDataPrevistaInicio.Name = "lbDataPrevistaInicio";
            this.lbDataPrevistaInicio.Size = new System.Drawing.Size(146, 20);
            this.lbDataPrevistaInicio.TabIndex = 13;
            this.lbDataPrevistaInicio.Text = "Previsão de inicio:";
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
            // lbDataPrevistaEntrega
            // 
            this.lbDataPrevistaEntrega.AutoSize = true;
            this.lbDataPrevistaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataPrevistaEntrega.Location = new System.Drawing.Point(17, 137);
            this.lbDataPrevistaEntrega.Name = "lbDataPrevistaEntrega";
            this.lbDataPrevistaEntrega.Size = new System.Drawing.Size(165, 20);
            this.lbDataPrevistaEntrega.TabIndex = 4;
            this.lbDataPrevistaEntrega.Text = "Previsão de Entrega:";
            // 
            // lbDiasPrevistosParaExecucao
            // 
            this.lbDiasPrevistosParaExecucao.AutoSize = true;
            this.lbDiasPrevistosParaExecucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiasPrevistosParaExecucao.Location = new System.Drawing.Point(322, 43);
            this.lbDiasPrevistosParaExecucao.Name = "lbDiasPrevistosParaExecucao";
            this.lbDiasPrevistosParaExecucao.Size = new System.Drawing.Size(44, 20);
            this.lbDiasPrevistosParaExecucao.TabIndex = 3;
            this.lbDiasPrevistosParaExecucao.Text = "dias.";
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
            // tbPrevDiasExec
            // 
            this.tbPrevDiasExec.Location = new System.Drawing.Point(211, 33);
            this.tbPrevDiasExec.Name = "tbPrevDiasExec";
            this.tbPrevDiasExec.Size = new System.Drawing.Size(95, 30);
            this.tbPrevDiasExec.TabIndex = 11;
            this.tbPrevDiasExec.TextChanged += new System.EventHandler(this.tbPrevDiasExec_TextChanged);
            // 
            // lbPrevisaoExecServ
            // 
            this.lbPrevisaoExecServ.AutoSize = true;
            this.lbPrevisaoExecServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrevisaoExecServ.Location = new System.Drawing.Point(13, 40);
            this.lbPrevisaoExecServ.Name = "lbPrevisaoExecServ";
            this.lbPrevisaoExecServ.Size = new System.Drawing.Size(178, 20);
            this.lbPrevisaoExecServ.TabIndex = 0;
            this.lbPrevisaoExecServ.Text = "Previsão de execução:";
            // 
            // lbValidadeOrcamento
            // 
            this.lbValidadeOrcamento.AutoSize = true;
            this.lbValidadeOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValidadeOrcamento.Location = new System.Drawing.Point(21, 58);
            this.lbValidadeOrcamento.Name = "lbValidadeOrcamento";
            this.lbValidadeOrcamento.Size = new System.Drawing.Size(173, 20);
            this.lbValidadeOrcamento.TabIndex = 9;
            this.lbValidadeOrcamento.Text = "Orçamento válido até:";
            // 
            // dtpDataValidadeOrcamento
            // 
            this.dtpDataValidadeOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataValidadeOrcamento.Location = new System.Drawing.Point(211, 53);
            this.dtpDataValidadeOrcamento.Name = "dtpDataValidadeOrcamento";
            this.dtpDataValidadeOrcamento.Size = new System.Drawing.Size(367, 27);
            this.dtpDataValidadeOrcamento.TabIndex = 14;
            // 
            // btCancelarOrcamento
            // 
            this.btCancelarOrcamento.BackColor = System.Drawing.Color.Red;
            this.btCancelarOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarOrcamento.ForeColor = System.Drawing.Color.White;
            this.btCancelarOrcamento.Location = new System.Drawing.Point(54, 165);
            this.btCancelarOrcamento.Name = "btCancelarOrcamento";
            this.btCancelarOrcamento.Size = new System.Drawing.Size(162, 32);
            this.btCancelarOrcamento.TabIndex = 15;
            this.btCancelarOrcamento.Text = "Cancelar";
            this.btCancelarOrcamento.UseVisualStyleBackColor = false;
            // 
            // btGravarOrcamento
            // 
            this.btGravarOrcamento.BackColor = System.Drawing.Color.Green;
            this.btGravarOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravarOrcamento.ForeColor = System.Drawing.Color.White;
            this.btGravarOrcamento.Location = new System.Drawing.Point(271, 165);
            this.btGravarOrcamento.Name = "btGravarOrcamento";
            this.btGravarOrcamento.Size = new System.Drawing.Size(162, 32);
            this.btGravarOrcamento.TabIndex = 16;
            this.btGravarOrcamento.Text = "Gravar";
            this.btGravarOrcamento.UseVisualStyleBackColor = false;
            // 
            // btSairOrcamento
            // 
            this.btSairOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSairOrcamento.Location = new System.Drawing.Point(492, 165);
            this.btSairOrcamento.Name = "btSairOrcamento";
            this.btSairOrcamento.Size = new System.Drawing.Size(162, 32);
            this.btSairOrcamento.TabIndex = 17;
            this.btSairOrcamento.Text = "Sair";
            this.btSairOrcamento.UseVisualStyleBackColor = true;
            // 
            // gpbPrazosFinalizacao
            // 
            this.gpbPrazosFinalizacao.Controls.Add(this.lbValidadeOrcamento);
            this.gpbPrazosFinalizacao.Controls.Add(this.btSairOrcamento);
            this.gpbPrazosFinalizacao.Controls.Add(this.dtpDataValidadeOrcamento);
            this.gpbPrazosFinalizacao.Controls.Add(this.btGravarOrcamento);
            this.gpbPrazosFinalizacao.Controls.Add(this.btCancelarOrcamento);
            this.gpbPrazosFinalizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPrazosFinalizacao.Location = new System.Drawing.Point(782, 417);
            this.gpbPrazosFinalizacao.Name = "gpbPrazosFinalizacao";
            this.gpbPrazosFinalizacao.Size = new System.Drawing.Size(724, 275);
            this.gpbPrazosFinalizacao.TabIndex = 5;
            this.gpbPrazosFinalizacao.TabStop = false;
            this.gpbPrazosFinalizacao.Text = "Prazos e Finalização";
            // 
            // OrcamentosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1521, 712);
            this.Controls.Add(this.gpbPrazosFinalizacao);
            this.Controls.Add(this.gpbEntrega);
            this.Controls.Add(this.gpbFormaPagto);
            this.Controls.Add(this.bpbProdutos_Servicos);
            this.Controls.Add(this.gpbCliente);
            this.Name = "OrcamentosForm";
            this.Text = "Orçamentos";
            this.Load += new System.EventHandler(this.OrcamentosForm_Load);
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.bpbProdutos_Servicos.ResumeLayout(false);
            this.bpbProdutos_Servicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbFormaPagto.ResumeLayout(false);
            this.gpbFormaPagto.PerformLayout();
            this.gpbEntrega.ResumeLayout(false);
            this.gpbEntrega.PerformLayout();
            this.gpbPrazosFinalizacao.ResumeLayout(false);
            this.gpbPrazosFinalizacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.GroupBox bpbProdutos_Servicos;
        private System.Windows.Forms.MaskedTextBox mktbQuantidade;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Label lbValorUnitario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label lbValorTotal;
        private System.Windows.Forms.TextBox tbValorTotal;
        private System.Windows.Forms.TextBox tbValorUnitario;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gpbFormaPagto;
        private System.Windows.Forms.CheckBox chkbJuros;
        private System.Windows.Forms.Label lbContinuaParcelamento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbParcelamento;
        private System.Windows.Forms.Label lvExibeValorAVista;
        private System.Windows.Forms.Label lbValorAVista;
        private System.Windows.Forms.TextBox tbPorcentDescAVista;
        private System.Windows.Forms.Label lbAVista;
        private System.Windows.Forms.Label lbExibeValorParcelado;
        private System.Windows.Forms.Label lbValorParcelado;
        private System.Windows.Forms.Label lbContinuaJuros;
        private System.Windows.Forms.TextBox tbPorcentJuros;
        private System.Windows.Forms.GroupBox gpbEntrega;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDataPrevistaEntrega;
        private System.Windows.Forms.Label lbDiasPrevistosParaExecucao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPrevDiasExec;
        private System.Windows.Forms.Label lbPrevisaoExecServ;
        private System.Windows.Forms.Label lbDataPrevistaInicio;
        private System.Windows.Forms.DateTimePicker dtpDataPrevistaInicioServico;
        private System.Windows.Forms.DateTimePicker dtpDataPrevistaEntrega;
        private System.Windows.Forms.Label lbValidadeOrcamento;
        private System.Windows.Forms.DateTimePicker dtpDataValidadeOrcamento;
        private System.Windows.Forms.Button btCancelarOrcamento;
        private System.Windows.Forms.Button btGravarOrcamento;
        private System.Windows.Forms.Button btSairOrcamento;
        private System.Windows.Forms.GroupBox gpbPrazosFinalizacao;
        private System.Windows.Forms.Label lbExibeValorTotalParcelado;
        private System.Windows.Forms.Label lbValorTotalParcelado;
        private System.Windows.Forms.Label lbExibeValorPorParcela;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.Button btConsultar;
    }
}