using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using UIWindows.Entities;

namespace UIWindows.Views
{
    public partial class frmBackupServerDB : Form
    {
        private string destino = "";

        public frmBackupServerDB()
        {
            InitializeComponent();
        }

        private void picBackup_Click(object sender, EventArgs e)
        {
            prbCopiando.Value = 0;

            try
            {
                Server dbServer = new Server(new ServerConnection(txtServidor.Text));
                Backup dbBackup = new Backup()
                {
                    Action = BackupActionType.Database, Database = txtBanco.Text
                };

                if (txtDestino.Text == "")
                    destino = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Backup";
                else
                {
                    string data = DateTime.Today.ToShortDateString().Replace("/", "-");
                    destino = @"" + txtDestino.Text + "\\Backup\\" + data;
                }

                if (!Directory.Exists(destino))
                {
                    Directory.CreateDirectory(destino);
                }

                var location = destino + "\\" + txtBanco.Text + ".bak";

                dbBackup.Devices.AddDevice(location,DeviceType.File);
                dbBackup.Initialize = true;
                dbBackup.PercentComplete += DbBackup_PercentComplete;
                dbBackup.SqlBackupAsync(dbServer);

                MessageBox.Show("Backup Concluido com Sucesso !!!");
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            prbCopiando.Invoke((MethodInvoker) delegate
            {
                prbCopiando.Value = e.Percent;
                prbCopiando.Update();
            });
        }
    }
}
