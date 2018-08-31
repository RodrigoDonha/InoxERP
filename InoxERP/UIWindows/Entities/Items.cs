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

        //public string sBudget_OSID { get; set; }
        //public string sServicesID { get; set; }
        //public string sProductsID { get; set; }
        //public string sContractsID { get; set; }
    }
}
