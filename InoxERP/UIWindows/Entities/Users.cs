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

        //ForengKeys Project <- Users
        //[ForeignKey("sProjectsID")]
        //public Projects Projects { get; set; }

        //public string sProjectsID { get; set; }

        public string getMD5Hash(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
