using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWindows.Business.Concrete;

namespace UIWindows.Views.Accounts
{
    public partial class frmChequeNumber : Form
    {
        public string chequeNumber { get; set; }

        ValidationEntries validation = new ValidationEntries();

        public frmChequeNumber()
        {
            InitializeComponent();
        }


        public frmChequeNumber(int installment)
        {
            InitializeComponent();
            lblParcela.Text = installment.ToString();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if(validationCamps())
                if(messageYesNo("confirm") == DialogResult.Yes)
                    chequeNumber = txtC1.Text + "-" + txtC2.Text + "-" + txtC3.Text;

            this.Dispose();
        }

        private bool validationCamps()
        {
            if (!validationC1())
                return false;
            if (!validationC2())
                return false;
            if (!validationC3())
                return false;
            
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
                MessageBox.Show("O Campo 1 deve conter 8 numeros");
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
                    return MessageBox.Show("Confirma os Campos Digitados para o CMC7 do Cheque ?", "Confirmação do Lançamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }
            return DialogResult.No;
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
    }
}
