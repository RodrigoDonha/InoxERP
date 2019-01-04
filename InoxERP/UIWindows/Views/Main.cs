using InoxERP.UI_Windows_Forms;
using System;
using System.Windows.Forms;
using UIWindows;
using UIWindows.Entities;
using UIWindows.Entities.Enum;
using UIWindows.Views;
using UIWindows.Views.Backups;
using UIWindows.Views.Reports;

namespace InoxERP
{
    public partial class frmMain : Form
    {
        public Users user = new Users();


        public frmMain(Users user)
        {
            this.user = user;
            InitializeComponent();
            lblLogado.Text = "Olá:  " + user.sName;
        }


        //SCREENS

        //MENUS REGISTER
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmClientsSearch().Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           new frmProviderSearch().Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmProductsRegisterSearch().Show();
        }

        private void tipServicosCadastro_Click(object sender, EventArgs e)
        {
            new frmServicesRegisterSearch().Show();
        }

        private void tipUsuariosCadastro_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmUserRegisterSearch(user).Show();
            else
                MessageBox.Show("Acesso Restrito");
        }


        //MENU BUDGET
        private void inclusãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmBudgetsRegister(null).Show();
        }

        private void tipConsultaOrcamento_Click(object sender, EventArgs e)
        {
            new frmBudgetSearch().Show();
        }


        //MENU SERVICE ORDERS
        private void tipConsultaOS_Click(object sender, EventArgs e)
        {
            new frmServiceOrderSearch().Show();
        }

        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmContractSearch().Show();
        }


        //MENU DELIVERYS
        private void tipEmAndamento_Click(object sender, EventArgs e)
        {
            new frmDeliveryFollowing().Show();
        }

        private void tipEntregasFinalizadas_Click(object sender, EventArgs e)
        {
            new frmDeliveryFinished().Show();
        }
        

        //MENU ACCOUNTS
        private void aPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAccountsToPay().Show();
        }

        private void aReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmAccountsToReceive().Show();
        }

       private void chequesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new frmAccountsCheque().Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAccountsSearch().Show();
        }


        //MENU CASH
        private void entradasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmCashEntry().Show();
        }

        private void saídasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmCashOut().Show();
        }

        private void tipGeralCaixa_Click(object sender, EventArgs e)
        {
            new frmCashGeneral().Show();
        }


        //MENU REPORTS
        private void orçamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmReportBudgets().Show();
        }

        private void ordensDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmReportServicesOrder().Show();
        }

        private void entregasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmReportDelivery().Show();
        }

        //menu reports ABA CASH
        private void dinheiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmReportAccounts().Show();

        }

        private void chequeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmReportCashCheque().Show();

        }
        
        private void geralToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new frmReportCashGeneral().Show();
        }
        
        //BACKUP AUTOMATIC WHEN PRINCIPAL FORM IS CLOSED
        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string server = "(localdb)\\MSSQLLocalDB";
            string DB = "InoxErpDB";
            string destiny = "C:\\Users\\Lucas\\OneDrive";
            //string destiny = "C:\\Users\\jefte\\OneDrive\\Backup";

            try
            {
                frmBackupServerDB backup = new frmBackupServerDB(server,DB,destiny);
            }
            catch (Exception msgException)
            {
                MessageBox.Show(msgException.Message);
            }
        }

        
        //PIC REGISTER
        private void picClient_Click(object sender, EventArgs e)
        {
            new frmClientsSearch().Show();
        }

        private void picFornecedor_Click(object sender, EventArgs e)
        {
            new frmProviderSearch().Show();
        }

        private void picProdutos_Click(object sender, EventArgs e)
        {
            new frmProductsRegisterSearch().Show();
        }

        private void picServicos_Click(object sender, EventArgs e)
        {
            new frmServicesRegisterSearch().Show();
        }

        private void picUsuarios_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmUserRegisterSearch(user).Show();
            else
                MessageBox.Show("Acesso Restrito");
        }


        //PIC BUDGET
        private void picInclusao_Click(object sender, EventArgs e)
        {
            new frmBudgetsRegister(null).Show();
        }

        private void picConsulta_Click(object sender, EventArgs e)
        {
            new frmBudgetSearch().Show();
        }



        //PIC SERVICES ORDERS
        private void picOrdemServico_Click(object sender, EventArgs e)
        {
            new frmServiceOrderSearch().Show();
        }

        private void picContratos_Click(object sender, EventArgs e)
        {
            new frmContractSearch().Show();
        }


        //PIC DELIVERYS
        private void picAndamento_Click(object sender, EventArgs e)
        {
            new frmDeliveryFollowing().Show();
        }

        private void picFinalizadas_Click(object sender, EventArgs e)
        {
            new frmDeliveryFinished().Show();
        }


        //PIC ACCOUNTS
        private void picaReceber_Click(object sender, EventArgs e)
        {
            new frmAccountsToReceive().Show();
        }

        private void picaPagar_Click(object sender, EventArgs e)
        {
            new frmAccountsToPay().Show();

        }

        private void picCheque_Click(object sender, EventArgs e)
        {
            new frmAccountsCheque().Show();
        }

        private void picConsultaContas_Click(object sender, EventArgs e)
        {
            new frmAccountsSearch().Show();
        }


        //PIC CASH
        private void picEntradas_Click(object sender, EventArgs e)
        {
            new frmCashEntry().Show();
        }

        private void picSaidas_Click(object sender, EventArgs e)
        {
            new frmCashOut().Show();
        }

        private void picGeral_Click(object sender, EventArgs e)
        {
            new frmCashGeneral().Show();
        }


        //PIC REPORTS
        private void picRelOrcamentos_Click(object sender, EventArgs e)
        {
            new frmReportBudgets().Show();
        }

        private void picRelOS_Click(object sender, EventArgs e)
        {
            new frmReportServicesOrder().Show();
        }

        private void picRelEntregas_Click(object sender, EventArgs e)
        {
            new frmReportDelivery().Show();
        }


        //pic reports ABA CASH
        private void picRelCaixa_Click(object sender, EventArgs e)
        {
            new frmReportCashGeneral().Show();
        }

        private void picRelCheques_Click(object sender, EventArgs e)
        {
            new frmReportCashCheque().Show();
        }

        private void picRelContas_Click(object sender, EventArgs e)
        {
            new frmReportAccounts().Show();
        }

        //PIC BACKUP
        private void picBackup_Click_1(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin && user.sLogin.Equals("Admin"))
                new frmAdminChose().Show();
            else if (user.Type == UserType.Admin)
                new frmBackupServerDB().Show();
            else
                MessageBox.Show("Acesso Restrito !!!");
        }

        //PIC RESTART APPLICATION
        private void picRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // CALL FORM REPORT USERS IN MENU
        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmUserRegisterSearch(user).Show();
            else
                MessageBox.Show("Acesso Restrito");
        }
    }
}
    

