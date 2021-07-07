using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmReportePacientes : Form
    {
        public frmReportePacientes()
        {
            InitializeComponent();
        }

        private void frmReportePacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.spmostrar_paciente' Puede moverla o quitarla según sea necesario.
            this.spmostrar_pacienteTableAdapter.Fill(this.dsPrincipal.spmostrar_paciente);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
