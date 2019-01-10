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

        public frmBackupServerDB(string server, string DB, string destiny)
        {
            InitializeComponent();
            BackupDB(server,DB,destiny);
        }

        private void picBackup_Click(object sender, EventArgs e)
        {
            prbCopiando.Value = 0;

            try
            {
                BackupDB();

                MessageBox.Show("Backup de Dados Concluído com Sucesso !!!");
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackupDB()
        {
            Server dbServer = new Server(new ServerConnection(txtServidor.Text));
            Backup dbBackup = new Backup()
            {
                Action = BackupActionType.Database,
                Database = txtBanco.Text
            };

            if (txtDestino.Text == "")
                destino = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Backup\\InoxErpDB\\" + returnDate();
            else
                destino = @"" + txtDestino.Text + "\\Backup\\InoxErpDB\\" + returnDate();

            if (!Directory.Exists(destino))
            {
                Directory.CreateDirectory(destino);
            }

            var location = destino + "\\" + txtBanco.Text + ".bak";

            dbBackup.Devices.AddDevice(location, DeviceType.File);
            dbBackup.Initialize = true;
            dbBackup.PercentComplete += DbBackup_PercentComplete;
            dbBackup.SqlBackupAsync(dbServer);
        }

        private void BackupDB(string server, string DB, string destiny)
        {
            string destinyB = "";
            prbCopiando.Value = 0;

            try
            {
                Server dbServer = new Server(new ServerConnection(server));
                Backup dbBackup = new Backup()
                {
                    Action = BackupActionType.Database,
                    Database = txtBanco.Text
                };

                if (txtDestino.Text == "")
                    destinyB = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Backup\\InoxErpDB\\" + returnDate();
                else
                    destinyB = @"" + destiny + "\\Backup\\InoxErpDB\\" + returnDate();

                if (!Directory.Exists(destinyB))
                {
                    Directory.CreateDirectory(destinyB);
                }

                var location = destinyB + "\\" + DB + ".bak";

                dbBackup.Devices.AddDevice(location, DeviceType.File);
                dbBackup.Initialize = true;
                dbBackup.SqlBackupAsync(dbServer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string returnDate()
        {
            switch (DateTime.Today.Month)
            {
                case 1:
                    return "Janeiro "  + DateTime.Today.Year + "\\" + DateTime.Today.ToShortDateString().Replace("/", "-");
                case 2:
                    return "Fevereiro " + DateTime.Today.Year + "\\" + DateTime.Today.ToShortDateString().Replace("/", "-");
                case 3:
                    return "Março " + DateTime.Today.Year + "\\" + DateTime.Today.ToShortDateString().Replace("/", "-");
                case 4:
                    return "Abril " + DateTime.Today.Year + "\\" + DateTime.Today.ToShortDateString().Replace("/", "-");
                case 5:
                    return "Maio " + DateTime.Today.Year + "\\" + DateTime.Today.ToShortDateString().Replace("/", "-");
                case 6:
                    return "Junho " + DateTime.Today.Year + "\\" + DateTime.Today.ToShortDateString().Replace("/", "-");
                case 7:
                    return "Julho " + DateTime.Today.Year + "\\" + DateTime.Today.ToShortDateString().Replace("/", "-");
                case 8:
                    return "Agosto " + DateTime.Today.Year + "\\" + DateTime.Today.ToShortDateString().Replace("/", "-");
                case 9:
                    return "Setembro " + DateTime.Today.Year + "\\" + DateTime.Today.ToShortDateString().Replace("/", "-");
                case 10:
                    return "Outubro " + DateTime.Today.Year + "\\" + DateTime.Today.ToShortDateString().Replace("/", "-");
                case 11:
                    return "Novembro " + DateTime.Today.Year + "\\" + DateTime.Today.ToShortDateString().Replace("/", "-");
                case 12:
                    return "Dezembro " + DateTime.Today.Year + "\\" + DateTime.Today.ToShortDateString().Replace("/", "-");
            }

            return "";
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
