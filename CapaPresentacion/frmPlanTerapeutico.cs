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


        private bool IsNuevo = false;


        public frmPlanTerapeutico()
        {
            InitializeComponent();

            this.ttMensaje.SetToolTip(this.txtNombre_Paciente, "Ingrese el Nombre del Paciente");
            this.ttMensaje.SetToolTip(this.txtNumero_Documento, "Ingrese el numero de documento");

            this.ttMensaje.SetToolTip(this.btnAñadir, "Añadir Recipe e Indicaciones al Plan de Estudio");
            this.ttMensaje.SetToolTip(this.btnQuitar, "Quitar Recipe e Indicaciones del Plan de Estudio");


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmPlanTerapeutico_Load(object sender, EventArgs e)
        {


            //LlenarComboRecipe();

            LlenarCbMedicamento();


            Deshabilitar();

        }


        //Para llenar el cbMedicamento
        private void LlenarCbMedicamento()
        {

            //llenar el cb medicinas aplicando autocompletado

            DataTable tabla_meds = new DataTable();

            tabla_meds = NReceta.CargarNombreMeds();

            if (tabla_meds == null)
            {
                MessageBox.Show("No hay registros en medicamentos ");

            }
            else
            {
                List<string> meds = tabla_meds.AsEnumerable().Select(r => r.Field<string>("nombre")).ToList();

                string[] meds_array = meds.ToArray();

                var autoComplete = new AutoCompleteStringCollection();
                autoComplete.AddRange(meds_array);

                this.cbMedicamento.AutoCompleteCustomSource = autoComplete;

                //traer toda la tabla de medicamentos
                cbMedicamento.ValueMember = "id"; //id
                cbMedicamento.DisplayMember = "nombre"; //medicamento

                


            }





            //this.cbPresentacion.DataSource = NReceta.Mostrar();
            //cbPresentacion.ValueMember = "presentacion";
            //cbPresentacion.DisplayMember = "presentacion";

            //this.cbDosis.DataSource = NReceta.Mostrar();
            //cbDosis.ValueMember = "dosis";
            //cbDosis.DisplayMember = "dosis";

        }





        //Para llenar el cbPresentacion
        private void LlenarCbPresentacion()
        {
             
            //SQL
            //buscar en la tabla Medicamento_Pivote, las presentaciones que compartan el mismo id



        }









        private void LlenarComboRecipe()
        {


            //llenar el cb medicinas aplicando autocompletado

            DataTable tabla_meds = new DataTable();

            tabla_meds = NReceta.Mostrar();

            if (tabla_meds == null)
            {
                MessageBox.Show("No hay registros en medicamentos ");

            }
            else
            {
            List<string> meds = tabla_meds.AsEnumerable().Select(r => r.Field<string>("medicamento")).ToList();

             string[] meds_array = meds.ToArray();

            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(meds_array);

            this.cbMedicamento.AutoCompleteCustomSource = autoComplete;

            }

          

            



            //para testear el contenido del array
            //foreach (string item in meds_array)
            //{
            //    MessageBox.Show(" wea: " + item + "");
            //}




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
            IsNuevo = true;
        }

        private void cbMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

            string med = this.cbMedicamento.Text;
            string presentacion = this.cbPresentacion.Text;
            string dosis = this.cbDosis.Text;
            string indic = this.txtIndicaciones.Text;


            // Add more items to the list  
            listBox1.Items.Add( med + presentacion + dosis + "  \n Indicaciones: " + indic + "  \n");



            //// Read List items  
            //foreach (string name in names)
            //{
            //    Console.Write($"{name}, ");
            //}

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

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
                        SqlCmd.CommandText = "insert into PlanTerapeutico (cedula_pac, nombre_pac, sexo, recipe_indicaciones, fecha_emision) values (@d1,@d2,@d3,@d4,@d5);";
                        //SqlCmd.CommandType = CommandType.StoredProcedure;

                        DateTime hoy = DateTime.Now;

                        SqlCmd.Parameters.AddWithValue("@d1", this.txtNumero_Documento.Text);
                        SqlCmd.Parameters.AddWithValue("@d2", this.txtNombre_Paciente.Text);
                        SqlCmd.Parameters.AddWithValue("@d3", this.txtSexo.Text);
                        SqlCmd.Parameters.AddWithValue("@d4", this.listBox1.Text);
                        SqlCmd.Parameters.AddWithValue("@d5", hoy);




                        //Ejecutamos nuestro comando

                        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




                    }
                    


                    if (this.IsNuevo)
                    {
                        MessageBox.Show("Se Insertó de forma correcta el plan terapeutico");
                    }


                    this.IsNuevo = false;
                    //this.Limpiar();
                    this.Deshabilitar();




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }



        private void MostrarInfoMedicamento()
        {

            //usar este metodo para hacer querys segun el medicamento seleccionado
            //string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            //SqlConnection conDataBase = new SqlConnection(Cn);

            //SqlDataAdapter cmdDataBase = new SqlDataAdapter("select * from Respuestas_Usuario where idusuario = '" + Id_Usuario + "' ;", conDataBase);

            //DataTable tablita = new DataTable();

            //cmdDataBase.Fill(tablita);

            //int cant_registros = 0;

            //cant_registros = tablita.Rows.Count;

            //int cellValue1 = Convert.ToInt32(tablita.Rows[0][0]);
            //int cellValue2 = Convert.ToInt32(tablita.Rows[1][0]);
            //int cellValue3 = Convert.ToInt32(tablita.Rows[2][0]);

        }

        private void cbPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("helloooooo");
        }

        private void cbMedicamento_SelectionChangeCommitted(object sender, EventArgs e)
        {


        }

        private void cbMedicamento_DropDownClosed(object sender, EventArgs e)
        {

            LlenarCbPresentacion();

        }

        private void cbMedicamento_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void cbMedicamento_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbPresentacion_Enter(object sender, EventArgs e)
        {

            LlenarCbPresentacion();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        //private void cbMedicamento_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    //if (Char.IsLetter(e.KeyChar)) 

        //    //{

        //    //    e.KeyChar = Char.ToUpper(e.KeyChar);

        //    //}

        //}
    }
}
