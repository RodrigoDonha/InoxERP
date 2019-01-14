using InoxERP.UI_Windows_Forms;
using System;
using System.Drawing;
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
            if (user.Type == UserType.Admin)
                new frmAccountsToPay().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }

        private void aReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmAccountsToReceive().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }

       private void chequesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmAccountsCheque().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmAccountsSearch().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }


        //MENU CASH
        private void entradasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmCashEntry().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }

        private void saídasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmCashOut().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }

        private void tipGeralCaixa_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmCashGeneral().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }


        //MENU REPORTS
        private void orçamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmReportBudgets().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }

        private void ordensDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmReportServicesOrder().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }

        private void entregasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmReportDelivery().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }

        //menu reports ABA CASH
        private void dinheiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmReportAccounts().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }

        private void chequeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmReportCashCheque().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }
        
        private void geralToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmReportCashGeneral().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }
        
        //BACKUP AUTOMATIC WHEN PRINCIPAL FORM IS CLOSED
        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string server = "(localdb)\\MSSQLLocalDB";
            string DB = "InoxErpDB";
            string destiny = "C:\\Users\\Lucas\\OneDrive";
            //string destiny = "C:\\Users\\jefte\\OneDrive";

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
            if (user.Type == UserType.Admin)
                new frmAccountsToReceive().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }

        private void picaPagar_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmAccountsToPay().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }

        private void picCheque_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmAccountsCheque().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }

        private void picConsultaContas_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmAccountsSearch().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }


        //PIC CASH
        private void picEntradas_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmCashEntry().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }

        private void picSaidas_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmCashOut().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }

        private void picGeral_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmCashGeneral().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }


        //PIC REPORTS
        private void picRelOrcamentos_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmReportBudgets().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }

        private void picRelOS_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmReportServicesOrder().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }

        private void picRelEntregas_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmReportDelivery().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }


        //pic reports ABA CASH
        private void picRelCaixa_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmReportCashGeneral().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }

        private void picRelCheques_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmReportCashCheque().Show();
            else
                MessageBox.Show("Acesso Restrito");
        }

        private void picRelContas_Click(object sender, EventArgs e)
        {
            if (user.Type == UserType.Admin)
                new frmReportAccounts().Show();
            else
                MessageBox.Show("Acesso Restrito");
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
    

