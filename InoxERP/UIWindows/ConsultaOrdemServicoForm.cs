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
    public partial class ConsultaOrdemServicoForm : Form
    {
        public ConsultaOrdemServicoForm()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OrdemServicoForm os = new OrdemServicoForm();
            os.Show();
        }
    }
}
