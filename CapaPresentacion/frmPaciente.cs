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
using System.Text.RegularExpressions;
using CapaDatos;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class frmPaciente : Form
    {

        private bool IsNuevo = false;

        private bool IsEditar = false;

        public DataTable dbdataset;


        public static DUsuario Session_Actual = frmPrincipal.User_Actual;


        SqlDataReader dr;



        public frmPaciente()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre_Paciente, "Ingrese el Nombre del Paciente");
            this.ttMensaje.SetToolTip(this.cblTipo_Documento, "Seleccione el tipo de documento");
            this.ttMensaje.SetToolTip(this.txtNumero_Documento, "Ingrese el numero de documento");
            this.ttMensaje.SetToolTip(this.txtCorreo, "Ingrese el correo");
            this.ttMensaje.SetToolTip(this.txtTalla, "Ingrese la talla del paciente");
            this.ttMensaje.SetToolTip(this.cblSexo, "Seleccione el sexo del paciente");
            this.ttMensaje.SetToolTip(this.cblEstado_Civil, "Seleccione el estado civil del paciente");
            
            this.ttMensaje.SetToolTip(this.txtDireccion, "Ingrese la direccion del paciente");
            this.ttMensaje.SetToolTip(this.txtOcupacion, "Ingrese la ocupacion del paciente");
            this.ttMensaje.SetToolTip(this.txtTelefono, "Ingrese el telefono del paciente");

            this.btnAnular.Enabled = false;
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            

            this.Mostrar();
            this.Habilitar(false);
            this.Botones();


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

            this.txtNombre_Paciente.Text = string.Empty;
            this.txtNumero_Documento.Text = string.Empty;
            this.txtCorreo.Text = string.Empty;
            this.txtPeso.Text = string.Empty;
            this.txtTalla.Text = string.Empty;
            
            this.txtDireccion.Text = string.Empty;
            this.txtOcupacion.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;



        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtIdpaciente.ReadOnly = !valor;
            this.txtNombre_Paciente.ReadOnly = !valor;
            this.txtNumero_Documento.ReadOnly = !valor;
            this.txtCorreo.ReadOnly = !valor;
            this.txtPeso.ReadOnly = !valor;
            this.txtTalla.ReadOnly = !valor;
            
            this.txtDireccion.ReadOnly = !valor;
            this.txtOcupacion.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;



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
            this.dataListado.Columns[1].Visible = false;

        }

        //Método Mostrar
        private void Mostrar()
        {


            this.dataListado.DataSource = NPacientes.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Pacientes: " + Convert.ToString(dataListado.Rows.Count);
        }


        //Método BuscarNombre
        private void BuscarNombre()
        {
            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("nombre LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;*/

            this.dataListado.DataSource = NPacientes.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            



            lblTotal.Text = "Total de Pacientes: " + Convert.ToString(dataListado.Rows.Count);
        }


        private void BuscarNum_Documento()
        {

            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("num_cedula LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;*/




            this.dataListado.DataSource = NPacientes.BuscarNum_Documento(this.txtBuscar.Text);
            this.OcultarColumnas();

            lblTotal.Text = "Total de Pacientes: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtNombre_Paciente.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

           

            try
            {
                string rpta = "";
                if (string.IsNullOrEmpty(txtNombre_Paciente.Text) || cblTipo_Documento.SelectedIndex == -1 || cblSexo.SelectedIndex == -1 || cblEstado_Civil.SelectedIndex == -1 || string.IsNullOrEmpty(txtNumero_Documento.Text)
                    || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtPeso.Text) || string.IsNullOrEmpty(txtTalla.Text) || string.IsNullOrEmpty(txtOcupacion.Text) || string.IsNullOrEmpty(txtTelefono.Text))
                {
                    MensajeError("No se pueden dejar campos vacios");
                    /*errorIcono.SetError(txtNombre, "Ingrese un Valor");
                    errorIcono.SetError(txtApellidos, "Ingrese un Valor");
                    errorIcono.SetError(txtNum_Documento, "Ingrese un Valor");
                    errorIcono.SetError(txtUsuario, "Ingrese un Valor");
                    errorIcono.SetError(txtPassword, "Ingrese un Valor");*/

                  



                }



                


                else
                {




                    if (this.IsNuevo)
                    {


                        if (this.validarExistePaciente(this.txtNumero_Documento.Text) == true)
                        {

                                MensajeError("Ya existe un paciente con este numero de cedula.");

                        }
                        else
                        {

                        rpta = NPacientes.Insertar(this.txtNombre_Paciente.Text.Trim().ToUpper(),
                        this.cblTipo_Documento.Text, this.txtNumero_Documento.Text.Trim().ToUpper(),
                        this.dtpFecha_Nacimiento.Text, this.cblSexo.Text, this.cblEstado_Civil.Text,
                        this.txtDireccion.Text.Trim().ToUpper(), this.txtOcupacion.Text.Trim().ToUpper(),
                        txtTelefono.Text.Trim().ToUpper(), txtCorreo.Text.Trim().ToUpper(), this.txtPeso.Text.Trim().ToUpper(), this.txtTalla.Text.Trim().ToUpper(), this.cblEstado.Text);

                        }

                        



                    }
                    else if (this.IsEditar)
                    {


                        if (this.validarExistePaciente(this.txtNumero_Documento.Text) == true)
                        {

                            rpta = NPacientes.Editar(Convert.ToInt32(this.txtIdpaciente.Text), this.txtNombre_Paciente.Text.Trim().ToUpper(),
                            this.cblTipo_Documento.Text, this.txtNumero_Documento.Text.Trim().ToUpper(),
                            this.dtpFecha_Nacimiento.Text, this.cblSexo.Text, this.cblEstado_Civil.Text,
                            this.txtDireccion.Text.Trim().ToUpper(), this.txtOcupacion.Text.Trim().ToUpper(),
                            txtTelefono.Text.Trim().ToUpper(), txtCorreo.Text.Trim().ToUpper(), this.txtPeso.Text.Trim().ToUpper(), this.txtTalla.Text.Trim().ToUpper(), this.cblEstado.Text);


                        }
                        else
                        {
                            MensajeError("No puede editar un registro que no existe. Porfavor, revise nuevamente los datos");
                        }


                    }


                    if (rpta.Equals("OK"))
                    {




                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el paciente");
                            this.OperacionInsertarPaciente();
                        }
                        else
                        {
                            this.MensajeOk("Se Actualizó de forma correcta el paciente");
                            this.OperacionEditarPaciente();
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
                    this.txtIdpaciente.Text = "";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        public bool validarExistePaciente(string ci)
        {
            bool resultado = false;


            SqlConnection SqlCon = new SqlConnection();



            //Código
            SqlCon.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon.Open();
            //Establecer el Comando
            SqlCommand SqlCmd = new SqlCommand("select * from Paciente where num_cedula ='" + ci + "' ");
            SqlCmd.Connection = SqlCon;
            
            //SqlCmd.CommandType = CommandType.StoredProcedure;
            

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdpaciente.Text.Equals(""))
            {
                this.IsEditar = true;
                this.IsNuevo = false;
                this.Botones();
                //this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el paciente a Modificar");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (this.cblBusqueda.Text.Equals("Nombre"))
            {



                this.BuscarNombre();
            }
            else if (this.cblBusqueda.Text.Equals("Documento"))
            {
                this.BuscarNum_Documento();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.cblBusqueda.Text.Equals("Nombre"))
            {



                this.BuscarNombre();
            }
            else if (this.cblBusqueda.Text.Equals("Documento"))
            {
                this.BuscarNum_Documento();
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

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Anular"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Anular"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {


            this.txtIdpaciente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idpaciente"].Value);
            this.txtNombre_Paciente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.cblTipo_Documento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_cedula"].Value);
            this.txtNumero_Documento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["num_cedula"].Value);
            this.dtpFecha_Nacimiento.Value = Convert.ToDateTime(this.dataListado.CurrentRow.Cells["fecha_nacimiento"].Value);
            this.cblSexo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["sexo"].Value);
            this.cblEstado_Civil.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["estado_civil"].Value);

            this.txtDireccion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value);
            this.txtOcupacion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["ocupacion"].Value);
            this.txtTelefono.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["telefono"].Value);
            this.txtCorreo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["correo"].Value);



            this.txtPeso.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["peso"].Value);
            this.txtTalla.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["talla"].Value);
            this.cblEstado.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["estado"].Value);


            this.Habilitar(false);


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtIdpaciente.Text = string.Empty;
            this.Habilitar(false);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Anular los/el pacientes", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = NPacientes.Anular(Convert.ToInt32(Codigo));


                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Anuló Correctamente El Paciente");
                                this.OperacionAnularPaciente();
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



        private void OperacionInsertarPaciente()
        {

            // Operacion Anular
            string rpta2 = "";



            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion, usuario) values (@d1,@d2, @d3)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "El usuario ha Registrado a un paciente.");
            SqlCmd2.Parameters.AddWithValue("@d3", Session_Actual.Log);





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }



        private void OperacionEditarPaciente()
        {


            // Operacion Anular
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion, usuario) values (@d1,@d2, @d3)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "El usuario " + Session_Actual.Log + " ha Editado un paciente. ");
            SqlCmd2.Parameters.AddWithValue("@d3", Session_Actual.Log);




            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }



        private void OperacionAnularPaciente()
        {


            // Operacion Anular
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion, usuario) values (@d1,@d2, @d3)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "El usuario " + Session_Actual.Log + " ha Anulado a un paciente. ");
            SqlCmd2.Parameters.AddWithValue("@d3", Session_Actual.Log);





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }

        private void txtNumero_Documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if ((!(char.IsDigit(ch))) && Convert.ToInt32(ch) != 8)
            {
                e.Handled = true;

            }
            else if (char.IsControl(ch))
            {
                e.Handled = false;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if ((!(char.IsDigit(ch))) && Convert.ToInt32(ch) != 8)
            {
                e.Handled = true;

            }
            else if (char.IsControl(ch))
            {
                e.Handled = false;
            }
        }


        public static bool validarEmail(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.Replace(email, expresion, string.Empty).Length == 0)
            {

                return true;
            }
            else
            {
                return false;
            }

        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (validarEmail(this.txtCorreo.Text))
            {

            }
            else
            {
                MessageBox.Show("Direccion de correo electronico no valido, el correo debe cumplir con un formato: nombre@dominio.com , " + "debe escribir un correo valido.", "Validacion de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtCorreo.SelectAll();
                this.txtCorreo.Focus();

            }
        }

        private void cblTipo_Documento_Leave(object sender, EventArgs e)
        {
            if (cblTipo_Documento.SelectedIndex == -1)
            {
                errorIcono.SetError(cblTipo_Documento, "Seleccione una opción");
            }
        }

        private void txtNombre_Paciente_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre_Paciente.Text))
            {

                errorIcono.SetError(txtNombre_Paciente, "Introduzca el nombre del paciente.");
            }
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            frmReportePacientes frm = new frmReportePacientes();
            frm.Show();
        }


        private void label12_MouseHover(object sender, EventArgs e)
        {
            this.ttMensaje.SetToolTip(this.label12, "Campo Obligatorio");
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            this.ttMensaje.SetToolTip(this.label2, "Campo Obligatorio");
        }
    }
}
