using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using InoxERP.UI_Windows_Forms;
using UIWindows.Business;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;
using UIWindows.Views.ServicesOrders;

namespace UIWindows
{
    public partial class frmServiceOrderSearch : Form
    {

        static InoxErpContext ctx = new InoxErpContext();
        Budgets_OS searchBudget = new Budgets_OS();
        Budget_OSBusiness obj = new Budget_OSBusiness(ctx);
        
        MessageBoxTimer msg = new MessageBoxTimer();

        Hired hrd = new Hired();

        String getId;

        public frmServiceOrderSearch()
        {
            InitializeComponent();
            // Display a message box. The Help button opens the Mspaint.chm Help file, 
            // shows index with the "ovals" keyword selected, and displays the
            // associated topic.
        }


        // Events

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            getIdGrigView();
            if (!getId.Equals(""))
            {
                frmBudgetsRegister bud = new frmBudgetsRegister(getId);

                /////FUNCTION TO DISABLE BUTTONS
                foreach (Control budControl in bud.Controls)
                {
                    foreach (Control btn in budControl.Controls)
                    {
                        if (btn.Name == "btnGravarOrcamento" || btn.Name == "btnExcluir" || btn.Name == "btnCancelarOrcamento")
                            btn.Enabled = false;
                        if (btn.Name == "btnAprovar")
                            btn.Enabled = true;
                    }
                }
                bud.BudgetData();
                bud.Show();
            }
        }

        private void btnDesaprovar_Click(object sender, EventArgs e)
        {
            //getIdGrigView();
            //if (dgvOrdemServico.CurrentRow != null)
            //{
            //    searchBudget = obj.ReturnByID(getId);
            //    if (messageYesNo("Desapprove") == DialogResult.Yes)
            //    {
            //        searchBudget.bServiceOrderApproved = false;
            //        searchBudget.dtDateServiceOrderApproved = DateTime.Now;

            //        obj.Update(searchBudget);
            //        MessageBox.Show("Desaprovado");

            //        fillDataSet();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Não foi possível selecionar o orçamento, tente selecionar novamente.");
            //}
        }

        private void btnFinlizar_Click(object sender, EventArgs e)
        {
            getIdGrigView();
            if (dgvOrdemServico.CurrentRow != null)
            {
                searchBudget = obj.ReturnByID(getId);
                if (messageYesNo("Finished") == DialogResult.Yes)
                {
                    searchBudget.bRegisterFinished = true;
                    searchBudget.dtDateRegisterFinished = DateTime.Now;
                    //searchBudget.bServiceOrderDelivered = true;
                    //searchBudget.dtDateServiceOrderDelivered = DateTime.Now;

                    obj.Update(searchBudget);
                    MessageBox.Show("Serviço Finalizado");

                    fillDataSet();
                }
            }
            else
            {
                MessageBox.Show("Não foi possível selecionar o orçamento, tente selecionar novamente.");
            }
        }

