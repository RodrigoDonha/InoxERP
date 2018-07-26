using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoxERP.Modelos
{
    public class UsuariosInformation
    {
        private int cod;
        private string usuario;
        private string senha;
        private string tipo;

        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        //public enum type
        //{
        //    Master,
        //    Administrador,
        //    Usuario
        //} 
    }
}
