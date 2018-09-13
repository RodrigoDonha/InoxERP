using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InoxERP.UI_Windows_Forms;

namespace UIWindows
{
    public partial class frmServiceOrderSearch : Form
    {
        public frmServiceOrderSearch()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            new frmBudgetsRegister(null).Show();
        }

        private void btnGerarContrato_Click(object sender, EventArgs e)
        {
            new frmContract().Show();
        }
    }
}
