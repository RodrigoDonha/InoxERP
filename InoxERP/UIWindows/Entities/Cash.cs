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
    [Table("tb_cash")]
    public class Cash : BaseEntity
    {
        [StringLength(100)]
        [Required(ErrorMessage = "Codigo do Orçamento é Obrigatório")]
        public string sId_Budgets_OS { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Codigo do Cliente é Obrigatório")]
        public string sId_Client { get; set; }

        [Required(ErrorMessage = "Valor é Obrigatório")]
        public decimal dValue { get; set; }

        [Required(ErrorMessage = "Data é Obrigatório")]
        public DateTime dtDate { get; set; }
        
        [StringLength(100)]
        public string sReferentTo { get; set; }

        [Range(1, 2, ErrorMessage = "Tipo de Entrada no Caixa é obrigatório")]
        public CashType CashType { get; set; }


        //ForengKey


        //Cash -> Cheques 1:n
        public ICollection<Cheques> Cheques { get; set; }


        //Cash -> AccountsToReceive 1:n
        public ICollection<AccountsToReceive> AccountsToReceive { get; set; }


        //Cash -> AccountsToPay 1:n
        public ICollection<AccountsToPay> AccountsToPay { get; set; }
    }
}
