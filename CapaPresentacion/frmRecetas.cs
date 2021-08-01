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
    public partial class frmRecetas : Form
    {

        private bool IsNuevo = false;

        private bool IsEditar = false;
        

        public static DUsuario Session_Actual = frmPrincipal.User_Actual;



        public frmRecetas()
        {
            InitializeComponent();



            this.ttMensaje.SetToolTip(this.txtMedicamento, "Ingrese el medicamento");

            this.ttMensaje.SetToolTip(this.txtPresentacion, "Ingrese la presentacion");
            this.ttMensaje.SetToolTip(this.txtDosis, "Ingrese la dosis");

            this.btnAnular.Enabled = false;
        }

        private void frmRecetas_Load(object sender, EventArgs e)
        {
            
            this.Habilitar(false);
            this.Botones();

            //aca uso el left join
            this.dataListado.DataSource = Operacion_Mostrar();


            lblTotal.Text = "Total de Recetas: " + Convert.ToString(dataListado.Rows.Count);

            this.OcultarColumnas();

        }

      

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
            this.txtidReceta.Text = string.Empty;

            this.txtMedicamento.Text = string.Empty;
            this.txtPresentacion.Text = string.Empty;
            this.txtDosis.Text = string.Empty;






        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtidReceta.ReadOnly = !valor;
            this.txtMedicamento.ReadOnly = !valor;
            this.txtPresentacion.ReadOnly = !valor;
            this.txtDosis.ReadOnly = !valor;






            //this.btnLimpiar.Enabled = valor;

        }

        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar) //Alt + 124
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }

        }


        //Método para ocultar columnas
        private void OcultarColumnas()
        {

            //this.dataListado.Columns[0].Visible = false;
            //this.dataListado.Columns[1].Visible = false;
            this.dataListado.Columns[1].Visible = false;
        }


        //Método Mostrar
        private void Mostrar()
        {


            this.dataListado.DataSource = NReceta.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Recetas: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarMedicamento
        private void BuscarMedicamento()
        {
            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("medicamento LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;*/


            this.dataListado.DataSource = NReceta.BuscarMedicamento(this.txtBuscar.Text);
            this.OcultarColumnas();


            lblTotal.Text = "Total de Recetas: " + Convert.ToString(dataListado.Rows.Count);
        }


        //Método BuscarPresentacion
        private void BuscarPresentacion()
        {
            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("presentacion LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;*/

            this.dataListado.DataSource = NReceta.BuscarPresentacion(this.txtBuscar.Text);
            this.OcultarColumnas();



            lblTotal.Text = "Total de Recetas: " + Convert.ToString(dataListado.Rows.Count);
        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtMedicamento.Text == string.Empty || this.txtPresentacion.Text == string.Empty || this.txtDosis.Text == string.Empty  ||
                    string.IsNullOrEmpty(lblCodPac.Text) )
                {
                    MensajeError("No se pueden dejar campos vacios");

                }
                else
                {



                    if (this.IsNuevo)
                    {


                        //rpta = NReceta.Insertar(this.txtMedicamento.Text.Trim().ToUpper(), this.txtPresentacion.Text.Trim().ToUpper(), this.txtDosis.Text.Trim().ToUpper());

                        



                        rpta = OperacionInsertar_Receta();




                    }
                    else
                    {



                        rpta = NReceta.Editar(Convert.ToInt32(this.txtidReceta.Text), this.txtMedicamento.Text.Trim().ToUpper(), this.txtPresentacion.Text.Trim().ToUpper(), this.txtDosis.Text.Trim().ToUpper());





                    }

                    if (rpta.Equals("OK"))
                    {




                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta la receta");
                            //this.OperacionInsertarReceta();
                        }
                        else
                        {
                            this.MensajeOk("Se Actualizó de forma correcta la receta");
                            //this.OperacionEditarReceta();

                        }

                    }
                    else
                    {


                        this.MensajeError(rpta);

                    }

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    //this.Mostrar();
                    this.dataListado.DataSource = Operacion_Mostrar();
                    this.txtidReceta.Text = "";


                    lblTotal.Text = "Total de Recetas: " + Convert.ToString(dataListado.Rows.Count);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtidReceta.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el plan terapeutico a Modificar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Anular"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Anular"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (this.cmbTipoReceta.Text.Equals("Medicamento"))
            {
                this.BuscarMedicamento();

            }
            else
            {

                this.BuscarPresentacion();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.cmbTipoReceta.Text.Equals("Medicamento"))
            {
                this.BuscarMedicamento();

            }
            else
            {

                this.BuscarPresentacion();
            }
        }

        private void chkAnular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnular.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
                this.btnAnular.Enabled = true;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
                this.btnAnular.Enabled = false;
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {



            //int IdMedicamentoSeleccionado;
            //IdMedicamentoSeleccionado = Convert.ToInt32(this.dataListado.CurrentRow.Cells["id"].Value);


            //string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            //string Query = "select * from Medicamento_Pivote where id ='" + IdMedicamentoSeleccionado + "' ;";
            //SqlConnection conDataBase = new SqlConnection(CN);
            //SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            //SqlDataReader myReader;

            //try
            //{

            //    conDataBase.Open();
            //    myReader = cmdDataBase.ExecuteReader();

            //    while (myReader.Read())
            //    {

            //        string nombre = myReader["nombre"].ToString();




            //    }



            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());

            //}


            this.txtidReceta.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["id"].Value);
            this.txtMedicamento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells[2].Value);
            this.txtPresentacion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells[3].Value);
            this.txtDosis.Text = Convert.ToString(this.dataListado.CurrentRow.Cells[4].Value);
        }


        //OPERACIONES INSERTAR MEDICAMENTOS
