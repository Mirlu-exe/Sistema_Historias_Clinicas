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
    public partial class frmReporteDiagnosticos : Form
    {
        public frmReporteDiagnosticos()
        {
            InitializeComponent();
        }

        private void frmReporteDiagnosticos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.Diagnostico' Puede moverla o quitarla según sea necesario.
            this.diagnosticoTableAdapter.Fill(this.dsPrincipal.Diagnostico);

            this.reportViewer1.RefreshReport();
        }
    }
}
