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
    public partial class ConsultaFornecedoresForm : Form
    {
        public ConsultaFornecedoresForm()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
            FornecedoresForm obj = new FornecedoresForm();
            obj.Show();
        }
    }
}
