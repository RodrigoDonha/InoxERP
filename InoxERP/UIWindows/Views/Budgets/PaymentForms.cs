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
using UIWindows.Entities;

namespace UIWindows
{
    public partial class frmPaymentForms : Form
    {
        ValidationEntries validation = new ValidationEntries();

        Budgets_OS budget = new Budgets_OS();

        public frmPaymentForms(Budgets_OS budget)
        {
            this.budget = budget;
            InitializeComponent();
            fillFrm();
        }

        public void validationEntriesNumerics(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }

        private void fillFrm()
        {

        }
    }
}
