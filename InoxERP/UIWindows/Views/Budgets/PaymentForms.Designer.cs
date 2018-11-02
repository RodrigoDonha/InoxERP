﻿namespace UIWindows
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
            this.nudPrazoDin = new System.Windows.Forms.NumericUpDown();
            this.lblPrazoDin = new System.Windows.Forms.Label();
            this.lblValorPorParcelaDin = new System.Windows.Forms.Label();
            this.lblValorParcelaDin = new System.Windows.Forms.Label();
            this.nudParcelasDin = new System.Windows.Forms.NumericUpDown();
            this.lblParcelasDin = new System.Windows.Forms.Label();
            this.txtValorDin = new System.Windows.Forms.TextBox();
            this.lblValorDin = new System.Windows.Forms.Label();
            this.grpCheque = new System.Windows.Forms.GroupBox();
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
            this.grpDinheiro.Controls.Add(this.nudPrazoDin);
            this.grpDinheiro.Controls.Add(this.lblPrazoDin);
            this.grpDinheiro.Controls.Add(this.lblValorPorParcelaDin);
            this.grpDinheiro.Controls.Add(this.lblValorParcelaDin);
            this.grpDinheiro.Controls.Add(this.nudParcelasDin);
            this.grpDinheiro.Controls.Add(this.lblParcelasDin);
            this.grpDinheiro.Controls.Add(this.txtValorDin);
            this.grpDinheiro.Controls.Add(this.lblValorDin);
            this.grpDinheiro.Location = new System.Drawing.Point(12, 203);
            this.grpDinheiro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDinheiro.Name = "grpDinheiro";
            this.grpDinheiro.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDinheiro.Size = new System.Drawing.Size(210, 169);
            this.grpDinheiro.TabIndex = 2;
            this.grpDinheiro.TabStop = false;
            this.grpDinheiro.Text = "Pagamento em Dinheiro";
            // 
            // nudPrazoDin
            // 
            this.nudPrazoDin.Location = new System.Drawing.Point(83, 100);
            this.nudPrazoDin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrazoDin.Name = "nudPrazoDin";
            this.nudPrazoDin.Size = new System.Drawing.Size(100, 23);
            this.nudPrazoDin.TabIndex = 16;
            this.nudPrazoDin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPrazoDin
            // 
            this.lblPrazoDin.AutoSize = true;
            this.lblPrazoDin.Location = new System.Drawing.Point(6, 102);
            this.lblPrazoDin.Name = "lblPrazoDin";
            this.lblPrazoDin.Size = new System.Drawing.Size(53, 17);
            this.lblPrazoDin.TabIndex = 15;
            this.lblPrazoDin.Text = "Prazo: ";
            // 
            // lblValorPorParcelaDin
            // 
            this.lblValorPorParcelaDin.AutoSize = true;
            this.lblValorPorParcelaDin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPorParcelaDin.Location = new System.Drawing.Point(143, 135);
            this.lblValorPorParcelaDin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorPorParcelaDin.Name = "lblValorPorParcelaDin";
            this.lblValorPorParcelaDin.Size = new System.Drawing.Size(16, 17);
            this.lblValorPorParcelaDin.TabIndex = 14;
            this.lblValorPorParcelaDin.Text = "0";
            // 
            // lblValorParcelaDin
            // 
            this.lblValorParcelaDin.AutoSize = true;
            this.lblValorParcelaDin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorParcelaDin.Location = new System.Drawing.Point(6, 135);
            this.lblValorParcelaDin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorParcelaDin.Name = "lblValorParcelaDin";
            this.lblValorParcelaDin.Size = new System.Drawing.Size(117, 17);
            this.lblValorParcelaDin.TabIndex = 13;
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
            this.nudParcelasDin.TabIndex = 7;
            this.nudParcelasDin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblParcelasDin
            // 
            this.lblParcelasDin.AutoSize = true;
            this.lblParcelasDin.Location = new System.Drawing.Point(6, 68);
            this.lblParcelasDin.Name = "lblParcelasDin";
            this.lblParcelasDin.Size = new System.Drawing.Size(71, 17);
            this.lblParcelasDin.TabIndex = 6;
            this.lblParcelasDin.Text = "Parcelas: ";
            // 
            // txtValorDin
            // 
            this.txtValorDin.Location = new System.Drawing.Point(83, 33);
            this.txtValorDin.MaxLength = 18;
            this.txtValorDin.Name = "txtValorDin";
            this.txtValorDin.Size = new System.Drawing.Size(100, 23);
            this.txtValorDin.TabIndex = 1;
            this.txtValorDin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validationEntriesNumerics);
            // 
            // lblValorDin
            // 
            this.lblValorDin.AutoSize = true;
            this.lblValorDin.Location = new System.Drawing.Point(6, 36);
            this.lblValorDin.Name = "lblValorDin";
            this.lblValorDin.Size = new System.Drawing.Size(49, 17);
            this.lblValorDin.TabIndex = 0;
            this.lblValorDin.Text = "Valor: ";
            // 
            // grpCheque
            // 
            this.grpCheque.Controls.Add(this.nudPrazoCheq);
            this.grpCheque.Controls.Add(this.lblPrazoCheq);
            this.grpCheque.Controls.Add(this.lblValorPorParcelaCheq);
            this.grpCheque.Controls.Add(this.lblValorParcelaCheq);
            this.grpCheque.Controls.Add(this.nudParcelasCheq);
            this.grpCheque.Controls.Add(this.lblParcelasCheq);
            this.grpCheque.Controls.Add(this.txtValorCheq);
            this.grpCheque.Controls.Add(this.lblValorCheq);
            this.grpCheque.Location = new System.Drawing.Point(237, 203);
            this.grpCheque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCheque.Name = "grpCheque";
            this.grpCheque.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCheque.Size = new System.Drawing.Size(210, 169);
            this.grpCheque.TabIndex = 3;
            this.grpCheque.TabStop = false;
            this.grpCheque.Text = "Pagamento em Cheque";
            // 
            // nudPrazoCheq
            // 
            this.nudPrazoCheq.Location = new System.Drawing.Point(83, 100);
            this.nudPrazoCheq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrazoCheq.Name = "nudPrazoCheq";
            this.nudPrazoCheq.Size = new System.Drawing.Size(100, 23);
            this.nudPrazoCheq.TabIndex = 20;
            this.nudPrazoCheq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPrazoCheq
            // 
            this.lblPrazoCheq.AutoSize = true;
            this.lblPrazoCheq.Location = new System.Drawing.Point(6, 102);
            this.lblPrazoCheq.Name = "lblPrazoCheq";
            this.lblPrazoCheq.Size = new System.Drawing.Size(53, 17);
            this.lblPrazoCheq.TabIndex = 19;
            this.lblPrazoCheq.Text = "Prazo: ";
            // 
            // lblValorPorParcelaCheq
            // 
            this.lblValorPorParcelaCheq.AutoSize = true;
            this.lblValorPorParcelaCheq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPorParcelaCheq.Location = new System.Drawing.Point(143, 135);
            this.lblValorPorParcelaCheq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorPorParcelaCheq.Name = "lblValorPorParcelaCheq";
            this.lblValorPorParcelaCheq.Size = new System.Drawing.Size(16, 17);
            this.lblValorPorParcelaCheq.TabIndex = 18;
            this.lblValorPorParcelaCheq.Text = "0";
            // 
            // lblValorParcelaCheq
            // 
            this.lblValorParcelaCheq.AutoSize = true;
            this.lblValorParcelaCheq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorParcelaCheq.Location = new System.Drawing.Point(6, 135);
            this.lblValorParcelaCheq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorParcelaCheq.Name = "lblValorParcelaCheq";
            this.lblValorParcelaCheq.Size = new System.Drawing.Size(117, 17);
            this.lblValorParcelaCheq.TabIndex = 17;
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
            this.nudParcelasCheq.TabIndex = 5;
            this.nudParcelasCheq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblParcelasCheq
            // 
            this.lblParcelasCheq.AutoSize = true;
            this.lblParcelasCheq.Location = new System.Drawing.Point(6, 65);
            this.lblParcelasCheq.Name = "lblParcelasCheq";
            this.lblParcelasCheq.Size = new System.Drawing.Size(71, 17);
            this.lblParcelasCheq.TabIndex = 4;
            this.lblParcelasCheq.Text = "Parcelas: ";
            // 
            // txtValorCheq
            // 
            this.txtValorCheq.Location = new System.Drawing.Point(83, 31);
            this.txtValorCheq.MaxLength = 18;
            this.txtValorCheq.Name = "txtValorCheq";
            this.txtValorCheq.Size = new System.Drawing.Size(100, 23);
            this.txtValorCheq.TabIndex = 3;
            this.txtValorCheq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validationEntriesNumerics);
            // 
            // lblValorCheq
            // 
            this.lblValorCheq.AutoSize = true;
            this.lblValorCheq.Location = new System.Drawing.Point(6, 34);
            this.lblValorCheq.Name = "lblValorCheq";
            this.lblValorCheq.Size = new System.Drawing.Size(49, 17);
            this.lblValorCheq.TabIndex = 2;
            this.lblValorCheq.Text = "Valor: ";
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPago.Location = new System.Drawing.Point(90, 389);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(105, 20);
            this.lblTotalPago.TabIndex = 5;
            this.lblTotalPago.Text = "Total Pago: ";
            // 
            // lblValorTotalPago
            // 
            this.lblValorTotalPago.AutoSize = true;
            this.lblValorTotalPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalPago.Location = new System.Drawing.Point(283, 389);
            this.lblValorTotalPago.Name = "lblValorTotalPago";
            this.lblValorTotalPago.Size = new System.Drawing.Size(19, 20);
            this.lblValorTotalPago.TabIndex = 6;
            this.lblValorTotalPago.Text = "0";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(361, 381);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(86, 33);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
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
            this.grpEntrada.Size = new System.Drawing.Size(435, 78);
            this.grpEntrada.TabIndex = 1;
            this.grpEntrada.TabStop = false;
            this.grpEntrada.Text = "Valor da Entrada";
            // 
            // txtEntradaCheq
            // 
            this.txtEntradaCheq.Location = new System.Drawing.Point(308, 33);
            this.txtEntradaCheq.MaxLength = 18;
            this.txtEntradaCheq.Name = "txtEntradaCheq";
            this.txtEntradaCheq.Size = new System.Drawing.Size(100, 23);
            this.txtEntradaCheq.TabIndex = 3;
            // 
            // lblEntradaCheq
            // 
            this.lblEntradaCheq.AutoSize = true;
            this.lblEntradaCheq.Location = new System.Drawing.Point(231, 36);
            this.lblEntradaCheq.Name = "lblEntradaCheq";
            this.lblEntradaCheq.Size = new System.Drawing.Size(65, 17);
            this.lblEntradaCheq.TabIndex = 2;
            this.lblEntradaCheq.Text = "Cheque: ";
            // 
            // txtEntradaDin
            // 
            this.txtEntradaDin.Location = new System.Drawing.Point(83, 33);
            this.txtEntradaDin.MaxLength = 18;
            this.txtEntradaDin.Name = "txtEntradaDin";
            this.txtEntradaDin.Size = new System.Drawing.Size(100, 23);
            this.txtEntradaDin.TabIndex = 1;
            // 
            // lblEntradaDin
            // 
            this.lblEntradaDin.AutoSize = true;
            this.lblEntradaDin.Location = new System.Drawing.Point(6, 36);
            this.lblEntradaDin.Name = "lblEntradaDin";
            this.lblEntradaDin.Size = new System.Drawing.Size(65, 17);
            this.lblEntradaDin.TabIndex = 0;
            this.lblEntradaDin.Text = "Dinheiro:";
            // 
            // txtPorcentDescAVista
            // 
            this.txtPorcentDescAVista.Location = new System.Drawing.Point(176, 56);
            this.txtPorcentDescAVista.Margin = new System.Windows.Forms.Padding(2);
            this.txtPorcentDescAVista.MaxLength = 18;
            this.txtPorcentDescAVista.Name = "txtPorcentDescAVista";
            this.txtPorcentDescAVista.Size = new System.Drawing.Size(40, 23);
            this.txtPorcentDescAVista.TabIndex = 22;
            this.txtPorcentDescAVista.Text = "0";
            // 
            // radDesconto
            // 
            this.radDesconto.AutoSize = true;
            this.radDesconto.Location = new System.Drawing.Point(12, 57);
            this.radDesconto.Name = "radDesconto";
            this.radDesconto.Size = new System.Drawing.Size(159, 21);
            this.radDesconto.TabIndex = 23;
            this.radDesconto.TabStop = true;
            this.radDesconto.Text = "Desconto á Vista (%)";
            this.radDesconto.UseVisualStyleBackColor = true;
            // 
            // radJuros
            // 
            this.radJuros.AutoSize = true;
            this.radJuros.Location = new System.Drawing.Point(287, 57);
            this.radJuros.Name = "radJuros";
            this.radJuros.Size = new System.Drawing.Size(115, 21);
            this.radJuros.TabIndex = 24;
            this.radJuros.TabStop = true;
            this.radJuros.Text = "Juros a.n. (%)";
            this.radJuros.UseVisualStyleBackColor = true;
            // 
            // txtPorcentJuros
            // 
            this.txtPorcentJuros.Location = new System.Drawing.Point(407, 56);
            this.txtPorcentJuros.Margin = new System.Windows.Forms.Padding(2);
            this.txtPorcentJuros.MaxLength = 18;
            this.txtPorcentJuros.Name = "txtPorcentJuros";
            this.txtPorcentJuros.Size = new System.Drawing.Size(40, 23);
            this.txtPorcentJuros.TabIndex = 25;
            this.txtPorcentJuros.Text = "0";
            // 
            // lblExibeValorOS
            // 
            this.lblExibeValorOS.AutoSize = true;
            this.lblExibeValorOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibeValorOS.Location = new System.Drawing.Point(283, 20);
            this.lblExibeValorOS.Name = "lblExibeValorOS";
            this.lblExibeValorOS.Size = new System.Drawing.Size(19, 20);
            this.lblExibeValorOS.TabIndex = 27;
            this.lblExibeValorOS.Text = "0";
            // 
            // lblValorOS
            // 
            this.lblValorOS.AutoSize = true;
            this.lblValorOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorOS.Location = new System.Drawing.Point(90, 20);
            this.lblValorOS.Name = "lblValorOS";
            this.lblValorOS.Size = new System.Drawing.Size(126, 20);
            this.lblValorOS.TabIndex = 26;
            this.lblValorOS.Text = "Valor da O.S.: ";
            // 
            // txtValorArredondamento
            // 
            this.txtValorArredondamento.Location = new System.Drawing.Point(287, 89);
            this.txtValorArredondamento.MaxLength = 18;
            this.txtValorArredondamento.Name = "txtValorArredondamento";
            this.txtValorArredondamento.Size = new System.Drawing.Size(68, 23);
            this.txtValorArredondamento.TabIndex = 5;
            // 
            // lblArredondamento
            // 
            this.lblArredondamento.AutoSize = true;
            this.lblArredondamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArredondamento.Location = new System.Drawing.Point(91, 90);
            this.lblArredondamento.Name = "lblArredondamento";
            this.lblArredondamento.Size = new System.Drawing.Size(126, 18);
            this.lblArredondamento.TabIndex = 4;
            this.lblArredondamento.Text = "Arredondamento: ";
            // 
            // frmPaymentForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 425);
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
    }
}