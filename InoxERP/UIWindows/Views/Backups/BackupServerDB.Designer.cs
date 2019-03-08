namespace UIWindows.Views
{
    partial class frmBackupServerDB
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackupServerDB));
            this.gpbBackup = new System.Windows.Forms.GroupBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblLocal = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.prbCopiando = new System.Windows.Forms.ProgressBar();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.picBackup = new System.Windows.Forms.PictureBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.ttBackup = new System.Windows.Forms.ToolTip(this.components);
            this.fbdSearch = new System.Windows.Forms.FolderBrowserDialog();
            this.gpbBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackup)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbBackup
            // 
            this.gpbBackup.Controls.Add(this.lblProgress);
            this.gpbBackup.Controls.Add(this.btnSearch);
            this.gpbBackup.Controls.Add(this.lblLocal);
            this.gpbBackup.Controls.Add(this.txtDestino);
            this.gpbBackup.Controls.Add(this.prbCopiando);
            this.gpbBackup.Controls.Add(this.txtBanco);
            this.gpbBackup.Controls.Add(this.txtServidor);
            this.gpbBackup.Controls.Add(this.picBackup);
            this.gpbBackup.Controls.Add(this.lblBanco);
            this.gpbBackup.Controls.Add(this.lblServidor);
            this.gpbBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBackup.Location = new System.Drawing.Point(19, 18);
            this.gpbBackup.Margin = new System.Windows.Forms.Padding(7);
            this.gpbBackup.Name = "gpbBackup";
            this.gpbBackup.Padding = new System.Windows.Forms.Padding(7);
            this.gpbBackup.Size = new System.Drawing.Size(463, 432);
            this.gpbBackup.TabIndex = 2;
            this.gpbBackup.TabStop = false;
            this.gpbBackup.Text = "Backup";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(204, 176);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(7);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(73, 17);
            this.lblProgress.TabIndex = 23;
            this.lblProgress.Text = "Progresso";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::UIWindows.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(401, 119);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 42);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(209, 98);
            this.lblLocal.Margin = new System.Windows.Forms.Padding(7);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(56, 17);
            this.lblLocal.TabIndex = 21;
            this.lblLocal.Text = "Destino";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(15, 129);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(7);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(376, 23);
            this.txtDestino.TabIndex = 20;
            this.txtDestino.Text = "C:\\Users\\LUCK Aço Inox\\OneDrive";
            this.txtDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prbCopiando
            // 
            this.prbCopiando.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.prbCopiando.Location = new System.Drawing.Point(15, 205);
            this.prbCopiando.Margin = new System.Windows.Forms.Padding(7);
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
            // picBackup
            // 
            this.picBackup.BackColor = System.Drawing.Color.White;
            this.picBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBackup.Image = ((System.Drawing.Image)(resources.GetObject("picBackup.Image")));
            this.picBackup.Location = new System.Drawing.Point(14, 281);
            this.picBackup.Margin = new System.Windows.Forms.Padding(7);
            this.picBackup.Name = "picBackup";
            this.picBackup.Size = new System.Drawing.Size(435, 137);
            this.picBackup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBackup.TabIndex = 8;
            this.picBackup.TabStop = false;
            this.ttBackup.SetToolTip(this.picBackup, "Realizar Backup");
            this.picBackup.Click += new System.EventHandler(this.picBackup_Click);
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(312, 26);
            this.lblBanco.Margin = new System.Windows.Forms.Padding(7);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(69, 17);
            this.lblBanco.TabIndex = 4;
            this.lblBanco.Text = "Database";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(72, 26);
            this.lblServidor.Margin = new System.Windows.Forms.Padding(7);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(61, 17);
            this.lblServidor.TabIndex = 1;
            this.lblServidor.Text = "Servidor";
            // 
            // ttBackup
            // 
            this.ttBackup.IsBalloon = true;
            this.ttBackup.ShowAlways = true;
            this.ttBackup.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttBackup.ToolTipTitle = "Backup";
            // 
            // frmBackupServerDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 469);
            this.Controls.Add(this.gpbBackup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBackupServerDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup do Servidor";
            this.gpbBackup.ResumeLayout(false);
            this.gpbBackup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbBackup;
        private System.Windows.Forms.PictureBox picBackup;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.ProgressBar prbCopiando;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.ToolTip ttBackup;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FolderBrowserDialog fbdSearch;
        private System.Windows.Forms.Label lblProgress;
    }
}