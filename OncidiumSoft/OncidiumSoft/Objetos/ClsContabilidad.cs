using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace OncidiumSoft.Objetos
{
    class ClsContabilidad
    {
        # region "ATRIBUTOS DE CONTABILIDAD"
        private int pidContabilidad;
        private DateTime pFechaInicio;
        private DateTime pFechaFin;
        private double pGanancia_Perdida;
        #endregion

        # region "OBTENER CONEXION PARA UTILIZAR EN LA CONTABILIDAD"
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("SERVER=" + "localhost" + ";PORT=3306" + ";DATABASE=" + "vivero" + ";UID=" + "root" + ";PWD=" + "root");
            conectar.Open();
            return conectar;
        }
        #endregion

        # region GETTERS Y SETTERS DE CONTABILIDAD"
        public int idContabilidad
        {
            get
            {
                return pidContabilidad;
            }
            set
            {
                pidContabilidad = value;
            }
        }
        public DateTime FechaInicio
        {
            get
            {
                return pFechaInicio;
            }
            set
            {
                pFechaInicio = value;
            }
        }
        public DateTime FechaFin
        {
            get
            {
                return pFechaFin;
            }
            set
            {
                pFechaFin = value;
            }
        }
        public double Ganancia_Perdida
        {
            get
            {
                return pGanancia_Perdida;
            }
            set
            {
                pGanancia_Perdida = value;
            }
        }
        #endregion
    }
}
