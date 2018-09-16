namespace UIWindows
{
    partial class frmDeliveryFollowing
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
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.radData = new System.Windows.Forms.RadioButton();
            this.radCPF_CNPJ = new System.Windows.Forms.RadioButton();
            this.radNome = new System.Windows.Forms.RadioButton();
            this.lblTipo = new System.Windows.Forms.Label();
            this.grpEntregas = new System.Windows.Forms.GroupBox();
            this.grdEntregas = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAbrirAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.inoxErpDBDataSet3ServiceOrdersApprovedGidView = new UIWindows.InoxErpDBDataSet3ServiceOrdersApprovedGidView();
            this.inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbdeliveryopenedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_delivery_openedTableAdapter = new UIWindows.InoxErpDBDataSet3ServiceOrdersApprovedGidViewTableAdapters.tb_delivery_openedTableAdapter();
            this.dtFinalPrevisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sObservationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPesquisa.SuspendLayout();
            this.grpEntregas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEntregas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inoxErpDBDataSet3ServiceOrdersApprovedGidView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdeliveryopenedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.btnPesquisar);
            this.grpPesquisa.Controls.Add(this.txtPesquisa);
            this.grpPesquisa.Controls.Add(this.radData);
            this.grpPesquisa.Controls.Add(this.radCPF_CNPJ);
            this.grpPesquisa.Controls.Add(this.radNome);
            this.grpPesquisa.Controls.Add(this.lblTipo);
            this.grpPesquisa.Location = new System.Drawing.Point(12, 12);
            this.grpPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPesquisa.Size = new System.Drawing.Size(776, 74);
            this.grpPesquisa.TabIndex = 6;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisa";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(684, 23);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(85, 30);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(347, 27);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(331, 23);
            this.txtPesquisa.TabIndex = 4;
            // 
            // radData
            // 
            this.radData.AutoSize = true;
            this.radData.Location = new System.Drawing.Point(281, 28);
            this.radData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radData.Name = "radData";
            this.radData.Size = new System.Drawing.Size(56, 21);
            this.radData.TabIndex = 3;
            this.radData.TabStop = true;
            this.radData.Text = "Data";
            this.radData.UseVisualStyleBackColor = true;
            // 
            // radCPF_CNPJ
            // 
            this.radCPF_CNPJ.AutoSize = true;
            this.radCPF_CNPJ.Location = new System.Drawing.Point(145, 28);
            this.radCPF_CNPJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radCPF_CNPJ.Name = "radCPF_CNPJ";
            this.radCPF_CNPJ.Size = new System.Drawing.Size(91, 21);
            this.radCPF_CNPJ.TabIndex = 2;
            this.radCPF_CNPJ.TabStop = true;
            this.radCPF_CNPJ.Text = "CPF/CNPJ";
            this.radCPF_CNPJ.UseVisualStyleBackColor = true;
            // 
            // radNome
            // 
            this.radNome.AutoSize = true;
            this.radNome.Location = new System.Drawing.Point(52, 28);
            this.radNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNome.Name = "radNome";
            this.radNome.Size = new System.Drawing.Size(63, 21);
            this.radNome.TabIndex = 1;
            this.radNome.TabStop = true;
            this.radNome.Text = "Nome";
            this.radNome.UseVisualStyleBackColor = true;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(5, 30);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 17);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // grpEntregas
            // 
            this.grpEntregas.Controls.Add(this.grdEntregas);
            this.grpEntregas.Location = new System.Drawing.Point(12, 92);
            this.grpEntregas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEntregas.Name = "grpEntregas";
            this.grpEntregas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEntregas.Size = new System.Drawing.Size(1202, 290);
            this.grpEntregas.TabIndex = 7;
            this.grpEntregas.TabStop = false;
            this.grpEntregas.Text = "Entregas";
            // 
            // grdEntregas
            // 
            this.grdEntregas.AllowUserToAddRows = false;
            this.grdEntregas.AllowUserToDeleteRows = false;
            this.grdEntregas.AutoGenerateColumns = false;
            this.grdEntregas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEntregas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtFinalPrevisionDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.sAdressDataGridViewTextBoxColumn,
            this.sTelephoneDataGridViewTextBoxColumn,
            this.sObservationDataGridViewTextBoxColumn,
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn,
            this.sIDDataGridViewTextBoxColumn,
            this.iCodDataGridViewTextBoxColumn});
            this.grdEntregas.DataSource = this.tbdeliveryopenedBindingSource;
            this.grdEntregas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEntregas.Location = new System.Drawing.Point(3, 18);
            this.grdEntregas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdEntregas.Name = "grdEntregas";
            this.grdEntregas.ReadOnly = true;
            this.grdEntregas.RowTemplate.Height = 24;
            this.grdEntregas.Size = new System.Drawing.Size(1196, 270);
            this.grdEntregas.TabIndex = 0;
            this.grdEntregas.Click += new System.EventHandler(this.grdEntregas_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(658, 399);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(120, 30);
            this.btnFinalizar.TabIndex = 11;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnAbrirAlterar
            // 
            this.btnAbrirAlterar.Location = new System.Drawing.Point(23, 399);
            this.btnAbrirAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbrirAlterar.Name = "btnAbrirAlterar";
            this.btnAbrirAlterar.Size = new System.Drawing.Size(120, 30);
            this.btnAbrirAlterar.TabIndex = 12;
            this.btnAbrirAlterar.Text = "Abrir / Alterar";
            this.btnAbrirAlterar.UseVisualStyleBackColor = true;
            this.btnAbrirAlterar.Click += new System.EventHandler(this.btnAbrirAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(337, 399);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(120, 30);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // inoxErpDBDataSet3ServiceOrdersApprovedGidView
            // 
            this.inoxErpDBDataSet3ServiceOrdersApprovedGidView.DataSetName = "InoxErpDBDataSet3ServiceOrdersApprovedGidView";
            this.inoxErpDBDataSet3ServiceOrdersApprovedGidView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource
            // 
            this.inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource.DataSource = this.inoxErpDBDataSet3ServiceOrdersApprovedGidView;
            this.inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource.Position = 0;
            // 
            // tbdeliveryopenedBindingSource
            // 
            this.tbdeliveryopenedBindingSource.DataMember = "tb_delivery_opened";
            this.tbdeliveryopenedBindingSource.DataSource = this.inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource;
            // 
            // tb_delivery_openedTableAdapter
            // 
            this.tb_delivery_openedTableAdapter.ClearBeforeFill = true;
            // 
            // dtFinalPrevisionDataGridViewTextBoxColumn
            // 
            this.dtFinalPrevisionDataGridViewTextBoxColumn.DataPropertyName = "dtFinalPrevision";
            this.dtFinalPrevisionDataGridViewTextBoxColumn.FillWeight = 180F;
            this.dtFinalPrevisionDataGridViewTextBoxColumn.HeaderText = "Previsão Entrega";
            this.dtFinalPrevisionDataGridViewTextBoxColumn.Name = "dtFinalPrevisionDataGridViewTextBoxColumn";
            this.dtFinalPrevisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sNameDataGridViewTextBoxColumn
            // 
            this.sNameDataGridViewTextBoxColumn.DataPropertyName = "sName";
            this.sNameDataGridViewTextBoxColumn.FillWeight = 300F;
            this.sNameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.sNameDataGridViewTextBoxColumn.Name = "sNameDataGridViewTextBoxColumn";
            this.sNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sAdressDataGridViewTextBoxColumn
            // 
            this.sAdressDataGridViewTextBoxColumn.DataPropertyName = "sAdress";
            this.sAdressDataGridViewTextBoxColumn.FillWeight = 360F;
            this.sAdressDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.sAdressDataGridViewTextBoxColumn.Name = "sAdressDataGridViewTextBoxColumn";
            this.sAdressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTelephoneDataGridViewTextBoxColumn
            // 
            this.sTelephoneDataGridViewTextBoxColumn.DataPropertyName = "sTelephone";
            this.sTelephoneDataGridViewTextBoxColumn.FillWeight = 180F;
            this.sTelephoneDataGridViewTextBoxColumn.HeaderText = "Contato";
            this.sTelephoneDataGridViewTextBoxColumn.Name = "sTelephoneDataGridViewTextBoxColumn";
            this.sTelephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sObservationDataGridViewTextBoxColumn
            // 
            this.sObservationDataGridViewTextBoxColumn.DataPropertyName = "sObservation";
            this.sObservationDataGridViewTextBoxColumn.FillWeight = 360F;
            this.sObservationDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.sObservationDataGridViewTextBoxColumn.Name = "sObservationDataGridViewTextBoxColumn";
            this.sObservationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtDateServiceOrderApprovedDataGridViewTextBoxColumn
            // 
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.DataPropertyName = "dtDateServiceOrderApproved";
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.FillWeight = 180F;
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.HeaderText = "Aprovação OS";
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.Name = "dtDateServiceOrderApprovedDataGridViewTextBoxColumn";
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "sID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "sID";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            this.sIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // iCodDataGridViewTextBoxColumn
            // 
            this.iCodDataGridViewTextBoxColumn.DataPropertyName = "iCod";
            this.iCodDataGridViewTextBoxColumn.HeaderText = "iCod";
            this.iCodDataGridViewTextBoxColumn.Name = "iCodDataGridViewTextBoxColumn";
            this.iCodDataGridViewTextBoxColumn.ReadOnly = true;
            this.iCodDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmDeliveryFollowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAbrirAlterar);
            this.Controls.Add(this.grpPesquisa);
            this.Controls.Add(this.grpEntregas);
            this.Controls.Add(this.btnFinalizar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDeliveryFollowing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entregas em Andamento";
            this.Load += new System.EventHandler(this.frmDeliveryFollowing_Load);
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.grpEntregas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEntregas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inoxErpDBDataSet3ServiceOrdersApprovedGidView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdeliveryopenedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton radData;
        private System.Windows.Forms.RadioButton radCPF_CNPJ;
        private System.Windows.Forms.RadioButton radNome;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox grpEntregas;
        private System.Windows.Forms.DataGridView grdEntregas;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnAbrirAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private InoxErpDBDataSet3ServiceOrdersApprovedGidView inoxErpDBDataSet3ServiceOrdersApprovedGidView;
        private System.Windows.Forms.BindingSource inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource;
        private System.Windows.Forms.BindingSource tbdeliveryopenedBindingSource;
        private InoxErpDBDataSet3ServiceOrdersApprovedGidViewTableAdapters.tb_delivery_openedTableAdapter tb_delivery_openedTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtFinalPrevisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sObservationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateServiceOrderApprovedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCodDataGridViewTextBoxColumn;
    }
}