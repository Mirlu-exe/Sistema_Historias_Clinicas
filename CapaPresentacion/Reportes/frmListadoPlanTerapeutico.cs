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
    public partial class frmListadoPlanTerapeutico : Form
    {
        public frmListadoPlanTerapeutico()
        {
            InitializeComponent();
        }

        private void frmListadoPlanTerapeutico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.spListaPlanTerapeutico' Puede moverla o quitarla según sea necesario.
            this.spListaPlanTerapeuticoTableAdapter.Fill(this.dsPrincipal.spListaPlanTerapeutico);
            this.reportViewer1.RefreshReport();        }
    }
}
