namespace UIWindows
{
    partial class frmDeliveryFinished
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.radData = new System.Windows.Forms.RadioButton();
            this.radCPF_CNPJ = new System.Windows.Forms.RadioButton();
            this.radNome = new System.Windows.Forms.RadioButton();
            this.lblTipo = new System.Windows.Forms.Label();
            this.grpEntregas = new System.Windows.Forms.GroupBox();
            this.grdEntregas = new System.Windows.Forms.DataGridView();
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sObservationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbdeliveryfinishedBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inoxErpDBDataSet3ServiceOrdersApprovedGidView = new UIWindows.InoxErpDBDataSet3ServiceOrdersApprovedGidView();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnReabrirEntrega = new System.Windows.Forms.Button();
            this.tb_delivery_finishedTableAdapter = new UIWindows.InoxErpDBDataSet3ServiceOrdersApprovedGidViewTableAdapters.tb_delivery_finishedTableAdapter();
            this.tbdeliveryfinishedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_budgets_osTableAdapter = new UIWindows.GeneralDataSetTableAdapters.tb_budgets_osTableAdapter();
            this.tbbudgetsosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generalDataSet = new UIWindows.GeneralDataSet();
            this.grpPesquisa.SuspendLayout();
            this.grpEntregas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEntregas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdeliveryfinishedBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inoxErpDBDataSet3ServiceOrdersApprovedGidView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdeliveryfinishedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbudgetsosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalDataSet)).BeginInit();
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
            this.grpPesquisa.Size = new System.Drawing.Size(1202, 74);
            this.grpPesquisa.TabIndex = 12;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisa";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(890, 23);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(85, 30);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(553, 27);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(331, 23);
            this.txtPesquisa.TabIndex = 4;
            // 
            // radData
            // 
            this.radData.AutoSize = true;
            this.radData.Location = new System.Drawing.Point(487, 28);
            this.radData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radData.Name = "radData";
            this.radData.Size = new System.Drawing.Size(56, 21);
            this.radData.TabIndex = 3;
            this.radData.TabStop = true;
            this.radData.Text = "Data";
            this.radData.UseVisualStyleBackColor = true;
            this.radData.CheckedChanged += new System.EventHandler(this.radData_CheckedChanged);
            // 
            // radCPF_CNPJ
            // 
            this.radCPF_CNPJ.AutoSize = true;
            this.radCPF_CNPJ.Location = new System.Drawing.Point(354, 28);
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
            this.radNome.Location = new System.Drawing.Point(261, 28);
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
            this.lblTipo.Location = new System.Drawing.Point(214, 30);
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
            this.grpEntregas.TabIndex = 13;
            this.grpEntregas.TabStop = false;
            this.grpEntregas.Text = "Entregas";
            // 
            // grdEntregas
            // 
            this.grdEntregas.AllowUserToAddRows = false;
            this.grdEntregas.AllowUserToDeleteRows = false;
            this.grdEntregas.AutoGenerateColumns = false;
            this.grdEntregas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEntregas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEntregas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.sAdressDataGridViewTextBoxColumn,
            this.sTelephoneDataGridViewTextBoxColumn,
            this.sObservationDataGridViewTextBoxColumn,
            this.dTotalDataGridViewTextBoxColumn,
            this.sID});
            this.grdEntregas.DataSource = this.tbdeliveryfinishedBindingSource;
            this.grdEntregas.Location = new System.Drawing.Point(11, 21);
            this.grdEntregas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdEntregas.Name = "grdEntregas";
            this.grdEntregas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEntregas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdEntregas.RowTemplate.Height = 24;
            this.grdEntregas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEntregas.Size = new System.Drawing.Size(1185, 257);
            this.grdEntregas.TabIndex = 0;
            this.grdEntregas.Click += new System.EventHandler(this.grdEntregas_Click_1);
            // 
            // dtDateServiceOrderDeliveredDataGridViewTextBoxColumn
            // 
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn.DataPropertyName = "dtDateServiceOrderDelivered";
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn.HeaderText = "Data Entrega";
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn.Name = "dtDateServiceOrderDeliveredDataGridViewTextBoxColumn";
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sNameDataGridViewTextBoxColumn
            // 
            this.sNameDataGridViewTextBoxColumn.DataPropertyName = "sName";
            this.sNameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.sNameDataGridViewTextBoxColumn.Name = "sNameDataGridViewTextBoxColumn";
            this.sNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sAdressDataGridViewTextBoxColumn
            // 
            this.sAdressDataGridViewTextBoxColumn.DataPropertyName = "sAdress";
            this.sAdressDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.sAdressDataGridViewTextBoxColumn.Name = "sAdressDataGridViewTextBoxColumn";
            this.sAdressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTelephoneDataGridViewTextBoxColumn
            // 
            this.sTelephoneDataGridViewTextBoxColumn.DataPropertyName = "sTelephone";
            this.sTelephoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.sTelephoneDataGridViewTextBoxColumn.Name = "sTelephoneDataGridViewTextBoxColumn";
            this.sTelephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sObservationDataGridViewTextBoxColumn
            // 
            this.sObservationDataGridViewTextBoxColumn.DataPropertyName = "sObservation";
            this.sObservationDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.sObservationDataGridViewTextBoxColumn.Name = "sObservationDataGridViewTextBoxColumn";
            this.sObservationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTotalDataGridViewTextBoxColumn
            // 
            this.dTotalDataGridViewTextBoxColumn.DataPropertyName = "dTotal";
            this.dTotalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.dTotalDataGridViewTextBoxColumn.Name = "dTotalDataGridViewTextBoxColumn";
            this.dTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sID
            // 
            this.sID.DataPropertyName = "sID";
            this.sID.HeaderText = "sID";
            this.sID.Name = "sID";
            this.sID.ReadOnly = true;
            this.sID.Visible = false;
            // 
            // tbdeliveryfinishedBindingSource1
            // 
            this.tbdeliveryfinishedBindingSource1.DataMember = "tb_delivery_finished";
            this.tbdeliveryfinishedBindingSource1.DataSource = this.inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource;
            // 
            // inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource
            // 
            this.inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource.DataSource = this.inoxErpDBDataSet3ServiceOrdersApprovedGidView;
            this.inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource.Position = 0;
            // 
            // inoxErpDBDataSet3ServiceOrdersApprovedGidView
            // 
            this.inoxErpDBDataSet3ServiceOrdersApprovedGidView.DataSetName = "InoxErpDBDataSet3ServiceOrdersApprovedGidView";
            this.inoxErpDBDataSet3ServiceOrdersApprovedGidView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(12, 402);
            this.btnAbrir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(150, 30);
            this.btnAbrir.TabIndex = 9;
            this.btnAbrir.Text = "Abrir / Alterar";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnReabrirEntrega
            // 
            this.btnReabrirEntrega.Location = new System.Drawing.Point(1064, 402);
            this.btnReabrirEntrega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReabrirEntrega.Name = "btnReabrirEntrega";
            this.btnReabrirEntrega.Size = new System.Drawing.Size(150, 30);
            this.btnReabrirEntrega.TabIndex = 18;
            this.btnReabrirEntrega.Text = "Reabrir Entrega";
            this.btnReabrirEntrega.UseVisualStyleBackColor = true;
            this.btnReabrirEntrega.Click += new System.EventHandler(this.btnReabrirEntrega_Click);
            // 
            // tb_delivery_finishedTableAdapter
            // 
            this.tb_delivery_finishedTableAdapter.ClearBeforeFill = true;
            // 
            // tbdeliveryfinishedBindingSource
            // 
            this.tbdeliveryfinishedBindingSource.DataMember = "tb_delivery_finished";
            this.tbdeliveryfinishedBindingSource.DataSource = this.inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource;
            // 
            // tb_budgets_osTableAdapter
            // 
            this.tb_budgets_osTableAdapter.ClearBeforeFill = true;
            // 
            // generalDataSet
            // 
            this.generalDataSet.DataSetName = "GeneralDataSet";
            this.generalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmDeliveryFinished
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 450);
            this.Controls.Add(this.btnReabrirEntrega);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.grpPesquisa);
            this.Controls.Add(this.grpEntregas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDeliveryFinished";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entregas Finalizadas";
            this.Load += new System.EventHandler(this.frmDeliveryFinished_Load);
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.grpEntregas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEntregas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdeliveryfinishedBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inoxErpDBDataSet3ServiceOrdersApprovedGidView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdeliveryfinishedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbudgetsosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalDataSet)).EndInit();
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
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnReabrirEntrega;
        private System.Windows.Forms.BindingSource inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource;
        private InoxErpDBDataSet3ServiceOrdersApprovedGidView inoxErpDBDataSet3ServiceOrdersApprovedGidView;
        private InoxErpDBDataSet3ServiceOrdersApprovedGidViewTableAdapters.tb_delivery_finishedTableAdapter tb_delivery_finishedTableAdapter;
        private System.Windows.Forms.BindingSource tbdeliveryfinishedBindingSource;
        private GeneralDataSetTableAdapters.tb_budgets_osTableAdapter tb_budgets_osTableAdapter;
        private System.Windows.Forms.BindingSource tbbudgetsosBindingSource;
        private System.Windows.Forms.BindingSource generalDataSetBindingSource;
        private GeneralDataSet generalDataSet;
        private System.Windows.Forms.BindingSource tbdeliveryfinishedBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateServiceOrderDeliveredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sObservationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sID;
    }
}