        private void btnGerarContrato_Click(object sender, EventArgs e)
        {
            getIdGrigView();
            DialogResult dr = MessageBox.Show("Deseja gerar o contrato com Cláusulas Totalmente Editáveis?",
                "Tipo de Contrato", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1,
                0);
            if (dr == DialogResult.Yes)
            {
                // gerar tela de contrato editavel
                if (dgvOrdemServico.CurrentRow != null)
                {
                    if (!checkContract(getId))
                    {
                        Clients cli = new Clients();
                        ClientsBusiness clients = new ClientsBusiness(ctx);

                        InoxErpContext c = new InoxErpContext();
                        Budget_OSBusiness objSearch = new Budget_OSBusiness(c);
                        Budgets_OS bud = new Budgets_OS();

                        bud = objSearch.ReturnByID(getId);

                        cli = clients.ReturnByID(bud.IdClients);

                        if (cli == null || cli.sName.Contains("CONSUMIDOR"))
                        {
                            msg.Show("Escolher Cliente",
                                " É necessário o Cadastro do Cliente antes de Gerar um Contrato \n\n Impossível continuar sem Cadastro prévio no Sistema !!!",
                                0, 10000);
                            if (messageYesNo("client") == DialogResult.Yes)
                            {
                                frmClientsSearch clientsSearch = new frmClientsSearch();

                                foreach (Control cliControl in clientsSearch.Controls)
                                {
                                    if (cliControl.Name == "btnAbrirAlterar" || cliControl.Name == "btnExcluir" ||
                                        cliControl.Name == "btnCadastrar")
                                        cliControl.Enabled = false;
                                }

                                clientsSearch.ShowDialog();

                                if (clientsSearch.ReturnClients != null)
                                {
                                    if (messageYesNo("changeClient") == DialogResult.Yes)
                                    {
                                        InoxErpContext ctxS = new InoxErpContext();
                                        Budget_OSBusiness objS = new Budget_OSBusiness(ctxS);
                                        Budgets_OS b = new Budgets_OS();

                                        b = objS.ReturnByID(getId);

                                        b.IdClients = clientsSearch.ReturnClients.sID;
                                        b.sName = clientsSearch.ReturnClients.sName;
                                        b.sAdress = clientsSearch.ReturnClients.sAdress;
                                        b.sTelephone = clientsSearch.ReturnClients.sPhoneCelularOne;
                                        b.sOccupation = clientsSearch.ReturnClients.sOccupation;

                                        objS.Update(b);

                                        var ok = objS.Search.FirstOrDefault(t => t.sID == b.sID);

                                        MessageBox.Show(ok == null
                                            ? "Erro ao Atualizar o Orçamento !!!"
                                            : "Orçamento Atualizado com Sucesso !!!");

                                        fillDataSet();
                                        checkContract(getId);

                                        txtPesquisa.Text = b.sName.ToString();
                                        btnPesquisar_Click(sender, e);
                                        btnGerarContrato_Click(sender, e);
                                    }
                                }
                            }
                        }
                        else if (messageYesNo("CreateContract") == DialogResult.Yes)
                        {
                            this.Dispose();

                            new frmEditableContract(getId, "Budget").Show();
                        }
                    }
                    else
                        MessageBox.Show("Já foi Gerado Contrato para esta Ordem de Serviço, Impossível gerar outro");

                }
                else
                {
                    MessageBox.Show("Não foi possível selecionar a Ordem de Serviço, tente selecionar novamente.");
                }
            }

            if (dr == DialogResult.No)
            {
                // gerar tela de contrato estático
                if (dgvOrdemServico.CurrentRow != null)
                {
                    if (!checkContract(getId))
                    {
                        Clients cli = new Clients();
                        ClientsBusiness clients = new ClientsBusiness(ctx);

                        InoxErpContext c = new InoxErpContext();
                        Budget_OSBusiness objSearch = new Budget_OSBusiness(c);
                        Budgets_OS bud = new Budgets_OS();

                        bud = objSearch.ReturnByID(getId);

                        cli = clients.ReturnByID(bud.IdClients);

                        if (cli == null || cli.sName.Contains("CONSUMIDOR"))
                        {
                            msg.Show("Escolher Cliente",
                                " É necessário o Cadastro do Cliente antes de Gerar um Contrato \n\n Impossível continuar sem Cadastro prévio no Sistema !!!",
                                0, 10000);
                            if (messageYesNo("client") == DialogResult.Yes)
                            {
                                frmClientsSearch clientsSearch = new frmClientsSearch();

                                foreach (Control cliControl in clientsSearch.Controls)
                                {
                                    if (cliControl.Name == "btnAbrirAlterar" || cliControl.Name == "btnExcluir" ||
                                        cliControl.Name == "btnCadastrar")
                                        cliControl.Enabled = false;
                                }

                                clientsSearch.ShowDialog();

                                if (clientsSearch.ReturnClients != null)
                                {
                                    if (messageYesNo("changeClient") == DialogResult.Yes)
                                    {
                                        InoxErpContext ctxS = new InoxErpContext();
                                        Budget_OSBusiness objS = new Budget_OSBusiness(ctxS);
                                        Budgets_OS b = new Budgets_OS();

                                        b = objS.ReturnByID(getId);

                                        b.IdClients = clientsSearch.ReturnClients.sID;
                                        b.sName = clientsSearch.ReturnClients.sName;
                                        b.sAdress = clientsSearch.ReturnClients.sAdress;
                                        b.sTelephone = clientsSearch.ReturnClients.sPhoneCelularOne;
                                        b.sOccupation = clientsSearch.ReturnClients.sOccupation;

                                        objS.Update(b);

                                        var ok = objS.Search.FirstOrDefault(t => t.sID == b.sID);

                                        MessageBox.Show(ok == null
                                            ? "Erro ao Atualizar o Orçamento !!!"
                                            : "Orçamento Atualizado com Sucesso !!!");

                                        fillDataSet();
                                        checkContract(getId);

                                        txtPesquisa.Text = b.sName.ToString();
                                        btnPesquisar_Click(sender, e);
                                        btnGerarContrato_Click(sender, e);
                                    }
                                }
                            }
                        }
                        else if (messageYesNo("CreateContract") == DialogResult.Yes)
                        {
                            this.Dispose();
                            new frmContract(getId, "Budget").Show();
                        }
                    }
                    else
                        MessageBox.Show("Já foi Gerado Contrato para esta Ordem de Serviço, Impossível gerar outro");

                }
                else
                {
                    MessageBox.Show("Não foi possível selecionar a Ordem de Serviço, tente selecionar novamente.");
                }
            }

            if (dr == DialogResult.Cancel)
            {
                // se cancelar a operação, sair da tela de diálogo
            }
        }

