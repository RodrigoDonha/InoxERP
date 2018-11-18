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
    public partial class frmCashEntry : Form
    {
        ValidationEntries validation = new ValidationEntries();

        public frmCashEntry()
        {
            InitializeComponent();
        }

        public void validationEntriesNumerics(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }

        private void frmCashEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_cash' table. You can move, or remove it, as needed.
            this.tb_cashTableAdapter.FillByCashEntry(this.fullDataSet.tb_cash);

        }
    }
}
