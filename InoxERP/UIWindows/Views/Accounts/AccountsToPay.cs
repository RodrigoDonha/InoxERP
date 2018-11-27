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
    public partial class frmAccountsToPay : Form
    {
        public frmAccountsToPay()
        {
            InitializeComponent();
        }

        private void frmAccountsToPay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_accountsToPay' table. You can move, or remove it, as needed.
            this.tb_accountsToPayTableAdapter.FillByAccountsToPay(this.fullDataSet.tb_accountsToPay);

        }
    }
}
