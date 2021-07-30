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
    public partial class frmReporteCitasMedicasTotales : Form
    {
        public frmReporteCitasMedicasTotales()
        {
            InitializeComponent();
        }

        private void frmReporteCitasMedicasTotales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.spListaCitasMedicasTotales' Puede moverla o quitarla según sea necesario.
            this.spListaCitasMedicasTotalesTableAdapter.Fill(this.dsPrincipal.spListaCitasMedicasTotales);

            this.reportViewer1.RefreshReport();
        }
    }
}
