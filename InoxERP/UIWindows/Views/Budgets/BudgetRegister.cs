﻿using System;
using System.ComponentModel.Design;
using System.Windows.Forms;
using UIWindows;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;
using UIWindows.Entities.Enum;

namespace InoxERP.UI_Windows_Forms
{
    public partial class frmBudgetsRegister : Form
    {
        static InoxErpContext ctx = new InoxErpContext();
        private decimal subTotal = 0;

        public frmBudgetsRegister()
        {
            InitializeComponent();
            btnProcurar.Focus();
        }

        //INSERT
        private void btnGravarOrcamento_Click(object sender, EventArgs e)
        {
            if (!validationCamps())
            {
            }
            else if (messageYesNo("Save") == DialogResult.Yes)
            {
            }
        }

        //INSERT ITEM ON dgvItens
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!validatorAdd()) // verifica se os campo de adicionar estão preenchidos
            {
            }
            else if (checkEqualsItems()) // verifica se o produto/serviço a ser inserido já esta na gridview 
            {
                decimal total = Convert.ToDecimal(txtQuantidade.Text) * Convert.ToDecimal(txtValorUnitario.Text);
                if (total == 0)
                {
                    MessageBox.Show("Quantidade do Produto/Serviço deve ser maior que Zero");
                }
                else
                {
                    dgvItens.Rows.Add(txtQuantidade.Text, txtDescricao.Text, txtValorUnitario.Text,
                        Convert.ToString(total));
                    subTotal = subTotal + total;
                    lblSubTotalValor.Text = Convert.ToString(subTotal);
                    clearItensLine();
                    txtQuantidade.Focus();
                }
            }
        }

        //DELETE ITEM ON dgvItens
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int compare = dgvItens.Rows.Count; // conta linhas da tabela
            if (compare == 0)
            {
            }
            else
            {
                var row = dgvItens.SelectedRows[0].Index;
                subTotal = subTotal - Convert.ToDecimal(dgvItens[3, row].Value.ToString());
                lblSubTotalValor.Text = Convert.ToString(subTotal);
                dgvItens.Rows.RemoveAt(row);
                txtQuantidade.Focus();
                if(compare.Equals(1))
                    clearCampsPayment();
            }
        }

        //FUNCTIONS OF DATA GRID VIEW ITEMS

        // SEARCH FOR EQUALS ITEMS
        public bool checkEqualsItems()
        {
            foreach (DataGridViewRow line in dgvItens.Rows)
            {
                if (line.Cells["description"].Value.Equals(txtDescricao.Text))
                    if (messageYesNo("Add") == DialogResult.Yes)
                        return true;
                    else
                        return false;
            }

            return true;
        }

        // CLEAN CAMPS OF ADD ITEMS
        public void clearItensLine()
        {
            txtQuantidade.Text = "";
            txtDescricao.Text = "";
            txtValorUnitario.Text = "";
            txtValorTotal.Text = "0";
        }
        
        // WHEN CLICK DVGITENS LINE
        private void dgvItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedItem();
        }

        //FILL PRODUCTS/SERVICES ON VIEW
        public void selectedItem()
        {
            txtQuantidade.Text = dgvItens[0, dgvItens.CurrentRow.Index].Value.ToString();
            txtDescricao.Text = dgvItens[1, dgvItens.CurrentRow.Index].Value.ToString();
            txtValorUnitario.Text = dgvItens[2, dgvItens.CurrentRow.Index].Value.ToString();
            txtValorTotal.Text = dgvItens[3, dgvItens.CurrentRow.Index].Value.ToString();
        }



        // VALIDATORS

        //validators CAMPS frm
        public bool validationCamps()
        {
            if (txtNome.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um NOME para o cliente");
                txtNome.Focus();
                return false;
            }

            if (txtEndereco.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um ENDEREÇO para o cliente");
                txtEndereco.Focus();
                return false;
            }

            if (txtTelefone.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um TELEFONE para o cliente");
                txtTelefone.Focus();
                return false;
            }

            if (txtCargo.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um CARGO para o cliente");
                txtCargo.Focus();
                return false;
            }

            int compare = dgvItens.Rows.Count; 
            if (compare == 0)
            {
                MessageBox.Show("Nenhum Item Adicionado ao Orçamento");
                txtQuantidade.Focus();
                return false;
            }

            if (!chkCombinar.Checked && !chkCheque.Checked && !chkDinheiro.Checked)
            {
                MessageBox.Show("Informe a FORMA de pagamento");
                chkCombinar.Focus();
                return false;
            }

            return true;
        }

        //validator ADD on DataGridView
        public bool validatorAdd()
        {
            if (txtQuantidade.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe a quantidade");
                txtQuantidade.Focus();
                return false;
            }

            if (txtDescricao.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe a descrição do Produto/Serviço");
                txtDescricao.Focus();
                return false;
            }

            if (txtValorUnitario.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe o Valor Unitário");
                txtValorUnitario.Focus();
                return false;
            }

            return true;
        }
        
        //validator Calc values
        public void valueTotal()
        {
            int i;
            decimal d;

            if (!int.TryParse(txtQuantidade.Text, out i)) // validator of numbers
            {
                if (txtQuantidade.Text == "")
                { }
                else
                {
                    MessageBox.Show("Somente Números");
                    txtQuantidade.Focus();
                    txtQuantidade.Text = "";
                }
            }
            if (!decimal.TryParse(txtValorUnitario.Text, out d)) // validator of numbers
            {
                if(txtValorUnitario.Text == "")
                { }
                else
                {
                    MessageBox.Show("Somente Números");
                    txtValorUnitario.Focus();
                    txtValorUnitario.Text = "";
                }
            }else
            if (txtQuantidade.Text.Length.Equals(0))
            {
                txtQuantidade.Text = "";
            }else
            if (txtValorUnitario.Text.Length.Equals(0))
            {
                txtValorUnitario.Text = "";
                txtValorTotal.Text = "0";
                
            }else
            {
                decimal total = Convert.ToDecimal(txtQuantidade.Text) * Convert.ToDecimal(txtValorUnitario.Text);
                txtValorTotal.Text = Convert.ToString(total);
            }
        }

        //validator YesNo
        public DialogResult messageYesNo(string type)
        {
            switch (type)
            {
                case "Cancel": 
                    return MessageBox.Show("Deseja Canelar o Orçamento?", "Cancelar Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "Save":
                    return MessageBox.Show("Deseja Gravar o Orçamento com os Dados Informados?", "Gravar Orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "Add":
                    return MessageBox.Show("Já existe um Produto / Serviço lançando igual, Deseja Continuar?", "Produto Igual Encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }

            return DialogResult.No;
        }



        // CALLS

        // CALLS VIEW PRODUCTS
        private void btnPeca_Click(object sender, EventArgs e)
        {
            //new frmProductsRegisterSearch().Show();
        }

        // CALLS VIEW SERVICES
        private void btnServico_Click(object sender, EventArgs e)
        {
            //new frmServicesRegisterSearch().Show();
        }

        // CALL VIEW CLIENTS
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            //new frmClientsSearch().Show();
        }

        
        // CALL FUNCTION VALUETOTAL() WHERE CAMP QUANTIDADE IS CHANGED
        private void txtQuantidade_TextChanged_1(object sender, EventArgs e)
        {
            if(txtQuantidade.Text != "")
                valueTotal();
        }
        
        // CALL FUNCTION VALUETOTAL() WHERE CAMP VALOR UNITARIO IS CHANGED
        private void txtValorUnitario_TextChanged(object sender, EventArgs e)
        {
            if (txtValorUnitario.Text != "")
                valueTotal();
        }



        //STATES OF OBJECTS

        // WHEN PAYMENT FORM IS CHANGED BY TO COMBINE
        private void chkCombinar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCombinar.Checked)
            {
                chkJuros.CheckState = CheckState.Unchecked;
                if (txtPorcentDescAVista.Enabled.Equals(true))
                    txtPorcentDescAVista.Enabled = false;
                //if(nudParcelas.Enabled.Equals(true))
                    nudParcelas.Enabled = false;
                //if(chkJuros.Enabled.Equals(true))
                    chkJuros.Enabled = false;
                if(txtPorcentJuros.Enabled.Equals(true))
                    txtPorcentJuros.Enabled = false;
                clearCampsPayment();
                chkCheque.Enabled = false;
                chkDinheiro.Enabled = false;
            }
            else
            {
                if (lblSubTotalValor.Text != "0")
                {
                    txtPorcentDescAVista.Enabled = true;
                    nudParcelas.Enabled = true;
                }
                chkJuros.Enabled = true;
                chkCheque.Enabled = true;
                chkDinheiro.Enabled = true;

                if (chkJuros.Checked)
                    txtPorcentJuros.Enabled = true;
            }
        }

        // WHEN RATE FORM IS CHANGED BY TRUE
        private void chkJuros_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJuros.Checked)
            {
                txtPorcentJuros.Enabled = true;
                txtPorcentDescAVista.Enabled = false;
            }
            else
            {
                txtPorcentJuros.Enabled = false;
                txtPorcentDescAVista.Enabled = true;
                clearCampsPayment();
            }

        }
        
        // WHEN NUM OF DAYS IS CHANGED
        private void nudDias_ValueChanged(object sender, EventArgs e)
        {
           setDateService();
        }

        // WHEN INITIAL DATE IS CHANGED
        private void dtpDataPrevistaInicio_ValueChanged(object sender, EventArgs e)
        {
            setDateService();
        }

        //WHEN FINAL DATE IS CHANGED
        private void dtpDataPrevistaEntrega_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDataPrevistaEntrega.Value >= DateTime.Today) // se a data final escolhida for maior que data atual
            {
                var days = dtpDataPrevistaEntrega.Value.Date - dtpDataPrevistaInicio.Value.Date; // calcula diferença de dias
                if (days.Days >= 0)
                    nudDias.Value = days.Days; //preenche o nuddias
            }
            else
                dtpDataPrevistaEntrega.Value = DateTime.Today; // senao ele ignora a data anterior e coloca a data atual
        }

        //WHEN SET DATE TO DELIVERY
        public void setDateService()
        {
            if (!nudDias.Value.Equals(0)) // se o valor do nuddias for maior que 0
            {
                var days = Convert.ToDouble(nudDias.Value);
                dtpDataPrevistaEntrega.Value =
                    dtpDataPrevistaInicio.Value.AddDays(days); // data final recebe data de inicio + dias

            }
            else
                dtpDataPrevistaEntrega.Value = dtpDataPrevistaInicio.Value; // senao ele ignora a data anterior e coloca a data atual
        }


        //WHEN SET DESCONT TO VALUE
        private void txtPorcentDescAVista_TextChanged(object sender, EventArgs e)
        {
            if (!lblSubTotalValor.Text.Length.Equals(0) && !txtPorcentDescAVista.Text.Length.Equals(0))
            {
                var descValue = Convert.ToDecimal(lblSubTotalValor.Text) - (Convert.ToDecimal(lblSubTotalValor.Text) * (Convert.ToDecimal(txtPorcentDescAVista.Text)/100));

                lblExibeValorAVista.Text = Convert.ToString(descValue);
                lblTotalGeralValor.Text = lblExibeValorAVista.Text;
                nudParcelas.Enabled = false;
                chkJuros.Enabled = false;
            }
            else
            {
                lblExibeValorAVista.Text = lblSubTotalValor.Text;
                lblTotalGeralValor.Text = lblSubTotalValor.Text;
                if (!chkCombinar.Checked.Equals(true))
                {
                    nudParcelas.Enabled = true;
                    chkJuros.Enabled = true;
                }
            }

        }

        //WHEN NUDPARCELAS IS CHANGED
        private void nudParcelas_ValueChanged(object sender, EventArgs e)
        {
            calcValueRate();
        }

        //WHEN PORCENTJUROS IS CHANGED
        private void txtPorcentJuros_TextChanged(object sender, EventArgs e)
        {
            calcValueRate();
        }

        // CLEAN CAMPS OF PAYMENTS
        public void clearCampsPayment()
        {
            txtPorcentDescAVista.Clear();
            lblValorPorParcela.Text = "0";
            lblValorJuros.Text = "0";
            lblExibeValorTotalParcelado.Text = "0";
            nudParcelas.Value = 1;
            txtPorcentJuros.Clear();
            lblTotalGeralValor.Text = lblSubTotalValor.Text;
        }

        //SET TOTAL GENERAL
        private void lblSubTotalValor_TextChanged(object sender, EventArgs e)
        {
            if (lblSubTotalValor.Text != "0")
            {
                txtPorcentDescAVista.Enabled = true;
                lblExibeValorAVista.Text = lblSubTotalValor.Text;
                nudParcelas.Enabled = true;
                chkJuros.Enabled = true;
                chkCombinar.Enabled = true;
                chkCheque.Enabled = true;
                chkDinheiro.Enabled = true;

            }
            else
            {
                txtPorcentDescAVista.Enabled = false;
                lblExibeValorAVista.Text = "0";
                nudParcelas.Enabled = false;
                chkJuros.Enabled = false;
                chkCombinar.Enabled = false;
                chkCheque.Enabled = false;
                chkDinheiro.Enabled = false;
            }
            lblTotalGeralValor.Text = lblSubTotalValor.Text;
        }

        //SET VALUE OF RATE
        public void calcValueRate() // see with lucas
        {
            if (!lblSubTotalValor.Text.Length.Equals(0) && !txtPorcentJuros.Text.Length.Equals(0) && !nudParcelas.Value.Equals(0))
            {
                decimal percentByTimes = 0;

                if (!nudParcelas.Value.Equals(1))
                    percentByTimes = Convert.ToDecimal(txtPorcentJuros.Text) / 100;// * Convert.ToDecimal(nudParcelas.Value);

                var valueOfInstallmentTimes = Math.Round(Convert.ToDecimal(lblSubTotalValor.Text) / Convert.ToDecimal(nudParcelas.Value),2);
                var valueRate = Math.Round(percentByTimes * valueOfInstallmentTimes, 2);
                var valueRatePerTimes = Math.Round(valueOfInstallmentTimes + valueRate, 2);
                var valueTotalWithRate = Math.Round(valueRatePerTimes * Convert.ToDecimal(nudParcelas.Value));

                lblValorPorParcela.Text = Convert.ToString(valueRatePerTimes);

                lblValorJuros.Text = Convert.ToString(valueRate * Convert.ToDecimal(nudParcelas.Value));

                lblExibeValorTotalParcelado.Text = Convert.ToString(valueTotalWithRate);

                lblTotalGeralValor.Text = lblExibeValorTotalParcelado.Text;
            }
            else
            {
                clearCampsPayment();
            }
        }

        // CLOSE FORM
        private void btnCancelarOrcamento_Click(object sender, EventArgs e)
        {
            if (messageYesNo("Cancel") == DialogResult.Yes)
                this.Dispose();
        }
    }    
}