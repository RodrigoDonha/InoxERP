namespace UIWindows
{
    partial class frmBudgetSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBudgetSearch));
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.radData = new System.Windows.Forms.RadioButton();
            this.radCPF_CNPJ = new System.Windows.Forms.RadioButton();
            this.radNome = new System.Windows.Forms.RadioButton();
            this.lblTipo = new System.Windows.Forms.Label();
            this.grpOrcamentos = new System.Windows.Forms.GroupBox();
            this.dgvOrcamentos = new System.Windows.Forms.DataGridView();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.sObservationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bServiceOrderDeliveredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRegisterFinishedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtDateRegisterFinishedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbbudgetsosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UIWindows.FullDataSet();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAprovar = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tb_budgets_osTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_budgets_osTableAdapter();
            this.grpPesquisa.SuspendLayout();
            this.grpOrcamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamentos)).BeginInit();
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
            this.grpPesquisa.Size = new System.Drawing.Size(776, 74);
            this.grpPesquisa.TabIndex = 0;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisa";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(691, 21);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(80, 30);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(347, 25);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisa.MaxLength = 100;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(331, 23);
            this.txtPesquisa.TabIndex = 4;
            // 
            // radData
            // 
            this.radData.AutoSize = true;
            this.radData.Location = new System.Drawing.Point(281, 26);
            this.radData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radData.Name = "radData";
            this.radData.Size = new System.Drawing.Size(56, 21);
            this.radData.TabIndex = 3;
            this.radData.Text = "Data";
            this.radData.UseVisualStyleBackColor = true;
            this.radData.Click += new System.EventHandler(this.radData_Click);
            // 
            // radCPF_CNPJ
            // 
            this.radCPF_CNPJ.AutoSize = true;
            this.radCPF_CNPJ.Location = new System.Drawing.Point(145, 26);
            this.radCPF_CNPJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radCPF_CNPJ.Name = "radCPF_CNPJ";
            this.radCPF_CNPJ.Size = new System.Drawing.Size(91, 21);
            this.radCPF_CNPJ.TabIndex = 2;
            this.radCPF_CNPJ.Text = "CPF/CNPJ";
            this.radCPF_CNPJ.UseVisualStyleBackColor = true;
            // 
            // radNome
            // 
            this.radNome.AutoSize = true;
            this.radNome.Checked = true;
            this.radNome.Location = new System.Drawing.Point(52, 26);
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
            this.lblTipo.Location = new System.Drawing.Point(5, 27);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 17);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // grpOrcamentos
            // 
            this.grpOrcamentos.Controls.Add(this.dgvOrcamentos);
            this.grpOrcamentos.Location = new System.Drawing.Point(12, 92);
            this.grpOrcamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOrcamentos.Name = "grpOrcamentos";
            this.grpOrcamentos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOrcamentos.Size = new System.Drawing.Size(786, 298);
            this.grpOrcamentos.TabIndex = 1;
            this.grpOrcamentos.TabStop = false;
            this.grpOrcamentos.Text = "Orçamentos";
            // 
            // dgvOrcamentos
            // 
            this.dgvOrcamentos.AllowUserToAddRows = false;
            this.dgvOrcamentos.AllowUserToDeleteRows = false;
            this.dgvOrcamentos.AutoGenerateColumns = false;
            this.dgvOrcamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrcamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.dtDateDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.sTelephoneDataGridViewTextBoxColumn,
            this.dTotalDataGridViewTextBoxColumn,
            this.iCodDataGridViewTextBoxColumn,
            this.clientTypeDataGridViewTextBoxColumn,
            this.sAdressDataGridViewTextBoxColumn,
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
            this.sObservationDataGridViewTextBoxColumn,
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn,
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn,
            this.bServiceOrderDeliveredDataGridViewCheckBoxColumn,
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn,
            this.bRegisterFinishedDataGridViewCheckBoxColumn,
            this.dtDateRegisterFinishedDataGridViewTextBoxColumn,
            this.idClientsDataGridViewTextBoxColumn});
            this.dgvOrcamentos.DataSource = this.tbbudgetsosBindingSource;
            this.dgvOrcamentos.Location = new System.Drawing.Point(11, 21);
            this.dgvOrcamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOrcamentos.MultiSelect = false;
            this.dgvOrcamentos.Name = "dgvOrcamentos";
            this.dgvOrcamentos.ReadOnly = true;
            this.dgvOrcamentos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvOrcamentos.RowTemplate.Height = 24;
            this.dgvOrcamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrcamentos.Size = new System.Drawing.Size(755, 257);
            this.dgvOrcamentos.TabIndex = 0;
            this.dgvOrcamentos.Click += new System.EventHandler(this.dgvBudgets_Click);
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "sID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "sID";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            this.sIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtDateDataGridViewTextBoxColumn
            // 
            this.dtDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dtDateDataGridViewTextBoxColumn.DataPropertyName = "dtDate";
            this.dtDateDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dtDateDataGridViewTextBoxColumn.Name = "dtDateDataGridViewTextBoxColumn";
            this.dtDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtDateDataGridViewTextBoxColumn.Width = 63;
            // 
            // sNameDataGridViewTextBoxColumn
            // 
            this.sNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sNameDataGridViewTextBoxColumn.DataPropertyName = "sName";
            this.sNameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.sNameDataGridViewTextBoxColumn.Name = "sNameDataGridViewTextBoxColumn";
            this.sNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dTotalDataGridViewTextBoxColumn
            // 
            this.dTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dTotalDataGridViewTextBoxColumn.DataPropertyName = "dTotal";
            this.dTotalDataGridViewTextBoxColumn.HeaderText = "Total do Orçamento";
            this.dTotalDataGridViewTextBoxColumn.Name = "dTotalDataGridViewTextBoxColumn";
            this.dTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.dTotalDataGridViewTextBoxColumn.Width = 145;
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
            // sAdressDataGridViewTextBoxColumn
            // 
            this.sAdressDataGridViewTextBoxColumn.DataPropertyName = "sAdress";
            this.sAdressDataGridViewTextBoxColumn.HeaderText = "sAdress";
            this.sAdressDataGridViewTextBoxColumn.Name = "sAdressDataGridViewTextBoxColumn";
            this.sAdressDataGridViewTextBoxColumn.ReadOnly = true;
            this.sAdressDataGridViewTextBoxColumn.Visible = false;
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
            // sObservationDataGridViewTextBoxColumn
            // 
            this.sObservationDataGridViewTextBoxColumn.DataPropertyName = "sObservation";
            this.sObservationDataGridViewTextBoxColumn.HeaderText = "sObservation";
            this.sObservationDataGridViewTextBoxColumn.Name = "sObservationDataGridViewTextBoxColumn";
            this.sObservationDataGridViewTextBoxColumn.ReadOnly = true;
            this.sObservationDataGridViewTextBoxColumn.Visible = false;
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
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(277, 402);
            this.btnAbrir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(80, 30);
            this.btnAbrir.TabIndex = 2;
            this.btnAbrir.Text = "Alterar";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(516, 402);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 30);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAprovar
            // 
            this.btnAprovar.Location = new System.Drawing.Point(157, 402);
            this.btnAprovar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Size = new System.Drawing.Size(80, 30);
            this.btnAprovar.TabIndex = 5;
            this.btnAprovar.Text = "Aprovar";
            this.btnAprovar.UseVisualStyleBackColor = true;
            this.btnAprovar.Click += new System.EventHandler(this.btnAprovar_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(396, 402);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 30);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tb_budgets_osTableAdapter
            // 
            this.tb_budgets_osTableAdapter.ClearBeforeFill = true;
            // 
            // frmBudgetSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnAprovar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.grpOrcamentos);
            this.Controls.Add(this.grpPesquisa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmBudgetSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Orcamentos";
            this.Load += new System.EventHandler(this.frmBudgetSearch_Load);
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.grpOrcamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamentos)).EndInit();
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
        private System.Windows.Forms.GroupBox grpOrcamentos;
        private System.Windows.Forms.DataGridView dgvOrcamentos;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAprovar;
        private System.Windows.Forms.Button btnPrint;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource tbbudgetsosBindingSource;
        private FullDataSetTableAdapters.tb_budgets_osTableAdapter tb_budgets_osTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAdressDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn sObservationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bServiceOrderApprovedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateServiceOrderApprovedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bServiceOrderDeliveredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateServiceOrderDeliveredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bRegisterFinishedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateRegisterFinishedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientsDataGridViewTextBoxColumn;
    }
}