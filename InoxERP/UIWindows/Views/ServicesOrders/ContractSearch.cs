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
    public partial class frmContractSearch : Form
    {
        public frmContractSearch()
        {
            InitializeComponent();
        }

        //overrid FILL DATASET
        public void fillDataSet()
        {
            this.tb_contractsTableAdapter.Fill(this.fullDataSet.tb_contracts);
        }

        private void frmContractSearch_Load(object sender, EventArgs e)
        {
            fillDataSet();
        }
    }
}
