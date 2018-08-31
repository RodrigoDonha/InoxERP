namespace UIWindows
{
    partial class frmContract
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTituloContrato = new System.Windows.Forms.Label();
            this.lblContrante = new System.Windows.Forms.Label();
            this.lblNomeC = new System.Windows.Forms.Label();
            this.lblCpfCnpjC = new System.Windows.Forms.Label();
            this.txtNomeC = new System.Windows.Forms.TextBox();
            this.txtCpfCnpjC = new System.Windows.Forms.TextBox();
            this.txtEnderecoC = new System.Windows.Forms.TextBox();
            this.lblEnderecoC = new System.Windows.Forms.Label();
            this.txtNumeroC = new System.Windows.Forms.TextBox();
            this.lblNumeroC = new System.Windows.Forms.Label();
            this.txtBairroC = new System.Windows.Forms.TextBox();
            this.lblBairroC = new System.Windows.Forms.Label();
            this.txtCepC = new System.Windows.Forms.TextBox();
            this.lblCepC = new System.Windows.Forms.Label();
            this.txtCidadeC = new System.Windows.Forms.TextBox();
            this.lblCidadeC = new System.Windows.Forms.Label();
            this.lblEstadoC = new System.Windows.Forms.Label();
            this.lblContratado = new System.Windows.Forms.Label();
            this.txtEstadoE = new System.Windows.Forms.TextBox();
            this.lblEstadoE = new System.Windows.Forms.Label();
            this.txtCidadeE = new System.Windows.Forms.TextBox();
            this.lblCidadeE = new System.Windows.Forms.Label();
            this.txtCepE = new System.Windows.Forms.TextBox();
            this.lblCepE = new System.Windows.Forms.Label();
            this.txtBairroE = new System.Windows.Forms.TextBox();
            this.lblBairroE = new System.Windows.Forms.Label();
            this.txtNumeroE = new System.Windows.Forms.TextBox();
            this.lblNumeroE = new System.Windows.Forms.Label();
            this.txtEnderecoE = new System.Windows.Forms.TextBox();
            this.lblEnderecoE = new System.Windows.Forms.Label();
            this.txtCnpjE = new System.Windows.Forms.TextBox();
            this.txtNomeE = new System.Windows.Forms.TextBox();
            this.lblCnpjE = new System.Windows.Forms.Label();
            this.lblNomeE = new System.Windows.Forms.Label();
            this.txtCpfE = new System.Windows.Forms.TextBox();
            this.lblCpfE = new System.Windows.Forms.Label();
            this.lblObjetoServicos = new System.Windows.Forms.Label();
            this.dgvProdutosServicos = new System.Windows.Forms.DataGridView();
            this.lblRefValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValorPorExtenso = new System.Windows.Forms.Label();
            this.lblRefPrazo = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.dtpDataaPartir = new System.Windows.Forms.DateTimePicker();
            this.lblAnos = new System.Windows.Forms.Label();
            this.txtGarantia = new System.Windows.Forms.TextBox();
            this.lblGarantia = new System.Windows.Forms.Label();
            this.lblPpte = new System.Windows.Forms.Label();
            this.dtpDataAtual = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbxEstate = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::UIWindows.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(184, 13);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(443, 107);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblTituloContrato
            // 
            this.lblTituloContrato.AutoSize = true;
            this.lblTituloContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloContrato.Location = new System.Drawing.Point(215, 124);
            this.lblTituloContrato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloContrato.Name = "lblTituloContrato";
            this.lblTituloContrato.Size = new System.Drawing.Size(382, 26);
            this.lblTituloContrato.TabIndex = 1;
            this.lblTituloContrato.Text = "Contrato de Prestação de Serviços";
            // 
            // lblContrante
            // 
            this.lblContrante.AutoSize = true;
            this.lblContrante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrante.Location = new System.Drawing.Point(37, 155);
            this.lblContrante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrante.Name = "lblContrante";
            this.lblContrante.Size = new System.Drawing.Size(142, 20);
            this.lblContrante.TabIndex = 2;
            this.lblContrante.Text = "CONTRATANTE:";
            // 
            // lblNomeC
            // 
            this.lblNomeC.AutoSize = true;
            this.lblNomeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeC.Location = new System.Drawing.Point(38, 183);
            this.lblNomeC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeC.Name = "lblNomeC";
            this.lblNomeC.Size = new System.Drawing.Size(45, 16);
            this.lblNomeC.TabIndex = 3;
            this.lblNomeC.Text = "Nome";
            // 
            // lblCpfCnpjC
            // 
            this.lblCpfCnpjC.AutoSize = true;
            this.lblCpfCnpjC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfCnpjC.Location = new System.Drawing.Point(38, 216);
            this.lblCpfCnpjC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpfCnpjC.Name = "lblCpfCnpjC";
            this.lblCpfCnpjC.Size = new System.Drawing.Size(59, 16);
            this.lblCpfCnpjC.TabIndex = 4;
            this.lblCpfCnpjC.Text = "Cpf/Cnpj";
            // 
            // txtNomeC
            // 
            this.txtNomeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeC.Location = new System.Drawing.Point(97, 178);
            this.txtNomeC.Name = "txtNomeC";
            this.txtNomeC.Size = new System.Drawing.Size(670, 22);
            this.txtNomeC.TabIndex = 5;
            // 
            // txtCpfCnpjC
            // 
            this.txtCpfCnpjC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfCnpjC.Location = new System.Drawing.Point(97, 211);
            this.txtCpfCnpjC.Name = "txtCpfCnpjC";
            this.txtCpfCnpjC.Size = new System.Drawing.Size(204, 22);
            this.txtCpfCnpjC.TabIndex = 6;
            // 
            // txtEnderecoC
            // 
            this.txtEnderecoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoC.Location = new System.Drawing.Point(389, 211);
            this.txtEnderecoC.Name = "txtEnderecoC";
            this.txtEnderecoC.Size = new System.Drawing.Size(378, 22);
            this.txtEnderecoC.TabIndex = 8;
            // 
            // lblEnderecoC
            // 
            this.lblEnderecoC.AutoSize = true;
            this.lblEnderecoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoC.Location = new System.Drawing.Point(321, 216);
            this.lblEnderecoC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnderecoC.Name = "lblEnderecoC";
            this.lblEnderecoC.Size = new System.Drawing.Size(67, 16);
            this.lblEnderecoC.TabIndex = 7;
            this.lblEnderecoC.Text = "Endereço";
            // 
            // txtNumeroC
            // 
            this.txtNumeroC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroC.Location = new System.Drawing.Point(97, 240);
            this.txtNumeroC.Name = "txtNumeroC";
            this.txtNumeroC.Size = new System.Drawing.Size(96, 22);
            this.txtNumeroC.TabIndex = 10;
            // 
            // lblNumeroC
            // 
            this.lblNumeroC.AutoSize = true;
            this.lblNumeroC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroC.Location = new System.Drawing.Point(38, 245);
            this.lblNumeroC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroC.Name = "lblNumeroC";
            this.lblNumeroC.Size = new System.Drawing.Size(23, 16);
            this.lblNumeroC.TabIndex = 9;
            this.lblNumeroC.Text = "Nº";
            // 
            // txtBairroC
            // 
            this.txtBairroC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroC.Location = new System.Drawing.Point(302, 240);
            this.txtBairroC.Name = "txtBairroC";
            this.txtBairroC.Size = new System.Drawing.Size(185, 22);
            this.txtBairroC.TabIndex = 12;
            // 
            // lblBairroC
            // 
            this.lblBairroC.AutoSize = true;
            this.lblBairroC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairroC.Location = new System.Drawing.Point(242, 245);
            this.lblBairroC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairroC.Name = "lblBairroC";
            this.lblBairroC.Size = new System.Drawing.Size(44, 16);
            this.lblBairroC.TabIndex = 11;
            this.lblBairroC.Text = "Bairro";
            // 
            // txtCepC
            // 
            this.txtCepC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCepC.Location = new System.Drawing.Point(563, 240);
            this.txtCepC.Name = "txtCepC";
            this.txtCepC.Size = new System.Drawing.Size(204, 22);
            this.txtCepC.TabIndex = 14;
            // 
            // lblCepC
            // 
            this.lblCepC.AutoSize = true;
            this.lblCepC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCepC.Location = new System.Drawing.Point(515, 245);
            this.lblCepC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCepC.Name = "lblCepC";
            this.lblCepC.Size = new System.Drawing.Size(35, 16);
            this.lblCepC.TabIndex = 13;
            this.lblCepC.Text = "CEP";
            // 
            // txtCidadeC
            // 
            this.txtCidadeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeC.Location = new System.Drawing.Point(97, 269);
            this.txtCidadeC.Name = "txtCidadeC";
            this.txtCidadeC.Size = new System.Drawing.Size(185, 22);
            this.txtCidadeC.TabIndex = 16;
            // 
            // lblCidadeC
            // 
            this.lblCidadeC.AutoSize = true;
            this.lblCidadeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeC.Location = new System.Drawing.Point(38, 274);
            this.lblCidadeC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidadeC.Name = "lblCidadeC";
            this.lblCidadeC.Size = new System.Drawing.Size(52, 16);
            this.lblCidadeC.TabIndex = 15;
            this.lblCidadeC.Text = "Cidade";
            // 
            // lblEstadoC
            // 
            this.lblEstadoC.AutoSize = true;
            this.lblEstadoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoC.Location = new System.Drawing.Point(299, 274);
            this.lblEstadoC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoC.Name = "lblEstadoC";
            this.lblEstadoC.Size = new System.Drawing.Size(51, 16);
            this.lblEstadoC.TabIndex = 17;
            this.lblEstadoC.Text = "Estado";
            // 
            // lblContratado
            // 
            this.lblContratado.AutoSize = true;
            this.lblContratado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContratado.Location = new System.Drawing.Point(37, 301);
            this.lblContratado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContratado.Name = "lblContratado";
            this.lblContratado.Size = new System.Drawing.Size(134, 20);
            this.lblContratado.TabIndex = 19;
            this.lblContratado.Text = "CONTRATADO:";
            // 
            // txtEstadoE
            // 
            this.txtEstadoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoE.Location = new System.Drawing.Point(363, 415);
            this.txtEstadoE.Name = "txtEstadoE";
            this.txtEstadoE.Size = new System.Drawing.Size(124, 22);
            this.txtEstadoE.TabIndex = 35;
            this.txtEstadoE.Text = "São Paulo";
            this.txtEstadoE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEstadoE
            // 
            this.lblEstadoE.AutoSize = true;
            this.lblEstadoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoE.Location = new System.Drawing.Point(299, 420);
            this.lblEstadoE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoE.Name = "lblEstadoE";
            this.lblEstadoE.Size = new System.Drawing.Size(51, 16);
            this.lblEstadoE.TabIndex = 34;
            this.lblEstadoE.Text = "Estado";
            // 
            // txtCidadeE
            // 
            this.txtCidadeE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeE.Location = new System.Drawing.Point(97, 415);
            this.txtCidadeE.Name = "txtCidadeE";
            this.txtCidadeE.Size = new System.Drawing.Size(185, 22);
            this.txtCidadeE.TabIndex = 33;
            this.txtCidadeE.Text = "Presidente Prudente";
            this.txtCidadeE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCidadeE
            // 
            this.lblCidadeE.AutoSize = true;
            this.lblCidadeE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeE.Location = new System.Drawing.Point(38, 420);
            this.lblCidadeE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidadeE.Name = "lblCidadeE";
            this.lblCidadeE.Size = new System.Drawing.Size(52, 16);
            this.lblCidadeE.TabIndex = 32;
            this.lblCidadeE.Text = "Cidade";
            // 
            // txtCepE
            // 
            this.txtCepE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCepE.Location = new System.Drawing.Point(563, 386);
            this.txtCepE.Name = "txtCepE";
            this.txtCepE.Size = new System.Drawing.Size(204, 22);
            this.txtCepE.TabIndex = 31;
            this.txtCepE.Text = "19065-510";
            this.txtCepE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCepE
            // 
            this.lblCepE.AutoSize = true;
            this.lblCepE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCepE.Location = new System.Drawing.Point(515, 391);
            this.lblCepE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCepE.Name = "lblCepE";
            this.lblCepE.Size = new System.Drawing.Size(35, 16);
            this.lblCepE.TabIndex = 30;
            this.lblCepE.Text = "CEP";
            // 
            // txtBairroE
            // 
            this.txtBairroE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroE.Location = new System.Drawing.Point(302, 386);
            this.txtBairroE.Name = "txtBairroE";
            this.txtBairroE.Size = new System.Drawing.Size(185, 22);
            this.txtBairroE.TabIndex = 29;
            this.txtBairroE.Text = "Cecap";
            this.txtBairroE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBairroE
            // 
            this.lblBairroE.AutoSize = true;
            this.lblBairroE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairroE.Location = new System.Drawing.Point(242, 391);
            this.lblBairroE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairroE.Name = "lblBairroE";
            this.lblBairroE.Size = new System.Drawing.Size(44, 16);
            this.lblBairroE.TabIndex = 28;
            this.lblBairroE.Text = "Bairro";
            // 
            // txtNumeroE
            // 
            this.txtNumeroE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroE.Location = new System.Drawing.Point(97, 386);
            this.txtNumeroE.Name = "txtNumeroE";
            this.txtNumeroE.Size = new System.Drawing.Size(96, 22);
            this.txtNumeroE.TabIndex = 27;
            this.txtNumeroE.Text = "210";
            this.txtNumeroE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNumeroE
            // 
            this.lblNumeroE.AutoSize = true;
            this.lblNumeroE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroE.Location = new System.Drawing.Point(38, 391);
            this.lblNumeroE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroE.Name = "lblNumeroE";
            this.lblNumeroE.Size = new System.Drawing.Size(23, 16);
            this.lblNumeroE.TabIndex = 26;
            this.lblNumeroE.Text = "Nº";
            // 
            // txtEnderecoE
            // 
            this.txtEnderecoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoE.Location = new System.Drawing.Point(389, 357);
            this.txtEnderecoE.Name = "txtEnderecoE";
            this.txtEnderecoE.Size = new System.Drawing.Size(378, 22);
            this.txtEnderecoE.TabIndex = 25;
            this.txtEnderecoE.Text = "Avenida das Flores";
            this.txtEnderecoE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEnderecoE
            // 
            this.lblEnderecoE.AutoSize = true;
            this.lblEnderecoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoE.Location = new System.Drawing.Point(321, 362);
            this.lblEnderecoE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnderecoE.Name = "lblEnderecoE";
            this.lblEnderecoE.Size = new System.Drawing.Size(67, 16);
            this.lblEnderecoE.TabIndex = 24;
            this.lblEnderecoE.Text = "Endereço";
            // 
            // txtCnpjE
            // 
            this.txtCnpjE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpjE.Location = new System.Drawing.Point(97, 357);
            this.txtCnpjE.Name = "txtCnpjE";
            this.txtCnpjE.Size = new System.Drawing.Size(204, 22);
            this.txtCnpjE.TabIndex = 23;
            this.txtCnpjE.Text = "30.286.217/0001-70";
            this.txtCnpjE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeE
            // 
            this.txtNomeE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeE.Location = new System.Drawing.Point(97, 324);
            this.txtNomeE.Name = "txtNomeE";
            this.txtNomeE.Size = new System.Drawing.Size(390, 22);
            this.txtNomeE.TabIndex = 22;
            this.txtNomeE.Text = "Lucas Beirigo Reggiani";
            this.txtNomeE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCnpjE
            // 
            this.lblCnpjE.AutoSize = true;
            this.lblCnpjE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpjE.Location = new System.Drawing.Point(38, 362);
            this.lblCnpjE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCnpjE.Name = "lblCnpjE";
            this.lblCnpjE.Size = new System.Drawing.Size(43, 16);
            this.lblCnpjE.TabIndex = 21;
            this.lblCnpjE.Text = "CNPJ";
            // 
            // lblNomeE
            // 
            this.lblNomeE.AutoSize = true;
            this.lblNomeE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeE.Location = new System.Drawing.Point(38, 329);
            this.lblNomeE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeE.Name = "lblNomeE";
            this.lblNomeE.Size = new System.Drawing.Size(45, 16);
            this.lblNomeE.TabIndex = 20;
            this.lblNomeE.Text = "Nome";
            // 
            // txtCpfE
            // 
            this.txtCpfE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfE.Location = new System.Drawing.Point(563, 324);
            this.txtCpfE.Name = "txtCpfE";
            this.txtCpfE.Size = new System.Drawing.Size(204, 22);
            this.txtCpfE.TabIndex = 37;
            this.txtCpfE.Text = "093.967.599-45";
            this.txtCpfE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCpfE
            // 
            this.lblCpfE.AutoSize = true;
            this.lblCpfE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfE.Location = new System.Drawing.Point(516, 329);
            this.lblCpfE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpfE.Name = "lblCpfE";
            this.lblCpfE.Size = new System.Drawing.Size(34, 16);
            this.lblCpfE.TabIndex = 36;
            this.lblCpfE.Text = "CPF";
            // 
            // lblObjetoServicos
            // 
            this.lblObjetoServicos.AutoSize = true;
            this.lblObjetoServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjetoServicos.Location = new System.Drawing.Point(37, 453);
            this.lblObjetoServicos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObjetoServicos.Name = "lblObjetoServicos";
            this.lblObjetoServicos.Size = new System.Drawing.Size(483, 20);
            this.lblObjetoServicos.TabIndex = 38;
            this.lblObjetoServicos.Text = "É objeto do presente contrato a prestação dos serviços de:";
            // 
            // dgvProdutosServicos
            // 
            this.dgvProdutosServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosServicos.Location = new System.Drawing.Point(41, 476);
            this.dgvProdutosServicos.Name = "dgvProdutosServicos";
            this.dgvProdutosServicos.Size = new System.Drawing.Size(726, 135);
            this.dgvProdutosServicos.TabIndex = 39;
            // 
            // lblRefValor
            // 
            this.lblRefValor.AutoSize = true;
            this.lblRefValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefValor.Location = new System.Drawing.Point(38, 623);
            this.lblRefValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefValor.Name = "lblRefValor";
            this.lblRefValor.Size = new System.Drawing.Size(174, 17);
            this.lblRefValor.TabIndex = 40;
            this.lblRefValor.Text = "Referente ao Valor de R$ ";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(219, 620);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(106, 22);
            this.txtValor.TabIndex = 41;
            // 
            // lblValorPorExtenso
            // 
            this.lblValorPorExtenso.AutoSize = true;
            this.lblValorPorExtenso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPorExtenso.Location = new System.Drawing.Point(332, 623);
            this.lblValorPorExtenso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorPorExtenso.Name = "lblValorPorExtenso";
            this.lblValorPorExtenso.Size = new System.Drawing.Size(129, 17);
            this.lblValorPorExtenso.TabIndex = 42;
            this.lblValorPorExtenso.Text = "(Valor por extenso)";
            // 
            // lblRefPrazo
            // 
            this.lblRefPrazo.AutoSize = true;
            this.lblRefPrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefPrazo.Location = new System.Drawing.Point(38, 650);
            this.lblRefPrazo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefPrazo.Name = "lblRefPrazo";
            this.lblRefPrazo.Size = new System.Drawing.Size(236, 17);
            this.lblRefPrazo.TabIndex = 43;
            this.lblRefPrazo.Text = "Referente ao prazo de entrega de : ";
            // 
            // txtDias
            // 
            this.txtDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.Location = new System.Drawing.Point(281, 647);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(44, 22);
            this.txtDias.TabIndex = 44;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(332, 650);
            this.lblDias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(153, 17);
            this.lblDias.TabIndex = 45;
            this.lblDias.Text = "Dias, a partir da data : ";
            // 
            // dtpDataaPartir
            // 
            this.dtpDataaPartir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataaPartir.Location = new System.Drawing.Point(490, 645);
            this.dtpDataaPartir.Name = "dtpDataaPartir";
            this.dtpDataaPartir.Size = new System.Drawing.Size(107, 23);
            this.dtpDataaPartir.TabIndex = 46;
            // 
            // lblAnos
            // 
            this.lblAnos.AutoSize = true;
            this.lblAnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnos.Location = new System.Drawing.Point(186, 680);
            this.lblAnos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnos.Name = "lblAnos";
            this.lblAnos.Size = new System.Drawing.Size(225, 17);
            this.lblAnos.TabIndex = 49;
            this.lblAnos.Text = "Anos contra defeito de fabricação.";
            // 
            // txtGarantia
            // 
            this.txtGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGarantia.Location = new System.Drawing.Point(135, 677);
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(44, 22);
            this.txtGarantia.TabIndex = 48;
            // 
            // lblGarantia
            // 
            this.lblGarantia.AutoSize = true;
            this.lblGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarantia.Location = new System.Drawing.Point(38, 680);
            this.lblGarantia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGarantia.Name = "lblGarantia";
            this.lblGarantia.Size = new System.Drawing.Size(95, 17);
            this.lblGarantia.TabIndex = 47;
            this.lblGarantia.Text = "Garantia de : ";
            // 
            // lblPpte
            // 
            this.lblPpte.AutoSize = true;
            this.lblPpte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPpte.Location = new System.Drawing.Point(174, 719);
            this.lblPpte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPpte.Name = "lblPpte";
            this.lblPpte.Size = new System.Drawing.Size(146, 17);
            this.lblPpte.TabIndex = 50;
            this.lblPpte.Text = "Presidente Prudente, ";
            // 
            // dtpDataAtual
            // 
            this.dtpDataAtual.Location = new System.Drawing.Point(325, 714);
            this.dtpDataAtual.Name = "dtpDataAtual";
            this.dtpDataAtual.Size = new System.Drawing.Size(272, 23);
            this.dtpDataAtual.TabIndex = 51;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(692, 707);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 41);
            this.btnSalvar.TabIndex = 52;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // cbxEstate
            // 
            this.cbxEstate.FormattingEnabled = true;
            this.cbxEstate.Location = new System.Drawing.Point(357, 271);
            this.cbxEstate.Name = "cbxEstate";
            this.cbxEstate.Size = new System.Drawing.Size(130, 24);
            this.cbxEstate.TabIndex = 53;
            // 
            // frmContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(814, 606);
            this.Controls.Add(this.cbxEstate);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtpDataAtual);
            this.Controls.Add(this.lblPpte);
            this.Controls.Add(this.lblAnos);
            this.Controls.Add(this.txtGarantia);
            this.Controls.Add(this.lblGarantia);
            this.Controls.Add(this.dtpDataaPartir);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.lblRefPrazo);
            this.Controls.Add(this.lblValorPorExtenso);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblRefValor);
            this.Controls.Add(this.dgvProdutosServicos);
            this.Controls.Add(this.lblObjetoServicos);
            this.Controls.Add(this.txtCpfE);
            this.Controls.Add(this.lblCpfE);
            this.Controls.Add(this.txtEstadoE);
            this.Controls.Add(this.lblEstadoE);
            this.Controls.Add(this.txtCidadeE);
            this.Controls.Add(this.lblCidadeE);
            this.Controls.Add(this.txtCepE);
            this.Controls.Add(this.lblCepE);
            this.Controls.Add(this.txtBairroE);
            this.Controls.Add(this.lblBairroE);
            this.Controls.Add(this.txtNumeroE);
            this.Controls.Add(this.lblNumeroE);
            this.Controls.Add(this.txtEnderecoE);
            this.Controls.Add(this.lblEnderecoE);
            this.Controls.Add(this.txtCnpjE);
            this.Controls.Add(this.txtNomeE);
            this.Controls.Add(this.lblCnpjE);
            this.Controls.Add(this.lblNomeE);
            this.Controls.Add(this.lblContratado);
            this.Controls.Add(this.lblEstadoC);
            this.Controls.Add(this.txtCidadeC);
            this.Controls.Add(this.lblCidadeC);
            this.Controls.Add(this.txtCepC);
            this.Controls.Add(this.lblCepC);
            this.Controls.Add(this.txtBairroC);
            this.Controls.Add(this.lblBairroC);
            this.Controls.Add(this.txtNumeroC);
            this.Controls.Add(this.lblNumeroC);
            this.Controls.Add(this.txtEnderecoC);
            this.Controls.Add(this.lblEnderecoC);
            this.Controls.Add(this.txtCpfCnpjC);
            this.Controls.Add(this.txtNomeC);
            this.Controls.Add(this.lblCpfCnpjC);
            this.Controls.Add(this.lblNomeC);
            this.Controls.Add(this.lblContrante);
            this.Controls.Add(this.lblTituloContrato);
            this.Controls.Add(this.picLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contrato de Serviços";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosServicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTituloContrato;
        private System.Windows.Forms.Label lblContrante;
        private System.Windows.Forms.Label lblNomeC;
        private System.Windows.Forms.Label lblCpfCnpjC;
        private System.Windows.Forms.TextBox txtNomeC;
        private System.Windows.Forms.TextBox txtCpfCnpjC;
        private System.Windows.Forms.TextBox txtEnderecoC;
        private System.Windows.Forms.Label lblEnderecoC;
        private System.Windows.Forms.TextBox txtNumeroC;
        private System.Windows.Forms.Label lblNumeroC;
        private System.Windows.Forms.TextBox txtBairroC;
        private System.Windows.Forms.Label lblBairroC;
        private System.Windows.Forms.TextBox txtCepC;
        private System.Windows.Forms.Label lblCepC;
        private System.Windows.Forms.TextBox txtCidadeC;
        private System.Windows.Forms.Label lblCidadeC;
        private System.Windows.Forms.Label lblEstadoC;
        private System.Windows.Forms.Label lblContratado;
        private System.Windows.Forms.TextBox txtEstadoE;
        private System.Windows.Forms.Label lblEstadoE;
        private System.Windows.Forms.TextBox txtCidadeE;
        private System.Windows.Forms.Label lblCidadeE;
        private System.Windows.Forms.TextBox txtCepE;
        private System.Windows.Forms.Label lblCepE;
        private System.Windows.Forms.TextBox txtBairroE;
        private System.Windows.Forms.Label lblBairroE;
        private System.Windows.Forms.TextBox txtNumeroE;
        private System.Windows.Forms.Label lblNumeroE;
        private System.Windows.Forms.TextBox txtEnderecoE;
        private System.Windows.Forms.Label lblEnderecoE;
        private System.Windows.Forms.TextBox txtCnpjE;
        private System.Windows.Forms.TextBox txtNomeE;
        private System.Windows.Forms.Label lblCnpjE;
        private System.Windows.Forms.Label lblNomeE;
        private System.Windows.Forms.TextBox txtCpfE;
        private System.Windows.Forms.Label lblCpfE;
        private System.Windows.Forms.Label lblObjetoServicos;
        private System.Windows.Forms.DataGridView dgvProdutosServicos;
        private System.Windows.Forms.Label lblRefValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValorPorExtenso;
        private System.Windows.Forms.Label lblRefPrazo;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.DateTimePicker dtpDataaPartir;
        private System.Windows.Forms.Label lblAnos;
        private System.Windows.Forms.TextBox txtGarantia;
        private System.Windows.Forms.Label lblGarantia;
        private System.Windows.Forms.Label lblPpte;
        private System.Windows.Forms.DateTimePicker dtpDataAtual;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbxEstate;
    }
}