namespace UIWindows.Views.ServicesOrders
{
    partial class EditableContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditableContract));
            this.txtContract = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tipBtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContract
            // 
            this.txtContract.Location = new System.Drawing.Point(12, 30);
            this.txtContract.Multiline = true;
            this.txtContract.Name = "txtContract";
            this.txtContract.Size = new System.Drawing.Size(608, 707);
            this.txtContract.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipBtnSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(632, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tipBtnSave
            // 
            this.tipBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tipBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tipBtnSave.Image")));
            this.tipBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipBtnSave.Name = "tipBtnSave";
            this.tipBtnSave.Size = new System.Drawing.Size(23, 22);
            this.tipBtnSave.Tag = "Salvar";
            this.tipBtnSave.Text = "Salvar";
            // 
            // EditableContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 749);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtContract);
            this.Name = "EditableContract";
            this.Text = "EditableContract";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContract;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tipBtnSave;
    }
}