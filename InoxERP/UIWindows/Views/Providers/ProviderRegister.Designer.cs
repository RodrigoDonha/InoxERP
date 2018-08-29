namespace InoxERP.UI_Windows_Forms
{
    partial class frmProviderRegister
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
            this.txtContatosResidencial = new System.Windows.Forms.TextBox();
            this.lblContatosEmail = new System.Windows.Forms.Label();
            this.lblContatosResidencial = new System.Windows.Forms.Label();
            this.lblContatosCelular2 = new System.Windows.Forms.Label();
            this.grpEndereco = new System.Windows.Forms.GroupBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
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
            this.txtCPF_CNPJ = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF_CNPJ = new System.Windows.Forms.Label();
            this.grpDadosBancarios = new System.Windows.Forms.GroupBox();
            this.txtCompraMinima = new System.Windows.Forms.TextBox();
            this.lblCompraMinima = new System.Windows.Forms.Label();
            this.txtFavorecido = new System.Windows.Forms.TextBox();
            this.lblFavorecido = new System.Windows.Forms.Label();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.lblConta = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.grpObservacoes.SuspendLayout();
            this.grpContatos.SuspendLayout();
            this.grpEndereco.SuspendLayout();
            this.grpDadosPessoais.SuspendLayout();
            this.grpDadosBancarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(957, 603);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(124, 31);
            this.btnSair.TabIndex = 41;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(824, 603);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 31);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.Green;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.White;
            this.btnGravar.Location = new System.Drawing.Point(692, 603);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(124, 31);
            this.btnGravar.TabIndex = 39;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // grpObservacoes
            // 
            this.grpObservacoes.Controls.Add(this.txtObservacoes);
            this.grpObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpObservacoes.Location = new System.Drawing.Point(12, 520);
            this.grpObservacoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpObservacoes.Name = "grpObservacoes";
            this.grpObservacoes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpObservacoes.Size = new System.Drawing.Size(1068, 77);
            this.grpObservacoes.TabIndex = 38;
            this.grpObservacoes.TabStop = false;
            this.grpObservacoes.Text = "Observações";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(11, 26);
            this.txtObservacoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(1047, 35);
            this.txtObservacoes.TabIndex = 0;
            // 
            // grpContatos
            // 
            this.grpContatos.Controls.Add(this.txtContatosCelular1);
            this.grpContatos.Controls.Add(this.lblContatosCelular1);
            this.grpContatos.Controls.Add(this.txtContatosEmail);
            this.grpContatos.Controls.Add(this.txtContatosCelular2);
            this.grpContatos.Controls.Add(this.txtContatosResidencial);
            this.grpContatos.Controls.Add(this.lblContatosEmail);
            this.grpContatos.Controls.Add(this.lblContatosResidencial);
            this.grpContatos.Controls.Add(this.lblContatosCelular2);
            this.grpContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContatos.Location = new System.Drawing.Point(12, 264);
            this.grpContatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpContatos.Name = "grpContatos";
            this.grpContatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpContatos.Size = new System.Drawing.Size(1068, 121);
            this.grpContatos.TabIndex = 37;
            this.grpContatos.TabStop = false;
            this.grpContatos.Text = "Contatos";
            // 
            // txtContatosCelular1
            // 
            this.txtContatosCelular1.Location = new System.Drawing.Point(156, 79);
            this.txtContatosCelular1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContatosCelular1.Name = "txtContatosCelular1";
            this.txtContatosCelular1.Size = new System.Drawing.Size(252, 23);
            this.txtContatosCelular1.TabIndex = 27;
            // 
            // lblContatosCelular1
            // 
            this.lblContatosCelular1.AutoSize = true;
            this.lblContatosCelular1.Location = new System.Drawing.Point(5, 81);
            this.lblContatosCelular1.Name = "lblContatosCelular1";
            this.lblContatosCelular1.Size = new System.Drawing.Size(56, 17);
            this.lblContatosCelular1.TabIndex = 26;
            this.lblContatosCelular1.Text = "Celular:";
            // 
            // txtContatosEmail
            // 
            this.txtContatosEmail.Location = new System.Drawing.Point(571, 26);
            this.txtContatosEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContatosEmail.Name = "txtContatosEmail";
            this.txtContatosEmail.Size = new System.Drawing.Size(485, 23);
            this.txtContatosEmail.TabIndex = 25;
            // 
            // txtContatosCelular2
            // 
            this.txtContatosCelular2.Location = new System.Drawing.Point(571, 78);
            this.txtContatosCelular2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContatosCelular2.Name = "txtContatosCelular2";
            this.txtContatosCelular2.Size = new System.Drawing.Size(257, 23);
            this.txtContatosCelular2.TabIndex = 20;
            // 
            // txtContatosResidencial
            // 
            this.txtContatosResidencial.Location = new System.Drawing.Point(156, 26);
            this.txtContatosResidencial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContatosResidencial.Name = "txtContatosResidencial";
            this.txtContatosResidencial.Size = new System.Drawing.Size(252, 23);
            this.txtContatosResidencial.TabIndex = 19;
            // 
            // lblContatosEmail
            // 
            this.lblContatosEmail.AutoSize = true;
            this.lblContatosEmail.Location = new System.Drawing.Point(441, 29);
            this.lblContatosEmail.Name = "lblContatosEmail";
            this.lblContatosEmail.Size = new System.Drawing.Size(51, 17);
            this.lblContatosEmail.TabIndex = 17;
            this.lblContatosEmail.Text = "E-Mail:";
            // 
            // lblContatosResidencial
            // 
            this.lblContatosResidencial.AutoSize = true;
            this.lblContatosResidencial.Location = new System.Drawing.Point(5, 29);
            this.lblContatosResidencial.Name = "lblContatosResidencial";
            this.lblContatosResidencial.Size = new System.Drawing.Size(78, 17);
            this.lblContatosResidencial.TabIndex = 4;
            this.lblContatosResidencial.Text = "Comercial.:";
            // 
            // lblContatosCelular2
            // 
            this.lblContatosCelular2.AutoSize = true;
            this.lblContatosCelular2.Location = new System.Drawing.Point(441, 84);
            this.lblContatosCelular2.Name = "lblContatosCelular2";
            this.lblContatosCelular2.Size = new System.Drawing.Size(56, 17);
            this.lblContatosCelular2.TabIndex = 5;
            this.lblContatosCelular2.Text = "Celular:";
            // 
            // grpEndereco
            // 
            this.grpEndereco.Controls.Add(this.txtCEP);
            this.grpEndereco.Controls.Add(this.txtEstado);
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
            this.grpEndereco.Location = new System.Drawing.Point(12, 127);
            this.grpEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEndereco.Name = "grpEndereco";
            this.grpEndereco.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEndereco.Size = new System.Drawing.Size(1068, 137);
            this.grpEndereco.TabIndex = 36;
            this.grpEndereco.TabStop = false;
            this.grpEndereco.Text = "Endereço";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(871, 98);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(185, 23);
            this.txtCEP.TabIndex = 22;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(740, 98);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(69, 23);
            this.txtEstado.TabIndex = 21;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(156, 98);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(495, 23);
            this.txtCidade.TabIndex = 20;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(807, 61);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(249, 23);
            this.txtComplemento.TabIndex = 19;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(345, 61);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(305, 23);
            this.txtBairro.TabIndex = 18;
            // 
            // txtNumEndereco
            // 
            this.txtNumEndereco.Location = new System.Drawing.Point(156, 60);
            this.txtNumEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumEndereco.Name = "txtNumEndereco";
            this.txtNumEndereco.Size = new System.Drawing.Size(97, 23);
            this.txtNumEndereco.TabIndex = 17;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(156, 24);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(900, 23);
            this.txtEndereco.TabIndex = 8;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(668, 63);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(98, 17);
            this.lblComplemento.TabIndex = 16;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(5, 26);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(73, 17);
            this.lblEndereco.TabIndex = 7;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblNumEndereco
            // 
            this.lblNumEndereco.AutoSize = true;
            this.lblNumEndereco.Location = new System.Drawing.Point(8, 64);
            this.lblNumEndereco.Name = "lblNumEndereco";
            this.lblNumEndereco.Size = new System.Drawing.Size(27, 17);
            this.lblNumEndereco.TabIndex = 8;
            this.lblNumEndereco.Text = "Nº:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(820, 101);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(39, 17);
            this.lblCEP.TabIndex = 12;
            this.lblCEP.Text = "CEP:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(267, 63);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(50, 17);
            this.lblBairro.TabIndex = 9;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(668, 102);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 17);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(5, 101);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(56, 17);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidade:";
            // 
            // grpDadosPessoais
            // 
            this.grpDadosPessoais.Controls.Add(this.txtCPF_CNPJ);
            this.grpDadosPessoais.Controls.Add(this.txtNome);
            this.grpDadosPessoais.Controls.Add(this.lblNome);
            this.grpDadosPessoais.Controls.Add(this.lblCPF_CNPJ);
            this.grpDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDadosPessoais.Location = new System.Drawing.Point(12, 18);
            this.grpDadosPessoais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDadosPessoais.Name = "grpDadosPessoais";
            this.grpDadosPessoais.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDadosPessoais.Size = new System.Drawing.Size(1068, 108);
            this.grpDadosPessoais.TabIndex = 35;
            this.grpDadosPessoais.TabStop = false;
            this.grpDadosPessoais.Text = "Dados da Empresa";
            // 
            // txtCPF_CNPJ
            // 
            this.txtCPF_CNPJ.Location = new System.Drawing.Point(156, 67);
            this.txtCPF_CNPJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPF_CNPJ.Name = "txtCPF_CNPJ";
            this.txtCPF_CNPJ.Size = new System.Drawing.Size(295, 23);
            this.txtCPF_CNPJ.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(156, 23);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(900, 23);
            this.txtNome.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(5, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(110, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome completo:";
            // 
            // lblCPF_CNPJ
            // 
            this.lblCPF_CNPJ.AutoSize = true;
            this.lblCPF_CNPJ.Location = new System.Drawing.Point(5, 70);
            this.lblCPF_CNPJ.Name = "lblCPF_CNPJ";
            this.lblCPF_CNPJ.Size = new System.Drawing.Size(113, 17);
            this.lblCPF_CNPJ.TabIndex = 1;
            this.lblCPF_CNPJ.Text = "C.P.F. / C.N.P.J.:";
            // 
            // grpDadosBancarios
            // 
            this.grpDadosBancarios.Controls.Add(this.txtCompraMinima);
            this.grpDadosBancarios.Controls.Add(this.lblCompraMinima);
            this.grpDadosBancarios.Controls.Add(this.txtFavorecido);
            this.grpDadosBancarios.Controls.Add(this.lblFavorecido);
            this.grpDadosBancarios.Controls.Add(this.txtCpfCnpj);
            this.grpDadosBancarios.Controls.Add(this.lblCpfCnpj);
            this.grpDadosBancarios.Controls.Add(this.txtConta);
            this.grpDadosBancarios.Controls.Add(this.lblConta);
            this.grpDadosBancarios.Controls.Add(this.txtBanco);
            this.grpDadosBancarios.Controls.Add(this.lblBanco);
            this.grpDadosBancarios.Controls.Add(this.txtAgencia);
            this.grpDadosBancarios.Controls.Add(this.lblAgencia);
            this.grpDadosBancarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDadosBancarios.Location = new System.Drawing.Point(12, 385);
            this.grpDadosBancarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDadosBancarios.Name = "grpDadosBancarios";
            this.grpDadosBancarios.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDadosBancarios.Size = new System.Drawing.Size(1068, 135);
            this.grpDadosBancarios.TabIndex = 42;
            this.grpDadosBancarios.TabStop = false;
            this.grpDadosBancarios.Text = "Dados Bancários";
            // 
            // txtCompraMinima
            // 
            this.txtCompraMinima.Location = new System.Drawing.Point(571, 97);
            this.txtCompraMinima.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCompraMinima.Name = "txtCompraMinima";
            this.txtCompraMinima.Size = new System.Drawing.Size(252, 23);
            this.txtCompraMinima.TabIndex = 39;
            // 
            // lblCompraMinima
            // 
            this.lblCompraMinima.AutoSize = true;
            this.lblCompraMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompraMinima.Location = new System.Drawing.Point(441, 100);
            this.lblCompraMinima.Name = "lblCompraMinima";
            this.lblCompraMinima.Size = new System.Drawing.Size(123, 17);
            this.lblCompraMinima.TabIndex = 38;
            this.lblCompraMinima.Text = "Compra Mínima:";
            // 
            // txtFavorecido
            // 
            this.txtFavorecido.Location = new System.Drawing.Point(571, 26);
            this.txtFavorecido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFavorecido.Name = "txtFavorecido";
            this.txtFavorecido.Size = new System.Drawing.Size(485, 23);
            this.txtFavorecido.TabIndex = 37;
            // 
            // lblFavorecido
            // 
            this.lblFavorecido.AutoSize = true;
            this.lblFavorecido.Location = new System.Drawing.Point(441, 29);
            this.lblFavorecido.Name = "lblFavorecido";
            this.lblFavorecido.Size = new System.Drawing.Size(86, 17);
            this.lblFavorecido.TabIndex = 36;
            this.lblFavorecido.Text = "Favorecido: ";
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(571, 59);
            this.txtCpfCnpj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(252, 23);
            this.txtCpfCnpj.TabIndex = 35;
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Location = new System.Drawing.Point(441, 62);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(77, 17);
            this.lblCpfCnpj.TabIndex = 34;
            this.lblCpfCnpj.Text = "CPF/CNPJ:";
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(156, 97);
            this.txtConta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(252, 23);
            this.txtConta.TabIndex = 33;
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(8, 100);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(49, 17);
            this.lblConta.TabIndex = 32;
            this.lblConta.Text = "Conta:";
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(156, 26);
            this.txtBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(252, 23);
            this.txtBanco.TabIndex = 31;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(8, 29);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(52, 17);
            this.lblBanco.TabIndex = 30;
            this.lblBanco.Text = "Banco:";
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(156, 59);
            this.txtAgencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(252, 23);
            this.txtAgencia.TabIndex = 29;
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Location = new System.Drawing.Point(8, 62);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(63, 17);
            this.lblAgencia.TabIndex = 28;
            this.lblAgencia.Text = "Agência:";
            // 
            // frmProviderRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 646);
            this.Controls.Add(this.grpDadosBancarios);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.grpObservacoes);
            this.Controls.Add(this.grpContatos);
            this.Controls.Add(this.grpEndereco);
            this.Controls.Add(this.grpDadosPessoais);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProviderRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores";
            this.grpObservacoes.ResumeLayout(false);
            this.grpObservacoes.PerformLayout();
            this.grpContatos.ResumeLayout(false);
            this.grpContatos.PerformLayout();
            this.grpEndereco.ResumeLayout(false);
            this.grpEndereco.PerformLayout();
            this.grpDadosPessoais.ResumeLayout(false);
            this.grpDadosPessoais.PerformLayout();
            this.grpDadosBancarios.ResumeLayout(false);
            this.grpDadosBancarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox grpObservacoes;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.GroupBox grpContatos;
        private System.Windows.Forms.TextBox txtContatosCelular1;
        private System.Windows.Forms.Label lblContatosCelular1;
        private System.Windows.Forms.TextBox txtContatosEmail;
        private System.Windows.Forms.TextBox txtContatosCelular2;
        private System.Windows.Forms.TextBox txtContatosResidencial;
        private System.Windows.Forms.Label lblContatosEmail;
        private System.Windows.Forms.Label lblContatosResidencial;
        private System.Windows.Forms.Label lblContatosCelular2;
        private System.Windows.Forms.GroupBox grpEndereco;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtEstado;
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
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF_CNPJ;
        private System.Windows.Forms.GroupBox grpDadosBancarios;
        private System.Windows.Forms.TextBox txtCompraMinima;
        private System.Windows.Forms.Label lblCompraMinima;
        private System.Windows.Forms.TextBox txtFavorecido;
        private System.Windows.Forms.Label lblFavorecido;
        private System.Windows.Forms.TextBox txtCpfCnpj;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.Label lblAgencia;
    }
}