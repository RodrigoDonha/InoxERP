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
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtReferenteA = new System.Windows.Forms.TextBox();
            this.lblReferenteA = new System.Windows.Forms.Label();
            this.txtNumeroCheque = new System.Windows.Forms.TextBox();
            this.lblNumeroCheque = new System.Windows.Forms.Label();
            this.nudParcelas = new System.Windows.Forms.NumericUpDown();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtOrcamento = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.grdCheques = new System.Windows.Forms.DataGridView();
            this.tbchequesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UIWindows.FullDataSet();
            this.lblVecto = new System.Windows.Forms.Label();
            this.lblOrcamento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_chequesTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_chequesTableAdapter();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIdBudgetsOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIdClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPayDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bChequePaidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iInstallmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iAmountInstallmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sChequeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sReferentToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCheques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbchequesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Location = new System.Drawing.Point(17, 50);
            this.lblCodCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(55, 16);
            this.lblCodCliente.TabIndex = 40;
            this.lblCodCliente.Text = "Cliente: ";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(104, 48);
            this.txtCodCliente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCodCliente.MaxLength = 100;
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(300, 22);
            this.txtCodCliente.TabIndex = 41;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(411, 46);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(101, 28);
            this.btnBuscarCliente.TabIndex = 42;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // txtReferenteA
            // 
            this.txtReferenteA.Location = new System.Drawing.Point(104, 201);
            this.txtReferenteA.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtReferenteA.MaxLength = 100;
            this.txtReferenteA.Name = "txtReferenteA";
            this.txtReferenteA.Size = new System.Drawing.Size(409, 22);
            this.txtReferenteA.TabIndex = 70;
            // 
            // lblReferenteA
            // 
            this.lblReferenteA.AutoSize = true;
            this.lblReferenteA.Location = new System.Drawing.Point(17, 204);
            this.lblReferenteA.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblReferenteA.Name = "lblReferenteA";
            this.lblReferenteA.Size = new System.Drawing.Size(84, 16);
            this.lblReferenteA.TabIndex = 69;
            this.lblReferenteA.Text = "Referente a: ";
            // 
            // txtNumeroCheque
            // 
            this.txtNumeroCheque.Location = new System.Drawing.Point(104, 161);
            this.txtNumeroCheque.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNumeroCheque.MaxLength = 33;
            this.txtNumeroCheque.Name = "txtNumeroCheque";
            this.txtNumeroCheque.Size = new System.Drawing.Size(409, 22);
            this.txtNumeroCheque.TabIndex = 64;
            // 
            // lblNumeroCheque
            // 
            this.lblNumeroCheque.AutoSize = true;
            this.lblNumeroCheque.Location = new System.Drawing.Point(17, 164);
            this.lblNumeroCheque.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumeroCheque.Name = "lblNumeroCheque";
            this.lblNumeroCheque.Size = new System.Drawing.Size(79, 16);
            this.lblNumeroCheque.TabIndex = 63;
            this.lblNumeroCheque.Text = "Nº Cheque: ";
            // 
            // nudParcelas
            // 
            this.nudParcelas.Location = new System.Drawing.Point(365, 123);
            this.nudParcelas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudParcelas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudParcelas.Name = "nudParcelas";
            this.nudParcelas.Size = new System.Drawing.Size(53, 22);
            this.nudParcelas.TabIndex = 62;
            this.nudParcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Location = new System.Drawing.Point(271, 126);
            this.lblParcelas.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(68, 16);
            this.lblParcelas.TabIndex = 61;
            this.lblParcelas.Text = "Parcelas: ";
            // 
            // btnBaixar
            // 
            this.btnBaixar.Location = new System.Drawing.Point(217, 458);
            this.btnBaixar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(101, 28);
            this.btnBaixar.TabIndex = 60;
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
            this.lblValor.TabIndex = 59;
            this.lblValor.Text = "Valor: ";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(413, 247);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 28);
            this.btnExcluir.TabIndex = 58;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(217, 247);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(101, 28);
            this.btnAlterar.TabIndex = 57;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(17, 247);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(101, 28);
            this.btnIncluir.TabIndex = 56;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(104, 122);
            this.txtValor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtValor.MaxLength = 18;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(132, 22);
            this.txtValor.TabIndex = 55;
            // 
            // txtOrcamento
            // 
            this.txtOrcamento.Location = new System.Drawing.Point(104, 85);
            this.txtOrcamento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtOrcamento.MaxLength = 100;
            this.txtOrcamento.Name = "txtOrcamento";
            this.txtOrcamento.Size = new System.Drawing.Size(132, 22);
            this.txtOrcamento.TabIndex = 54;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(365, 82);
            this.dtpData.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(145, 22);
            this.dtpData.TabIndex = 53;
            // 
            // grdCheques
            // 
            this.grdCheques.AutoGenerateColumns = false;
            this.grdCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCheques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.sIdBudgetsOSDataGridViewTextBoxColumn,
            this.sIdClientDataGridViewTextBoxColumn,
            this.dtDueDateDataGridViewTextBoxColumn,
            this.dValueDataGridViewTextBoxColumn,
            this.dtPayDateDataGridViewTextBoxColumn,
            this.bChequePaidDataGridViewCheckBoxColumn,
            this.iInstallmentDataGridViewTextBoxColumn,
            this.iAmountInstallmentDataGridViewTextBoxColumn,
            this.sChequeNumberDataGridViewTextBoxColumn,
            this.sReferentToDataGridViewTextBoxColumn,
            this.idCashDataGridViewTextBoxColumn});
            this.grdCheques.DataSource = this.tbchequesBindingSource;
            this.grdCheques.Location = new System.Drawing.Point(17, 294);
            this.grdCheques.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grdCheques.Name = "grdCheques";
            this.grdCheques.Size = new System.Drawing.Size(496, 156);
            this.grdCheques.TabIndex = 52;
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
            this.lblVecto.Location = new System.Drawing.Point(271, 86);
            this.lblVecto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVecto.Name = "lblVecto";
            this.lblVecto.Size = new System.Drawing.Size(85, 16);
            this.lblVecto.TabIndex = 51;
            this.lblVecto.Text = "Vencimento: ";
            // 
            // lblOrcamento
            // 
            this.lblOrcamento.AutoSize = true;
            this.lblOrcamento.Location = new System.Drawing.Point(17, 89);
            this.lblOrcamento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOrcamento.Name = "lblOrcamento";
            this.lblOrcamento.Size = new System.Drawing.Size(61, 16);
            this.lblOrcamento.TabIndex = 50;
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
            this.label1.TabIndex = 49;
            this.label1.Text = "Cheques";
            // 
            // tb_chequesTableAdapter
            // 
            this.tb_chequesTableAdapter.ClearBeforeFill = true;
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "sID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "sID";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            this.sIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sIdBudgetsOSDataGridViewTextBoxColumn
            // 
            this.sIdBudgetsOSDataGridViewTextBoxColumn.DataPropertyName = "sId_Budgets_OS";
            this.sIdBudgetsOSDataGridViewTextBoxColumn.HeaderText = "sId_Budgets_OS";
            this.sIdBudgetsOSDataGridViewTextBoxColumn.Name = "sIdBudgetsOSDataGridViewTextBoxColumn";
            this.sIdBudgetsOSDataGridViewTextBoxColumn.Visible = false;
            // 
            // sIdClientDataGridViewTextBoxColumn
            // 
            this.sIdClientDataGridViewTextBoxColumn.DataPropertyName = "sId_Client";
            this.sIdClientDataGridViewTextBoxColumn.HeaderText = "sId_Client";
            this.sIdClientDataGridViewTextBoxColumn.Name = "sIdClientDataGridViewTextBoxColumn";
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
            this.dValueDataGridViewTextBoxColumn.Width = 65;
            // 
            // dtPayDateDataGridViewTextBoxColumn
            // 
            this.dtPayDateDataGridViewTextBoxColumn.DataPropertyName = "dtPayDate";
            this.dtPayDateDataGridViewTextBoxColumn.HeaderText = "dtPayDate";
            this.dtPayDateDataGridViewTextBoxColumn.Name = "dtPayDateDataGridViewTextBoxColumn";
            this.dtPayDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // bChequePaidDataGridViewCheckBoxColumn
            // 
            this.bChequePaidDataGridViewCheckBoxColumn.DataPropertyName = "bChequePaid";
            this.bChequePaidDataGridViewCheckBoxColumn.HeaderText = "bChequePaid";
            this.bChequePaidDataGridViewCheckBoxColumn.Name = "bChequePaidDataGridViewCheckBoxColumn";
            this.bChequePaidDataGridViewCheckBoxColumn.Visible = false;
            // 
            // iInstallmentDataGridViewTextBoxColumn
            // 
            this.iInstallmentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iInstallmentDataGridViewTextBoxColumn.DataPropertyName = "iInstallment";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.iInstallmentDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.iInstallmentDataGridViewTextBoxColumn.HeaderText = "Parcela";
            this.iInstallmentDataGridViewTextBoxColumn.Name = "iInstallmentDataGridViewTextBoxColumn";
            this.iInstallmentDataGridViewTextBoxColumn.Width = 80;
            // 
            // iAmountInstallmentDataGridViewTextBoxColumn
            // 
            this.iAmountInstallmentDataGridViewTextBoxColumn.DataPropertyName = "iAmountInstallment";
            this.iAmountInstallmentDataGridViewTextBoxColumn.HeaderText = "iAmountInstallment";
            this.iAmountInstallmentDataGridViewTextBoxColumn.Name = "iAmountInstallmentDataGridViewTextBoxColumn";
            this.iAmountInstallmentDataGridViewTextBoxColumn.Visible = false;
            // 
            // sChequeNumberDataGridViewTextBoxColumn
            // 
            this.sChequeNumberDataGridViewTextBoxColumn.DataPropertyName = "sChequeNumber";
            this.sChequeNumberDataGridViewTextBoxColumn.HeaderText = "sChequeNumber";
            this.sChequeNumberDataGridViewTextBoxColumn.Name = "sChequeNumberDataGridViewTextBoxColumn";
            this.sChequeNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // sReferentToDataGridViewTextBoxColumn
            // 
            this.sReferentToDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sReferentToDataGridViewTextBoxColumn.DataPropertyName = "sReferentTo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sReferentToDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.sReferentToDataGridViewTextBoxColumn.HeaderText = "Referente";
            this.sReferentToDataGridViewTextBoxColumn.Name = "sReferentToDataGridViewTextBoxColumn";
            // 
            // idCashDataGridViewTextBoxColumn
            // 
            this.idCashDataGridViewTextBoxColumn.DataPropertyName = "idCash";
            this.idCashDataGridViewTextBoxColumn.HeaderText = "idCash";
            this.idCashDataGridViewTextBoxColumn.Name = "idCashDataGridViewTextBoxColumn";
            this.idCashDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmAccountsCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 494);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.lblCodCliente);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.txtReferenteA);
            this.Controls.Add(this.lblReferenteA);
            this.Controls.Add(this.txtNumeroCheque);
            this.Controls.Add(this.lblNumeroCheque);
            this.Controls.Add(this.nudParcelas);
            this.Controls.Add(this.lblParcelas);
            this.Controls.Add(this.btnBaixar);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtOrcamento);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtReferenteA;
        private System.Windows.Forms.Label lblReferenteA;
        private System.Windows.Forms.TextBox txtNumeroCheque;
        private System.Windows.Forms.Label lblNumeroCheque;
        private System.Windows.Forms.NumericUpDown nudParcelas;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtOrcamento;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPayDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bChequePaidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iInstallmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iAmountInstallmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sChequeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sReferentToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCashDataGridViewTextBoxColumn;
    }
}