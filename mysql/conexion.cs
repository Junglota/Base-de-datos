using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Prueba_2_login.mysql
{
    internal class conexion
    {
        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1;database=log;Uid=root;pwd=juegos321");
            conexion.Open();
            return conexion;
        }
    }
}
