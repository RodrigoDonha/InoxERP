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
        Budgets_OS searchBudget = new Budgets_OS();
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

        // apresenta exception: nome da coluna já existe: conforme tutorial: https://social.msdn.microsoft.com/Forums/pt-BR/7497b070-542a-47f6-991c-81aa2bd0fd1e/inserir-linha-datagridview?forum=504
        public DataTable CriaDataTable()
        {
            var dt = new DataTable();
            DataColumn dc = new DataColumn();

            dc.DataType = Type.GetType("System.String");
            dc.ColumnName = "Data";
            dc.Caption = "dtDate";
            dc.AllowDBNull = true;
            //dt.Columns.Add(dc);

            dc.DataType = Type.GetType("System.String");
            dc.ColumnName = "Nome";
            dc.Caption = "sName";
            dc.AllowDBNull = true;
            //dt.Columns.Add(dc);

            dc.DataType = Type.GetType("System.String");
            dc.ColumnName = "Telefone";
            dc.Caption = "sTelephone";
            dc.AllowDBNull = true;
            //dt.Columns.Add(dc);

            dc.DataType = Type.GetType("System.String");
            dc.ColumnName = "Valor";
            dc.Caption = "dTotal";
            dc.AllowDBNull = true;
            dt.Columns.Add(dc);

            return dt;
        }

        private DataTable dt;

        // consulta data preciso saber como faz para passar a data do txt para uma consulta, pelo jeito abaixo dá exception
        public void searchByDate()
        {
            //DateTime data = Convert.ToDateTime(txtPesquisa.Text);
            //var query = from p in ctx.Budgets_OS where (p.dtDate == data) select p;
            var query = from p in ctx.Budgets_OS select p;

            dt = CriaDataTable();
            dgvOrcamentos.DataSource = dt;
            DataRow linha = dt.NewRow();

            foreach (var bud in query)
            {
                if (bud.dtDate.ToString().Contains("14/09/2018"))
                {
                    linha["dtDate"] = bud.dtDate.ToString();
                    linha["sName"] = bud.sName.ToString();
                    linha["sTelephone"] = bud.sTelephone.ToString();
                    linha["dTotal"] = bud.dTotal.ToString();
                }
            }

            //alimentando a grid view com um objeto usando .Rows.Add(bud.DtDate.ToString ....) não funfou, diz que não pode receber dados de objeto sem criar DataTable.
            // por isso tentei dessa maneira acima, mas também não funfou.
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
                        obj.Delete(getId);

                        var ok = obj.Search.FirstOrDefault(b => b.sID == searchBudget.sID);

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

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            getId = "";
            if (dgvOrcamentos.CurrentRow != null)
            {
                getId = Convert.ToString(dgvOrcamentos[0, dgvOrcamentos.CurrentRow.Index].Value.ToString());
                searchBudget = obj.ReturnByID(getId);
                if (messageYesNo("Approve") == DialogResult.Yes)
                {
                    searchBudget.bServiceOrderApproved = true;
                    searchBudget.dtDateServiceOrderApproved = DateTime.Now;

                    obj.Update(searchBudget);
                        MessageBox.Show("Aprovado");}
            }
            else
            {
                MessageBox.Show("Não foi possível selecionar o orçamento, tente selecionar novamente.");
            }


            
        }
    }
}
