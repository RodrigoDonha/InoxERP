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
    public partial class frmAccountsCheque : Form
    {
        public frmAccountsCheque()
        {
            InitializeComponent();
        }

        private void frmAccountsCheque_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_cheques' table. You can move, or remove it, as needed.
            this.tb_chequesTableAdapter.FillByCheque(this.fullDataSet.tb_cheques);
            // TODO: This line of code loads data into the 'fullDataSet.tb_accountsToReceive' table. You can move, or remove it, as needed.
        }
    }
}
