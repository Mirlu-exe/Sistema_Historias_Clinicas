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
using CapaNegocio;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class frmPlanEstudio : Form
    {

        private bool IsNuevo = false;

        private bool IsEditar = false;

        public static DUsuario Session_Actual = frmPrincipal.User_Actual;


        public frmPlanEstudio()
        {
            InitializeComponent();



        }

        private void frmPlanEstudio_Load(object sender, EventArgs e)
        {



        }

        DataTable dbdataset;

        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los controles del formulario
        private void Limpiar()
        {



        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
