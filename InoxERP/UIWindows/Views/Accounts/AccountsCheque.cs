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
    public partial class frmAccountsCheque : Form
    {
        ValidationEntries validation = new ValidationEntries();

        public frmAccountsCheque()
        {
            InitializeComponent();
        }

        private void frmAccountsCheque_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void fillGrid()
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_cheques' table. You can move, or remove it, as needed.
            this.tb_chequesTableAdapter.FillByCheque(this.fullDataSet.tb_cheques);
        }

        private void txtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorLetters(sender,e);
        }

        private void txtOrcamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorNumbers(sender,e);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender,e);
        }

        private void txtNumeroCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorNumbersCheque(sender,e);
        }
    }
}
