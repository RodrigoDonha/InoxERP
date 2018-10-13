using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;

namespace UIWindows
{
    public partial class frmServicesRegisterSearch : Form
    {
        static InoxErpContext ctx = new InoxErpContext();
        ServicesBusiness obj = new ServicesBusiness(ctx);
        ValidationEntries validation = new ValidationEntries();

        public frmServicesRegisterSearch()
        {
            InitializeComponent();
        }

        //INSERT
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!validationCamps())
                MessageBox.Show("Por Favor preencha as informações Corretamente");
            else
            {
                Services servicesPersist = new Services();

                servicesPersist.sID = Guid.NewGuid().ToString();

                servicesPersist.sDescription = txtServico.Text;
                servicesPersist.sTime = Convert.ToDouble(txtHoras.Text);
                servicesPersist.dTotal = Convert.ToDecimal(txtValorTotal.Text);
                servicesPersist.sObservation = txtObservacao.Text;

                if (messageYesNo("insert") == DialogResult.Yes)
                 {
                     obj.Insert(servicesPersist);

                     var ok = obj.Search.FirstOrDefault(b => b.sID == servicesPersist.sID);

                     if (ok == null)
                         MessageBox.Show("Erro ao Cadastrar o Serviço !!!");
                     else
                         MessageBox.Show("Serviço Cadastrado com Sucesso !!!");

                    afterAction();
                 }
            }
        }


        //UPDATE
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!validationCamps())
                MessageBox.Show("Por Favor preencha as informações Corretamente");
            else
            {
                Services servicesAlter = new Services();

                servicesAlter = obj.ReturnByID(lblID.Text);

                servicesAlter.sDescription = txtServico.Text;
                servicesAlter.sTime = Convert.ToDouble(txtHoras.Text);
                servicesAlter.dTotal = Convert.ToDecimal(txtValorTotal.Text);
                servicesAlter.sObservation = txtObservacao.Text;

                if (messageYesNo("update") == DialogResult.Yes)
                {
                    obj.Update(servicesAlter);

                    var ok = obj.Search.FirstOrDefault(b => b.sID == servicesAlter.sID);

                    if (ok == null)
                        MessageBox.Show("Erro ao Atualizar o Serviço !!!");
                    else
                        MessageBox.Show("Serviço Atualizado com Sucesso !!!");

                    afterAction();

                    tbcConsultaValores.SelectedTab = Consulta;
                }
            }
        }


        //DELETE
        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (lblID.Text.Equals(""))
                MessageBox.Show("Selecione um Serviço Primeiro");
            else if (messageYesNo("delete") == DialogResult.Yes)
            {
                obj.Delete(lblID.Text);

                var ok = obj.Search.FirstOrDefault(b => b.sID == lblID.Text);

                if (ok != null)
                    MessageBox.Show("Erro ao Excluir o Serviço !!!");
                else
                    MessageBox.Show("Serviço Excluido com Sucesso !!!");

                afterAction();

                tbcConsultaValores.SelectedTab = Consulta;
            }
        }
       
        public void afterAction()
        {
            fillDataSet();
            cleanCamps();
        }


        //VALIDATORS

        //validator CAMPS
        public bool validationCamps()
        {
            if (txtServico.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe o Nome para o Serviço");
                txtServico.Focus();
                return false;
            }

            if (txtHoras.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe a Quantidade de Tempo Gasto para Fazer o Serviço");
                txtHoras.Focus();
                return false;
            }

            if (txtValorTotal.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe o Valor Cobrado para Fazer o Serviço");
                txtValorTotal.Focus();
                return false;
            }
            
            return true;
        }

        //validator DIALOG
        public DialogResult messageYesNo(string type)
        {
            switch (type)
            {
                case "insert":
                    return MessageBox.Show("Confirma a inclusão ?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "update":
                    return MessageBox.Show("Confirma a atualização ?", "Atualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "delete":
                    return MessageBox.Show("Confirma a Exclusão ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }

            return DialogResult.No;
        }


        //VALIDATION OF NUMBERS
        public void valueTotal()
        {
            decimal d;

            if (!decimal.TryParse(txtHoras.Text, out d))
            {
                if (txtHoras.Text == "")
                { }
                else
                {
                    txtHoras.Focus();
                    txtHoras.Text = "";
                }
            }
            if (!decimal.TryParse(txtValorTotal.Text, out d))
            {
                if (txtValorTotal.Text == "")
                { }
                else
                {
                    txtValorTotal.Focus();
                    txtValorTotal.Text = "";
                }
            }
        }

        //CLEAN
        public void cleanCamps()
        {
            txtServico.Clear();
            txtHoras.Clear();
            txtValorTotal.Clear();
            txtObservacao.Clear();
        }


        //FILLs
        

        //overrid FILL DATASET
        public void fillDataSet()
        {
            this.tb_servicesTableAdapter.Fill(this.fullDataSet.tb_services);
        }

        //FILL INFORMATION CAMPS
        private void dgvConsultaPecas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int compare = dgvConsultaServicos.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (compare == 0)
            { }
            else
            {
                tbcConsultaValores.SelectedTab = Cadastro; // muda tab
                txtServico.Focus();
                cleanCamps();
                lblID.Text = dgvConsultaServicos[0, dgvConsultaServicos.CurrentRow.Index].Value.ToString();
                txtServico.Text = dgvConsultaServicos[1, dgvConsultaServicos.CurrentRow.Index].Value.ToString();
                txtHoras.Text = dgvConsultaServicos[2, dgvConsultaServicos.CurrentRow.Index].Value.ToString();
                txtValorTotal.Text = dgvConsultaServicos[3, dgvConsultaServicos.CurrentRow.Index].Value.ToString();
                txtObservacao.Text = dgvConsultaServicos[4, dgvConsultaServicos.CurrentRow.Index].Value.ToString();
            }
        }

        //FILL DATASET ON LOAD
        private void frmServicesRegisterSearch_Load(object sender, EventArgs e)
        {
            fillDataSet();
        }


        //STATES CHANGED

        //WHEN STATE OF TXTHORAS IS CHANGED
        private void txtHoras_TextChanged(object sender, EventArgs e)
        {
            if (txtHoras.Text != "")
                valueTotal();
        }

        //WHEN STATE OF TXTVALORTOTAL IS CHANGED
        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {
            if (txtValorTotal.Text != "")
                valueTotal();
        }

        //SEARCH
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            searchByName();
        }

        //SEARCH BY NAME
        public void searchByName()
        {
            var search = from p in ctx.Services where p.sDescription.StartsWith(txtConsultaServico.Text) select p;

            if (search.ToList().Count.Equals(0))
            {
                txtConsultaServico.Clear();
                MessageBox.Show("Serviço Não Encontrado");
                txtConsultaServico.Focus();
                searchByName();
            }
            else
            {
                List<Services> s = search.ToList();
                txtConsultaServico.Clear();
                dgvConsultaServicos.DataSource = s.ToList();
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            fillDataOnTab();
        }

        public void fillDataOnTab()
        {
            int compare = dgvConsultaServicos.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (compare == 0)
            { }
            else
            {
                tbcConsultaValores.SelectedTab = Cadastro; // muda tab
                txtServico.Focus();
                cleanCamps();
                lblID.Text = dgvConsultaServicos[0, dgvConsultaServicos.CurrentRow.Index].Value.ToString();
                txtServico.Text = dgvConsultaServicos[1, dgvConsultaServicos.CurrentRow.Index].Value.ToString();
                txtHoras.Text = dgvConsultaServicos[2, dgvConsultaServicos.CurrentRow.Index].Value.ToString();
                txtValorTotal.Text = dgvConsultaServicos[3, dgvConsultaServicos.CurrentRow.Index].Value.ToString();
                txtObservacao.Text = dgvConsultaServicos[4, dgvConsultaServicos.CurrentRow.Index].Value.ToString();
            }
        }

        public void validationEntriesNumerics(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }

        public void validationEntriesTime(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyTime(sender, e);
        }

        private void dgvConsultaServicos_DoubleClick(object sender, EventArgs e)
        {
            fillDataOnTab();
        }
    }
}
