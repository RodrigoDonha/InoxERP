//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MySql.Data.MySqlClient;

//namespace InoxERP.DAL
//{
//    abstract class BaseDAL
//    {
//        private string conexao;

//        public void __construct()
//        {
//            this.conexao = Dados.StringDeConexao;
//        }

//        public void select(string sql)
//        {
//            if (!sql.Length.Equals(0))
//            {
//                return Select < sql,this.conexao >;
//            }

//        }

//        public function insert($table, $cols, $values)
//        {
//            if (!empty($table) && !empty($cols) && !empty($values))
//            {
//            $parametros = $cols;
//            $colunas = str_replace(":", "", $cols);
//            /*
//                INSERT INTO usuario (nome,email) VALUES (:nome,:email);
//            */
//            $stmt = $this->conexao->prepare("INSERT INTO $table ($colunas) VALUES ($parametros)");
//            $stmt->execute($values);

//                return $stmt->rowCount();
//            }
//            else
//            {
//                return false;
//            }
//        }

//        public function update($table, $cols, $values, $where)
//        {
//            if (!empty($table) && !empty($cols) && !empty($values))
//            {
//                if ($where)
//            {
//                $where = " WHERE $where ";
//                }

//            $stmt = $this->conexao->prepare("UPDATE $table SET $cols $where");
//            $stmt->execute($values);

//                return $stmt->rowCount();
//            }
//            else
//            {
//                return false;
//            }
//        }


//        public function delete($table,$values)
//        {
//            if (!empty($table) && !empty($values))
//            {
//            $stmt = $this->conexao->prepare("DELETE FROM $table WHERE cod = '$values'");
//            $stmt->execute();
//            }
//            else
//            {
//                return false;
//            }
//        }



//    }



//    namespace Park.DAL
//    {
//        public class PrecosDAL
//        {
//            public void Incluir(PrecosInformation preco)
//            {
//                //conexao
//                MySqlConnection cn = new MySqlConnection();
//                try
//                {
//                    cn.ConnectionString = Dados.StringDeConexao;
//                    //command
//                    MySqlCommand cmd = new MySqlCommand();
//                    cmd.Connection = cn;
//                    cmd.CommandText = "insert into precos(pcarPequeno,pcarGrande,pMoto,pdiacarPequeno,pdiacarGrande,p30minCarPeq,p30minCarGrande,p30minMoto,carencia1hora,carenciaMaisHoras,carenciaLava,pCarPeqLava,pCarGdeLava,pMotoLava) values (@pcarPequeno,@pcarGrande,@pMoto@,pdiacarPequeno,@pdiacarGrande,@p30minCarPeq,@p30minCarGrande,@p30minMoto,@carencia1hora,@carenciaMaisHoras,@pCarPeqLava,@pCarGdeLava,@pMotoLava);";
//                    cmd.Parameters.AddWithValue("@pcarPequeno", preco.PcarPequeno);
//                    cmd.Parameters.AddWithValue("@pcarGrande", preco.PdiacarGrande);
//                    cmd.Parameters.AddWithValue("@pMoto", preco.PMoto);
//                    cmd.Parameters.AddWithValue("@pdiacarPequeno", preco.PdiacarPequeno);
//                    cmd.Parameters.AddWithValue("@pdiacarGrande", preco.PdiacarGrande);
//                    cmd.Parameters.AddWithValue("@p30minCarPeq", preco.P30minCarPeq);
//                    cmd.Parameters.AddWithValue("@p30minCarGrande", preco.P30minCarGrande);
//                    cmd.Parameters.AddWithValue("@p30minMoto", preco.P30minMoto);
//                    cmd.Parameters.AddWithValue("@carencia1hora", preco.Carencia1hora);
//                    cmd.Parameters.AddWithValue("@carenciaMaisHoras", preco.CarenciaMaisHoras);
//                    cmd.Parameters.AddWithValue("@carenciaLava", preco.CarenciaLava);
//                    cmd.Parameters.AddWithValue("@pCarPeqLava", preco.PCarPeqLava);
//                    cmd.Parameters.AddWithValue("@pCarGdeLava", preco.PCarGdeLava);
//                    cmd.Parameters.AddWithValue("@pMotoLava", preco.PMotoLava);

