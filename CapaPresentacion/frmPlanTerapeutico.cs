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
    public partial class frmPlanTerapeutico : Form
    {
        public frmPlanTerapeutico()
        {
            InitializeComponent();

            this.ttMensaje.SetToolTip(this.txtNombre_Paciente, "Ingrese el Nombre del Paciente");
            this.ttMensaje.SetToolTip(this.txtNumero_Documento, "Ingrese el numero de documento");

            this.ttMensaje.SetToolTip(this.btnAñadir, "Añadir Recipe e Indicaciones al Plan Terapeutico");
            this.ttMensaje.SetToolTip(this.btnQuitar, "Quitar Recipe e Indicaciones del Plan Terapeutico");


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmPlanTerapeutico_Load(object sender, EventArgs e)
        {
            LlenarComboRecipe();


            Deshabilitar();

        }




        private void LlenarComboRecipe()
        {



            //traer toda la tabla de medicamentos


            this.cbMedicamento.DataSource = NReceta.Mostrar();
            cbMedicamento.ValueMember = "medicamento";
            cbMedicamento.DisplayMember = "medicamento";



            this.cbPresentacion.DataSource = NReceta.Mostrar();
            cbPresentacion.ValueMember = "presentacion";
            cbPresentacion.DisplayMember = "presentacion";

            this.cbDosis.DataSource = NReceta.Mostrar();
            cbDosis.ValueMember = "dosis";
            cbDosis.DisplayMember = "dosis";


        }


        private void Deshabilitar()
        {
            this.groupBox_Recipe.Enabled = false;

            this.groupBox_Indicaciones.Enabled = false;

            this.groupBox_Plan_Terapeutico_Lista.Enabled = false;


        }

        private void Habilitar()
        {

            this.groupBox_Recipe.Enabled = true;

            this.groupBox_Indicaciones.Enabled = true;

            this.groupBox_Plan_Terapeutico_Lista.Enabled = true;

        }


        private int Buscar_idPac_por_cedula()
        {

            string cedula_del_pac = this.txtNumero_Documento.Text;

            DataTable paciente_tabla = new DataTable();

            paciente_tabla = NPacientes.BuscarNum_Documento(cedula_del_pac);

            int id_del_pac = 0;

            if (paciente_tabla.Rows.Count == 0)
            {
                MessageBox.Show("no existe ese paciente");
                id_del_pac = 0;
            }
            else
            {

                id_del_pac = Convert.ToInt32(paciente_tabla.Rows[0][0]);
                string nombre_del_pac = Convert.ToString(paciente_tabla.Rows[0][1]);
                string sexo_del_pac = Convert.ToString(paciente_tabla.Rows[0][5]);

                this.txtNombre_Paciente.Text = nombre_del_pac;
                this.txtSexo.Text = sexo_del_pac;



                //lblTotal.Text = "Total de Pacientes: " + Convert.ToString(paciente_tabla.Rows.Count);
            }

            return id_del_pac;

        }



        private void txtNumero_Documento_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {

                int id_del_paciente_a_cargar;

                id_del_paciente_a_cargar = Buscar_idPac_por_cedula();

                if (id_del_paciente_a_cargar > 0)
                {

                }
                else
                {
                    MessageBox.Show("Este paciente no esta registrado");
                }

            }
        }

        private void btnNuevo_informe_Click(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void cbMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
