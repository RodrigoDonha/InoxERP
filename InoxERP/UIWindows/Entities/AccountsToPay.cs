using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWindows.Entities
{
    [Table("tb_accountsToPay")]
    public class AccountsToPay : BaseEntity
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

        [Required(ErrorMessage = "Data de Pagamento da Conta é Obrigatório")]
        public DateTime dtPayDate { get; set; }

        public bool bReceivePaid { get; set; }

        [Required(ErrorMessage = "Parcela da Conta é Obrigatória")]
        public int iInstallment { get; set; }

        [Required(ErrorMessage = "Quantidade de Parcelas da Conta é Obrigatória")]
        public int iAmountInstallment { get; set; }

        [StringLength(100)]
        public string sReferentTo { get; set; }


        //ForengKey

        //AccountsToPay -> ParcialPay 1:n
        public ICollection<ParcialPay> ParcialPay { get; set; }


        //Cash -> AccountsToPay 1:n
        public virtual Cash Cash { get; set; }

        [ForeignKey("Cash")]
        public string idCash { get; set; }


        //Providers -> AccountsToPay 1:n
        public virtual Providers Providers { get; set; }

        [ForeignKey("Providers")]
        public string idProviders { get; set; }
    }
}
