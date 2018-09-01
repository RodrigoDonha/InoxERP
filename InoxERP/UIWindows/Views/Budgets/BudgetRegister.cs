using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWindows;

namespace InoxERP.UI_Windows_Forms
{
    public partial class frmBudgetsRegister : Form
    {
        public frmBudgetsRegister()
        {
            InitializeComponent();
            btnProcurar.Focus();
        }

        private void OrcamentosForm_Load(object sender, EventArgs e)
        {

        }

        private void tbPrevDiasExec_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            frmClientsSearch obj = new frmClientsSearch();
            //this.Hide();
            obj.Show();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            frmSelectViewSearch selecao = new frmSelectViewSearch();
            selecao.Show();
        }

        private void btnPeca_Click(object sender, EventArgs e)
        {
            new frmProductsRegisterSearch().Show();
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            new frmServicesRegisterSearch().Show();
        }
    }
}
