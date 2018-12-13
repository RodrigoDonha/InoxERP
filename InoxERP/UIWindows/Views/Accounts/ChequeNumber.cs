using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWindows.Views.Accounts
{
    public partial class frmChequeNumber : Form
    {
        public string chequeNumber { get; set; }
        public frmChequeNumber()
        {
            InitializeComponent();
        }


        public frmChequeNumber(int installment)
        {
            InitializeComponent();
            lblParcela.Text = installment.ToString();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            chequeNumber = txtC1.Text + "-" + txtC2.Text + "-" + txtC3.Text;

            this.Dispose();
        }
    }
}
