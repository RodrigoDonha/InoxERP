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
    public partial class frmAccountsToPay : Form
    {
        ValidationEntries validation = new ValidationEntries();

        public frmAccountsToPay()
        {
            InitializeComponent();
        }

        private void frmAccountsToPay_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void fillGrid()
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_accountsToPay' table. You can move, or remove it, as needed.
            this.tb_accountsToPayTableAdapter.FillByAccountsToPay(this.fullDataSet.tb_accountsToPay);
        }

        private void txtNomeFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorLetters(sender,e);
        }

        private void txtOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorNumbers(sender,e);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender,e);
        }
    }
}
