using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWindows
{
    public partial class SelecaoTelasConsultaForm : Form
    {
        public SelecaoTelasConsultaForm()
        {
            InitializeComponent();
        }

        private void btnConsultarProdutos_Click(object sender, EventArgs e)
        {
            ConsultaProdutosForm consulta = new ConsultaProdutosForm();
            this.Hide();
            consulta.Show();
        }

        private void btnConsultarServico_Click(object sender, EventArgs e)
        {
            ConsultaServicosForm consulta = new ConsultaServicosForm();
            this.Hide();
            consulta.Show();
        }
    }
}
