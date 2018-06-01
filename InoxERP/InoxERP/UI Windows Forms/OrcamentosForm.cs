using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InoxERP.UI_Windows_Forms
{
    public partial class OrcamentosForm : Form
    {
        public OrcamentosForm()
        {
            InitializeComponent();
            btCliente.Focus();
        }

        private void OrcamentosForm_Load(object sender, EventArgs e)
        {

        }

        private void tbPrevDiasExec_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            ClientesForm obj = new ClientesForm();
            //this.Hide();
            obj.Show();
        }
    }
}
