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
        Services services = new Services();

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
                services.sID = Guid.NewGuid().ToString();
                
                services.sDescription = txtServico.Text;
                services.sTime = Convert.ToDouble(txtHoras.Text);
                services.dTotal = Convert.ToDecimal(txtValorTotal.Text);
                services.sObservation = txtObservacao.Text;

                if (messageYesNo("insert") == DialogResult.Yes)
                 {
                     obj.Insert(services);
                     afterAction();
                     MessageBox.Show("Salvo");
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
                services = obj.ReturnByID(lblID.Text);

                services.sDescription = txtServico.Text;
                services.sTime = Convert.ToDouble(txtHoras.Text);
                services.dTotal = Convert.ToDecimal(txtValorTotal.Text);
                services.sObservation = txtObservacao.Text;

                if (messageYesNo("update") == DialogResult.Yes)
                {
                    obj.Update(services);
                    afterAction();
                    MessageBox.Show("Atualizado");
                    tbcConsultaValores.SelectedTab = Consulta;
                }
            }
        }


        //DELETE
        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (lblID.Text.Equals(""))
                MessageBox.Show("Selecione um Usuario Primeiro");
            else if (messageYesNo("delete") == DialogResult.Yes)
            {
                obj.Delete(lblID.Text);
                afterAction();
                MessageBox.Show("Excluído");
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
                txtServico.Focus();
                return false;
            }

            if (txtHoras.Text.Length.Equals(0))
            {
                txtHoras.Focus();
                return false;
            }

            if (txtValorTotal.Text.Length.Equals(0))
            {
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


        //CLEAN
        public void cleanCamps()
        {
            txtServico.Clear();
            txtHoras.Clear();
            txtValorTotal.Clear();
            txtObservacao.Clear();
        }


        //FILLs

        //FILL DATASET ON LOAD
        private void frmServicesRegisterSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inoxErpDBDataSet1.tb_services' table. You can move, or remove it, as needed.
            fillDataSet();
        }

        //overrid FILL DATASET
        public void fillDataSet()
        {
            this.tb_servicesTableAdapter.Fill(this.inoxErpDBDataSet1.tb_services);
        }

        //FILL INFORMATION CAMPS
        private void dgvConsultaPecas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int compare = dgvConsultaPecas.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (compare == 0)
            { }
            else
            {
                tbcConsultaValores.SelectedTab = Cadastro; // muda tab
                txtServico.Focus();
                cleanCamps();
                lblID.Text = dgvConsultaPecas[0, dgvConsultaPecas.CurrentRow.Index].Value.ToString();
                txtServico.Text = dgvConsultaPecas[1, dgvConsultaPecas.CurrentRow.Index].Value.ToString();
                txtHoras.Text = dgvConsultaPecas[2, dgvConsultaPecas.CurrentRow.Index].Value.ToString();
                txtValorTotal.Text = dgvConsultaPecas[3, dgvConsultaPecas.CurrentRow.Index].Value.ToString();
                txtObservacao.Text = dgvConsultaPecas[4, dgvConsultaPecas.CurrentRow.Index].Value.ToString();
            }
        }
    }
}
