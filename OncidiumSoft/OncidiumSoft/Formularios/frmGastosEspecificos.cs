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
    public partial class frmGastosEspecificos : Form
    {
        double sumaGastos;
        public frmGastosEspecificos()
        {
            InitializeComponent();
        }

        private void btnCancelarGastos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmContabilidad().Show();
        }

        private void btnAceptarGastos_Click(object sender, EventArgs e)
        {
            frmContabilidad objCont = new frmContabilidad();
            if (txtGastosFertilizantes.Text != string.Empty && txtGastosInsecticidas.Text != string.Empty && txtGastosGasolina.Text != string.Empty &&
                txtGastosAgua.Text != string.Empty && txtGastosLuz.Text != string.Empty && txtImprevistos.Text != string.Empty)
            {
                sumaGastos = double.Parse(txtGastosFertilizantes.Text) + double.Parse(txtGastosInsecticidas.Text) + double.Parse(txtGastosGasolina.Text) +
                double.Parse(txtGastosAgua.Text) + double.Parse(txtGastosLuz.Text) + double.Parse(txtImprevistos.Text);
                objCont.txtGastosGenerales.Text = sumaGastos.ToString();
                this.Hide();
                objCont.Show();
            }
            else
            {
                MessageBox.Show("Hay campos vacíos");
            }
            
        }

        private void txtGastosFertilizantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void txtGastosInsecticidas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void txtGastosGasolina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back && (e.KeyChar != ',')))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void txtGastosAgua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void txtGastosLuz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void txtImprevistos_KeyPress(object sender, KeyPressEventArgs e)
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
