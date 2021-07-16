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

            LlenarComboPacientes();

            this.cmbPacientes.SelectedIndex = -1;

            this.ttMensaje.SetToolTip(this.cmbPacientes, "Seleccione el paciente");

            this.ttMensaje.SetToolTip(this.txtMedicamento, "Ingrese el medicamento");

            this.ttMensaje.SetToolTip(this.txtPresentacion, "Ingrese la presentacion");
            this.ttMensaje.SetToolTip(this.txtDosis, "Ingrese la dosis");
            this.ttMensaje.SetToolTip(this.txtDuracion, "Ingrese la duracion");
            this.ttMensaje.SetToolTip(this.txtCantidad, "Ingrese la cantidad");

            this.btnAnular.Enabled = false;
        }

        private void frmRecetas_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
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
            this.txtidReceta.Text = string.Empty;
            this.cmbPacientes.SelectedIndex = -1;
            this.txtMedicamento.Text = string.Empty;
            this.txtPresentacion.Text = string.Empty;
            this.txtDosis.Text = string.Empty;
            this.txtDuracion.Text = string.Empty;
            this.txtCantidad.Text = string.Empty;






        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtidReceta.ReadOnly = !valor;
            this.txtMedicamento.ReadOnly = !valor;
            this.txtPresentacion.ReadOnly = !valor;
            this.txtDosis.ReadOnly = !valor;
            this.txtDuracion.ReadOnly = !valor;
            this.txtCantidad.Enabled = valor;
            this.cmbPacientes.Enabled = valor;






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
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }

        }


        //Método para ocultar columnas
        private void OcultarColumnas()
        {

            this.dataListado.Columns[0].Visible = false;
            //this.dataListado.Columns[1].Visible = false;

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


        private void LlenarComboPacientes()
        {

            this.cmbPacientes.DataSource = NPacientes.Mostrar();
            cmbPacientes.ValueMember = "idpaciente";
            cmbPacientes.DisplayMember = "nombre";


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.cmbPacientes.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtMedicamento.Text == string.Empty || this.txtPresentacion.Text == string.Empty || this.txtDuracion.Text == string.Empty || this.txtDosis.Text == string.Empty || this.txtCantidad.Text == string.Empty ||
                    string.IsNullOrEmpty(lblCodPac.Text) || this.cmbPacientes.SelectedIndex == -1)
                {
                    MensajeError("No se pueden dejar campos vacios");

                }
                else
                {



                    if (this.IsNuevo)
                    {


                        rpta = NReceta.Insertar(Convert.ToInt32(this.lblCodPac.Text), this.txtMedicamento.Text.Trim().ToUpper(), this.txtPresentacion.Text.Trim().ToUpper(), this.txtDosis.Text.Trim().ToUpper(), this.txtDuracion.Text.Trim().ToUpper(), Convert.ToInt32(this.txtCantidad.Text));





                        // Operacion Insertar


                        /*SqlConnection SqlCon2 = new SqlConnection();




                        SqlCon2.ConnectionString = Conexion.Cn;
                        SqlCon2.Open();

                        SqlCommand SqlCmd2 = new SqlCommand();
                        SqlCmd2.Connection = SqlCon2;
                        SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion) values (@d1,@d2)";





                        SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
                        SqlCmd2.Parameters.AddWithValue("@d2", "Se ha registrado un nuevo diagnostico al sistema");





                        //Ejecutamos nuestro comando

                        rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";*/






                    }
                    else
                    {



                        rpta = NReceta.Editar(Convert.ToInt32(this.txtidReceta.Text), Convert.ToInt32(this.lblCodPac.Text), this.txtMedicamento.Text.Trim().ToUpper(), this.txtPresentacion.Text.Trim().ToUpper(), this.txtDosis.Text.Trim().ToUpper(), this.txtDuracion.Text.Trim().ToUpper(), Convert.ToInt32(this.txtCantidad.Text));





                    }

                    if (rpta.Equals("OK"))
                    {




                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el plan terapeutico");
                            //this.OperacionInsertarReceta();
                        }
                        else
                        {
                            this.MensajeOk("Se Actualizó de forma correcta el plan terapeutico");
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
                    this.Mostrar();
                    this.txtidReceta.Text = "";


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
            int idpacienteseleccionado;
            idpacienteseleccionado = Convert.ToInt32(this.dataListado.CurrentRow.Cells["idpaciente"].Value);


            string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            string Query = "select * from Paciente where idpaciente ='" + idpacienteseleccionado + "' ;";
            SqlConnection conDataBase = new SqlConnection(CN);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;

            try
            {

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {

                    string nombre = myReader["nombre"].ToString();

                    this.cmbPacientes.Enabled = true;

                    this.cmbPacientes.Text = nombre;



                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }


            this.txtidReceta.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idreceta"].Value);
            this.lblCodPac.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idpaciente"].Value);
            this.txtMedicamento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["medicamento"].Value);
            this.txtPresentacion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["presentacion"].Value);
            this.txtDosis.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["dosis"].Value);
            this.txtDuracion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["duracion"].Value);
            this.txtCantidad.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["cantidad"].Value);
        }



        private void OperacionInsertarReceta()
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
            SqlCmd2.Parameters.AddWithValue("@d2", "Se ha registrado el nuevo plan terapeutico al sistema");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            


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
                Opcion = MessageBox.Show("Realmente Desea Eliminar las/la receta", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = NReceta.Eliminar(Convert.ToInt32(Codigo));


                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Eliminó Correctamente el plan terapeutico");
                                this.OperacionAnularReceta();
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }






                        }
                    }
                    this.Mostrar();
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

        private void cmbPacientes_DropDownClosed(object sender, EventArgs e)
        {

            if (this.cmbPacientes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un paciente de la lista");
            }
            else
            {
                //MessageBox.Show(Convert.ToString(this.cmbPacientes.Text));

                string nombrepac = this.cmbPacientes.Text;


                string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                string Query = "select * from Paciente where nombre = '" + nombrepac + "' ;";
                SqlConnection conDataBase = new SqlConnection(CN);
                SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
                SqlDataReader myReader;

                try
                {

                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();

                    while (myReader.Read())
                    {

                        string idpaciente = myReader["idpaciente"].ToString();
                        string nombre = myReader["nombre"].ToString();

                        //MessageBox.Show(idpaciente);

                        this.lblCodPac.Text = idpaciente;



                    }



                }
                catch (Exception ex)
                {


                }


            }
        }
    }
    
}
