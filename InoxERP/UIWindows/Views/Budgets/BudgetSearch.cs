using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tb_budgets_osTableAdapter.FillBy(this.inoxErpDBDataSet2.tb_budgets_os);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
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

        public void searchByName() //nao esta funcionando
        {
            //dgvOrcamentos.DataSource = obj.returnByName(txtPesquisa.Text);

            //SqlDataAdapter da = new SqlDataAdapter();

            //DataSet dt = obj.returnByName(txtPesquisa.Text);
            //var o = obj.returnByName(txtPesquisa.Text);

            //DataTable table = new DataTable();

            //da.Fill(table);

            //var search = from p in ctx.Budgets_OS where p.sName.Equals(txtPesquisa.Text) select p;
            //var search = from p in ctx.Budgets_OS select p.sName.Equals(txtPesquisa.Text);

            var search = from p in ctx.Budgets_OS where p.sName.StartsWith(txtPesquisa.Text) select p;

            dgvOrcamentos.DataSource = search.ToList();
        }

        public void searchByCPF_CNPJ()
        {

        }
        public void searchByDate()
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {            
            if(getId == null)
            {
                MessageBox.Show("Selecione um orçmento na lista acima.");
            }
            else
            {
                //new frmPrintBudgets(getId).Show();
                new Print(getId).Show();
            }
        }

        private void dgvBudgets_Click(object sender, EventArgs e)
        {
            getId = "";
            getId = Convert.ToString(dgvOrcamentos[0, dgvOrcamentos.CurrentRow.Index].Value.ToString());            
        }

        private void dgvOrcamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
