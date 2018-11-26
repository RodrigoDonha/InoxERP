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
    public partial class frmAccountsToReceive : Form
    {
        public frmAccountsToReceive()
        {
            InitializeComponent();
        }

        private void frmAccountsToReceive_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_accountsToReceive' table. You can move, or remove it, as needed.
            this.tb_accountsToReceiveTableAdapter.FillByAccountsToReceive(this.fullDataSet.tb_accountsToReceive);

        }
    }
}
