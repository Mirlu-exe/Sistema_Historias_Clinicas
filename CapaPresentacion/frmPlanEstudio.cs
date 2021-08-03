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

        private void btnAñadir_Click(object sender, EventArgs e)
        {

            string examen = this.cbExamenes.Text;
            string muestra = this.cbMuestras.Text;
            string nota = this.txtNota.Text;


            // Add more items to the list  
            listBox1.Items.Add( examen + " " + muestra + "  \n Notas: " + nota + "  \n");



            //// Read List items  
            //foreach (string name in names)
            //{
            //    Console.Write($"{name}, ");
            //}
        }

        private void btnGuardar_informe_Click(object sender, EventArgs e)
        {
            
        }
    }
}
