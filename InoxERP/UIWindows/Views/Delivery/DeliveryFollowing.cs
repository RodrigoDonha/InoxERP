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
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;

namespace UIWindows
{
    public partial class frmDeliveryFollowing : Form
    {
        static InoxErpContext ctx = new InoxErpContext();
        Budgets_OS searchBudget = new Budgets_OS();
        Budget_OSBusiness obj = new Budget_OSBusiness(ctx);
        ItemsBusiness item = new ItemsBusiness(ctx);

        String getId;
        
        public frmDeliveryFollowing()
        {
            InitializeComponent();
        }

        // Events

        private void frmDeliveryFollowing_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'inoxErpDBDataSet3ServiceOrdersApprovedGidView.tb_delivery_opened'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_delivery_openedTableAdapter.Fill(this.inoxErpDBDataSet3ServiceOrdersApprovedGidView.tb_delivery_opened);
        }

        private void btnAbrirAlterar_Click(object sender, EventArgs e)
        {
            getIdGrigView();
            frmBudgetsRegister bud = new frmBudgetsRegister(getId);
            bud.BudgetData();
            bud.Show();
        }

        private void btnReabrirOS_Click(object sender, EventArgs e)
        {
            getIdGrigView();
            if (messageYesNo("ReopenOS") == DialogResult.Yes)
            {
                Budgets_OS budgetAlter = new Budgets_OS();

                //procura o orçamento para alteração
                budgetAlter = obj.ReturnByID(getId);

                budgetAlter.bRegisterFinished = false;
                budgetAlter.dtDateRegisterFinished = DateTime.Now;

                obj.Update(budgetAlter);

                //verifica se o orçamento foi atualizado com sucesso
                var ok = obj.Search.FirstOrDefault(b => b.sID == budgetAlter.sID);

                if (ok == null)
                    MessageBox.Show("Erro ao Reabrir a Ordem de Serviço !!!");
                else
                {
                    MessageBox.Show("Ordem de Serviço Reaberta!");
                }

                fillDataSet();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            getIdGrigView();

            if (messageYesNo("Finished") == DialogResult.Yes)
            {
                Budgets_OS budgetAlter = new Budgets_OS();

                //procura o orçamento para alteração
                budgetAlter = obj.ReturnByID(getId);

                budgetAlter.bServiceOrderDelivered = true;
                budgetAlter.dtDateServiceOrderDelivered = DateTime.Now;

                obj.Update(budgetAlter);

                //verifica se o orçamento foi atualizado com sucesso
                var ok = obj.Search.FirstOrDefault(b => b.sID == budgetAlter.sID);

                if (ok == null)
                    MessageBox.Show("Erro ao Finalizar a Entrega !!!");
                else
                {
                    MessageBox.Show("Entrega Concluída!");
                }

                fillDataSet();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Jefter, inserir excluir aqui
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (radNome.Checked)
                searchByName();
            else if (radCPF_CNPJ.Checked)
                searchByCPF_CNPJ();
            else if (radData.Checked)
                searchByDate();
        }

        private void radData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informe a data no formato dd/mm/aaaa, exemplo: 01/09/2018");
        }


        private void grdEntregas_Click(object sender, EventArgs e)
        {
            getIdGrigView();
        }


        // Parameters Ready, Validations and Verifications down

        public void getIdGrigView()
        {
            getId = "";
            if (grdEntregas.CurrentRow != null)
            {
                getId = Convert.ToString(grdEntregas[6, grdEntregas.CurrentRow.Index].Value.ToString());
            }
            else
            {
                MessageBox.Show("Não foi possível selecionar o orçamento, tente selecionar novamente.");
            }
        }

        public DialogResult messageYesNo(string type)
        {
            switch (type)
            {
                case "Finished":
                    return MessageBox.Show("Confirma a Entrega?", "Finalizar Entrega", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "ReopenOS":
                    return MessageBox.Show("Confirma a Reabertura da Ordem de Serviço?", "Reabrir Ordem de Serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            return DialogResult.No;
        }

        //overrid FILL DATASET
        public void fillDataSet()
        {
            this.tb_delivery_openedTableAdapter.Fill(this.inoxErpDBDataSet3ServiceOrdersApprovedGidView.tb_delivery_opened);
        }

        // SEARCH BY NAME CLIENT
        public void searchByName()
        {
            var query = from p in ctx.Budgets_OS where p.bServiceOrderApproved.Equals(true)
                where p.bRegisterFinished.Equals(true)
                where p.bServiceOrderDelivered.Equals(false)
                where p.sName.StartsWith(txtPesquisa.Text)
            select p;

            grdEntregas.DataSource = query.ToList();
        }

        public void searchByCPF_CNPJ()
        {
            // implementar quando já estiver sido implementado o módulo clientes
        }

        public void searchByDate(){

            var query = from p in ctx.Budgets_OS
                where p.bServiceOrderApproved.Equals(true)
                where p.bRegisterFinished.Equals(true)
                where p.bServiceOrderDelivered.Equals(false)
            select p;

            if (txtPesquisa.Text == "")
            {
                grdEntregas.DataSource = query.ToList();
            }
            else
            {
                List<Budgets_OS> list = new List<Budgets_OS>();

                foreach (var line in query.ToList())
                {
                    if (line.dtFinalPrevision.Date.ToShortDateString().Contains(txtPesquisa.Text))
                    {
                        list.Add(line);
                    }
                }
                grdEntregas.DataSource = list.ToList();
            }
        }
    }
}
