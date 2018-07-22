namespace InoxERP.UI_Windows_Forms
{
    partial class ClientesForm
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
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(124, 31);
            this.btnSair.TabIndex = 34;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(823, 597);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 31);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.Green;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.White;
            this.btnGravar.Location = new System.Drawing.Point(691, 597);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(124, 31);
            this.btnGravar.TabIndex = 32;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // grpObservacoes
            // 
            this.grpObservacoes.Controls.Add(this.txtObservacoes);
            this.grpObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpObservacoes.Location = new System.Drawing.Point(11, 469);
            this.grpObservacoes.Name = "grpObservacoes";
            this.grpObservacoes.Size = new System.Drawing.Size(1068, 114);
            this.grpObservacoes.TabIndex = 31;
            this.grpObservacoes.TabStop = false;
            this.grpObservacoes.Text = "Observações";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(10, 26);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(1046, 68);
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
            this.grpContatos.Location = new System.Drawing.Point(11, 328);
            this.grpContatos.Name = "grpContatos";
            this.grpContatos.Size = new System.Drawing.Size(1068, 140);
            this.grpContatos.TabIndex = 30;
            this.grpContatos.TabStop = false;
            this.grpContatos.Text = "Contatos";
            // 
            // txtContatosCelular1
            // 
            this.txtContatosCelular1.Location = new System.Drawing.Point(151, 88);
            this.txtContatosCelular1.Name = "txtContatosCelular1";
            this.txtContatosCelular1.Size = new System.Drawing.Size(257, 27);
            this.txtContatosCelular1.TabIndex = 27;
            // 
            // lblContatosCelular1
            // 
            this.lblContatosCelular1.AutoSize = true;
            this.lblContatosCelular1.Location = new System.Drawing.Point(6, 91);
            this.lblContatosCelular1.Name = "lblContatosCelular1";
            this.lblContatosCelular1.Size = new System.Drawing.Size(67, 20);
            this.lblContatosCelular1.TabIndex = 26;
            this.lblContatosCelular1.Text = "Celular:";
            // 
            // txtContatosEmail
            // 
            this.txtContatosEmail.Location = new System.Drawing.Point(540, 36);
            this.txtContatosEmail.Name = "txtContatosEmail";
            this.txtContatosEmail.Size = new System.Drawing.Size(516, 27);
            this.txtContatosEmail.TabIndex = 25;
            // 
            // txtContatosCelular2
            // 
            this.txtContatosCelular2.Location = new System.Drawing.Point(540, 91);
            this.txtContatosCelular2.Name = "txtContatosCelular2";
            this.txtContatosCelular2.Size = new System.Drawing.Size(257, 27);
            this.txtContatosCelular2.TabIndex = 20;
            // 
            // txtContatosResidencial
            // 
            this.txtContatosResidencial.Location = new System.Drawing.Point(156, 36);
            this.txtContatosResidencial.Name = "txtContatosResidencial";
            this.txtContatosResidencial.Size = new System.Drawing.Size(252, 27);
            this.txtContatosResidencial.TabIndex = 19;
            // 
            // lblContatosEmail
            // 
            this.lblContatosEmail.AutoSize = true;
            this.lblContatosEmail.Location = new System.Drawing.Point(441, 39);
            this.lblContatosEmail.Name = "lblContatosEmail";
            this.lblContatosEmail.Size = new System.Drawing.Size(62, 20);
            this.lblContatosEmail.TabIndex = 17;
            this.lblContatosEmail.Text = "E-Mail:";
            // 
            // lblContatosResidencial
            // 
            this.lblContatosResidencial.AutoSize = true;
            this.lblContatosResidencial.Location = new System.Drawing.Point(6, 39);
            this.lblContatosResidencial.Name = "lblContatosResidencial";
            this.lblContatosResidencial.Size = new System.Drawing.Size(92, 20);
            this.lblContatosResidencial.TabIndex = 4;
            this.lblContatosResidencial.Text = "Res./Com.:";
            // 
            // lblContatosCelular2
            // 
            this.lblContatosCelular2.AutoSize = true;
            this.lblContatosCelular2.Location = new System.Drawing.Point(441, 94);
            this.lblContatosCelular2.Name = "lblContatosCelular2";
            this.lblContatosCelular2.Size = new System.Drawing.Size(67, 20);
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
            this.grpEndereco.Location = new System.Drawing.Point(11, 149);
            this.grpEndereco.Name = "grpEndereco";
            this.grpEndereco.Size = new System.Drawing.Size(1068, 178);
            this.grpEndereco.TabIndex = 29;
            this.grpEndereco.TabStop = false;
            this.grpEndereco.Text = "Endereço";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(871, 130);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(185, 27);
            this.txtCEP.TabIndex = 22;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(740, 130);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(69, 27);
            this.txtEstado.TabIndex = 21;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(156, 130);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(494, 27);
            this.txtCidade.TabIndex = 20;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(807, 85);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(249, 27);
            this.txtComplemento.TabIndex = 19;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(345, 85);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(305, 27);
            this.txtBairro.TabIndex = 18;
            // 
            // txtNumEndereco
            // 
            this.txtNumEndereco.Location = new System.Drawing.Point(156, 84);
            this.txtNumEndereco.Name = "txtNumEndereco";
            this.txtNumEndereco.Size = new System.Drawing.Size(97, 27);
            this.txtNumEndereco.TabIndex = 17;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(156, 41);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(900, 27);
            this.txtEndereco.TabIndex = 8;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(668, 87);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(117, 20);
            this.lblComplemento.TabIndex = 16;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(6, 43);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(85, 20);
            this.lblEndereco.TabIndex = 7;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblNumEndereco
            // 
            this.lblNumEndereco.AutoSize = true;
            this.lblNumEndereco.Location = new System.Drawing.Point(6, 87);
            this.lblNumEndereco.Name = "lblNumEndereco";
            this.lblNumEndereco.Size = new System.Drawing.Size(32, 20);
            this.lblNumEndereco.TabIndex = 8;
            this.lblNumEndereco.Text = "Nº:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(820, 133);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(48, 20);
            this.lblCEP.TabIndex = 12;
            this.lblCEP.Text = "CEP:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(266, 87);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(60, 20);
            this.lblBairro.TabIndex = 9;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(668, 134);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(66, 20);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(6, 133);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(66, 20);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidade:";
            // 
            // grpDadosPessoais
            // 
            this.grpDadosPessoais.Controls.Add(this.txtCPF_CNPJ);
            this.grpDadosPessoais.Controls.Add(this.txtNome);
            this.grpDadosPessoais.Controls.Add(this.lblNomeCompleto);
            this.grpDadosPessoais.Controls.Add(this.lblCPF_CNPJ);
            this.grpDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDadosPessoais.Location = new System.Drawing.Point(11, 18);
            this.grpDadosPessoais.Name = "grpDadosPessoais";
            this.grpDadosPessoais.Size = new System.Drawing.Size(1068, 130);
            this.grpDadosPessoais.TabIndex = 28;
            this.grpDadosPessoais.TabStop = false;
            this.grpDadosPessoais.Text = "Dados Pessoais";
            // 
            // txtCPF_CNPJ
            // 
            this.txtCPF_CNPJ.Location = new System.Drawing.Point(156, 78);
            this.txtCPF_CNPJ.Name = "txtCPF_CNPJ";
            this.txtCPF_CNPJ.Size = new System.Drawing.Size(295, 27);
            this.txtCPF_CNPJ.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(156, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(900, 27);
            this.txtNome.TabIndex = 4;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(6, 41);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(131, 20);
            this.lblNomeCompleto.TabIndex = 0;
            this.lblNomeCompleto.Text = "Nome completo:";
            // 
            // lblCPF_CNPJ
            // 
            this.lblCPF_CNPJ.AutoSize = true;
            this.lblCPF_CNPJ.Location = new System.Drawing.Point(6, 81);
            this.lblCPF_CNPJ.Name = "lblCPF_CNPJ";
            this.lblCPF_CNPJ.Size = new System.Drawing.Size(134, 20);
            this.lblCPF_CNPJ.TabIndex = 1;
            this.lblCPF_CNPJ.Text = "C.P.F. / C.N.P.J.:";
            // 
            // ClientesForm
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
            this.Name = "ClientesForm";
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
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Label lblCPF_CNPJ;
        private System.Windows.Forms.TextBox txtContatosCelular1;
        private System.Windows.Forms.Label lblContatosCelular1;
    }
}