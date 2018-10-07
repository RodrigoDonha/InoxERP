namespace InoxERP.UI_Windows_Forms
{
    partial class frmClientsRegister
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.grpObservacoes = new System.Windows.Forms.GroupBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.grpContatos = new System.Windows.Forms.GroupBox();
            this.txtContatosCelular1 = new System.Windows.Forms.TextBox();
            this.lblContatosCelular1 = new System.Windows.Forms.Label();
            this.txtContatosEmail = new System.Windows.Forms.TextBox();
            this.txtContatosCelular2 = new System.Windows.Forms.TextBox();
            this.txtContatosResiCom = new System.Windows.Forms.TextBox();
            this.lblContatosEmail = new System.Windows.Forms.Label();
            this.lblContatosResidencial = new System.Windows.Forms.Label();
            this.lblContatosCelular2 = new System.Windows.Forms.Label();
            this.grpEndereco = new System.Windows.Forms.GroupBox();
            this.cmbEstate = new System.Windows.Forms.ComboBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumEndereco = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNumEndereco = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.grpDadosPessoais = new System.Windows.Forms.GroupBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblCargoProfissao = new System.Windows.Forms.Label();
            this.radIndustrial = new System.Windows.Forms.RadioButton();
            this.radResidencial = new System.Windows.Forms.RadioButton();
            this.radComercial = new System.Windows.Forms.RadioButton();
            this.txtCPF_CNPJ = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.lblCPF_CNPJ = new System.Windows.Forms.Label();
            this.grpObservacoes.SuspendLayout();
            this.grpContatos.SuspendLayout();
            this.grpEndereco.SuspendLayout();
            this.grpDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(956, 597);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(124, 31);
            this.btnSair.TabIndex = 21;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(823, 597);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 31);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.Green;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.White;
            this.btnGravar.Location = new System.Drawing.Point(691, 597);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(124, 31);
            this.btnGravar.TabIndex = 19;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // grpObservacoes
            // 
            this.grpObservacoes.Controls.Add(this.txtObservacoes);
            this.grpObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpObservacoes.Location = new System.Drawing.Point(11, 469);
            this.grpObservacoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpObservacoes.Name = "grpObservacoes";
            this.grpObservacoes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpObservacoes.Size = new System.Drawing.Size(1068, 114);
            this.grpObservacoes.TabIndex = 4;
            this.grpObservacoes.TabStop = false;
            this.grpObservacoes.Text = "Observações";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(11, 26);
            this.txtObservacoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservacoes.MaxLength = 300;
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(1047, 68);
            this.txtObservacoes.TabIndex = 18;
            // 
            // grpContatos
            // 
            this.grpContatos.Controls.Add(this.txtContatosCelular1);
            this.grpContatos.Controls.Add(this.lblContatosCelular1);
            this.grpContatos.Controls.Add(this.txtContatosEmail);
            this.grpContatos.Controls.Add(this.txtContatosCelular2);
            this.grpContatos.Controls.Add(this.txtContatosResiCom);
            this.grpContatos.Controls.Add(this.lblContatosEmail);
            this.grpContatos.Controls.Add(this.lblContatosResidencial);
            this.grpContatos.Controls.Add(this.lblContatosCelular2);
            this.grpContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContatos.Location = new System.Drawing.Point(11, 327);
            this.grpContatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpContatos.Name = "grpContatos";
            this.grpContatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpContatos.Size = new System.Drawing.Size(1068, 140);
            this.grpContatos.TabIndex = 3;
            this.grpContatos.TabStop = false;
            this.grpContatos.Text = "Contatos";
            // 
            // txtContatosCelular1
            // 
            this.txtContatosCelular1.Location = new System.Drawing.Point(151, 89);
            this.txtContatosCelular1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContatosCelular1.MaxLength = 15;
            this.txtContatosCelular1.Name = "txtContatosCelular1";
            this.txtContatosCelular1.Size = new System.Drawing.Size(257, 23);
            this.txtContatosCelular1.TabIndex = 16;
            // 
            // lblContatosCelular1
            // 
            this.lblContatosCelular1.AutoSize = true;
            this.lblContatosCelular1.Location = new System.Drawing.Point(5, 91);
            this.lblContatosCelular1.Name = "lblContatosCelular1";
            this.lblContatosCelular1.Size = new System.Drawing.Size(56, 17);
            this.lblContatosCelular1.TabIndex = 26;
            this.lblContatosCelular1.Text = "Celular:";
            // 
            // txtContatosEmail
            // 
            this.txtContatosEmail.Location = new System.Drawing.Point(540, 36);
            this.txtContatosEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContatosEmail.MaxLength = 100;
            this.txtContatosEmail.Name = "txtContatosEmail";
            this.txtContatosEmail.Size = new System.Drawing.Size(516, 23);
            this.txtContatosEmail.TabIndex = 15;
            // 
            // txtContatosCelular2
            // 
            this.txtContatosCelular2.Location = new System.Drawing.Point(540, 91);
            this.txtContatosCelular2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContatosCelular2.MaxLength = 15;
            this.txtContatosCelular2.Name = "txtContatosCelular2";
            this.txtContatosCelular2.Size = new System.Drawing.Size(257, 23);
            this.txtContatosCelular2.TabIndex = 17;
            // 
            // txtContatosResiCom
            // 
            this.txtContatosResiCom.Location = new System.Drawing.Point(156, 36);
            this.txtContatosResiCom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContatosResiCom.MaxLength = 14;
            this.txtContatosResiCom.Name = "txtContatosResiCom";
            this.txtContatosResiCom.Size = new System.Drawing.Size(252, 23);
            this.txtContatosResiCom.TabIndex = 14;
            // 
            // lblContatosEmail
            // 
            this.lblContatosEmail.AutoSize = true;
            this.lblContatosEmail.Location = new System.Drawing.Point(441, 39);
            this.lblContatosEmail.Name = "lblContatosEmail";
            this.lblContatosEmail.Size = new System.Drawing.Size(51, 17);
            this.lblContatosEmail.TabIndex = 17;
            this.lblContatosEmail.Text = "E-Mail:";
            // 
            // lblContatosResidencial
            // 
            this.lblContatosResidencial.AutoSize = true;
            this.lblContatosResidencial.Location = new System.Drawing.Point(5, 39);
            this.lblContatosResidencial.Name = "lblContatosResidencial";
            this.lblContatosResidencial.Size = new System.Drawing.Size(77, 17);
            this.lblContatosResidencial.TabIndex = 4;
            this.lblContatosResidencial.Text = "Res./Com.:";
            // 
            // lblContatosCelular2
            // 
            this.lblContatosCelular2.AutoSize = true;
            this.lblContatosCelular2.Location = new System.Drawing.Point(441, 94);
            this.lblContatosCelular2.Name = "lblContatosCelular2";
            this.lblContatosCelular2.Size = new System.Drawing.Size(56, 17);
            this.lblContatosCelular2.TabIndex = 5;
            this.lblContatosCelular2.Text = "Celular:";
            // 
            // grpEndereco
            // 
            this.grpEndereco.Controls.Add(this.cmbEstate);
            this.grpEndereco.Controls.Add(this.txtCEP);
            this.grpEndereco.Controls.Add(this.txtCidade);
            this.grpEndereco.Controls.Add(this.txtComplemento);
            this.grpEndereco.Controls.Add(this.txtBairro);
            this.grpEndereco.Controls.Add(this.txtNumEndereco);
            this.grpEndereco.Controls.Add(this.txtEndereco);
            this.grpEndereco.Controls.Add(this.lblComplemento);
            this.grpEndereco.Controls.Add(this.lblEndereco);
            this.grpEndereco.Controls.Add(this.lblNumEndereco);
            this.grpEndereco.Controls.Add(this.lblCEP);
            this.grpEndereco.Controls.Add(this.lblBairro);
            this.grpEndereco.Controls.Add(this.lblEstado);
            this.grpEndereco.Controls.Add(this.lblCidade);
            this.grpEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEndereco.Location = new System.Drawing.Point(11, 149);
            this.grpEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEndereco.Name = "grpEndereco";
            this.grpEndereco.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEndereco.Size = new System.Drawing.Size(1068, 178);
            this.grpEndereco.TabIndex = 2;
            this.grpEndereco.TabStop = false;
            this.grpEndereco.Text = "Endereço";
            // 
            // cmbEstate
            // 
            this.cmbEstate.FormattingEnabled = true;
            this.cmbEstate.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbEstate.Location = new System.Drawing.Point(730, 128);
            this.cmbEstate.Name = "cmbEstate";
            this.cmbEstate.Size = new System.Drawing.Size(74, 25);
            this.cmbEstate.TabIndex = 12;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(871, 130);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCEP.MaxLength = 9;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(185, 23);
            this.txtCEP.TabIndex = 13;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(156, 130);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCidade.MaxLength = 100;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(495, 23);
            this.txtCidade.TabIndex = 11;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(807, 85);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComplemento.MaxLength = 50;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(249, 23);
            this.txtComplemento.TabIndex = 10;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(345, 85);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(305, 23);
            this.txtBairro.TabIndex = 9;
            // 
            // txtNumEndereco
            // 
            this.txtNumEndereco.Location = new System.Drawing.Point(156, 84);
            this.txtNumEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumEndereco.MaxLength = 10;
            this.txtNumEndereco.Name = "txtNumEndereco";
            this.txtNumEndereco.Size = new System.Drawing.Size(97, 23);
            this.txtNumEndereco.TabIndex = 8;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(156, 41);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(900, 23);
            this.txtEndereco.TabIndex = 7;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(668, 87);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(98, 17);
            this.lblComplemento.TabIndex = 16;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(5, 43);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(73, 17);
            this.lblEndereco.TabIndex = 7;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblNumEndereco
            // 
            this.lblNumEndereco.AutoSize = true;
            this.lblNumEndereco.Location = new System.Drawing.Point(5, 87);
            this.lblNumEndereco.Name = "lblNumEndereco";
            this.lblNumEndereco.Size = new System.Drawing.Size(27, 17);
            this.lblNumEndereco.TabIndex = 8;
            this.lblNumEndereco.Text = "Nº:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(820, 133);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(39, 17);
            this.lblCEP.TabIndex = 12;
            this.lblCEP.Text = "CEP:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(267, 87);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(50, 17);
            this.lblBairro.TabIndex = 9;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(668, 134);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 17);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(5, 133);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(56, 17);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidade:";
            // 
            // grpDadosPessoais
            // 
            this.grpDadosPessoais.Controls.Add(this.txtCargo);
            this.grpDadosPessoais.Controls.Add(this.lblCargoProfissao);
            this.grpDadosPessoais.Controls.Add(this.radIndustrial);
            this.grpDadosPessoais.Controls.Add(this.radResidencial);
            this.grpDadosPessoais.Controls.Add(this.radComercial);
            this.grpDadosPessoais.Controls.Add(this.txtCPF_CNPJ);
            this.grpDadosPessoais.Controls.Add(this.txtNome);
            this.grpDadosPessoais.Controls.Add(this.lblNomeCompleto);
            this.grpDadosPessoais.Controls.Add(this.lblCPF_CNPJ);
            this.grpDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDadosPessoais.Location = new System.Drawing.Point(11, 18);
            this.grpDadosPessoais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDadosPessoais.Name = "grpDadosPessoais";
            this.grpDadosPessoais.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDadosPessoais.Size = new System.Drawing.Size(1068, 130);
            this.grpDadosPessoais.TabIndex = 1;
            this.grpDadosPessoais.TabStop = false;
            this.grpDadosPessoais.Text = "Dados Pessoais";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(864, 79);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCargo.MaxLength = 100;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(192, 23);
            this.txtCargo.TabIndex = 6;
            // 
            // lblCargoProfissao
            // 
            this.lblCargoProfissao.AutoSize = true;
            this.lblCargoProfissao.Location = new System.Drawing.Point(747, 82);
            this.lblCargoProfissao.Name = "lblCargoProfissao";
            this.lblCargoProfissao.Size = new System.Drawing.Size(113, 17);
            this.lblCargoProfissao.TabIndex = 35;
            this.lblCargoProfissao.Text = "Cargo/Profissão:";
            // 
            // radIndustrial
            // 
            this.radIndustrial.AutoSize = true;
            this.radIndustrial.Location = new System.Drawing.Point(656, 80);
            this.radIndustrial.Name = "radIndustrial";
            this.radIndustrial.Size = new System.Drawing.Size(83, 21);
            this.radIndustrial.TabIndex = 5;
            this.radIndustrial.Text = "Industrial";
            this.radIndustrial.UseVisualStyleBackColor = true;
            // 
            // radResidencial
            // 
            this.radResidencial.AutoSize = true;
            this.radResidencial.Location = new System.Drawing.Point(551, 79);
            this.radResidencial.Name = "radResidencial";
            this.radResidencial.Size = new System.Drawing.Size(99, 21);
            this.radResidencial.TabIndex = 4;
            this.radResidencial.Text = "Residêncial";
            this.radResidencial.UseVisualStyleBackColor = true;
            // 
            // radComercial
            // 
            this.radComercial.AutoSize = true;
            this.radComercial.Checked = true;
            this.radComercial.Location = new System.Drawing.Point(457, 78);
            this.radComercial.Name = "radComercial";
            this.radComercial.Size = new System.Drawing.Size(88, 21);
            this.radComercial.TabIndex = 3;
            this.radComercial.TabStop = true;
            this.radComercial.Text = "Comercial";
            this.radComercial.UseVisualStyleBackColor = true;
            // 
            // txtCPF_CNPJ
            // 
            this.txtCPF_CNPJ.Location = new System.Drawing.Point(156, 78);
            this.txtCPF_CNPJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPF_CNPJ.MaxLength = 18;
            this.txtCPF_CNPJ.Name = "txtCPF_CNPJ";
            this.txtCPF_CNPJ.Size = new System.Drawing.Size(295, 23);
            this.txtCPF_CNPJ.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(156, 34);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(900, 23);
            this.txtNome.TabIndex = 1;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(5, 41);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(110, 17);
            this.lblNomeCompleto.TabIndex = 0;
            this.lblNomeCompleto.Text = "Nome completo:";
            // 
            // lblCPF_CNPJ
            // 
            this.lblCPF_CNPJ.AutoSize = true;
            this.lblCPF_CNPJ.Location = new System.Drawing.Point(5, 81);
            this.lblCPF_CNPJ.Name = "lblCPF_CNPJ";
            this.lblCPF_CNPJ.Size = new System.Drawing.Size(113, 17);
            this.lblCPF_CNPJ.TabIndex = 1;
            this.lblCPF_CNPJ.Text = "C.P.F. / C.N.P.J.:";
            // 
            // frmClientsRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 646);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.grpObservacoes);
            this.Controls.Add(this.grpContatos);
            this.Controls.Add(this.grpEndereco);
            this.Controls.Add(this.grpDadosPessoais);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmClientsRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.grpObservacoes.ResumeLayout(false);
            this.grpObservacoes.PerformLayout();
            this.grpContatos.ResumeLayout(false);
            this.grpContatos.PerformLayout();
            this.grpEndereco.ResumeLayout(false);
            this.grpEndereco.PerformLayout();
            this.grpDadosPessoais.ResumeLayout(false);
            this.grpDadosPessoais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox grpObservacoes;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.GroupBox grpContatos;
        private System.Windows.Forms.TextBox txtContatosEmail;
        private System.Windows.Forms.TextBox txtContatosCelular2;
        private System.Windows.Forms.TextBox txtContatosResiCom;
        private System.Windows.Forms.Label lblContatosEmail;
        private System.Windows.Forms.Label lblContatosResidencial;
        private System.Windows.Forms.Label lblContatosCelular2;
        private System.Windows.Forms.GroupBox grpEndereco;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNumEndereco;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.GroupBox grpDadosPessoais;
        private System.Windows.Forms.TextBox txtCPF_CNPJ;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Label lblCPF_CNPJ;
        private System.Windows.Forms.TextBox txtContatosCelular1;
        private System.Windows.Forms.Label lblContatosCelular1;
        private System.Windows.Forms.RadioButton radIndustrial;
        private System.Windows.Forms.RadioButton radResidencial;
        private System.Windows.Forms.RadioButton radComercial;
        private System.Windows.Forms.ComboBox cmbEstate;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblCargoProfissao;
    }
}