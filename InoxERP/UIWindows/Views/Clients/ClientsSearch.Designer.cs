namespace UIWindows
{
    partial class frmClientsSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAbrirAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.grpClientes = new System.Windows.Forms.GroupBox();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCpfCnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDistrictDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sComplementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhoneResidencialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhoneCelularOneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhoneCelularTwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOccupationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sObservationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbclientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UIWindows.FullDataSet();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.radCPF_CNPJ = new System.Windows.Forms.RadioButton();
            this.radNome = new System.Windows.Forms.RadioButton();
            this.lblTipo = new System.Windows.Forms.Label();
            this.tb_clientsTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_clientsTableAdapter();
            this.grpClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            this.grpPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(629, 406);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(160, 30);
            this.btnCadastrar.TabIndex = 19;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAbrirAlterar
            // 
            this.btnAbrirAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirAlterar.Location = new System.Drawing.Point(12, 406);
            this.btnAbrirAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbrirAlterar.Name = "btnAbrirAlterar";
            this.btnAbrirAlterar.Size = new System.Drawing.Size(160, 30);
            this.btnAbrirAlterar.TabIndex = 18;
            this.btnAbrirAlterar.Text = "Abrir / Alterar";
            this.btnAbrirAlterar.UseVisualStyleBackColor = true;
            this.btnAbrirAlterar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(359, 403);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 30);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // grpClientes
            // 
            this.grpClientes.Controls.Add(this.grdClientes);
            this.grpClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpClientes.Location = new System.Drawing.Point(12, 95);
            this.grpClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpClientes.Name = "grpClientes";
            this.grpClientes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpClientes.Size = new System.Drawing.Size(776, 290);
            this.grpClientes.TabIndex = 14;
            this.grpClientes.TabStop = false;
            this.grpClientes.Text = "Clientes";
            // 
            // grdClientes
            // 
            this.grdClientes.AllowUserToAddRows = false;
            this.grdClientes.AllowUserToDeleteRows = false;
            this.grdClientes.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.sCpfCnpjDataGridViewTextBoxColumn,
            this.clientTypeDataGridViewTextBoxColumn,
            this.sAdressDataGridViewTextBoxColumn,
            this.iNumberDataGridViewTextBoxColumn,
            this.sDistrictDataGridViewTextBoxColumn,
            this.sComplementDataGridViewTextBoxColumn,
            this.sCityDataGridViewTextBoxColumn,
            this.estateDataGridViewTextBoxColumn,
            this.sCEPDataGridViewTextBoxColumn,
            this.sPhoneResidencialDataGridViewTextBoxColumn,
            this.sPhoneCelularOneDataGridViewTextBoxColumn,
            this.sPhoneCelularTwoDataGridViewTextBoxColumn,
            this.sEmailDataGridViewTextBoxColumn,
            this.sOccupationDataGridViewTextBoxColumn,
            this.sObservationDataGridViewTextBoxColumn});
            this.grdClientes.DataSource = this.tbclientsBindingSource;
            this.grdClientes.Location = new System.Drawing.Point(11, 21);
            this.grdClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.ReadOnly = true;
            this.grdClientes.RowTemplate.Height = 24;
            this.grdClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClientes.Size = new System.Drawing.Size(755, 257);
            this.grdClientes.TabIndex = 0;
            this.grdClientes.Click += new System.EventHandler(this.grdClientes_Click);
            this.grdClientes.DoubleClick += new System.EventHandler(this.grdClientes_DoubleClick);
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "sID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "sID";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            this.sIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sNameDataGridViewTextBoxColumn
            // 
            this.sNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sNameDataGridViewTextBoxColumn.DataPropertyName = "sName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.sNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.sNameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.sNameDataGridViewTextBoxColumn.Name = "sNameDataGridViewTextBoxColumn";
            this.sNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sCpfCnpjDataGridViewTextBoxColumn
            // 
            this.sCpfCnpjDataGridViewTextBoxColumn.DataPropertyName = "sCpfCnpj";
            this.sCpfCnpjDataGridViewTextBoxColumn.HeaderText = "CPF / CNPJ";
            this.sCpfCnpjDataGridViewTextBoxColumn.Name = "sCpfCnpjDataGridViewTextBoxColumn";
            this.sCpfCnpjDataGridViewTextBoxColumn.ReadOnly = true;
            this.sCpfCnpjDataGridViewTextBoxColumn.Visible = false;
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
            // iNumberDataGridViewTextBoxColumn
            // 
            this.iNumberDataGridViewTextBoxColumn.DataPropertyName = "iNumber";
            this.iNumberDataGridViewTextBoxColumn.HeaderText = "iNumber";
            this.iNumberDataGridViewTextBoxColumn.Name = "iNumberDataGridViewTextBoxColumn";
            this.iNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // sDistrictDataGridViewTextBoxColumn
            // 
            this.sDistrictDataGridViewTextBoxColumn.DataPropertyName = "sDistrict";
            this.sDistrictDataGridViewTextBoxColumn.HeaderText = "sDistrict";
            this.sDistrictDataGridViewTextBoxColumn.Name = "sDistrictDataGridViewTextBoxColumn";
            this.sDistrictDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDistrictDataGridViewTextBoxColumn.Visible = false;
            // 
            // sComplementDataGridViewTextBoxColumn
            // 
            this.sComplementDataGridViewTextBoxColumn.DataPropertyName = "sComplement";
            this.sComplementDataGridViewTextBoxColumn.HeaderText = "sComplement";
            this.sComplementDataGridViewTextBoxColumn.Name = "sComplementDataGridViewTextBoxColumn";
            this.sComplementDataGridViewTextBoxColumn.ReadOnly = true;
            this.sComplementDataGridViewTextBoxColumn.Visible = false;
            // 
            // sCityDataGridViewTextBoxColumn
            // 
            this.sCityDataGridViewTextBoxColumn.DataPropertyName = "sCity";
            this.sCityDataGridViewTextBoxColumn.HeaderText = "sCity";
            this.sCityDataGridViewTextBoxColumn.Name = "sCityDataGridViewTextBoxColumn";
            this.sCityDataGridViewTextBoxColumn.ReadOnly = true;
            this.sCityDataGridViewTextBoxColumn.Visible = false;
            // 
            // estateDataGridViewTextBoxColumn
            // 
            this.estateDataGridViewTextBoxColumn.DataPropertyName = "Estate";
            this.estateDataGridViewTextBoxColumn.HeaderText = "Estate";
            this.estateDataGridViewTextBoxColumn.Name = "estateDataGridViewTextBoxColumn";
            this.estateDataGridViewTextBoxColumn.ReadOnly = true;
            this.estateDataGridViewTextBoxColumn.Visible = false;
            // 
            // sCEPDataGridViewTextBoxColumn
            // 
            this.sCEPDataGridViewTextBoxColumn.DataPropertyName = "sCEP";
            this.sCEPDataGridViewTextBoxColumn.HeaderText = "sCEP";
            this.sCEPDataGridViewTextBoxColumn.Name = "sCEPDataGridViewTextBoxColumn";
            this.sCEPDataGridViewTextBoxColumn.ReadOnly = true;
            this.sCEPDataGridViewTextBoxColumn.Visible = false;
            // 
            // sPhoneResidencialDataGridViewTextBoxColumn
            // 
            this.sPhoneResidencialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sPhoneResidencialDataGridViewTextBoxColumn.DataPropertyName = "sPhoneResidencial";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sPhoneResidencialDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.sPhoneResidencialDataGridViewTextBoxColumn.HeaderText = "Tel Res.";
            this.sPhoneResidencialDataGridViewTextBoxColumn.Name = "sPhoneResidencialDataGridViewTextBoxColumn";
            this.sPhoneResidencialDataGridViewTextBoxColumn.ReadOnly = true;
            this.sPhoneResidencialDataGridViewTextBoxColumn.Width = 86;
            // 
            // sPhoneCelularOneDataGridViewTextBoxColumn
            // 
            this.sPhoneCelularOneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sPhoneCelularOneDataGridViewTextBoxColumn.DataPropertyName = "sPhoneCelularOne";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sPhoneCelularOneDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.sPhoneCelularOneDataGridViewTextBoxColumn.HeaderText = "Celular 1";
            this.sPhoneCelularOneDataGridViewTextBoxColumn.Name = "sPhoneCelularOneDataGridViewTextBoxColumn";
            this.sPhoneCelularOneDataGridViewTextBoxColumn.ReadOnly = true;
            this.sPhoneCelularOneDataGridViewTextBoxColumn.Width = 89;
            // 
            // sPhoneCelularTwoDataGridViewTextBoxColumn
            // 
            this.sPhoneCelularTwoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sPhoneCelularTwoDataGridViewTextBoxColumn.DataPropertyName = "sPhoneCelularTwo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sPhoneCelularTwoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.sPhoneCelularTwoDataGridViewTextBoxColumn.HeaderText = "Celular 2";
            this.sPhoneCelularTwoDataGridViewTextBoxColumn.Name = "sPhoneCelularTwoDataGridViewTextBoxColumn";
            this.sPhoneCelularTwoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sPhoneCelularTwoDataGridViewTextBoxColumn.Width = 89;
            // 
            // sEmailDataGridViewTextBoxColumn
            // 
            this.sEmailDataGridViewTextBoxColumn.DataPropertyName = "sEmail";
            this.sEmailDataGridViewTextBoxColumn.HeaderText = "sEmail";
            this.sEmailDataGridViewTextBoxColumn.Name = "sEmailDataGridViewTextBoxColumn";
            this.sEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.sEmailDataGridViewTextBoxColumn.Visible = false;
            // 
            // sOccupationDataGridViewTextBoxColumn
            // 
            this.sOccupationDataGridViewTextBoxColumn.DataPropertyName = "sOccupation";
            this.sOccupationDataGridViewTextBoxColumn.HeaderText = "sOccupation";
            this.sOccupationDataGridViewTextBoxColumn.Name = "sOccupationDataGridViewTextBoxColumn";
            this.sOccupationDataGridViewTextBoxColumn.ReadOnly = true;
            this.sOccupationDataGridViewTextBoxColumn.Visible = false;
            // 
            // sObservationDataGridViewTextBoxColumn
            // 
            this.sObservationDataGridViewTextBoxColumn.DataPropertyName = "sObservation";
            this.sObservationDataGridViewTextBoxColumn.HeaderText = "sObservation";
            this.sObservationDataGridViewTextBoxColumn.Name = "sObservationDataGridViewTextBoxColumn";
            this.sObservationDataGridViewTextBoxColumn.ReadOnly = true;
            this.sObservationDataGridViewTextBoxColumn.Visible = false;
            // 
            // tbclientsBindingSource
            // 
            this.tbclientsBindingSource.DataMember = "tb_clients";
            this.tbclientsBindingSource.DataSource = this.fullDataSet;
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
            this.grpPesquisa.Controls.Add(this.radCPF_CNPJ);
            this.grpPesquisa.Controls.Add(this.radNome);
            this.grpPesquisa.Controls.Add(this.lblTipo);
            this.grpPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPesquisa.Location = new System.Drawing.Point(12, 15);
            this.grpPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPesquisa.Size = new System.Drawing.Size(776, 74);
            this.grpPesquisa.TabIndex = 13;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisa";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(686, 21);
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
            // radCPF_CNPJ
            // 
            this.radCPF_CNPJ.AutoSize = true;
            this.radCPF_CNPJ.Location = new System.Drawing.Point(190, 25);
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
            this.radNome.Location = new System.Drawing.Point(97, 25);
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
            // tb_clientsTableAdapter
            // 
            this.tb_clientsTableAdapter.ClearBeforeFill = true;
            // 
            // frmClientsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 444);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnAbrirAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.grpClientes);
            this.Controls.Add(this.grpPesquisa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmClientsSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Clientes";
            this.Load += new System.EventHandler(this.frmClientsSearch_Load);
            this.grpClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAbrirAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox grpClientes;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton radCPF_CNPJ;
        private System.Windows.Forms.RadioButton radNome;
        private System.Windows.Forms.Label lblTipo;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource tbclientsBindingSource;
        private FullDataSetTableAdapters.tb_clientsTableAdapter tb_clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCpfCnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDistrictDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sComplementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhoneResidencialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhoneCelularOneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhoneCelularTwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOccupationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sObservationDataGridViewTextBoxColumn;
    }
}