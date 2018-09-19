using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWindows.Entities
{
    [Table("tb_items")]
    public class Items : BaseEntity
    {
        [Required(ErrorMessage = "Quantidade é obrigatória")]
        public double dAmount { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Descrição é obrigatória")]
        public string sDescription { get; set; }

        [Required(ErrorMessage = "Valor UN é obrigatório")]
        public decimal dPrice { get; set; }

        [Required(ErrorMessage = "Valor TOTAL é obrigatório")]
        public decimal dTotal { get; set; }

        [StringLength(300)]
        public string sObservation { get; set; }


        //ForengKeys				

        
        //Items -> Products 1:n
        public ICollection<Products> Products { get; set; }


        //Items -> Services 1:n
        public ICollection<Services> Services { get; set; }


        //Budgets_OS -> Items 1:n
        public virtual Budgets_OS Budgets_OS { get; set; }

        [ForeignKey("Budgets_OS")]
        public string IdBudgets_OS { get; set; }


        //Contracts -> Items 1:n
        public virtual Contracts Contracts { get; set; }

        [ForeignKey("Contracts")]
        public string IdContracts { get; set; }
    }
}
