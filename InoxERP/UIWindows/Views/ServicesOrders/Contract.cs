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
    public partial class frmContract : Form
    {
        ValidationEntries validation = new ValidationEntries();

        static InoxErpContext ctx = new InoxErpContext();
        Budgets_OS searchBudget = new Budgets_OS();
        Clients cli = new Clients();
        Budget_OSBusiness obj = new Budget_OSBusiness(ctx);
        ClientsBusiness clients = new ClientsBusiness(ctx);
        ItemsBusiness item = new ItemsBusiness(ctx);

        private string getId;

        public frmContract(string id)
        {
            getId = id;
            InitializeComponent();

            getData();
        }

        public void getData()
        {
            searchBudget = obj.ReturnByID(getId);
        }

        public void validationEntriesCPFandCNPJ(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyCPFandCNPJ(sender, e);
        }

        public void validationEntriesCEP(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyCEP(sender, e);
        }

        public void validationEntriesNumerics(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }

        public void validationEntriesPhones(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyPhones(sender, e);
        }

        public void ClickContractOfObject()
        {
            if (searchBudget.IdClients != null)
            {
                string idClient = searchBudget.IdClients;
                cli = clients.ReturnByID(idClient);
                txtNomeC.Text = cli.sName;
                txtCpfCnpjC.Text = cli.sCpfCnpj;
                //txtRgC.Text (não há rg do cliente no banco)
                txtCepC.Text = cli.sCEP;
                txtEnderecoC.Text = cli.sAdress;
                txtNumeroC.Text = cli.iNumber.ToString();
                txtBairroC.Text = cli.sDistrict;
                txtCidadeC.Text = cli.sCity;
                cbxEstate.Text = cli.Estate.ToString();
            }

            txtDescription.Text = searchBudget.sObservation;
            txtValores.Text = searchBudget.dTotal.ToString();
            txtValores1.Text = searchBudget.dTotal.ToString();
            txtPrazoGarantia.Text = searchBudget.iWarrantyTime.ToString();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            ClickContractOfObject();
        }
    }
}
