namespace UIWindows
{
    partial class frmSelectProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectProvider));
            this.btnLucas = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRichard = new System.Windows.Forms.Button();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLucas
            // 
            this.btnLucas.Location = new System.Drawing.Point(9, 42);
            this.btnLucas.Margin = new System.Windows.Forms.Padding(4);
            this.btnLucas.Name = "btnLucas";
            this.btnLucas.Size = new System.Drawing.Size(160, 28);
            this.btnLucas.TabIndex = 0;
            this.btnLucas.Text = "Lucas Beirigo";
            this.btnLucas.UseVisualStyleBackColor = true;
            this.btnLucas.Click += new System.EventHandler(this.BtnLucas_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(124, 86);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnRichard
            // 
            this.btnRichard.Location = new System.Drawing.Point(177, 42);
            this.btnRichard.Margin = new System.Windows.Forms.Padding(4);
            this.btnRichard.Name = "btnRichard";
            this.btnRichard.Size = new System.Drawing.Size(160, 28);
            this.btnRichard.TabIndex = 2;
            this.btnRichard.Text = "Richard Carlos";
            this.btnRichard.UseVisualStyleBackColor = true;
            this.btnRichard.Click += new System.EventHandler(this.BtnRichard_Click);
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Location = new System.Drawing.Point(104, 9);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(144, 17);
            this.lblEscolha.TabIndex = 3;
            this.lblEscolha.Text = "Escolha o Contratado";
            // 
            // frmSelectProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 127);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.btnRichard);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLucas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSelectProvider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contrato em Branco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLucas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRichard;
        private System.Windows.Forms.Label lblEscolha;
    }
}