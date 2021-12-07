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

namespace CapaPresentacion
{
    public partial class frmCitas : Form
    {

        private bool IsNuevo = false;

        private bool IsEditar = false;


        public static DUsuario Session_Actual = frmPrincipal.User_Actual;

        public frmCitas()
        {
            InitializeComponent();

            this.ttMensaje.SetToolTip(this.txtNumero_Cedula, "Escriba la cedula del paciente");

            this.ttMensaje.SetToolTip(this.dtpFechaCita, "Ingrese la fecha de la cita");

            fillComboServicios();
            


            this.btnAnular.Enabled = false;
        }

        private void frmCitas_Load(object sender, EventArgs e)
        {

            //traer la tasa del dia guardado en la BD
            traerTasaDelDia();


            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.Servicio' Puede moverla o quitarla según sea necesario.
            this.servicioTableAdapter.Fill(this.dsPrincipal.Servicio);
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.Cita' Puede moverla o quitarla según sea necesario.
            this.citaTableAdapter.Fill(this.dsPrincipal.Cita);
            this.Habilitar(false);
            this.Botones();
           

            dtpFechaCita.Value = DateTime.Now.Date;
            LblHora.Text = DateTime.Now.Date.ToShortDateString();

            Mostrar();
            this.RevisarCitasHoy();
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;


            OcultarColumnas();

            //UsuarioResponsable();

        }

        //Método para ocultar columnas
        private void OcultarColumnas()
        {


            this.dataListado.Columns["idcita"].Visible = false;
            this.dataListado.Columns["idpaciente"].Visible = false;
            this.dataListado.Columns["idusuario"].Visible = false;
            this.dataListado.Columns["idservicio"].Visible = false;
            this.dataListado.Columns["estado"].Visible = false;

            this.dgv_citashoy.Columns["idcita"].Visible = false;
            this.dgv_citashoy.Columns["idpaciente"].Visible = false;
            this.dgv_citashoy.Columns["idusuario"].Visible = false;
            this.dgv_citashoy.Columns["idservicio"].Visible = false;
            this.dgv_citashoy.Columns["estado"].Visible = false;

        }

