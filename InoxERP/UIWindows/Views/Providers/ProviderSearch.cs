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

        private void frmProviderSearch_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fullDataSet.tb_providers'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_providersTableAdapter.Fill(this.fullDataSet.tb_providers);

        }
    }
}
