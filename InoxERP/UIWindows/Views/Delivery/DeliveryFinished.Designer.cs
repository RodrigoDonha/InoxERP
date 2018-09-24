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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.radData = new System.Windows.Forms.RadioButton();
            this.radCPF_CNPJ = new System.Windows.Forms.RadioButton();
            this.radNome = new System.Windows.Forms.RadioButton();
            this.lblTipo = new System.Windows.Forms.Label();
            this.grpEntregas = new System.Windows.Forms.GroupBox();
            this.dgvEntregasFinalizadas = new System.Windows.Forms.DataGridView();
            this.tbbudgetsosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UIWindows.FullDataSet();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnReabrirEntrega = new System.Windows.Forms.Button();
            this.tbbudgetsosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_budgets_osTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_budgets_osTableAdapter();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sObservationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOccupationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPaymentToMatchDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dPercentDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPaymentInstallmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bInterestRateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dWithInterestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtStartPrevisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFinalPrevisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iWarrantyTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtBudgetExpirationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bServiceOrderDeliveredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bRegisterFinishedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtDateRegisterFinishedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPesquisa.SuspendLayout();
            this.grpEntregas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregasFinalizadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbudgetsosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbudgetsosBindingSource)).BeginInit();
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
            this.btnPesquisar.Location = new System.Drawing.Point(872, 23);
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
            this.txtPesquisa.Location = new System.Drawing.Point(535, 27);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(331, 23);
            this.txtPesquisa.TabIndex = 4;
            // 
            // radData
            // 
            this.radData.AutoSize = true;
            this.radData.Location = new System.Drawing.Point(469, 28);
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
            this.radCPF_CNPJ.Location = new System.Drawing.Point(336, 28);
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
            this.radNome.Location = new System.Drawing.Point(243, 28);
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
            this.lblTipo.Location = new System.Drawing.Point(196, 30);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 17);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // grpEntregas
            // 
            this.grpEntregas.Controls.Add(this.dgvEntregasFinalizadas);
            this.grpEntregas.Location = new System.Drawing.Point(12, 92);
            this.grpEntregas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEntregas.Name = "grpEntregas";
            this.grpEntregas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEntregas.Size = new System.Drawing.Size(1202, 293);
            this.grpEntregas.TabIndex = 13;
            this.grpEntregas.TabStop = false;
            this.grpEntregas.Text = "Entregas";
            // 
            // dgvEntregasFinalizadas
            // 
            this.dgvEntregasFinalizadas.AllowUserToAddRows = false;
            this.dgvEntregasFinalizadas.AllowUserToDeleteRows = false;
            this.dgvEntregasFinalizadas.AutoGenerateColumns = false;
            this.dgvEntregasFinalizadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntregasFinalizadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntregasFinalizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregasFinalizadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.sAdressDataGridViewTextBoxColumn,
            this.sTelephoneDataGridViewTextBoxColumn,
            this.sObservationDataGridViewTextBoxColumn,
            this.dTotalDataGridViewTextBoxColumn,
            this.iCodDataGridViewTextBoxColumn,
            this.clientTypeDataGridViewTextBoxColumn,
            this.dtDateDataGridViewTextBoxColumn,
            this.sOccupationDataGridViewTextBoxColumn,
            this.paymentMethodsDataGridViewTextBoxColumn,
            this.bPaymentToMatchDataGridViewCheckBoxColumn,
            this.dPercentDiscountDataGridViewTextBoxColumn,
            this.iPaymentInstallmentsDataGridViewTextBoxColumn,
            this.bInterestRateDataGridViewCheckBoxColumn,
            this.dWithInterestDataGridViewTextBoxColumn,
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn,
            this.dtStartPrevisionDataGridViewTextBoxColumn,
            this.dtFinalPrevisionDataGridViewTextBoxColumn,
            this.iWarrantyTimeDataGridViewTextBoxColumn,
            this.dtBudgetExpirationDateDataGridViewTextBoxColumn,
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn,
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn,
            this.bServiceOrderDeliveredDataGridViewCheckBoxColumn,
            this.bRegisterFinishedDataGridViewCheckBoxColumn,
            this.dtDateRegisterFinishedDataGridViewTextBoxColumn,
            this.idClientsDataGridViewTextBoxColumn});
            this.dgvEntregasFinalizadas.DataSource = this.tbbudgetsosBindingSource1;
            this.dgvEntregasFinalizadas.Location = new System.Drawing.Point(11, 21);
            this.dgvEntregasFinalizadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEntregasFinalizadas.MultiSelect = false;
            this.dgvEntregasFinalizadas.Name = "dgvEntregasFinalizadas";
            this.dgvEntregasFinalizadas.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntregasFinalizadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEntregasFinalizadas.RowTemplate.Height = 24;
            this.dgvEntregasFinalizadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntregasFinalizadas.Size = new System.Drawing.Size(1185, 268);
            this.dgvEntregasFinalizadas.TabIndex = 0;
            this.dgvEntregasFinalizadas.Click += new System.EventHandler(this.grdEntregas_Click_1);
            // 
            // tbbudgetsosBindingSource1
            // 
            this.tbbudgetsosBindingSource1.DataMember = "tb_budgets_os";
            this.tbbudgetsosBindingSource1.DataSource = this.fullDataSet;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tbbudgetsosBindingSource
            // 
            this.tbbudgetsosBindingSource.DataMember = "tb_budgets_os";
            this.tbbudgetsosBindingSource.DataSource = this.fullDataSet;
            // 
            // tb_budgets_osTableAdapter
            // 
            this.tb_budgets_osTableAdapter.ClearBeforeFill = true;
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "sID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "sID";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            this.sIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtDateServiceOrderDeliveredDataGridViewTextBoxColumn
            // 
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn.DataPropertyName = "dtDateServiceOrderDelivered";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn.HeaderText = "Data da Entrega";
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn.Name = "dtDateServiceOrderDeliveredDataGridViewTextBoxColumn";
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn.Width = 125;
            // 
            // sNameDataGridViewTextBoxColumn
            // 
            this.sNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sNameDataGridViewTextBoxColumn.DataPropertyName = "sName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.sNameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.sNameDataGridViewTextBoxColumn.Name = "sNameDataGridViewTextBoxColumn";
            this.sNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sAdressDataGridViewTextBoxColumn
            // 
            this.sAdressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sAdressDataGridViewTextBoxColumn.DataPropertyName = "sAdress";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sAdressDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.sAdressDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.sAdressDataGridViewTextBoxColumn.Name = "sAdressDataGridViewTextBoxColumn";
            this.sAdressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTelephoneDataGridViewTextBoxColumn
            // 
            this.sTelephoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sTelephoneDataGridViewTextBoxColumn.DataPropertyName = "sTelephone";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sTelephoneDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.sTelephoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.sTelephoneDataGridViewTextBoxColumn.Name = "sTelephoneDataGridViewTextBoxColumn";
            this.sTelephoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTelephoneDataGridViewTextBoxColumn.Width = 89;
            // 
            // sObservationDataGridViewTextBoxColumn
            // 
            this.sObservationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sObservationDataGridViewTextBoxColumn.DataPropertyName = "sObservation";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sObservationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.sObservationDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.sObservationDataGridViewTextBoxColumn.Name = "sObservationDataGridViewTextBoxColumn";
            this.sObservationDataGridViewTextBoxColumn.ReadOnly = true;
            this.sObservationDataGridViewTextBoxColumn.Visible = false;
            this.sObservationDataGridViewTextBoxColumn.Width = 96;
            // 
            // dTotalDataGridViewTextBoxColumn
            // 
            this.dTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dTotalDataGridViewTextBoxColumn.DataPropertyName = "dTotal";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.dTotalDataGridViewTextBoxColumn.HeaderText = "Total da O.S.";
            this.dTotalDataGridViewTextBoxColumn.Name = "dTotalDataGridViewTextBoxColumn";
            this.dTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.dTotalDataGridViewTextBoxColumn.Width = 82;
            // 
            // iCodDataGridViewTextBoxColumn
            // 
            this.iCodDataGridViewTextBoxColumn.DataPropertyName = "iCod";
            this.iCodDataGridViewTextBoxColumn.HeaderText = "iCod";
            this.iCodDataGridViewTextBoxColumn.Name = "iCodDataGridViewTextBoxColumn";
            this.iCodDataGridViewTextBoxColumn.ReadOnly = true;
            this.iCodDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientTypeDataGridViewTextBoxColumn
            // 
            this.clientTypeDataGridViewTextBoxColumn.DataPropertyName = "ClientType";
            this.clientTypeDataGridViewTextBoxColumn.HeaderText = "ClientType";
            this.clientTypeDataGridViewTextBoxColumn.Name = "clientTypeDataGridViewTextBoxColumn";
            this.clientTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtDateDataGridViewTextBoxColumn
            // 
            this.dtDateDataGridViewTextBoxColumn.DataPropertyName = "dtDate";
            this.dtDateDataGridViewTextBoxColumn.HeaderText = "dtDate";
            this.dtDateDataGridViewTextBoxColumn.Name = "dtDateDataGridViewTextBoxColumn";
            this.dtDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // sOccupationDataGridViewTextBoxColumn
            // 
            this.sOccupationDataGridViewTextBoxColumn.DataPropertyName = "sOccupation";
            this.sOccupationDataGridViewTextBoxColumn.HeaderText = "sOccupation";
            this.sOccupationDataGridViewTextBoxColumn.Name = "sOccupationDataGridViewTextBoxColumn";
            this.sOccupationDataGridViewTextBoxColumn.ReadOnly = true;
            this.sOccupationDataGridViewTextBoxColumn.Visible = false;
            // 
            // paymentMethodsDataGridViewTextBoxColumn
            // 
            this.paymentMethodsDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethods";
            this.paymentMethodsDataGridViewTextBoxColumn.HeaderText = "PaymentMethods";
            this.paymentMethodsDataGridViewTextBoxColumn.Name = "paymentMethodsDataGridViewTextBoxColumn";
            this.paymentMethodsDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentMethodsDataGridViewTextBoxColumn.Visible = false;
            // 
            // bPaymentToMatchDataGridViewCheckBoxColumn
            // 
            this.bPaymentToMatchDataGridViewCheckBoxColumn.DataPropertyName = "bPaymentToMatch";
            this.bPaymentToMatchDataGridViewCheckBoxColumn.HeaderText = "bPaymentToMatch";
            this.bPaymentToMatchDataGridViewCheckBoxColumn.Name = "bPaymentToMatchDataGridViewCheckBoxColumn";
            this.bPaymentToMatchDataGridViewCheckBoxColumn.ReadOnly = true;
            this.bPaymentToMatchDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dPercentDiscountDataGridViewTextBoxColumn
            // 
            this.dPercentDiscountDataGridViewTextBoxColumn.DataPropertyName = "dPercentDiscount";
            this.dPercentDiscountDataGridViewTextBoxColumn.HeaderText = "dPercentDiscount";
            this.dPercentDiscountDataGridViewTextBoxColumn.Name = "dPercentDiscountDataGridViewTextBoxColumn";
            this.dPercentDiscountDataGridViewTextBoxColumn.ReadOnly = true;
            this.dPercentDiscountDataGridViewTextBoxColumn.Visible = false;
            // 
            // iPaymentInstallmentsDataGridViewTextBoxColumn
            // 
            this.iPaymentInstallmentsDataGridViewTextBoxColumn.DataPropertyName = "iPaymentInstallments";
            this.iPaymentInstallmentsDataGridViewTextBoxColumn.HeaderText = "iPaymentInstallments";
            this.iPaymentInstallmentsDataGridViewTextBoxColumn.Name = "iPaymentInstallmentsDataGridViewTextBoxColumn";
            this.iPaymentInstallmentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.iPaymentInstallmentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // bInterestRateDataGridViewCheckBoxColumn
            // 
            this.bInterestRateDataGridViewCheckBoxColumn.DataPropertyName = "bInterestRate";
            this.bInterestRateDataGridViewCheckBoxColumn.HeaderText = "bInterestRate";
            this.bInterestRateDataGridViewCheckBoxColumn.Name = "bInterestRateDataGridViewCheckBoxColumn";
            this.bInterestRateDataGridViewCheckBoxColumn.ReadOnly = true;
            this.bInterestRateDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dWithInterestDataGridViewTextBoxColumn
            // 
            this.dWithInterestDataGridViewTextBoxColumn.DataPropertyName = "dWithInterest";
            this.dWithInterestDataGridViewTextBoxColumn.HeaderText = "dWithInterest";
            this.dWithInterestDataGridViewTextBoxColumn.Name = "dWithInterestDataGridViewTextBoxColumn";
            this.dWithInterestDataGridViewTextBoxColumn.ReadOnly = true;
            this.dWithInterestDataGridViewTextBoxColumn.Visible = false;
            // 
            // iPrevisionOfExecuteDataGridViewTextBoxColumn
            // 
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.DataPropertyName = "iPrevisionOfExecute";
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.HeaderText = "iPrevisionOfExecute";
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.Name = "iPrevisionOfExecuteDataGridViewTextBoxColumn";
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.ReadOnly = true;
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtStartPrevisionDataGridViewTextBoxColumn
            // 
            this.dtStartPrevisionDataGridViewTextBoxColumn.DataPropertyName = "dtStartPrevision";
            this.dtStartPrevisionDataGridViewTextBoxColumn.HeaderText = "dtStartPrevision";
            this.dtStartPrevisionDataGridViewTextBoxColumn.Name = "dtStartPrevisionDataGridViewTextBoxColumn";
            this.dtStartPrevisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtStartPrevisionDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtFinalPrevisionDataGridViewTextBoxColumn
            // 
            this.dtFinalPrevisionDataGridViewTextBoxColumn.DataPropertyName = "dtFinalPrevision";
            this.dtFinalPrevisionDataGridViewTextBoxColumn.HeaderText = "dtFinalPrevision";
            this.dtFinalPrevisionDataGridViewTextBoxColumn.Name = "dtFinalPrevisionDataGridViewTextBoxColumn";
            this.dtFinalPrevisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtFinalPrevisionDataGridViewTextBoxColumn.Visible = false;
            // 
            // iWarrantyTimeDataGridViewTextBoxColumn
            // 
            this.iWarrantyTimeDataGridViewTextBoxColumn.DataPropertyName = "iWarrantyTime";
            this.iWarrantyTimeDataGridViewTextBoxColumn.HeaderText = "iWarrantyTime";
            this.iWarrantyTimeDataGridViewTextBoxColumn.Name = "iWarrantyTimeDataGridViewTextBoxColumn";
            this.iWarrantyTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.iWarrantyTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtBudgetExpirationDateDataGridViewTextBoxColumn
            // 
            this.dtBudgetExpirationDateDataGridViewTextBoxColumn.DataPropertyName = "dtBudgetExpirationDate";
            this.dtBudgetExpirationDateDataGridViewTextBoxColumn.HeaderText = "dtBudgetExpirationDate";
            this.dtBudgetExpirationDateDataGridViewTextBoxColumn.Name = "dtBudgetExpirationDateDataGridViewTextBoxColumn";
            this.dtBudgetExpirationDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtBudgetExpirationDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // bServiceOrderApprovedDataGridViewCheckBoxColumn
            // 
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn.DataPropertyName = "bServiceOrderApproved";
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn.HeaderText = "bServiceOrderApproved";
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn.Name = "bServiceOrderApprovedDataGridViewCheckBoxColumn";
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dtDateServiceOrderApprovedDataGridViewTextBoxColumn
            // 
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.DataPropertyName = "dtDateServiceOrderApproved";
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.HeaderText = "dtDateServiceOrderApproved";
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.Name = "dtDateServiceOrderApprovedDataGridViewTextBoxColumn";
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.Visible = false;
            // 
            // bServiceOrderDeliveredDataGridViewCheckBoxColumn
            // 
            this.bServiceOrderDeliveredDataGridViewCheckBoxColumn.DataPropertyName = "bServiceOrderDelivered";
            this.bServiceOrderDeliveredDataGridViewCheckBoxColumn.HeaderText = "bServiceOrderDelivered";
            this.bServiceOrderDeliveredDataGridViewCheckBoxColumn.Name = "bServiceOrderDeliveredDataGridViewCheckBoxColumn";
            this.bServiceOrderDeliveredDataGridViewCheckBoxColumn.ReadOnly = true;
            this.bServiceOrderDeliveredDataGridViewCheckBoxColumn.Visible = false;
            // 
            // bRegisterFinishedDataGridViewCheckBoxColumn
            // 
            this.bRegisterFinishedDataGridViewCheckBoxColumn.DataPropertyName = "bRegisterFinished";
            this.bRegisterFinishedDataGridViewCheckBoxColumn.HeaderText = "bRegisterFinished";
            this.bRegisterFinishedDataGridViewCheckBoxColumn.Name = "bRegisterFinishedDataGridViewCheckBoxColumn";
            this.bRegisterFinishedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.bRegisterFinishedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dtDateRegisterFinishedDataGridViewTextBoxColumn
            // 
            this.dtDateRegisterFinishedDataGridViewTextBoxColumn.DataPropertyName = "dtDateRegisterFinished";
            this.dtDateRegisterFinishedDataGridViewTextBoxColumn.HeaderText = "dtDateRegisterFinished";
            this.dtDateRegisterFinishedDataGridViewTextBoxColumn.Name = "dtDateRegisterFinishedDataGridViewTextBoxColumn";
            this.dtDateRegisterFinishedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtDateRegisterFinishedDataGridViewTextBoxColumn.Visible = false;
            // 
            // idClientsDataGridViewTextBoxColumn
            // 
            this.idClientsDataGridViewTextBoxColumn.DataPropertyName = "IdClients";
            this.idClientsDataGridViewTextBoxColumn.HeaderText = "IdClients";
            this.idClientsDataGridViewTextBoxColumn.Name = "idClientsDataGridViewTextBoxColumn";
            this.idClientsDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClientsDataGridViewTextBoxColumn.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregasFinalizadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbudgetsosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbudgetsosBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvEntregasFinalizadas;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnReabrirEntrega;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource tbbudgetsosBindingSource;
        private FullDataSetTableAdapters.tb_budgets_osTableAdapter tb_budgets_osTableAdapter;
        private System.Windows.Forms.BindingSource tbbudgetsosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateServiceOrderDeliveredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sObservationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOccupationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bPaymentToMatchDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPercentDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPaymentInstallmentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bInterestRateDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dWithInterestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPrevisionOfExecuteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtStartPrevisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtFinalPrevisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iWarrantyTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtBudgetExpirationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bServiceOrderApprovedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateServiceOrderApprovedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bServiceOrderDeliveredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bRegisterFinishedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateRegisterFinishedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientsDataGridViewTextBoxColumn;
    }
}