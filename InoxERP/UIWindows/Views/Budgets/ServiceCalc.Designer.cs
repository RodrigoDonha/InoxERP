namespace UIWindows.Views.Budgets
{
    partial class frmServiceCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiceCalc));
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblPecas = new System.Windows.Forms.Label();
            this.txtPorcentagem = new System.Windows.Forms.TextBox();
            this.lblValordosProdutos = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblMaoDeObra = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(142, 148);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 28);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblPecas
            // 
            this.lblPecas.AutoSize = true;
            this.lblPecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPecas.Location = new System.Drawing.Point(16, 15);
            this.lblPecas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPecas.Name = "lblPecas";
            this.lblPecas.Size = new System.Drawing.Size(51, 17);
            this.lblPecas.TabIndex = 1;
            this.lblPecas.Text = "Peças:";
            // 
            // txtPorcentagem
            // 
            this.txtPorcentagem.Location = new System.Drawing.Point(233, 51);
            this.txtPorcentagem.Margin = new System.Windows.Forms.Padding(4);
            this.txtPorcentagem.MaxLength = 18;
            this.txtPorcentagem.Name = "txtPorcentagem";
            this.txtPorcentagem.Size = new System.Drawing.Size(121, 23);
            this.txtPorcentagem.TabIndex = 1;
            this.txtPorcentagem.TextChanged += new System.EventHandler(this.txtPorcent_TextChanged);
            this.txtPorcentagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validationEntriesNumerics);
            // 
            // lblValordosProdutos
            // 
            this.lblValordosProdutos.AutoSize = true;
            this.lblValordosProdutos.Location = new System.Drawing.Point(39, 59);
            this.lblValordosProdutos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValordosProdutos.Name = "lblValordosProdutos";
            this.lblValordosProdutos.Size = new System.Drawing.Size(16, 17);
            this.lblValordosProdutos.TabIndex = 3;
            this.lblValordosProdutos.Text = "0";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(139, 15);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 17);
            this.lblX.TabIndex = 4;
            this.lblX.Text = "x";
            // 
            // lblMaoDeObra
            // 
            this.lblMaoDeObra.AutoSize = true;
            this.lblMaoDeObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaoDeObra.Location = new System.Drawing.Point(229, 15);
            this.lblMaoDeObra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaoDeObra.Name = "lblMaoDeObra";
            this.lblMaoDeObra.Size = new System.Drawing.Size(127, 17);
            this.lblMaoDeObra.TabIndex = 5;
            this.lblMaoDeObra.Text = "% da Mão de Obra";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(101, 103);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(233, 100);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.MaxLength = 18;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 23);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validationEntriesNumerics);
            // 
            // frmServiceCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 189);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMaoDeObra);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblValordosProdutos);
            this.Controls.Add(this.txtPorcentagem);
            this.Controls.Add(this.lblPecas);
            this.Controls.Add(this.btnConfirmar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmServiceCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Mão de Obra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblPecas;
        private System.Windows.Forms.TextBox txtPorcentagem;
        private System.Windows.Forms.Label lblValordosProdutos;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblMaoDeObra;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}