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
    public partial class frmtListadoHistoriaPaciente : Form
    {
        private int _paciente;

        public int Paciente
        {
            get { return _paciente; }
            set { _paciente = value; }
        }

        public frmtListadoHistoriaPaciente()
        {
            InitializeComponent();
        }

        private void frmtListadoHistoriaPaciente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.spListaHistoriaPaciente' Puede moverla o quitarla según sea necesario.
            this.spListaHistoriaPacienteTableAdapter.Fill(this.dsPrincipal.spListaHistoriaPaciente, Paciente);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
