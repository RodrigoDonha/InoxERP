using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWindows.Entities
{
    [Table("tb_services")]
    public class Services : BaseEntity
    {
        [StringLength(100)]
        [Required(ErrorMessage = "Descrição é obrigatória")]
        public string sDescription { get; set; }

        [Required(ErrorMessage = "Tempo é obrigatório")]
        public double sTime { get; set; }

        [Required(ErrorMessage = "Valor TOTAL é obrigatório")]
        public decimal dTotal { get; set; }

        [StringLength(300)]
        public string sObservation { get; set; }


        //ForengKeys				

        //public string sItemsID { get; set; }
    }
}
