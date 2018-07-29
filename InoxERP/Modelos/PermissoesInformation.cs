using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoxERP.Modelos
{
    public class PermissoesInformation
    {
        private bool orcamento;
        private bool ordemServico;
        private bool entrega;
        private bool caixa;
        private bool relatorios;
        private bool usuarios;
        private bool permissoes;

        public bool Orcamento
        {
            get { return orcamento; }
            set { orcamento = value; }
        }

        public bool OrdemServico
        {
            get { return ordemServico; }
            set { ordemServico = value; }
        }

        public bool Entrega
        {
            get { return entrega; }
            set { entrega = value; }
        }

        public bool Caixa
        {
            get { return caixa; }
            set { caixa = value; }
        }

        public bool Relatorios
        {
            get { return relatorios; }
            set { relatorios = value; }
        }

        public bool Usuaruios
        {
            get { return usuarios; }
            set { usuarios = value; }
        }

        public bool Permissoes
        {
            get { return permissoes; }
            set { permissoes = value; }
        }
    }
}
