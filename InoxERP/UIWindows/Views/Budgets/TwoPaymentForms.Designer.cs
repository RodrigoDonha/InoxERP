namespace UIWindows
{
    partial class frmTwoPaymentForms
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
            this.grpDinheiro = new System.Windows.Forms.GroupBox();
            this.grpServicos = new System.Windows.Forms.GroupBox();
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.txtValorCheque = new System.Windows.Forms.TextBox();
            this.lblCheque = new System.Windows.Forms.Label();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.nudParcelaCheque = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.grpDinheiro.SuspendLayout();
            this.grpServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelaCheque)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDinheiro
            // 
            this.grpDinheiro.Controls.Add(this.txtDinheiro);
            this.grpDinheiro.Controls.Add(this.lblDinheiro);
            this.grpDinheiro.Location = new System.Drawing.Point(12, 12);
            this.grpDinheiro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDinheiro.Name = "grpDinheiro";
            this.grpDinheiro.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDinheiro.Size = new System.Drawing.Size(275, 78);
            this.grpDinheiro.TabIndex = 0;
            this.grpDinheiro.TabStop = false;
            this.grpDinheiro.Text = "Dinheiro";
            // 
            // grpServicos
            // 
            this.grpServicos.Controls.Add(this.nudParcelaCheque);
            this.grpServicos.Controls.Add(this.lblParcelas);
            this.grpServicos.Controls.Add(this.txtValorCheque);
            this.grpServicos.Controls.Add(this.lblCheque);
            this.grpServicos.Location = new System.Drawing.Point(12, 91);
            this.grpServicos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpServicos.Name = "grpServicos";
            this.grpServicos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpServicos.Size = new System.Drawing.Size(275, 100);
            this.grpServicos.TabIndex = 1;
            this.grpServicos.TabStop = false;
            this.grpServicos.Text = "Cheque";
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.Location = new System.Drawing.Point(6, 36);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(69, 17);
            this.lblDinheiro.TabIndex = 0;
            this.lblDinheiro.Text = "Dinheiro: ";
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Location = new System.Drawing.Point(110, 33);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(100, 23);
            this.txtDinheiro.TabIndex = 1;
            // 
            // txtValorCheque
            // 
            this.txtValorCheque.Location = new System.Drawing.Point(110, 31);
            this.txtValorCheque.Name = "txtValorCheque";
            this.txtValorCheque.Size = new System.Drawing.Size(100, 23);
            this.txtValorCheque.TabIndex = 3;
            // 
            // lblCheque
            // 
            this.lblCheque.AutoSize = true;
            this.lblCheque.Location = new System.Drawing.Point(6, 34);
            this.lblCheque.Name = "lblCheque";
            this.lblCheque.Size = new System.Drawing.Size(65, 17);
            this.lblCheque.TabIndex = 2;
            this.lblCheque.Text = "Cheque: ";
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Location = new System.Drawing.Point(6, 65);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(71, 17);
            this.lblParcelas.TabIndex = 4;
            this.lblParcelas.Text = "Parcelas: ";
            // 
            // nudParcelaCheque
            // 
            this.nudParcelaCheque.Location = new System.Drawing.Point(110, 63);
            this.nudParcelaCheque.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudParcelaCheque.Name = "nudParcelaCheque";
            this.nudParcelaCheque.Size = new System.Drawing.Size(100, 23);
            this.nudParcelaCheque.TabIndex = 5;
            this.nudParcelaCheque.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(59, 206);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(119, 206);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(16, 17);
            this.lblValorTotal.TabIndex = 6;
            this.lblValorTotal.Text = "0";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(122, 240);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 27);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // frmTwoPaymentForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 279);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.grpServicos);
            this.Controls.Add(this.grpDinheiro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTwoPaymentForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valores para Pagamento";
            this.grpDinheiro.ResumeLayout(false);
            this.grpDinheiro.PerformLayout();
            this.grpServicos.ResumeLayout(false);
            this.grpServicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelaCheque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDinheiro;
        private System.Windows.Forms.GroupBox grpServicos;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.NumericUpDown nudParcelaCheque;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.TextBox txtValorCheque;
        private System.Windows.Forms.Label lblCheque;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnConfirmar;
    }
}