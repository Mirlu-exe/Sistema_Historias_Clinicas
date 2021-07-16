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

using CapaDatos;
using CapaNegocio;
using Utilidades;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {


        private int id_de_coincidencia;
        //aqui se le da el valor del id del usuario actual.
        public static DUsuario usuarioRespuestas = new DUsuario();

        


        private static frmUsuarios _instancia;

        public static frmUsuarios GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new frmUsuarios();
            }
            return _instancia;
        }







        private bool IsNuevo = false;

        private bool IsEditar = false;

        private int id_selected_user;


        public static DUsuario Session_Actual = frmPrincipal.User_Actual;



        public frmUsuarios()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombreUsuario, "Ingrese el Nombre del Usuario");

            this.ttMensaje.SetToolTip(this.txtCargo, "Seleccione el cargo del usuario");
            this.ttMensaje.SetToolTip(this.txtEspecialidad, "Ingrese la especialidad del usuario");
            this.ttMensaje.SetToolTip(this.cmbAcceso, "Seleccione el tipo de acceso");
            this.ttMensaje.SetToolTip(this.txtLogin, "Ingrese el nombre de acceso");
            this.ttMensaje.SetToolTip(this.txtClave, "Ingrese la clave del usuario");

            this.btnAnular.Enabled = false;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();

            this.btnPreguntasSeguridad.Enabled = false;

            OcultarColumnas();

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

            this.txtNombreUsuario.Text = string.Empty;
            this.txtCargo.Text = string.Empty;
            this.txtEspecialidad.Text = string.Empty;
            this.cmbAcceso.Text = string.Empty;
            this.txtClave.Text = string.Empty;
            this.txtLogin.Text = string.Empty;
            this.cmbEstado.Text = string.Empty;



        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtCodigoUsuario.ReadOnly = !valor;
            this.txtNombreUsuario.ReadOnly = !valor;
            this.txtCargo.ReadOnly = !valor;
            this.txtEspecialidad.ReadOnly = !valor;
            this.txtClave.ReadOnly = !valor;
            this.txtLogin.ReadOnly = !valor;





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

            this.dataListado.Columns["idusuario"].Visible = false;
            this.dataListado.Columns["password"].Visible = false;
            this.dataListado.Columns["salt"].Visible = false;

        }


        //Método Mostrar
        private void Mostrar()
        {


            this.dataListado.DataSource = NUsuario.Mostrar();


            this.OcultarColumnas();
            lblTotal.Text = "Total de Usuarios: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarNombre
        private void BuscarNombre()
        {
            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("nombre LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;*/


            this.dataListado.DataSource = NUsuario.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();


            lblTotal.Text = "Total de Usuarios: " + Convert.ToString(dataListado.Rows.Count);
        }


        private void BuscarCargo()
        {

            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("cargo LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;*/

            this.dataListado.DataSource = NUsuario.BuscarCargo(this.txtBuscar.Text);
            this.OcultarColumnas();




            lblTotal.Text = "Total de Usuarios: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void BuscarAcceso()
        {

            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("cargo LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;*/

            this.dataListado.DataSource = NUsuario.BuscarAcceso(this.txtBuscar.Text);
            this.OcultarColumnas();




            lblTotal.Text = "Total de Usuarios: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtNombreUsuario.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (this.txtClave.TextLength < 8)
            {
                MessageBox.Show("Contraseña muy corta, por motivos de seguridad debe tener minimo 8 caracteres");
                this.txtClave.Clear();
                this.txtClave.Focus();
            }


            try
            {
                string rpta = "";
                if (string.IsNullOrEmpty(txtNombreUsuario.Text) || string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrEmpty(txtClave.Text) || string.IsNullOrEmpty(txtCargo.Text) || string.IsNullOrEmpty(txtEspecialidad.Text)
                    || cmbAcceso.SelectedIndex == -1 || cmbEstado.SelectedIndex == -1)
                {
                    MensajeError("No se pueden dejar campos vacios");


                    if (this.validarExisteUsuario(this.txtLogin.Text) == true)
                    {

                        MensajeError("Hay un usuario con este nombre. Intente con otro.");
                    }

                }
                else
                {



                    if (this.IsNuevo)
                    {


                        if (this.IsNuevo)
                        {

                            string pswd_plain;
                            string pswd_encrypt;
                            string pswd_salt;

                            pswd_plain = this.txtClave.Text.Trim();

                            HashWithSaltResult hashWithSaltResult = SHA256Implementation.CreateEncriptHashWithSalt(pswd_plain, DateTime.Now.ToString());
                            pswd_encrypt = hashWithSaltResult.Digest;
                            pswd_salt = hashWithSaltResult.Salt;

                            rpta = NUsuario.Insertar(this.txtNombreUsuario.Text.Trim().ToUpper(),
                            this.txtCargo.Text.Trim().ToUpper(), this.txtEspecialidad.Text.Trim().ToUpper(),
                            this.cmbAcceso.Text, this.txtLogin.Text.Trim().ToUpper(), pswd_encrypt, this.cmbEstado.Text, pswd_salt);





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



                    }
                    else
                    {

                        string pswd_plain;
                        string pswd_encrypt;
                        string pswd_salt;

                        pswd_plain = this.txtClave.Text.Trim();

                        HashWithSaltResult hashWithSaltResult = SHA256Implementation.CreateEncriptHashWithSalt(pswd_plain, DateTime.Now.ToString());
                        pswd_encrypt = hashWithSaltResult.Digest;
                        pswd_salt = hashWithSaltResult.Salt;

                        rpta = NUsuario.Editar(Convert.ToInt32(this.txtCodigoUsuario.Text), this.txtNombreUsuario.Text.Trim().ToUpper(),
                         this.txtCargo.Text.Trim().ToUpper(), this.txtEspecialidad.Text.Trim().ToUpper(),
                         this.cmbAcceso.Text, this.txtLogin.Text.Trim().ToUpper(), pswd_encrypt, this.cmbEstado.Text, pswd_salt);

                        



                    }

                    if (rpta.Equals("OK"))
                    {




                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el usuario");
                            this.OperacionInsertarUsuario();
                        }
                        else
                        {
                            this.MensajeOk("Se Actualizó de forma correcta el usuario");
                            this.OperacionEditarUsuario();
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
                    this.txtCodigoUsuario.Text = "";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        public bool validarExisteUsuario(string login)
        {
            bool resultado = false;


            SqlConnection SqlCon = new SqlConnection();

            SqlDataReader dr;

            //Código
            SqlCon.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon.Open();
            //Establecer el Comando
            SqlCommand SqlCmd = new SqlCommand("select * from Usuario where login ='" + login + "' and estado = 'Activo'");
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
            if (!this.txtCodigoUsuario.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
                this.cmbEstado.Enabled = true;
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el usuario a Modificar");
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
            if (this.cblBusqueda.Text.Equals("Nombre"))
            {



                this.BuscarNombre();
            }
            else if (this.cblBusqueda.Text.Equals("Cargo"))
            {
                this.BuscarCargo();
            }
            else if (this.cblBusqueda.Text.Equals("Nivel Acceso"))
            {
                this.BuscarAcceso();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.cblBusqueda.Text.Equals("Nombre"))
            {



                this.BuscarNombre();
            }
            else if (this.cblBusqueda.Text.Equals("Cargo"))
            {
                this.BuscarCargo();
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
            this.txtCodigoUsuario.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idusuario"].Value);
            this.txtNombreUsuario.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtCargo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["cargo"].Value);
            this.txtEspecialidad.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["especialidad"].Value);

            this.cmbAcceso.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["acceso"].Value);
            this.txtLogin.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["login"].Value);
            this.txtClave.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["password"].Value);

            this.cmbEstado.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["estado"].Value);

            

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Anular los/el usuario", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = NUsuario.Anular(Convert.ToInt32(Codigo));


                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Anuló Correctamente El Usuario");
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void OperacionInsertarUsuario()
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
            SqlCmd2.Parameters.AddWithValue("@d2", "Se ha registrado un nuevo usuario al sistema");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }



        private void OperacionEditarUsuario()
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
            SqlCmd2.Parameters.AddWithValue("@d2", "Se editó un usuario");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }



        private void OperacionAnularUsuario()
        {



            

             //Operacion Anular
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion) values (@d1,@d2)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "Se anuló un usuario");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }

        private void cblBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_MouseHover(object sender, EventArgs e)
        {
            this.ttMensaje.SetToolTip(this.label11, "Campo Obligatorio");
        }

        private void label14_MouseHover(object sender, EventArgs e)
        {
            this.ttMensaje.SetToolTip(this.label14, "Campo Obligatorio");
        }

        private void label15_MouseHover(object sender, EventArgs e)
        {
            this.ttMensaje.SetToolTip(this.label15, "Campo Obligatorio");
        }

        private void label16_MouseHover(object sender, EventArgs e)
        {
            this.ttMensaje.SetToolTip(this.label16, "Campo Obligatorio");
        }

        private void label17_MouseHover(object sender, EventArgs e)
        {
            this.ttMensaje.SetToolTip(this.label17, "Campo Obligatorio");
        }

        private void btnPreguntasSeguridad_Click(object sender, EventArgs e)
        {


            if ( string.IsNullOrEmpty(this.txtCodigoUsuario.Text) ) //se verifica que contenga datos
            {

                MessageBox.Show("Select a user!");




            }
            else
            {

                //aca le estoy pasando el valor de id_del_usuario, al form de preguntas de seguridad.
                usuarioRespuestas.Idusuario = id_selected_user;


                frmConfigPreguntasSeguridad frm_preguntasseguridad = new frmConfigPreguntasSeguridad();

                frm_preguntasseguridad.Show();
            }



        }

        private void txtCodigoUsuario_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCodigoUsuario.Text))  //en caso de que el codigo esté vacio
            {

                this.btnPreguntasSeguridad.Enabled = false;

            }else if (this.txtCodigoUsuario.Text == "0") //en caso de que el id por alguna razon sea 0
            {

                this.btnPreguntasSeguridad.Enabled = false;

            }
            else //en caso de que tenga cualquier otro numero.
            {
                id_selected_user = Convert.ToInt32(this.txtCodigoUsuario.Text);
                this.btnPreguntasSeguridad.Enabled = true;
            }

            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtCodigoUsuario.Clear();
            this.txtLogin.Clear();
            this.txtNombreUsuario.Clear();
            this.txtClave.Clear();
            this.txtCargo.Clear();
            this.txtEspecialidad.Clear();
            this.cmbAcceso.SelectedIndex = -1;
            this.cmbEstado.SelectedIndex = -1;



        }

        private void txtCodigoUsuario_Leave(object sender, EventArgs e)
        {
         
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (this.txtClave.TextLength < 8)
            {
                MessageBox.Show("Contraseña muy corta, por motivos de seguridad debe tener minimo 8 caracteres");
                this.txtClave.Clear();
                this.txtClave.Focus();
            }

        }
    }



}
