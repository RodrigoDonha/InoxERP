using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWindows.Business.Concrete;

namespace UIWindows
{
    public partial class frmTwoPaymentForms : Form
    {
        ValidationEntries validation = new ValidationEntries();

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

        public void validationEntriesNumerics(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }
    }
}
