using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class frmConfigPersonal : Form
    {
        public frmConfigPersonal()
        {
            InitializeComponent();
        }


        public static DUsuario Session_Actual = frmPrincipal.User_Actual;

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void frmConfigPersonal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEditarContrasena frm = new frmEditarContrasena();

            frm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmEditarPreguntasSeguridad frm = new frmEditarPreguntasSeguridad();

            frm.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
