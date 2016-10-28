using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OncidiumSoft.Conexxion_Datos
{
    class Conexion
    {
        public MySqlConnection cConexion = new MySqlConnection();

        public void Conectar()
        {
            string strCadenaConexion;
            strCadenaConexion = "SERVER=" + "localhost" + ";PORT=3306" + ";DATABASE=" + "vivero" + ";UID=" + "root" + ";PWD=" + "root";
            cConexion.ConnectionString = strCadenaConexion;
            cConexion.Open();
        }

        public void Cerrar()
        {
            cConexion.Close();
        }
    }
}
