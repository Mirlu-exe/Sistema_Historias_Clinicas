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
    public partial class frmListaEvolucionFechas : Form
    {
        private DateTime _fecha1, _fecha2;

        public DateTime fecha1
        {
            get { return _fecha1; }
            set { _fecha1 = value; }
        }

        public DateTime fecha2
        {
            get { return _fecha2; }
            set { _fecha2 = value; }
        }
        
        public frmListaEvolucionFechas()
        {
            InitializeComponent();
           
           

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmListaEvolucionFechas_Load(object sender, EventArgs e)
        {
            

            DateTime fecha1 = FechasReportesEvolucion.Fecha1.Date;

            DateTime fecha2 = FechasReportesEvolucion.Fecha2.Date;

            MessageBox.Show(fecha1.ToString("d") + " y " + fecha2.ToString("d"));

            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.spListaEvolucionFechas' Puede moverla o quitarla según sea necesario.
            this.spListaEvolucionFechasTableAdapter.Fill(this.dsPrincipal.spListaEvolucionFechas, fecha1, fecha2);

            MessageBox.Show("a");
            this.reportViewer1.RefreshReport();

           
        }
    
  }
}