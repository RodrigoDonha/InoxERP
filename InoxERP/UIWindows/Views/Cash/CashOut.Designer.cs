namespace UIWindows
{
    partial class frmCashOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashOut));
            this.lblSaidas = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNomeClieForn = new System.Windows.Forms.TextBox();
            this.lblCliForn = new System.Windows.Forms.Label();
            this.txtNFOS = new System.Windows.Forms.TextBox();
            this.lblNFOS = new System.Windows.Forms.Label();
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
            this.dtDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sReferentToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sChequeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcashBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UIWindows.FullDataSet();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblReferenteA = new System.Windows.Forms.Label();
            this.txtNumCheque = new System.Windows.Forms.TextBox();
            this.lblNumeroCheque = new System.Windows.Forms.Label();
            this.tb_cashTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_cashTableAdapter();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdSaidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcashBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaidas
            // 
            this.lblSaidas.AutoSize = true;
            this.lblSaidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaidas.Location = new System.Drawing.Point(210, 6);
            this.lblSaidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaidas.Name = "lblSaidas";
            this.lblSaidas.Size = new System.Drawing.Size(72, 24);
            this.lblSaidas.TabIndex = 1;
            this.lblSaidas.Text = "Saídas";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(386, 39);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 28);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtNomeClieForn
            // 
            this.txtNomeClieForn.Location = new System.Drawing.Point(272, 42);
            this.txtNomeClieForn.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeClieForn.MaxLength = 100;
            this.txtNomeClieForn.Name = "txtNomeClieForn";
            this.txtNomeClieForn.Size = new System.Drawing.Size(102, 23);
            this.txtNomeClieForn.TabIndex = 5;
            this.txtNomeClieForn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeClieForn_KeyPress);
            // 
            // lblCliForn
            // 
            this.lblCliForn.AutoSize = true;
            this.lblCliForn.Location = new System.Drawing.Point(184, 45);
            this.lblCliForn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliForn.Name = "lblCliForn";
            this.lblCliForn.Size = new System.Drawing.Size(80, 17);
            this.lblCliForn.TabIndex = 4;
            this.lblCliForn.Text = "Clien/Forn: ";
            // 
            // txtNFOS
            // 
            this.txtNFOS.Location = new System.Drawing.Point(103, 42);
            this.txtNFOS.Margin = new System.Windows.Forms.Padding(4);
            this.txtNFOS.MaxLength = 100;
            this.txtNFOS.Name = "txtNFOS";
            this.txtNFOS.Size = new System.Drawing.Size(73, 23);
            this.txtNFOS.TabIndex = 3;
            this.txtNFOS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNFOS_KeyPress);
            // 
            // lblNFOS
            // 
            this.lblNFOS.AutoSize = true;
            this.lblNFOS.Location = new System.Drawing.Point(13, 44);
            this.lblNFOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNFOS.Name = "lblNFOS";
            this.lblNFOS.Size = new System.Drawing.Size(62, 17);
            this.lblNFOS.TabIndex = 2;
            this.lblNFOS.Text = "NF/O.S.:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(384, 190);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 28);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(204, 190);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 28);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(14, 190);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(100, 28);
            this.btnIncluir.TabIndex = 15;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(103, 81);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.MaxLength = 18;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(140, 23);
            this.txtValor.TabIndex = 8;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validationEntriesNumerics);
            // 
            // txtReferenteA
            // 
            this.txtReferenteA.Location = new System.Drawing.Point(103, 155);
            this.txtReferenteA.Margin = new System.Windows.Forms.Padding(4);
            this.txtReferenteA.MaxLength = 100;
            this.txtReferenteA.Name = "txtReferenteA";
            this.txtReferenteA.Size = new System.Drawing.Size(381, 23);
            this.txtReferenteA.TabIndex = 14;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(361, 79);
            this.dtpData.Margin = new System.Windows.Forms.Padding(4);
            this.dtpData.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(123, 23);
            this.dtpData.TabIndex = 10;
            // 
            // grdSaidas
            // 
            this.grdSaidas.AllowUserToAddRows = false;
            this.grdSaidas.AllowUserToDeleteRows = false;
            this.grdSaidas.AutoGenerateColumns = false;
            this.grdSaidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSaidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.sIdBudgetsOSDataGridViewTextBoxColumn,
            this.sIdClientDataGridViewTextBoxColumn,
            this.dtDateDataGridViewTextBoxColumn,
            this.dValueDataGridViewTextBoxColumn,
            this.sReferentToDataGridViewTextBoxColumn,
            this.cashTypeDataGridViewTextBoxColumn,
            this.sChequeNumber});
            this.grdSaidas.DataSource = this.tbcashBindingSource;
            this.grdSaidas.Location = new System.Drawing.Point(13, 227);
            this.grdSaidas.Margin = new System.Windows.Forms.Padding(4);
            this.grdSaidas.MultiSelect = false;
            this.grdSaidas.Name = "grdSaidas";
            this.grdSaidas.ReadOnly = true;
            this.grdSaidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSaidas.Size = new System.Drawing.Size(469, 185);
            this.grdSaidas.TabIndex = 18;
            this.grdSaidas.TabStop = false;
            this.grdSaidas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSaidas_CellClick);
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
            // dtDateDataGridViewTextBoxColumn
            // 
            this.dtDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dtDateDataGridViewTextBoxColumn.DataPropertyName = "dtDate";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtDateDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dtDateDataGridViewTextBoxColumn.Name = "dtDateDataGridViewTextBoxColumn";
            this.dtDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtDateDataGridViewTextBoxColumn.Width = 63;
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
            this.dValueDataGridViewTextBoxColumn.Width = 66;
            // 
            // sReferentToDataGridViewTextBoxColumn
            // 
            this.sReferentToDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sReferentToDataGridViewTextBoxColumn.DataPropertyName = "sReferentTo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sReferentToDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.sReferentToDataGridViewTextBoxColumn.HeaderText = "Referente";
            this.sReferentToDataGridViewTextBoxColumn.Name = "sReferentToDataGridViewTextBoxColumn";
            this.sReferentToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cashTypeDataGridViewTextBoxColumn
            // 
            this.cashTypeDataGridViewTextBoxColumn.DataPropertyName = "CashType";
            this.cashTypeDataGridViewTextBoxColumn.HeaderText = "CashType";
            this.cashTypeDataGridViewTextBoxColumn.Name = "cashTypeDataGridViewTextBoxColumn";
            this.cashTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cashTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // sChequeNumber
            // 
            this.sChequeNumber.DataPropertyName = "sChequeNumber";
            this.sChequeNumber.HeaderText = "sChequeNumber";
            this.sChequeNumber.Name = "sChequeNumber";
            this.sChequeNumber.ReadOnly = true;
            this.sChequeNumber.Visible = false;
            // 
            // tbcashBindingSource
            // 
            this.tbcashBindingSource.DataMember = "tb_cash";
            this.tbcashBindingSource.DataSource = this.fullDataSet;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 84);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(49, 17);
            this.lblValor.TabIndex = 7;
            this.lblValor.Text = "Valor: ";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(294, 84);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(46, 17);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "Data: ";
            // 
            // lblReferenteA
            // 
            this.lblReferenteA.AutoSize = true;
            this.lblReferenteA.Location = new System.Drawing.Point(13, 158);
            this.lblReferenteA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReferenteA.Name = "lblReferenteA";
            this.lblReferenteA.Size = new System.Drawing.Size(91, 17);
            this.lblReferenteA.TabIndex = 13;
            this.lblReferenteA.Text = "Referente a: ";
            // 
            // txtNumCheque
            // 
            this.txtNumCheque.Location = new System.Drawing.Point(103, 120);
            this.txtNumCheque.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumCheque.MaxLength = 33;
            this.txtNumCheque.Name = "txtNumCheque";
            this.txtNumCheque.Size = new System.Drawing.Size(381, 23);
            this.txtNumCheque.TabIndex = 12;
            this.txtNumCheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumCheque_KeyPress);
            // 
            // lblNumeroCheque
            // 
            this.lblNumeroCheque.AutoSize = true;
            this.lblNumeroCheque.Location = new System.Drawing.Point(13, 123);
            this.lblNumeroCheque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroCheque.Name = "lblNumeroCheque";
            this.lblNumeroCheque.Size = new System.Drawing.Size(84, 17);
            this.lblNumeroCheque.TabIndex = 11;
            this.lblNumeroCheque.Text = "Nº Cheque: ";
            // 
            // tb_cashTableAdapter
            // 
            this.tb_cashTableAdapter.ClearBeforeFill = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(13, 9);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 24);
            this.lblId.TabIndex = 19;
            this.lblId.Visible = false;
            // 
            // frmCashOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 425);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtNumCheque);
            this.Controls.Add(this.lblNumeroCheque);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNomeClieForn);
            this.Controls.Add(this.lblCliForn);
            this.Controls.Add(this.txtNFOS);
            this.Controls.Add(this.lblNFOS);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCashOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa Saídas";
            this.Load += new System.EventHandler(this.frmCashOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSaidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcashBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSaidas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNomeClieForn;
        private System.Windows.Forms.Label lblCliForn;
        private System.Windows.Forms.TextBox txtNFOS;
        private System.Windows.Forms.Label lblNFOS;
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
        private System.Windows.Forms.TextBox txtNumCheque;
        private System.Windows.Forms.Label lblNumeroCheque;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource tbcashBindingSource;
        private FullDataSetTableAdapters.tb_cashTableAdapter tb_cashTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIdBudgetsOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIdClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sReferentToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sChequeNumber;
        private System.Windows.Forms.Label lblId;
    }
}