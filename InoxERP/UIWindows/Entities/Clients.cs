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
    [Table("tb_clients")]
    public class Clients : BaseEntity
    {
        [StringLength(100)]
        [Required(ErrorMessage = "O Nome é obrigatório")]
        public string sName { get; set; }

        [StringLength(18)]
        //[Required(ErrorMessage = "CPF/CNPJ é obrigatório")]
        public string sCpfCnpj { get; set; }

        [StringLength(14)]
        public string sRg { get; set; }
        
        //[Range(1, 3, ErrorMessage = "Tipo é obrigatório")]
        public ClientType ClientType { get; set; }

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

        [StringLength(14)]
        public string sPhoneResidencial { get; set; }

        [StringLength(15)]
        //[Required(ErrorMessage = "Celular é obrigatório")]
        public string sPhoneCelularOne { get; set; }

        [StringLength(15)]
        public string sPhoneCelularTwo { get; set; }

        [StringLength(100)]
        public string sEmail { get; set; }

        [StringLength(100)]
        public string sOccupation { get; set; }

        [StringLength(300)]
        public string sObservation { get; set; }


        //ForengKeys

        //Clients -> Budgets_OS 1:n
        public ICollection<Budgets_OS> Budgets_OS { get; set; }
    }
}
