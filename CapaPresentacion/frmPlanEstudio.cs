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

            this.listBox1.Items.Add("Laboratorio: ");

            this.listBox2.Items.Add("Estudios: ");

            this.lbl_fecha_emision.Text = DateTime.Now.ToShortDateString();

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

            string laboratorio = this.cbLab.Text;
            
            //string nota = this.txtNota.Text;
            // Add more items to the list  
            //listBox1.Items.Add(examen + " " + muestra + "  \n Notas: " + nota + "  \n");


            // Add more items to the list  
            listBox1.Items.Add(laboratorio + " ");

            
        }

        private void btnGuardar_informe_Click(object sender, EventArgs e)
        {

            try
            {
                string rpta = "";
                if (this.txtNombre_Paciente.Text == string.Empty)
                {
                    MessageBox.Show("No puede dejar campos vacios o sin seleccionar. ", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.tabControl1.SelectedIndex = 1;
                }
                else
                {



                    if (this.IsNuevo)
                    {


                        SqlConnection SqlCon = new SqlConnection();



                        //Código
                        SqlCon.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                        SqlCon.Open();
                        //Establecer el Comando
                        SqlCommand SqlCmd = new SqlCommand();
                        SqlCmd.Connection = SqlCon;
                        SqlCmd.CommandText = "spinsertar_planestudio";
                        SqlCmd.CommandType = CommandType.StoredProcedure;


                        string hoy = DateTime.Now.ToShortDateString();


                        //construir el string de Laboratorios
                        StringBuilder sb_lab = new StringBuilder();
                        foreach (string a in listBox1.Items)
                            sb_lab.Append(a);

                        string laboratorios_all = sb_lab.ToString();



                        //construir el string de Examen
                        StringBuilder sb_estudios = new StringBuilder();
                        foreach (string b in listBox2.Items)
                            sb_estudios.Append(b);

                        string estudios_all = sb_estudios.ToString();




                        SqlCmd.Parameters.AddWithValue("@idpaciente", Buscar_idPac_por_cedula());
                        SqlCmd.Parameters.AddWithValue("@laboratorios_all", laboratorios_all);
                        SqlCmd.Parameters.AddWithValue("@estudios_all", estudios_all);
                        SqlCmd.Parameters.AddWithValue("@fechaemision", hoy);


                        //Ejecutamos nuestro comando

                        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




                    }



                    if (this.IsNuevo)
                    {
                        MessageBox.Show("Se Insertó de forma correcta el plan de estudio");
                    }


                    this.IsNuevo = false;
                    this.Limpiar();
                    this.Deshabilitar();




                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }


        }



        private void Deshabilitar()
        {
            this.groupBox3.Enabled = false;



        }

        private void Habilitar()
        {

            this.groupBox3.Enabled = true;


        }




        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnAñadirEstudios_Click(object sender, EventArgs e)
        {
            string estudios = this.cbEstudios.Text;

            // Add more items to the list  
            listBox2.Items.Add(estudios + " " );
        }

        private void btnNuevo_informe_Click(object sender, EventArgs e)
        {
            Habilitar();
            IsNuevo = true;
        }

        private void btnQuitarLab_Click(object sender, EventArgs e)
        {

        }
    }
}
