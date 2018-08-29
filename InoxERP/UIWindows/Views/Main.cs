using InoxERP.UI_Windows_Forms;
using System;
using System.Windows.Forms;
using UIWindows;
using UIWindows.Entities;

namespace InoxERP
{
    public partial class frmMain : Form
    {
        public Users user = new Users();

        //Funções

        public frmMain(Users user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void orçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void inclusãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBudgetsRegister obj = new frmBudgetsRegister();
            //this.Hide();
            obj.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientsSearch obj = new frmClientsSearch();
            //this.Hide();
            obj.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProviderSearch obj = new frmProviderSearch();
            //this.Hide();
            obj.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductsRegisterSearch obj = new frmProductsRegisterSearch();
            //this.Hide();
            obj.Show();
        }

        private void geralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCashGeneral obj = new frmCashGeneral();
            //this.Hide();
            obj.Show();
        }

        private void entradasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCashEntry obj = new frmCashEntry();
            //this.Hide();
            obj.Show();
        }

        private void saídasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCashOut obj = new frmCashOut();
            //this.Hide();
            obj.Show();
        }

        private void chequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountsCheque obj = new frmAccountsCheque();
            //this.Hide();
            obj.Show();
        }

        private void tipConsultaOrcamento_Click(object sender, EventArgs e)
        {
            frmBudgetSearch consulta = new frmBudgetSearch();
            consulta.Show();

        }

        private void tipConsultaOS_Click(object sender, EventArgs e)
        {
            frmServiceOrderSearch consulta = new frmServiceOrderSearch();
            consulta.Show();
        }

        private void tipEmAndamento_Click(object sender, EventArgs e)
        {
            frmDeliveryFollowing andamento = new frmDeliveryFollowing();
            andamento.Show();
        }

        private void tipEntregasFinalizadas_Click(object sender, EventArgs e)
        {
            frmDeliveryFinished finalizadas = new frmDeliveryFinished();
            finalizadas.Show();
        }

        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void orçamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportBudgets orcamentos = new frmReportBudgets();
            orcamentos.Show();
        }

        private void ordensDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportServicesOrder os = new frmReportServicesOrder();
            os.Show();
        }

        private void entregasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportDelivery entregas = new frmReportDelivery();
            entregas.Show();
        }

        private void recebidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportCashCheque cheque = new frmReportCashCheque();
            cheque.Show();
        }

        private void recebíveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportCashMoney dinheiro = new frmReportCashMoney();
            dinheiro.Show();
        }

        private void geralToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmReportCashGeneral geral = new frmReportCashGeneral();
            geral.Show();
        }

        private void tipUsuariosCadastro_Click(object sender, EventArgs e)
        {
            frmUserRegisterSearch usuarios = new frmUserRegisterSearch();
            usuarios.Show();
        }

        private void tipServicosCadastro_Click(object sender, EventArgs e)
        {
            frmServicesRegisterSearch servicos = new frmServicesRegisterSearch();
            servicos.Show();
        }

        private void chequesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAccountsCheque obj = new frmAccountsCheque();
            //this.Hide();
            obj.Show();
        }

        private void aPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountsToPay obj = new frmAccountsToPay();
            //this.Hide();
            obj.Show();
        }

        private void aReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAccountsToReceive obj = new frmAccountsToReceive();
            //this.Hide();
            obj.Show();
        }

        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmContractSearch().Show();
        }

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
            new frmUserRegisterSearch().Show();
        }

        private void picInclusao_Click(object sender, EventArgs e)
        {
            new frmBudgetsRegister().Show();
        }

        private void picConsulta_Click(object sender, EventArgs e)
        {
            new frmBudgetSearch().Show();
        }

        private void picOrdemServico_Click(object sender, EventArgs e)
        {
            new frmServiceOrderSearch().Show();
        }

        private void picContratos_Click(object sender, EventArgs e)
        {
            new frmContractSearch().Show();
        }

        private void picAndamento_Click(object sender, EventArgs e)
        {
            new frmDeliveryFollowing().Show();
        }

        private void picFinalizadas_Click(object sender, EventArgs e)
        {
            new frmDeliveryFinished().Show();
        }

        private void picaReceber_Click(object sender, EventArgs e)
        {
            new frmAccountsToReceive().Show();
        }

        private void picaPagar_Click(object sender, EventArgs e)
        {
            new frmAccountsToPay().Show();

        }

        private void picCheques_Click(object sender, EventArgs e)
        {
            new frmAccountsCheque().Show();
        }

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

        private void picRelDinheiro_Click(object sender, EventArgs e)
        {
            new frmReportCashMoney().Show();
        }

        private void picRelCheques_Click(object sender, EventArgs e)
        {
            new frmReportCashCheque().Show();
        }

        private void picRelCaixaGeral_Click(object sender, EventArgs e)
        {
            new frmReportCashGeneral().Show();
        }

        private void picBackup_Click_1(object sender, EventArgs e)
        {
            new frmBackup().Show();

        }
        
        private void picCheque_Click(object sender, EventArgs e)
        {
            new frmAccountsCheque().Show();
        }

        private void picConsultaContas_Click(object sender, EventArgs e)
        {
            new frmAccountsSearch().Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAccountsSearch().Show();
        }
    }
}
    

