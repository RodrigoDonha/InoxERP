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
    public partial class frmProviderSearch : Form
    {
        public frmProviderSearch()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
            frmProviderRegister obj = new frmProviderRegister();
            obj.Show();
        }
    }
}
