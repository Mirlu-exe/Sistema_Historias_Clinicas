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
    public partial class frmGraficoRegistrosPacientes : Form
    {
        public frmGraficoRegistrosPacientes()
        {
            InitializeComponent();
        }

        private void frmGraficoRegistrosPacientes_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
