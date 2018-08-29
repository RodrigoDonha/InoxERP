namespace UIWindows
{
    partial class frmAccountsSearch
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
            this.tbpRecebidos = new System.Windows.Forms.TabPage();
            this.gpbConsultarRecebidos = new System.Windows.Forms.GroupBox();
            this.dgvRecebidos = new System.Windows.Forms.DataGridView();
            this.tbpPagos = new System.Windows.Forms.TabPage();
            this.gpbConsultaPagos = new System.Windows.Forms.GroupBox();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.tbcConsultaValores = new System.Windows.Forms.TabControl();
            this.btnEstornarPagos = new System.Windows.Forms.Button();
            this.btnEstornarRecebidos = new System.Windows.Forms.Button();
            this.tbpCheques = new System.Windows.Forms.TabPage();
            this.btnEstornarCheque = new System.Windows.Forms.Button();
            this.dgvCheques = new System.Windows.Forms.DataGridView();
            this.gpbCheques = new System.Windows.Forms.GroupBox();
            this.tbpRecebidos.SuspendLayout();
            this.gpbConsultarRecebidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecebidos)).BeginInit();
            this.tbpPagos.SuspendLayout();
            this.gpbConsultaPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.tbcConsultaValores.SuspendLayout();
            this.tbpCheques.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheques)).BeginInit();
            this.gpbCheques.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpRecebidos
            // 
            this.tbpRecebidos.Controls.Add(this.gpbConsultarRecebidos);
            this.tbpRecebidos.Location = new System.Drawing.Point(4, 26);
            this.tbpRecebidos.Name = "tbpRecebidos";
            this.tbpRecebidos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRecebidos.Size = new System.Drawing.Size(545, 436);
            this.tbpRecebidos.TabIndex = 4;
            this.tbpRecebidos.Text = "Recebidos";
            this.tbpRecebidos.UseVisualStyleBackColor = true;
            // 
            // gpbConsultarRecebidos
            // 
            this.gpbConsultarRecebidos.Controls.Add(this.btnEstornarRecebidos);
            this.gpbConsultarRecebidos.Controls.Add(this.dgvRecebidos);
            this.gpbConsultarRecebidos.Location = new System.Drawing.Point(6, 6);
            this.gpbConsultarRecebidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbConsultarRecebidos.Name = "gpbConsultarRecebidos";
            this.gpbConsultarRecebidos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbConsultarRecebidos.Size = new System.Drawing.Size(533, 431);
            this.gpbConsultarRecebidos.TabIndex = 3;
            this.gpbConsultarRecebidos.TabStop = false;
            this.gpbConsultarRecebidos.Text = "Consultar Recebidos";
            // 
            // dgvRecebidos
            // 
            this.dgvRecebidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecebidos.Location = new System.Drawing.Point(9, 29);
            this.dgvRecebidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRecebidos.Name = "dgvRecebidos";
            this.dgvRecebidos.RowTemplate.Height = 24;
            this.dgvRecebidos.Size = new System.Drawing.Size(517, 362);
            this.dgvRecebidos.TabIndex = 8;
            // 
            // tbpPagos
            // 
            this.tbpPagos.Controls.Add(this.gpbConsultaPagos);
            this.tbpPagos.Location = new System.Drawing.Point(4, 26);
            this.tbpPagos.Name = "tbpPagos";
            this.tbpPagos.Size = new System.Drawing.Size(545, 436);
            this.tbpPagos.TabIndex = 2;
            this.tbpPagos.Text = "Pagos";
            this.tbpPagos.UseVisualStyleBackColor = true;
            // 
            // gpbConsultaPagos
            // 
            this.gpbConsultaPagos.Controls.Add(this.btnEstornarPagos);
            this.gpbConsultaPagos.Controls.Add(this.dgvPagos);
            this.gpbConsultaPagos.Location = new System.Drawing.Point(6, 6);
            this.gpbConsultaPagos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbConsultaPagos.Name = "gpbConsultaPagos";
            this.gpbConsultaPagos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbConsultaPagos.Size = new System.Drawing.Size(533, 431);
            this.gpbConsultaPagos.TabIndex = 2;
            this.gpbConsultaPagos.TabStop = false;
            this.gpbConsultaPagos.Text = "Consultar Pagos";
            // 
            // dgvPagos
            // 
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Location = new System.Drawing.Point(9, 29);
            this.dgvPagos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.RowTemplate.Height = 24;
            this.dgvPagos.Size = new System.Drawing.Size(517, 362);
            this.dgvPagos.TabIndex = 8;
            // 
            // tbcConsultaValores
            // 
            this.tbcConsultaValores.Controls.Add(this.tbpPagos);
            this.tbcConsultaValores.Controls.Add(this.tbpRecebidos);
            this.tbcConsultaValores.Controls.Add(this.tbpCheques);
            this.tbcConsultaValores.Location = new System.Drawing.Point(4, 9);
            this.tbcConsultaValores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcConsultaValores.Name = "tbcConsultaValores";
            this.tbcConsultaValores.SelectedIndex = 0;
            this.tbcConsultaValores.Size = new System.Drawing.Size(553, 466);
            this.tbcConsultaValores.TabIndex = 4;
            // 
            // btnEstornarPagos
            // 
            this.btnEstornarPagos.Location = new System.Drawing.Point(206, 396);
            this.btnEstornarPagos.Name = "btnEstornarPagos";
            this.btnEstornarPagos.Size = new System.Drawing.Size(134, 30);
            this.btnEstornarPagos.TabIndex = 9;
            this.btnEstornarPagos.Text = "Estornar Pago";
            this.btnEstornarPagos.UseVisualStyleBackColor = true;
            // 
            // btnEstornarRecebidos
            // 
            this.btnEstornarRecebidos.Location = new System.Drawing.Point(205, 396);
            this.btnEstornarRecebidos.Name = "btnEstornarRecebidos";
            this.btnEstornarRecebidos.Size = new System.Drawing.Size(134, 30);
            this.btnEstornarRecebidos.TabIndex = 10;
            this.btnEstornarRecebidos.Text = "Estornar Recebido";
            this.btnEstornarRecebidos.UseVisualStyleBackColor = true;
            // 
            // tbpCheques
            // 
            this.tbpCheques.Controls.Add(this.gpbCheques);
            this.tbpCheques.Location = new System.Drawing.Point(4, 26);
            this.tbpCheques.Name = "tbpCheques";
            this.tbpCheques.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCheques.Size = new System.Drawing.Size(545, 436);
            this.tbpCheques.TabIndex = 5;
            this.tbpCheques.Text = "Cheques";
            this.tbpCheques.UseVisualStyleBackColor = true;
            // 
            // btnEstornarCheque
            // 
            this.btnEstornarCheque.Location = new System.Drawing.Point(205, 397);
            this.btnEstornarCheque.Name = "btnEstornarCheque";
            this.btnEstornarCheque.Size = new System.Drawing.Size(134, 30);
            this.btnEstornarCheque.TabIndex = 10;
            this.btnEstornarCheque.Text = "Estornar Cheque";
            this.btnEstornarCheque.UseVisualStyleBackColor = true;
            // 
            // dgvCheques
            // 
            this.dgvCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheques.Location = new System.Drawing.Point(9, 30);
            this.dgvCheques.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCheques.Name = "dgvCheques";
            this.dgvCheques.RowTemplate.Height = 24;
            this.dgvCheques.Size = new System.Drawing.Size(517, 362);
            this.dgvCheques.TabIndex = 8;
            // 
            // gpbCheques
            // 
            this.gpbCheques.Controls.Add(this.btnEstornarCheque);
            this.gpbCheques.Controls.Add(this.dgvCheques);
            this.gpbCheques.Location = new System.Drawing.Point(6, 5);
            this.gpbCheques.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbCheques.Name = "gpbCheques";
            this.gpbCheques.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbCheques.Size = new System.Drawing.Size(533, 431);
            this.gpbCheques.TabIndex = 4;
            this.gpbCheques.TabStop = false;
            this.gpbCheques.Text = "Consultar Cheques";
            // 
            // frmAccountsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 484);
            this.Controls.Add(this.tbcConsultaValores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAccountsSearch";
            this.Text = "Consultar Contas";
            this.tbpRecebidos.ResumeLayout(false);
            this.gpbConsultarRecebidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecebidos)).EndInit();
            this.tbpPagos.ResumeLayout(false);
            this.gpbConsultaPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.tbcConsultaValores.ResumeLayout(false);
            this.tbpCheques.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheques)).EndInit();
            this.gpbCheques.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpRecebidos;
        private System.Windows.Forms.GroupBox gpbConsultarRecebidos;
        private System.Windows.Forms.Button btnEstornarRecebidos;
        private System.Windows.Forms.DataGridView dgvRecebidos;
        private System.Windows.Forms.TabPage tbpPagos;
        private System.Windows.Forms.GroupBox gpbConsultaPagos;
        private System.Windows.Forms.Button btnEstornarPagos;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.TabControl tbcConsultaValores;
        private System.Windows.Forms.TabPage tbpCheques;
        private System.Windows.Forms.GroupBox gpbCheques;
        private System.Windows.Forms.Button btnEstornarCheque;
        private System.Windows.Forms.DataGridView dgvCheques;
    }
}