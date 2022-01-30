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
    public partial class frmReporteEstudios : Form
    {
        public frmReporteEstudios()
        {
            InitializeComponent();
        }

        private void frmReporteEstudios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.Estudios' Puede moverla o quitarla según sea necesario.
            this.estudiosTableAdapter.Fill(this.dsPrincipal.Estudios);

            this.reportViewer1.RefreshReport();
        }
    }
}