        public void traerTasaDelDia()
        {
            string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            string Query = "select Tasa_del_dia from TasaDelDia ;";
            SqlConnection conDataBase = new SqlConnection(CN);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader Lectura;

            try
            {

                conDataBase.Open();
                Lectura = cmdDataBase.ExecuteReader();

                while (Lectura.Read())
                {

                    this.txtTasa.Text = (Lectura["Tasa_del_dia"].ToString() );

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void fillComboServicios()
        {


            string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            string Query = "select * from Servicio where estado = 'Activo' ;";
            SqlConnection conDataBase = new SqlConnection(CN);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader Lectura;

            try
            {

                conDataBase.Open();
                Lectura = cmdDataBase.ExecuteReader();

                while (Lectura.Read())
                {

                    cmbServicios.Items.Add(Lectura["nombre"].ToString());



                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        DataTable dbdataset;


        public void UsuarioResponsable()
        {

            this.txtCodUsuario.Text = Convert.ToString(Session_Actual.Idusuario);


            this.lbl_usuario.Text = Session_Actual.Log;

        }


        //Método BuscarPaciente
        private void BuscarPaciente()
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Paciente LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;





            lblTotal.Text = "Total de Citas: " + Convert.ToString(dataListado.Rows.Count);

        }



        //Método BuscarServicio
        private void BuscarServicio()
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Servicio LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;





            lblTotal.Text = "Total de Citas: " + Convert.ToString(dataListado.Rows.Count);

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
            this.txtNumero_Cedula.Text = string.Empty;
            this.txtNombre_Paciente.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;

            this.txtCodServicio.Text = string.Empty;
            this.txtCodUsuario.Text = string.Empty;
            this.txtCodigoPaciente.Text = string.Empty;
            this.txtCosto.Text = string.Empty;
            this.txtCostoBs.Text = string.Empty;
            this.lbl_usuario.Text = string.Empty;
            this.cmbServicios.SelectedIndex = -1;





        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtNumero_Cedula.ReadOnly = !valor;
            //this.txtBuscarServicio.ReadOnly = !valor;



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



        //Método Mostrar
        private void Mostrar()
        {


            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.num_cedula, Paciente.telefono, Paciente.nombre as Paciente, Cita.idusuario, Usuario.login, Cita.fecha, Cita.idservicio, Servicio.nombre as Servicio, Cita.Estado from Cita INNER JOIN dbo.Paciente ON dbo.Cita.idpaciente = dbo.Paciente.idpaciente INNER JOIN dbo.Servicio ON dbo.Cita.idservicio = dbo.Servicio.idservicio INNER JOIN dbo.Usuario ON dbo.Cita.idusuario = dbo.Usuario.idusuario WHERE Cita.estado = 'Activo'", conDataBase);

            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataListado.DataSource = bSource;
                sda.Update(dbdataset);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                MessageBox.Show("Ha ocurrido un error");
            }





            lblTotal.Text = "Total de Citas: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;


            this.txtNumero_Cedula.Focus();

            UsuarioResponsable();

            this.txtEstadoCita.Text = "Activo";



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (string.IsNullOrEmpty(txtCodigoPaciente.Text) || string.IsNullOrEmpty(txtCodServicio.Text) ||
                    cmbServicios.SelectedIndex == -1 || string.IsNullOrEmpty(txtNumero_Cedula.Text))
                {
                    MessageBox.Show("No puede dejar campos vacios o sin seleccionar. ", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {



                    if (this.IsNuevo)
                    {

                        int id_usuario_que_lo_registro = Session_Actual.Idusuario;


                        SqlConnection SqlCon = new SqlConnection();



                        //Código
                        SqlCon.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                        SqlCon.Open();
                        //Establecer el Comando
                        SqlCommand SqlCmd = new SqlCommand();
                        SqlCmd.Connection = SqlCon;
                        SqlCmd.CommandText = "insert into Cita (idpaciente, idusuario, fecha, idservicio, estado, CostoT) values (@d1,@d2,@d3,@d4,@d5, @d6)";
                        //SqlCmd.CommandType = CommandType.StoredProcedure;



                        //Sqlcmd.Parameters.AddWithValue("@d1", txtNombreCliente.Text);
                        SqlCmd.Parameters.AddWithValue("@d1", Convert.ToInt32(this.txtCodigoPaciente.Text));
                        SqlCmd.Parameters.AddWithValue("@d2", id_usuario_que_lo_registro);
                        SqlCmd.Parameters.AddWithValue("@d3", this.dtpFechaCita.Text);

                        SqlCmd.Parameters.AddWithValue("@d4", Convert.ToInt32(this.txtCodServicio.Text));
                        SqlCmd.Parameters.AddWithValue("@d5", this.txtEstadoCita.Text);
                        SqlCmd.Parameters.AddWithValue("@d6", Convert.ToDecimal(this.txtCostoBs.Text));




                        //Ejecutamos nuestro comando

                        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";












                    }
                    else
                    {

                        SqlConnection SqlCon = new SqlConnection();



                        //Código
                        SqlCon.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                        SqlCon.Open();
                        //Establecer el Comando
                        SqlCommand SqlCmd = new SqlCommand();
                        SqlCmd.Connection = SqlCon;
                        SqlCmd.CommandText = "update Cita set idpaciente = @d1, idusuario = @d2, fecha = @d3, idservicio = @d4, estado = @d5 where idcita=@d6";
                        //SqlCmd.CommandType = CommandType.StoredProcedure;



                        //Sqlcmd.Parameters.AddWithValue("@d1", txtNombreCliente.Text);
                        SqlCmd.Parameters.AddWithValue("@d1", Convert.ToInt32(this.txtCodigoPaciente.Text));
                        SqlCmd.Parameters.AddWithValue("@d2", Convert.ToInt32(this.txtCodUsuario.Text));
                        SqlCmd.Parameters.AddWithValue("@d3", this.dtpFechaCita.Text);

                        SqlCmd.Parameters.AddWithValue("@d4", Convert.ToInt32(this.txtCodServicio.Text));
                        SqlCmd.Parameters.AddWithValue("@d5", this.txtEstadoCita.Text);
                        SqlCmd.Parameters.AddWithValue("@d6", Convert.ToInt32(this.txtCodCita.Text));



                        //Ejecutamos nuestro comando

                        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";





                    }


                    if (this.IsNuevo)
                    {
                        this.MensajeOk("Se Insertó de forma correcta la cita");
                        this.OperacionInsertarCita();
                    }
                    else
                    {
                        this.MensajeOk("Se Actualizó de forma correcta la cita");
                        this.OperacionEditarCita();
                    }



                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();

                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;

                    this.Mostrar();
                    this.RevisarCitasHoy();

                    this.txtEstadoCita.Text = string.Empty;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtCodCita.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;

            }
            else
            {
                this.MensajeError("Debe de seleccionar primero la cita a Modificar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;

            this.txtEstadoCita.Text = string.Empty;

        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Anular"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Anular"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
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

            //cargar todos los datos en el formulario

            this.txtCodCita.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idcita"].Value);


            this.txtCodigoPaciente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idpaciente"].Value);
            this.txtNumero_Cedula.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["num_cedula"].Value);
            this.txtNombre_Paciente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Paciente"].Value);
            this.txtTelefono.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["telefono"].Value);

            this.txtCodUsuario.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idusuario"].Value);
            this.lbl_usuario.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["login"].Value);


            this.txtCodServicio.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idservicio"].Value);
            this.cmbServicios.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Servicio"].Value);

            this.dtpFechaCita.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["fecha"].Value);

            this.txtEstadoCita.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["estado"].Value);


        }


        private void cmbServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            string Query = "select * from Servicio where nombre = '" + this.cmbServicios.Text + "' ;";
            SqlConnection conDataBase = new SqlConnection(CN);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;

            try
            {

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {

                    string idservicio = myReader["idservicio"].ToString();
                    string costo = myReader["costo"].ToString();

                    this.txtCodServicio.Text = idservicio;
                    this.txtCosto.Text = costo;

                    double tasa = Convert.ToDouble(this.txtTasa.Text);
                    double montoUSD = Convert.ToDouble(this.txtCosto.Text);
                    double montoVEF = montoUSD * tasa;

                    this.txtCostoBs.Text = Convert.ToString(montoVEF);


                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("error " + ex.ToString() + "");  

            }


           // int Dolares = Convert.ToInt32(this.txtCosto.Text);



        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Anular Esta cita pacientes", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);



                            SqlConnection SqlCon = new SqlConnection();







                            //Código
                            SqlCon.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                            SqlCon.Open();
                            //Establecer el Comando
                            SqlCommand SqlCmd = new SqlCommand();
                            SqlCmd.Connection = SqlCon;
                            SqlCmd.CommandText = "update cita set estado = @d1 where idcita = @d2";
                            //SqlCmd.CommandType = CommandType.StoredProcedure;



                            //Sqlcmd.Parameters.AddWithValue("@d1", txtNombreCliente.Text);
                            SqlCmd.Parameters.AddWithValue("@d1", "Inactivo");
                            SqlCmd.Parameters.AddWithValue("@d2", Convert.ToInt32(Codigo));





                            //Ejecutamos nuestro comando

                            rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "";





                            //Rpta = NCliente.Eliminar(Convert.ToInt32(Codigo));

                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Anulo Correctamente la cita");
                                this.OperacionAnularCita();
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }

                        }
                    }

                    Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void OperacionInsertarCita()
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
            SqlCmd2.Parameters.AddWithValue("@d2", "El usuario ha Registrado a un Cita.");
            SqlCmd2.Parameters.AddWithValue("@d3", Session_Actual.Log);




            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }



