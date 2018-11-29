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
            fillContractOfObject();
            btnProximo.Text = "Próximo";
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

        public void fillContractOfObject()
        {
            if (searchBudget.IdClients != null)
            {
                string idClient = searchBudget.IdClients;
                cli = clients.ReturnByID(idClient);
                txtNomeC.Text = cli.sName;
                txtCpfCnpjC.Text = cli.sCpfCnpj;
                txtRgC.Text = cli.sRg;
                txtCepC.Text = cli.sCEP;
                txtEnderecoC.Text = cli.sAdress;
                txtNumeroC.Text = cli.iNumber.ToString();
                txtBairroC.Text = cli.sDistrict;
                txtCidadeC.Text = cli.sCity;
                cbxEstate.Text = cli.Estate.ToString();
            }
            else
            {
                txtNomeC.Text = searchBudget.sName;
                txtEnderecoC.Text = searchBudget.sAdress;                
            }

            txtDescription.Text = searchBudget.sObservation;
            txtValores.Text = searchBudget.dTotal.ToString();
            txtValores1.Text = searchBudget.dTotal.ToString();
            txtPrazoGarantia.Text = searchBudget.iWarrantyTime.ToString();
            txtPrazo1.Text = Convert.ToString(searchBudget.iPrevisionOfExecute);
            txtPrazo2.Text = Convert.ToString(searchBudget.iPrevisionOfExecute);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            ConfirmPositionTab();
        }

        public void ConfirmPositionTab()
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                btnProximo.Text = "Próximo";
                tabControl1.SelectedTab = tabPage2;
                
            } else if(tabControl1.SelectedTab == tabPage2)
            {
                btnProximo.Text = "Próximo";
                tabControl1.SelectedTab = tabPage3;
            } else if (tabControl1.SelectedTab == tabPage3)
            {
                btnProximo.Text = "Gravar";
                tabControl1.SelectedTab = tabPage4;
            }else if (tabControl1.SelectedTab == tabPage4)
            {
                // implementar aqui o gravar contrato
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                btnProximo.Text = "Próximo";
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                btnProximo.Text = "Próximo";
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                btnProximo.Text = "Próximo";
            }
            if (tabControl1.SelectedTab == tabPage4)
            {
                btnProximo.Text = "Gravar";
            }
        }

        private void btnAlterarContratado_Click(object sender, EventArgs e)
        {
            if (txtNomeContratado.Text == "RICHARD CARLOS REGGIANI")
            {
                txtNomeContratado.Text = "LUCAS BEIRIGO REGGIANI";
                txtCpfCnpjContratado.Text = "30.286.217/0001-70";
                txtRgContratado.Text = "093967599-45";
                txtCepContratado.Text = "19065-510";
                txtEnderecoContratado.Text = "AV. DAS FLORES";
                txtNumeroContratado.Text = "210";
                txtBairroContratado.Text = "CECAP";
                txtCidadeContratado.Text = "PRESIDENTE PRUDENTE";
                cbxEstateContratado.Text = "SP"; 
            }
            else
            {
                txtNomeContratado.Text = "RICHARD CARLOS REGGIANI";
                txtCpfCnpjContratado.Text = "31.210.732/0001-30";
                txtRgContratado.Text = "";
                txtCepContratado.Text = "19045-333";
                txtEnderecoContratado.Text = "RUA ROTARY CLUBE DE PRESIDENTE PRUDENTE-ALVOR";
                txtNumeroContratado.Text = "25";
                txtBairroContratado.Text = "VILA ROTARIA \"ARCH C. KLUMPH\"";
                txtCidadeContratado.Text = "PRESIDENTE PRUDENTE";
                cbxEstateContratado.Text = "SP";
            }
        }

        public void gravarContrato()
        {
            // implementar aqui a gravação do contrato e passar essa função na função ConfirmPositionTab()
        }
    }
}
