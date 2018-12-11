namespace UIWindows
{
    partial class frmContractSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContractSearch));
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.grpContratos = new System.Windows.Forms.GroupBox();
            this.grdContratos = new System.Windows.Forms.DataGridView();
            this.tbcontractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UIWindows.FullDataSet();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.radCPF_CNPJ = new System.Windows.Forms.RadioButton();
            this.radNome = new System.Windows.Forms.RadioButton();
            this.lblTipo = new System.Windows.Forms.Label();
            this.tb_contractsTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_contractsTableAdapter();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtContractDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sClientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sProviderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sProviderCpfCnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sProviderAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sProviderNumberAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sProviderDistrictDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sProviderCepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sProviderCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerEstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sClientCpfCnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sClientAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sClientNumberAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sClientDistrictDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sClientCepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sClientCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTotalValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDeadlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtStartExecutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iWarrantyTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetsOSsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpContratos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcontractsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            this.grpPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(629, 406);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(160, 30);
            this.btnImprimir.TabIndex = 25;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(12, 406);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(160, 30);
            this.btnVisualizar.TabIndex = 24;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(359, 406);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 30);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // grpContratos
            // 
            this.grpContratos.Controls.Add(this.grdContratos);
            this.grpContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContratos.Location = new System.Drawing.Point(12, 95);
            this.grpContratos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpContratos.Name = "grpContratos";
            this.grpContratos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpContratos.Size = new System.Drawing.Size(776, 290);
            this.grpContratos.TabIndex = 21;
            this.grpContratos.TabStop = false;
            this.grpContratos.Text = "Contratos";
            // 
            // grdContratos
            // 
            this.grdContratos.AllowUserToAddRows = false;
            this.grdContratos.AllowUserToDeleteRows = false;
            this.grdContratos.AutoGenerateColumns = false;
            this.grdContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContratos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.dtContractDateDataGridViewTextBoxColumn,
            this.sClientNameDataGridViewTextBoxColumn,
            this.sProviderNameDataGridViewTextBoxColumn,
            this.sProviderCpfCnpjDataGridViewTextBoxColumn,
            this.sProviderAdressDataGridViewTextBoxColumn,
            this.sProviderNumberAdressDataGridViewTextBoxColumn,
            this.sProviderDistrictDataGridViewTextBoxColumn,
            this.sProviderCepDataGridViewTextBoxColumn,
            this.sProviderCityDataGridViewTextBoxColumn,
            this.providerEstateDataGridViewTextBoxColumn,
            this.sClientCpfCnpjDataGridViewTextBoxColumn,
            this.sClientAdressDataGridViewTextBoxColumn,
            this.sClientNumberAdressDataGridViewTextBoxColumn,
            this.sClientDistrictDataGridViewTextBoxColumn,
            this.sClientCepDataGridViewTextBoxColumn,
            this.sClientCityDataGridViewTextBoxColumn,
            this.clientEstateDataGridViewTextBoxColumn,
            this.dTotalValueDataGridViewTextBoxColumn,
            this.iDeadlineDataGridViewTextBoxColumn,
            this.dtStartExecutionDataGridViewTextBoxColumn,
            this.iWarrantyTimeDataGridViewTextBoxColumn,
            this.budgetsOSsIDDataGridViewTextBoxColumn});
            this.grdContratos.DataSource = this.tbcontractsBindingSource;
            this.grdContratos.Location = new System.Drawing.Point(11, 21);
            this.grdContratos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdContratos.Name = "grdContratos";
            this.grdContratos.ReadOnly = true;
            this.grdContratos.RowTemplate.Height = 24;
            this.grdContratos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdContratos.Size = new System.Drawing.Size(755, 257);
            this.grdContratos.TabIndex = 0;
            this.grdContratos.Click += new System.EventHandler(this.grdContratos_Click);
            // 
            // tbcontractsBindingSource
            // 
            this.tbcontractsBindingSource.DataMember = "tb_contracts";
            this.tbcontractsBindingSource.DataSource = this.fullDataSet;
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
            this.grpPesquisa.TabIndex = 20;
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
            this.radCPF_CNPJ.Text = "CPF/CNPJ";
            this.radCPF_CNPJ.UseVisualStyleBackColor = true;
            // 
            // radNome
            // 
            this.radNome.AutoSize = true;
            this.radNome.Checked = true;
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
            // tb_contractsTableAdapter
            // 
            this.tb_contractsTableAdapter.ClearBeforeFill = true;
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "sID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "sID";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            this.sIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtContractDateDataGridViewTextBoxColumn
            // 
            this.dtContractDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dtContractDateDataGridViewTextBoxColumn.DataPropertyName = "dtContractDate";
            this.dtContractDateDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dtContractDateDataGridViewTextBoxColumn.Name = "dtContractDateDataGridViewTextBoxColumn";
            this.dtContractDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtContractDateDataGridViewTextBoxColumn.Width = 63;
            // 
            // sClientNameDataGridViewTextBoxColumn
            // 
            this.sClientNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sClientNameDataGridViewTextBoxColumn.DataPropertyName = "sClientName";
            this.sClientNameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.sClientNameDataGridViewTextBoxColumn.Name = "sClientNameDataGridViewTextBoxColumn";
            this.sClientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sProviderNameDataGridViewTextBoxColumn
            // 
            this.sProviderNameDataGridViewTextBoxColumn.DataPropertyName = "sProviderName";
            this.sProviderNameDataGridViewTextBoxColumn.HeaderText = "sProviderName";
            this.sProviderNameDataGridViewTextBoxColumn.Name = "sProviderNameDataGridViewTextBoxColumn";
            this.sProviderNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sProviderNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // sProviderCpfCnpjDataGridViewTextBoxColumn
            // 
            this.sProviderCpfCnpjDataGridViewTextBoxColumn.DataPropertyName = "sProviderCpfCnpj";
            this.sProviderCpfCnpjDataGridViewTextBoxColumn.HeaderText = "sProviderCpfCnpj";
            this.sProviderCpfCnpjDataGridViewTextBoxColumn.Name = "sProviderCpfCnpjDataGridViewTextBoxColumn";
            this.sProviderCpfCnpjDataGridViewTextBoxColumn.ReadOnly = true;
            this.sProviderCpfCnpjDataGridViewTextBoxColumn.Visible = false;
            // 
            // sProviderAdressDataGridViewTextBoxColumn
            // 
            this.sProviderAdressDataGridViewTextBoxColumn.DataPropertyName = "sProviderAdress";
            this.sProviderAdressDataGridViewTextBoxColumn.HeaderText = "sProviderAdress";
            this.sProviderAdressDataGridViewTextBoxColumn.Name = "sProviderAdressDataGridViewTextBoxColumn";
            this.sProviderAdressDataGridViewTextBoxColumn.ReadOnly = true;
            this.sProviderAdressDataGridViewTextBoxColumn.Visible = false;
            // 
            // sProviderNumberAdressDataGridViewTextBoxColumn
            // 
            this.sProviderNumberAdressDataGridViewTextBoxColumn.DataPropertyName = "sProviderNumberAdress";
            this.sProviderNumberAdressDataGridViewTextBoxColumn.HeaderText = "sProviderNumberAdress";
            this.sProviderNumberAdressDataGridViewTextBoxColumn.Name = "sProviderNumberAdressDataGridViewTextBoxColumn";
            this.sProviderNumberAdressDataGridViewTextBoxColumn.ReadOnly = true;
            this.sProviderNumberAdressDataGridViewTextBoxColumn.Visible = false;
            // 
            // sProviderDistrictDataGridViewTextBoxColumn
            // 
            this.sProviderDistrictDataGridViewTextBoxColumn.DataPropertyName = "sProviderDistrict";
            this.sProviderDistrictDataGridViewTextBoxColumn.HeaderText = "sProviderDistrict";
            this.sProviderDistrictDataGridViewTextBoxColumn.Name = "sProviderDistrictDataGridViewTextBoxColumn";
            this.sProviderDistrictDataGridViewTextBoxColumn.ReadOnly = true;
            this.sProviderDistrictDataGridViewTextBoxColumn.Visible = false;
            // 
            // sProviderCepDataGridViewTextBoxColumn
            // 
            this.sProviderCepDataGridViewTextBoxColumn.DataPropertyName = "sProviderCep";
            this.sProviderCepDataGridViewTextBoxColumn.HeaderText = "sProviderCep";
            this.sProviderCepDataGridViewTextBoxColumn.Name = "sProviderCepDataGridViewTextBoxColumn";
            this.sProviderCepDataGridViewTextBoxColumn.ReadOnly = true;
            this.sProviderCepDataGridViewTextBoxColumn.Visible = false;
            // 
            // sProviderCityDataGridViewTextBoxColumn
            // 
            this.sProviderCityDataGridViewTextBoxColumn.DataPropertyName = "sProviderCity";
            this.sProviderCityDataGridViewTextBoxColumn.HeaderText = "sProviderCity";
            this.sProviderCityDataGridViewTextBoxColumn.Name = "sProviderCityDataGridViewTextBoxColumn";
            this.sProviderCityDataGridViewTextBoxColumn.ReadOnly = true;
            this.sProviderCityDataGridViewTextBoxColumn.Visible = false;
            // 
            // providerEstateDataGridViewTextBoxColumn
            // 
            this.providerEstateDataGridViewTextBoxColumn.DataPropertyName = "ProviderEstate";
            this.providerEstateDataGridViewTextBoxColumn.HeaderText = "ProviderEstate";
            this.providerEstateDataGridViewTextBoxColumn.Name = "providerEstateDataGridViewTextBoxColumn";
            this.providerEstateDataGridViewTextBoxColumn.ReadOnly = true;
            this.providerEstateDataGridViewTextBoxColumn.Visible = false;
            // 
            // sClientCpfCnpjDataGridViewTextBoxColumn
            // 
            this.sClientCpfCnpjDataGridViewTextBoxColumn.DataPropertyName = "sClientCpfCnpj";
            this.sClientCpfCnpjDataGridViewTextBoxColumn.HeaderText = "sClientCpfCnpj";
            this.sClientCpfCnpjDataGridViewTextBoxColumn.Name = "sClientCpfCnpjDataGridViewTextBoxColumn";
            this.sClientCpfCnpjDataGridViewTextBoxColumn.ReadOnly = true;
            this.sClientCpfCnpjDataGridViewTextBoxColumn.Visible = false;
            // 
            // sClientAdressDataGridViewTextBoxColumn
            // 
            this.sClientAdressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sClientAdressDataGridViewTextBoxColumn.DataPropertyName = "sClientAdress";
            this.sClientAdressDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.sClientAdressDataGridViewTextBoxColumn.Name = "sClientAdressDataGridViewTextBoxColumn";
            this.sClientAdressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sClientNumberAdressDataGridViewTextBoxColumn
            // 
            this.sClientNumberAdressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sClientNumberAdressDataGridViewTextBoxColumn.DataPropertyName = "sClientNumberAdress";
            this.sClientNumberAdressDataGridViewTextBoxColumn.HeaderText = "Nº";
            this.sClientNumberAdressDataGridViewTextBoxColumn.Name = "sClientNumberAdressDataGridViewTextBoxColumn";
            this.sClientNumberAdressDataGridViewTextBoxColumn.ReadOnly = true;
            this.sClientNumberAdressDataGridViewTextBoxColumn.Width = 48;
            // 
            // sClientDistrictDataGridViewTextBoxColumn
            // 
            this.sClientDistrictDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sClientDistrictDataGridViewTextBoxColumn.DataPropertyName = "sClientDistrict";
            this.sClientDistrictDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.sClientDistrictDataGridViewTextBoxColumn.Name = "sClientDistrictDataGridViewTextBoxColumn";
            this.sClientDistrictDataGridViewTextBoxColumn.ReadOnly = true;
            this.sClientDistrictDataGridViewTextBoxColumn.Width = 71;
            // 
            // sClientCepDataGridViewTextBoxColumn
            // 
            this.sClientCepDataGridViewTextBoxColumn.DataPropertyName = "sClientCep";
            this.sClientCepDataGridViewTextBoxColumn.HeaderText = "sClientCep";
            this.sClientCepDataGridViewTextBoxColumn.Name = "sClientCepDataGridViewTextBoxColumn";
            this.sClientCepDataGridViewTextBoxColumn.ReadOnly = true;
            this.sClientCepDataGridViewTextBoxColumn.Visible = false;
            // 
            // sClientCityDataGridViewTextBoxColumn
            // 
            this.sClientCityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sClientCityDataGridViewTextBoxColumn.DataPropertyName = "sClientCity";
            this.sClientCityDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.sClientCityDataGridViewTextBoxColumn.Name = "sClientCityDataGridViewTextBoxColumn";
            this.sClientCityDataGridViewTextBoxColumn.ReadOnly = true;
            this.sClientCityDataGridViewTextBoxColumn.Width = 77;
            // 
            // clientEstateDataGridViewTextBoxColumn
            // 
            this.clientEstateDataGridViewTextBoxColumn.DataPropertyName = "ClientEstate";
            this.clientEstateDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.clientEstateDataGridViewTextBoxColumn.Name = "clientEstateDataGridViewTextBoxColumn";
            this.clientEstateDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientEstateDataGridViewTextBoxColumn.Visible = false;
            // 
            // dTotalValueDataGridViewTextBoxColumn
            // 
            this.dTotalValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dTotalValueDataGridViewTextBoxColumn.DataPropertyName = "dTotalValue";
            this.dTotalValueDataGridViewTextBoxColumn.HeaderText = "Total";
            this.dTotalValueDataGridViewTextBoxColumn.Name = "dTotalValueDataGridViewTextBoxColumn";
            this.dTotalValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.dTotalValueDataGridViewTextBoxColumn.Width = 65;
            // 
            // iDeadlineDataGridViewTextBoxColumn
            // 
            this.iDeadlineDataGridViewTextBoxColumn.DataPropertyName = "iDeadline";
            this.iDeadlineDataGridViewTextBoxColumn.HeaderText = "iDeadline";
            this.iDeadlineDataGridViewTextBoxColumn.Name = "iDeadlineDataGridViewTextBoxColumn";
            this.iDeadlineDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDeadlineDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtStartExecutionDataGridViewTextBoxColumn
            // 
            this.dtStartExecutionDataGridViewTextBoxColumn.DataPropertyName = "dtStartExecution";
            this.dtStartExecutionDataGridViewTextBoxColumn.HeaderText = "dtStartExecution";
            this.dtStartExecutionDataGridViewTextBoxColumn.Name = "dtStartExecutionDataGridViewTextBoxColumn";
            this.dtStartExecutionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtStartExecutionDataGridViewTextBoxColumn.Visible = false;
            // 
            // iWarrantyTimeDataGridViewTextBoxColumn
            // 
            this.iWarrantyTimeDataGridViewTextBoxColumn.DataPropertyName = "iWarrantyTime";
            this.iWarrantyTimeDataGridViewTextBoxColumn.HeaderText = "iWarrantyTime";
            this.iWarrantyTimeDataGridViewTextBoxColumn.Name = "iWarrantyTimeDataGridViewTextBoxColumn";
            this.iWarrantyTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.iWarrantyTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // budgetsOSsIDDataGridViewTextBoxColumn
            // 
            this.budgetsOSsIDDataGridViewTextBoxColumn.DataPropertyName = "Budgets_OS_sID";
            this.budgetsOSsIDDataGridViewTextBoxColumn.HeaderText = "Budgets_OS_sID";
            this.budgetsOSsIDDataGridViewTextBoxColumn.Name = "budgetsOSsIDDataGridViewTextBoxColumn";
            this.budgetsOSsIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.budgetsOSsIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmContractSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.grpContratos);
            this.Controls.Add(this.grpPesquisa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmContractSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Contratos";
            this.Load += new System.EventHandler(this.frmContractSearch_Load);
            this.grpContratos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcontractsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox grpContratos;
        private System.Windows.Forms.DataGridView grdContratos;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton radCPF_CNPJ;
        private System.Windows.Forms.RadioButton radNome;
        private System.Windows.Forms.Label lblTipo;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource tbcontractsBindingSource;
        private FullDataSetTableAdapters.tb_contractsTableAdapter tb_contractsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtContractDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sClientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sProviderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sProviderCpfCnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sProviderAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sProviderNumberAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sProviderDistrictDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sProviderCepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sProviderCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerEstateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sClientCpfCnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sClientAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sClientNumberAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sClientDistrictDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sClientCepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sClientCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEstateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTotalValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDeadlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtStartExecutionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iWarrantyTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetsOSsIDDataGridViewTextBoxColumn;
    }
}