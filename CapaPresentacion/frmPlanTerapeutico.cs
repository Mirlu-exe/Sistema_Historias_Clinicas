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


        ////variables donde se guardaran valores traidos de otros forms

        public string Cedula_paciente_perteneciente { get; set; }

        public string Cedula_paciente_perteneciente_evol { get; set; }




        public frmPlanTerapeutico(string cedula)
        {
            InitializeComponent();

            this.ttMensaje.SetToolTip(this.txtNombre_Paciente, "Ingrese el Nombre del Paciente");
            this.ttMensaje.SetToolTip(this.txtCedulaPac_Terapeutico, "Ingrese el numero de documento");

            this.ttMensaje.SetToolTip(this.btnAñadir, "Añadir Recipe e Indicaciones al Plan de Estudio");
            this.ttMensaje.SetToolTip(this.btnQuitar, "Quitar Recipe e Indicaciones del Plan de Estudio");

            txtCedulaPac_Terapeutico.Text = cedula;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmPlanTerapeutico_Load(object sender, EventArgs e)
        {


            CargarDatosPaciente();

            //LlenarComboRecipe();

            LlenarCbMedicamento();


            Deshabilitar();


            this.lbl_fecha_emision.Text = DateTime.Now.ToShortDateString();

        }


        private void CargarDatosPaciente()
        {
            // mandar la cedula del paciente a este form y cargar los datos.
            

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
        private List<string> LlenarCbPresentacion( int id_del_medicamento_a_buscar)
        {

            //SQL
            //buscar en la tabla Medicamento_Pivote, las presentaciones que compartan el mismo id

            string rpta = "";

            List<string> Lista_de_id_presentaciones = new List<string>();


            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_buscar_presentacion_segun_nombre_med";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@presentacion_a_buscar";
                ParNombre.SqlDbType = SqlDbType.Int;
                ParNombre.Size = 50;
                ParNombre.Value = id_del_medicamento_a_buscar;
                SqlCmd.Parameters.Add(ParNombre);


                //Ejecutamos nuestro comando

                int resultados = SqlCmd.ExecuteNonQuery();


                //rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";


                //// Add a range of items  
                //int[] presentaciones = { rpta };
                //AuthorList.AddRange(authors);


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }



            return Lista_de_id_presentaciones;


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

            string cedula_del_pac = this.txtCedulaPac_Terapeutico.Text;

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

     

        private void btnAñadir_Click(object sender, EventArgs e)
        {

            string med = this.cbMedicamento.Text;
            string presentacion = this.cbPresentacion.Text;
            string dosis = this.cbDosis.Text;
            string indic = this.txtIndicaciones.Text;


            // Add more items to the list  
            listBox1.Items.Add( med + " " + presentacion + " " + dosis + "  \n Indicaciones: " + indic + "  \n");



            //// Read List items  
            //foreach (string name in names)
            //{
            //    Console.Write($"{name}, ");
            //}

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int posicion = listBox1.SelectedIndex;

            if(posicion == -1)
            {
                MessageBox.Show("seleccione un elemento para quitar de el Plan Terapeutico");
            }
            else
            {
               

                listBox1.Items.RemoveAt(posicion);
            }
            

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
                        SqlCmd.CommandText = "spinsertar_planterapeutico";
                        SqlCmd.CommandType = CommandType.StoredProcedure;




                        string hoy = DateTime.Now.ToShortDateString();



                        StringBuilder sb = new StringBuilder();
                        foreach (string s in listBox1.Items)
                        sb.Append(s);

                        string recipe_e_indicaciones = sb.ToString();


                        SqlCmd.Parameters.AddWithValue("@idpaciente", Buscar_idPac_por_cedula());
                        SqlCmd.Parameters.AddWithValue("@listamedicamentos", recipe_e_indicaciones);
                        SqlCmd.Parameters.AddWithValue("@fechaemision", hoy);


                        //Ejecutamos nuestro comando

                        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";



                        //Establecer el Comando para traer el id del ultimo row añadido
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = SqlCon;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select @@IDENTITY";
  //                      Id_plan_terapeutico_recien_guardado = Convert.ToInt32(cmd.ExecuteScalar());

                        


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




        private void cbPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tablita = new DataTable();

            tablita = TraerDosisMedicamento(this.cbMedicamento.Text, this.cbPresentacion.Text);

            List<string> dosis = tablita.AsEnumerable().Select(r => r.Field<string>("nombre")).ToList();



            this.cbDosis.DataSource = dosis;
        }

        private void cbMedicamento_SelectionChangeCommitted(object sender, EventArgs e)
        {


        }

        private void cbMedicamento_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void cbMedicamento_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void cbMedicamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
                e.KeyChar -= (char)32;
        }

        private void cbPresentacion_Enter(object sender, EventArgs e)
        {


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbMedicamento_TextChanged(object sender, EventArgs e)
        {
            string nombre_med;

            nombre_med = this.cbMedicamento.Text;

            



        }

        private void cbMedicamento_Leave(object sender, EventArgs e)
        {
            

            if ( validarExisteMedicamento(this.cbMedicamento.Text)  )
            {



                MessageBox.Show("el medicamento si existe :) ");


                DataTable tablita = new DataTable();

                tablita = TraerPresentacionMedicamento(this.cbMedicamento.Text);

                List<string> presentaciones = tablita.AsEnumerable().Select(r => r.Field<string>("nombre")).ToList();



                this.cbPresentacion.DataSource = presentaciones;





            }
            else if ( !validarExisteMedicamento(this.cbMedicamento.Text))
            {


                MessageBox.Show("el medicamento no existe, porfavor ingrese un nombre válido");
                this.cbMedicamento.Text = string.Empty;
                this.cbPresentacion.Text = string.Empty;
                this.cbDosis.Text = string.Empty;
                this.cbMedicamento.Focus();


            }
            else
            {
                MessageBox.Show("el medicamento no existe, porfavor ingrese un nombre válido");
                this.cbMedicamento.Text = string.Empty;
                this.cbPresentacion.Text = string.Empty;
                this.cbDosis.Text = string.Empty;
                this.cbMedicamento.Focus();
            }

        }






        public bool validarExisteMedicamento(string nombre_medicamento)
        {


            SqlDataReader dr;

            bool resultado = false;


            SqlConnection SqlCon = new SqlConnection();



            //Código
            SqlCon.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon.Open();
            //Establecer el Comando
            SqlCommand SqlCmd = new SqlCommand("select * from Meds_Nombres where nombre ='" + nombre_medicamento + "' ");
            SqlCmd.Connection = SqlCon;



            try
            {

                dr = SqlCmd.ExecuteReader();

                if (dr.Read())
                {
                    resultado = true;

                }

                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error.", ex.Message);
            }

            return resultado;

        }


        private int TraerIDMedicamento(string nombre)
        {
            int id_del_med = 0;

            DataTable DtResultado = new DataTable("IDMedicamento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_buscar_id_segun_nombre_med";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParMedBuscar = new SqlParameter();
                ParMedBuscar.ParameterName = "@nombre_a_buscar";
                ParMedBuscar.SqlDbType = SqlDbType.VarChar;
                ParMedBuscar.Value = nombre;
                SqlCmd.Parameters.Add(ParMedBuscar);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                DtResultado = null;
            }


            id_del_med = Convert.ToInt32(DtResultado.Rows[0][0]);


            return id_del_med;


        }


        private DataTable TraerPresentacionMedicamento(string nombre_med)
        {

            DataTable DtResultado = new DataTable("PresentacionMedicamento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_mostrar_presentacion_medicamento_segun_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParMedBuscar = new SqlParameter();
                ParMedBuscar.ParameterName = "@nombre_med";
                ParMedBuscar.SqlDbType = SqlDbType.VarChar;
                ParMedBuscar.Value = nombre_med;
                SqlCmd.Parameters.Add(ParMedBuscar);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                DtResultado = null;
            }

            return DtResultado;


        }


        private DataTable TraerDosisMedicamento(string nombre_med, string presentacion)
        {

            DataTable DtResultado = new DataTable("DosisMedicamento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_mostrar_dosis_presentacion_meds";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParMedBuscar = new SqlParameter();
                ParMedBuscar.ParameterName = "@nombre_med";
                ParMedBuscar.SqlDbType = SqlDbType.VarChar;
                ParMedBuscar.Value = nombre_med;
                SqlCmd.Parameters.Add(ParMedBuscar);

                SqlParameter ParPresBuscar = new SqlParameter();
                ParPresBuscar.ParameterName = "@presentacion_med";
                ParPresBuscar.SqlDbType = SqlDbType.VarChar;
                ParPresBuscar.Value = presentacion;
                SqlCmd.Parameters.Add(ParPresBuscar);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                DtResultado = null;
            }

            return DtResultado;


        }



        private void cbPresentacion_Leave(object sender, EventArgs e)
        {


            DataTable tablita = new DataTable();

            tablita = TraerDosisMedicamento(this.cbMedicamento.Text, this.cbPresentacion.Text);

            List<string> dosis = tablita.AsEnumerable().Select(r => r.Field<string>("nombre")).ToList();

            

            this.cbDosis.DataSource = dosis;

            


            
        }


        private void cbDosis_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("tamos listos con el recipe");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int posicion = listBox1.SelectedIndex;

            MessageBox.Show("aaaa  "  + posicion.ToString() + "");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_Documento_TextChanged(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
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

        private void frmPlanTerapeutico_FormClosing(object sender, FormClosingEventArgs e)
        {

           
        }
    }
}
