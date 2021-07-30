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
    public partial class frmListaPlanEstudio : Form
    {
        public frmListaPlanEstudio()
        {
            InitializeComponent();
        }

        private void frmListaPlanEstudio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.spListaPlanEstudio' Puede moverla o quitarla según sea necesario.
            this.spListaPlanEstudioTableAdapter.Fill(this.dsPrincipal.spListaPlanEstudio);
            this.reportViewer1.RefreshReport();
        }
    }
}
