using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    class CDConexion
    {
        private MySqlConnection Conexion = new MySqlConnection("server=localhost;user id=root;database=bdgym;password=121986");
        public MySqlConnection AbrirConexion() {
            try
            {
                if (Conexion.State == System.Data.ConnectionState.Closed)
                {
                    Conexion.Open();
                }
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return Conexion;


        }
        public MySqlConnection CerrarConexion() {
            try
            {
                if (Conexion.State == System.Data.ConnectionState.Open)
                {
                    Conexion.Close();
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return Conexion;
        }
        //    Conexion = new MySqlConnection();
        //    Conexion.ConnectionString = sql;
        //            Conexion.Open();
        //            Query.CommandText = "SELECT idCliente, nombre, rutCliente FROM cliente LIMIT 1";
        //            Query.Connection = Conexion;
        //            consultar = Query.ExecuteReader();
        //            while (consultar.Read())
        //            {
        //                int id = consultar.GetInt32(0);
        //    string nombre = consultar.GetString(1);
        //    string telefono = consultar.GetString(2);
        //    MessageBox.Show("Cliente:\n" + id + " " + nombre + " " + telefono);
        //            }
        //Conexion.Close();
    }
}
