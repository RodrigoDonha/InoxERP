namespace UIWindows
{
    partial class ConsultaChequesBaixadosForm
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
            this.grpConsultarValores = new System.Windows.Forms.GroupBox();
            this.grdConsultaPecas = new System.Windows.Forms.DataGridView();
            this.grpConsultarValores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaPecas)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConsultarValores
            // 
            this.grpConsultarValores.Controls.Add(this.grdConsultaPecas);
            this.grpConsultarValores.Location = new System.Drawing.Point(12, 11);
            this.grpConsultarValores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConsultarValores.Name = "grpConsultarValores";
            this.grpConsultarValores.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConsultarValores.Size = new System.Drawing.Size(535, 462);
            this.grpConsultarValores.TabIndex = 2;
            this.grpConsultarValores.TabStop = false;
            this.grpConsultarValores.Text = "Consultar";
            // 
            // grdConsultaPecas
            // 
            this.grdConsultaPecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultaPecas.Location = new System.Drawing.Point(9, 23);
            this.grdConsultaPecas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdConsultaPecas.Name = "grdConsultaPecas";
            this.grdConsultaPecas.RowTemplate.Height = 24;
            this.grdConsultaPecas.Size = new System.Drawing.Size(517, 429);
            this.grdConsultaPecas.TabIndex = 7;
            // 
            // ConsultaChequesBaixadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 484);
            this.Controls.Add(this.grpConsultarValores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConsultaChequesBaixadosForm";
            this.Text = "Consulta de Cheques Baixados";
            this.grpConsultarValores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaPecas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConsultarValores;
        private System.Windows.Forms.DataGridView grdConsultaPecas;
    }
}