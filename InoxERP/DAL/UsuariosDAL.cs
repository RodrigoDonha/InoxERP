using System;
using InoxERP.Modelos;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace InoxERP.DAL
{    
    public class UsuariosDAL
    {
        public void Incluir(UsuariosInformation usuarios)
        {
            //conexao
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into usuarios(usuario,senha,tipo) values (@usuario, @senha, @tipo);";
                cmd.Parameters.AddWithValue("@usuario", usuarios.Usuario);
                cmd.Parameters.AddWithValue("@senha", usuarios.Senha);
                cmd.Parameters.AddWithValue("@tipo", usuarios.Tipo);
                cn.Open();
                usuarios.IdLogin = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (MySqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(UsuariosInformation usuarios)
        {
            // conexao
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update usuarios set usuario = @usuario, senha = @senha, tipo = @tipo where idLogin = @idLogin; ";
                cmd.Parameters.AddWithValue("@idLogin", usuarios.IdLogin);
                cmd.Parameters.AddWithValue("@usuario", usuarios.Usuario);
                cmd.Parameters.AddWithValue("@senha", usuarios.Senha);
                cmd.Parameters.AddWithValue("@tipo", usuarios.Tipo);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int idLogin)
        {
            //conexao
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "delete from usuarios where idLogin = " + idLogin;
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o Usuario " +
                    idLogin);
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public DataTable ExecutarConsulta(CommandType cmd, string select)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection(Dados.StringDeConexao);
                cn.Open();
                MySqlCommand Sqlcmd = cn.CreateCommand();
                Sqlcmd.CommandType = cmd;
                Sqlcmd.CommandText = select;

                foreach (MySqlParameter sqlParameter in sqlParameterCollection)
                {
                    Sqlcmd.Parameters.Add(new MySqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(Sqlcmd);

                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                return dataTable;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable Listagem()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select idLogin as Codigo, usuario as Usuario, senha as Senha, tipo as Tipo from usuarios where tipo != 0", Dados.StringDeConexao);
            da.Fill(tabela);
            return tabela;
        }
                
        public UsuariosList ConsultaUser(UsuariosInformation usuario)
        {
            try
            {
                UsuariosList userList = new UsuariosList();
                string user = usuario.Usuario;
                string senha = usuario.Senha;
                string query = "SELECT * FROM usuarios WHERE usuario = @usuario AND senha = @senha";

                AdicionarParametros("@usuario", user);
                AdicionarParametros("@senha", senha);

                DataTable tableUser = new DataTable();

                tableUser = ExecutarConsulta(CommandType.Text, query);

                foreach (DataRow linha in tableUser.Rows)
                {
                    UsuariosInformation u = new UsuariosInformation();
                    u.IdLogin = Convert.ToInt32(linha["idLogin"]);
                    u.Usuario = Convert.ToString(linha["usuario"]);
                    u.Senha = Convert.ToString(linha["senha"]);
                    u.Tipo = Convert.ToInt32(linha["tipo"]);

                    userList.Add(u);
                }
                return userList;
            }
            catch (Exception)
            {
                throw new Exception("Erro ao Conectar no Banco de Dados");
            }
        }

        private MySqlParameterCollection sqlParameterCollection = new MySqlCommand().Parameters;

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new MySqlParameter(nomeParametro, valorParametro));
        }
    }
}

