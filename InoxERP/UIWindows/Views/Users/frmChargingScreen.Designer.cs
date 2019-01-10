namespace UIWindows.Views.Users
{
    partial class frmChargingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChargingScreen));
            this.prbNet = new System.Windows.Forms.ProgressBar();
            this.prbModules = new System.Windows.Forms.ProgressBar();
            this.prbSystem = new System.Windows.Forms.ProgressBar();
            this.lblNet = new System.Windows.Forms.Label();
            this.lblModules = new System.Windows.Forms.Label();
            this.lblSystem = new System.Windows.Forms.Label();
            this.picSystem = new System.Windows.Forms.PictureBox();
            this.picModules = new System.Windows.Forms.PictureBox();
            this.picNet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNet)).BeginInit();
            this.SuspendLayout();
            // 
            // prbNet
            // 
            this.prbNet.Location = new System.Drawing.Point(16, 105);
            this.prbNet.Margin = new System.Windows.Forms.Padding(4);
            this.prbNet.Name = "prbNet";
            this.prbNet.Size = new System.Drawing.Size(133, 28);
            this.prbNet.TabIndex = 3;
            // 
            // prbModules
            // 
            this.prbModules.Location = new System.Drawing.Point(157, 105);
            this.prbModules.Margin = new System.Windows.Forms.Padding(4);
            this.prbModules.Name = "prbModules";
            this.prbModules.Size = new System.Drawing.Size(133, 28);
            this.prbModules.TabIndex = 4;
            // 
            // prbSystem
            // 
            this.prbSystem.Location = new System.Drawing.Point(298, 105);
            this.prbSystem.Margin = new System.Windows.Forms.Padding(4);
            this.prbSystem.Name = "prbSystem";
            this.prbSystem.Size = new System.Drawing.Size(133, 28);
            this.prbSystem.TabIndex = 5;
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNet.Location = new System.Drawing.Point(12, 149);
            this.lblNet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(139, 15);
            this.lblNet.TabIndex = 6;
            this.lblNet.Text = "Verificando Conexão";
            // 
            // lblModules
            // 
            this.lblModules.AutoSize = true;
            this.lblModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModules.Location = new System.Drawing.Point(158, 149);
            this.lblModules.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModules.Name = "lblModules";
            this.lblModules.Size = new System.Drawing.Size(141, 15);
            this.lblModules.TabIndex = 7;
            this.lblModules.Text = "Carregando Módulos";
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.Location = new System.Drawing.Point(310, 149);
            this.lblSystem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(112, 15);
            this.lblSystem.TabIndex = 8;
            this.lblSystem.Text = "Abrindo Sistema";
            // 
            // picSystem
            // 
            this.picSystem.Image = global::UIWindows.Properties.Resources.system;
            this.picSystem.Location = new System.Drawing.Point(298, 15);
            this.picSystem.Margin = new System.Windows.Forms.Padding(4);
            this.picSystem.Name = "picSystem";
            this.picSystem.Size = new System.Drawing.Size(133, 82);
            this.picSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSystem.TabIndex = 2;
            this.picSystem.TabStop = false;
            // 
            // picModules
            // 
            this.picModules.Image = global::UIWindows.Properties.Resources.modules;
            this.picModules.Location = new System.Drawing.Point(157, 15);
            this.picModules.Margin = new System.Windows.Forms.Padding(4);
            this.picModules.Name = "picModules";
            this.picModules.Size = new System.Drawing.Size(133, 82);
            this.picModules.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picModules.TabIndex = 1;
            this.picModules.TabStop = false;
            // 
            // picNet
            // 
            this.picNet.Image = global::UIWindows.Properties.Resources.net;
            this.picNet.Location = new System.Drawing.Point(16, 15);
            this.picNet.Margin = new System.Windows.Forms.Padding(4);
            this.picNet.Name = "picNet";
            this.picNet.Size = new System.Drawing.Size(133, 82);
            this.picNet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNet.TabIndex = 0;
            this.picNet.TabStop = false;
            // 
            // frmChargingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 185);
            this.Controls.Add(this.lblSystem);
            this.Controls.Add(this.lblModules);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.prbSystem);
            this.Controls.Add(this.prbModules);
            this.Controls.Add(this.prbNet);
            this.Controls.Add(this.picSystem);
            this.Controls.Add(this.picModules);
            this.Controls.Add(this.picNet);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChargingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carregando";
            this.Load += new System.EventHandler(this.frmChargingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNet;
        private System.Windows.Forms.PictureBox picModules;
        private System.Windows.Forms.PictureBox picSystem;
        private System.Windows.Forms.ProgressBar prbNet;
        private System.Windows.Forms.ProgressBar prbModules;
        private System.Windows.Forms.ProgressBar prbSystem;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblModules;
        private System.Windows.Forms.Label lblSystem;
    }
}