        private bool checkContract(string id)
        {
            InoxErpContext c = new InoxErpContext();
            Budget_OSBusiness objS = new Budget_OSBusiness(c);

            bool contract = objS.ReturnByID(id).bContractRegistred;

            return contract;
        }

        private void grdOrdemServico_Click(object sender, EventArgs e)
        {
            getIdGrigView();
        }

        private void radData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informe a data no formato dd/mm/aaaa, exemplo: 01/09/2018");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (radNome.Checked)
                searchByName();
            else if (radCPF_CNPJ.Checked)
                searchByCPF_CNPJ();
            else if (radData.Checked)
                searchByDate();
        }

        // Parameters Ready, Validations and Verifications down
        public void getIdGrigView()
        {
            getId = "";
            if (dgvOrdemServico.CurrentRow != null)
            {
                getId = Convert.ToString(dgvOrdemServico[0, dgvOrdemServico.CurrentRow.Index].Value.ToString());
                txtPesquisa.Text = Convert.ToString(dgvOrdemServico[2, dgvOrdemServico.CurrentRow.Index].Value.ToString());
            }
            else
            {
                MessageBox.Show("Não foi possível selecionar o orçamento, tente selecionar novamente.");
                return;
            }
        }
        
        // SEARCH BY NAME CLIENT
        public void searchByName() 
        {
            var search = from p in ctx.Budgets_OS
                where p.sName.StartsWith(txtPesquisa.Text)
                where p.bServiceOrderApproved.Equals(true)
                where p.bRegisterFinished.Equals(false)
                select p;

            if (search.ToList().Count.Equals(0))
            {
                txtPesquisa.Clear();
                MessageBox.Show("Nenhuma Ordem de Serviço Encontrada");
                txtPesquisa.Focus();
            }
            else
            {
                List<Budgets_OS> s = search.ToList();
                txtPesquisa.Clear();
                dgvOrdemServico.DataSource = s.ToList();
            }
        }

        public void searchByCPF_CNPJ()
        {
            var search = from p in ctx.Budgets_OS
                where p.Clients.sCpfCnpj.StartsWith(txtPesquisa.Text)
                where p.bServiceOrderApproved.Equals(true)
                where p.bRegisterFinished.Equals(false)
                select p;

            if (search.ToList().Count.Equals(0))
            {
                txtPesquisa.Clear();
                MessageBox.Show("Nenhum Cliente Encontrado");
                txtPesquisa.Focus();
            }
            else
            {
                List<Budgets_OS> b = search.ToList();
                txtPesquisa.Clear();
                dgvOrdemServico.DataSource = b.ToList();
            }
        }

        public void searchByDate()
        {
            var query = from p in ctx.Budgets_OS
                where p.bServiceOrderApproved.Equals(true)
                where p.bRegisterFinished.Equals(false)
                select p;

            if (txtPesquisa.Text == "")
            {
                dgvOrdemServico.DataSource = query.ToList();
            }
            else
            {
                List<Budgets_OS> list = new List<Budgets_OS>();

                foreach (var line in query.ToList())
                {
                    if (line.dtDate.Date.ToShortDateString().Contains(txtPesquisa.Text))
                    {
                        list.Add(line);
                    }
                }
                dgvOrdemServico.DataSource = list.ToList();
            }
        }

        public DialogResult messageYesNo(string type)
        {
            switch (type)
            {
                case "Exclude":
                    return MessageBox.Show("Confirma excluisão ?", "Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "Desapprove":
                    return MessageBox.Show("Confirma a Desaprovação deste orçamento ?", "Ordem de Serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "Finished":
                    return MessageBox.Show("Confirma a Finalização do Serviço ?", "Finalizar Serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "client":
                    return MessageBox.Show("Deseja Selecionar um Cliente para esta Ordem de Serviço e continuar com a emissão de contrato ?", "Escolher Cliente", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                case "changeClient":
                    return MessageBox.Show("Confirma o Cliente Escolhido para Troca ?", "Mudança de Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "CreateContract":
                    return MessageBox.Show("Confirma a Geração do Contrato ?", "Gerar Contrato", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            return DialogResult.No;
        }

        //overrid FILL DATASET
        public void fillDataSet()
        {
            this.tb_budgets_osTableAdapter.FillByOrderServiceApproved(this.fullDataSet.tb_budgets_os);
            dgvOrdemServico.Sort(dgvOrdemServico.Columns[1], ListSortDirection.Descending);
        }

        private void frmServiceOrderSearch_Load(object sender, EventArgs e)
        {
            this.tb_budgets_osTableAdapter.FillByOrderServiceApproved(this.fullDataSet.tb_budgets_os);
            dgvOrdemServico.Sort(dgvOrdemServico.Columns[1], ListSortDirection.Descending);

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            getIdGrigView();
            if (!getId.Equals(""))
                new ServiceOrdersPrint(getId).Show();
        }
    }
}
