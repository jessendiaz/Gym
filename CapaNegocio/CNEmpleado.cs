using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using MySql.Data.MySqlClient;

namespace CapaNegocio
{
    class CNEmpleado
    {
        private CDEmpleado objeto = new CDEmpleado();
        private string _rut;
        private string _nombre;
        private string _pass;

        public string Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Pass
        {
            get { return _pass; }
            set { _pass = value; }
        }
        public CNEmpleado() { }
        public MySqlDataReader iniciarSesion()
        {
            MySqlDataReader logear;
            logear = objeto.iniciarSesion(Nombre, Pass);
            return logear;
        }

    }
    
}
