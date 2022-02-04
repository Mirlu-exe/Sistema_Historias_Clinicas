using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class frmReporteServicios : Form
    {
        public frmReporteServicios()
        {
            InitializeComponent();
        }

        private void frmReporteServicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.Servicio' Puede moverla o quitarla según sea necesario.
            this.servicioTableAdapter.Fill(this.dsPrincipal.Servicio);

            this.reportViewer1.RefreshReport();
        }
    }
}
