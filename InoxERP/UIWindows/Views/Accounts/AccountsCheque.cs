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
using UIWindows.Entities.Enum;
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

        private void grdCheques_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cleanCamps();
            int compare = grdCheques.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (compare == 0)
            { }
            else
            {
                lblId.Text = grdCheques[0, grdCheques.CurrentRow.Index].Value.ToString();

                ClientsBusiness objC = new ClientsBusiness(ctx);
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
                nudParcelas.Value = Convert.ToDecimal(grdCheques[8, grdCheques.CurrentRow.Index].Value);
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
                    return MessageBox.Show("Confirma a Exclusão do Cheque ?", "Excluir Lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "cash":
                    return MessageBox.Show("Confirma a Baixa do Cheque ?", "Baixar Lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

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

        private DateTime returnDueDate(int instalments, DateTime date)
        {
            DateTime due = date.Date;
            int prazo = Convert.ToInt32(nudPrazo.Value);

            if(instalments == 0 && prazo == 0 && due.Equals(DateTime.Today)) //cheque a vista
                return DateTime.Today;

            if (instalments == 0 && prazo == 0 && !due.Equals(DateTime.Today)) //cheque pré 1 parcela unica dia fixo
                return due;

            if (instalments == 0 && prazo != 0) //cheque pré 1 parcela unica com dias especificados
                return due.AddDays(Convert.ToDouble(prazo));

            if (instalments > 0 && prazo == 0) //cheque pré com varias parcelas em dias fixos nos meses
            {
                due = due.AddMonths(instalments);
                return due;
            }

            if (instalments > 0 && prazo != 0) //cheque pré com varias parcelas com calculo dos dias conforme valor informado
            {
                int i  = instalments + 1;
                due = due.AddDays(Convert.ToDouble(prazo*i));
                return due;
            }

            return DateTime.Now;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (validationCamps())
                if (messageYesNo("confirm") == DialogResult.Yes)
                {
                    InoxErpContext ctxP = new InoxErpContext();
                    ChequesBusiness objPersist = new ChequesBusiness(ctxP);

                    DateTime date = dtpData.Value;

                    for (int i = 0; i < nudParcelas.Value; i++)
                    {
                        Cheques chequePersist = new Cheques
                        {
                            sID = Guid.NewGuid().ToString(),

                            sId_Budgets_OS = returnOS(),
                            sId_Client = returnId(),
                            dValue = Convert.ToDecimal(txtValor.Text.Replace(".", ",")),
                            dtDueDate = returnDueDate(i,date),
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
                            MessageBox.Show("Erro ao Lançar o Cheque !!!");
                        else if(i+1 == nudParcelas.Value)
                            MessageBox.Show("Cheques Lançados com Sucesso !!!");

                    }
                    
                    cleanCamps();
                }

            fillGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (validationCamps())
                if (messageYesNo("alter") == DialogResult.Yes)
                {
                    InoxErpContext ctxA = new InoxErpContext();
                    ChequesBusiness objAlter = new ChequesBusiness(ctxA);
                    Cheques chequeAlter = new Cheques();
                    
                    chequeAlter = objAlter.ReturnByID(lblId.Text);

                    chequeAlter.sId_Budgets_OS = returnOS();
                    chequeAlter.sId_Client = returnId();
                    chequeAlter.dValue = Convert.ToDecimal(txtValor.Text.Replace(".", ","));
                    chequeAlter.dtDueDate = dtpData.Value.Date;
                    chequeAlter.sChequeNumber = returnChequeNumber(1);
                    chequeAlter.sReferentTo = txtReferenteA.Text;
                   

                    objAlter.Update(chequeAlter);

                    var ok = objAlter.Search.FirstOrDefault(b => b.sID == chequeAlter.sID);


                    MessageBox.Show(ok == null ? "Erro ao Alterar o Cheque !!!" : "Cheques Alterado com Sucesso !!!");
                }

            cleanCamps();
            fillGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (messageYesNo("delete") == DialogResult.Yes)
            {
                InoxErpContext ctxD = new InoxErpContext();
                ChequesBusiness objDel = new ChequesBusiness(ctxD);

                objDel.Delete(lblId.Text);

                var ok = objDel.Search.FirstOrDefault(b => b.sID == lblId.Text);

                MessageBox.Show(ok != null ? "Erro ao Excluir o Cheque !!!" : "Cheques Excluído com Sucesso !!!");
            }

            cleanCamps();
            fillGrid();
        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            if (validationCamps())
                if (messageYesNo("cash") == DialogResult.Yes)
                {
                    InoxErpContext ctxC = new InoxErpContext();
                    ChequesBusiness objC = new ChequesBusiness(ctxC);
                    Cheques chequeCash = new Cheques();

                    chequeCash = objC.ReturnByID(lblId.Text);

                    chequeCash.dtPayDate = DateTime.Today;
                    chequeCash.bChequePaid = true;
                    
                    objC.Update(chequeCash);

                    CashBusiness objPersist = new CashBusiness(ctxC);
                    Cash cashPersist = new Cash
                    {
                        sID = Guid.NewGuid().ToString(),

                        sId_Budgets_OS = chequeCash.sId_Budgets_OS,
                        sId_Client = chequeCash.sId_Client,
                        dValue = chequeCash.dValue,
                        dtDate = chequeCash.dtPayDate,
                        sChequeNumber = chequeCash.sChequeNumber,
                        sReferentTo = chequeCash.sReferentTo,
                        CashType = CashType.Enter
                    };

                    objPersist.Insert(cashPersist);

                    var okCash = objPersist.Search.FirstOrDefault(b => b.sID == cashPersist.sID);


                    var okCheq = objC.Search.FirstOrDefault(b => b.sID == chequeCash.sID);
                    
                    MessageBox.Show(okCash == null || okCheq == null ? "Erro ao Baixar o Cheque !!!" : "Cheques Baixado com Sucesso !!!");
                }

            cleanCamps();
            fillGrid();
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
