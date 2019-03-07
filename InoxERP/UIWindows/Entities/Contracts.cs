using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UIWindows.Entities.Enum;

namespace UIWindows.Entities
{
    [Table("tb_contracts")]
    public class Contracts : BaseEntity
    {
        [StringLength(100)]
        [Required(ErrorMessage = "Chave da O.S. é Obrigatória")]
        public string sIdBudget_OS { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Nome do Contratante é Obrigatório")]
        public string sProviderName { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "CNPJ/CPF do Contratante é Obrigatório")]
        public string sProviderCpfCnpj { get; set; }

        [StringLength(16)]
        [Required(ErrorMessage = "Inscrção Estadual/RG do Contratante é Obrigatório")]
        public string sRegistStateRg { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Endereço do Contratante é Obrigatório")]
        public string sProviderAdress { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Número do Endereço do Contratante é Obrigatório")]
        public string sProviderNumberAdress { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Bairro do Contratante é Obrigatório")]
        public string sProviderDistrict { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "CEP do Contratante é Obrigatório")]
        public string sProviderCep { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Cidade do Contratante é Obrigatório")]
        public string sProviderCity { get; set; }
        
        [Range(0,27, ErrorMessage = "Estado do Contratante é Obrigatório")]
        public Estate ProviderEstate { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Nome do Cliente é Obrigatório")]
        public string sClientName { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "CNPJ/CPF do Cliente é Obrigatório")]
        public string sClientCpfCnpj { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "RG do Cliente é Obrigatório")]
        public string sClientRg { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Endereço do Cliente é Obrigatório")]
        public string sClientAdress { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Número do Endereço do Cliente é Obrigatório")]
        public string sClientNumberAdress { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Bairro do Cliente é Obrigatório")]
        public string sClientDistrict { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "CEP do Cliente é Obrigatório")]
        public string sClientCep { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Cidade do Cliente é Obrigatório")]
        public string sClientCity { get; set; }

        [Range(0, 27, ErrorMessage = "Estado do Cliente é Obrigatório")]
        public Estate ClientEstate { get; set; }

        [Required(ErrorMessage = "Valor Total é Obrigatório")]
        public decimal dTotalValue { get; set; }

        [Required(ErrorMessage = "Prazo é Obrigatório")]
        public int iDeadline { get; set; }

        [Required(ErrorMessage = "Inicio do Seviço é obrigatória")]
        public DateTime dtStartExecution { get; set; }

        [Required(ErrorMessage = "Garantia é obrigatória")]
        public int iWarrantyTime { get; set; }

        [Required(ErrorMessage = "Data do Contrato é obrigatória")]
        public DateTime dtContractDate { get; set; }

        [Required(ErrorMessage = "O Objeto do Contrato é Obrigatório")]
        public string sClientObjectContract { get; set; }

        public string sPaymentForm { get; set; }

        public string sCity { get; set; }


        //ForengKeys


        //Contracts -> Items 1:n
        public ICollection<Items> Items { get; set; }


        //Contracts -> Budgets_OS 1:1
        public virtual Budgets_OS Budgets_OS { get; set; }
        
    }
}
