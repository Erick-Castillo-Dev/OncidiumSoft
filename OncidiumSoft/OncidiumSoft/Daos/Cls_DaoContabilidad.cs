using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace OncidiumSoft.Daos
{
    class Cls_DaoContabilidad
    {
        # region "CONEXION A LA BD"
        public MySqlConnection cConexion = new MySqlConnection();

        public void Conectar()
        {
            string strCadenaConexion;
            strCadenaConexion = "SERVER=" + "localhost" + ";PORT=3306" + ";DATABASE=" + "vivero" + ";UID=" + "root" + ";PWD=" + "root";
            cConexion.ConnectionString = strCadenaConexion;
            cConexion.Open();
        }
        # endregion
        

    }
}
