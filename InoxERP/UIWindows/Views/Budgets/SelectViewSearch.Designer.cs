namespace UIWindows
{
    partial class frmSelectViewSearch
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
            this.grpProdutos = new System.Windows.Forms.GroupBox();
            this.btnConsultarProdutos = new System.Windows.Forms.Button();
            this.grpServicos = new System.Windows.Forms.GroupBox();
            this.btnConsultarServico = new System.Windows.Forms.Button();
            this.grpProdutos.SuspendLayout();
            this.grpServicos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProdutos
            // 
            this.grpProdutos.Controls.Add(this.btnConsultarProdutos);
            this.grpProdutos.Location = new System.Drawing.Point(12, 12);
            this.grpProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProdutos.Name = "grpProdutos";
            this.grpProdutos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProdutos.Size = new System.Drawing.Size(313, 100);
            this.grpProdutos.TabIndex = 0;
            this.grpProdutos.TabStop = false;
            this.grpProdutos.Text = "Produtos";
            // 
            // btnConsultarProdutos
            // 
            this.btnConsultarProdutos.Location = new System.Drawing.Point(67, 41);
            this.btnConsultarProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarProdutos.Name = "btnConsultarProdutos";
            this.btnConsultarProdutos.Size = new System.Drawing.Size(180, 30);
            this.btnConsultarProdutos.TabIndex = 0;
            this.btnConsultarProdutos.Text = "Consultar Produto";
            this.btnConsultarProdutos.UseVisualStyleBackColor = true;
            this.btnConsultarProdutos.Click += new System.EventHandler(this.btnConsultarProdutos_Click);
            // 
            // grpServicos
            // 
            this.grpServicos.Controls.Add(this.btnConsultarServico);
            this.grpServicos.Location = new System.Drawing.Point(12, 118);
            this.grpServicos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpServicos.Name = "grpServicos";
            this.grpServicos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpServicos.Size = new System.Drawing.Size(313, 100);
            this.grpServicos.TabIndex = 1;
            this.grpServicos.TabStop = false;
            this.grpServicos.Text = "Serviços";
            // 
            // btnConsultarServico
            // 
            this.btnConsultarServico.Location = new System.Drawing.Point(67, 41);
            this.btnConsultarServico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarServico.Name = "btnConsultarServico";
            this.btnConsultarServico.Size = new System.Drawing.Size(180, 30);
            this.btnConsultarServico.TabIndex = 0;
            this.btnConsultarServico.Text = "Consultar Serviço";
            this.btnConsultarServico.UseVisualStyleBackColor = true;
            this.btnConsultarServico.Click += new System.EventHandler(this.btnConsultarServico_Click);
            // 
            // frmSelectViewSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 233);
            this.Controls.Add(this.grpServicos);
            this.Controls.Add(this.grpProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSelectViewSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção de Consulta";
            this.grpProdutos.ResumeLayout(false);
            this.grpServicos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProdutos;
        private System.Windows.Forms.Button btnConsultarProdutos;
        private System.Windows.Forms.GroupBox grpServicos;
        private System.Windows.Forms.Button btnConsultarServico;
    }
}