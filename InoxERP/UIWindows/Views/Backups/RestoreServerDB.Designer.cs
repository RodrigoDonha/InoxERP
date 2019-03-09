namespace UIWindows
{
    partial class frmRestoreServerDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestoreServerDB));
            this.gpbRestore = new System.Windows.Forms.GroupBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.prbCopiando = new System.Windows.Forms.ProgressBar();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.picRestore = new System.Windows.Forms.PictureBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.gpbRestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestore)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbRestore
            // 
            this.gpbRestore.Controls.Add(this.lblLocal);
            this.gpbRestore.Controls.Add(this.txtOrigem);
            this.gpbRestore.Controls.Add(this.prbCopiando);
            this.gpbRestore.Controls.Add(this.txtBanco);
            this.gpbRestore.Controls.Add(this.txtServidor);
            this.gpbRestore.Controls.Add(this.picRestore);
            this.gpbRestore.Controls.Add(this.lblBanco);
            this.gpbRestore.Controls.Add(this.lblServidor);
            this.gpbRestore.Location = new System.Drawing.Point(19, 18);
            this.gpbRestore.Margin = new System.Windows.Forms.Padding(7);
            this.gpbRestore.Name = "gpbRestore";
            this.gpbRestore.Padding = new System.Windows.Forms.Padding(7);
            this.gpbRestore.Size = new System.Drawing.Size(463, 432);
            this.gpbRestore.TabIndex = 3;
            this.gpbRestore.TabStop = false;
            this.gpbRestore.Text = "Restaurar";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(209, 96);
            this.lblLocal.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(54, 17);
            this.lblLocal.TabIndex = 21;
            this.lblLocal.Text = "Origem";
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(15, 129);
            this.txtOrigem.Margin = new System.Windows.Forms.Padding(7);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(434, 23);
            this.txtOrigem.TabIndex = 20;
            this.txtOrigem.Text = "C:\\Users\\Lucas\\OneDrive\\Backup\\";
            this.txtOrigem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prbCopiando
            // 
            this.prbCopiando.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.prbCopiando.Location = new System.Drawing.Point(15, 196);
            this.prbCopiando.Margin = new System.Windows.Forms.Padding(5);
            this.prbCopiando.Name = "prbCopiando";
            this.prbCopiando.Size = new System.Drawing.Size(434, 34);
            this.prbCopiando.TabIndex = 19;
            // 
            // txtBanco
            // 
            this.txtBanco.Enabled = false;
            this.txtBanco.Location = new System.Drawing.Point(250, 54);
            this.txtBanco.Margin = new System.Windows.Forms.Padding(7);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(199, 23);
            this.txtBanco.TabIndex = 18;
            this.txtBanco.Text = "InoxErpDB";
            this.txtBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtServidor
            // 
            this.txtServidor.Enabled = false;
            this.txtServidor.Location = new System.Drawing.Point(15, 54);
            this.txtServidor.Margin = new System.Windows.Forms.Padding(7);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(199, 23);
            this.txtServidor.TabIndex = 17;
            this.txtServidor.Text = "(localdb)\\MSSQLLocalDB";
            this.txtServidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picRestore
            // 
            this.picRestore.BackColor = System.Drawing.Color.White;
            this.picRestore.Image = ((System.Drawing.Image)(resources.GetObject("picRestore.Image")));
            this.picRestore.Location = new System.Drawing.Point(15, 281);
            this.picRestore.Margin = new System.Windows.Forms.Padding(7);
            this.picRestore.Name = "picRestore";
            this.picRestore.Size = new System.Drawing.Size(434, 137);
            this.picRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRestore.TabIndex = 8;
            this.picRestore.TabStop = false;
            this.picRestore.Click += new System.EventHandler(this.picRestore_Click);
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(312, 26);
            this.lblBanco.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(69, 17);
            this.lblBanco.TabIndex = 4;
            this.lblBanco.Text = "Database";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(72, 26);
            this.lblServidor.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(61, 17);
            this.lblServidor.TabIndex = 1;
            this.lblServidor.Text = "Servidor";
            // 
            // frmRestoreServerDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 469);
            this.Controls.Add(this.gpbRestore);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmRestoreServerDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurar Servidor";
            this.gpbRestore.ResumeLayout(false);
            this.gpbRestore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbRestore;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.ProgressBar prbCopiando;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.PictureBox picRestore;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.Label lblServidor;
    }
}