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

namespace UIWindows
{
    public partial class frmAccountsSearch : Form
    {
        MessageBoxTimer msg = new MessageBoxTimer();

        public frmAccountsSearch()
        {
            InitializeComponent();
        }

        private void frmAccountsSearch_Load(object sender, EventArgs e)
        {
            fillByReceived();
            fillByPaied();
            fillByCheque();
        }

        private void fillByCheque()
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_cheques' table. You can move, or remove it, as needed.
            this.tb_chequesTableAdapter.FillByChequesReveiced(this.fullDataSet.tb_cheques);
            dgvCheques.Columns[0].Visible = false;
        }

        private void fillByPaied()
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_accountsToPay' table. You can move, or remove it, as needed.
            this.tb_accountsToPayTableAdapter.FillByAccountsPaied(this.fullDataSet.tb_accountsToPay);
            dgvPagos.Columns[0].Visible = false;
        }

        private void fillByReceived()
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_accountsToReceive' table. You can move, or remove it, as needed.
            this.tb_accountsToReceiveTableAdapter.FillByAccountReceived(this.fullDataSet.tb_accountsToReceive);
            dgvRecebidos.Columns[0].Visible = false;
        }

        //DIALOG OPTIONS
        public DialogResult messageYesNo(string type)
        {
            switch (type)
            {
                case "refund":
                    return MessageBox.Show("Confirma o Estorno da Conta ? \n ***Isso Gera Automaticamente um E" +
                                           "storno no Extrato", "Estornar Conta", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }

            return DialogResult.No;
        }

        private string returIdPagos()
        {
            string id = "";
            try
            {
                id = dgvPagos[0, dgvPagos.CurrentRow.Index].Value.ToString();
            }
            catch (Exception)
            {}

            return id;
        }

        private string returIdRecebidos()
        {
            string id = "";
            try
            {
                id = dgvRecebidos[0, dgvRecebidos.CurrentRow.Index].Value.ToString();
            }
            catch (Exception)
            { }

            return id;
        }

        private string returIdCheques()
        {
            string id = "";
            try
            {
                id = dgvCheques[0, dgvCheques.CurrentRow.Index].Value.ToString();
            }
            catch (Exception)
            { }

            return id;
        }

        private void btnEstornarPagos_Click(object sender, EventArgs e)
        {
            string id = returIdPagos();

            if (!id.Equals(""))
            {
                if (messageYesNo("refund") == DialogResult.Yes)
                {
                    InoxErpContext ctxR = new InoxErpContext();
                    AccountsToPayBusiness objRef = new AccountsToPayBusiness(ctxR);
                    AccountsToPay accRef = new AccountsToPay();

                    accRef = objRef.ReturnByID(id);

                    accRef.bReceivePaid = false;

                    objRef.Update(accRef);

                    CashBusiness objPersist = new CashBusiness(ctxR);

                    Cash cash = new Cash
                    {
                        sId_Budgets_OS = accRef.sId_Budgets_OS,
                        sId_Client = accRef.sId_Client,
                        dValue = accRef.dValue,
                        dtDate = DateTime.Now,
                        sChequeNumber = "0",
                        sReferentTo = "ESTORNO REFERENTE: " + accRef.sReferentTo,
                        CashType = CashType.Enter,
                        sID = Guid.NewGuid().ToString()
                    };

                    objPersist.Insert(cash);

                    var up = objRef.Search.FirstOrDefault(b => b.sID == accRef.sID);

                    var ins = objPersist.Search.FirstOrDefault(b => b.sID == cash.sID);

                    if (up == null || ins == null)
                        MessageBox.Show("Erro ao Estornar a Conta !!!");
                    else
                        MessageBox.Show("Conta Estornada com Sucesso !!!");
                }
            }else
                msg.Show("Selecione uma Conta", "Selecione uma conta para estornar !!!", 0, 2000);

            fillByPaied();
        }

        private void btnEstornarRecebidos_Click(object sender, EventArgs e)
        {
            string id = returIdRecebidos();

            if (!id.Equals(""))
            {
                if (messageYesNo("refund") == DialogResult.Yes)
                {
                    InoxErpContext ctxR = new InoxErpContext();
                    AccountsToReceiveBusiness objRef = new AccountsToReceiveBusiness(ctxR);
                    AccountsToReceive accRef = new AccountsToReceive();

                    accRef = objRef.ReturnByID(id);

                    accRef.bReceivePaid = false;

                    objRef.Update(accRef);

                    CashBusiness objPersist = new CashBusiness(ctxR);

                    Cash cash = new Cash
                    {
                        sId_Budgets_OS = accRef.sId_Budgets_OS,
                        sId_Client = accRef.sId_Client,
                        dValue = accRef.dValue,
                        dtDate = DateTime.Now,
                        sChequeNumber = "0",
                        sReferentTo = "ESTORNO REFERENTE: " + accRef.sReferentTo,
                        CashType = CashType.Out,
                        sID = Guid.NewGuid().ToString()
                    };

                    objPersist.Insert(cash);

                    var up = objRef.Search.FirstOrDefault(b => b.sID == accRef.sID);

                    var ins = objPersist.Search.FirstOrDefault(b => b.sID == cash.sID);

                    if (up == null || ins == null)
                        MessageBox.Show("Erro ao Estornar a Conta !!!");
                    else
                        MessageBox.Show("Conta Estornada com Sucesso !!!");
                }
            }
            else
                msg.Show("Selecione uma Conta", "Selecione uma conta para estornar !!!", 0, 2000);

            fillByReceived();
        }

        private void btnEstornarCheque_Click(object sender, EventArgs e)
        {
            string id = returIdCheques();

            if (!id.Equals(""))
            {
                if (messageYesNo("refund") == DialogResult.Yes)
                {
                    InoxErpContext ctxR = new InoxErpContext();
                    ChequesBusiness objRef = new ChequesBusiness(ctxR);
                    Cheques accRef = new Cheques();

                    accRef = objRef.ReturnByID(id);

                    accRef.bChequePaid = false;

                    objRef.Update(accRef);

                    CashBusiness objPersist = new CashBusiness(ctxR);

                    Cash cash = new Cash
                    {
                        sId_Budgets_OS = accRef.sId_Budgets_OS,
                        sId_Client = accRef.sId_Client,
                        dValue = accRef.dValue,
                        dtDate = DateTime.Now,
                        sChequeNumber = accRef.sChequeNumber,
                        sReferentTo = "ESTORNO REFERENTE: " + accRef.sReferentTo,
                        CashType = CashType.Out,
                        sID = Guid.NewGuid().ToString()
                    };

                    objPersist.Insert(cash);

                    var up = objRef.Search.FirstOrDefault(b => b.sID == accRef.sID);

                    var ins = objPersist.Search.FirstOrDefault(b => b.sID == cash.sID);

                    if (up == null || ins == null)
                        MessageBox.Show("Erro ao Estornar o Cheque !!!");
                    else
                        MessageBox.Show("Cheque Estornado com Sucesso !!!");
                }
            }
            else
                msg.Show("Selecione um Cheque", "Selecione um Cheque para estornar !!!", 0, 2000);

            fillByCheque();
        }
    }
}
