﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWindows.Business;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;
using UIWindows.Views.Accounts;

namespace UIWindows
{
    public partial class frmAccountsCheque : Form
    {
        static InoxErpContext ctx = new InoxErpContext();

        ClientsBusiness objClient = new ClientsBusiness(ctx);
        Budget_OSBusiness objBudget = new Budget_OSBusiness(ctx);

        ValidationEntries validation = new ValidationEntries();
        MessageBoxTimer msg = new MessageBoxTimer();

        public frmAccountsCheque()
        {
            InitializeComponent();
        }

        private void frmAccountsCheque_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void fillGrid()
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_cheques' table. You can move, or remove it, as needed.
            this.tb_chequesTableAdapter.FillByCheque(this.fullDataSet.tb_cheques);
        }

        private void txtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorLetters(sender,e);

            if (e.KeyChar == 13)
                searcByLike();
        }

        private void txtOrcamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorNumbers(sender,e);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender,e);
        }

        private void txtNumeroCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorNumbersCheque(sender,e);
        }

        private void grdCheques_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cleanCamps();
            int compare = grdCheques.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (compare == 0)
            { }
            else
            {
                ClientsBusiness objC= new ClientsBusiness(ctx);
                ProviderBusiness objP = new ProviderBusiness(ctx);

                string cli = grdCheques[2, grdCheques.CurrentRow.Index].Value.ToString();
                try
                {
                    txtNomeCliente.Text = objC.Search
                        .FirstOrDefault(c => c.sID == cli).sName;
                }
                catch (Exception)
                {
                    try
                    {
                        txtNomeCliente.Text = objP.Search
                            .FirstOrDefault(c => c.sID == cli).sName;
                    }
                    catch (Exception)
                    {
                        txtNomeCliente.Text = "";
                    }
                }

                string id = grdCheques[1, grdCheques.CurrentRow.Index].Value.ToString();

                try
                {
                    txtOS.Text = objBudget.Search
                        .FirstOrDefault(c => c.sID == id).iCod.ToString();
                }
                catch (Exception)
                {
                    txtOS.Text = "";
                }

                dtpData.Text = grdCheques[3, grdCheques.CurrentRow.Index].Value.ToString();
                txtValor.Text = grdCheques[5, grdCheques.CurrentRow.Index].Value.ToString();
                nudParcelas.Value = Convert.ToDecimal(grdCheques[6, grdCheques.CurrentRow.Index].Value);
                string num = grdCheques[10, grdCheques.CurrentRow.Index].Value.ToString();
                try
                {
                    string[] parts = num.Split('-');

                    txtC1.Text = parts[0];
                    txtC2.Text = parts[1];
                    txtC3.Text = parts[2];
                }
                catch (Exception)
                {
                    txtC1.Text = "0";
                    txtC2.Text = "0";
                    txtC3.Text = "0";
                    msg.Show("Cheque", "Número do Cheque Não Encontrado", 0, 1000);
                }
                

                txtReferenteA.Text = grdCheques[9, grdCheques.CurrentRow.Index].Value.ToString();
            }
        }

        private bool validationCamps()
        {
            if (txtValor.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um Valor para o Lançamento");
                txtValor.Focus();
                return false;
            }

            if (txtValor.Text.Equals("0"))
            {
                MessageBox.Show("Informe um Valor Maior Que Zero");
                txtValor.Focus();
                return false;
            }

            if (!validationC1())
                return false;

            if (!validationC2())
                return false;

            if (!validationC3())
                return false;

            if (txtReferenteA.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um Referencia/Motivo para o Lançamento");
                txtReferenteA.Focus();
                return false;
            }

            return true;
        }
        private bool validationC1()
        {
            if (txtC1.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um Valor para o Campo 1");
                txtC1.Focus();
                return false;
            }

            if (txtC1.Text.Length < 8)
            {
                MessageBox.Show("O Campo 1 deve conter 8 Digitos");
                txtC1.Focus();
                return false;
            }

            return true;
        }

        private bool validationC2()
        {
            if (txtC2.Text.Equals("0"))
            {
                MessageBox.Show("Informe um Valor para o Campo 2");
                txtC2.Focus();
                return false;
            }


            if (txtC2.Text.Length < 10)
            {
                MessageBox.Show("O Campo 2 deve conter 10 Digitos");
                txtC2.Focus();
                return false;
            }

            return true;
        }

        private bool validationC3()
        {
            if (txtC3.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um Valor para o Campo 3");
                txtC3.Focus();
                return false;
            }

            if (txtC3.Text.Length < 12)
            {
                MessageBox.Show("O Campo 3 deve conter 12 Digitos");
                txtC3.Focus();
                return false;
            }

            return true;
        }

        //DIALOG OPTIONS
        public DialogResult messageYesNo(string type)
        {
            switch (type)
            {
                case "confirm":
                    return MessageBox.Show("Confirma o Lançamento do Cheque ?", "Concluir Lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "alter":
                    return MessageBox.Show("Confirma a Alteração do Cheque ?", "Alterar Lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "delete":
                    return MessageBox.Show("Confirma a Exclusçao do Cheque ?", "Excluir Lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                
            }
            return DialogResult.No;
        }

        private void searchByName()
        {
            string idClient = "";
            frmClientsSearch clientsSearch = new frmClientsSearch();

            foreach (Control cliControl in clientsSearch.Controls)
            {
                if (cliControl.Name == "btnAbrirAlterar" || cliControl.Name == "btnExcluir" || cliControl.Name == "btnCadastrar")
                    cliControl.Enabled = false;
            }

            clientsSearch.ShowDialog();

            if (clientsSearch.ReturnClients != null)
                idClient = clientsSearch.ReturnClients.sID;

            var chq = from p in ctx.Cheques where p.sId_Client.Equals(idClient) where p.bChequePaid.Equals(false) select p;

            if (chq.ToList().Count.Equals(0))
            {
                if (clientsSearch.ReturnClients == null)
                {
                    msg.Show("Cliente Não Encontrado", "Não foi Encontrado Cliente para este lançamento", 0, 2000);
                }
                else
                {
                    txtNomeCliente.Text = clientsSearch.ReturnClients.sName;
                }

                msg.Show("Lançamento Não Encontrado", "Não foi Encontrado Lançamentos para este Fornecedor", 0, 2000);
                txtNomeCliente.Focus();
            }
            else
            {
                List<Cheques> s = chq.ToList();
                txtNomeCliente.Text = clientsSearch.ReturnClients.sName;
                grdCheques.DataSource = s.ToList();
            }
        }

        private void searcByLike()
        {
            string idClient = txtNomeCliente.Text;
            
            var cli = from p in ctx.Clients where p.sName.Contains(idClient) select p.sID;

            var chq = from p in ctx.Cheques where p.sId_Client.Equals(cli.FirstOrDefault()) where p.bChequePaid.Equals(false) select p;

            if (chq.ToList().Count.Equals(0))
            {
                msg.Show("Lançamento Não Encontrado", "Não foi Encontrado Lançamentos para este Cliente / Fornecedor", 0, 2000);
                fillGrid();
                txtNomeCliente.Focus();
            }
            else
            {
                List<Cheques> s = chq.ToList();
                grdCheques.DataSource = s.ToList();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            searchByName();
        }

        private string returnOS()
        {
            int os = txtOS.Text == "" ? -1 : Convert.ToInt32(txtOS.Text);
            Budgets_OS retID = new Budgets_OS();
            try
            {
                retID = objBudget.Search.FirstOrDefault(c => c.iCod == os);
                if (retID.Equals(null))
                    return null;
            }
            catch (Exception)
            {
                retID = new Budgets_OS();
                retID.sID = "";
                //msg.Show("Ordem de Serviço", "Não foi possivel encontrar a O.S. Informada, o Sistema irá prosseguir com valores Padrões", 0, 4000);
            }
            return retID.sID;
        }

        private string returnId()
        {
            string id = txtNomeCliente.Text == "" ? "0" : txtNomeCliente.Text;
            try
            {
                var searchC = from p in ctx.Clients where p.sName.Contains(id) select p;

                if (!searchC.ToList().Count.Equals(0))
                {
                    List<Clients> c = new List<Clients>();

                    c = searchC.ToList();

                    id = c[0].sID;
                }
                else
                    try
                    {
                        var searchP = from p in ctx.Providers where p.sName.Contains(id) select p;

                        if (!searchP.ToList().Count.Equals(0))
                        {
                            List<Providers> c = new List<Providers>();

                            c = searchP.ToList();

                            id = c[0].sID;
                        }
                        else
                            id = objClient.Search.FirstOrDefault(c => c.sName.Contains("CONSUMIDOR")).sID;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(
                            "Antes de concluir este Lançamento Voçê tem que Cadastrar um Cliente CONSUMIDOR para continuar");
                    }

            }
            catch (Exception)
            { }
            return id;
        }

        private void cleanCamps()
        {
            lblId.Text = "";
            txtNomeCliente.Clear();
            txtOS.Clear();
            txtValor.Clear();
            dtpData.Value = DateTime.Now;
            nudParcelas.Value = 1;
            nudPrazo.Value = 0;
            txtC1.Clear();
            txtC2.Clear();
            txtC3.Clear();
            txtReferenteA.Clear();
        }

        private string returnChequeNumber(int installment)
        {
            string number = "0";
            if (installment > 1)
            {
                frmChequeNumber numCheque = new frmChequeNumber(installment);

                numCheque.ShowDialog();

                if (numCheque.chequeNumber != null)
                    number = numCheque.chequeNumber;
            }else
                number = txtC1.Text + "-" + txtC2.Text + "-" + txtC3.Text;

            return number;
        }

        private DateTime returnDueDate(int instalments)
        {
            if(instalments == 1 && nudPrazo.Value == 0 && dtpData.Value.Equals(DateTime.Now))//cheque a vista
                return DateTime.Now;

            if (instalments == 1 && nudPrazo.Value == 0 && !dtpData.Value.Equals(DateTime.Now))//cheque pré 1 parcela unica dia fixo
                return dtpData.Value;

            if (instalments == 1 && nudPrazo.Value != 0) //cheque pré 1 parcela unica com dias especificados
                return dtpData.Value.AddDays(Convert.ToDouble(nudPrazo.Value));

            if (instalments > 1 && nudPrazo.Value == 0)
                return dtpData.Value.AddMonths(instalments);

            if (instalments > 1 && nudPrazo.Value != 0)
            {
                dtpData.Value.AddDays(Convert.ToDouble(nudPrazo.Value));
                return dtpData.Value.AddMonths(instalments);
            }

            return DateTime.Now;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (validationCamps())
                if (messageYesNo("confirm") == DialogResult.Yes)
                {
                    InoxErpContext ctx = new InoxErpContext();
                    ChequesBusiness objPersist = new ChequesBusiness(ctx);

                    for (int i = 0; i < nudParcelas.Value; i++)
                    {
                        Cheques chequePersist = new Cheques
                        {
                            sID = Guid.NewGuid().ToString(),

                            sId_Budgets_OS = returnOS(),
                            sId_Client = returnId(),
                            dValue = Convert.ToDecimal(txtValor.Text.Replace(".", ",")),
                            dtDueDate = returnDueDate(i+1), // veirficar data ********
                            dtPayDate = DateTime.Today,
                            bChequePaid = false,
                            iInstallment = i+1,
                            iAmountInstallment = Convert.ToInt32(nudParcelas.Value),
                            sChequeNumber = returnChequeNumber(i+1),
                            sReferentTo = txtReferenteA.Text
                        };

                        objPersist.Insert(chequePersist);

                        var ok = objPersist.Search.FirstOrDefault(b => b.sID == chequePersist.sID);

                        if (ok == null)
                            MessageBox.Show("Erro ao Lançar a Entrada no Caixa !!!");
                        else if(i == nudParcelas.Value)
                            MessageBox.Show("Entrada Lançada com Sucesso !!!"); ////verificar confirmação

                    }
                    
                    cleanCamps();
                    fillGrid(); ////verificar fill
                }
        }

        private void txtC1_Leave(object sender, EventArgs e)
        {
            validationC1();
        }

        private void txtC2_Leave(object sender, EventArgs e)
        {
            validationC2();
        }

        private void txtC3_Leave(object sender, EventArgs e)
        {
            validationC3();
        }

        private void txtC1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorNumbersCheque(sender,e);
        }

        private void txtC2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorNumbersCheque(sender,e);
        }

        private void txtC3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorNumbersCheque(sender,e);
        }
    }
}
