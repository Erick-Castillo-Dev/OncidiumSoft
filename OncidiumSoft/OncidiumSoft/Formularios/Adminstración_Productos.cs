using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OncidiumSoft.Formularios
{
    public partial class Adminstración_Productos : Form
    {
        public Adminstración_Productos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento que permitira agregar un nuevo producto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar_Productos AddProducto = new Agregar_Productos();
            AddProducto.Show();
        }
    }
}
