using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using InoxERP.BLL;
using InoxERP.Modelos;
using InoxERP.UI_Windows_Forms;
using UIWindows;

namespace InoxERP
{
    public partial class PrincipalForm : Form
    {
        private string TipoDeUsuario { get; set; } //MANDA P CA
        private string UsuarioLogado { get; set; } //MANDA P CA

        //Funções

        public PrincipalForm(string tipo, string usuario)
        {
            this.TipoDeUsuario = tipo;
            this.UsuarioLogado = usuario;
            InitializeComponent();
        }

        private void orçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PermissoesList List = new PermissoesList();
            //PermissaoUsuarioBLL permissao = new PermissaoUsuarioBLL();
            //List = permissao.Permissao(TipoDeUsuario);
        }

        private void inclusãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrcamentosForm obj = new OrcamentosForm();
            //this.Hide();
            obj.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaClientesForm obj = new ConsultaClientesForm();
            //this.Hide();
            obj.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFornecedoresForm obj = new ConsultaFornecedoresForm();
            //this.Hide();
            obj.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaProdutosForm obj = new ConsultaProdutosForm();
            //this.Hide();
            obj.Show();
        }

        private void geralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaixaGeralForm obj = new CaixaGeralForm();
            //this.Hide();
            obj.Show();
        }

        private void entradasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CaixaEntradasForm obj = new CaixaEntradasForm();
            //this.Hide();
            obj.Show();
        }

        private void saídasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CaixaSaidasForm obj = new CaixaSaidasForm();
            //this.Hide();
            obj.Show();
        }

        private void chequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaixaChequesForm obj = new CaixaChequesForm();
            //this.Hide();
            obj.Show();
        }

        private void tipConsultaOrcamento_Click(object sender, EventArgs e)
        {
            ConsultaOrcamentoForm consulta = new ConsultaOrcamentoForm();
            consulta.Show();

        }

        private void tipConsultaOS_Click(object sender, EventArgs e)
        {
            ConsultaOrdemServicoForm consulta = new ConsultaOrdemServicoForm();
            consulta.Show();
        }

        private void tipEmAndamento_Click(object sender, EventArgs e)
        {
            EntregasAndamentoForm andamento = new EntregasAndamentoForm();
            andamento.Show();
        }

        private void tipEntregasFinalizadas_Click(object sender, EventArgs e)
        {
            EntregasFinalizadasForm finalizadas = new EntregasFinalizadasForm();
            finalizadas.Show();
        }

        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void orçamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatoriosOrcamentosForm orcamentos = new RelatoriosOrcamentosForm();
            orcamentos.Show();
        }

        private void ordensDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatoriosOrdemServicoForm os = new RelatoriosOrdemServicoForm();
            os.Show();
        }

        private void entregasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioEntregasForm entregas = new RelatorioEntregasForm();
            entregas.Show();
        }

        private void recebidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioCaixaChequeForm cheque = new RelatorioCaixaChequeForm();
            cheque.Show();
        }

        private void recebíveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioCaixaDinheiroForm dinheiro = new RelatorioCaixaDinheiroForm();
            dinheiro.Show();
        }

        private void geralToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RelatorioCaixaGeralForm geral = new RelatorioCaixaGeralForm();
            geral.Show();
        }

        private void tipUsuariosCadastro_Click(object sender, EventArgs e)
        {
            ConsultaUsuariosForm usuarios = new ConsultaUsuariosForm();
            usuarios.Show();
        }

        private void tipServicosCadastro_Click(object sender, EventArgs e)
        {
            ConsultaServicosForm servicos = new ConsultaServicosForm();
            servicos.Show();
        }

        private void chequesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CaixaChequesForm obj = new CaixaChequesForm();
            //this.Hide();
            obj.Show();
        }

        private void aPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContasaPagarForm obj = new ContasaPagarForm();
            //this.Hide();
            obj.Show();
        }

        private void aReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ContasaReceberForm obj = new ContasaReceberForm();
            //this.Hide();
            obj.Show();
        }

        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultaContratosForm().Show();
        }

        private void picClient_Click(object sender, EventArgs e)
        {
            new ConsultaClientesForm().Show();
        }

        private void picFornecedor_Click(object sender, EventArgs e)
        {
            new ConsultaFornecedoresForm().Show();
        }

        private void picProdutos_Click(object sender, EventArgs e)
        {
            new ConsultaProdutosForm().Show();
        }

        private void picServicos_Click(object sender, EventArgs e)
        {
            new ConsultaServicosForm().Show();
        }

        private void picUsuarios_Click(object sender, EventArgs e)
        {
            new ConsultaUsuariosForm().Show();
        }

        private void picInclusao_Click(object sender, EventArgs e)
        {
            new OrcamentosForm().Show();
        }

        private void picConsulta_Click(object sender, EventArgs e)
        {
            new ConsultaOrcamentoForm().Show();
        }

        private void picOrdemServico_Click(object sender, EventArgs e)
        {
            new ConsultaOrdemServicoForm().Show();
        }

        private void picContratos_Click(object sender, EventArgs e)
        {
            new ConsultaContratosForm().Show();
        }

        private void picAndamento_Click(object sender, EventArgs e)
        {
            new EntregasAndamentoForm().Show();
        }

        private void picFinalizadas_Click(object sender, EventArgs e)
        {
            new EntregasFinalizadasForm().Show();
        }

        private void picaReceber_Click(object sender, EventArgs e)
        {
            new ContasaReceberForm().Show();
        }

        private void picaPagar_Click(object sender, EventArgs e)
        {
            new ContasaPagarForm().Show();

        }

        private void picCheques_Click(object sender, EventArgs e)
        {
            new CaixaChequesForm().Show();
        }

        private void picEntradas_Click(object sender, EventArgs e)
        {
            new CaixaEntradasForm().Show();
        }

        private void picSaidas_Click(object sender, EventArgs e)
        {
            new CaixaSaidasForm().Show();
        }

        private void picGeral_Click(object sender, EventArgs e)
        {
            new CaixaGeralForm().Show();
        }

        private void picRelOrcamentos_Click(object sender, EventArgs e)
        {
            new RelatoriosOrcamentosForm().Show();
        }

        private void picRelOS_Click(object sender, EventArgs e)
        {
            new RelatoriosOrdemServicoForm().Show();
        }

        private void picRelEntregas_Click(object sender, EventArgs e)
        {
            new RelatorioEntregasForm().Show();
        }

        private void picRelDinheiro_Click(object sender, EventArgs e)
        {
            new RelatorioCaixaDinheiroForm().Show();
        }

        private void picRelCheques_Click(object sender, EventArgs e)
        {
            new RelatorioCaixaChequeForm().Show();
        }

        private void picRelCaixaGeral_Click(object sender, EventArgs e)
        {
            new RelatorioCaixaGeralForm().Show();
        }

        private void picBackup_Click_1(object sender, EventArgs e)
        {
            new BackupForm().Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new CaixaChequesForm().Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new CaixaChequesForm().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new ConsultaChequesBaixadosForm().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new ConsultaContasForm().Show();
        }
    }
}
    

