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
using UIWindows;

namespace InoxERP
{
    public partial class PrincipalForm : Form
    {
        private int TipoDeUsuario { get; set; }//MANDA P CA
        private string UsuarioLogado { get; set; }//MANDA P CA

        //Funções

        public PrincipalForm(int tipo, string usuario)
        {
            this.TipoDeUsuario = tipo;
            this.UsuarioLogado = usuario;
            InitializeComponent();
        }
        
        private void orçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inclusãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrcamentosForm obj = new OrcamentosForm();
            //this.Hide();
            obj.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesForm obj = new ClientesForm();
            //this.Hide();
            obj.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FornecedoresForm obj = new FornecedoresForm();
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
            UsuariosForm usuarios = new UsuariosForm();
            usuarios.Show();
        }
    }
}
