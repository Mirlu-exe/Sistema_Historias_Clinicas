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
    public partial class frmtListadoHistoriaPaciente : Form
    {
        public frmtListadoHistoriaPaciente()
        {
            InitializeComponent();
        }

        private void frmtListadoHistoriaPaciente_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
