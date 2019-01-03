namespace UIWindows
{
    partial class frmPaymentForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentForms));
            this.grpDinheiro = new System.Windows.Forms.GroupBox();
            this.txtPrimParcDin = new System.Windows.Forms.TextBox();
            this.lblPrimParcDin = new System.Windows.Forms.Label();
            this.nudPrazoDin = new System.Windows.Forms.NumericUpDown();
            this.lblPrazoDin = new System.Windows.Forms.Label();
            this.lblValorPorParcelaDin = new System.Windows.Forms.Label();
            this.lblValorParcelaDin = new System.Windows.Forms.Label();
            this.nudParcelasDin = new System.Windows.Forms.NumericUpDown();
            this.lblParcelasDin = new System.Windows.Forms.Label();
            this.txtValorDin = new System.Windows.Forms.TextBox();
            this.lblValorDin = new System.Windows.Forms.Label();
            this.grpCheque = new System.Windows.Forms.GroupBox();
            this.txtPrimParcCheq = new System.Windows.Forms.TextBox();
            this.lblPrimParcCheq = new System.Windows.Forms.Label();
            this.nudPrazoCheq = new System.Windows.Forms.NumericUpDown();
            this.lblPrazoCheq = new System.Windows.Forms.Label();
            this.lblValorPorParcelaCheq = new System.Windows.Forms.Label();
            this.lblValorParcelaCheq = new System.Windows.Forms.Label();
            this.nudParcelasCheq = new System.Windows.Forms.NumericUpDown();
            this.lblParcelasCheq = new System.Windows.Forms.Label();
            this.txtValorCheq = new System.Windows.Forms.TextBox();
            this.lblValorCheq = new System.Windows.Forms.Label();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.lblValorTotalPago = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.grpEntrada = new System.Windows.Forms.GroupBox();
            this.txtEntradaCheq = new System.Windows.Forms.TextBox();
            this.lblEntradaCheq = new System.Windows.Forms.Label();
            this.txtEntradaDin = new System.Windows.Forms.TextBox();
            this.lblEntradaDin = new System.Windows.Forms.Label();
            this.txtPorcentDescAVista = new System.Windows.Forms.TextBox();
            this.radDesconto = new System.Windows.Forms.RadioButton();
            this.radJuros = new System.Windows.Forms.RadioButton();
            this.txtPorcentJuros = new System.Windows.Forms.TextBox();
            this.lblExibeValorOS = new System.Windows.Forms.Label();
            this.lblValorOS = new System.Windows.Forms.Label();
            this.txtValorArredondamento = new System.Windows.Forms.TextBox();
            this.lblArredondamento = new System.Windows.Forms.Label();
            this.chkLimpar = new System.Windows.Forms.CheckBox();
            this.lblValorRestante = new System.Windows.Forms.Label();
            this.lblRestante = new System.Windows.Forms.Label();
            this.grpDinheiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrazoDin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelasDin)).BeginInit();
            this.grpCheque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrazoCheq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelasCheq)).BeginInit();
            this.grpEntrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDinheiro
            // 
            this.grpDinheiro.Controls.Add(this.txtPrimParcDin);
            this.grpDinheiro.Controls.Add(this.lblPrimParcDin);
            this.grpDinheiro.Controls.Add(this.nudPrazoDin);
            this.grpDinheiro.Controls.Add(this.lblPrazoDin);
            this.grpDinheiro.Controls.Add(this.lblValorPorParcelaDin);
            this.grpDinheiro.Controls.Add(this.lblValorParcelaDin);
            this.grpDinheiro.Controls.Add(this.nudParcelasDin);
            this.grpDinheiro.Controls.Add(this.lblParcelasDin);
            this.grpDinheiro.Controls.Add(this.txtValorDin);
            this.grpDinheiro.Controls.Add(this.lblValorDin);
            this.grpDinheiro.Location = new System.Drawing.Point(12, 232);
            this.grpDinheiro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDinheiro.Name = "grpDinheiro";
            this.grpDinheiro.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDinheiro.Size = new System.Drawing.Size(210, 195);
            this.grpDinheiro.TabIndex = 18;
            this.grpDinheiro.TabStop = false;
            this.grpDinheiro.Text = "Pagamento em Dinheiro";
            // 
            // txtPrimParcDin
            // 
            this.txtPrimParcDin.Location = new System.Drawing.Point(82, 132);
            this.txtPrimParcDin.MaxLength = 18;
            this.txtPrimParcDin.Name = "txtPrimParcDin";
            this.txtPrimParcDin.Size = new System.Drawing.Size(100, 23);
            this.txtPrimParcDin.TabIndex = 26;
            this.txtPrimParcDin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimParcDin_KeyPress);
            this.txtPrimParcDin.Leave += new System.EventHandler(this.txtPrimParcDin_Leave);
            // 
            // lblPrimParcDin
            // 
            this.lblPrimParcDin.AutoSize = true;
            this.lblPrimParcDin.Location = new System.Drawing.Point(5, 135);
            this.lblPrimParcDin.Name = "lblPrimParcDin";
            this.lblPrimParcDin.Size = new System.Drawing.Size(77, 17);
            this.lblPrimParcDin.TabIndex = 25;
            this.lblPrimParcDin.Text = "1º Parcela:";
            // 
            // nudPrazoDin
            // 
            this.nudPrazoDin.Location = new System.Drawing.Point(83, 100);
            this.nudPrazoDin.Name = "nudPrazoDin";
            this.nudPrazoDin.Size = new System.Drawing.Size(100, 23);
            this.nudPrazoDin.TabIndex = 24;
            // 
            // lblPrazoDin
            // 
            this.lblPrazoDin.AutoSize = true;
            this.lblPrazoDin.Location = new System.Drawing.Point(6, 102);
            this.lblPrazoDin.Name = "lblPrazoDin";
            this.lblPrazoDin.Size = new System.Drawing.Size(53, 17);
            this.lblPrazoDin.TabIndex = 23;
            this.lblPrazoDin.Text = "Prazo: ";
            // 
            // lblValorPorParcelaDin
            // 
            this.lblValorPorParcelaDin.AutoSize = true;
            this.lblValorPorParcelaDin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPorParcelaDin.Location = new System.Drawing.Point(142, 166);
            this.lblValorPorParcelaDin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorPorParcelaDin.Name = "lblValorPorParcelaDin";
            this.lblValorPorParcelaDin.Size = new System.Drawing.Size(16, 17);
            this.lblValorPorParcelaDin.TabIndex = 28;
            this.lblValorPorParcelaDin.Text = "0";
            // 
            // lblValorParcelaDin
            // 
            this.lblValorParcelaDin.AutoSize = true;
            this.lblValorParcelaDin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorParcelaDin.Location = new System.Drawing.Point(5, 166);
            this.lblValorParcelaDin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorParcelaDin.Name = "lblValorParcelaDin";
            this.lblValorParcelaDin.Size = new System.Drawing.Size(117, 17);
            this.lblValorParcelaDin.TabIndex = 27;
            this.lblValorParcelaDin.Text = "Valor da Parcela:";
            // 
            // nudParcelasDin
            // 
            this.nudParcelasDin.Location = new System.Drawing.Point(83, 66);
            this.nudParcelasDin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudParcelasDin.Name = "nudParcelasDin";
            this.nudParcelasDin.Size = new System.Drawing.Size(100, 23);
            this.nudParcelasDin.TabIndex = 22;
            this.nudParcelasDin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudParcelasDin.ValueChanged += new System.EventHandler(this.nudParcelasDin_ValueChanged);
            this.nudParcelasDin.Leave += new System.EventHandler(this.nudParcelasDin_Leave);
            // 
            // lblParcelasDin
            // 
            this.lblParcelasDin.AutoSize = true;
            this.lblParcelasDin.Location = new System.Drawing.Point(6, 68);
            this.lblParcelasDin.Name = "lblParcelasDin";
            this.lblParcelasDin.Size = new System.Drawing.Size(71, 17);
            this.lblParcelasDin.TabIndex = 21;
            this.lblParcelasDin.Text = "Parcelas: ";
            // 
            // txtValorDin
            // 
            this.txtValorDin.Location = new System.Drawing.Point(83, 33);
            this.txtValorDin.MaxLength = 18;
            this.txtValorDin.Name = "txtValorDin";
            this.txtValorDin.Size = new System.Drawing.Size(100, 23);
            this.txtValorDin.TabIndex = 20;
            this.txtValorDin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorDin_KeyPress);
            this.txtValorDin.Leave += new System.EventHandler(this.txtValorDin_Leave);
            // 
            // lblValorDin
            // 
            this.lblValorDin.AutoSize = true;
            this.lblValorDin.Location = new System.Drawing.Point(6, 36);
            this.lblValorDin.Name = "lblValorDin";
            this.lblValorDin.Size = new System.Drawing.Size(49, 17);
            this.lblValorDin.TabIndex = 19;
            this.lblValorDin.Text = "Valor: ";
            // 
            // grpCheque
            // 
            this.grpCheque.Controls.Add(this.txtPrimParcCheq);
            this.grpCheque.Controls.Add(this.lblPrimParcCheq);
            this.grpCheque.Controls.Add(this.nudPrazoCheq);
            this.grpCheque.Controls.Add(this.lblPrazoCheq);
            this.grpCheque.Controls.Add(this.lblValorPorParcelaCheq);
            this.grpCheque.Controls.Add(this.lblValorParcelaCheq);
            this.grpCheque.Controls.Add(this.nudParcelasCheq);
            this.grpCheque.Controls.Add(this.lblParcelasCheq);
            this.grpCheque.Controls.Add(this.txtValorCheq);
            this.grpCheque.Controls.Add(this.lblValorCheq);
            this.grpCheque.Location = new System.Drawing.Point(237, 232);
            this.grpCheque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCheque.Name = "grpCheque";
            this.grpCheque.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCheque.Size = new System.Drawing.Size(210, 195);
            this.grpCheque.TabIndex = 30;
            this.grpCheque.TabStop = false;
            this.grpCheque.Text = "Pagamento em Cheque";
            // 
            // txtPrimParcCheq
            // 
            this.txtPrimParcCheq.Location = new System.Drawing.Point(83, 132);
            this.txtPrimParcCheq.MaxLength = 18;
            this.txtPrimParcCheq.Name = "txtPrimParcCheq";
            this.txtPrimParcCheq.Size = new System.Drawing.Size(100, 23);
            this.txtPrimParcCheq.TabIndex = 38;
            this.txtPrimParcCheq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimParcCheq_KeyPress);
            this.txtPrimParcCheq.Leave += new System.EventHandler(this.txtPrimParcCheq_Leave);
            // 
            // lblPrimParcCheq
            // 
            this.lblPrimParcCheq.AutoSize = true;
            this.lblPrimParcCheq.Location = new System.Drawing.Point(6, 135);
            this.lblPrimParcCheq.Name = "lblPrimParcCheq";
            this.lblPrimParcCheq.Size = new System.Drawing.Size(77, 17);
            this.lblPrimParcCheq.TabIndex = 37;
            this.lblPrimParcCheq.Text = "1º Parcela:";
            // 
            // nudPrazoCheq
            // 
            this.nudPrazoCheq.Location = new System.Drawing.Point(83, 100);
            this.nudPrazoCheq.Name = "nudPrazoCheq";
            this.nudPrazoCheq.Size = new System.Drawing.Size(100, 23);
            this.nudPrazoCheq.TabIndex = 36;
            // 
            // lblPrazoCheq
            // 
            this.lblPrazoCheq.AutoSize = true;
            this.lblPrazoCheq.Location = new System.Drawing.Point(6, 102);
            this.lblPrazoCheq.Name = "lblPrazoCheq";
            this.lblPrazoCheq.Size = new System.Drawing.Size(53, 17);
            this.lblPrazoCheq.TabIndex = 35;
            this.lblPrazoCheq.Text = "Prazo: ";
            // 
            // lblValorPorParcelaCheq
            // 
            this.lblValorPorParcelaCheq.AutoSize = true;
            this.lblValorPorParcelaCheq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPorParcelaCheq.Location = new System.Drawing.Point(143, 166);
            this.lblValorPorParcelaCheq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorPorParcelaCheq.Name = "lblValorPorParcelaCheq";
            this.lblValorPorParcelaCheq.Size = new System.Drawing.Size(16, 17);
            this.lblValorPorParcelaCheq.TabIndex = 40;
            this.lblValorPorParcelaCheq.Text = "0";
            // 
            // lblValorParcelaCheq
            // 
            this.lblValorParcelaCheq.AutoSize = true;
            this.lblValorParcelaCheq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorParcelaCheq.Location = new System.Drawing.Point(6, 166);
            this.lblValorParcelaCheq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorParcelaCheq.Name = "lblValorParcelaCheq";
            this.lblValorParcelaCheq.Size = new System.Drawing.Size(117, 17);
            this.lblValorParcelaCheq.TabIndex = 39;
            this.lblValorParcelaCheq.Text = "Valor da Parcela:";
            // 
            // nudParcelasCheq
            // 
            this.nudParcelasCheq.Location = new System.Drawing.Point(83, 63);
            this.nudParcelasCheq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudParcelasCheq.Name = "nudParcelasCheq";
            this.nudParcelasCheq.Size = new System.Drawing.Size(100, 23);
            this.nudParcelasCheq.TabIndex = 34;
            this.nudParcelasCheq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudParcelasCheq.ValueChanged += new System.EventHandler(this.nudParcelasCheq_ValueChanged);
            this.nudParcelasCheq.Leave += new System.EventHandler(this.nudParcelasCheq_Leave);
            // 
            // lblParcelasCheq
            // 
            this.lblParcelasCheq.AutoSize = true;
            this.lblParcelasCheq.Location = new System.Drawing.Point(6, 65);
            this.lblParcelasCheq.Name = "lblParcelasCheq";
            this.lblParcelasCheq.Size = new System.Drawing.Size(71, 17);
            this.lblParcelasCheq.TabIndex = 33;
            this.lblParcelasCheq.Text = "Parcelas: ";
            // 
            // txtValorCheq
            // 
            this.txtValorCheq.Location = new System.Drawing.Point(83, 31);
            this.txtValorCheq.MaxLength = 18;
            this.txtValorCheq.Name = "txtValorCheq";
            this.txtValorCheq.Size = new System.Drawing.Size(100, 23);
            this.txtValorCheq.TabIndex = 32;
            this.txtValorCheq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorCheq_KeyPress);
            this.txtValorCheq.Leave += new System.EventHandler(this.txtValorCheq_Leave);
            // 
            // lblValorCheq
            // 
            this.lblValorCheq.AutoSize = true;
            this.lblValorCheq.Location = new System.Drawing.Point(6, 34);
            this.lblValorCheq.Name = "lblValorCheq";
            this.lblValorCheq.Size = new System.Drawing.Size(49, 17);
            this.lblValorCheq.TabIndex = 31;
            this.lblValorCheq.Text = "Valor: ";
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPago.Location = new System.Drawing.Point(90, 450);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(105, 20);
            this.lblTotalPago.TabIndex = 42;
            this.lblTotalPago.Text = "Total Pago: ";
            // 
            // lblValorTotalPago
            // 
            this.lblValorTotalPago.AutoSize = true;
            this.lblValorTotalPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalPago.Location = new System.Drawing.Point(273, 450);
            this.lblValorTotalPago.Name = "lblValorTotalPago";
            this.lblValorTotalPago.Size = new System.Drawing.Size(19, 20);
            this.lblValorTotalPago.TabIndex = 43;
            this.lblValorTotalPago.Text = "0";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(361, 442);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(86, 33);
            this.btnConfirmar.TabIndex = 44;
            this.btnConfirmar.Text = "Aprovar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // grpEntrada
            // 
            this.grpEntrada.Controls.Add(this.txtEntradaCheq);
            this.grpEntrada.Controls.Add(this.lblEntradaCheq);
            this.grpEntrada.Controls.Add(this.txtEntradaDin);
            this.grpEntrada.Controls.Add(this.lblEntradaDin);
            this.grpEntrada.Location = new System.Drawing.Point(12, 121);
            this.grpEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEntrada.Name = "grpEntrada";
            this.grpEntrada.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEntrada.Size = new System.Drawing.Size(435, 74);
            this.grpEntrada.TabIndex = 10;
            this.grpEntrada.TabStop = false;
            this.grpEntrada.Text = "Valor da Entrada";
            // 
            // txtEntradaCheq
            // 
            this.txtEntradaCheq.Location = new System.Drawing.Point(308, 33);
            this.txtEntradaCheq.MaxLength = 18;
            this.txtEntradaCheq.Name = "txtEntradaCheq";
            this.txtEntradaCheq.Size = new System.Drawing.Size(100, 23);
            this.txtEntradaCheq.TabIndex = 14;
            this.txtEntradaCheq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntradaCheq_KeyPress);
            this.txtEntradaCheq.Leave += new System.EventHandler(this.txtEntradaCheq_Leave);
            // 
            // lblEntradaCheq
            // 
            this.lblEntradaCheq.AutoSize = true;
            this.lblEntradaCheq.Location = new System.Drawing.Point(231, 36);
            this.lblEntradaCheq.Name = "lblEntradaCheq";
            this.lblEntradaCheq.Size = new System.Drawing.Size(65, 17);
            this.lblEntradaCheq.TabIndex = 13;
            this.lblEntradaCheq.Text = "Cheque: ";
            // 
            // txtEntradaDin
            // 
            this.txtEntradaDin.Location = new System.Drawing.Point(83, 33);
            this.txtEntradaDin.MaxLength = 18;
            this.txtEntradaDin.Name = "txtEntradaDin";
            this.txtEntradaDin.Size = new System.Drawing.Size(100, 23);
            this.txtEntradaDin.TabIndex = 12;
            this.txtEntradaDin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntradaDin_KeyPress);
            this.txtEntradaDin.Leave += new System.EventHandler(this.txtEntradaDin_Leave);
            // 
            // lblEntradaDin
            // 
            this.lblEntradaDin.AutoSize = true;
            this.lblEntradaDin.Location = new System.Drawing.Point(6, 36);
            this.lblEntradaDin.Name = "lblEntradaDin";
            this.lblEntradaDin.Size = new System.Drawing.Size(65, 17);
            this.lblEntradaDin.TabIndex = 11;
            this.lblEntradaDin.Text = "Dinheiro:";
            // 
            // txtPorcentDescAVista
            // 
            this.txtPorcentDescAVista.Enabled = false;
            this.txtPorcentDescAVista.Location = new System.Drawing.Point(176, 56);
            this.txtPorcentDescAVista.Margin = new System.Windows.Forms.Padding(2);
            this.txtPorcentDescAVista.MaxLength = 18;
            this.txtPorcentDescAVista.Name = "txtPorcentDescAVista";
            this.txtPorcentDescAVista.Size = new System.Drawing.Size(40, 23);
            this.txtPorcentDescAVista.TabIndex = 4;
            this.txtPorcentDescAVista.Text = "0";
            this.txtPorcentDescAVista.TextChanged += new System.EventHandler(this.txtPorcentDescAVista_TextChanged);
            this.txtPorcentDescAVista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentDescAVista_KeyPress);
            // 
            // radDesconto
            // 
            this.radDesconto.AutoSize = true;
            this.radDesconto.Location = new System.Drawing.Point(12, 57);
            this.radDesconto.Name = "radDesconto";
            this.radDesconto.Size = new System.Drawing.Size(159, 21);
            this.radDesconto.TabIndex = 3;
            this.radDesconto.TabStop = true;
            this.radDesconto.Text = "Desconto á Vista (%)";
            this.radDesconto.UseVisualStyleBackColor = true;
            this.radDesconto.CheckedChanged += new System.EventHandler(this.radDesconto_CheckedChanged);
            // 
            // radJuros
            // 
            this.radJuros.AutoSize = true;
            this.radJuros.Location = new System.Drawing.Point(287, 57);
            this.radJuros.Name = "radJuros";
            this.radJuros.Size = new System.Drawing.Size(115, 21);
            this.radJuros.TabIndex = 5;
            this.radJuros.TabStop = true;
            this.radJuros.Text = "Juros a.n. (%)";
            this.radJuros.UseVisualStyleBackColor = true;
            this.radJuros.CheckedChanged += new System.EventHandler(this.radJuros_CheckedChanged);
            // 
            // txtPorcentJuros
            // 
            this.txtPorcentJuros.Enabled = false;
            this.txtPorcentJuros.Location = new System.Drawing.Point(407, 56);
            this.txtPorcentJuros.Margin = new System.Windows.Forms.Padding(2);
            this.txtPorcentJuros.MaxLength = 18;
            this.txtPorcentJuros.Name = "txtPorcentJuros";
            this.txtPorcentJuros.Size = new System.Drawing.Size(40, 23);
            this.txtPorcentJuros.TabIndex = 6;
            this.txtPorcentJuros.Text = "0";
            this.txtPorcentJuros.TextChanged += new System.EventHandler(this.txtPorcentJuros_TextChanged);
            this.txtPorcentJuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentJuros_KeyPress);
            // 
            // lblExibeValorOS
            // 
            this.lblExibeValorOS.AutoSize = true;
            this.lblExibeValorOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibeValorOS.Location = new System.Drawing.Point(273, 20);
            this.lblExibeValorOS.Name = "lblExibeValorOS";
            this.lblExibeValorOS.Size = new System.Drawing.Size(19, 20);
            this.lblExibeValorOS.TabIndex = 2;
            this.lblExibeValorOS.Text = "0";
            // 
            // lblValorOS
            // 
            this.lblValorOS.AutoSize = true;
            this.lblValorOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorOS.Location = new System.Drawing.Point(90, 20);
            this.lblValorOS.Name = "lblValorOS";
            this.lblValorOS.Size = new System.Drawing.Size(126, 20);
            this.lblValorOS.TabIndex = 1;
            this.lblValorOS.Text = "Valor da O.S.: ";
            // 
            // txtValorArredondamento
            // 
            this.txtValorArredondamento.Location = new System.Drawing.Point(287, 89);
            this.txtValorArredondamento.MaxLength = 18;
            this.txtValorArredondamento.Name = "txtValorArredondamento";
            this.txtValorArredondamento.Size = new System.Drawing.Size(68, 23);
            this.txtValorArredondamento.TabIndex = 8;
            this.txtValorArredondamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorArredondamento_KeyPress);
            this.txtValorArredondamento.Leave += new System.EventHandler(this.txtValorArredondamento_Leave);
            // 
            // lblArredondamento
            // 
            this.lblArredondamento.AutoSize = true;
            this.lblArredondamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArredondamento.Location = new System.Drawing.Point(91, 90);
            this.lblArredondamento.Name = "lblArredondamento";
            this.lblArredondamento.Size = new System.Drawing.Size(126, 18);
            this.lblArredondamento.TabIndex = 7;
            this.lblArredondamento.Text = "Arredondamento: ";
            // 
            // chkLimpar
            // 
            this.chkLimpar.AutoSize = true;
            this.chkLimpar.Location = new System.Drawing.Point(377, 19);
            this.chkLimpar.Name = "chkLimpar";
            this.chkLimpar.Size = new System.Drawing.Size(70, 21);
            this.chkLimpar.TabIndex = 45;
            this.chkLimpar.Text = "Limpar";
            this.chkLimpar.UseVisualStyleBackColor = true;
            this.chkLimpar.CheckedChanged += new System.EventHandler(this.chkLimpar_CheckedChanged);
            // 
            // lblValorRestante
            // 
            this.lblValorRestante.AutoSize = true;
            this.lblValorRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorRestante.Location = new System.Drawing.Point(273, 204);
            this.lblValorRestante.Name = "lblValorRestante";
            this.lblValorRestante.Size = new System.Drawing.Size(19, 20);
            this.lblValorRestante.TabIndex = 17;
            this.lblValorRestante.Text = "0";
            // 
            // lblRestante
            // 
            this.lblRestante.AutoSize = true;
            this.lblRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestante.Location = new System.Drawing.Point(90, 204);
            this.lblRestante.Name = "lblRestante";
            this.lblRestante.Size = new System.Drawing.Size(140, 20);
            this.lblRestante.TabIndex = 16;
            this.lblRestante.Text = "Valor Restante: ";
            // 
            // frmPaymentForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 486);
            this.Controls.Add(this.lblValorRestante);
            this.Controls.Add(this.lblRestante);
            this.Controls.Add(this.chkLimpar);
            this.Controls.Add(this.txtValorArredondamento);
            this.Controls.Add(this.lblExibeValorOS);
            this.Controls.Add(this.lblArredondamento);
            this.Controls.Add(this.lblValorOS);
            this.Controls.Add(this.txtPorcentJuros);
            this.Controls.Add(this.radJuros);
            this.Controls.Add(this.radDesconto);
            this.Controls.Add(this.txtPorcentDescAVista);
            this.Controls.Add(this.grpEntrada);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblValorTotalPago);
            this.Controls.Add(this.lblTotalPago);
            this.Controls.Add(this.grpCheque);
            this.Controls.Add(this.grpDinheiro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPaymentForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmação de Pagamento";
            this.grpDinheiro.ResumeLayout(false);
            this.grpDinheiro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrazoDin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelasDin)).EndInit();
            this.grpCheque.ResumeLayout(false);
            this.grpCheque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrazoCheq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelasCheq)).EndInit();
            this.grpEntrada.ResumeLayout(false);
            this.grpEntrada.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDinheiro;
        private System.Windows.Forms.GroupBox grpCheque;
        private System.Windows.Forms.TextBox txtValorDin;
        private System.Windows.Forms.Label lblValorDin;
        private System.Windows.Forms.NumericUpDown nudParcelasCheq;
        private System.Windows.Forms.Label lblParcelasCheq;
        private System.Windows.Forms.TextBox txtValorCheq;
        private System.Windows.Forms.Label lblValorCheq;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.Label lblValorTotalPago;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.NumericUpDown nudParcelasDin;
        private System.Windows.Forms.Label lblParcelasDin;
        private System.Windows.Forms.GroupBox grpEntrada;
        private System.Windows.Forms.TextBox txtEntradaCheq;
        private System.Windows.Forms.Label lblEntradaCheq;
        private System.Windows.Forms.TextBox txtEntradaDin;
        private System.Windows.Forms.Label lblEntradaDin;
        private System.Windows.Forms.Label lblValorPorParcelaDin;
        private System.Windows.Forms.Label lblValorParcelaDin;
        private System.Windows.Forms.TextBox txtPorcentDescAVista;
        private System.Windows.Forms.RadioButton radDesconto;
        private System.Windows.Forms.RadioButton radJuros;
        private System.Windows.Forms.TextBox txtPorcentJuros;
        private System.Windows.Forms.NumericUpDown nudPrazoDin;
        private System.Windows.Forms.Label lblPrazoDin;
        private System.Windows.Forms.NumericUpDown nudPrazoCheq;
        private System.Windows.Forms.Label lblPrazoCheq;
        private System.Windows.Forms.Label lblValorPorParcelaCheq;
        private System.Windows.Forms.Label lblValorParcelaCheq;
        private System.Windows.Forms.Label lblExibeValorOS;
        private System.Windows.Forms.Label lblValorOS;
        private System.Windows.Forms.TextBox txtValorArredondamento;
        private System.Windows.Forms.Label lblArredondamento;
        private System.Windows.Forms.TextBox txtPrimParcDin;
        private System.Windows.Forms.Label lblPrimParcDin;
        private System.Windows.Forms.TextBox txtPrimParcCheq;
        private System.Windows.Forms.Label lblPrimParcCheq;
        private System.Windows.Forms.CheckBox chkLimpar;
        private System.Windows.Forms.Label lblValorRestante;
        private System.Windows.Forms.Label lblRestante;
    }
}