//                    cn.Open();
//                    preco.CodPreco = Convert.ToInt32(cmd.ExecuteScalar());
//                }
//                catch (MySqlException ex)
//                {
//                    throw new Exception("Servidor SQL Erro:" + ex.Number);
//                }
//                catch (Exception ex)
//                {
//                    throw new Exception(ex.Message);
//                }
//                finally
//                {
//                    cn.Close();
//                }
//            }
//            public void Alterar(PrecosInformation preco)
//            {
//                // conexao
//                MySqlConnection cn = new MySqlConnection();
//                try
//                {
//                    cn.ConnectionString = Dados.StringDeConexao;
//                    MySqlCommand cmd = new MySqlCommand();
//                    cmd.Connection = cn;
//                    cmd.CommandType = CommandType.Text;
//                    cmd.CommandText = "update precos set pcarPequeno = @pcarPequeno, pcarGrande = @pcarGrande, pMoto = @pMoto, pdiacarPequeno = @pdiacarPequeno, pdiacarGrande = @pdiacarGrande, pdiaMoto = @pdiaMoto, p30minCarPeq = @p30minCarPeq, p30minCarGrande = @p30minCarGrande, p30minMoto = @p30minMoto, carencia1hora = @carencia1hora, carenciaMaisHoras = @carenciaMaisHoras, carenciaLava = @carenciaLava, pCarPeqLava = @pCarPeqLava, pCarGdeLava = @pCarGdeLava, pMotoLava = @pMotoLava where codPreco = @codPreco; ";
//                    cmd.Parameters.AddWithValue("@codPreco", preco.CodPreco);
//                    cmd.Parameters.AddWithValue("@pcarPequeno", preco.PcarPequeno);
//                    cmd.Parameters.AddWithValue("@pcarGrande", preco.PcarGrande);
//                    cmd.Parameters.AddWithValue("@pMoto", preco.PMoto);
//                    cmd.Parameters.AddWithValue("@pdiacarPequeno", preco.PdiacarPequeno);
//                    cmd.Parameters.AddWithValue("@pdiacarGrande", preco.PdiacarGrande);
//                    cmd.Parameters.AddWithValue("@pdiaMoto", preco.PdiaMoto);
//                    cmd.Parameters.AddWithValue("@p30minCarPeq", preco.P30minCarPeq);
//                    cmd.Parameters.AddWithValue("@p30minCarGrande", preco.P30minCarGrande);
//                    cmd.Parameters.AddWithValue("@p30minMoto", preco.P30minMoto);
//                    cmd.Parameters.AddWithValue("@carencia1hora", preco.Carencia1hora);
//                    cmd.Parameters.AddWithValue("@carenciaMaisHoras", preco.CarenciaMaisHoras);
//                    cmd.Parameters.AddWithValue("@carenciaLava", preco.CarenciaLava);
//                    cmd.Parameters.AddWithValue("@pCarPeqLava", preco.PCarPeqLava);
//                    cmd.Parameters.AddWithValue("@pCarGdeLava", preco.PCarGdeLava);
//                    cmd.Parameters.AddWithValue("@pMotoLava", preco.PMotoLava);

//                    cn.Open();
//                    cmd.ExecuteNonQuery();
//                }
//                catch (MySqlException ex)
//                {
//                    throw new Exception("Servidor SQL Erro:" + ex.Number);
//                }
//                catch (Exception ex)
//                {
//                    throw new Exception(ex.Message);
//                }
//                finally
//                {
//                    cn.Close();
//                }
//            }
//            public void Excluir(int codPreco)
//            {
//                //conexao
//                MySqlConnection cn = new MySqlConnection();
//                try
//                {
//                    cn.ConnectionString = Dados.StringDeConexao;
//                    //command
//                    MySqlCommand cmd = new MySqlCommand();
//                    cmd.Connection = cn;
//                    cmd.CommandText = "delete from precos where codPreco = " + codPreco;
//                    cn.Open();
//                    int resultado = cmd.ExecuteNonQuery();
//                    if (resultado != 1)
//                    {
//                        throw new Exception("Não foi possível excluir a Lista de Preço: " +
//                        codPreco);
//                    }
//                }
//                catch (MySqlException ex)
//                {
//                    throw new Exception("Servidor SQL Erro:" + ex.Number);
//                }
//                catch (Exception ex)
//                {
//                    throw new Exception(ex.Message);
//                }
//                finally
//                {
//                    cn.Close();
//                }
//            }
//            public DataTable Listagem()
//            {
//                DataTable tabela = new DataTable();
//                MySqlDataAdapter da = new MySqlDataAdapter("select * from precos", Dados.StringDeConexao);
//                da.Fill(tabela);
//                return tabela;
//            }

//            public DataTable Listagem1()
//            {
//                DataTable tabela = new DataTable();
//                MySqlDataAdapter da = new MySqlDataAdapter("select codPreco as 'Codigo', pcarPequeno as Pequeno, pcarGrande as Grande, pMoto as Moto, pdiacarPequeno as 'Diaria Carro Pequeno', pdiacarGrande as 'Diaria Carro Grande', pdiaMoto as 'Diaria Moto', p30minCarPeq as '30 min Carro Peq', p30minCarGrande as '30 min Carro Grande', p30minMoto as '30 min Moto', carencia1hora as 'Carencia Primeira Hora', carenciaMaisHoras as 'Carencia Demais Horas', carenciaLava as 'Carencia Lavagem', pCarPeqLava as 'Lavagem Carro Peq',pCarGdeLava as 'Lavagem Carro Gde',pMotoLava as 'Lavagem Moto' from precos", Dados.StringDeConexao);
//                da.Fill(tabela);
//                return tabela;
//            }
//        }
//    }

//}
