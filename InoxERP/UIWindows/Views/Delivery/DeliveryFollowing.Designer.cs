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
            this.dgvEntregas = new System.Windows.Forms.DataGridView();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFinalPrevisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sObservationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.iWarrantyTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtBudgetExpirationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bServiceOrderDeliveredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRegisterFinishedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtDateRegisterFinishedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbbudgetsosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UIWindows.FullDataSet();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAbrirAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnReabrirOS = new System.Windows.Forms.Button();
            this.tb_budgets_osTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_budgets_osTableAdapter();
            this.grpPesquisa.SuspendLayout();
            this.grpEntregas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbudgetsosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
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
            this.grpPesquisa.TabIndex = 6;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisa";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(875, 23);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(85, 30);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(538, 27);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(331, 23);
            this.txtPesquisa.TabIndex = 4;
            // 
            // radData
            // 
            this.radData.AutoSize = true;
            this.radData.Location = new System.Drawing.Point(472, 28);
            this.radData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radData.Name = "radData";
            this.radData.Size = new System.Drawing.Size(56, 21);
            this.radData.TabIndex = 3;
            this.radData.TabStop = true;
            this.radData.Text = "Data";
            this.radData.UseVisualStyleBackColor = true;
            this.radData.Click += new System.EventHandler(this.radData_Click);
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
            this.grpEntregas.Controls.Add(this.dgvEntregas);
            this.grpEntregas.Location = new System.Drawing.Point(12, 92);
            this.grpEntregas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEntregas.Name = "grpEntregas";
            this.grpEntregas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEntregas.Size = new System.Drawing.Size(1202, 290);
            this.grpEntregas.TabIndex = 7;
            this.grpEntregas.TabStop = false;
            this.grpEntregas.Text = "Entregas";
            // 
            // dgvEntregas
            // 
            this.dgvEntregas.AllowUserToAddRows = false;
            this.dgvEntregas.AllowUserToDeleteRows = false;
            this.dgvEntregas.AutoGenerateColumns = false;
            this.dgvEntregas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.dtFinalPrevisionDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.sAdressDataGridViewTextBoxColumn,
            this.sTelephoneDataGridViewTextBoxColumn,
            this.sObservationDataGridViewTextBoxColumn,
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn,
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
            this.iWarrantyTimeDataGridViewTextBoxColumn,
            this.dtBudgetExpirationDateDataGridViewTextBoxColumn,
            this.dTotalDataGridViewTextBoxColumn,
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn,
            this.bServiceOrderDeliveredDataGridViewCheckBoxColumn,
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn,
            this.bRegisterFinishedDataGridViewCheckBoxColumn,
            this.dtDateRegisterFinishedDataGridViewTextBoxColumn,
            this.idClientsDataGridViewTextBoxColumn});
            this.dgvEntregas.DataSource = this.tbbudgetsosBindingSource;
            this.dgvEntregas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEntregas.Location = new System.Drawing.Point(3, 18);
            this.dgvEntregas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEntregas.MultiSelect = false;
            this.dgvEntregas.Name = "dgvEntregas";
            this.dgvEntregas.ReadOnly = true;
            this.dgvEntregas.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvEntregas.RowTemplate.Height = 24;
            this.dgvEntregas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntregas.Size = new System.Drawing.Size(1196, 270);
            this.dgvEntregas.TabIndex = 0;
            this.dgvEntregas.Click += new System.EventHandler(this.grdEntregas_Click);
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "sID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "sID";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            this.sIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtFinalPrevisionDataGridViewTextBoxColumn
            // 
            this.dtFinalPrevisionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dtFinalPrevisionDataGridViewTextBoxColumn.DataPropertyName = "dtFinalPrevision";
            this.dtFinalPrevisionDataGridViewTextBoxColumn.HeaderText = "Previsão de Entrega";
            this.dtFinalPrevisionDataGridViewTextBoxColumn.Name = "dtFinalPrevisionDataGridViewTextBoxColumn";
            this.dtFinalPrevisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtFinalPrevisionDataGridViewTextBoxColumn.Width = 103;
            // 
            // sNameDataGridViewTextBoxColumn
            // 
            this.sNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sNameDataGridViewTextBoxColumn.DataPropertyName = "sName";
            this.sNameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.sNameDataGridViewTextBoxColumn.Name = "sNameDataGridViewTextBoxColumn";
            this.sNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNameDataGridViewTextBoxColumn.Width = 70;
            // 
            // sAdressDataGridViewTextBoxColumn
            // 
            this.sAdressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sAdressDataGridViewTextBoxColumn.DataPropertyName = "sAdress";
            this.sAdressDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.sAdressDataGridViewTextBoxColumn.Name = "sAdressDataGridViewTextBoxColumn";
            this.sAdressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTelephoneDataGridViewTextBoxColumn
            // 
            this.sTelephoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sTelephoneDataGridViewTextBoxColumn.DataPropertyName = "sTelephone";
            this.sTelephoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.sTelephoneDataGridViewTextBoxColumn.Name = "sTelephoneDataGridViewTextBoxColumn";
            this.sTelephoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTelephoneDataGridViewTextBoxColumn.Width = 89;
            // 
            // sObservationDataGridViewTextBoxColumn
            // 
            this.sObservationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sObservationDataGridViewTextBoxColumn.DataPropertyName = "sObservation";
            this.sObservationDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.sObservationDataGridViewTextBoxColumn.Name = "sObservationDataGridViewTextBoxColumn";
            this.sObservationDataGridViewTextBoxColumn.ReadOnly = true;
            this.sObservationDataGridViewTextBoxColumn.Width = 96;
            // 
            // dtDateServiceOrderApprovedDataGridViewTextBoxColumn
            // 
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.DataPropertyName = "dtDateServiceOrderApproved";
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.HeaderText = "Aprovação da O.S.";
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.Name = "dtDateServiceOrderApprovedDataGridViewTextBoxColumn";
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.Width = 114;
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
            // dTotalDataGridViewTextBoxColumn
            // 
            this.dTotalDataGridViewTextBoxColumn.DataPropertyName = "dTotal";
            this.dTotalDataGridViewTextBoxColumn.HeaderText = "dTotal";
            this.dTotalDataGridViewTextBoxColumn.Name = "dTotalDataGridViewTextBoxColumn";
            this.dTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.dTotalDataGridViewTextBoxColumn.Visible = false;
            // 
            // bServiceOrderApprovedDataGridViewCheckBoxColumn
            // 
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn.DataPropertyName = "bServiceOrderApproved";
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn.HeaderText = "bServiceOrderApproved";
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn.Name = "bServiceOrderApprovedDataGridViewCheckBoxColumn";
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // bServiceOrderDeliveredDataGridViewCheckBoxColumn
            // 
            this.bServiceOrderDeliveredDataGridViewCheckBoxColumn.DataPropertyName = "bServiceOrderDelivered";
            this.bServiceOrderDeliveredDataGridViewCheckBoxColumn.HeaderText = "bServiceOrderDelivered";
            this.bServiceOrderDeliveredDataGridViewCheckBoxColumn.Name = "bServiceOrderDeliveredDataGridViewCheckBoxColumn";
            this.bServiceOrderDeliveredDataGridViewCheckBoxColumn.ReadOnly = true;
            this.bServiceOrderDeliveredDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dtDateServiceOrderDeliveredDataGridViewTextBoxColumn
            // 
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn.DataPropertyName = "dtDateServiceOrderDelivered";
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn.HeaderText = "dtDateServiceOrderDelivered";
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn.Name = "dtDateServiceOrderDeliveredDataGridViewTextBoxColumn";
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn.Visible = false;
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
            // tbbudgetsosBindingSource
            // 
            this.tbbudgetsosBindingSource.DataMember = "tb_budgets_os";
            this.tbbudgetsosBindingSource.DataSource = this.fullDataSet;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(696, 399);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(120, 30);
            this.btnFinalizar.TabIndex = 11;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnAbrirAlterar
            // 
            this.btnAbrirAlterar.Location = new System.Drawing.Point(15, 399);
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
            this.btnExcluir.Location = new System.Drawing.Point(1091, 399);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(120, 30);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnReabrirOS
            // 
            this.btnReabrirOS.Location = new System.Drawing.Point(328, 399);
            this.btnReabrirOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReabrirOS.Name = "btnReabrirOS";
            this.btnReabrirOS.Size = new System.Drawing.Size(120, 30);
            this.btnReabrirOS.TabIndex = 18;
            this.btnReabrirOS.Text = "Reabrir OS";
            this.btnReabrirOS.UseVisualStyleBackColor = true;
            this.btnReabrirOS.Click += new System.EventHandler(this.btnReabrirOS_Click);
            // 
            // tb_budgets_osTableAdapter
            // 
            this.tb_budgets_osTableAdapter.ClearBeforeFill = true;
            // 
            // frmDeliveryFollowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 450);
            this.Controls.Add(this.btnReabrirOS);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbudgetsosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvEntregas;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnAbrirAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnReabrirOS;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource tbbudgetsosBindingSource;
        private FullDataSetTableAdapters.tb_budgets_osTableAdapter tb_budgets_osTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtFinalPrevisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sObservationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateServiceOrderApprovedDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iWarrantyTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtBudgetExpirationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bServiceOrderApprovedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bServiceOrderDeliveredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateServiceOrderDeliveredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bRegisterFinishedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateRegisterFinishedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientsDataGridViewTextBoxColumn;
    }
}