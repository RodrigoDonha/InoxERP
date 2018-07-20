using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InoxERP.UI_Windows_Forms;
using UIWindows;

namespace InoxERP
{
    public partial class PrincipalForm : Form
    {

        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void orçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inclusãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrcamentosForm obj = new OrcamentosForm();
            //this.Hide();
            obj.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesForm obj = new ClientesForm();
            //this.Hide();
            obj.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FornecedoresForm obj = new FornecedoresForm();
            //this.Hide();
            obj.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaValoresForm obj = new ConsultaValoresForm();
            //this.Hide();
            obj.Show();
        }
        
        private void geralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaixaGeralForm obj = new CaixaGeralForm();
            //this.Hide();
            obj.Show();
        }
        
        private void entradasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CaixaEntradasForm obj = new CaixaEntradasForm();
            //this.Hide();
            obj.Show();
        }

        private void saídasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CaixaSaidasForm obj = new CaixaSaidasForm();
            //this.Hide();
            obj.Show();
        }

        private void chequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaixaChequesForm obj = new CaixaChequesForm();
            //this.Hide();
            obj.Show();
        }
    }
}
