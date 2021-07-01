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
    public partial class frmReporteRecetas : Form
    {
        private int _Idreceta;

        public int Idreceta
        {
            get { return _Idreceta; }
            set { _Idreceta = value; }
        }

        
        public frmReporteRecetas()
        {
            InitializeComponent();
        }

        private void frmReporteRecetas_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'dsReceta.spreporte_receta' Puede moverla o quitarla según sea necesario.
            this.spreporte_recetaTableAdapter.Fill(this.dsReceta.spreporte_receta, _Idreceta);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
