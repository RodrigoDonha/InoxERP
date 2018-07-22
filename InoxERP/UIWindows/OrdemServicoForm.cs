using InoxERP.UI_Windows_Forms;
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
    public partial class OrdemServicoForm : Form
    {
        public OrdemServicoForm()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ClientesForm clientes = new ClientesForm();
            clientes.Show();           
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            SelecaoTelasConsultaForm selecao = new SelecaoTelasConsultaForm();
            selecao.Show();
        }
    }
}
