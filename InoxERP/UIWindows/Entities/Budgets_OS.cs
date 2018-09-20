using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWindows.Entities;
using UIWindows.Entities.Enum;

namespace UIWindows.Entities
{
    [Table("tb_budgets_os")]
    public class Budgets_OS : BaseEntity
    {
        [Required(ErrorMessage = "Codigo para o Orçamento e obrigatório")]
        public int iCod { get; set; }

        [Range(1,3, ErrorMessage = "Tipo é obrigatório")]
        public ClientType ClientType { get; set; }

        [Required(ErrorMessage = "Data é obrigatória")]
        public DateTime dtDate { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string sName { get; set; }

        [StringLength(100)]
        //[Required(ErrorMessage = "Endereço é obrigatório")]
        public string sAdress { get; set; }

        [StringLength(14)]
        [Required(ErrorMessage = "Telefone é obrigatório")]
        public string sTelephone { get; set; }

        [StringLength(100)]
        //[Required(ErrorMessage = "Cargo é obrigatório")]
        public string sOccupation { get; set; }

        [Range(1, 4, ErrorMessage = "Tipo de Pagamento é obrigatório")]
        public PaymentMethods PaymentMethods { get; set; }

        public bool bPaymentToMatch { get; set; }

        public decimal dPercentDiscount { get; set; }

        //[Required(ErrorMessage = "Quantidade Parcelamento é obrigatória")]
        public int iPaymentInstallments { get; set; }

        public bool bInterestRate { get; set; }
        
        public decimal dWithInterest { get; set; }

        //[Required(ErrorMessage = "Previsão é obrigatória")]
        public int iPrevisionOfExecute { get; set; }
       
        //[Required(ErrorMessage = "Previsão Inicial é obrigatória")]
        public DateTime dtStartPrevision { get; set; }

        //[Required(ErrorMessage = "Previsão Final é obrigatória")]
        public DateTime dtFinalPrevision { get; set; }
        
        //[Required(ErrorMessage = "Garantia é obrigatória")]
        public int iWarrantyTime { get; set; }

        //[Required(ErrorMessage = "Data Expiração é obrigatória")]
        public DateTime dtBudgetExpirationDate { get; set; }

        //[StringLength(300)]
        public string sObservation { get; set; }
        
        [Required(ErrorMessage = "Total é obrigatório")]
        public decimal dTotal { get; set; }

        public bool bServiceOrderApproved { get; set; }

        public DateTime? dtDateServiceOrderApproved { get; set; }

        public bool bServiceOrderDelivered { get; set; }

        public DateTime? dtDateServiceOrderDelivered { get; set; }

        public bool bRegisterFinished { get; set; }

        public DateTime? dtDateRegisterFinished { get; set; }


        //ForengKeys				

        //Budgets_OS -> Items 1:n
        public virtual ICollection<Items> Items { get; set; }


        //Budgets_OS -> AccountsToReceive 1:n
        public virtual ICollection<AccountsToReceive> AccountsToReceive { get; set; }


        //Clients -> Products 1:n
        public virtual Clients Clients { get; set; }

        [ForeignKey("Clients")]
        public string IdClients { get; set; }

        
        ////Budgets_OS -> Contracts 1:1
        //public virtual Contracts Contracts { get; set; }
    }
}