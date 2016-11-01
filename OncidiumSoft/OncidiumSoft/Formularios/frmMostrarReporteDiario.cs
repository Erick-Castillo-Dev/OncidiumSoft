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
    public partial class frmMostrarReporteDiario : Form
    {
        public frmMostrarReporteDiario()
        {
            InitializeComponent();
        }

        private void frmMostrarReporteDiario_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
