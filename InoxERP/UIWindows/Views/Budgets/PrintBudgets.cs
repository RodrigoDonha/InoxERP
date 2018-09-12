using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWindows.Views.Budgets
{
    public partial class frmPrintBudgets : Form
    {
        public frmPrintBudgets()
        {
            InitializeComponent();
        }

        private void frmPrintBudgets_Load(object sender, EventArgs e)
        {

            this.rptBudgetPrint.RefreshReport();
        }
    }
}
