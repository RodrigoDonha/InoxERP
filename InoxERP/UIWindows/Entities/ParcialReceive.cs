using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWindows.Entities
{
    [Table("tb_parcialReceive")]
    public class ParcialReceive : BaseEntity
    {
        [Required(ErrorMessage = "Valor Parcial da Conta é Obrigatório")]
        public decimal dParcialValue { get; set; }

        [Required(ErrorMessage = "Data de Pagamento Parcial da Conta é Obrigatória")]
        public DateTime dtParcialDueDate { get; set; }
        
        [StringLength(100)]
        public string sReferentTo { get; set; }


        //ForengKey


        //AccountsToReceive -> ParcialReceive 1:n
        public virtual AccountsToReceive AccountsToReceive { get; set; }

        [ForeignKey("AccountsToReceive")]
        public string idAccountsToReceive { get; set; }
    }
}
