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
        ValidationEntries validation = new ValidationEntries();

        private string id;

        
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
                if (btnGravar.Text == "Alterar")
                {
                    if (messageYesNo("alter") == DialogResult.Yes)
                    {
                        if (!validationCamps())
                            MessageBox.Show("Por Favor preencha as informações Corretamente");
                        else
                        {
                            Providers providersAlter = new Providers();
                            
                            //procura o orçamento para alteração
                            providersAlter = obj.returnById(id);

                            //preenche os dados do orçamento
                            providersAlter.sName = txtNome.Text;
                            providersAlter.sCpfCnpj = txtCPF_CNPJ.Text;
                            providersAlter.sAdress = txtEndereco.Text;
                            providersAlter.iNumber = Convert.ToInt32(txtNumEndereco.Text);
                            providersAlter.sDistrict = txtBairro.Text;
                            providersAlter.sComplement = txtComplemento.Text;
                            providersAlter.sCity = txtCidade.Text;
                            providersAlter.Estate = validation.estate(cmbEstate.SelectedIndex);
                            providersAlter.sCEP = txtCEP.Text;
                            providersAlter.sPhoneComercial = txtContatosComercial.Text;
                            providersAlter.sEmail = txtContatosEmail.Text;
                            providersAlter.sPhoneCelularOne = txtContatosCelular1.Text;
                            providersAlter.sPhoneCelularTwo = txtContatosCelular2.Text;
                            providersAlter.sBank = txtBanco.Text;
                            providersAlter.sAgency = txtAgencia.Text;
                            providersAlter.sAccount = txtConta.Text;
                            providersAlter.sFavored = txtFavorecido.Text;
                            providersAlter.sCpfCnpjFavored = txtCpfCnpj.Text;
                            if (txtCompraMinima.Text == "")
                            {
                                providersAlter.dMinimumPurchase = Convert.ToDecimal("0.00");
                            }
                            else
                            {
                                providersAlter.dMinimumPurchase = Convert.ToDecimal(txtCompraMinima.Text);
                            }

                            providersAlter.sObservation = txtObservacoes.Text;


                            //atualiza
                            obj.Update(providersAlter);

                            //verifica se o orçamento foi atualizado com sucesso
                            var ok = obj.Search.FirstOrDefault(b => b.sID == providersAlter.sID);

                            if (ok == null)
                                MessageBox.Show("Erro ao Atualizar o Orçamento !!!");
                            else
                            {
                                MessageBox.Show("Orçamento Atualizado com Sucesso !!!");
                                btnGravar.Text = "Gravar";

                                cleanCamps();

                                //fecha a tela de alteração
                                Dispose();

                                //abre tela de consulta novamente
                                new frmProviderSearch().Show();
                            }
                        }
                    }
                }
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
                    ProvidersPersist.Estate = validation.estate(cmbEstate.SelectedIndex);
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
                            MessageBox.Show("Fornecedor: " + ProvidersPersist.sName.ToString() +
                                            " Cadastrado com Sucesso !!!");

                        afterAction();
                        Dispose();
                    }
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
                case "alter":
                    return MessageBox.Show("Confirma a alteração ?", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }

            return DialogResult.No;
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

            if (txtContatosComercial.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um Telefone Comercial");
                return false;
            }

            //if (txtContatosComercial.Text.Length.Equals(0) & txtContatosCelular1.Text.Length.Equals(0) & txtContatosCelular2.Text.Length.Equals(0))
            //{
            //    MessageBox.Show("Informe um Telefone");
            //    return false;
            //}

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


        public void completeRegister(string id)
        {
            this.id = "";
            this.id = id;
            Providers prov = new Providers();
            prov = obj.returnById(id);
            txtNome.Text = prov.sName;
            txtCPF_CNPJ.Text = prov.sCpfCnpj;
            txtEndereco.Text = prov.sAdress;
            txtNumEndereco.Text = prov.iNumber.ToString();
            txtBairro.Text = prov.sDistrict;
            txtComplemento.Text = prov.sComplement;
            txtCidade.Text = prov.sCity;
            cmbEstate.Text = prov.Estate.ToString();
            txtCEP.Text = prov.sCEP;
            txtContatosComercial.Text = prov.sPhoneComercial;
            txtContatosEmail.Text = prov.sEmail;
            txtContatosCelular1.Text = prov.sPhoneCelularOne;
            txtContatosCelular2.Text = prov.sPhoneCelularTwo;
            txtBanco.Text = prov.sBank;
            txtAgencia.Text = prov.sAgency;
            txtConta.Text = prov.sAccount;
            txtFavorecido.Text = prov.sFavored;
            txtCpfCnpj.Text = prov.sCpfCnpjFavored;
            txtCompraMinima.Text = prov.dMinimumPurchase.ToString();
            txtObservacoes.Text = prov.sObservation;
            
            btnGravar.Text = "Alterar";
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
            validation.characterValidatorOnlyNumbersAndComma(sender, e);
        }

        public void validationEntriesPhones(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyPhones(sender, e);
        }

        private void btnCopiarDadosEmpresa_Click(object sender, EventArgs e)
        {
            txtFavorecido.Text = txtNome.Text;
            txtCpfCnpj.Text = txtCPF_CNPJ.Text;
        }
    }
}
