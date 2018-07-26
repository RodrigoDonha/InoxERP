using System;
using InoxERP.Modelos;
using System.Data;
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
                usuarios.Cod = Convert.ToInt32(cmd.ExecuteScalar());
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
                cmd.CommandText = "update usuarios set usuario = @usuario, senha = @senha, tipo = @tipo where cod = @cod; ";
                cmd.Parameters.AddWithValue("@idLogin", usuarios.Cod);
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
        public void Excluir(int cod)
        {
            //conexao
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "delete from usuarios where idLogin = " + cod;
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o Usuario " +
                    cod);
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
       
        public DataTable Listagem()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select cod as Codigo, usuario as Usuario, senha as Senha, tipo as Tipo from usuarios where tipo != 0", Dados.StringDeConexao);
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

                DataTable tabela = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM tb_usuarios WHERE usuario = '" + user + "' AND senha = '" + senha + "'", Dados.StringDeConexao);
                da.Fill(tabela);

                foreach (DataRow linha in tabela.Rows)
                {
                    UsuariosInformation u = new UsuariosInformation();
                    u.Cod = Convert.ToInt32(linha["cod"]);
                    u.Usuario = Convert.ToString(linha["usuario"]);
                    u.Senha = Convert.ToString(linha["senha"]);
                    u.Tipo = Convert.ToString(linha["tipo"]);

                    userList.Add(u);
                }
                return userList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       
    }
}

