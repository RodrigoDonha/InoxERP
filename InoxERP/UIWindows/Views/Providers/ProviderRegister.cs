using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWindows;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;
using UIWindows.Entities.Enum;

namespace InoxERP.UI_Windows_Forms
{
    public partial class frmProviderRegister : Form
    {
        static InoxErpContext ctx = new InoxErpContext();
        ProviderBusiness obj = new ProviderBusiness(ctx);

        
        public frmProviderRegister()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
            new frmProviderSearch().Show();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
            new frmProviderSearch().Show();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!validationCamps())
                MessageBox.Show("Por Favor preencha as informações Corretamente");
            else
            {
                Providers ProvidersPersist = new Providers();
                ProvidersPersist.sID = Guid.NewGuid().ToString();

                ProvidersPersist.sName = txtNome.Text;
                ProvidersPersist.sCpfCnpj = txtCPF_CNPJ.Text;
                ProvidersPersist.sAdress = txtEndereco.Text;
                ProvidersPersist.iNumber = Convert.ToInt32(txtNumEndereco.Text);
                ProvidersPersist.sDistrict = txtBairro.Text;
                ProvidersPersist.sComplement = txtComplemento.Text;
                ProvidersPersist.sCity = txtCidade.Text;
                ProvidersPersist.Estate = estate();
                ProvidersPersist.sCEP = txtCEP.Text;
                ProvidersPersist.sPhoneComercial = txtContatosComercial.Text;
                ProvidersPersist.sEmail = txtContatosEmail.Text;
                ProvidersPersist.sPhoneCelularOne = txtContatosCelular1.Text;
                ProvidersPersist.sPhoneCelularTwo = txtContatosCelular2.Text;
                ProvidersPersist.sBank = txtBanco.Text;
                ProvidersPersist.sAgency = txtAgencia.Text;
                ProvidersPersist.sAccount = txtConta.Text;
                ProvidersPersist.sFavored = txtFavorecido.Text;
                ProvidersPersist.sCpfCnpjFavored = txtCpfCnpj.Text;
                if (txtCompraMinima.Text == "")
                {
                    ProvidersPersist.dMinimumPurchase = Convert.ToDecimal("0.00");
                }
                else
                {
                    ProvidersPersist.dMinimumPurchase = Convert.ToDecimal(txtCompraMinima.Text);
                }
                ProvidersPersist.sObservation = txtObservacoes.Text;

                if (messageYesNo("insert") == DialogResult.Yes)
                {
                    obj.Insert(ProvidersPersist);

                    var ok = obj.Search.FirstOrDefault(b => b.sID == ProvidersPersist.sID);

                    if (ok == null)
                        MessageBox.Show("Erro ao Cadastrar o Fornecedor !!!");
                    else
                        MessageBox.Show("Fornecedor: " + ProvidersPersist.sName.ToString() + " Cadastrado com Sucesso !!!");

                    afterAction();
                }
            }
        }

        public void afterAction()
        {
            cleanCamps();
        }

        //CLEAN
        public void cleanCamps()
        {
            txtNome.Clear();
            txtCPF_CNPJ.Clear();
            txtEndereco.Clear();
            txtNumEndereco.Clear();
            txtBairro.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            cmbEstate.SelectedIndex = -1;
            txtCEP.Clear();
            txtContatosComercial.Clear();
            txtContatosEmail.Clear();
            txtContatosCelular1.Clear();
            txtContatosCelular2.Clear();
            txtBanco.Clear();
            txtAgencia.Clear();
            txtConta.Clear();
            txtFavorecido.Clear();
            txtCpfCnpj.Clear();
            txtCompraMinima.Clear();
            txtObservacoes.Clear();
        }

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

        public Estate estate()
        {
            switch (Convert.ToInt32(cmbEstate.SelectedIndex.ToString()))
            {
                case 0: return Estate.AC;
                case 1: return Estate.AI;
                case 2: return Estate.AP;
                case 3: return Estate.AM;
                case 4: return Estate.BA;
                case 5: return Estate.CE;
                case 6: return Estate.DF;
                case 7: return Estate.ES;
                case 8: return Estate.GO;
                case 9: return Estate.MA;
                case 10: return Estate.MT;
                case 11: return Estate.MS;
                case 12: return Estate.MG;
                case 13: return Estate.PA;
                case 14: return Estate.PB;
                case 15: return Estate.PR;
                case 16: return Estate.PE;
                case 17: return Estate.PI;
                case 18: return Estate.RJ;
                case 19: return Estate.RN;
                case 20: return Estate.RS;
                case 21: return Estate.RO;
                case 22: return Estate.RR;
                case 23: return Estate.SC;
                case 24: return Estate.SP;
                case 25: return Estate.SE;
                case 26: return Estate.TO;
            }
            return 0;
        }

        public bool validationCamps()
        {
            if (txtNome.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um Nome para o Fornecedor");
                txtNome.Focus();
                return false;
            }

            if (txtCPF_CNPJ.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe o CPF / CNPJ para o Fornecedor");
                txtCPF_CNPJ.Focus();
                return false;
            }

            if (txtEndereco.Text == "0")
            {
                MessageBox.Show("Informe um Endereço");
                txtEndereco.Focus();
            }

            if (txtNumEndereco.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um número para o endereço");
                txtNumEndereco.Focus();
                return false;
            }

            if (txtBairro.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe o Bairro");
                txtBairro.Focus();
                return false;
            }

            //if (txtComplemento.Text.Length.Equals(0))
            //{
            //    MessageBox.Show("Informe um complemento");
            //    return false;
            //}

            if (txtCidade.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe uma Cidade");
                return false;
            }

            if (cmbEstate.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um Estado");
                return false;
            }

            if (txtCEP.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe uma CEP");
                return false;
            }

            if (txtCidade.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe uma Cidade");
                return false;
            }

            if (txtContatosComercial.Text.Length.Equals(0) & txtContatosCelular1.Text.Length.Equals(0) & txtContatosCelular2.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um Telefone");
                return false;
            }

            //if (txtContatosEmail.Text.Length.Equals(0))
            //{
            //    MessageBox.Show("Informe um E-mail");
            //    return false;
            //}

            //if (txtBanco.Text.Length.Equals(0))
            //{
            //    MessageBox.Show("Informe o Banco");
            //    return false;
            //}

            //if (txtAgencia.Text.Length.Equals(0))
            //{
            //    MessageBox.Show("Informe a Agencia");
            //    return false;
            //}

            //if (txtConta.Text.Length.Equals(0))
            //{
            //    MessageBox.Show("Informe a Conta");
            //    return false;
            //}

            //if (txtFavorecido.Text.Length.Equals(0))
            //{
            //    MessageBox.Show("Informe o Favorecido");
            //    return false;
            //}

            //if (txtCpfCnpj.Text.Length.Equals(0))
            //{
            //    MessageBox.Show("Informe o CPF / CNPJ do Favorecido");
            //    return false;
            //}

            //if (txtCompraMinima.Text.Length.Equals(0))
            //{
            //    MessageBox.Show("Informe o valor da Compra Mínima");
            //    return false;
            //}

            return true;
        }
    }
}
