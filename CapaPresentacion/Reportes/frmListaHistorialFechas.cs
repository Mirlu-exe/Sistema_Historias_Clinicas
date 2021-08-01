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
    public partial class frmListaHistorialFechas : Form
    {
        private DateTime _fecha1, _fecha2;

        public DateTime Fecha1
        {
            get { return _fecha1; }
            set { _fecha1 = value; }
        }

        public DateTime Fecha2
        {
            get { return _fecha2; }
            set { _fecha2 = value; }
        }

        public frmListaHistorialFechas()
        {
            InitializeComponent();
        }

        private void frmListaHistorialFechas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.spListaHistorialFechas' Puede moverla o quitarla según sea necesario.
            this.spListaHistorialFechasTableAdapter.Fill(this.dsPrincipal.spListaHistorialFechas, Fecha1, Fecha2);
            this.reportViewer1.RefreshReport();
        }
    }
}
