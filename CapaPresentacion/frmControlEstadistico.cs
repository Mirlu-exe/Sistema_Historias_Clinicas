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



        public frmControlEstadistico()
        {
            InitializeComponent();
        }

        private void frmControlEstadistico_Load(object sender, EventArgs e)
        {
            //this.Mostrar();
            this.Habilitar();
            this.Botones();
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
            this.cbCampo.Enabled = true;
            this.lblFechaHora.Enabled = true;

        }

        //Deshabilitar los controles del formulario
        private void Deshabilitar()
        {
            this.rbPaciente.Enabled = false;
            this.rbHistoriaMedica.Enabled = false;
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

            



            lblTotal.Text = "Total de Pacientes: " + Convert.ToString(dataListado.Rows.Count);


        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }


    }
}
