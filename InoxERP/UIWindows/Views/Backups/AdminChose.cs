using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWindows.Views.Backups
{
    public partial class frmAdminChose : Form
    {
        public frmAdminChose()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            Dispose();
            new frmBackupServerDB().Show();
        }

        private void btnRestauracao_Click(object sender, EventArgs e)
        {
            Dispose();
            new frmRestoreServerDB().Show();
        }
    }
}
