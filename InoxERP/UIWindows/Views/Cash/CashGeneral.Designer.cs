namespace UIWindows
{
    partial class frmCashGeneral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashGeneral));
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtReferenteA = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblReferenteA = new System.Windows.Forms.Label();
            this.lblExtratoGeral = new System.Windows.Forms.Label();
            this.lblSaldoFinal = new System.Windows.Forms.Label();
            this.lblExibeSaldoFinal = new System.Windows.Forms.Label();
            this.grdExtratoGeral = new System.Windows.Forms.DataGridView();
            this.fullDataSet = new UIWindows.FullDataSet();
            this.tbcashBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_cashTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_cashTableAdapter();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIdBudgetsOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIdClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sReferentToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sChequeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdExtratoGeral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcashBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(150, 51);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.MaxLength = 18;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(119, 23);
            this.txtValor.TabIndex = 21;
            // 
            // txtReferenteA
            // 
            this.txtReferenteA.Enabled = false;
            this.txtReferenteA.Location = new System.Drawing.Point(150, 80);
            this.txtReferenteA.Margin = new System.Windows.Forms.Padding(4);
            this.txtReferenteA.MaxLength = 100;
            this.txtReferenteA.Name = "txtReferenteA";
            this.txtReferenteA.Size = new System.Drawing.Size(339, 23);
            this.txtReferenteA.TabIndex = 20;
            // 
            // dtpData
            // 
            this.dtpData.Enabled = false;
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(331, 49);
            this.dtpData.Margin = new System.Windows.Forms.Padding(4);
            this.dtpData.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(158, 23);
            this.dtpData.TabIndex = 19;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(51, 53);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(49, 17);
            this.lblValor.TabIndex = 17;
            this.lblValor.Text = "Valor: ";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(277, 53);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(46, 17);
            this.lblData.TabIndex = 16;
            this.lblData.Text = "Data: ";
            // 
            // lblReferenteA
            // 
            this.lblReferenteA.AutoSize = true;
            this.lblReferenteA.Location = new System.Drawing.Point(51, 83);
            this.lblReferenteA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReferenteA.Name = "lblReferenteA";
            this.lblReferenteA.Size = new System.Drawing.Size(91, 17);
            this.lblReferenteA.TabIndex = 15;
            this.lblReferenteA.Text = "Referente a: ";
            // 
            // lblExtratoGeral
            // 
            this.lblExtratoGeral.AutoSize = true;
            this.lblExtratoGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtratoGeral.Location = new System.Drawing.Point(224, 9);
            this.lblExtratoGeral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtratoGeral.Name = "lblExtratoGeral";
            this.lblExtratoGeral.Size = new System.Drawing.Size(131, 24);
            this.lblExtratoGeral.TabIndex = 14;
            this.lblExtratoGeral.Text = "Extrato Geral";
            // 
            // lblSaldoFinal
            // 
            this.lblSaldoFinal.AutoSize = true;
            this.lblSaldoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoFinal.Location = new System.Drawing.Point(224, 379);
            this.lblSaldoFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoFinal.Name = "lblSaldoFinal";
            this.lblSaldoFinal.Size = new System.Drawing.Size(63, 24);
            this.lblSaldoFinal.TabIndex = 22;
            this.lblSaldoFinal.Text = "Saldo:";
            // 
            // lblExibeSaldoFinal
            // 
            this.lblExibeSaldoFinal.AutoSize = true;
            this.lblExibeSaldoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibeSaldoFinal.Location = new System.Drawing.Point(321, 379);
            this.lblExibeSaldoFinal.Name = "lblExibeSaldoFinal";
            this.lblExibeSaldoFinal.Size = new System.Drawing.Size(21, 24);
            this.lblExibeSaldoFinal.TabIndex = 23;
            this.lblExibeSaldoFinal.Text = "0";
            // 
            // grdExtratoGeral
            // 
            this.grdExtratoGeral.AllowUserToAddRows = false;
            this.grdExtratoGeral.AllowUserToDeleteRows = false;
            this.grdExtratoGeral.AllowUserToResizeColumns = false;
            this.grdExtratoGeral.AllowUserToResizeRows = false;
            this.grdExtratoGeral.AutoGenerateColumns = false;
            this.grdExtratoGeral.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grdExtratoGeral.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdExtratoGeral.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExtratoGeral.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdExtratoGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExtratoGeral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.sIdBudgetsOSDataGridViewTextBoxColumn,
            this.sIdClientDataGridViewTextBoxColumn,
            this.dtDateDataGridViewTextBoxColumn,
            this.sReferentToDataGridViewTextBoxColumn,
            this.dValueDataGridViewTextBoxColumn,
            this.dBalanceDataGridViewTextBoxColumn,
            this.cashTypeDataGridViewTextBoxColumn,
            this.sChequeNumberDataGridViewTextBoxColumn});
            this.grdExtratoGeral.DataSource = this.tbcashBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdExtratoGeral.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdExtratoGeral.GridColor = System.Drawing.SystemColors.Window;
            this.grdExtratoGeral.Location = new System.Drawing.Point(13, 111);
            this.grdExtratoGeral.Margin = new System.Windows.Forms.Padding(4);
            this.grdExtratoGeral.MultiSelect = false;
            this.grdExtratoGeral.Name = "grdExtratoGeral";
            this.grdExtratoGeral.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExtratoGeral.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grdExtratoGeral.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdExtratoGeral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdExtratoGeral.Size = new System.Drawing.Size(538, 264);
            this.grdExtratoGeral.TabIndex = 18;
            this.grdExtratoGeral.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdExtratoGeral_CellClick);
            this.grdExtratoGeral.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdExtratoGeral_DataBindingComplete);
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbcashBindingSource
            // 
            this.tbcashBindingSource.DataMember = "tb_cash";
            this.tbcashBindingSource.DataSource = this.fullDataSet;
            // 
            // tb_cashTableAdapter
            // 
            this.tb_cashTableAdapter.ClearBeforeFill = true;
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
            dataGridViewCellStyle2.Format = "d";
            this.dtDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtDateDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dtDateDataGridViewTextBoxColumn.Name = "dtDateDataGridViewTextBoxColumn";
            this.dtDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtDateDataGridViewTextBoxColumn.Width = 63;
            // 
            // sReferentToDataGridViewTextBoxColumn
            // 
            this.sReferentToDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sReferentToDataGridViewTextBoxColumn.DataPropertyName = "sReferentTo";
            this.sReferentToDataGridViewTextBoxColumn.HeaderText = "Referente";
            this.sReferentToDataGridViewTextBoxColumn.Name = "sReferentToDataGridViewTextBoxColumn";
            this.sReferentToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dValueDataGridViewTextBoxColumn
            // 
            this.dValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dValueDataGridViewTextBoxColumn.DataPropertyName = "dValue";
            this.dValueDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.dValueDataGridViewTextBoxColumn.Name = "dValueDataGridViewTextBoxColumn";
            this.dValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.dValueDataGridViewTextBoxColumn.Width = 66;
            // 
            // dBalanceDataGridViewTextBoxColumn
            // 
            this.dBalanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dBalanceDataGridViewTextBoxColumn.DataPropertyName = "dBalance";
            this.dBalanceDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.dBalanceDataGridViewTextBoxColumn.Name = "dBalanceDataGridViewTextBoxColumn";
            this.dBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.dBalanceDataGridViewTextBoxColumn.Width = 69;
            // 
            // cashTypeDataGridViewTextBoxColumn
            // 
            this.cashTypeDataGridViewTextBoxColumn.DataPropertyName = "CashType";
            this.cashTypeDataGridViewTextBoxColumn.HeaderText = "CashType";
            this.cashTypeDataGridViewTextBoxColumn.Name = "cashTypeDataGridViewTextBoxColumn";
            this.cashTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cashTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // sChequeNumberDataGridViewTextBoxColumn
            // 
            this.sChequeNumberDataGridViewTextBoxColumn.DataPropertyName = "sChequeNumber";
            this.sChequeNumberDataGridViewTextBoxColumn.HeaderText = "sChequeNumber";
            this.sChequeNumberDataGridViewTextBoxColumn.Name = "sChequeNumberDataGridViewTextBoxColumn";
            this.sChequeNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.sChequeNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmCashGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 412);
            this.Controls.Add(this.lblExibeSaldoFinal);
            this.Controls.Add(this.lblSaldoFinal);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtReferenteA);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.grdExtratoGeral);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblReferenteA);
            this.Controls.Add(this.lblExtratoGeral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCashGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa Geral";
            this.Load += new System.EventHandler(this.frmCashGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdExtratoGeral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcashBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtReferenteA;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblReferenteA;
        private System.Windows.Forms.Label lblExtratoGeral;
        private System.Windows.Forms.Label lblSaldoFinal;
        private System.Windows.Forms.Label lblExibeSaldoFinal;
        private System.Windows.Forms.DataGridView grdExtratoGeral;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource tbcashBindingSource;
        private FullDataSetTableAdapters.tb_cashTableAdapter tb_cashTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIdBudgetsOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIdClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sReferentToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sChequeNumberDataGridViewTextBoxColumn;
    }
}