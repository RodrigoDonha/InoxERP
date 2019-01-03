using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignIn));
            this.btnAcessar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.grpUsuario = new System.Windows.Forms.GroupBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.grpSenha = new System.Windows.Forms.GroupBox();
            this.btnVisualizarSenha = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpUsuario.SuspendLayout();
            this.grpSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAcessar.Location = new System.Drawing.Point(72, 320);
            this.btnAcessar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(80, 30);
            this.btnAcessar.TabIndex = 6;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = false;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gold;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(206, 320);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 30);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFechar.Location = new System.Drawing.Point(342, 320);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(80, 30);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // grpUsuario
            // 
            this.grpUsuario.Controls.Add(this.txtLogin);
            this.grpUsuario.Location = new System.Drawing.Point(72, 78);
            this.grpUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUsuario.Name = "grpUsuario";
            this.grpUsuario.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUsuario.Size = new System.Drawing.Size(345, 100);
            this.grpUsuario.TabIndex = 1;
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
            this.txtLogin.TabIndex = 3;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // grpSenha
            // 
            this.grpSenha.Controls.Add(this.btnVisualizarSenha);
            this.grpSenha.Controls.Add(this.txtSenha);
            this.grpSenha.Location = new System.Drawing.Point(72, 187);
            this.grpSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSenha.Name = "grpSenha";
            this.grpSenha.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSenha.Size = new System.Drawing.Size(345, 100);
            this.grpSenha.TabIndex = 2;
            this.grpSenha.TabStop = false;
            this.grpSenha.Text = "Senha";
            // 
            // btnVisualizarSenha
            // 
            this.btnVisualizarSenha.BackColor = System.Drawing.Color.White;
            this.btnVisualizarSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVisualizarSenha.BackgroundImage")));
            this.btnVisualizarSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVisualizarSenha.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVisualizarSenha.FlatAppearance.BorderSize = 0;
            this.btnVisualizarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVisualizarSenha.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizarSenha.Image")));
            this.btnVisualizarSenha.Location = new System.Drawing.Point(294, 44);
            this.btnVisualizarSenha.Name = "btnVisualizarSenha";
            this.btnVisualizarSenha.Padding = new System.Windows.Forms.Padding(3);
            this.btnVisualizarSenha.Size = new System.Drawing.Size(29, 17);
            this.btnVisualizarSenha.TabIndex = 5;
            this.btnVisualizarSenha.UseVisualStyleBackColor = false;
            this.btnVisualizarSenha.Click += new System.EventHandler(this.btnVisualizarSenha_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(19, 41);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenha.MaxLength = 100;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(307, 23);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UIWindows.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(150, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 372);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpSenha);
            this.Controls.Add(this.grpUsuario);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAcessar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso ao Usuário";
            this.grpUsuario.ResumeLayout(false);
            this.grpUsuario.PerformLayout();
            this.grpSenha.ResumeLayout(false);
            this.grpSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnVisualizarSenha;
        private PictureBox pictureBox1;
    }
}