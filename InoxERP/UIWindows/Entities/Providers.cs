using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UIWindows.Entities.Enum;

namespace UIWindows.Entities
{
    [Table("tb_providers")]
    public class Providers : BaseEntity
    {
        [StringLength(100)]
        [Required(ErrorMessage = "O Nome é obrigatório")]
        public string sName { get; set; }

        [StringLength(18)]
        [Required(ErrorMessage = "CPF/CNPJ é obrigatório")]
        public string sCpfCnpj { get; set; }
        
        [StringLength(100)]
        //[Required(ErrorMessage = "Endereço é obrigatório")]
        public string sAdress { get; set; }

        //[Required(ErrorMessage = "Numero é obrigatório")]
        public int iNumber { get; set; }

        [StringLength(100)]
        //[Required(ErrorMessage = "Bairro é obrigatório")]
        public string sDistrict { get; set; }

        [StringLength(50)]
        public string sComplement { get; set; }

        [StringLength(100)]
        //[Required(ErrorMessage = "Cidade é obrigatória")]
        public string sCity { get; set; }

        //[Range(1, 27, ErrorMessage = "Estado é obrigatório")]
        public Estate Estate { get; set; }

        [StringLength(9)]
        //[Required(ErrorMessage = "CEP é obrigatório")]
        public string sCEP { get; set; }

        [Required(ErrorMessage = "Telefone Comercial é obrigatório")]
        [StringLength(14)]
        public string sPhoneComercial { get; set; }

        //[Required(ErrorMessage = "Celular é obrigatório")]
        [StringLength(15)]
        public string sPhoneCelularOne { get; set; }

        [StringLength(15)]
        public string sPhoneCelularTwo { get; set; }

        [StringLength(100)]
        public string sEmail { get; set; }

        [StringLength(50)]
        public string sBank { get; set; }

        [StringLength(20)]
        public string sAgency { get; set; }

        [StringLength(20)]
        public string sAccount { get; set; }

        [StringLength(100)]
        public string sFavored { get; set; }

        [StringLength(18)]
        public string sCpfCnpjFavored { get; set; }
        
        public decimal dMinimumPurchase { get; set; }

        [StringLength(300)]
        public string sObservation { get; set; }


        //ForengKeys				

        //Providers -> Products 1:n
        public virtual ICollection<Products> Products { get; set; }


        //Providers -> AccountsToPay 1:n
        public virtual ICollection<AccountsToPay> AccountsToPay { get; set; }
    }
}
