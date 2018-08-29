using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWindows.Entities
{
    public class BaseEntity
    {
        [Key]
        [StringLength(40)]
        public string sID { get; set; }
    }
}
