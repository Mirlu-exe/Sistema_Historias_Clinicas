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
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class frmControlEstadistico : Form
    {


        private bool IsNuevo = false;


        public static DUsuario Session_Actual = frmPrincipal.User_Actual;

        public frmControlEstadistico()
        {
            InitializeComponent();
        }

        private void frmControlEstadistico_Load(object sender, EventArgs e)
        {
            //this.Mostrar();
            this.Habilitar();
            this.Botones();

            lblFechaHora.Text = DateTime.Now.ToString();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString();
        }


        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo) //Alt + 124
            {
                this.Habilitar();
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Deshabilitar();
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }

        }

        //Habilitar los controles del formulario
        private void Habilitar()
        {
            this.rbPaciente.Enabled = true;
            this.rbHistoriaMedica.Enabled = true;
            this.rbUsuarios.Enabled = true;
            this.cbCampo.Enabled = true;
            this.lblFechaHora.Enabled = true;

        }

        //Deshabilitar los controles del formulario
        private void Deshabilitar()
        {
            this.rbPaciente.Enabled = false;
            this.rbHistoriaMedica.Enabled = false;
            this.rbUsuarios.Enabled = false;
            this.cbCampo.Enabled = false;
            this.lblFechaHora.Enabled = false;

        }


        //Método Mostrar
        private void Mostrar_Graficos()
        {

            if (this.rbPaciente.Checked)
            {
                MessageBox.Show("se mostrará la bd de pacientes");
                //this.dataListado.DataSource = NControlEstadistico.Mostrar_Graficos_Pacientes();

            }
            else if (this.rbHistoriaMedica.Checked)
            {
                MessageBox.Show("se mostrará la bd de pacientes");
                //this.dataListado.DataSource = NControlEstadistico.Mostrar_Graficos_HistoriasMedicas();
            }
            else if (this.rbUsuarios.Checked)
            {
                MessageBox.Show("se mostrará la bd de usuarios");
                //this.dataListado.DataSource = NControlEstadistico.Mostrar_Graficos_Usuarios();
            }

            lblTotal.Text = "Total de Pacientes: " + Convert.ToString(dataListado.Rows.Count);


        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //tomar el id del usuario actual

            //seleccionar el nombre del tipo de grafica

            //seleccionar el origen de datos

            //seleccionar el campo

            //seleccionar la fecha y hora en que se creo el grafico
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Deshabilitar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rbHistoriaMedica.Checked = false;
            rbPaciente.Checked = false;
            rbUsuarios.Checked = false;

            cbCampo.SelectedIndex = -1;

            cblBusqueda.SelectedIndex = 0;
            this.txtBuscar.Clear();


        }

        private void rbPaciente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPaciente.Checked)
            {
                //cargar los campos
                //Edad, Sexo, Estado Civil 
                //en el cbCampo
            }
        }

        private void rbHistoriaMedica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHistoriaMedica.Checked)
            {
                //cargar los campos
                //Diagnosticos, Tipo de Sangre, Razon consulta
                //en el cbCampo
            }
        }

        private void rbUsuarios_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuarios.Checked)
            {
                //cargar los campos
                //calcular la cantidad de Pacientes registrados por Asistente
                //calcular la cantidad de Citas registradas por Asistentes
                //calcular la cantidad de dinero que ha ganado cada Asistente por dia
                //calcular la cantidad de dinero que ha ganado cada Asistente por mes
                //calcular la cantidad de dinero que ha ganado cada Asistente por año
                //en el cbCampo
            }
        }

        private void btnCrearGrafico_Click(object sender, EventArgs e)
        {

        }
    }
}
