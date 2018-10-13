using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
    public partial class frmClientsRegister : Form
    {
        static InoxErpContext ctx = new InoxErpContext();
        ClientsBusiness obj = new ClientsBusiness(ctx);
        ValidationEntries validation = new ValidationEntries();
        string getID;

        public frmClientsRegister(String id)
        {
            getID = "";
            getID = id;
            InitializeComponent();
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
            new frmClientsSearch().Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
            new frmClientsSearch().Show();

            // implementar validadação de campos preenchidos e caso esteja algum campo preenchido, perguntar se tem certeza de cancelar
        }

        

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!validationCamps())
                MessageBox.Show("Por Favor preencha as informações Corretamente");
            else
            {
                if (btnGravar.Text == "Alterar")
                {
                    if (messageYesNo("Alter") == DialogResult.Yes)
                    {
                        if (!validationCamps())
                            MessageBox.Show("Por Favor preencha as informações Corretamente");
                        else
                        {
                            Clients clientsAlter = new Clients();

                            //procura o orçamento para alteração
                            clientsAlter = obj.ReturnByID(getID);

                            //preenche os dados do orçamento
                            clientsAlter.sName = txtNome.Text;
                            clientsAlter.sCpfCnpj = txtCPF_CNPJ.Text;
                            clientsAlter.ClientType = clientType();
                            clientsAlter.sOccupation = txtCargo.Text;
                            clientsAlter.sAdress = txtEndereco.Text;
                            clientsAlter.iNumber = Convert.ToInt32(txtNumEndereco.Text);
                            clientsAlter.sDistrict = txtBairro.Text;
                            clientsAlter.sComplement = txtComplemento.Text;
                            clientsAlter.sCity = txtCidade.Text;
                            clientsAlter.Estate = estate();
                            clientsAlter.sCEP = txtCEP.Text;
                            clientsAlter.sPhoneResidencial = txtContatosResiCom.Text;
                            clientsAlter.sEmail = txtContatosEmail.Text;
                            clientsAlter.sPhoneCelularOne = txtContatosCelular1.Text;
                            clientsAlter.sPhoneCelularTwo = txtContatosCelular2.Text;
                            clientsAlter.sObservation = txtObservacoes.Text;


                            //atualiza
                            obj.Update(clientsAlter);

                            //verifica se o orçamento foi atualizado com sucesso
                            var ok = obj.Search.FirstOrDefault(b => b.sID == clientsAlter.sID);

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
                                new frmClientsSearch().Show();
                            }
                        }
                    }
                }
                else
                {
                    Clients clientsPersist = new Clients();
                    clientsPersist.sID = Guid.NewGuid().ToString();

                    clientsPersist.sName = txtNome.Text;
                    clientsPersist.sCpfCnpj = txtCPF_CNPJ.Text;
                    clientsPersist.ClientType = clientType();
                    clientsPersist.sOccupation = txtCargo.Text;
                    clientsPersist.sAdress = txtEndereco.Text;
                    clientsPersist.iNumber = Convert.ToInt32(txtNumEndereco.Text);
                    clientsPersist.sDistrict = txtBairro.Text;
                    clientsPersist.sComplement = txtComplemento.Text;
                    clientsPersist.sCity = txtCidade.Text;
                    clientsPersist.Estate = estate();
                    clientsPersist.sCEP = txtCEP.Text;
                    clientsPersist.sPhoneResidencial = txtContatosResiCom.Text;
                    clientsPersist.sEmail = txtContatosEmail.Text;
                    clientsPersist.sPhoneCelularOne = txtContatosCelular1.Text;
                    clientsPersist.sPhoneCelularTwo = txtContatosCelular2.Text;
                    clientsPersist.sObservation = txtObservacoes.Text;

                    if (messageYesNo("insert") == DialogResult.Yes)
                    {
                        obj.Insert(clientsPersist);

                        var ok = obj.Search.FirstOrDefault(b => b.sID == clientsPersist.sID);

                        if (ok == null)
                            MessageBox.Show("Erro ao Cadastrar o Cliente !!!");
                        else
                            MessageBox.Show("Cliente: " + clientsPersist.sName.ToString() + " Cadastrado com Sucesso !!!");

                        afterAction();
                    }
                }
            }
        }

        public DialogResult messageYesNo(string type)
        {
            switch (type)
            {
                case "insert":
                    return MessageBox.Show("Confirma a inclusão ?", "Salvar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "update":
                    return MessageBox.Show("Confirma a atualização ?", "Atualizar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "delete":
                    return MessageBox.Show("Confirma a Exclusão ?", "Excluir", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "Alter":
                    return MessageBox.Show("Confirma a Alteração ?", "Alterar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }

            return DialogResult.No;
        }

        //RETURN ClientType
        public ClientType clientType()
        {
            if (radComercial.Checked)
                return ClientType.Comercial;
            if (radIndustrial.Checked)
                return ClientType.Industrial;
            if (radResidencial.Checked)
                return ClientType.Residencial;

            return 0;
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
            radResidencial.Checked = false;
            radComercial.Checked = false;
            radIndustrial.Checked = false;
            txtEndereco.Clear();
            txtNumEndereco.Clear();
            txtBairro.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            cmbEstate.SelectedIndex = -1;
            txtCEP.Clear();
            txtContatosResiCom.Clear();
            txtContatosEmail.Clear();
            txtContatosCelular1.Clear();
            txtContatosCelular2.Clear();
            txtObservacoes.Clear();
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
                MessageBox.Show("Informe um Nome para o Cliente");
                txtNome.Focus();
                return false;
            }

            if (txtCPF_CNPJ.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe o CPF / CNPJ para o Cliente");
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

            if (txtContatosResiCom.Text.Length.Equals(0) & txtContatosCelular1.Text.Length.Equals(0) &
                txtContatosCelular2.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um Telefone");
                return false;
            }

            //if (txtContatosEmail.Text.Length.Equals(0))
            //{
            //    MessageBox.Show("Informe um E-mail");
            //    return false;
            //}

            return true;
        }

        public void completeRegister(string id)
        {
            Clients cli = new Clients();
            cli = obj.ReturnByID(id);

            getID = "";
            getID = cli.sID;
            txtNome.Text = cli.sName;
            txtCPF_CNPJ.Text = cli.sCpfCnpj;
            Type(cli);
            txtCargo.Text = cli.sOccupation;
            txtEndereco.Text = cli.sAdress;
            txtNumEndereco.Text = cli.iNumber.ToString();
            txtBairro.Text = cli.sDistrict;
            txtComplemento.Text = cli.sComplement;
            txtCidade.Text = cli.sCity;
            cmbEstate.Text = cli.Estate.ToString();
            txtCEP.Text = cli.sCEP;
            txtContatosResiCom.Text = cli.sPhoneResidencial;
            txtContatosCelular1.Text = cli.sPhoneCelularOne;
            txtContatosCelular2.Text = cli.sPhoneCelularTwo;
            txtContatosEmail.Text = cli.sEmail;
            txtObservacoes.Text = cli.sObservation;

            btnGravar.Text = "Alterar";
        }

        //RETURN ClientType
        public void Type(Clients cli)
        {

            if (cli.ClientType == ClientType.Comercial)
            {
                radComercial.Checked = true;
            }else if (cli.ClientType == ClientType.Residencial)
            {
                radResidencial.Checked = true;
            }
            else if (cli.ClientType == ClientType.Industrial)
            {
                radIndustrial.Checked = true;
            }
        }

        public bool validationCampsNumber(object sender, EventArgs e)
        {
            //teste = teste.Remove(teste.Lenght - 1);
            var obj = sender;
            var eve = e;
            return true;
        }

        private void txtCPF_CNPJ_TextChanged(object sender, EventArgs e)
        {
            validationCampsNumber(sender, e);
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
    }
}
