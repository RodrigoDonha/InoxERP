﻿namespace UIWindows
{
    partial class frmServicesRegisterSearch
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
            this.Consulta = new System.Windows.Forms.TabPage();
            this.grpConsultarValores = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvConsultaServicos = new System.Windows.Forms.DataGridView();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sObservationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbservicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UIWindows.FullDataSet();
            this.txtConsultaServico = new System.Windows.Forms.TextBox();
            this.lblServico = new System.Windows.Forms.Label();
            this.Cadastro = new System.Windows.Forms.TabPage();
            this.grpConsultaValores = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblMedidas = new System.Windows.Forms.Label();
            this.lblPeca = new System.Windows.Forms.Label();
            this.tbcConsultaValores = new System.Windows.Forms.TabControl();
            this.tb_servicesTableAdapter = new UIWindows.FullDataSetTableAdapters.tb_servicesTableAdapter();
            this.Consulta.SuspendLayout();
            this.grpConsultarValores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbservicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            this.Cadastro.SuspendLayout();
            this.grpConsultaValores.SuspendLayout();
            this.tbcConsultaValores.SuspendLayout();
            this.SuspendLayout();
            // 
            // Consulta
            // 
            this.Consulta.Controls.Add(this.grpConsultarValores);
            this.Consulta.Location = new System.Drawing.Point(4, 25);
            this.Consulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Consulta.Name = "Consulta";
            this.Consulta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Consulta.Size = new System.Drawing.Size(577, 437);
            this.Consulta.TabIndex = 1;
            this.Consulta.Text = "Consulta";
            this.Consulta.UseVisualStyleBackColor = true;
            // 
            // grpConsultarValores
            // 
            this.grpConsultarValores.Controls.Add(this.btnBuscar);
            this.grpConsultarValores.Controls.Add(this.dgvConsultaServicos);
            this.grpConsultarValores.Controls.Add(this.txtConsultaServico);
            this.grpConsultarValores.Controls.Add(this.lblServico);
            this.grpConsultarValores.Location = new System.Drawing.Point(5, 5);
            this.grpConsultarValores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConsultarValores.Name = "grpConsultarValores";
            this.grpConsultarValores.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConsultarValores.Size = new System.Drawing.Size(576, 437);
            this.grpConsultarValores.TabIndex = 1;
            this.grpConsultarValores.TabStop = false;
            this.grpConsultarValores.Text = "Consultar Serviços";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(482, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 32);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvConsultaServicos
            // 
            this.dgvConsultaServicos.AllowUserToAddRows = false;
            this.dgvConsultaServicos.AllowUserToDeleteRows = false;
            this.dgvConsultaServicos.AutoGenerateColumns = false;
            this.dgvConsultaServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.sDescriptionDataGridViewTextBoxColumn,
            this.sTimeDataGridViewTextBoxColumn,
            this.dTotalDataGridViewTextBoxColumn,
            this.sObservationDataGridViewTextBoxColumn,
            this.idItemsDataGridViewTextBoxColumn});
            this.dgvConsultaServicos.DataSource = this.tbservicesBindingSource;
            this.dgvConsultaServicos.Location = new System.Drawing.Point(9, 69);
            this.dgvConsultaServicos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvConsultaServicos.MultiSelect = false;
            this.dgvConsultaServicos.Name = "dgvConsultaServicos";
            this.dgvConsultaServicos.ReadOnly = true;
            this.dgvConsultaServicos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvConsultaServicos.RowTemplate.Height = 24;
            this.dgvConsultaServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaServicos.Size = new System.Drawing.Size(548, 354);
            this.dgvConsultaServicos.TabIndex = 7;
            this.dgvConsultaServicos.TabStop = false;
            this.dgvConsultaServicos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaPecas_CellDoubleClick);
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "sID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "sID";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            this.sIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sDescriptionDataGridViewTextBoxColumn
            // 
            this.sDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sDescriptionDataGridViewTextBoxColumn.DataPropertyName = "sDescription";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sDescriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.sDescriptionDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.sDescriptionDataGridViewTextBoxColumn.Name = "sDescriptionDataGridViewTextBoxColumn";
            this.sDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTimeDataGridViewTextBoxColumn
            // 
            this.sTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sTimeDataGridViewTextBoxColumn.DataPropertyName = "sTime";
            this.sTimeDataGridViewTextBoxColumn.HeaderText = "Tempo";
            this.sTimeDataGridViewTextBoxColumn.Name = "sTimeDataGridViewTextBoxColumn";
            this.sTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTimeDataGridViewTextBoxColumn.Width = 77;
            // 
            // dTotalDataGridViewTextBoxColumn
            // 
            this.dTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dTotalDataGridViewTextBoxColumn.DataPropertyName = "dTotal";
            this.dTotalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.dTotalDataGridViewTextBoxColumn.Name = "dTotalDataGridViewTextBoxColumn";
            this.dTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.dTotalDataGridViewTextBoxColumn.Width = 65;
            // 
            // sObservationDataGridViewTextBoxColumn
            // 
            this.sObservationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sObservationDataGridViewTextBoxColumn.DataPropertyName = "sObservation";
            this.sObservationDataGridViewTextBoxColumn.HeaderText = "Observação";
            this.sObservationDataGridViewTextBoxColumn.Name = "sObservationDataGridViewTextBoxColumn";
            this.sObservationDataGridViewTextBoxColumn.ReadOnly = true;
            this.sObservationDataGridViewTextBoxColumn.Width = 110;
            // 
            // idItemsDataGridViewTextBoxColumn
            // 
            this.idItemsDataGridViewTextBoxColumn.DataPropertyName = "IdItems";
            this.idItemsDataGridViewTextBoxColumn.HeaderText = "IdItems";
            this.idItemsDataGridViewTextBoxColumn.Name = "idItemsDataGridViewTextBoxColumn";
            this.idItemsDataGridViewTextBoxColumn.ReadOnly = true;
            this.idItemsDataGridViewTextBoxColumn.Visible = false;
            // 
            // tbservicesBindingSource
            // 
            this.tbservicesBindingSource.DataMember = "tb_services";
            this.tbservicesBindingSource.DataSource = this.fullDataSet;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtConsultaServico
            // 
            this.txtConsultaServico.Location = new System.Drawing.Point(71, 30);
            this.txtConsultaServico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConsultaServico.Name = "txtConsultaServico";
            this.txtConsultaServico.Size = new System.Drawing.Size(405, 23);
            this.txtConsultaServico.TabIndex = 6;
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(6, 33);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(59, 17);
            this.lblServico.TabIndex = 5;
            this.lblServico.Text = "Serviço:";
            // 
            // Cadastro
            // 
            this.Cadastro.Controls.Add(this.grpConsultaValores);
            this.Cadastro.Location = new System.Drawing.Point(4, 25);
            this.Cadastro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cadastro.Size = new System.Drawing.Size(577, 437);
            this.Cadastro.TabIndex = 0;
            this.Cadastro.Text = "Cadastro";
            this.Cadastro.UseVisualStyleBackColor = true;
            // 
            // grpConsultaValores
            // 
            this.grpConsultaValores.Controls.Add(this.lblID);
            this.grpConsultaValores.Controls.Add(this.btnExcluir);
            this.grpConsultaValores.Controls.Add(this.lblObservacao);
            this.grpConsultaValores.Controls.Add(this.btnAlterar);
            this.grpConsultaValores.Controls.Add(this.txtObservacao);
            this.grpConsultaValores.Controls.Add(this.btnGravar);
            this.grpConsultaValores.Controls.Add(this.txtValorTotal);
            this.grpConsultaValores.Controls.Add(this.txtHoras);
            this.grpConsultaValores.Controls.Add(this.txtServico);
            this.grpConsultaValores.Controls.Add(this.lblValorTotal);
            this.grpConsultaValores.Controls.Add(this.lblMedidas);
            this.grpConsultaValores.Controls.Add(this.lblPeca);
            this.grpConsultaValores.Location = new System.Drawing.Point(5, 6);
            this.grpConsultaValores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConsultaValores.Name = "grpConsultaValores";
            this.grpConsultaValores.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConsultaValores.Size = new System.Drawing.Size(566, 430);
            this.grpConsultaValores.TabIndex = 0;
            this.grpConsultaValores.TabStop = false;
            this.grpConsultaValores.Text = "Cadastro de Serviços";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(8, 254);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 17);
            this.lblID.TabIndex = 10;
            this.lblID.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(435, 330);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(73, 30);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(6, 119);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(89, 17);
            this.lblObservacao.TabIndex = 9;
            this.lblObservacao.Text = "Observação:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(252, 330);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(73, 30);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(8, 138);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(552, 92);
            this.txtObservacao.TabIndex = 7;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(65, 330);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 30);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(435, 68);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(125, 23);
            this.txtValorTotal.TabIndex = 6;
            this.txtValorTotal.TextChanged += new System.EventHandler(this.txtValorTotal_TextChanged);
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(85, 68);
            this.txtHoras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(125, 23);
            this.txtHoras.TabIndex = 5;
            this.txtHoras.TextChanged += new System.EventHandler(this.txtHoras_TextChanged);
            // 
            // txtServico
            // 
            this.txtServico.Location = new System.Drawing.Point(85, 30);
            this.txtServico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(475, 23);
            this.txtServico.TabIndex = 4;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(330, 71);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(81, 17);
            this.lblValorTotal.TabIndex = 3;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // lblMedidas
            // 
            this.lblMedidas.AutoSize = true;
            this.lblMedidas.Location = new System.Drawing.Point(5, 71);
            this.lblMedidas.Name = "lblMedidas";
            this.lblMedidas.Size = new System.Drawing.Size(56, 17);
            this.lblMedidas.TabIndex = 1;
            this.lblMedidas.Text = "Tempo:";
            // 
            // lblPeca
            // 
            this.lblPeca.AutoSize = true;
            this.lblPeca.Location = new System.Drawing.Point(5, 33);
            this.lblPeca.Name = "lblPeca";
            this.lblPeca.Size = new System.Drawing.Size(59, 17);
            this.lblPeca.TabIndex = 0;
            this.lblPeca.Text = "Serviço:";
            // 
            // tbcConsultaValores
            // 
            this.tbcConsultaValores.Controls.Add(this.Consulta);
            this.tbcConsultaValores.Controls.Add(this.Cadastro);
            this.tbcConsultaValores.Location = new System.Drawing.Point(5, 7);
            this.tbcConsultaValores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcConsultaValores.Name = "tbcConsultaValores";
            this.tbcConsultaValores.SelectedIndex = 0;
            this.tbcConsultaValores.Size = new System.Drawing.Size(585, 466);
            this.tbcConsultaValores.TabIndex = 3;
            // 
            // tb_servicesTableAdapter
            // 
            this.tb_servicesTableAdapter.ClearBeforeFill = true;
            // 
            // frmServicesRegisterSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 484);
            this.Controls.Add(this.tbcConsultaValores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmServicesRegisterSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Consulta de Servicos";
            this.Load += new System.EventHandler(this.frmServicesRegisterSearch_Load);
            this.Consulta.ResumeLayout(false);
            this.grpConsultarValores.ResumeLayout(false);
            this.grpConsultarValores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbservicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            this.Cadastro.ResumeLayout(false);
            this.grpConsultaValores.ResumeLayout(false);
            this.grpConsultaValores.PerformLayout();
            this.tbcConsultaValores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Consulta;
        private System.Windows.Forms.GroupBox grpConsultarValores;
        private System.Windows.Forms.DataGridView dgvConsultaServicos;
        private System.Windows.Forms.TextBox txtConsultaServico;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.TabPage Cadastro;
        private System.Windows.Forms.GroupBox grpConsultaValores;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblMedidas;
        private System.Windows.Forms.Label lblPeca;
        private System.Windows.Forms.TabControl tbcConsultaValores;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblID;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource tbservicesBindingSource;
        private FullDataSetTableAdapters.tb_servicesTableAdapter tb_servicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sObservationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItemsDataGridViewTextBoxColumn;
    }
}