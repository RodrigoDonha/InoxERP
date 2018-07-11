namespace InoxERP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orçamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inclusãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entregasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.baixarChequesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saídasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.geralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emAndamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmarPagtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orçamentoToolStripMenuItem,
            this.ordemDeServiçoToolStripMenuItem,
            this.entregasToolStripMenuItem,
            this.caixaToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orçamentoToolStripMenuItem
            // 
            this.orçamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inclusãoToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.orçamentoToolStripMenuItem.Name = "orçamentoToolStripMenuItem";
            this.orçamentoToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.orçamentoToolStripMenuItem.Text = "Orçamentos";
            this.orçamentoToolStripMenuItem.Click += new System.EventHandler(this.orçamentoToolStripMenuItem_Click);
            // 
            // inclusãoToolStripMenuItem
            // 
            this.inclusãoToolStripMenuItem.Name = "inclusãoToolStripMenuItem";
            this.inclusãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inclusãoToolStripMenuItem.Text = "Inclusão";
            this.inclusãoToolStripMenuItem.Click += new System.EventHandler(this.inclusãoToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultaToolStripMenuItem.Text = "consulta";
            // 
            // ordemDeServiçoToolStripMenuItem
            // 
            this.ordemDeServiçoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem1});
            this.ordemDeServiçoToolStripMenuItem.Name = "ordemDeServiçoToolStripMenuItem";
            this.ordemDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.ordemDeServiçoToolStripMenuItem.Text = "Ordens de Serviço";
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.consultaToolStripMenuItem1.Text = "Consulta";
            // 
            // entregasToolStripMenuItem
            // 
            this.entregasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emAndamentoToolStripMenuItem,
            this.finalizadasToolStripMenuItem});
            this.entregasToolStripMenuItem.Name = "entregasToolStripMenuItem";
            this.entregasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.entregasToolStripMenuItem.Text = "Entregas";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasToolStripMenuItem1,
            this.saídasToolStripMenuItem1,
            this.geralToolStripMenuItem});
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // entradasToolStripMenuItem1
            // 
            this.entradasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirToolStripMenuItem2,
            this.baixarChequesToolStripMenuItem1,
            this.consultarToolStripMenuItem1});
            this.entradasToolStripMenuItem1.Name = "entradasToolStripMenuItem1";
            this.entradasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.entradasToolStripMenuItem1.Text = "Entradas";
            // 
            // incluirToolStripMenuItem2
            // 
            this.incluirToolStripMenuItem2.Name = "incluirToolStripMenuItem2";
            this.incluirToolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.incluirToolStripMenuItem2.Text = "Incluir";
            // 
            // baixarChequesToolStripMenuItem1
            // 
            this.baixarChequesToolStripMenuItem1.Name = "baixarChequesToolStripMenuItem1";
            this.baixarChequesToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.baixarChequesToolStripMenuItem1.Text = "Baixar Cheques";
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            // 
            // saídasToolStripMenuItem1
            // 
            this.saídasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirToolStripMenuItem3,
            this.consultarToolStripMenuItem2});
            this.saídasToolStripMenuItem1.Name = "saídasToolStripMenuItem1";
            this.saídasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.saídasToolStripMenuItem1.Text = "Saídas";
            // 
            // incluirToolStripMenuItem3
            // 
            this.incluirToolStripMenuItem3.Name = "incluirToolStripMenuItem3";
            this.incluirToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.incluirToolStripMenuItem3.Text = "Incluir";
            // 
            // consultarToolStripMenuItem2
            // 
            this.consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            this.consultarToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.consultarToolStripMenuItem2.Text = "Consultar";
            // 
            // geralToolStripMenuItem
            // 
            this.geralToolStripMenuItem.Name = "geralToolStripMenuItem";
            this.geralToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.geralToolStripMenuItem.Text = "Geral";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.serviçosToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // emAndamentoToolStripMenuItem
            // 
            this.emAndamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.confirmarPagtoToolStripMenuItem});
            this.emAndamentoToolStripMenuItem.Name = "emAndamentoToolStripMenuItem";
            this.emAndamentoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.emAndamentoToolStripMenuItem.Text = "Em Andamento";
            // 
            // finalizadasToolStripMenuItem
            // 
            this.finalizadasToolStripMenuItem.Name = "finalizadasToolStripMenuItem";
            this.finalizadasToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.finalizadasToolStripMenuItem.Text = "Finalizadas";
            // 
            // confirmarPagtoToolStripMenuItem
            // 
            this.confirmarPagtoToolStripMenuItem.Name = "confirmarPagtoToolStripMenuItem";
            this.confirmarPagtoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.confirmarPagtoToolStripMenuItem.Text = "confirmar pagto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 600);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "InoxERP - Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orçamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inclusãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordemDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entregasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem incluirToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem baixarChequesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saídasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem incluirToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem geralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emAndamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmarPagtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizadasToolStripMenuItem;
    }
}

