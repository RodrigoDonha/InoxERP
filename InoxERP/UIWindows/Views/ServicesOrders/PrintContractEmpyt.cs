using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWindows.Views.Reports.Contracts;

namespace UIWindows
{
    public partial class frmPrintContractEmpyt : Form
    {
        private string contratadoString;
        private string cnpj;

        public frmPrintContractEmpyt()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnLucas_Click(object sender, EventArgs e)
        {
            contratadoString = "Nome: LUCAS BEIRIGO REGGIANI 09396759945" +
                                  ", CPF/CNPJ: 30.286.217/0001-70" +
                                  ", Inscr. Estadual: 562.431.339.111" +
                                  ", Endereço: AV. DAS FLORES" +
                                  " Nº. 210" +
                                  ", Bairro: CECAP" +
                                  ", Cidade: PRESIDENTE PRUDENTE" +
                                  "/SP" +
                                  ", CEP: 19065-510";
            cnpj = "30.286.217/0001-70";

            ContractEmptyPrint print = new ContractEmptyPrint(contratadoString, cnpj);
            print.Show();
        }

        private void BtnRichard_Click(object sender, EventArgs e)
        {
            contratadoString = "Nome: RICHARD CARLOS REGGIANI 16479617851" +
                               ", CPF/CNPJ: 31.210.732/0001-30" +
                               ", Inscr. Estadual: 562.439.989.118" +
                               ", Endereço: RUA ROTARY CLUBE DE PRESIDENTE PRUDENTE-ALVOR" +
                               " Nº. 25" +
                               ", Bairro: VILA ROTARIA \"ARCH C. KLUMPH\"" +
                               ", Cidade: PRESIDENTE PRUDENTE" +
                               "/SP" +
                               ", CEP: 19045-333";
            cnpj = "31.210.732/0001-30";

            ContractEmptyPrint print = new ContractEmptyPrint(contratadoString, cnpj);
            print.Show();
        }
    }
}