        private void OperacionEditarCita()
        {
            txtEstadoCita.Enabled = false;

            // Operacion Anular
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion, usuario) values (@d1,@d2, @d3)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "El usuario ha Editar a un Cita.");
            SqlCmd2.Parameters.AddWithValue("@d3", Session_Actual.Log);





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }



        private void OperacionAnularCita()
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
            SqlCmd2.Parameters.AddWithValue("@d2", "El usuario ha Anular a una Cita.");
            SqlCmd2.Parameters.AddWithValue("@d3", Session_Actual.Log);




            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }

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
                SqlCmd.CommandText = "sp_mostrar_citas";
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbBusqueda.Text.Equals("Paciente"))
            {

                this.BuscarPaciente();

            }
            else
            {

                this.BuscarServicio();
            }
        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            string Query = "select * from Usuario where nombre = '" + this.lbl_usuario.Text + "' ;";
            SqlConnection conDataBase = new SqlConnection(CN);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;

            try
            {

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {

                    string idusuario = myReader["idusuario"].ToString();
                    string nombre = myReader["nombre"].ToString();

                    this.txtCodUsuario.Text = idusuario;
                    //this.txtbuscarpaciente.Text = nombre;


                }



            }
            catch (Exception ex)
            {


            }
        }

        // Listo
        private void RevisarCitasHoy()
        {

            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.num_cedula, Paciente.telefono, Paciente.nombre as Paciente, Cita.idusuario, Usuario.login, Cita.fecha, Cita.idservicio, Servicio.nombre as Servicio, Cita.Estado from Cita INNER JOIN dbo.Paciente ON dbo.Cita.idpaciente = dbo.Paciente.idpaciente INNER JOIN dbo.Servicio ON dbo.Cita.idservicio = dbo.Servicio.idservicio INNER JOIN dbo.Usuario ON dbo.Cita.idusuario = dbo.Usuario.idusuario where fecha LIKE '"+ (DateTime.Now.ToShortDateString()) +"' AND Cita.estado = 'Activo' ", conDataBase);

            try
            {

                string Citashoy = DateTime.Now.ToShortDateString();

               // MessageBox.Show("hoy es: " + Citashoy + " :)");

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable tablita = new DataTable();
                sda.Fill(tablita);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = tablita;
                dgv_citashoy.DataSource = bSource;
                sda.Update(tablita);

                DataView DV = new DataView(tablita);

                //DV.RowFilter = string.Format("fecha LIKE '%{0}' AND estado = 'Activo'", Citashoy);

                dgv_citashoy.DataSource = DV;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                MessageBox.Show("Ha ocurrido un error");
            }


            OcultarColumnas();
            int Cupos = dgv_citashoy.Rows.Count;

            lblCitasHoy.Text = "Total de Citas: " + Convert.ToString(Cupos);


            //validacion de cupos maximos

            if (Cupos == 5) 
            {
                MessageBox.Show("A alcanzado le monto maximo de citas diarias");
                btnNuevo.Enabled = false;

            }
            else 
            { btnNuevo.Enabled = true; }














            /** otro fail 
            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
           SqlDataAdapter cmdDataBase = new SqlDataAdapter("Cita", conDataBase);

            try
            {

                DataView DV = new DataView(dbdataset);


                DV.RowFilter = string.Format("fecha LIKE '%{0}' AND estado = 'Activo'", Citashoy );

                dgv_citashoy.DataSource = DV;

                //SqlDataAdapter sda = new SqlDataAdapter();
                //sda.SelectCommand = cmdDataBase;
                //dbdataset = new DataTable();
                //sda.Fill(dbdataset);
                //BindingSource bSource = new BindingSource();



                //bSource.DataSource = dbdataset;
                //dgv_citashoy.DataSource = bSource;
                //sda.Update(dbdataset);


            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error");
            }

*/

            /** Se murio :c

            string Citashoy = DateTime.Now.Date.ToShortDateString();

            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);

            SqlDataAdapter cmdDataBase = new SqlDataAdapter("Cita", conDataBase);



            DataView DV = new DataView(dbdataset);


            DV.RowFilter = string.Format("fecha LIKE '%{0}' AND estado = 'Activo'",Citashoy);

            dgv_citashoy.DataSource = DV;

    */


        }

      
        private void btnCitasHoy_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

   

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            
        }




        private int Buscar_idPac_por_cedula()
        {

            string cedula_del_pac = this.txtNumero_Cedula.Text;

            DataTable paciente_tabla = new DataTable();

            paciente_tabla = NPacientes.BuscarNum_Cedula(cedula_del_pac);

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
                string telefono_del_pac = Convert.ToString(paciente_tabla.Rows[0][9]);

                this.txtNombre_Paciente.Text = nombre_del_pac;
                this.txtTelefono.Text = telefono_del_pac;



            }

            return id_del_pac;

        }


        private void txtNumero_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                int id_del_paciente_a_cargar;

                id_del_paciente_a_cargar = Buscar_idPac_por_cedula();

                if (id_del_paciente_a_cargar > 0)
                {
                    this.txtCodigoPaciente.Text = id_del_paciente_a_cargar.ToString();
                }
                else
                {
                    MessageBox.Show("Este paciente no esta registrado");
                }

            }
        }

        private void dgv_citashoy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte_Cita_Click(object sender, EventArgs e)
        {
            frmListadoCitasUsuario frm = new frmListadoCitasUsuario();
            frm.Show();
        }

        private void btnActualizarTasa_Click(object sender, EventArgs e)
        {




            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();


            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "UPDATE TasaDelDia SET Tasa_del_dia = '" + this.txtTasa.Text + "' ";

            

            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se actualizó la tasa";



        }

        private void txtTasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txtTasa.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        private void txtTasa_TextChanged(object sender, EventArgs e)
        {

            if ( !(this.txtCosto.Text == "") )
            {

                double tasa = Convert.ToDouble(this.txtTasa.Text);

                MessageBox.Show("la tasa es:" + tasa + "");

                double montoUSD = Convert.ToDouble(this.txtCosto.Text);

                MessageBox.Show("el monto usd es:" + montoUSD + "");

                double montoVEF = montoUSD * tasa;

                this.txtCostoBs.Text = Convert.ToString(montoVEF);

                MessageBox.Show("el total es:" + tasa + "");

            }

           
        }
    }
}