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
    public partial class frmListadoCitasUsuario : Form
    {
        private int _usuario;

        public int Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public frmListadoCitasUsuario()
        {
            InitializeComponent();
        }

        private void frmListadoCitasUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.spListaCitasMedicasUsuarios' Puede moverla o quitarla según sea necesario.
            this.spListaCitasMedicasUsuariosTableAdapter.Fill(this.dsPrincipal.spListaCitasMedicasUsuarios, Usuario);
            this.reportViewer1.RefreshReport();
        }
    }
}
