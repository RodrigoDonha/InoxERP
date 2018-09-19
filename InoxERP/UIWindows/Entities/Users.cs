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
    [Table("tb_users")]
    public class Users : BaseEntity
    {
        [StringLength(100)]
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string sName { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Login é obrigatório")]
        public string sLogin { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Senha é obrigatória")]
        public string sKey { get; set; }

        [Range(1, 2, ErrorMessage = "Tipo é obrigatório")]
        public UserType Type { get; set; }

        //ForengKeys 

        //Users -> Permitions 1:1
        public virtual Permitions Permitions { get; set; }
        
    }
}
