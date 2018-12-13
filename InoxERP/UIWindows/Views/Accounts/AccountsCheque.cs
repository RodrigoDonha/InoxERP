using System;
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

        ChequesBusiness objCheq = new ChequesBusiness(ctx);
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
                txtNumeroCheque.Text = grdCheques[10, grdCheques.CurrentRow.Index].Value.ToString();
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
            

            if (txtNumeroCheque.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe o Número do Cheque");
                txtNumeroCheque.Focus();
                return false;
            }

            if (txtReferenteA.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um Referencia/Motivo para o Lançamento");
                txtReferenteA.Focus();
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
                    return MessageBox.Show("Confirma o Lançamento no Caixa ?", "Concluir Lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "alter":
                    return MessageBox.Show("Confirma a Alteração do Lançamento no Caixa ?", "Alterar Lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "delete":
                    return MessageBox.Show("Confirma a Exclusçao do Lançamento no Caixa ? \n ***Isso Gera Automaticamente um E" +
                                           "storno no Extrato", "Excluir Lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "refund":
                    return MessageBox.Show("Confirma a Exclusão do Lançamento no Caixa ? \n ***Isso Gera Automaticamente um E" +
                                           "storno no Extrato", "Excluir Lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
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
                msg.Show("Ordem de Serviço", "Não foi possivel encontrar a O.S. Informada, o Sistema irá prosseguir com valores Padrões", 0, 4000);
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
            txtNumeroCheque.Clear();
            txtReferenteA.Clear();
        }

        private string returnChequeNumber(int installment)
        {
            string number = "0";

            frmChequeNumber numCheque = new frmChequeNumber(installment);

            numCheque.ShowDialog();

            if(numCheque.chequeNumber != null)
                number = numCheque.chequeNumber;

            return number;
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
                        Cheques chequePersist = new Cheques()
                        {
                            sID = Guid.NewGuid().ToString(),

                            sId_Budgets_OS = returnOS(),
                            sId_Client = returnId(),
                            dValue = Convert.ToDecimal(txtValor.Text.Replace(".", ",")),
                            dtDueDate = dtpData.Value, // veirficar data
                            dtPayDate = DateTime.Today,
                            bChequePaid = false,
                            iInstallment = i+1,
                            iAmountInstallment = Convert.ToInt32(nudParcelas.Value), //verificar primeira parcela
                            sChequeNumber = returnChequeNumber(i+1),
                            sReferentTo = txtReferenteA.Text
                        };

                        objPersist.Insert(chequePersist);

                        var ok = objPersist.Search.FirstOrDefault(b => b.sID == chequePersist.sID);

                        if (ok == null)
                            MessageBox.Show("Erro ao Lançar a Entrada no Caixa !!!");
                        else if(i == nudParcelas.Value)
                            MessageBox.Show("Entrada Lançada com Sucesso !!!");

                    }
                    
                    cleanCamps();
                    fillGrid();
                }
        }
    }
}
