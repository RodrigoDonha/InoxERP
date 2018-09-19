namespace UIWindows.Views.Backups
{
    partial class frmAdminChose
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
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestauracao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(14, 29);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(5);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(124, 35);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestauracao
            // 
            this.btnRestauracao.Location = new System.Drawing.Point(183, 29);
            this.btnRestauracao.Margin = new System.Windows.Forms.Padding(5);
            this.btnRestauracao.Name = "btnRestauracao";
            this.btnRestauracao.Size = new System.Drawing.Size(124, 35);
            this.btnRestauracao.TabIndex = 1;
            this.btnRestauracao.Text = "Restauração";
            this.btnRestauracao.UseVisualStyleBackColor = true;
            this.btnRestauracao.Click += new System.EventHandler(this.btnRestauracao_Click);
            // 
            // frmAdminChose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 93);
            this.Controls.Add(this.btnRestauracao);
            this.Controls.Add(this.btnBackup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAdminChose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolha";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestauracao;
    }
}