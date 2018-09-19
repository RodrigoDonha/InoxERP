using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWindows.Entities
{
    [Table("tb_accountsToReceive")]
    public class AccountsToReceive : BaseEntity
    {
        [StringLength(100)]
        [Required(ErrorMessage = "Codigo do Orçamento é Obrigatório")]
        public string sId_Budgets_OS { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Codigo do Cliente é Obrigatório")]
        public string sId_Client { get; set; }

        [Required(ErrorMessage = "Valor da Conta é Obrigatório")]
        public decimal dValue { get; set; }

        [Required(ErrorMessage = "Data de Vencimento da Conta é Obrigatório")]
        public DateTime dtDueDate { get; set; }

        [Required(ErrorMessage = "Data do Recebimento da Conta é Obrigatório")]
        public DateTime dtReceiveDate { get; set; }

        public bool bReceivePaid { get; set; }

        [Required(ErrorMessage = "Parcela da Conta é Obrigatória")]
        public int iInstallment { get; set; }

        [Required(ErrorMessage = "Quantidade de Parcelas da Conta é Obrigatória")]
        public int iAmountInstallment { get; set; }
        
        [StringLength(100)]
        public string sReferentTo { get; set; }


        //ForengKey

        //AccountsToReceive -> ParcialReceive 1:n
        public ICollection<ParcialReceive> ParcialReceive { get; set; }


        //Cash -> AccountsToReceive 1:n
        public virtual Cash Cash { get; set; }

        [ForeignKey("Cash")]
        public string idCash { get; set; }


        //Budgets_OS -> AccountsToReceive 1:n
        public virtual Budgets_OS Budgets_OS { get; set; }

        [ForeignKey("Budgets_OS")]
        public string idBudgets_OS { get; set; }
    }
}
