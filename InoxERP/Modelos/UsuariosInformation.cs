using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoxERP.Modelos
{
    public class UsuariosInformation
    {
        private int idLogin;
        private string usuario;
        private string senha;
        private int tipo;

        public int IdLogin
        {
            get { return idLogin; }
            set { idLogin = value; }
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

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
