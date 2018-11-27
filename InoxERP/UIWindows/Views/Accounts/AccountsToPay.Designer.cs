﻿namespace UIWindows
{
    partial class frmAccountsToPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountsToPay));
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
            this.dValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPayDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bReceivePaidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iInstallmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iAmountInstallmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sReferentToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProvidersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbaccountsToPayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UIWindows.FullDataSet();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblReferenteA = new System.Windows.Forms.Label();
            this.lblSaidas = new System.Windows.Forms.Label();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.btnBuscarFornecedor = new System.Windows.Forms.Button();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.lblNomeFornecedor = new System.Windows.Forms.Label();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.lblOS = new System.Windows.Forms.Label();
            this.nudParcelas = new System.Windows.Forms.NumericUpDown();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.tb_accountsToPayTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_accountsToPayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdSaidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaccountsToPayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(382, 192);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 28);
            this.btnExcluir.TabIndex = 39;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(201, 192);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 28);
            this.btnAlterar.TabIndex = 38;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(13, 192);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(100, 28);
            this.btnIncluir.TabIndex = 36;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(112, 115);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor.MaxLength = 18;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(92, 22);
            this.txtValor.TabIndex = 35;
            // 
            // txtReferenteA
            // 
            this.txtReferenteA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferenteA.Location = new System.Drawing.Point(112, 150);
            this.txtReferenteA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReferenteA.MaxLength = 100;
            this.txtReferenteA.Name = "txtReferenteA";
            this.txtReferenteA.Size = new System.Drawing.Size(369, 22);
            this.txtReferenteA.TabIndex = 34;
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(348, 80);
            this.dtpData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(133, 22);
            this.dtpData.TabIndex = 33;
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
            this.dValueDataGridViewTextBoxColumn,
            this.dtPayDateDataGridViewTextBoxColumn,
            this.bReceivePaidDataGridViewCheckBoxColumn,
            this.iInstallmentDataGridViewTextBoxColumn,
            this.iAmountInstallmentDataGridViewTextBoxColumn,
            this.sReferentToDataGridViewTextBoxColumn,
            this.idCashDataGridViewTextBoxColumn,
            this.idProvidersDataGridViewTextBoxColumn});
            this.grdSaidas.DataSource = this.tbaccountsToPayBindingSource;
            this.grdSaidas.Location = new System.Drawing.Point(13, 237);
            this.grdSaidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdSaidas.MultiSelect = false;
            this.grdSaidas.Name = "grdSaidas";
            this.grdSaidas.ReadOnly = true;
            this.grdSaidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSaidas.Size = new System.Drawing.Size(469, 185);
            this.grdSaidas.TabIndex = 32;
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
            // dtPayDateDataGridViewTextBoxColumn
            // 
            this.dtPayDateDataGridViewTextBoxColumn.DataPropertyName = "dtPayDate";
            this.dtPayDateDataGridViewTextBoxColumn.HeaderText = "dtPayDate";
            this.dtPayDateDataGridViewTextBoxColumn.Name = "dtPayDateDataGridViewTextBoxColumn";
            this.dtPayDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtPayDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // bReceivePaidDataGridViewCheckBoxColumn
            // 
            this.bReceivePaidDataGridViewCheckBoxColumn.DataPropertyName = "bReceivePaid";
            this.bReceivePaidDataGridViewCheckBoxColumn.HeaderText = "bReceivePaid";
            this.bReceivePaidDataGridViewCheckBoxColumn.Name = "bReceivePaidDataGridViewCheckBoxColumn";
            this.bReceivePaidDataGridViewCheckBoxColumn.ReadOnly = true;
            this.bReceivePaidDataGridViewCheckBoxColumn.Visible = false;
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
            // idProvidersDataGridViewTextBoxColumn
            // 
            this.idProvidersDataGridViewTextBoxColumn.DataPropertyName = "idProviders";
            this.idProvidersDataGridViewTextBoxColumn.HeaderText = "idProviders";
            this.idProvidersDataGridViewTextBoxColumn.Name = "idProvidersDataGridViewTextBoxColumn";
            this.idProvidersDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProvidersDataGridViewTextBoxColumn.Visible = false;
            // 
            // tbaccountsToPayBindingSource
            // 
            this.tbaccountsToPayBindingSource.DataMember = "tb_accountsToPay";
            this.tbaccountsToPayBindingSource.DataSource = this.fullDataSet;
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
            this.lblValor.TabIndex = 31;
            this.lblValor.Text = "Valor: ";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(242, 85);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(90, 17);
            this.lblData.TabIndex = 30;
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
            this.lblReferenteA.TabIndex = 29;
            this.lblReferenteA.Text = "Referente a: ";
            // 
            // lblSaidas
            // 
            this.lblSaidas.AutoSize = true;
            this.lblSaidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaidas.Location = new System.Drawing.Point(181, 9);
            this.lblSaidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaidas.Name = "lblSaidas";
            this.lblSaidas.Size = new System.Drawing.Size(151, 24);
            this.lblSaidas.TabIndex = 28;
            this.lblSaidas.Text = "Contas a Pagar";
            // 
            // btnBaixar
            // 
            this.btnBaixar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixar.Location = new System.Drawing.Point(201, 430);
            this.btnBaixar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(100, 28);
            this.btnBaixar.TabIndex = 42;
            this.btnBaixar.Text = "Baixar";
            this.btnBaixar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarFornecedor
            // 
            this.btnBuscarFornecedor.Location = new System.Drawing.Point(381, 44);
            this.btnBuscarFornecedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarFornecedor.Name = "btnBuscarFornecedor";
            this.btnBuscarFornecedor.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarFornecedor.TabIndex = 49;
            this.btnBuscarFornecedor.Text = "Buscar";
            this.btnBuscarFornecedor.UseVisualStyleBackColor = true;
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(113, 49);
            this.txtNomeFornecedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeFornecedor.MaxLength = 100;
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(260, 20);
            this.txtNomeFornecedor.TabIndex = 48;
            // 
            // lblNomeFornecedor
            // 
            this.lblNomeFornecedor.AutoSize = true;
            this.lblNomeFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFornecedor.Location = new System.Drawing.Point(13, 50);
            this.lblNomeFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeFornecedor.Name = "lblNomeFornecedor";
            this.lblNomeFornecedor.Size = new System.Drawing.Size(93, 17);
            this.lblNomeFornecedor.TabIndex = 47;
            this.lblNomeFornecedor.Text = "Fornecedor : ";
            // 
            // txtOS
            // 
            this.txtOS.Location = new System.Drawing.Point(112, 82);
            this.txtOS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOS.MaxLength = 100;
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(92, 20);
            this.txtOS.TabIndex = 46;
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOS.Location = new System.Drawing.Point(13, 83);
            this.lblOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(62, 17);
            this.lblOS.TabIndex = 45;
            this.lblOS.Text = "NF/O.S.:";
            // 
            // nudParcelas
            // 
            this.nudParcelas.Location = new System.Drawing.Point(348, 118);
            this.nudParcelas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudParcelas.Name = "nudParcelas";
            this.nudParcelas.Size = new System.Drawing.Size(48, 20);
            this.nudParcelas.TabIndex = 50;
            this.nudParcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcelas.Location = new System.Drawing.Point(242, 118);
            this.lblParcelas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(71, 17);
            this.lblParcelas.TabIndex = 51;
            this.lblParcelas.Text = "Parcelas: ";
            // 
            // tb_accountsToPayTableAdapter
            // 
            this.tb_accountsToPayTableAdapter.ClearBeforeFill = true;
            // 
            // frmAccountsToPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 471);
            this.Controls.Add(this.lblParcelas);
            this.Controls.Add(this.nudParcelas);
            this.Controls.Add(this.btnBuscarFornecedor);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.lblNomeFornecedor);
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
            this.Controls.Add(this.lblSaidas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccountsToPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Pagar";
            this.Load += new System.EventHandler(this.frmAccountsToPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSaidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaccountsToPayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label lblSaidas;
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.Button btnBuscarFornecedor;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.Label lblNomeFornecedor;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.NumericUpDown nudParcelas;
        private System.Windows.Forms.Label lblParcelas;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource tbaccountsToPayBindingSource;
        private FullDataSetTableAdapters.tb_accountsToPayTableAdapter tb_accountsToPayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIdBudgetsOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIdClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPayDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bReceivePaidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iInstallmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iAmountInstallmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sReferentToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProvidersDataGridViewTextBoxColumn;
    }
}