using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWindows.DTO
{
    public class DTOPaymentForm
    {
        public string sId_Budgets_OS { get; set; }

        public string sId_Client { get; set; }

        public decimal dValue { get; set; }

        public bool bType { get; set; }

        public DateTime dtDueDate { get; set; } //vecto
        
        public int iInstallment { get; set; }

        public int iAmountInstallment { get; set; }

        public string sReferentTo { get; set; }//num Orçamento
    }
}
