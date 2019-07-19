using System;
using System.Windows.Forms;
using UIWindows.Entities;
using UIWindows.Views.Reports.Contracts;

namespace UIWindows
{
    public partial class frmSelectProvider : Form
    {
        public string type;
        Hired hrd = new Hired();

        private string contratadoString;
        
        public frmSelectProvider(string ContractType)
        {
            type = ContractType;
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnLucas_Click(object sender, EventArgs e)
        {
            if (type == "frmEditableContract")
                hrd.Lucas_Hired();
            else
            {
                ContractEmptyPrint print = new ContractEmptyPrint(contratadoString, hrd.CpfCnpj);
                print.Show();
            }
            this.Dispose();
        }

        private void BtnRichard_Click(object sender, EventArgs e)
        {
            if (type == "frmEditableContract")
                hrd.Richard_Hired();
            else
            {
                ContractEmptyPrint print = new ContractEmptyPrint(contratadoString, hrd.CpfCnpj);
                print.Show();
            }
            this.Dispose();
        }

        public Hired Returns()
        {
            return hrd;
        }
    }
}
