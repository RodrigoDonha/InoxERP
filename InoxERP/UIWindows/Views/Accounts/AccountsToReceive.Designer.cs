namespace UIWindows
{
    partial class frmAccountsToReceive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountsToReceive));
            this.lblEntradas = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.lblOS = new System.Windows.Forms.Label();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtReferenteA = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.grdSaidas = new System.Windows.Forms.DataGridView();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIdBudgetsOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIdClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtReceiveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iInstallmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bReceivePaidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iAmountInstallmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sReferentToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBudgetsOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbaccountsToReceiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UIWindows.FullDataSet();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblReferenteA = new System.Windows.Forms.Label();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.nudParcelas = new System.Windows.Forms.NumericUpDown();
            this.tb_accountsToReceiveTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_accountsToReceiveTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdSaidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaccountsToReceiveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradas.Location = new System.Drawing.Point(182, 9);
            this.lblEntradas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(177, 24);
            this.lblEntradas.TabIndex = 1;
            this.lblEntradas.Text = "Contas a Receber";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(382, 45);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(112, 50);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCliente.MaxLength = 100;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(262, 20);
            this.txtNomeCliente.TabIndex = 3;
            this.txtNomeCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeCliente_KeyPress);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(10, 51);
            this.lblNomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(59, 17);
            this.lblNomeCliente.TabIndex = 2;
            this.lblNomeCliente.Text = "Cliente: ";
            // 
            // txtOS
            // 
            this.txtOS.Location = new System.Drawing.Point(112, 83);
            this.txtOS.Margin = new System.Windows.Forms.Padding(4);
            this.txtOS.MaxLength = 100;
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(103, 20);
            this.txtOS.TabIndex = 6;
            this.txtOS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOS_KeyPress);
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOS.Location = new System.Drawing.Point(13, 84);
            this.lblOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(40, 17);
            this.lblOS.TabIndex = 5;
            this.lblOS.Text = "O.S.:";
            // 
            // btnBaixar
            // 
            this.btnBaixar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixar.Location = new System.Drawing.Point(201, 432);
            this.btnBaixar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(100, 28);
            this.btnBaixar.TabIndex = 18;
            this.btnBaixar.Text = "Baixar";
            this.btnBaixar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(382, 192);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 28);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(201, 192);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 28);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(13, 192);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(100, 28);
            this.btnIncluir.TabIndex = 15;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(112, 115);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.MaxLength = 18;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(103, 22);
            this.txtValor.TabIndex = 10;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txtReferenteA
            // 
            this.txtReferenteA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferenteA.Location = new System.Drawing.Point(112, 150);
            this.txtReferenteA.Margin = new System.Windows.Forms.Padding(4);
            this.txtReferenteA.MaxLength = 100;
            this.txtReferenteA.Name = "txtReferenteA";
            this.txtReferenteA.Size = new System.Drawing.Size(369, 22);
            this.txtReferenteA.TabIndex = 14;
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(366, 84);
            this.dtpData.Margin = new System.Windows.Forms.Padding(4);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(115, 22);
            this.dtpData.TabIndex = 8;
            // 
            // grdSaidas
            // 
            this.grdSaidas.AutoGenerateColumns = false;
            this.grdSaidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSaidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.sIdBudgetsOSDataGridViewTextBoxColumn,
            this.sIdClientDataGridViewTextBoxColumn,
            this.dtDueDateDataGridViewTextBoxColumn,
            this.dtReceiveDateDataGridViewTextBoxColumn,
            this.dValueDataGridViewTextBoxColumn,
            this.iInstallmentDataGridViewTextBoxColumn,
            this.bReceivePaidDataGridViewCheckBoxColumn,
            this.iAmountInstallmentDataGridViewTextBoxColumn,
            this.sReferentToDataGridViewTextBoxColumn,
            this.idCashDataGridViewTextBoxColumn,
            this.idBudgetsOSDataGridViewTextBoxColumn});
            this.grdSaidas.DataSource = this.tbaccountsToReceiveBindingSource;
            this.grdSaidas.Location = new System.Drawing.Point(13, 237);
            this.grdSaidas.Margin = new System.Windows.Forms.Padding(4);
            this.grdSaidas.MultiSelect = false;
            this.grdSaidas.Name = "grdSaidas";
            this.grdSaidas.ReadOnly = true;
            this.grdSaidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSaidas.Size = new System.Drawing.Size(469, 185);
            this.grdSaidas.TabIndex = 19;
            this.grdSaidas.TabStop = false;
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
            this.dtDueDateDataGridViewTextBoxColumn.HeaderText = "Vencimento";
            this.dtDueDateDataGridViewTextBoxColumn.Name = "dtDueDateDataGridViewTextBoxColumn";
            this.dtDueDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtDueDateDataGridViewTextBoxColumn.Width = 97;
            // 
            // dtReceiveDateDataGridViewTextBoxColumn
            // 
            this.dtReceiveDateDataGridViewTextBoxColumn.DataPropertyName = "dtReceiveDate";
            this.dtReceiveDateDataGridViewTextBoxColumn.HeaderText = "dtReceiveDate";
            this.dtReceiveDateDataGridViewTextBoxColumn.Name = "dtReceiveDateDataGridViewTextBoxColumn";
            this.dtReceiveDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtReceiveDateDataGridViewTextBoxColumn.Visible = false;
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
            this.dValueDataGridViewTextBoxColumn.Width = 60;
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
            this.iInstallmentDataGridViewTextBoxColumn.Width = 74;
            // 
            // bReceivePaidDataGridViewCheckBoxColumn
            // 
            this.bReceivePaidDataGridViewCheckBoxColumn.DataPropertyName = "bReceivePaid";
            this.bReceivePaidDataGridViewCheckBoxColumn.HeaderText = "bReceivePaid";
            this.bReceivePaidDataGridViewCheckBoxColumn.Name = "bReceivePaidDataGridViewCheckBoxColumn";
            this.bReceivePaidDataGridViewCheckBoxColumn.ReadOnly = true;
            this.bReceivePaidDataGridViewCheckBoxColumn.Visible = false;
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
            // idCashDataGridViewTextBoxColumn
            // 
            this.idCashDataGridViewTextBoxColumn.DataPropertyName = "idCash";
            this.idCashDataGridViewTextBoxColumn.HeaderText = "idCash";
            this.idCashDataGridViewTextBoxColumn.Name = "idCashDataGridViewTextBoxColumn";
            this.idCashDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCashDataGridViewTextBoxColumn.Visible = false;
            // 
            // idBudgetsOSDataGridViewTextBoxColumn
            // 
            this.idBudgetsOSDataGridViewTextBoxColumn.DataPropertyName = "idBudgets_OS";
            this.idBudgetsOSDataGridViewTextBoxColumn.HeaderText = "idBudgets_OS";
            this.idBudgetsOSDataGridViewTextBoxColumn.Name = "idBudgetsOSDataGridViewTextBoxColumn";
            this.idBudgetsOSDataGridViewTextBoxColumn.ReadOnly = true;
            this.idBudgetsOSDataGridViewTextBoxColumn.Visible = false;
            // 
            // tbaccountsToReceiveBindingSource
            // 
            this.tbaccountsToReceiveBindingSource.DataMember = "tb_accountsToReceive";
            this.tbaccountsToReceiveBindingSource.DataSource = this.fullDataSet;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(13, 118);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(49, 17);
            this.lblValor.TabIndex = 9;
            this.lblValor.Text = "Valor: ";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(260, 84);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(90, 17);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Vencimento: ";
            // 
            // lblReferenteA
            // 
            this.lblReferenteA.AutoSize = true;
            this.lblReferenteA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferenteA.Location = new System.Drawing.Point(13, 153);
            this.lblReferenteA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReferenteA.Name = "lblReferenteA";
            this.lblReferenteA.Size = new System.Drawing.Size(91, 17);
            this.lblReferenteA.TabIndex = 13;
            this.lblReferenteA.Text = "Referente a: ";
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcelas.Location = new System.Drawing.Point(260, 118);
            this.lblParcelas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(71, 17);
            this.lblParcelas.TabIndex = 11;
            this.lblParcelas.Text = "Parcelas: ";
            // 
            // nudParcelas
            // 
            this.nudParcelas.Location = new System.Drawing.Point(366, 118);
            this.nudParcelas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudParcelas.Name = "nudParcelas";
            this.nudParcelas.Size = new System.Drawing.Size(48, 20);
            this.nudParcelas.TabIndex = 12;
            this.nudParcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tb_accountsToReceiveTableAdapter
            // 
            this.tb_accountsToReceiveTableAdapter.ClearBeforeFill = true;
            // 
            // frmAccountsToReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 471);
            this.Controls.Add(this.lblParcelas);
            this.Controls.Add(this.nudParcelas);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.txtOS);
            this.Controls.Add(this.lblOS);
            this.Controls.Add(this.btnBaixar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtReferenteA);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.grdSaidas);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblReferenteA);
            this.Controls.Add(this.lblEntradas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccountsToReceive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Receber";
            this.Load += new System.EventHandler(this.frmAccountsToReceive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSaidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaccountsToReceiveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtReferenteA;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DataGridView grdSaidas;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblReferenteA;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.NumericUpDown nudParcelas;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource tbaccountsToReceiveBindingSource;
        private FullDataSetTableAdapters.tb_accountsToReceiveTableAdapter tb_accountsToReceiveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIdBudgetsOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIdClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtReceiveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iInstallmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bReceivePaidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iAmountInstallmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sReferentToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBudgetsOSDataGridViewTextBoxColumn;
    }
}