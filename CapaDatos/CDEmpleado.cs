using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    
    public class CDEmpleado
    {
        private CDConexion Conexion = new CDConexion();
        private MySqlDataReader leer;

        public MySqlDataReader iniciarSesion(string user, string pass) {
            string sql = "select * from empleado where rut = " + user + " and password = " + pass;
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = sql;
            leer = comando.ExecuteReader();
            return leer;
        }
    }
}
