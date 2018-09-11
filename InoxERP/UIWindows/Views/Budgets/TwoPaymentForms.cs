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
    public partial class frmTwoPaymentForms : Form
    {
        public frmTwoPaymentForms()
        {
            InitializeComponent();
        }

        private void btnConsultarProdutos_Click(object sender, EventArgs e)
        {
            frmProductsRegisterSearch consulta = new frmProductsRegisterSearch();
            this.Hide();
            consulta.Show();
        }

        private void btnConsultarServico_Click(object sender, EventArgs e)
        {
            frmServicesRegisterSearch consulta = new frmServicesRegisterSearch();
            this.Hide();
            consulta.Show();
        }
    }
}