//--------------------------------------------------------------
         //1-.INSERTAR NOMBRE DE MEDICAMIENTOS
        private int OperacionInsertar_Meds_Nombres()
        {

            int resultado = 0;

            string rpta2 = "";
            string rpta3 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "INSERT INTO Meds_Nombres (nombre) VALUES (@d1)  SELECT SCOPE_IDENTITY()";


            SqlCmd2.Parameters.AddWithValue("@d1", this.txtMedicamento.Text);




            DataTable DtResultado = new DataTable();

            try
            {

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd2);
                SqlDat.Fill(DtResultado);

                resultado = Convert.ToInt32(DtResultado.Rows[0][0]);
    

             }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error.", ex.Message);
            }

            return resultado;




        }

        //2-.INSERTAR DOSIS DE MEDICAMIENTOS
        private int OperacionInsertar_Meds_Dosis()
        {

            int resultado = 0;

            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "INSERT INTO Meds_Dosis (nombre) VALUES (@d1) SELECT SCOPE_IDENTITY()";


            SqlCmd2.Parameters.AddWithValue("@d1", txtDosis.Text);






            DataTable DtResultado = new DataTable();

            try
            {

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd2);
                SqlDat.Fill(DtResultado);

                resultado = Convert.ToInt32(DtResultado.Rows[0][0]);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error.", ex.Message);
            }

            return resultado;




            /**string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion) values (@d1,@d2)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "Se ha registrado el nuevo plan terapeutico al sistema");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

           **/


        }

        //3-. INSETAR PRESENTACION
        private int OperacionInsertar_Meds_Presentacion()
        {

            int resultado = 0;

            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "INSERT INTO Meds_Presentacion (nombre) VALUES (@d1) SELECT SCOPE_IDENTITY()";


            SqlCmd2.Parameters.AddWithValue("@d1", txtPresentacion.Text);



            DataTable DtResultado = new DataTable();

            try
            {

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd2);
                SqlDat.Fill(DtResultado);

                resultado = Convert.ToInt32(DtResultado.Rows[0][0]);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error.", ex.Message);
            }

            return resultado;




            /**string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion) values (@d1,@d2)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "Se ha registrado el nuevo plan terapeutico al sistema");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

           **/


        }
        //----------------------------------------------------------------


        //MOSTRAR TODOS LOS DATOS
       
        private DataTable Operacion_Mostrar() 
        {

            DataTable DtResultado = new DataTable("tablita");

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_mostrar_meds";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;

                MessageBox.Show("NO FURULA " + ex.ToString() + "");
            }
            return DtResultado;

        }




        private string OperacionInsertar_Receta()
        {



            int id_med;

            id_med = OperacionInsertar_Meds_Nombres();

            //MessageBox.Show("Hola! el id del nombre que acabas de escribir es: " + id_med + ":)");



            int id_presentacion;

            id_presentacion = OperacionInsertar_Meds_Presentacion();

            //MessageBox.Show("Hola! el id de la presentacion que acabas de escribir es: " + id_presentacion + ":)");



            int id_dosis;

            id_dosis = OperacionInsertar_Meds_Dosis();

            //MessageBox.Show("Hola! el id de la dosis que acabas de escribir es: " + id_dosis + ":)");



            string estado;

            estado = "Activo";



            //Aqui es donde se guardan las id en la tabla pivote:

            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();


            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
          

            SqlCmd2.CommandText = "insert into Medicamentos_Pivote (idmed, idpresentacion, iddosis, estado) values (@d1,@d2, @d3, @d4)";

            //SqlCmd2.CommandText = "INSERT INTO Medicamentos_Pivote (idmed, idpresentacion, iddosis) SELECT idmed, idpresentacion, iddosis FROM Medicamentos_Pivote    LEFT JOIN Meds_Nombres ON Medicamentos_Pivote.idmed = Meds_Nombres.id     LEFT JOIN Meds_Presentacion ON Medicamentos_Pivote.idpresentacion = Meds_Presentacion.id    LEFT JOIN Meds_Dosis ON Medicamentos_Pivote.iddosis = Meds_Dosis.id; ";



            SqlCmd2.Parameters.AddWithValue("@d1", id_med);
            SqlCmd2.Parameters.AddWithValue("@d2", id_presentacion);
            SqlCmd2.Parameters.AddWithValue("@d3", id_dosis);
            SqlCmd2.Parameters.AddWithValue("@d4", estado);




            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";


            return rpta2;

        }




        private void OperacionEditarReceta()
        {


            // Operacion Anular
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion) values (@d1,@d2)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "Se editó una receta");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";


            

        }


        // Operacion Anular en funcionamiento chquear mas tarde
        private void OperacionAnularReceta()
        {


            // Operacion Anular
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion) values (@d1,@d2)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "Se anuló una receta");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            frmVistaPacientes form = new frmVistaPacientes();
            form.ShowDialog();
        }

        private void cmbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Anular las/la receta", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = NReceta.Anular(Convert.ToInt32(Codigo));


                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Anular Correctamente la receta");
                                this.OperacionAnularReceta();
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }


                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
           
            
        }

        private void cmbPacientes_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void txtPresentacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
