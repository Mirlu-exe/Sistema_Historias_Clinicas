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
    public partial class frmListadoHistorialOp : Form
    {
        public frmListadoHistorialOp()
        {
            InitializeComponent();
        }

        private void frmListadoHistorialOp_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.Operacion' Puede moverla o quitarla según sea necesario.
            this.OperacionTableAdapter.Fill(this.dsPrincipal.Operacion);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
