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
    public partial class frmClientsRegister : Form
    {
        static InoxErpContext ctx = new InoxErpContext();
        ClientsBusiness obj = new ClientsBusiness(ctx);

        public frmClientsRegister()
        {
            InitializeComponent();
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
                case 1: return Estate.AC;
                case 2: return Estate.AI;
                case 3: return Estate.AP;
                case 4: return Estate.AM;
                case 5: return Estate.BA;
                case 6: return Estate.CE;
                case 7: return Estate.DF;
                case 8: return Estate.ES;
                case 9: return Estate.GO;
                case 10: return Estate.MA;
                case 11: return Estate.MT;
                case 12: return Estate.MS;
                case 13: return Estate.MG;
                case 14: return Estate.PA;
                case 15: return Estate.PB;
                case 16: return Estate.PR;
                case 17: return Estate.PE;
                case 18: return Estate.PI;
                case 19: return Estate.RJ;
                case 20: return Estate.RN;
                case 21: return Estate.RS;
                case 22: return Estate.RO;
                case 23: return Estate.RR;
                case 24: return Estate.SC;
                case 25: return Estate.SP;
                case 26: return Estate.SE;
                case 27: return Estate.TO;
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
    }
}
