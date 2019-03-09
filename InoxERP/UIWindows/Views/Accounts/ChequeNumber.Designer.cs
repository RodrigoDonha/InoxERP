namespace UIWindows.Views.Accounts
{
    partial class frmChequeNumber
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
            this.lblRefParcela = new System.Windows.Forms.Label();
            this.lblParcela = new System.Windows.Forms.Label();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.txtC3 = new System.Windows.Forms.TextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRefParcela
            // 
            this.lblRefParcela.AutoSize = true;
            this.lblRefParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefParcela.Location = new System.Drawing.Point(13, 9);
            this.lblRefParcela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefParcela.Name = "lblRefParcela";
            this.lblRefParcela.Size = new System.Drawing.Size(459, 20);
            this.lblRefParcela.TabIndex = 0;
            this.lblRefParcela.Text = "Informe o Número CMC7 do Cheque para a Parcela de Número ";
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcela.Location = new System.Drawing.Point(487, 9);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(18, 20);
            this.lblParcela.TabIndex = 1;
            this.lblParcela.Text = "0";
            // 
            // txtC1
            // 
            this.txtC1.Location = new System.Drawing.Point(12, 45);
            this.txtC1.MaxLength = 8;
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(160, 23);
            this.txtC1.TabIndex = 2;
            this.txtC1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC1_KeyPress);
            this.txtC1.Leave += new System.EventHandler(this.txtC1_Leave);
            // 
            // txtC2
            // 
            this.txtC2.Location = new System.Drawing.Point(179, 45);
            this.txtC2.MaxLength = 10;
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(160, 23);
            this.txtC2.TabIndex = 3;
            this.txtC2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC2_KeyPress);
            this.txtC2.Leave += new System.EventHandler(this.txtC2_Leave);
            // 
            // txtC3
            // 
            this.txtC3.Location = new System.Drawing.Point(345, 45);
            this.txtC3.MaxLength = 12;
            this.txtC3.Name = "txtC3";
            this.txtC3.Size = new System.Drawing.Size(160, 23);
            this.txtC3.TabIndex = 4;
            this.txtC3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC3_KeyPress);
            this.txtC3.Leave += new System.EventHandler(this.txtC3_Leave);
            // 
            // btnConfirma
            // 
            this.btnConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.Location = new System.Drawing.Point(179, 74);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(160, 30);
            this.btnConfirma.TabIndex = 5;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // frmChequeNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 114);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txtC3);
            this.Controls.Add(this.txtC2);
            this.Controls.Add(this.txtC1);
            this.Controls.Add(this.lblParcela);
            this.Controls.Add(this.lblRefParcela);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmChequeNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numero do Cheque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRefParcela;
        private System.Windows.Forms.Label lblParcela;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.TextBox txtC2;
        private System.Windows.Forms.TextBox txtC3;
        private System.Windows.Forms.Button btnConfirma;
    }
}