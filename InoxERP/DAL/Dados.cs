using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InoxERP.DAL
{
    public class Dados
    {
        public static string StringDeConexao
        {
            get
            {
                return "server=localhost;port=3307;User Id=root;database=inoxerp;password=usbw;SslMode=none";
            }
        }

    }
}
