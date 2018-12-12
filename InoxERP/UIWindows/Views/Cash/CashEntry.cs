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
using UIWindows.Entities.Enum;

namespace UIWindows
{
    public partial class frmCashEntry : Form
    {
        static InoxErpContext ctx = new InoxErpContext();

        ClientsBusiness objClient = new ClientsBusiness(ctx);
        Budget_OSBusiness objBudget = new Budget_OSBusiness(ctx);

        ValidationEntries validation = new ValidationEntries();
        MessageBoxTimer msg = new MessageBoxTimer();

        public frmCashEntry()
        {
            InitializeComponent();
        }

        public void validationEntriesNumerics(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorOnlyNumbers(sender, e);
        }

        private void frmCashEntry_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void fillGrid()
        {
            // TODO: This line of code loads data into the 'fullDataSet.tb_cash' table. You can move, or remove it, as needed.
            this.tb_cashTableAdapter.FillByCashEntry(this.fullDataSet.tb_cash);
        }

        private void txtOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorNumbers(sender,e);
        }

        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorLetters(sender,e);
        }

        private void txtNumCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.characterValidatorNumbersCheque(sender,e);
        }

        private void grdEntradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int compare = grdEntradas.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (compare == 0)
            { }
            else
            {
                InoxErpContext ctxS = new InoxErpContext();

                ClientsBusiness objS = new ClientsBusiness(ctxS);

                string id = grdEntradas[1, grdEntradas.CurrentRow.Index].Value.ToString();
                try
                {
                    txtOS.Text = objBudget.Search
                        .FirstOrDefault(c => c.sID == id).iCod.ToString();
                }
                catch (Exception)
                {
                    txtOS.Text = "";
                }

                lblId.Text = grdEntradas[0, grdEntradas.CurrentRow.Index].Value.ToString();

                string cli = grdEntradas[2, grdEntradas.CurrentRow.Index].Value.ToString();
                txtNomeCliente.Text = objS.Search
                    .FirstOrDefault(c => c.sID == cli).sName.ToString();
                
                txtValor.Text = grdEntradas[4, grdEntradas.CurrentRow.Index].Value.ToString();
                dtpData.Text = grdEntradas[3, grdEntradas.CurrentRow.Index].Value.ToString();
                txtNumCheque.Text = grdEntradas[7, grdEntradas.CurrentRow.Index].Value.ToString();
                txtReferenteA.Text = grdEntradas[5, grdEntradas.CurrentRow.Index].Value.ToString();
            }
        }


        //validators CAMPS frm
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

            if (txtNumCheque.Text.Length.Equals(0))
            {
                txtNumCheque.Text = "0";
            }

            if (txtReferenteA.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um Referencia/Motivo para o Lançamento");
                txtReferenteA.Focus();
                return false;
            }

            return true;
        }

        private string returnId()
        {
            string id = txtNomeCliente.Text == "" ? "0" : txtNomeCliente.Text;
            try
            {
                var search = from p in ctx.Clients where p.sName.Contains(id) select p;

                if (!search.ToList().Count.Equals(0))
                {
                    List<Clients> c = new List<Clients>();

                    c = search.ToList();

                    id = c[0].sID;
                }else
                    try
                    {
                        id = objClient.Search.FirstOrDefault(c => c.sName.Contains("CONSUMIDOR")).sID;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(
                            "Antes de concluir este Lançamento Voçê tem que Cadastrar um Cliente CONSUMIDOR para continuar");
                    }

            }
            catch (Exception)
            {}
            return id;
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
                msg.Show("Ordem de Srviço", "Não foi possivel encontrar a O.S. Informada, o Sistema irá prosseguir com valores Padrões", 0, 4000);
            }
            return retID.sID;
        }

        private void cleanCamps()
        {
            lblId.Text = "";
            txtOS.Clear();
            txtNomeCliente.Clear();
            txtValor.Clear();
            dtpData.Value = DateTime.Now;
            txtNumCheque.Clear();
            txtReferenteA.Clear();
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
                    return MessageBox.Show("Confirma a Exclusão do Lançamento no Caixa ? \n ***Isso Gera Automaticamente um E" +
                                           "storno no Extrato", "Excluir Lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "refund":
                    return MessageBox.Show("Confirma a Exclusão do Lançamento no Caixa ? \n ***Isso Gera Automaticamente um E" +
                                           "storno no Extrato", "Excluir Lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            return DialogResult.No;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (validationCamps())
                if (messageYesNo("confirm") == DialogResult.Yes)
                {
                    InoxErpContext ctx = new InoxErpContext();
                    CashBusiness objPersist = new CashBusiness(ctx);
                    Cash cashPersist = new Cash
                    {
                        sID = Guid.NewGuid().ToString(),

                        sId_Budgets_OS = returnOS(),
                        sId_Client = returnId(),
                        dValue = Convert.ToDecimal(txtValor.Text.Replace(".", ",")),
                        dtDate = dtpData.Value,
                        sChequeNumber = txtNumCheque.Text,
                        sReferentTo = txtReferenteA.Text,
                        CashType = CashType.Enter
                    };

                    objPersist.Insert(cashPersist);

                    var ok = objPersist.Search.FirstOrDefault(b => b.sID == cashPersist.sID);

                    if (ok == null)
                        MessageBox.Show("Erro ao Lançar a Entrada no Caixa !!!");
                    else
                        MessageBox.Show("Entrada Lançada com Sucesso !!!");

                    cleanCamps();
                    fillGrid();
                }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (validationCamps())
                if (!checkRefund())
                    if (messageYesNo("alter") == DialogResult.Yes)
                    {
                        InoxErpContext ctxA = new InoxErpContext();
                        CashBusiness objALter = new CashBusiness(ctxA);
                        Cash cashAlter = new Cash();
                        
                        cashAlter = objALter.ReturnByID(getIdGRD());

                        cashAlter.sId_Budgets_OS = returnOS();
                        cashAlter.sId_Client = returnId();
                        cashAlter.dValue = Convert.ToDecimal(txtValor.Text.Replace(".", ","));
                        cashAlter.dtDate = dtpData.Value;
                        cashAlter.sChequeNumber = txtNumCheque.Text;
                        cashAlter.sReferentTo = txtReferenteA.Text;
                        cashAlter.CashType = CashType.Enter;
                    
                        
                        objALter.Update(cashAlter);

                        var ok = objALter.Search.FirstOrDefault(b => b.sID == cashAlter.sID);

                        if (ok == null)
                            MessageBox.Show("Erro ao Alterar a Entrada no Caixa !!!");
                        else
                            MessageBox.Show("Entrada Alterada com Sucesso !!!");

                        cleanCamps();
                        fillGrid();
                    }
        }


        private bool checkRefund()
        {
            string text = grdEntradas[5, grdEntradas.CurrentRow.Index].Value.ToString();
            if (text.Contains("ESTORNADO") || text.Contains("ESTORNO"))
            {
                msg.Show("Exclusão de Estorno", "Não é possível Alterar ou Excluir um ESTORNO DE LANÇAMENTO", 0, 2000);
                return true;
            }
            return false;
        }

        private string getIdGRD()
        {
            string id = lblId.Text;
            
            return id;
        }

        private void btnEstornar_Click(object sender, EventArgs e)
        {
            if (lblId.Text.Equals(""))
                MessageBox.Show("Selecione um Lançamento Primeiro");
            else if(!checkRefund())
                    if (messageYesNo("refund") == DialogResult.Yes)
                    {
                        InoxErpContext ctxD = new InoxErpContext();
                        CashBusiness objDel = new CashBusiness(ctxD);
                        Cash cashDel = new Cash();
                    
                        cashDel = objDel.ReturnByID(getIdGRD());

                        cashDel.sId_Budgets_OS = returnOS();
                        cashDel.sId_Client = returnId();
                        cashDel.dValue = Convert.ToDecimal(txtValor.Text.Replace(".", ","));
                        cashDel.dtDate = dtpData.Value;
                        cashDel.sChequeNumber = txtNumCheque.Text;
                        cashDel.sReferentTo = "LANÇAMENTO ESTORNADO: " + txtReferenteA.Text;
                        cashDel.CashType = CashType.Enter;

                        objDel.Update(cashDel);

                        Cash cashOut = new Cash
                        {
                            sId_Budgets_OS = returnOS(),
                            sId_Client = returnId(),
                            dValue = Convert.ToDecimal(txtValor.Text.Replace(".", ",")),
                            dtDate = DateTime.Now,
                            sChequeNumber = txtNumCheque.Text,
                            sReferentTo = "ESTORNO REFERENTE: " + txtReferenteA.Text,
                            CashType = CashType.Out,
                            sID = Guid.NewGuid().ToString()
                        };

                        objDel.Insert(cashOut);

                        var up = objDel.Search.FirstOrDefault(b => b.sID == lblId.Text);

                        var ins = objDel.Search.FirstOrDefault(b => b.sID == lblId.Text);
                    
                        if (up == null || ins == null)
                            MessageBox.Show("Erro ao Estornar a Entrada !!!");
                        else
                            MessageBox.Show("Entrada Estornada com Sucesso !!!");

                        cleanCamps();

                        fillGrid();
                    }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            searchByName();
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
            
            var cash = from p in ctx.Cash where p.sId_Client.Equals(idClient) where p.CashType == CashType.Enter select p;

            if (cash.ToList().Count.Equals(0))
            {
                txtNomeCliente.Text = clientsSearch.ReturnClients.sName;
                msg.Show("Lançamento Não Encontrado","Não foi Encontrado Lançamentos para este Cliente",0,2000);
                txtNomeCliente.Focus();
            }
            else
            {
                List<Cash> s = cash.ToList();
                txtNomeCliente.Text = clientsSearch.ReturnClients.sName;
                grdEntradas.DataSource = s.ToList();
            }
        }
    }
}
