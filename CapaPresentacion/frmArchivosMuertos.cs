using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using CapaDatos;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class frmArchivosMuertos : Form
    {
        public frmArchivosMuertos()
        {
            InitializeComponent();
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void frmArchivosMuertos_Load(object sender, EventArgs e)
        {



        }



        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmPacientesFallecidos());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmPapeleraReciclaje());
        }
    }
}
