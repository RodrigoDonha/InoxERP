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
    public partial class frmDeliveryFinished : Form
    {
        static InoxErpContext ctx = new InoxErpContext();
        Budgets_OS searchBudget = new Budgets_OS();
        Budget_OSBusiness obj = new Budget_OSBusiness(ctx);
        ItemsBusiness item = new ItemsBusiness(ctx);

        String getId;

        public frmDeliveryFinished()
        {
            InitializeComponent();
        }



        // Events


        private void btnAbrir_Click(object sender, EventArgs e)
        {
            getIdGrigView();

            if (!getId.Equals(""))
            {
                frmBudgetsRegister bud = new frmBudgetsRegister(getId);

                /////FUNCTION TO DISABLE BUTTONS
                foreach (Control budControl in bud.Controls)
                {
                    foreach (Control btn in budControl.Controls)
                    {
                        if (btn.Name == "btnGravarOrcamento" || btn.Name == "btnExcluir" || btn.Name == "btnCancelarOrcamento")
                            btn.Enabled = false;
                        if (btn.Name == "btnAprovar")
                            btn.Enabled = true;
                    }
                }

                bud.BudgetData();
                bud.Show();
            }
        }

        private void btnReabrirEntrega_Click(object sender, EventArgs e)
        {
            getIdGrigView();
            if (dgvEntregasFinalizadas.CurrentRow != null)
            {
                if (messageYesNo("ReopenDelivery") == DialogResult.Yes)
                {
                    Budgets_OS budgetAlter = new Budgets_OS();

                    //procura o orçamento para alteração
                    budgetAlter = obj.ReturnByID(getId);

                    budgetAlter.bServiceOrderDelivered = false; // libera na tela de entrega em andamento
                    budgetAlter.dtDateServiceOrderDelivered = DateTime.Now;
                    budgetAlter.bRegisterFinished = false; // libera na tela de ordens de serviço em andamento
                    budgetAlter.dtDateRegisterFinished = DateTime.Now;

                    obj.Update(budgetAlter);

                    //verifica se o orçamento foi atualizado com sucesso
                    var ok = obj.Search.FirstOrDefault(b => b.sID == budgetAlter.sID);

                    if (ok == null)
                        MessageBox.Show("Erro ao Reabrir a Entrega!!!");
                    else
                    {
                        MessageBox.Show("Entrega Reaberta!");
                    }

                    fillDataSet();
                }
            }
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            if (radNome.Checked)
                searchByName();
            else if (radCPF_CNPJ.Checked)
                searchByCPF_CNPJ();
            else if (radData.Checked)
                searchByDate();
        }

        private void radData_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Informe a data no formato dd/mm/aaaa, exemplo: 01/09/2018");
        }

        private void grdEntregas_Click_1(object sender, EventArgs e)
        {
            getIdGrigView();
        }


        // Parameters Ready, Validations and Verifications down


        public void getIdGrigView()
        {
            getId = "";
            if (dgvEntregasFinalizadas.CurrentRow != null)
            {
                getId = Convert.ToString(dgvEntregasFinalizadas[0, dgvEntregasFinalizadas.CurrentRow.Index].Value.ToString());
                txtPesquisa.Text = Convert.ToString(dgvEntregasFinalizadas[2, dgvEntregasFinalizadas.CurrentRow.Index].Value.ToString());
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
                case "ReopenDelivery":
                    return MessageBox.Show("Confirma a Reabertura da Entrega?", "Reabrir Entrega", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            return DialogResult.No;
        }

        //overrid FILL DATASET
        public void fillDataSet()
        {
            this.tb_budgets_osTableAdapter.FillByDeliveryFinished(this.fullDataSet.tb_budgets_os);
        }

        // SEARCH BY NAME CLIENT
        public void searchByName()
        {
            var search = from p in ctx.Budgets_OS
                        where p.bServiceOrderApproved.Equals(true)
                        where p.bRegisterFinished.Equals(true)
                        where p.bServiceOrderDelivered.Equals(true)
                        where p.sName.StartsWith(txtPesquisa.Text)
                        select p;

            if (search.ToList().Count.Equals(0))
            {
                txtPesquisa.Clear();
                MessageBox.Show("Nenhum Cliente Encontrado");
                txtPesquisa.Focus();
            }
            else
            {
                List<Budgets_OS> b = search.ToList();
                txtPesquisa.Clear();
                dgvEntregasFinalizadas.DataSource = b.ToList();
            }
        }

        public void searchByCPF_CNPJ()
        {
            var search = from p in ctx.Budgets_OS
                         where p.Clients.sCpfCnpj.StartsWith(txtPesquisa.Text)
                         where p.bServiceOrderApproved.Equals(true)
                         where p.bRegisterFinished.Equals(true)
                         where p.bServiceOrderDelivered.Equals(true)
                         select p;

            if (search.ToList().Count.Equals(0))
            {
                txtPesquisa.Clear();
                MessageBox.Show("Nenhum Cliente Encontrado");
                txtPesquisa.Focus();
            }
            else
            {
                List<Budgets_OS> b = search.ToList();
                txtPesquisa.Clear();
                dgvEntregasFinalizadas.DataSource = b.ToList();
            }
        }

        public void searchByDate()
        {
            var query = from p in ctx.Budgets_OS
                        where p.bServiceOrderApproved.Equals(true)
                        where p.bRegisterFinished.Equals(true)
                        where p.bServiceOrderDelivered.Equals(true)
                        select p;

            if (txtPesquisa.Text == "")
            {
                dgvEntregasFinalizadas.DataSource = query.ToList();
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
                dgvEntregasFinalizadas.DataSource = list.ToList();
            }
        }

        private void frmDeliveryFinished_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_budgets_os' table. You can move, or remove it, as needed.
            this.tb_budgets_osTableAdapter.FillByDeliveryFinished(this.fullDataSet.tb_budgets_os);

        }
    }
}

