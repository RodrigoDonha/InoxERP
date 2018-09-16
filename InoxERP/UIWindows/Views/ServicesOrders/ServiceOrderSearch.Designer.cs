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
            this.grdOrdemServico = new System.Windows.Forms.DataGridView();
            this.dtDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtStartPrevisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFinalPrevisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbbudgetsos1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inoxErpDBDataSet3ServiceOrdersApprovedGidView = new UIWindows.InoxErpDBDataSet3ServiceOrdersApprovedGidView();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.radData = new System.Windows.Forms.RadioButton();
            this.radCPF_CNPJ = new System.Windows.Forms.RadioButton();
            this.radNome = new System.Windows.Forms.RadioButton();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnGerarContrato = new System.Windows.Forms.Button();
            this.tb_budgets_os1TableAdapter = new UIWindows.InoxErpDBDataSet3ServiceOrdersApprovedGidViewTableAdapters.tb_budgets_os1TableAdapter();
            this.grpOrdemServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdemServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbudgetsos1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inoxErpDBDataSet3ServiceOrdersApprovedGidView)).BeginInit();
            this.grpPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFinlizar
            // 
            this.btnFinlizar.Location = new System.Drawing.Point(454, 406);
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
            this.btnDesaprovar.Location = new System.Drawing.Point(241, 406);
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
            this.grpOrdemServico.Controls.Add(this.grdOrdemServico);
            this.grpOrdemServico.Location = new System.Drawing.Point(12, 95);
            this.grpOrdemServico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOrdemServico.Name = "grpOrdemServico";
            this.grpOrdemServico.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOrdemServico.Size = new System.Drawing.Size(1211, 290);
            this.grpOrdemServico.TabIndex = 7;
            this.grpOrdemServico.TabStop = false;
            this.grpOrdemServico.Text = "Ordens de Serviço";
            // 
            // grdOrdemServico
            // 
            this.grdOrdemServico.AllowUserToAddRows = false;
            this.grdOrdemServico.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.grdOrdemServico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdOrdemServico.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOrdemServico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdOrdemServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrdemServico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtDateDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.sTelephoneDataGridViewTextBoxColumn,
            this.dTotalDataGridViewTextBoxColumn,
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn,
            this.dtStartPrevisionDataGridViewTextBoxColumn,
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn,
            this.dtFinalPrevisionDataGridViewTextBoxColumn,
            this.sIDDataGridViewTextBoxColumn,
            this.iCodDataGridViewTextBoxColumn});
            this.grdOrdemServico.DataSource = this.tbbudgetsos1BindingSource;
            this.grdOrdemServico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOrdemServico.Location = new System.Drawing.Point(3, 18);
            this.grdOrdemServico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdOrdemServico.Name = "grdOrdemServico";
            this.grdOrdemServico.ReadOnly = true;
            this.grdOrdemServico.RowTemplate.Height = 24;
            this.grdOrdemServico.Size = new System.Drawing.Size(1205, 270);
            this.grdOrdemServico.TabIndex = 0;
            this.grdOrdemServico.Click += new System.EventHandler(this.grdOrdemServico_Click);
            // 
            // dtDateDataGridViewTextBoxColumn
            // 
            this.dtDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtDateDataGridViewTextBoxColumn.DataPropertyName = "dtDate";
            this.dtDateDataGridViewTextBoxColumn.FillWeight = 179.47F;
            this.dtDateDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dtDateDataGridViewTextBoxColumn.Name = "dtDateDataGridViewTextBoxColumn";
            this.dtDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sNameDataGridViewTextBoxColumn
            // 
            this.sNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sNameDataGridViewTextBoxColumn.DataPropertyName = "sName";
            this.sNameDataGridViewTextBoxColumn.FillWeight = 360.3499F;
            this.sNameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.sNameDataGridViewTextBoxColumn.Name = "sNameDataGridViewTextBoxColumn";
            this.sNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTelephoneDataGridViewTextBoxColumn
            // 
            this.sTelephoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTelephoneDataGridViewTextBoxColumn.DataPropertyName = "sTelephone";
            this.sTelephoneDataGridViewTextBoxColumn.FillWeight = 180.8954F;
            this.sTelephoneDataGridViewTextBoxColumn.HeaderText = "Contato";
            this.sTelephoneDataGridViewTextBoxColumn.Name = "sTelephoneDataGridViewTextBoxColumn";
            this.sTelephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTotalDataGridViewTextBoxColumn
            // 
            this.dTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dTotalDataGridViewTextBoxColumn.DataPropertyName = "dTotal";
            this.dTotalDataGridViewTextBoxColumn.FillWeight = 179.48F;
            this.dTotalDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.dTotalDataGridViewTextBoxColumn.Name = "dTotalDataGridViewTextBoxColumn";
            this.dTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtDateServiceOrderApprovedDataGridViewTextBoxColumn
            // 
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.DataPropertyName = "dtDateServiceOrderApproved";
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.FillWeight = 179.4644F;
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.HeaderText = "Aprovação Orçamento";
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.Name = "dtDateServiceOrderApprovedDataGridViewTextBoxColumn";
            this.dtDateServiceOrderApprovedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtStartPrevisionDataGridViewTextBoxColumn
            // 
            this.dtStartPrevisionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtStartPrevisionDataGridViewTextBoxColumn.DataPropertyName = "dtStartPrevision";
            this.dtStartPrevisionDataGridViewTextBoxColumn.FillWeight = 180.8738F;
            this.dtStartPrevisionDataGridViewTextBoxColumn.HeaderText = "Inicio da Execução";
            this.dtStartPrevisionDataGridViewTextBoxColumn.Name = "dtStartPrevisionDataGridViewTextBoxColumn";
            this.dtStartPrevisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iPrevisionOfExecuteDataGridViewTextBoxColumn
            // 
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.DataPropertyName = "iPrevisionOfExecute";
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.HeaderText = "Previsão Execução (Dias)";
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.Name = "iPrevisionOfExecuteDataGridViewTextBoxColumn";
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.ReadOnly = true;
            this.iPrevisionOfExecuteDataGridViewTextBoxColumn.Width = 143;
            // 
            // dtFinalPrevisionDataGridViewTextBoxColumn
            // 
            this.dtFinalPrevisionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtFinalPrevisionDataGridViewTextBoxColumn.DataPropertyName = "dtFinalPrevision";
            this.dtFinalPrevisionDataGridViewTextBoxColumn.FillWeight = 179.4662F;
            this.dtFinalPrevisionDataGridViewTextBoxColumn.HeaderText = "Previsão Entrega";
            this.dtFinalPrevisionDataGridViewTextBoxColumn.Name = "dtFinalPrevisionDataGridViewTextBoxColumn";
            this.dtFinalPrevisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "sID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "sID";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            this.sIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIDDataGridViewTextBoxColumn.Visible = false;
            this.sIDDataGridViewTextBoxColumn.Width = 68;
            // 
            // iCodDataGridViewTextBoxColumn
            // 
            this.iCodDataGridViewTextBoxColumn.DataPropertyName = "iCod";
            this.iCodDataGridViewTextBoxColumn.HeaderText = "iCod";
            this.iCodDataGridViewTextBoxColumn.Name = "iCodDataGridViewTextBoxColumn";
            this.iCodDataGridViewTextBoxColumn.ReadOnly = true;
            this.iCodDataGridViewTextBoxColumn.Visible = false;
            this.iCodDataGridViewTextBoxColumn.Width = 47;
            // 
            // tbbudgetsos1BindingSource
            // 
            this.tbbudgetsos1BindingSource.DataMember = "tb_budgets_os1";
            this.tbbudgetsos1BindingSource.DataSource = this.inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource;
            // 
            // inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource
            // 
            this.inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource.DataSource = this.inoxErpDBDataSet3ServiceOrdersApprovedGidView;
            this.inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource.Position = 0;
            // 
            // inoxErpDBDataSet3ServiceOrdersApprovedGidView
            // 
            this.inoxErpDBDataSet3ServiceOrdersApprovedGidView.DataSetName = "InoxErpDBDataSet3ServiceOrdersApprovedGidView";
            this.inoxErpDBDataSet3ServiceOrdersApprovedGidView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnPesquisar.Location = new System.Drawing.Point(1103, 21);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(80, 30);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(759, 25);
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
            this.radData.TabStop = true;
            this.radData.Text = "Data";
            this.radData.UseVisualStyleBackColor = true;
            // 
            // radCPF_CNPJ
            // 
            this.radCPF_CNPJ.AutoSize = true;
            this.radCPF_CNPJ.Location = new System.Drawing.Point(145, 26);
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
            // btnGerarContrato
            // 
            this.btnGerarContrato.Location = new System.Drawing.Point(658, 406);
            this.btnGerarContrato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerarContrato.Name = "btnGerarContrato";
            this.btnGerarContrato.Size = new System.Drawing.Size(120, 30);
            this.btnGerarContrato.TabIndex = 12;
            this.btnGerarContrato.Text = "Gerar Contrato";
            this.btnGerarContrato.UseVisualStyleBackColor = true;
            this.btnGerarContrato.Click += new System.EventHandler(this.btnGerarContrato_Click);
            // 
            // tb_budgets_os1TableAdapter
            // 
            this.tb_budgets_os1TableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdemServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbudgetsos1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inoxErpDBDataSet3ServiceOrdersApprovedGidView)).EndInit();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinlizar;
        private System.Windows.Forms.Button btnDesaprovar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.GroupBox grpOrdemServico;
        private System.Windows.Forms.DataGridView grdOrdemServico;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton radData;
        private System.Windows.Forms.RadioButton radCPF_CNPJ;
        private System.Windows.Forms.RadioButton radNome;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnGerarContrato;
        private System.Windows.Forms.BindingSource inoxErpDBDataSet3ServiceOrdersApprovedGidViewBindingSource;
        private InoxErpDBDataSet3ServiceOrdersApprovedGidView inoxErpDBDataSet3ServiceOrdersApprovedGidView;
        private System.Windows.Forms.BindingSource tbbudgetsos1BindingSource;
        private InoxErpDBDataSet3ServiceOrdersApprovedGidViewTableAdapters.tb_budgets_os1TableAdapter tb_budgets_os1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDateServiceOrderApprovedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtStartPrevisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPrevisionOfExecuteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtFinalPrevisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCodDataGridViewTextBoxColumn;
    }
}