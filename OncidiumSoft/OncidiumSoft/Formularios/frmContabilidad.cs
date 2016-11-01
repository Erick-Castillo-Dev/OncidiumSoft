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
    public partial class frmContabilidad : Form
    {
        public frmContabilidad()
        {
            InitializeComponent();
        }
        double Inversion;

        private void frmContabilidad_Load(object sender, EventArgs e)
        {
            lblFechaA.Text = DateTime.Now.ToLongDateString();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmHistorialContabilidades().Show();
        }

        private void GastosGenerales_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmGastosEspecificos().Show();
        }

        private void btnCalcularInversion_Click(object sender, EventArgs e)
        {
            Inversion = double.Parse(txtGastosGenerales.Text) + double.Parse(txtSalarios.Text);
            lblInversionT.Text = Inversion.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtGastosGenerales.Clear();
            txtSalarios.Clear();
            txtGastosGenerales.Enabled = false;
            lblInversionT.Text = "0.00";
        }

        private void txtSalarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

    }
}
