using InoxERP.DAL;
using InoxERP.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoxERP.BLL
{
    public class PermissaoUsuarioBLL
    {
        public PermissoesList Permissao(string tipo)
        {            
            PermissoesDAL perm = new PermissoesDAL();
            return perm.ConsultaPermissoes(tipo);            
        }
    }
}
