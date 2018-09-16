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
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.radData = new System.Windows.Forms.RadioButton();
            this.radCPF_CNPJ = new System.Windows.Forms.RadioButton();
            this.radNome = new System.Windows.Forms.RadioButton();
            this.lblTipo = new System.Windows.Forms.Label();
            this.grpOrcamentos = new System.Windows.Forms.GroupBox();
            this.dgvOrcamentos = new System.Windows.Forms.DataGridView();
            this.dtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAprovar = new System.Windows.Forms.Button();
            this.fKdbotbitemsdbotbbudgetsosBudgetsOSsIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.sID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sObservationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbbudgetsosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.inoxErpDBDataSet2 = new UIWindows.InoxErpDBDataSet2();
            this.tbbudgetsosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_budgets_osTableAdapter = new UIWindows.InoxErpDBDataSet2TableAdapters.tb_budgets_osTableAdapter();
            this.tbitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_itemsTableAdapter = new UIWindows.InoxErpDBDataSet2TableAdapters.tb_itemsTableAdapter();
            this.tbbudgetsosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKdbotbitemsdbotbbudgetsosIdBudgetsOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtDateRegisterFinishedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRegisterFinishedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtBudgetExpirationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iWarrantyTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFinalPrevisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtStartPrevisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dWithInterestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bInterestRateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iPaymentInstallmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPercentDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPaymentToMatchDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clientTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOccupationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPesquisa.SuspendLayout();
            this.grpOrcamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdbotbitemsdbotbbudgetsosBudgetsOSsIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbudgetsosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inoxErpDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbudgetsosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbudgetsosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdbotbitemsdbotbbudgetsosIdBudgetsOSBindingSource)).BeginInit();
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
            this.sID,
            this.dTotal,
            this.sObservationDataGridViewTextBoxColumn,
            this.dtDate,
            this.sName,
            this.sTelephone,
            this.sAdressDataGridViewTextBoxColumn,
            this.sOccupationDataGridViewTextBoxColumn,
            this.clientTypeDataGridViewTextBoxColumn,
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
            this.bRegisterFinishedDataGridViewCheckBoxColumn,
            this.dtDateRegisterFinishedDataGridViewTextBoxColumn});
            this.dgvOrcamentos.DataSource = this.tbbudgetsosBindingSource2;
            this.dgvOrcamentos.Location = new System.Drawing.Point(11, 21);
            this.dgvOrcamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOrcamentos.MultiSelect = false;
            this.dgvOrcamentos.Name = "dgvOrcamentos";
            this.dgvOrcamentos.ReadOnly = true;
            this.dgvOrcamentos.RowTemplate.Height = 24;
            this.dgvOrcamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrcamentos.Size = new System.Drawing.Size(755, 257);
            this.dgvOrcamentos.TabIndex = 0;
            this.dgvOrcamentos.Click += new System.EventHandler(this.dgvBudgets_Click);
            // 
            // dtDate
            // 
            this.dtDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtDate.DataPropertyName = "dtDate";
            this.dtDate.HeaderText = "Data";
            this.dtDate.Name = "dtDate";
            this.dtDate.ReadOnly = true;
            // 
            // dTotal
            // 
            this.dTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dTotal.DataPropertyName = "dTotal";
            this.dTotal.HeaderText = "Total Orçamento";
            this.dTotal.Name = "dTotal";
            this.dTotal.ReadOnly = true;
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
            // fKdbotbitemsdbotbbudgetsosBudgetsOSsIDBindingSource
            // 
            this.fKdbotbitemsdbotbbudgetsosBudgetsOSsIDBindingSource.DataMember = "FK_dbo.tb_items_dbo.tb_budgets_os_IdBudgets_OS";
            this.fKdbotbitemsdbotbbudgetsosBudgetsOSsIDBindingSource.DataSource = this.tbbudgetsosBindingSource;
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
            // sID
            // 
            this.sID.DataPropertyName = "sID";
            this.sID.HeaderText = "sID";
            this.sID.Name = "sID";
            this.sID.ReadOnly = true;
            this.sID.Visible = false;
            // 
            // sObservationDataGridViewTextBoxColumn
            // 
            this.sObservationDataGridViewTextBoxColumn.DataPropertyName = "sObservation";
            this.sObservationDataGridViewTextBoxColumn.HeaderText = "sObservation";
            this.sObservationDataGridViewTextBoxColumn.Name = "sObservationDataGridViewTextBoxColumn";
            this.sObservationDataGridViewTextBoxColumn.ReadOnly = true;
            this.sObservationDataGridViewTextBoxColumn.Visible = false;
            // 
            // tbbudgetsosBindingSource2
            // 
            this.tbbudgetsosBindingSource2.DataMember = "tb_budgets_os";
            this.tbbudgetsosBindingSource2.DataSource = this.inoxErpDBDataSet2;
            // 
            // inoxErpDBDataSet2
            // 
            this.inoxErpDBDataSet2.DataSetName = "InoxErpDBDataSet2";
            this.inoxErpDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbbudgetsosBindingSource
            // 
            this.tbbudgetsosBindingSource.DataMember = "tb_budgets_os";
            this.tbbudgetsosBindingSource.DataSource = this.inoxErpDBDataSet2;
            // 
            // tb_budgets_osTableAdapter
            // 
            this.tb_budgets_osTableAdapter.ClearBeforeFill = true;
            // 
            // tbitemsBindingSource
            // 
            this.tbitemsBindingSource.DataMember = "tb_items";
            this.tbitemsBindingSource.DataSource = this.inoxErpDBDataSet2;
            // 
            // tb_itemsTableAdapter
            // 
            this.tb_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // tbbudgetsosBindingSource1
            // 
            this.tbbudgetsosBindingSource1.DataMember = "tb_budgets_os";
            this.tbbudgetsosBindingSource1.DataSource = this.inoxErpDBDataSet2;
            // 
            // fKdbotbitemsdbotbbudgetsosIdBudgetsOSBindingSource
            // 
            this.fKdbotbitemsdbotbbudgetsosIdBudgetsOSBindingSource.DataMember = "FK_dbo.tb_items_dbo.tb_budgets_os_IdBudgets_OS";
            this.fKdbotbitemsdbotbbudgetsosIdBudgetsOSBindingSource.DataSource = this.tbbudgetsosBindingSource2;
            // 
            // dtDateRegisterFinishedDataGridViewTextBoxColumn
            // 
            this.dtDateRegisterFinishedDataGridViewTextBoxColumn.DataPropertyName = "dtDateRegisterFinished";
            this.dtDateRegisterFinishedDataGridViewTextBoxColumn.HeaderText = "dtDateRegisterFinished";
            this.dtDateRegisterFinishedDataGridViewTextBoxColumn.Name = "dtDateRegisterFinishedDataGridViewTextBoxColumn";
            this.dtDateRegisterFinishedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtDateRegisterFinishedDataGridViewTextBoxColumn.Visible = false;
            // 
            // bRegisterFinishedDataGridViewCheckBoxColumn
            // 
            this.bRegisterFinishedDataGridViewCheckBoxColumn.DataPropertyName = "bRegisterFinished";
            this.bRegisterFinishedDataGridViewCheckBoxColumn.HeaderText = "bRegisterFinished";
            this.bRegisterFinishedDataGridViewCheckBoxColumn.Name = "bRegisterFinishedDataGridViewCheckBoxColumn";
            this.bRegisterFinishedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.bRegisterFinishedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dtDateServiceOrderApprovedDataGridViewTextBoxColumn
            // 
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.DataPropertyName = "dtDateServiceOrderApproved";
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.HeaderText = "dtDateServiceOrderApproved";
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.Name = "dtDateServiceOrderApprovedDataGridViewTextBoxColumn";
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.Visible = false;
            // 
            // bServiceOrderApprovedDataGridViewCheckBoxColumn
            // 
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn.DataPropertyName = "bServiceOrderApproved";
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn.HeaderText = "bServiceOrderApproved";
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn.Name = "bServiceOrderApprovedDataGridViewCheckBoxColumn";
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dtBudgetExpirationDateDataGridViewTextBoxColumn
            // 
            this.dtBudgetExpirationDateDataGridViewTextBoxColumn.DataPropertyName = "dtBudgetExpirationDate";
            this.dtBudgetExpirationDateDataGridViewTextBoxColumn.HeaderText = "dtBudgetExpirationDate";
            this.dtBudgetExpirationDateDataGridViewTextBoxColumn.Name = "dtBudgetExpirationDateDataGridViewTextBoxColumn";
            this.dtBudgetExpirationDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtBudgetExpirationDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // iWarrantyTimeDataGridViewTextBoxColumn
            // 
            this.iWarrantyTimeDataGridViewTextBoxColumn.DataPropertyName = "iWarrantyTime";
            this.iWarrantyTimeDataGridViewTextBoxColumn.HeaderText = "iWarrantyTime";
            this.iWarrantyTimeDataGridViewTextBoxColumn.Name = "iWarrantyTimeDataGridViewTextBoxColumn";
            this.iWarrantyTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.iWarrantyTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtFinalPrevisionDataGridViewTextBoxColumn
            // 
            this.dtFinalPrevisionDataGridViewTextBoxColumn.DataPropertyName = "dtFinalPrevision";
            this.dtFinalPrevisionDataGridViewTextBoxColumn.HeaderText = "dtFinalPrevision";
            this.dtFinalPrevisionDataGridViewTextBoxColumn.Name = "dtFinalPrevisionDataGridViewTextBoxColumn";
            this.dtFinalPrevisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtFinalPrevisionDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtStartPrevisionDataGridViewTextBoxColumn
            // 
            this.dtStartPrevisionDataGridViewTextBoxColumn.DataPropertyName = "dtStartPrevision";
            this.dtStartPrevisionDataGridViewTextBoxColumn.HeaderText = "dtStartPrevision";
            this.dtStartPrevisionDataGridViewTextBoxColumn.Name = "dtStartPrevisionDataGridViewTextBoxColumn";
            this.dtStartPrevisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtStartPrevisionDataGridViewTextBoxColumn.Visible = false;
            // 
            // iPrevisionOfExecuteDataGridViewTextBoxColumn
            // 
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.DataPropertyName = "iPrevisionOfExecute";
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.HeaderText = "iPrevisionOfExecute";
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.Name = "iPrevisionOfExecuteDataGridViewTextBoxColumn";
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.ReadOnly = true;
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.Visible = false;
            // 
            // dWithInterestDataGridViewTextBoxColumn
            // 
            this.dWithInterestDataGridViewTextBoxColumn.DataPropertyName = "dWithInterest";
            this.dWithInterestDataGridViewTextBoxColumn.HeaderText = "dWithInterest";
            this.dWithInterestDataGridViewTextBoxColumn.Name = "dWithInterestDataGridViewTextBoxColumn";
            this.dWithInterestDataGridViewTextBoxColumn.ReadOnly = true;
            this.dWithInterestDataGridViewTextBoxColumn.Visible = false;
            // 
            // bInterestRateDataGridViewCheckBoxColumn
            // 
            this.bInterestRateDataGridViewCheckBoxColumn.DataPropertyName = "bInterestRate";
            this.bInterestRateDataGridViewCheckBoxColumn.HeaderText = "bInterestRate";
            this.bInterestRateDataGridViewCheckBoxColumn.Name = "bInterestRateDataGridViewCheckBoxColumn";
            this.bInterestRateDataGridViewCheckBoxColumn.ReadOnly = true;
            this.bInterestRateDataGridViewCheckBoxColumn.Visible = false;
            // 
            // iPaymentInstallmentsDataGridViewTextBoxColumn
            // 
            this.iPaymentInstallmentsDataGridViewTextBoxColumn.DataPropertyName = "iPaymentInstallments";
            this.iPaymentInstallmentsDataGridViewTextBoxColumn.HeaderText = "iPaymentInstallments";
            this.iPaymentInstallmentsDataGridViewTextBoxColumn.Name = "iPaymentInstallmentsDataGridViewTextBoxColumn";
            this.iPaymentInstallmentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.iPaymentInstallmentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // dPercentDiscountDataGridViewTextBoxColumn
            // 
            this.dPercentDiscountDataGridViewTextBoxColumn.DataPropertyName = "dPercentDiscount";
            this.dPercentDiscountDataGridViewTextBoxColumn.HeaderText = "dPercentDiscount";
            this.dPercentDiscountDataGridViewTextBoxColumn.Name = "dPercentDiscountDataGridViewTextBoxColumn";
            this.dPercentDiscountDataGridViewTextBoxColumn.ReadOnly = true;
            this.dPercentDiscountDataGridViewTextBoxColumn.Visible = false;
            // 
            // bPaymentToMatchDataGridViewCheckBoxColumn
            // 
            this.bPaymentToMatchDataGridViewCheckBoxColumn.DataPropertyName = "bPaymentToMatch";
            this.bPaymentToMatchDataGridViewCheckBoxColumn.HeaderText = "bPaymentToMatch";
            this.bPaymentToMatchDataGridViewCheckBoxColumn.Name = "bPaymentToMatchDataGridViewCheckBoxColumn";
            this.bPaymentToMatchDataGridViewCheckBoxColumn.ReadOnly = true;
            this.bPaymentToMatchDataGridViewCheckBoxColumn.Visible = false;
            // 
            // clientTypeDataGridViewTextBoxColumn
            // 
            this.clientTypeDataGridViewTextBoxColumn.DataPropertyName = "ClientType";
            this.clientTypeDataGridViewTextBoxColumn.HeaderText = "ClientType";
            this.clientTypeDataGridViewTextBoxColumn.Name = "clientTypeDataGridViewTextBoxColumn";
            this.clientTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // sOccupationDataGridViewTextBoxColumn
            // 
            this.sOccupationDataGridViewTextBoxColumn.DataPropertyName = "sOccupation";
            this.sOccupationDataGridViewTextBoxColumn.HeaderText = "sOccupation";
            this.sOccupationDataGridViewTextBoxColumn.Name = "sOccupationDataGridViewTextBoxColumn";
            this.sOccupationDataGridViewTextBoxColumn.ReadOnly = true;
            this.sOccupationDataGridViewTextBoxColumn.Visible = false;
            // 
            // sAdressDataGridViewTextBoxColumn
            // 
            this.sAdressDataGridViewTextBoxColumn.DataPropertyName = "sAdress";
            this.sAdressDataGridViewTextBoxColumn.HeaderText = "sAdress";
            this.sAdressDataGridViewTextBoxColumn.Name = "sAdressDataGridViewTextBoxColumn";
            this.sAdressDataGridViewTextBoxColumn.ReadOnly = true;
            this.sAdressDataGridViewTextBoxColumn.Visible = false;
            // 
            // sTelephone
            // 
            this.sTelephone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTelephone.DataPropertyName = "sTelephone";
            this.sTelephone.HeaderText = "Telefone";
            this.sTelephone.Name = "sTelephone";
            this.sTelephone.ReadOnly = true;
            // 
            // sName
            // 
            this.sName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sName.DataPropertyName = "sName";
            this.sName.HeaderText = "Nome";
            this.sName.Name = "sName";
            this.sName.ReadOnly = true;
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBudgetSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Orcamentos";
            this.Load += new System.EventHandler(this.frmBudgetSearch_Load);
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.grpOrcamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdbotbitemsdbotbbudgetsosBudgetsOSsIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbudgetsosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inoxErpDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbudgetsosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbudgetsosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdbotbitemsdbotbbudgetsosIdBudgetsOSBindingSource)).EndInit();
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
        private InoxErpDBDataSet2 inoxErpDBDataSet2;
        private System.Windows.Forms.BindingSource tbbudgetsosBindingSource;
        private InoxErpDBDataSet2TableAdapters.tb_budgets_osTableAdapter tb_budgets_osTableAdapter;
        private System.Windows.Forms.BindingSource tbitemsBindingSource;
        private InoxErpDBDataSet2TableAdapters.tb_itemsTableAdapter tb_itemsTableAdapter;
        private System.Windows.Forms.BindingSource tbbudgetsosBindingSource2;
        private System.Windows.Forms.BindingSource fKdbotbitemsdbotbbudgetsosBudgetsOSsIDBindingSource;
        private System.Windows.Forms.BindingSource tbbudgetsosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn sObservationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn sName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOccupationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTypeDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn bRegisterFinishedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateRegisterFinishedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKdbotbitemsdbotbbudgetsosIdBudgetsOSBindingSource;
    }
}