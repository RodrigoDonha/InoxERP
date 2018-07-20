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
            this.btSair = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.gpbObservacoes = new System.Windows.Forms.GroupBox();
            this.txbObservacoes = new System.Windows.Forms.TextBox();
            this.gpbContatos = new System.Windows.Forms.GroupBox();
            this.txbContatosEmail = new System.Windows.Forms.TextBox();
            this.txbContatosCelular2 = new System.Windows.Forms.TextBox();
            this.txbContatosResidencial = new System.Windows.Forms.TextBox();
            this.lbContatosEmail = new System.Windows.Forms.Label();
            this.lbContatosResidencial = new System.Windows.Forms.Label();
            this.lbContatosCelular2 = new System.Windows.Forms.Label();
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.txbCEP = new System.Windows.Forms.TextBox();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.txtbCidade = new System.Windows.Forms.TextBox();
            this.txtbComplemento = new System.Windows.Forms.TextBox();
            this.txtbBairro = new System.Windows.Forms.TextBox();
            this.txtbNumEndereco = new System.Windows.Forms.TextBox();
            this.txtbEndereco = new System.Windows.Forms.TextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbNumEndereco = new System.Windows.Forms.Label();
            this.lbCEP = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.txtbCPF_CNPJ = new System.Windows.Forms.TextBox();
            this.txtbNomeCompleto = new System.Windows.Forms.TextBox();
            this.lbNomeCompleto = new System.Windows.Forms.Label();
            this.lbCPF_CNPJ = new System.Windows.Forms.Label();
            this.txbContatosCelular1 = new System.Windows.Forms.TextBox();
            this.lbContatosCelular1 = new System.Windows.Forms.Label();
            this.gpbObservacoes.SuspendLayout();
            this.gpbContatos.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            this.gpbDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(956, 597);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(124, 31);
            this.btSair.TabIndex = 34;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Red;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(823, 597);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(124, 31);
            this.btCancelar.TabIndex = 33;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.Color.Green;
            this.btGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravar.ForeColor = System.Drawing.Color.White;
            this.btGravar.Location = new System.Drawing.Point(691, 597);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(124, 31);
            this.btGravar.TabIndex = 32;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = false;
            // 
            // gpbObservacoes
            // 
            this.gpbObservacoes.Controls.Add(this.txbObservacoes);
            this.gpbObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbObservacoes.Location = new System.Drawing.Point(11, 469);
            this.gpbObservacoes.Name = "gpbObservacoes";
            this.gpbObservacoes.Size = new System.Drawing.Size(1068, 114);
            this.gpbObservacoes.TabIndex = 31;
            this.gpbObservacoes.TabStop = false;
            this.gpbObservacoes.Text = "Observações";
            // 
            // txbObservacoes
            // 
            this.txbObservacoes.Location = new System.Drawing.Point(10, 26);
            this.txbObservacoes.Multiline = true;
            this.txbObservacoes.Name = "txbObservacoes";
            this.txbObservacoes.Size = new System.Drawing.Size(1046, 68);
            this.txbObservacoes.TabIndex = 0;
            // 
            // gpbContatos
            // 
            this.gpbContatos.Controls.Add(this.txbContatosCelular1);
            this.gpbContatos.Controls.Add(this.lbContatosCelular1);
            this.gpbContatos.Controls.Add(this.txbContatosEmail);
            this.gpbContatos.Controls.Add(this.txbContatosCelular2);
            this.gpbContatos.Controls.Add(this.txbContatosResidencial);
            this.gpbContatos.Controls.Add(this.lbContatosEmail);
            this.gpbContatos.Controls.Add(this.lbContatosResidencial);
            this.gpbContatos.Controls.Add(this.lbContatosCelular2);
            this.gpbContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbContatos.Location = new System.Drawing.Point(11, 328);
            this.gpbContatos.Name = "gpbContatos";
            this.gpbContatos.Size = new System.Drawing.Size(1068, 140);
            this.gpbContatos.TabIndex = 30;
            this.gpbContatos.TabStop = false;
            this.gpbContatos.Text = "Contatos";
            // 
            // txbContatosEmail
            // 
            this.txbContatosEmail.Location = new System.Drawing.Point(540, 36);
            this.txbContatosEmail.Name = "txbContatosEmail";
            this.txbContatosEmail.Size = new System.Drawing.Size(516, 27);
            this.txbContatosEmail.TabIndex = 25;
            // 
            // txbContatosCelular2
            // 
            this.txbContatosCelular2.Location = new System.Drawing.Point(540, 91);
            this.txbContatosCelular2.Name = "txbContatosCelular2";
            this.txbContatosCelular2.Size = new System.Drawing.Size(257, 27);
            this.txbContatosCelular2.TabIndex = 20;
            // 
            // txbContatosResidencial
            // 
            this.txbContatosResidencial.Location = new System.Drawing.Point(156, 36);
            this.txbContatosResidencial.Name = "txbContatosResidencial";
            this.txbContatosResidencial.Size = new System.Drawing.Size(252, 27);
            this.txbContatosResidencial.TabIndex = 19;
            // 
            // lbContatosEmail
            // 
            this.lbContatosEmail.AutoSize = true;
            this.lbContatosEmail.Location = new System.Drawing.Point(441, 39);
            this.lbContatosEmail.Name = "lbContatosEmail";
            this.lbContatosEmail.Size = new System.Drawing.Size(62, 20);
            this.lbContatosEmail.TabIndex = 17;
            this.lbContatosEmail.Text = "E-Mail:";
            // 
            // lbContatosResidencial
            // 
            this.lbContatosResidencial.AutoSize = true;
            this.lbContatosResidencial.Location = new System.Drawing.Point(6, 39);
            this.lbContatosResidencial.Name = "lbContatosResidencial";
            this.lbContatosResidencial.Size = new System.Drawing.Size(92, 20);
            this.lbContatosResidencial.TabIndex = 4;
            this.lbContatosResidencial.Text = "Res./Com.:";
            // 
            // lbContatosCelular2
            // 
            this.lbContatosCelular2.AutoSize = true;
            this.lbContatosCelular2.Location = new System.Drawing.Point(441, 94);
            this.lbContatosCelular2.Name = "lbContatosCelular2";
            this.lbContatosCelular2.Size = new System.Drawing.Size(67, 20);
            this.lbContatosCelular2.TabIndex = 5;
            this.lbContatosCelular2.Text = "Celular:";
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.Controls.Add(this.txbCEP);
            this.gpbEndereco.Controls.Add(this.txbEstado);
            this.gpbEndereco.Controls.Add(this.txtbCidade);
            this.gpbEndereco.Controls.Add(this.txtbComplemento);
            this.gpbEndereco.Controls.Add(this.txtbBairro);
            this.gpbEndereco.Controls.Add(this.txtbNumEndereco);
            this.gpbEndereco.Controls.Add(this.txtbEndereco);
            this.gpbEndereco.Controls.Add(this.lbComplemento);
            this.gpbEndereco.Controls.Add(this.lbEndereco);
            this.gpbEndereco.Controls.Add(this.lbNumEndereco);
            this.gpbEndereco.Controls.Add(this.lbCEP);
            this.gpbEndereco.Controls.Add(this.lbBairro);
            this.gpbEndereco.Controls.Add(this.lbEstado);
            this.gpbEndereco.Controls.Add(this.lbCidade);
            this.gpbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEndereco.Location = new System.Drawing.Point(11, 149);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Size = new System.Drawing.Size(1068, 178);
            this.gpbEndereco.TabIndex = 29;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço";
            // 
            // txbCEP
            // 
            this.txbCEP.Location = new System.Drawing.Point(871, 130);
            this.txbCEP.Name = "txbCEP";
            this.txbCEP.Size = new System.Drawing.Size(185, 27);
            this.txbCEP.TabIndex = 22;
            // 
            // txbEstado
            // 
            this.txbEstado.Location = new System.Drawing.Point(740, 130);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(69, 27);
            this.txbEstado.TabIndex = 21;
            // 
            // txtbCidade
            // 
            this.txtbCidade.Location = new System.Drawing.Point(156, 130);
            this.txtbCidade.Name = "txtbCidade";
            this.txtbCidade.Size = new System.Drawing.Size(494, 27);
            this.txtbCidade.TabIndex = 20;
            // 
            // txtbComplemento
            // 
            this.txtbComplemento.Location = new System.Drawing.Point(807, 85);
            this.txtbComplemento.Name = "txtbComplemento";
            this.txtbComplemento.Size = new System.Drawing.Size(249, 27);
            this.txtbComplemento.TabIndex = 19;
            // 
            // txtbBairro
            // 
            this.txtbBairro.Location = new System.Drawing.Point(345, 85);
            this.txtbBairro.Name = "txtbBairro";
            this.txtbBairro.Size = new System.Drawing.Size(305, 27);
            this.txtbBairro.TabIndex = 18;
            // 
            // txtbNumEndereco
            // 
            this.txtbNumEndereco.Location = new System.Drawing.Point(156, 84);
            this.txtbNumEndereco.Name = "txtbNumEndereco";
            this.txtbNumEndereco.Size = new System.Drawing.Size(97, 27);
            this.txtbNumEndereco.TabIndex = 17;
            // 
            // txtbEndereco
            // 
            this.txtbEndereco.Location = new System.Drawing.Point(156, 41);
            this.txtbEndereco.Name = "txtbEndereco";
            this.txtbEndereco.Size = new System.Drawing.Size(900, 27);
            this.txtbEndereco.TabIndex = 8;
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Location = new System.Drawing.Point(668, 87);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(117, 20);
            this.lbComplemento.TabIndex = 16;
            this.lbComplemento.Text = "Complemento:";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(6, 43);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(85, 20);
            this.lbEndereco.TabIndex = 7;
            this.lbEndereco.Text = "Endereço:";
            // 
            // lbNumEndereco
            // 
            this.lbNumEndereco.AutoSize = true;
            this.lbNumEndereco.Location = new System.Drawing.Point(6, 87);
            this.lbNumEndereco.Name = "lbNumEndereco";
            this.lbNumEndereco.Size = new System.Drawing.Size(32, 20);
            this.lbNumEndereco.TabIndex = 8;
            this.lbNumEndereco.Text = "Nº:";
            // 
            // lbCEP
            // 
            this.lbCEP.AutoSize = true;
            this.lbCEP.Location = new System.Drawing.Point(820, 133);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(48, 20);
            this.lbCEP.TabIndex = 12;
            this.lbCEP.Text = "CEP:";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(266, 87);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(60, 20);
            this.lbBairro.TabIndex = 9;
            this.lbBairro.Text = "Bairro:";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(668, 134);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(66, 20);
            this.lbEstado.TabIndex = 11;
            this.lbEstado.Text = "Estado:";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(6, 133);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(66, 20);
            this.lbCidade.TabIndex = 10;
            this.lbCidade.Text = "Cidade:";
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.Controls.Add(this.txtbCPF_CNPJ);
            this.gpbDadosPessoais.Controls.Add(this.txtbNomeCompleto);
            this.gpbDadosPessoais.Controls.Add(this.lbNomeCompleto);
            this.gpbDadosPessoais.Controls.Add(this.lbCPF_CNPJ);
            this.gpbDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosPessoais.Location = new System.Drawing.Point(11, 18);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(1068, 130);
            this.gpbDadosPessoais.TabIndex = 28;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "Dados Pessoais";
            // 
            // txtbCPF_CNPJ
            // 
            this.txtbCPF_CNPJ.Location = new System.Drawing.Point(156, 78);
            this.txtbCPF_CNPJ.Name = "txtbCPF_CNPJ";
            this.txtbCPF_CNPJ.Size = new System.Drawing.Size(295, 27);
            this.txtbCPF_CNPJ.TabIndex = 5;
            // 
            // txtbNomeCompleto
            // 
            this.txtbNomeCompleto.Location = new System.Drawing.Point(156, 35);
            this.txtbNomeCompleto.Name = "txtbNomeCompleto";
            this.txtbNomeCompleto.Size = new System.Drawing.Size(900, 27);
            this.txtbNomeCompleto.TabIndex = 4;
            // 
            // lbNomeCompleto
            // 
            this.lbNomeCompleto.AutoSize = true;
            this.lbNomeCompleto.Location = new System.Drawing.Point(6, 41);
            this.lbNomeCompleto.Name = "lbNomeCompleto";
            this.lbNomeCompleto.Size = new System.Drawing.Size(131, 20);
            this.lbNomeCompleto.TabIndex = 0;
            this.lbNomeCompleto.Text = "Nome completo:";
            // 
            // lbCPF_CNPJ
            // 
            this.lbCPF_CNPJ.AutoSize = true;
            this.lbCPF_CNPJ.Location = new System.Drawing.Point(6, 81);
            this.lbCPF_CNPJ.Name = "lbCPF_CNPJ";
            this.lbCPF_CNPJ.Size = new System.Drawing.Size(134, 20);
            this.lbCPF_CNPJ.TabIndex = 1;
            this.lbCPF_CNPJ.Text = "C.P.F. / C.N.P.J.:";
            // 
            // txbContatosCelular1
            // 
            this.txbContatosCelular1.Location = new System.Drawing.Point(151, 88);
            this.txbContatosCelular1.Name = "txbContatosCelular1";
            this.txbContatosCelular1.Size = new System.Drawing.Size(257, 27);
            this.txbContatosCelular1.TabIndex = 27;
            // 
            // lbContatosCelular1
            // 
            this.lbContatosCelular1.AutoSize = true;
            this.lbContatosCelular1.Location = new System.Drawing.Point(6, 91);
            this.lbContatosCelular1.Name = "lbContatosCelular1";
            this.lbContatosCelular1.Size = new System.Drawing.Size(67, 20);
            this.lbContatosCelular1.TabIndex = 26;
            this.lbContatosCelular1.Text = "Celular:";
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 646);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.gpbObservacoes);
            this.Controls.Add(this.gpbContatos);
            this.Controls.Add(this.gpbEndereco);
            this.Controls.Add(this.gpbDadosPessoais);
            this.Name = "ClientesForm";
            this.Text = "Clientes";
            this.gpbObservacoes.ResumeLayout(false);
            this.gpbObservacoes.PerformLayout();
            this.gpbContatos.ResumeLayout(false);
            this.gpbContatos.PerformLayout();
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.GroupBox gpbObservacoes;
        private System.Windows.Forms.TextBox txbObservacoes;
        private System.Windows.Forms.GroupBox gpbContatos;
        private System.Windows.Forms.TextBox txbContatosEmail;
        private System.Windows.Forms.TextBox txbContatosCelular2;
        private System.Windows.Forms.TextBox txbContatosResidencial;
        private System.Windows.Forms.Label lbContatosEmail;
        private System.Windows.Forms.Label lbContatosResidencial;
        private System.Windows.Forms.Label lbContatosCelular2;
        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.TextBox txbCEP;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.TextBox txtbCidade;
        private System.Windows.Forms.TextBox txtbComplemento;
        private System.Windows.Forms.TextBox txtbBairro;
        private System.Windows.Forms.TextBox txtbNumEndereco;
        private System.Windows.Forms.TextBox txtbEndereco;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbNumEndereco;
        private System.Windows.Forms.Label lbCEP;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.TextBox txtbCPF_CNPJ;
        private System.Windows.Forms.TextBox txtbNomeCompleto;
        private System.Windows.Forms.Label lbNomeCompleto;
        private System.Windows.Forms.Label lbCPF_CNPJ;
        private System.Windows.Forms.TextBox txbContatosCelular1;
        private System.Windows.Forms.Label lbContatosCelular1;
    }
}