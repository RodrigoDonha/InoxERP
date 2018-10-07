namespace UIWindows
{
    partial class frmSignIn
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
            this.btnAcessar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.grpUsuario = new System.Windows.Forms.GroupBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.grpSenha = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.grpUsuario.SuspendLayout();
            this.grpSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAcessar.Location = new System.Drawing.Point(63, 284);
            this.btnAcessar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(80, 30);
            this.btnAcessar.TabIndex = 4;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = false;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gold;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(197, 284);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 30);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFechar.Location = new System.Drawing.Point(333, 284);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(80, 30);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // grpUsuario
            // 
            this.grpUsuario.Controls.Add(this.txtLogin);
            this.grpUsuario.Location = new System.Drawing.Point(63, 50);
            this.grpUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUsuario.Name = "grpUsuario";
            this.grpUsuario.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUsuario.Size = new System.Drawing.Size(345, 100);
            this.grpUsuario.TabIndex = 0;
            this.grpUsuario.TabStop = false;
            this.grpUsuario.Text = "Usuário";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(19, 47);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLogin.MaxLength = 100;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(307, 23);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // grpSenha
            // 
            this.grpSenha.Controls.Add(this.txtSenha);
            this.grpSenha.Location = new System.Drawing.Point(63, 151);
            this.grpSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSenha.Name = "grpSenha";
            this.grpSenha.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSenha.Size = new System.Drawing.Size(345, 100);
            this.grpSenha.TabIndex = 2;
            this.grpSenha.TabStop = false;
            this.grpSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(19, 42);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenha.MaxLength = 100;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(307, 23);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 362);
            this.Controls.Add(this.grpSenha);
            this.Controls.Add(this.grpUsuario);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAcessar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso ao Usuário";
            this.grpUsuario.ResumeLayout(false);
            this.grpUsuario.PerformLayout();
            this.grpSenha.ResumeLayout(false);
            this.grpSenha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.GroupBox grpUsuario;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.GroupBox grpSenha;
        private System.Windows.Forms.TextBox txtSenha;
    }
}