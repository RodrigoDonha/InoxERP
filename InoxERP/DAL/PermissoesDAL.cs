using System;
using InoxERP.Modelos;
using System.Data;
using MySql.Data.MySqlClient;

namespace InoxERP.DAL
{
    public class PermissoesDAL
    {
        public PermissoesList ConsultaPermissoes(string tipo)
        {
            try
            {
                PermissoesList permiList = new PermissoesList();

                DataTable tabela = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM tb_permissoes WHERE tipo = '" + tipo + "'", Dados.StringDeConexao);
                da.Fill(tabela);

                foreach (DataRow linha in tabela.Rows)
                {
                    PermissoesInformation pe = new PermissoesInformation();
                    pe.Orcamento = Convert.ToBoolean(linha["orcamento"]);
                    pe.OrdemServico = Convert.ToBoolean(linha["ordem_servico"]);
                    pe.Entrega = Convert.ToBoolean(linha["entrega"]);
                    pe.Caixa = Convert.ToBoolean(linha["caixa"]);
                    pe.Relatorios = Convert.ToBoolean(linha["relatorios"]);
                    pe.Usuaruios = Convert.ToBoolean(linha["usuarios"]);
                    pe.Permissoes = Convert.ToBoolean(linha["permissoes"]);

                    permiList.Add(pe);
                }
                return permiList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

