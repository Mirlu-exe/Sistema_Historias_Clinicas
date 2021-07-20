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

            this.ttMensaje.SetToolTip(this.txtbuscarpaciente, "Seleccione un paciente");

            //this.ttMensaje.SetToolTip(this.txtCosto, "Ingrese el costo del servicio");
            this.ttMensaje.SetToolTip(this.dtpFechaCita, "Ingrese la fecha de la reserva");
            fillComboServicios();
            fillComboPacientes();
            fillComboUsuarios();


            //cargarCodigoUsuario();
            this.btnAnular.Enabled = false;
        }

        private void frmCitas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.Servicio' Puede moverla o quitarla según sea necesario.
            this.servicioTableAdapter.Fill(this.dsPrincipal.Servicio);
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.Cita' Puede moverla o quitarla según sea necesario.
            this.citaTableAdapter.Fill(this.dsPrincipal.Cita);
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
            this.montoTotalCitas();

            OcultarColumnas();

            LblHora.Text = DateTime.Now.Date.ToShortDateString();

        }

        //Método para ocultar columnas
        private void OcultarColumnas()
        {

            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;

            this.dataListado.Columns["idusuario"].Visible = false;
            this.dataListado.Columns["idpaciente"].Visible = false;
            this.dataListado.Columns["idservicio"].Visible = false;

        }

        public void cargarCodigoUsuario()
        {
            frmPrincipal menu = new frmPrincipal();
            this.txtCodUsuario.Text = menu.lblcodigoUsuario.Text;

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


            }

        }


        public void fillComboUsuarios()
        {

            string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            string Query = "select * from Usuario where estado = 'Activo' ;";
            SqlConnection conDataBase = new SqlConnection(CN);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader Lectura;

            try
            {

                conDataBase.Open();
                Lectura = cmdDataBase.ExecuteReader();

                while (Lectura.Read())
                {

                    cmbUsuarios.Items.Add(Lectura["nombre"].ToString());



                }



            }
            catch (Exception ex)
            {


            }

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


        public void fillComboPacientes()
        {


            string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            string Query = "select * from Paciente where estado = 'Activo' ;";
            SqlConnection conDataBase = new SqlConnection(CN);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader Lectura;

            try
            {

                conDataBase.Open();
                Lectura = cmdDataBase.ExecuteReader();

                while (Lectura.Read())
                {

                    cmbPacientes.Items.Add(Lectura["nombre"].ToString());



                }



            }
            catch (Exception ex)
            {


            }

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
            this.txtbuscarpaciente.Text = string.Empty;

            this.txtCodServicio.Text = string.Empty;
            this.txtCodUsuario.Text = string.Empty;
            this.txtCodigoPaciente.Text = string.Empty;
            this.txtCosto.Text = string.Empty;
            this.cmbUsuarios.SelectedIndex = -1;
            this.cmbPacientes.SelectedIndex = -1;
            this.cmbServicios.SelectedIndex = -1;





        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtCodCita.ReadOnly = !valor;
            this.txtbuscarpaciente.ReadOnly = !valor;
            //this.txtBuscarServicio.ReadOnly = !valor;
            this.cmbPacientes.Enabled = valor;
            this.cmbUsuarios.Enabled = valor;
            this.txtCosto.ReadOnly = !valor;







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



        //Método Mostrar
        private void Mostrar()
        {


            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre as Paciente, Cita.idusuario, Cita.fecha, Cita.idservicio, Servicio.nombre as Servicio, Cita.Estado from Cita inner join dbo.Paciente ON dbo.Cita.idpaciente = dbo.Paciente.idpaciente INNER JOIN dbo.Servicio ON dbo.Cita.idservicio = dbo.Servicio.idservicio ", conDataBase);

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


                MessageBox.Show("Ha ocurrido un error");
            }





            this.OcultarColumnas();
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
            this.txtbuscarpaciente.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (string.IsNullOrEmpty(txtCodigoPaciente.Text) || string.IsNullOrEmpty(txtCodUsuario.Text) || string.IsNullOrEmpty(txtCodServicio.Text) ||
                    cmbServicios.SelectedIndex == -1 || cmbPacientes.SelectedIndex == -1)
                {
                    MessageBox.Show("No puede dejar campos vacios o sin seleccionar. ", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);


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
                        SqlCmd.CommandText = "insert into Cita (idpaciente, idusuario, fecha, idservicio, estado) values (@d1,@d2,@d3,@d4,@d5)";
                        //SqlCmd.CommandType = CommandType.StoredProcedure;



                        //Sqlcmd.Parameters.AddWithValue("@d1", txtNombreCliente.Text);
                        SqlCmd.Parameters.AddWithValue("@d1", Convert.ToInt32(this.txtCodigoPaciente.Text));
                        SqlCmd.Parameters.AddWithValue("@d2", Convert.ToInt32(this.txtCodUsuario.Text));
                        SqlCmd.Parameters.AddWithValue("@d3", this.dtpFechaCita.Text);

                        SqlCmd.Parameters.AddWithValue("@d4", Convert.ToInt32(this.txtCodServicio.Text));
                        SqlCmd.Parameters.AddWithValue("@d5", this.cmbEstadoCita.Text);




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
                        SqlCmd.Parameters.AddWithValue("@d5", this.cmbEstadoCita.Text);
                        SqlCmd.Parameters.AddWithValue("@d6", Convert.ToInt32(this.txtCodCita.Text));



                        //Ejecutamos nuestro comando

                        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";





                    }


                    if (this.IsNuevo)
                    {
                        this.MensajeOk("Se Insertó de forma correcta la cita");
                        this.OperacionInsertarCita();
                        this.montoTotalCitas();
                    }
                    else
                    {
                        this.MensajeOk("Se Actualizó de forma correcta la cita");
                        this.OperacionEditarCita();
                        this.montoTotalCitas();
                    }



                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                    this.montoTotalCitas();


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
            this.txtCodCita.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idcita"].Value);
            this.txtCodigoPaciente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idpaciente"].Value);
            this.txtCodUsuario.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idusuario"].Value);
            this.dtpFechaCita.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["fecha"].Value);
            this.cmbServicios.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Servicio"].Value);
            this.cmbPacientes.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Paciente"].Value);
            this.txtCodServicio.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idservicio"].Value);
            this.cmbEstadoCita.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["estado"].Value);
        }

        private void cmbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            string Query = "select * from Paciente where nombre = '" + this.cmbPacientes.Text + "' ;";
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

                    this.txtCodigoPaciente.Text = idpaciente;
                    //this.txtbuscarpaciente.Text = nombre;


                }



            }
            catch (Exception ex)
            {


            }
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


                }



            }
            catch (Exception ex)
            {


            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Cancelar Esta cita pacientes", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
                            SqlCmd.Parameters.AddWithValue("@d1", "Cancelada");
                            SqlCmd.Parameters.AddWithValue("@d2", Convert.ToInt32(Codigo));





                            //Ejecutamos nuestro comando

                            rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "";





                            //Rpta = NCliente.Eliminar(Convert.ToInt32(Codigo));

                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se canceló Correctamente la cita");
                                this.OperacionAnularCita();
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


        private void OperacionInsertarCita()
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
            SqlCmd2.Parameters.AddWithValue("@d2", "Se ha registrado una nueva cita ");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }



        private void OperacionEditarCita()
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
            SqlCmd2.Parameters.AddWithValue("@d2", "Se editó una cita ");





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
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion) values (@d1,@d2)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "Se anuló una cita");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }


        public void montoTotalCitas()
        {

            //int sum = 0;


            //for (int i = 0; i < dataListado.Rows.Count; i++)
            //{


            //    sum += Convert.ToInt32(dataListado.Rows[i].Cells["costo"].Value);
            //}

            //this.lblMontoTotal.Text = sum.ToString() + "$ ";


        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbBusqueda.Text.Equals("Paciente"))
            {

                this.BuscarPaciente();
                this.montoTotalCitas();

            }
            else
            {

                this.BuscarServicio();
                this.montoTotalCitas();
            }
        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            string Query = "select * from Usuario where nombre = '" + this.cmbUsuarios.Text + "' ;";
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

        
        private void RevisarCitasHoy() 
        {

          string Citashoy = DateTime.Now.Date.ToShortDateString();

            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase = new SqlCommand("select Cita.fecha from Cita inner join dbo.Paciente ON dbo.Cita.idpaciente = dbo.Paciente.idpaciente INNER JOIN dbo.Servicio ON dbo.Cita.idservicio = dbo.Servicio.idservicio ", conDataBase);



        }

        private void dgv_citas_hoy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LblHora_Click(object sender, EventArgs e)
        {

        }
    }
}
