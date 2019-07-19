using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWindows.Entities
{
    public class Hired
    {
        public string Name                { get; set; }
        public string CpfCnpj             { get; set; }
        public string InscrEst            { get; set; }
        public string Adress              { get; set; }
        public string Number              { get; set; }
        public string District            { get; set; }
        public string Complement          { get; set; }
        public string City                { get; set; }
        public string Estate              { get; set; }
        public string CEP                 { get; set; }
        public string CommercialPhone     { get; set; }
        public string CellPhone           { get; set; }
        public string Email               { get; set; }
        public string Observation         { get; set; }
        public string AllHiredInformation { get; set; } // for implements contract empty

        public void Clear_Hired()
        {
            Name                = "";
            CpfCnpj             = "";
            InscrEst            = "";
            Adress              = "";
            Number              = "";
            District            = "";
            Complement          = "";
            City                = "";
            Estate              = "";
            CEP                 = "";
            CommercialPhone     = "";
            CellPhone           = "";
            Email               = "";
            Observation         = "";
            AllHiredInformation = "";
        }

        // Editables Contracts

        public void Lucas_Hired()
        {
            Name            = "LUCAS BEIRIGO REGGIANI 09396759945";
            CpfCnpj         = "30.286.217/0001-70";
            InscrEst        = "562.431.339.111";
            Adress          = "AV. DAS FLORES";
            Number          = "210";
            District        = "CECAP";
            Complement      = "";
            City            = "PRESIDENTE PRUDENTE";
            Estate          = "SP";
            CEP             = "19065-510";
            CommercialPhone = "";
            CellPhone       = "";
            Email           = "";
            Observation     = "";
            StringContracts(); // for implements contract empty
        }

        public void Richard_Hired()
        {
            Name            = "RICHARD CARLOS REGGIANI 16479617851";
            CpfCnpj         = "31.210.732/0001-30";
            InscrEst        = "562.439.989.118";
            Adress          = "RUA ROTARY CLUBE DE PRESIDENTE PRUDENTE-ALVOR";
            Number          = "25";
            District        = "VILA ROTARIA \"ARCH C. KLUMPH\"";
            Complement      = "";
            City            = "PRESIDENTE PRUDENTE";
            Estate          = "SP";
            CEP             = "19045-333";
            CommercialPhone = "";
            CellPhone       = "";
            Email           = "";
            Observation     = "";
            StringContracts(); // for implements contract empty
        }

        // Empty Contracts

        public void StringContracts()
        {
            AllHiredInformation = "Nome: "              + Name     +
                                  ", CPF/CNPJ: "        + CpfCnpj  +
                                  ", Inscr. Estadual: " + InscrEst +
                                  ", Endereço: "        + Adress   +
                                  " Nº. "               + Number   +
                                  ", Bairro: "          + District +
                                  ", Cidade: "          + City     +
                                  "/"                   + Estate   +
                                  ", CEP: "             + CEP      ;
        }
    }
}
