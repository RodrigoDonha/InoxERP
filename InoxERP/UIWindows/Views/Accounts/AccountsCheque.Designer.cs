namespace UIWindows
{
    partial class frmAccountsCheque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountsCheque));
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtReferenteA = new System.Windows.Forms.TextBox();
            this.lblReferenteA = new System.Windows.Forms.Label();
            this.lblNumeroCheque = new System.Windows.Forms.Label();
            this.nudParcelas = new System.Windows.Forms.NumericUpDown();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.grdCheques = new System.Windows.Forms.DataGridView();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIdBudgetsOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIdClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPayDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iInstallmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bChequePaidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iAmountInstallmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sReferentToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sChequeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbchequesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UIWindows.FullDataSet();
            this.lblVecto = new System.Windows.Forms.Label();
            this.lblOrcamento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_chequesTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_chequesTableAdapter();
            this.lblId = new System.Windows.Forms.Label();
            this.nudPrazo = new System.Windows.Forms.NumericUpDown();
            this.lblPrazo = new System.Windows.Forms.Label();
            this.txtC3 = new System.Windows.Forms.TextBox();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.txtC1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCheques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbchequesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrazo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Location = new System.Drawing.Point(17, 50);
            this.lblCodCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(55, 16);
            this.lblCodCliente.TabIndex = 2;
            this.lblCodCliente.Text = "Cliente: ";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(104, 48);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNomeCliente.MaxLength = 100;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(300, 22);
            this.txtNomeCliente.TabIndex = 3;
            this.txtNomeCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCliente_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(413, 44);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 28);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtReferenteA
            // 
            this.txtReferenteA.Location = new System.Drawing.Point(104, 201);
            this.txtReferenteA.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtReferenteA.MaxLength = 100;
            this.txtReferenteA.Name = "txtReferenteA";
            this.txtReferenteA.Size = new System.Drawing.Size(408, 22);
            this.txtReferenteA.TabIndex = 16;
            // 
            // lblReferenteA
            // 
            this.lblReferenteA.AutoSize = true;
            this.lblReferenteA.Location = new System.Drawing.Point(17, 204);
            this.lblReferenteA.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblReferenteA.Name = "lblReferenteA";
            this.lblReferenteA.Size = new System.Drawing.Size(84, 16);
            this.lblReferenteA.TabIndex = 15;
            this.lblReferenteA.Text = "Referente a: ";
            // 
            // lblNumeroCheque
            // 
            this.lblNumeroCheque.AutoSize = true;
            this.lblNumeroCheque.Location = new System.Drawing.Point(17, 165);
            this.lblNumeroCheque.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumeroCheque.Name = "lblNumeroCheque";
            this.lblNumeroCheque.Size = new System.Drawing.Size(79, 16);
            this.lblNumeroCheque.TabIndex = 13;
            this.lblNumeroCheque.Text = "Nº Cheque: ";
            // 
            // nudParcelas
            // 
            this.nudParcelas.Location = new System.Drawing.Point(354, 123);
            this.nudParcelas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudParcelas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudParcelas.Name = "nudParcelas";
            this.nudParcelas.Size = new System.Drawing.Size(47, 22);
            this.nudParcelas.TabIndex = 12;
            this.nudParcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Location = new System.Drawing.Point(267, 126);
            this.lblParcelas.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(68, 16);
            this.lblParcelas.TabIndex = 11;
            this.lblParcelas.Text = "Parcelas: ";
            // 
            // btnBaixar
            // 
            this.btnBaixar.Location = new System.Drawing.Point(217, 458);
            this.btnBaixar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(101, 28);
            this.btnBaixar.TabIndex = 20;
            this.btnBaixar.Text = "Baixar";
            this.btnBaixar.UseVisualStyleBackColor = true;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(17, 126);
            this.lblValor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 16);
            this.lblValor.TabIndex = 9;
            this.lblValor.Text = "Valor: ";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(411, 247);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 28);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(217, 247);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(101, 28);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(17, 247);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(101, 28);
            this.btnIncluir.TabIndex = 17;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(104, 122);
            this.txtValor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtValor.MaxLength = 18;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(130, 22);
            this.txtValor.TabIndex = 10;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txtOS
            // 
            this.txtOS.Location = new System.Drawing.Point(104, 85);
            this.txtOS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtOS.MaxLength = 100;
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(130, 22);
            this.txtOS.TabIndex = 6;
            this.txtOS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrcamento_KeyPress);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(356, 84);
            this.dtpData.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(156, 22);
            this.dtpData.TabIndex = 8;
            // 
            // grdCheques
            // 
            this.grdCheques.AllowUserToAddRows = false;
            this.grdCheques.AllowUserToDeleteRows = false;
            this.grdCheques.AutoGenerateColumns = false;
            this.grdCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCheques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.sIdBudgetsOSDataGridViewTextBoxColumn,
            this.sIdClientDataGridViewTextBoxColumn,
            this.dtDueDateDataGridViewTextBoxColumn,
            this.dtPayDateDataGridViewTextBoxColumn,
            this.dValueDataGridViewTextBoxColumn,
            this.iInstallmentDataGridViewTextBoxColumn,
            this.bChequePaidDataGridViewCheckBoxColumn,
            this.iAmountInstallmentDataGridViewTextBoxColumn,
            this.sReferentToDataGridViewTextBoxColumn,
            this.sChequeNumberDataGridViewTextBoxColumn,
            this.idCashDataGridViewTextBoxColumn});
            this.grdCheques.DataSource = this.tbchequesBindingSource;
            this.grdCheques.Location = new System.Drawing.Point(17, 294);
            this.grdCheques.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grdCheques.MultiSelect = false;
            this.grdCheques.Name = "grdCheques";
            this.grdCheques.ReadOnly = true;
            this.grdCheques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCheques.Size = new System.Drawing.Size(496, 156);
            this.grdCheques.TabIndex = 21;
            this.grdCheques.TabStop = false;
            this.grdCheques.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCheques_CellClick);
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "sID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "sID";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            this.sIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sIdBudgetsOSDataGridViewTextBoxColumn
            // 
            this.sIdBudgetsOSDataGridViewTextBoxColumn.DataPropertyName = "sId_Budgets_OS";
            this.sIdBudgetsOSDataGridViewTextBoxColumn.HeaderText = "sId_Budgets_OS";
            this.sIdBudgetsOSDataGridViewTextBoxColumn.Name = "sIdBudgetsOSDataGridViewTextBoxColumn";
            this.sIdBudgetsOSDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIdBudgetsOSDataGridViewTextBoxColumn.Visible = false;
            // 
            // sIdClientDataGridViewTextBoxColumn
            // 
            this.sIdClientDataGridViewTextBoxColumn.DataPropertyName = "sId_Client";
            this.sIdClientDataGridViewTextBoxColumn.HeaderText = "sId_Client";
            this.sIdClientDataGridViewTextBoxColumn.Name = "sIdClientDataGridViewTextBoxColumn";
            this.sIdClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIdClientDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtDueDateDataGridViewTextBoxColumn
            // 
            this.dtDueDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dtDueDateDataGridViewTextBoxColumn.DataPropertyName = "dtDueDate";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtDueDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtDueDateDataGridViewTextBoxColumn.HeaderText = "Vecimento";
            this.dtDueDateDataGridViewTextBoxColumn.Name = "dtDueDateDataGridViewTextBoxColumn";
            this.dtDueDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtDueDateDataGridViewTextBoxColumn.Width = 97;
            // 
            // dtPayDateDataGridViewTextBoxColumn
            // 
            this.dtPayDateDataGridViewTextBoxColumn.DataPropertyName = "dtPayDate";
            this.dtPayDateDataGridViewTextBoxColumn.HeaderText = "dtPayDate";
            this.dtPayDateDataGridViewTextBoxColumn.Name = "dtPayDateDataGridViewTextBoxColumn";
            this.dtPayDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtPayDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // dValueDataGridViewTextBoxColumn
            // 
            this.dValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dValueDataGridViewTextBoxColumn.DataPropertyName = "dValue";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dValueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dValueDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.dValueDataGridViewTextBoxColumn.Name = "dValueDataGridViewTextBoxColumn";
            this.dValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.dValueDataGridViewTextBoxColumn.Width = 65;
            // 
            // iInstallmentDataGridViewTextBoxColumn
            // 
            this.iInstallmentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iInstallmentDataGridViewTextBoxColumn.DataPropertyName = "iInstallment";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.iInstallmentDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.iInstallmentDataGridViewTextBoxColumn.HeaderText = "Parcela";
            this.iInstallmentDataGridViewTextBoxColumn.Name = "iInstallmentDataGridViewTextBoxColumn";
            this.iInstallmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.iInstallmentDataGridViewTextBoxColumn.Width = 80;
            // 
            // bChequePaidDataGridViewCheckBoxColumn
            // 
            this.bChequePaidDataGridViewCheckBoxColumn.DataPropertyName = "bChequePaid";
            this.bChequePaidDataGridViewCheckBoxColumn.HeaderText = "bChequePaid";
            this.bChequePaidDataGridViewCheckBoxColumn.Name = "bChequePaidDataGridViewCheckBoxColumn";
            this.bChequePaidDataGridViewCheckBoxColumn.ReadOnly = true;
            this.bChequePaidDataGridViewCheckBoxColumn.Visible = false;
            // 
            // iAmountInstallmentDataGridViewTextBoxColumn
            // 
            this.iAmountInstallmentDataGridViewTextBoxColumn.DataPropertyName = "iAmountInstallment";
            this.iAmountInstallmentDataGridViewTextBoxColumn.HeaderText = "iAmountInstallment";
            this.iAmountInstallmentDataGridViewTextBoxColumn.Name = "iAmountInstallmentDataGridViewTextBoxColumn";
            this.iAmountInstallmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.iAmountInstallmentDataGridViewTextBoxColumn.Visible = false;
            // 
            // sReferentToDataGridViewTextBoxColumn
            // 
            this.sReferentToDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sReferentToDataGridViewTextBoxColumn.DataPropertyName = "sReferentTo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sReferentToDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.sReferentToDataGridViewTextBoxColumn.HeaderText = "Referente";
            this.sReferentToDataGridViewTextBoxColumn.Name = "sReferentToDataGridViewTextBoxColumn";
            this.sReferentToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sChequeNumberDataGridViewTextBoxColumn
            // 
            this.sChequeNumberDataGridViewTextBoxColumn.DataPropertyName = "sChequeNumber";
            this.sChequeNumberDataGridViewTextBoxColumn.HeaderText = "sChequeNumber";
            this.sChequeNumberDataGridViewTextBoxColumn.Name = "sChequeNumberDataGridViewTextBoxColumn";
            this.sChequeNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.sChequeNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // idCashDataGridViewTextBoxColumn
            // 
            this.idCashDataGridViewTextBoxColumn.DataPropertyName = "idCash";
            this.idCashDataGridViewTextBoxColumn.HeaderText = "idCash";
            this.idCashDataGridViewTextBoxColumn.Name = "idCashDataGridViewTextBoxColumn";
            this.idCashDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCashDataGridViewTextBoxColumn.Visible = false;
            // 
            // tbchequesBindingSource
            // 
            this.tbchequesBindingSource.DataMember = "tb_cheques";
            this.tbchequesBindingSource.DataSource = this.fullDataSet;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblVecto
            // 
            this.lblVecto.AutoSize = true;
            this.lblVecto.Location = new System.Drawing.Point(267, 86);
            this.lblVecto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVecto.Name = "lblVecto";
            this.lblVecto.Size = new System.Drawing.Size(85, 16);
            this.lblVecto.TabIndex = 7;
            this.lblVecto.Text = "Vencimento: ";
            // 
            // lblOrcamento
            // 
            this.lblOrcamento.AutoSize = true;
            this.lblOrcamento.Location = new System.Drawing.Point(17, 89);
            this.lblOrcamento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOrcamento.Name = "lblOrcamento";
            this.lblOrcamento.Size = new System.Drawing.Size(61, 16);
            this.lblOrcamento.TabIndex = 5;
            this.lblOrcamento.Text = "NF/O.S.: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cheques";
            // 
            // tb_chequesTableAdapter
            // 
            this.tb_chequesTableAdapter.ClearBeforeFill = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(14, 20);
            this.lblId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 16);
            this.lblId.TabIndex = 22;
            this.lblId.Visible = false;
            // 
            // nudPrazo
            // 
            this.nudPrazo.Location = new System.Drawing.Point(466, 124);
            this.nudPrazo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPrazo.Name = "nudPrazo";
            this.nudPrazo.Size = new System.Drawing.Size(47, 22);
            this.nudPrazo.TabIndex = 24;
            // 
            // lblPrazo
            // 
            this.lblPrazo.AutoSize = true;
            this.lblPrazo.Location = new System.Drawing.Point(412, 126);
            this.lblPrazo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(46, 16);
            this.lblPrazo.TabIndex = 23;
            this.lblPrazo.Text = "Prazo:";
            // 
            // txtC3
            // 
            this.txtC3.Location = new System.Drawing.Point(382, 162);
            this.txtC3.MaxLength = 12;
            this.txtC3.Name = "txtC3";
            this.txtC3.Size = new System.Drawing.Size(130, 22);
            this.txtC3.TabIndex = 27;
            this.txtC3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC3_KeyPress);
            this.txtC3.Leave += new System.EventHandler(this.txtC3_Leave);
            // 
            // txtC2
            // 
            this.txtC2.Location = new System.Drawing.Point(244, 162);
            this.txtC2.MaxLength = 10;
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(130, 22);
            this.txtC2.TabIndex = 26;
            this.txtC2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC2_KeyPress);
            this.txtC2.Leave += new System.EventHandler(this.txtC2_Leave);
            // 
            // txtC1
            // 
            this.txtC1.Location = new System.Drawing.Point(103, 162);
            this.txtC1.MaxLength = 8;
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(130, 22);
            this.txtC1.TabIndex = 25;
            this.txtC1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC1_KeyPress);
            this.txtC1.Leave += new System.EventHandler(this.txtC1_Leave);
            // 
            // frmAccountsCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 494);
            this.Controls.Add(this.txtC3);
            this.Controls.Add(this.txtC2);
            this.Controls.Add(this.txtC1);
            this.Controls.Add(this.nudPrazo);
            this.Controls.Add(this.lblPrazo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCodCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtReferenteA);
            this.Controls.Add(this.lblReferenteA);
            this.Controls.Add(this.lblNumeroCheque);
            this.Controls.Add(this.nudParcelas);
            this.Controls.Add(this.lblParcelas);
            this.Controls.Add(this.btnBaixar);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtOS);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.grdCheques);
            this.Controls.Add(this.lblVecto);
            this.Controls.Add(this.lblOrcamento);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmAccountsCheque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa Cheques";
            this.Load += new System.EventHandler(this.frmAccountsCheque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCheques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbchequesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrazo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtReferenteA;
        private System.Windows.Forms.Label lblReferenteA;
        private System.Windows.Forms.Label lblNumeroCheque;
        private System.Windows.Forms.NumericUpDown nudParcelas;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DataGridView grdCheques;
        private System.Windows.Forms.Label lblVecto;
        private System.Windows.Forms.Label lblOrcamento;
        private System.Windows.Forms.Label label1;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource tbchequesBindingSource;
        private FullDataSetTableAdapters.tb_chequesTableAdapter tb_chequesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIdBudgetsOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIdClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPayDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iInstallmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bChequePaidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iAmountInstallmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sReferentToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sChequeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCashDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.NumericUpDown nudPrazo;
        private System.Windows.Forms.Label lblPrazo;
        private System.Windows.Forms.TextBox txtC3;
        private System.Windows.Forms.TextBox txtC2;
        private System.Windows.Forms.TextBox txtC1;
    }
}