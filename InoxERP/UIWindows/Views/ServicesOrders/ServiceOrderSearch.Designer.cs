namespace UIWindows
{
    partial class frmServiceOrderSearch
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
            this.btnFinlizar = new System.Windows.Forms.Button();
            this.btnDesaprovar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.grpOrdemServico = new System.Windows.Forms.GroupBox();
            this.tbbudgetsosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UIWindows.FullDataSet();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.radData = new System.Windows.Forms.RadioButton();
            this.radCPF_CNPJ = new System.Windows.Forms.RadioButton();
            this.radNome = new System.Windows.Forms.RadioButton();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnGerarContrato = new System.Windows.Forms.Button();
            this.tb_budgets_osTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_budgets_osTableAdapter();
            this.dgvOrdemServico = new System.Windows.Forms.DataGridView();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtStartPrevisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFinalPrevisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOccupationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPaymentToMatchDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dPercentDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPaymentInstallmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bInterestRateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dWithInterestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iWarrantyTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtBudgetExpirationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sObservationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bServiceOrderDeliveredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRegisterFinishedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtDateRegisterFinishedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpOrdemServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbbudgetsosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            this.grpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdemServico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinlizar
            // 
            this.btnFinlizar.Location = new System.Drawing.Point(714, 406);
            this.btnFinlizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinlizar.Name = "btnFinlizar";
            this.btnFinlizar.Size = new System.Drawing.Size(120, 30);
            this.btnFinlizar.TabIndex = 11;
            this.btnFinlizar.Text = "Finalizar";
            this.btnFinlizar.UseVisualStyleBackColor = true;
            this.btnFinlizar.Click += new System.EventHandler(this.btnFinlizar_Click);
            // 
            // btnDesaprovar
            // 
            this.btnDesaprovar.Location = new System.Drawing.Point(349, 406);
            this.btnDesaprovar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesaprovar.Name = "btnDesaprovar";
            this.btnDesaprovar.Size = new System.Drawing.Size(120, 30);
            this.btnDesaprovar.TabIndex = 10;
            this.btnDesaprovar.Text = "Desaprovar";
            this.btnDesaprovar.UseVisualStyleBackColor = true;
            this.btnDesaprovar.Click += new System.EventHandler(this.btnDespaprovar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(23, 406);
            this.btnAbrir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(120, 30);
            this.btnAbrir.TabIndex = 8;
            this.btnAbrir.Text = "Abrir / Alterar";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // grpOrdemServico
            // 
            this.grpOrdemServico.AutoSize = true;
            this.grpOrdemServico.Controls.Add(this.dgvOrdemServico);
            this.grpOrdemServico.Location = new System.Drawing.Point(12, 95);
            this.grpOrdemServico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOrdemServico.Name = "grpOrdemServico";
            this.grpOrdemServico.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOrdemServico.Size = new System.Drawing.Size(1211, 290);
            this.grpOrdemServico.TabIndex = 7;
            this.grpOrdemServico.TabStop = false;
            this.grpOrdemServico.Text = "Ordens de Serviço";
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
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.btnPesquisar);
            this.grpPesquisa.Controls.Add(this.txtPesquisa);
            this.grpPesquisa.Controls.Add(this.radData);
            this.grpPesquisa.Controls.Add(this.radCPF_CNPJ);
            this.grpPesquisa.Controls.Add(this.radNome);
            this.grpPesquisa.Controls.Add(this.lblTipo);
            this.grpPesquisa.Location = new System.Drawing.Point(12, 15);
            this.grpPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPesquisa.Size = new System.Drawing.Size(1208, 74);
            this.grpPesquisa.TabIndex = 6;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisa";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(889, 20);
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
            this.txtPesquisa.Location = new System.Drawing.Point(545, 24);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(331, 23);
            this.txtPesquisa.TabIndex = 4;
            // 
            // radData
            // 
            this.radData.AutoSize = true;
            this.radData.Location = new System.Drawing.Point(472, 25);
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
            this.radCPF_CNPJ.Location = new System.Drawing.Point(336, 25);
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
            this.radNome.Location = new System.Drawing.Point(243, 25);
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
            this.lblTipo.Location = new System.Drawing.Point(196, 26);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 17);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // btnGerarContrato
            // 
            this.btnGerarContrato.Location = new System.Drawing.Point(1100, 406);
            this.btnGerarContrato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerarContrato.Name = "btnGerarContrato";
            this.btnGerarContrato.Size = new System.Drawing.Size(120, 30);
            this.btnGerarContrato.TabIndex = 12;
            this.btnGerarContrato.Text = "Gerar Contrato";
            this.btnGerarContrato.UseVisualStyleBackColor = true;
            this.btnGerarContrato.Click += new System.EventHandler(this.btnGerarContrato_Click);
            // 
            // tb_budgets_osTableAdapter
            // 
            this.tb_budgets_osTableAdapter.ClearBeforeFill = true;
            // 
            // dgvOrdemServico
            // 
            this.dgvOrdemServico.AllowUserToAddRows = false;
            this.dgvOrdemServico.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvOrdemServico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrdemServico.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdemServico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrdemServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdemServico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.dtDateDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.sTelephoneDataGridViewTextBoxColumn,
            this.dTotalDataGridViewTextBoxColumn,
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn,
            this.dtStartPrevisionDataGridViewTextBoxColumn,
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn,
            this.dtFinalPrevisionDataGridViewTextBoxColumn,
            this.clientTypeDataGridViewTextBoxColumn,
            this.iCodDataGridViewTextBoxColumn,
            this.sAdressDataGridViewTextBoxColumn,
            this.sOccupationDataGridViewTextBoxColumn,
            this.paymentMethodsDataGridViewTextBoxColumn,
            this.bPaymentToMatchDataGridViewCheckBoxColumn,
            this.dPercentDiscountDataGridViewTextBoxColumn,
            this.iPaymentInstallmentsDataGridViewTextBoxColumn,
            this.bInterestRateDataGridViewCheckBoxColumn,
            this.dWithInterestDataGridViewTextBoxColumn,
            this.iWarrantyTimeDataGridViewTextBoxColumn,
            this.dtBudgetExpirationDateDataGridViewTextBoxColumn,
            this.sObservationDataGridViewTextBoxColumn,
            this.bServiceOrderApprovedDataGridViewCheckBoxColumn,
            this.bServiceOrderDeliveredDataGridViewCheckBoxColumn,
            this.dtDateServiceOrderDeliveredDataGridViewTextBoxColumn,
            this.bRegisterFinishedDataGridViewCheckBoxColumn,
            this.dtDateRegisterFinishedDataGridViewTextBoxColumn,
            this.idClientsDataGridViewTextBoxColumn});
            this.dgvOrdemServico.DataSource = this.tbbudgetsosBindingSource;
            this.dgvOrdemServico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdemServico.Location = new System.Drawing.Point(3, 18);
            this.dgvOrdemServico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOrdemServico.MultiSelect = false;
            this.dgvOrdemServico.Name = "dgvOrdemServico";
            this.dgvOrdemServico.ReadOnly = true;
            this.dgvOrdemServico.RowTemplate.Height = 24;
            this.dgvOrdemServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdemServico.Size = new System.Drawing.Size(1205, 270);
            this.dgvOrdemServico.TabIndex = 0;
            this.dgvOrdemServico.Click += new System.EventHandler(this.grdOrdemServico_Click);
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
            this.dTotalDataGridViewTextBoxColumn.HeaderText = "Valor da O.S.";
            this.dTotalDataGridViewTextBoxColumn.Name = "dTotalDataGridViewTextBoxColumn";
            this.dTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.dTotalDataGridViewTextBoxColumn.Width = 118;
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
            // dtStartPrevisionDataGridViewTextBoxColumn
            // 
            this.dtStartPrevisionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dtStartPrevisionDataGridViewTextBoxColumn.DataPropertyName = "dtStartPrevision";
            this.dtStartPrevisionDataGridViewTextBoxColumn.HeaderText = "Início do Serviço";
            this.dtStartPrevisionDataGridViewTextBoxColumn.Name = "dtStartPrevisionDataGridViewTextBoxColumn";
            this.dtStartPrevisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtStartPrevisionDataGridViewTextBoxColumn.Width = 124;
            // 
            // iPrevisionOfExecuteDataGridViewTextBoxColumn
            // 
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.DataPropertyName = "iPrevisionOfExecute";
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.HeaderText = "Previsão de Execução (Dias)";
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.Name = "iPrevisionOfExecuteDataGridViewTextBoxColumn";
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.ReadOnly = true;
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.Width = 161;
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
            // clientTypeDataGridViewTextBoxColumn
            // 
            this.clientTypeDataGridViewTextBoxColumn.DataPropertyName = "ClientType";
            this.clientTypeDataGridViewTextBoxColumn.HeaderText = "ClientType";
            this.clientTypeDataGridViewTextBoxColumn.Name = "clientTypeDataGridViewTextBoxColumn";
            this.clientTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // iCodDataGridViewTextBoxColumn
            // 
            this.iCodDataGridViewTextBoxColumn.DataPropertyName = "iCod";
            this.iCodDataGridViewTextBoxColumn.HeaderText = "iCod";
            this.iCodDataGridViewTextBoxColumn.Name = "iCodDataGridViewTextBoxColumn";
            this.iCodDataGridViewTextBoxColumn.ReadOnly = true;
            this.iCodDataGridViewTextBoxColumn.Visible = false;
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
            // frmServiceOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 450);
            this.Controls.Add(this.btnGerarContrato);
            this.Controls.Add(this.btnFinlizar);
            this.Controls.Add(this.btnDesaprovar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.grpOrdemServico);
            this.Controls.Add(this.grpPesquisa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmServiceOrderSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Ordem de Serviço";
            this.Load += new System.EventHandler(this.frmServiceOrderSearch_Load);
            this.grpOrdemServico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbbudgetsosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdemServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinlizar;
        private System.Windows.Forms.Button btnDesaprovar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.GroupBox grpOrdemServico;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton radData;
        private System.Windows.Forms.RadioButton radCPF_CNPJ;
        private System.Windows.Forms.RadioButton radNome;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnGerarContrato;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource tbbudgetsosBindingSource;
        private FullDataSetTableAdapters.tb_budgets_osTableAdapter tb_budgets_osTableAdapter;
        private System.Windows.Forms.DataGridView dgvOrdemServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateServiceOrderApprovedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtStartPrevisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPrevisionOfExecuteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtFinalPrevisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOccupationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bPaymentToMatchDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPercentDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPaymentInstallmentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bInterestRateDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dWithInterestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iWarrantyTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtBudgetExpirationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sObservationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bServiceOrderApprovedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bServiceOrderDeliveredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateServiceOrderDeliveredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bRegisterFinishedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateRegisterFinishedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientsDataGridViewTextBoxColumn;
    }
}