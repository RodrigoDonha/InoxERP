using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWindows.Entities.Enum;

namespace UIWindows.Entities
{
    [Table("tb_products")]
    public class Products : BaseEntity
    {
        [StringLength(100)]
        [Required(ErrorMessage = "Descrição é obrigatória")]
        public string sDescription { get; set; }

        [Required(ErrorMessage = "Quantidade é obrigatória")]
        public double dAmount { get; set; }
        
        [Range(1, 3, ErrorMessage = "Tipo é obrigatório")]
        public UnityType Type { get; set; }

        [Required(ErrorMessage = "Valor UN é obrigatório")]
        public decimal dPrice { get; set; }

        [Required(ErrorMessage = "Valor TOTAL é obrigatório")]
        public decimal dTotal { get; set; }

        [StringLength(300)]
        public string sObservation { get; set; }


        //ForengKeys				

        //Providers -> Products 1:n
        public virtual Providers Providers { get; set; }

        [ForeignKey("Providers")]
        public string IdProviders { get; set; }


        //Items -> Products 1:n
        public virtual Items Items { get; set; }

        [ForeignKey("Items")]
        public string IdItems { get; set; }
    }
}
