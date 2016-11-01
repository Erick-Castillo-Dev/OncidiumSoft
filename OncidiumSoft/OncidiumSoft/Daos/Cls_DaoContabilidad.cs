using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OncidiumSoft.Conexxion_Datos;

namespace OncidiumSoft.Daos
{
    class Cls_DaoContabilidad
    {
        /// <summary>
        /// Creación del objeto para obtener la conexion
        /// </summary>
        Conexion objConexion = new Conexion();
        public void obtenerVenta()
        {
            objConexion.Conectar();

        }
    }
}
