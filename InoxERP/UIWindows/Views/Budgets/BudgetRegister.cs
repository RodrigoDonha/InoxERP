using System;
using System.Windows.Forms;
using UIWindows;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;
using UIWindows.Entities.Enum;

namespace InoxERP.UI_Windows_Forms
{
    public partial class frmBudgetsRegister : Form
    {
        static InoxErpContext ctx = new InoxErpContext();

        // daqui pra baixo muda tudo
        UsersBusiness obj = new UsersBusiness(ctx);
        Users userLog = new Users();
        Users user = new Users();


        public frmBudgetsRegister()
        {
            InitializeComponent();
            btnProcurar.Focus();
        }

        private void OrcamentosForm_Load(object sender, EventArgs e)
        {

        }

        private void tbPrevDiasExec_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            frmClientsSearch obj = new frmClientsSearch();
            //this.Hide();
            obj.Show();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            frmSelectViewSearch selecao = new frmSelectViewSearch();
            selecao.Show();
        }

        private void btnPeca_Click(object sender, EventArgs e)
        {
            new frmProductsRegisterSearch().Show();
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            new frmServicesRegisterSearch().Show();
        }

        //validators CAMPS
        public bool validationCamps()
        {
            // ver se essa condição com OU funfa certinho
            if (radComercial.Text.Length.Equals(0) || radResidencial.Text.Length.Equals(0) || radIndustrial.Text.Length.Equals(0))
            {
                radComercial.Focus();
                return false;
            }

            if (txtNome.Text.Length.Equals(0))
            {
                txtNome.Focus();
                return false;
            }

            if (txtEndereco.Text.Length.Equals(0))
            {
                txtEndereco.Focus();
                return false;
            }

            if (txtTelefone.Text.Length.Equals(0))
            {
                txtTelefone.Focus();
                return false;
            }

            if (txtCargo.Text.Length.Equals(0))
            {
                txtCargo.Focus();
                return false;
            }

            // verificar se funfa assim
            //if (grdItens.Text.Length.Equals(0))
            //{
            //    txtCargo.Focus();
            //    return false;
            //}

            return true;
        }

        private void btnGravarOrcamento_Click(object sender, EventArgs e)
        {

        }
    }    
}
