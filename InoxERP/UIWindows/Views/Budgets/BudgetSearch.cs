using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using InoxERP.UI_Windows_Forms;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;
using UIWindows.Views.Budgets;

namespace UIWindows
{
    public partial class frmBudgetSearch : Form
    {
        static InoxErpContext ctx = new InoxErpContext();
        Budgets_OS budget = new Budgets_OS();
        Budget_OSBusiness obj = new Budget_OSBusiness(ctx);
        ItemsBusiness item = new  ItemsBusiness(ctx);
        
        String getId;

        public frmBudgetSearch()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (radNome.Checked)
                searchByName();
            else if (radCPF_CNPJ.Checked)
                searchByCPF_CNPJ();
            else if(radData.Checked)
                searchByDate();
        }

        // SEARCH BY NAME CLIENT
        public void searchByName() //nao esta funcionando
        {
            var search = from p in ctx.Budgets_OS where p.sName.StartsWith(txtPesquisa.Text) select p;

            dgvOrcamentos.DataSource = search.ToList();
        }

        public void searchByCPF_CNPJ()
        {
            
        }

        public void searchByDate()
        {
            var query = from p in ctx.Budgets_OS select p;

            if (txtPesquisa.Text == "")
            {
                dgvOrcamentos.DataSource = query.ToList();
            }
            else
            {
                List<Budgets_OS> list = new List<Budgets_OS>();

                foreach (var line in query.ToList())
                {
                    if (line.dtDate.Date.ToShortDateString().Contains(txtPesquisa.Text))
                    {
                        list.Add(line);
                    }
                }
                dgvOrcamentos.DataSource = list.ToList();
            }
        }

        // call screen print budget
        private void btnPrint_Click(object sender, EventArgs e)
        {            
            if(getId == null)
            {
                MessageBox.Show("Selecione um orçmento na lista acima.");
            }
            else
            {
                PrintingBudget();
                //new BudgetPrint(getId).Show();
            }
        }

        // chama a impressão do orçamento, se vai imprimir com preço nos itens ou não.
        public void PrintingBudget()
        {
            if (messageYesNo("Price") == DialogResult.Yes)
            {
                new BudgetPrintWithPrice(getId).Show();
            }
            else
            {
                new BudgetPrint(getId).Show();
            }
        }

        private void dgvBudgets_Click(object sender, EventArgs e)
        {
            getId = "";
            if (dgvOrcamentos.CurrentRow != null)
            {
                getId = Convert.ToString(dgvOrcamentos[0, dgvOrcamentos.CurrentRow.Index].Value.ToString());
                txtPesquisa.Text = Convert.ToString(dgvOrcamentos[2, dgvOrcamentos.CurrentRow.Index].Value.ToString());
            }
            else
            {
                MessageBox.Show("Não foi possível selecionar o orçamento, tente selecionar novamente.");
                txtPesquisa.Text = "";
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (getId == null)
            {
                MessageBox.Show("Selecione um orçmento na lista acima.");
            }
            else
            {
                Dispose();
                frmBudgetsRegister bud = new frmBudgetsRegister(getId);
                bud.BudgetData();
                bud.Show();
            }
        }

        // só esta excluindo orçamentos sem itens, com itens está dando erro, precisa pegar o id do orçamento e tentar deletar os itens pelo id do orçemanto
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            getId = "";

            if (dgvOrcamentos.CurrentRow != null)
            {
                getId = Convert.ToString(dgvOrcamentos[0, dgvOrcamentos.CurrentRow.Index].Value.ToString());
                
                if (messageYesNo("Exclude") == DialogResult.Yes)
                {
                    obj.Delete(getId);

                    var ok = obj.Search.FirstOrDefault(b => b.sID == budget.sID);

                    if (ok != null)
                        MessageBox.Show("Erro ao Excluir o Orçamento !!!");
                    else
                        MessageBox.Show("Orçamento Excluido com Susseço !!!");
                }
                fillDataSet();
            }
            else
            {
                MessageBox.Show("Não foi possível selecionar o orçamento, tente selecionar novamente.");
            }
        }


        // faz consulta aos itens de um orçamento
        public void deleteItemsBudget()
        {
            var search = from p in ctx.Items where p.IdBudgets_OS.StartsWith(getId) select p; // esta linha não está consultando pela coluna correta.
            if (search.Count() > 0)
            {
                foreach (var line in search)
                {
                    string id = line.sID.ToString();
                    item.Delete(id);
                }
            }
        }

        //validator YesNo
        public DialogResult messageYesNo(string type)
        {
            switch (type)
            {
                case "Exclude":
                    return MessageBox.Show("Confirma excluisão?", "Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "Approve":
                    return MessageBox.Show("Confirma aprovação deste orçamento?", "Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "Price":
                    return MessageBox.Show("Deseja Exibir / Imprimir o orçamento com preço nos itens?", "Exibir Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            return DialogResult.No;
        }

        //overrid FILL DATASET
        public void fillDataSet()
        {
            this.tb_budgets_osTableAdapter.FillByBudgetUnapproved(this.fullDataSet.tb_budgets_os);
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            if (dgvOrcamentos.CurrentRow != null)
            {
                setId();
                budget = obj.ReturnByID(getId);
                if (messageYesNo("Approve") == DialogResult.Yes)
                {
                    budget.bServiceOrderApproved = true;
                    budget.dtDateServiceOrderApproved = DateTime.Now;

                    obj.Update(budget);
                        MessageBox.Show("Aprovado");}

                fillDataSet();
            }
            else
            {
                MessageBox.Show("Não foi possível selecionar o orçamento, tente selecionar novamente.");
            }
        }

        private void setId()
        {
            getId = Convert.ToString(dgvOrcamentos[0, dgvOrcamentos.CurrentRow.Index].Value.ToString());
        }

        private void radData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informe a data no formato dd/mm/aaaa, exemplo: 01/09/2018");
        }

        private void frmBudgetSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_budgets_os' table. You can move, or remove it, as needed.
            this.tb_budgets_osTableAdapter.FillByBudgetUnapproved(this.fullDataSet.tb_budgets_os);

        }
    }
}
