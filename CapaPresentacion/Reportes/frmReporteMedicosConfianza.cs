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
    public partial class frmReporteMedicosConfianza : Form
    {
        public frmReporteMedicosConfianza()
        {
            InitializeComponent();
        }

        private void frmReporteMedicosConfianza_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.MedicoConfianza' Puede moverla o quitarla según sea necesario.
            this.medicoConfianzaTableAdapter.Fill(this.dsPrincipal.MedicoConfianza);

            this.reportViewer1.RefreshReport();
        }
    }
}
