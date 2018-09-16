using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InoxERP.UI_Windows_Forms;
using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;
using UIWindows.Views.Budgets;
using DataSet = System.Data.DataSet;

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

        private void frmBudgetSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inoxErpDBDataSet2.tb_items' table. You can move, or remove it, as needed.
            this.tb_itemsTableAdapter.Fill(this.inoxErpDBDataSet2.tb_items);
            // TODO: This line of code loads data into the 'inoxErpDBDataSet2.tb_budgets_os' table. You can move, or remove it, as needed.
            this.tb_budgets_osTableAdapter.Fill(this.inoxErpDBDataSet2.tb_budgets_os);
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

        private DataTable dt;

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
                new BudgetPrint(getId).Show();
            }
        }

        private void dgvBudgets_Click(object sender, EventArgs e)
        {
            getId = "";
            if (dgvOrcamentos.CurrentRow != null)
            {
                getId = Convert.ToString(dgvOrcamentos[0, dgvOrcamentos.CurrentRow.Index].Value.ToString());
            }
            else
            {
                MessageBox.Show("Não foi possível selecionar o orçamento, tente selecionar novamente.");
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
                    deleteItemsBudget(); // chama a consulta aos items para deletar eles antes de deletar o orçamento
                    obj.Delete(getId);   // deleta o orçamento depois de deletar os itens

                    var ok = obj.Search.FirstOrDefault(b => b.sID == budget.sID);

                    if (ok != null)
                        MessageBox.Show("Erro ao Excluir o Orçamento !!!");
                    else
                        MessageBox.Show("Orçamento Excluido com Susseço !!!");
                }
            }
            else
            {
                MessageBox.Show("Não foi possível selecionar o orçamento, tente selecionar novamente.");
            }
        }


        // faz consulta aos itens de um orçamento
        public void deleteItemsBudget()
        {
            var search = from p in ctx.Items where p.Budgets_OSID.StartsWith(getId) select p; // esta linha não está consultando pela coluna correta.
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
            }
            return DialogResult.No;
        }

        //overrid FILL DATASET
        public void fillDataSet()
        {
            this.tb_budgets_osTableAdapter.Fill(this.inoxErpDBDataSet2.tb_budgets_os);
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            getId = "";
            if (dgvOrcamentos.CurrentRow != null)
            {
                getId = Convert.ToString(dgvOrcamentos[0, dgvOrcamentos.CurrentRow.Index].Value.ToString());
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

        private void radData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informe a data no formato dd/mm/aaaa, exemplo: 01/09/2018");
        }
    }
}
