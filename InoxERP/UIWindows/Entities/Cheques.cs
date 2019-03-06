using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWindows.Entities
{
    [Table("tb_cheques")]
    public class Cheques : BaseEntity
    {
        [StringLength(100)]
        //[Required(ErrorMessage = "Codigo do Orçamento é Obrigatório")]
        public string sId_Budgets_OS { get; set; }

        [StringLength(100)]
        //[Required(ErrorMessage = "Codigo do Cliente é Obrigatório")]
        public string sId_Client { get; set; }

        [Required(ErrorMessage = "Valor do Cheque é Obrigatório")]
        public decimal dValue { get; set; }
        
        public decimal dPaid { get; set; }

        public decimal dRemaing { get; set; }


        [Required(ErrorMessage = "Data de Vencimento do Cheque é Obrigatório")]
        public DateTime dtDueDate { get; set; }

        [Required(ErrorMessage = "Data de Pagamento do Cheque é Obrigatório")]
        public DateTime dtPayDate { get; set; }

        public DateTime dtIssue { get; set; }

        public bool bChequePaid { get; set; }

        [Required(ErrorMessage = "Parcela do Cheque é Obrigatória")]
        public int iInstallment { get; set; }

        [Required(ErrorMessage = "Quantidade de Parcelas do Cheque é Obrigatória")]
        public int iAmountInstallment { get; set; }

        [StringLength(33)]
        [Required(ErrorMessage = "Número do Cheque é Obrigatório")]
        public string sChequeNumber { get; set; }

        [StringLength(100)]
        public string sReferentTo { get; set; }

        [StringLength(100)]
        public string sClientName { get; set; }


        //ForengKey

        //Cash -> Cheque 1:n
        public virtual Cash Cash { get; set; }

        [ForeignKey("Cash")]
        public string idCash { get; set; }
    }
}
