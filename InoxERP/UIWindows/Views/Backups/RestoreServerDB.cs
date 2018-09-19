using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace UIWindows
{
    public partial class frmRestoreServerDB : Form
    {
        private string origem = "";

        public frmRestoreServerDB()
        {
            InitializeComponent();
        }

        private void picRestore_Click(object sender, EventArgs e)
        {
            prbCopiando.Value = 0;

            try
            {
                Server dbServer = new Server(new ServerConnection(txtServidor.Text));
                Restore dbRestore = new Restore()
                {
                    Database = txtBanco.Text,
                    Action = RestoreActionType.Database,
                    ReplaceDatabase = true,
                    NoRecovery = false
                };

                origem = @"" + txtOrigem.Text;
                
                if (!Directory.Exists(origem))
                {
                    MessageBox.Show("Caminho de Restauração escolhido não Existe");
                }

                var location = origem + "\\" + txtBanco.Text + ".bak";

                dbRestore.Devices.AddDevice(location, DeviceType.File);
                dbRestore.PercentComplete += DbRestore_PercentComplete;
                dbRestore.SqlRestoreAsync(dbServer);

                MessageBox.Show("Restauração Concluida com Sucesso !!!");
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DbRestore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            prbCopiando.Invoke((MethodInvoker)delegate
            {
                prbCopiando.Value = e.Percent;
                prbCopiando.Update();
            });
        }
    }
}
