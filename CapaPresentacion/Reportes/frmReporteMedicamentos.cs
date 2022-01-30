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
    public partial class frmReporteMedicamentos : Form
    {
        public frmReporteMedicamentos()
        {
            InitializeComponent();
        }

        private void frmReporteMedicamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.sp_mostrar_meds' Puede moverla o quitarla según sea necesario.
            this.sp_mostrar_medsTableAdapter.Fill(this.dsPrincipal.sp_mostrar_meds);

            this.reportViewer1.RefreshReport();
        }
    }
}
