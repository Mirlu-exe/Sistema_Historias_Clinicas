using CapaDatos;
using CapaNegocio;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CapaDatos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmHistoria : Form
    {

        private bool IsNuevo = false;

        private bool IsEditar = false;



        private bool IsNuevo_evol = false;

        private bool IsEditar_evol = false;




        public static DUsuario Session_Actual = frmPrincipal.User_Actual;

        public frmHistoria()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.dtpFechaConsulta, "Ingrese la fecha de consulta");

            this.ttMensaje.SetToolTip(this.txtRazonConsulta, "Ingrese la razon de la consulta");
            this.ttMensaje.SetToolTip(this.txtEnfermedadActual, "Ingrese la enfermedad actual");
            this.ttMensaje.SetToolTip(this.txtHistoriaPersonal, "Ingrese la historia personal");
            this.ttMensaje.SetToolTip(this.txtHistoriaFamiliar, "Ingrese la historia familiar");
            this.ttMensaje.SetToolTip(this.txtTratamiento_Actual, "Ingrese el tratamiento actual");
            this.ttMensaje.SetToolTip(this.txtExamenFisico, "Ingrese el examen fisico");
            this.ttMensaje.SetToolTip(this.txtLaboratorio, "Ingrese el laboratorio");
            this.ttMensaje.SetToolTip(this.txtecg, "Ingrese el ecg paciente");
            this.ttMensaje.SetToolTip(this.txtRayos_X, "Ingrese los rayos X del paciente");
            this.ttMensaje.SetToolTip(this.txtEcocardiograma, "Ingrese el ecocardiograma del paciente");
            this.ttMensaje.SetToolTip(this.cbPlanEstudio, "Ingrese el plan de estudio");
            this.ttMensaje.SetToolTip(this.cbPlanTerapeutico, "Ingrese el plan terapeutico");

            this.btnAnular.Enabled = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmHistoria_Load(object sender, EventArgs e)
        {
            this.MostrarHistoriasActivas();
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
            this.LlenarComboDiagnosticos();

            OcultarColumnas();
            dataListado.Columns["idpaciente"].Visible = false;
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

            this.txtPaciente.Text = string.Empty;
            this.txtCedula.Text = string.Empty;
            //this.txtServicio.Text = string.Empty;
            this.txtMostrarPeso.Text = string.Empty;
            this.txtMostrarTalla.Text = string.Empty;
            this.txtRazonConsulta.Text = string.Empty;
            this.txtEnfermedadActual.Text = string.Empty;
            this.txtHistoriaPersonal.Text = string.Empty;
            this.txtHistoriaFamiliar.Text = string.Empty;
            this.txtTratamiento_Actual.Text = string.Empty;
            this.txtExamenFisico.Text = string.Empty;
            this.txtLaboratorio.Text = string.Empty;
            this.txtecg.Text = string.Empty;
            this.txtRayos_X.Text = string.Empty;
            this.txtEcocardiograma.Text = string.Empty;
            this.cbPlanEstudio.Text = string.Empty;
            this.cbPlanTerapeutico.Text = string.Empty;
            this.cblTipo_Sangre.Text = string.Empty;
            this.txtDiagnosticos.Text = string.Empty;
            



        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtPaciente.ReadOnly = !valor;
            this.txtCedula.ReadOnly = !valor;
            //this.txtServicio.ReadOnly = !valor;
            this.txtMostrarPeso.ReadOnly = !valor;
            this.txtMostrarTalla.ReadOnly = !valor;
            this.txtEnfermedadActual.ReadOnly = !valor;
            this.txtRazonConsulta.ReadOnly = !valor;
            this.txtHistoriaPersonal.ReadOnly = !valor;
            this.txtHistoriaFamiliar.ReadOnly = !valor;
            this.txtTratamiento_Actual.ReadOnly = !valor;
            this.txtExamenFisico.ReadOnly = !valor;
            this.txtLaboratorio.ReadOnly = !valor;
            this.txtecg.ReadOnly = !valor;
            this.txtRayos_X.ReadOnly = !valor;
            this.txtEcocardiograma.ReadOnly = !valor;
            this.cbPlanEstudio.Enabled = !valor;
            this.cbPlanTerapeutico.Enabled = !valor;



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



        private void LlenarComboDiagnosticos()
        {



            //traer toda la tabla de medicamentos


            //this.txtDiagnosticos.DataSource = NDiagnostico.Mostrar();
            //txtDiagnosticos.ValueMember = "enfermedad";
            //txtDiagnosticos.DisplayMember = "enfermedad";





        }

        //Método para ocultar columnas
        private void OcultarColumnas()
        {

            //this.datalistadohistorias.Columns[0].Visible = false;
            //this.dataListado.Columns[1].Visible = false;



        }





        //Método Mostrar
        private void Mostrar()
        {





            this.dataListado.DataSource = NPacientes.Mostrar();
            OcultarColumnas();
            lblTotal.Text = "Total de Pacientes: " + Convert.ToString(dataListado.Rows.Count);




            /*string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula, Paciente.peso, Paciente.talla, Cita.idusuario, Cita.fecha, Cita.idservicio, Servicio.nombre as Servicio, Cita.Costo, Cita.Estado from Cita inner join dbo.Paciente ON dbo.Cita.idpaciente = dbo.Paciente.idpaciente INNER JOIN dbo.Servicio ON dbo.Cita.idservicio = dbo.Servicio.idservicio where Cita.estado = 'Activo'; ", conDataBase);

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
            lblTotal.Text = "Total de Citas: " + Convert.ToString(dataListado.Rows.Count);*/




        }


        //Método Mostrar
        private void MostrarHistoriasActivas()
        {


            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase = new SqlCommand("select Historia.idhistoria, Historia.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula, Historia.fecha_consulta, Historia.razon_consulta, Historia.enfermedad_actual, Historia.historia_familiar, Historia.historia_personal, Historia.tratamiento_actual, Historia.examen_fisico, Historia.ecg, Historia.laboratorio, Historia.rayos_x, Historia.ecocardiograma, Historia.plan_estudio, Historia.plan_terapeutico, Historia.estado, Historia.tipo_sangre, Historia.diagnosticos FROM Paciente INNER JOIN Historia ON Paciente.idpaciente = Historia.idpaciente where Historia.estado = 'Activo'; ", conDataBase);





            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                datalistadohistorias.DataSource = bSource;
                sda.Update(dbdataset);


            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error");
            }



            OcultarColumnas();


            lblHistoriasActivas.Text = "Total de Historias : " + Convert.ToString(datalistadohistorias.Rows.Count);
        }






        ////Método Mostrar Muertos
        //private void MostrarHistoriasAnuladas()
        //{


        //    string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
        //    SqlConnection conDataBase = new SqlConnection(Cn);
        //    //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
        //    //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
        //    SqlCommand cmdDataBase = new SqlCommand("SELECT Historia.idhistoria, Historia.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula, Historia.fecha_consulta, Historia.razon_consulta, Historia.enfermedad_actual, Historia.historia_familiar, Historia.historia_personal, Historia.tratamiento_actual, Historia.examen_fisico, Historia.ecg, Historia.laboratorio, Historia.rayos_x, Historia.ecocardiograma, Historia.plan_estudio, Historia.plan_terapeutico, Historia.estado FROM Paciente INNER JOIN Historia ON Paciente.idpaciente = Historia.idpaciente where Historia.estado = 'Inactivo'; ", conDataBase);





        //    try
        //    {

        //        SqlDataAdapter sda = new SqlDataAdapter();
        //        sda.SelectCommand = cmdDataBase;
        //        dbdataset = new DataTable();
        //        sda.Fill(dbdataset);
        //        BindingSource bSource = new BindingSource();

        //        bSource.DataSource = dbdataset;
        //        datalistadoMuertos.DataSource = bSource;
        //        sda.Update(dbdataset);


        //    }
        //    catch (Exception ex)
        //    {


        //        MessageBox.Show("Ha ocurrido un error");
        //    }



        //    OcultarColumnas();


        //    lblCantidadArchivosMuertos.Text = "Total de Historias: " + Convert.ToString(datalistadoMuertos.Rows.Count);
        //}


        //Metodo BuscarPacienteSegunHistoria
        private void BuscarPacienteSegunHistoria()
        {

        }


        //Método BuscarNombre
        private void BuscarNombre()
        {

            this.dataListado.DataSource = NPacientes.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Pacientes: " + Convert.ToString(dataListado.Rows.Count);
            
            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Paciente LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;





            lblTotal.Text = "Total de Citas: " + Convert.ToString(dataListado.Rows.Count);*/
        }


        //Método BuscarServicio
        /*private void BuscarServicio()
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Servicio LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;





            lblTotal.Text = "Total de Citas: " + Convert.ToString(dataListado.Rows.Count);
        }*/

        //Método BuscarTalla
        private void BuscarTalla()
        {
            this.dataListado.DataSource = NPacientes.BuscarTalla(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Pacientes: " + Convert.ToString(dataListado.Rows.Count);
        }


        //Método BuscarPeso
        private void BuscarPeso()
        {
            //this.dataListado.DataSource = NPacientes.BuscarPeso(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Pacientes: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarPeso
        private void BuscarCedula()
        {

            this.dataListado.DataSource = NPacientes.BuscarNum_Documento(this.txtBuscar.Text);
            this.OcultarColumnas();

            lblTotal.Text = "Total de Pacientes: " + Convert.ToString(dataListado.Rows.Count);
            
            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("num_cedula LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;





            lblTotal.Text = "Total de Citas: " + Convert.ToString(dataListado.Rows.Count);*/
        }



        //Método Mostrar
        private void MostrarFechas(string fecha1, string fecha2)
        {


            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula, Paciente.peso, Paciente.talla, Cita.idusuario, Cita.fecha, Cita.idservicio, Servicio.nombre as Servicio, Cita.Costo, Cita.Estado from Cita inner join dbo.Paciente ON dbo.Cita.idpaciente = dbo.Paciente.idpaciente INNER JOIN dbo.Servicio ON dbo.Cita.idservicio = dbo.Servicio.idservicio where Cita.fecha between '" + fecha1 + "' and '" + fecha2 + "' ", conDataBase);

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


        //Método Mostrar
        private void MostrarFechasActivas(string fecha1, string fecha2)
        {


            /*string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase = new SqlCommand("SELECT Historia.idhistoria, Historia.idcita, Cita.costo, Cita.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula,Cita.idservicio, Servicio.nombre AS Servicio, Historia.fecha_consulta, Historia.razon_consulta, Historia.enfermedad_actual, Historia.historia_familiar, Historia.historia_personal, Historia.tratamiento_actual, Historia.examen_fisico, Historia.ecg, Historia.laboratorio, Historia.rayos_x, Historia.ecocardiograma, Historia.plan_estudio, Historia.plan_terapeutico, Historia.estado FROM Cita INNER JOIN Historia ON Cita.idcita = Historia.idcita INNER JOIN Paciente ON Cita.idpaciente = Paciente.idpaciente INNER JOIN Servicio ON Cita.idservicio = Servicio.idservicio where Historia.fecha_consulta between '" + fecha1 + "' and '" + fecha2 + "' ", conDataBase);





            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                datalistadohistorias.DataSource = bSource;
                sda.Update(dbdataset);


            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error");
            }






            lblHistoriasActivas.Text = "Total de Historias : " + Convert.ToString(datalistadohistorias.Rows.Count);*/
        }



        //Método Mostrar
        private void MostrarFechasAnuladas(string fecha1, string fecha2)
        {


            /*string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase = new SqlCommand("SELECT Historia.idhistoria, Historia.idcita, Cita.costo, Cita.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula,Cita.idservicio, Servicio.nombre AS Servicio, Historia.fecha_consulta, Historia.razon_consulta, Historia.enfermedad_actual, Historia.historia_familiar, Historia.historia_personal, Historia.tratamiento_actual, Historia.examen_fisico, Historia.ecg, Historia.laboratorio, Historia.rayos_x, Historia.ecocardiograma, Historia.plan_estudio, Historia.plan_terapeutico, Historia.estado FROM Cita INNER JOIN Historia ON Cita.idcita = Historia.idcita INNER JOIN Paciente ON Cita.idpaciente = Paciente.idpaciente INNER JOIN Servicio ON Cita.idservicio = Servicio.idservicio where Historia.fecha_consulta between '" + fecha1 + "' and '" + fecha2 + "' ", conDataBase);





            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                datalistadoMuertos.DataSource = bSource;
                sda.Update(dbdataset);


            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error");
            }






            lblCantidadArchivosMuertos.Text = "Total de Historias: " + Convert.ToString(datalistadoMuertos.Rows.Count);*/
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtPaciente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.lblCodigoPaciente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idpaciente"].Value);
            //this.lblCodigoCita.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idcita"].Value);
            this.cmbTipoCedula.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_cedula"].Value);
            this.txtCedula.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["num_cedula"].Value);
            //this.txtServicio.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Servicio"].Value);
            this.txtMostrarPeso.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["peso"].Value);
            this.txtMostrarTalla.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["talla"].Value);

            this.OcultarColumnas();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (this.cblBusqueda.Text.Equals("Paciente"))
            {

                this.BuscarNombre();
            }
            else if (this.cblBusqueda.Text.Equals("Servicio"))
            {
                //this.BuscarServicio();
            }

            else if (this.cblBusqueda.Text.Equals("Talla"))
            {
                this.BuscarTalla();
            }

            else if (this.cblBusqueda.Text.Equals("Peso"))
            {
                this.BuscarPeso();
            }

            else if (this.cblBusqueda.Text.Equals("Cedula"))
            {
                this.BuscarCedula();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.cblBusqueda.Text.Equals("Paciente"))
            {



                this.BuscarNombre();
            }
            else if (this.cblBusqueda.Text.Equals("Servicio"))
            {
                //this.BuscarServicio();
            }

            else if (this.cblBusqueda.Text.Equals("Talla"))
            {
                this.BuscarTalla();
            }

            else if (this.cblBusqueda.Text.Equals("Peso"))
            {
                this.BuscarPeso();
            }

            else if (this.cblBusqueda.Text.Equals("Cedula"))
            {
                this.BuscarCedula();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtPaciente.Focus();

            this.tabControl1.SelectedIndex = 1;

            OcultarColumnas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.lblCodigoPaciente.Text == string.Empty)
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
                        SqlCmd.CommandText = "insert into Historia (idpaciente, fecha_consulta, razon_consulta, enfermedad_actual, historia_familiar, historia_personal, tratamiento_actual, examen_fisico, laboratorio, ecg, rayos_x, ecocardiograma, plan_estudio, plan_terapeutico, estado, tipo_sangre, diagnosticos) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15, @d16, @d17);";
                        //SqlCmd.CommandType = CommandType.StoredProcedure;



                        //Sqlcmd.Parameters.AddWithValue("@d1", txtNombreCliente.Text);
                        SqlCmd.Parameters.AddWithValue("@d1", this.lblCodigoPaciente.Text);
                        SqlCmd.Parameters.AddWithValue("@d2", this.dtpFechaConsulta.Text);
                        SqlCmd.Parameters.AddWithValue("@d3", this.txtRazonConsulta.Text);
                        SqlCmd.Parameters.AddWithValue("@d4", this.txtEnfermedadActual.Text);
                        SqlCmd.Parameters.AddWithValue("@d5", this.txtHistoriaFamiliar.Text);
                        SqlCmd.Parameters.AddWithValue("@d6", this.txtHistoriaPersonal.Text);
                        SqlCmd.Parameters.AddWithValue("@d7", this.txtTratamiento_Actual.Text);
                        SqlCmd.Parameters.AddWithValue("@d8", this.txtExamenFisico.Text);
                        SqlCmd.Parameters.AddWithValue("@d9", this.txtLaboratorio.Text);
                        SqlCmd.Parameters.AddWithValue("@d10", this.txtecg.Text);
                        SqlCmd.Parameters.AddWithValue("@d11", this.txtRayos_X.Text);
                        SqlCmd.Parameters.AddWithValue("@d12", this.txtEcocardiograma.Text);
                        SqlCmd.Parameters.AddWithValue("@d13", this.cbPlanEstudio.Text);
                        SqlCmd.Parameters.AddWithValue("@d14", this.cbPlanTerapeutico.Text);
                        SqlCmd.Parameters.AddWithValue("@d15", this.cmbEstadoHistoria.Text);
                        SqlCmd.Parameters.AddWithValue("@d16", this.cblTipo_Sangre.Text);
                        SqlCmd.Parameters.AddWithValue("@d17", this.txtDiagnosticos.Text);





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
                        SqlCmd.CommandText = "update Historia set idpaciente = @d1, fecha_consulta = @d2, razon_consulta = @d3, enfermedad_actual = @d4, historia_familiar = @d5, historia_personal = @d6, tratamiento_actual = @d7, examen_fisico = @d8, laboratorio = @d9, ecg = @d10, rayos_x = @d11, ecocardiograma = @d12, plan_estudio = @d13, plan_terapeutico = @d14,  estado = @d15 , tipo_sangre = @d17, diagnosticos = @d18 where idhistoria=@d16";
                        //SqlCmd.CommandType = CommandType.StoredProcedure;



                        //Sqlcmd.Parameters.AddWithValue("@d1", txtNombreCliente.Text);
                        SqlCmd.Parameters.AddWithValue("@d1", this.lblCodigoPaciente.Text);
                        SqlCmd.Parameters.AddWithValue("@d2", this.dtpFechaConsulta.Text);
                        SqlCmd.Parameters.AddWithValue("@d3", this.txtRazonConsulta.Text);
                        SqlCmd.Parameters.AddWithValue("@d4", this.txtEnfermedadActual.Text);
                        SqlCmd.Parameters.AddWithValue("@d5", this.txtHistoriaFamiliar.Text);
                        SqlCmd.Parameters.AddWithValue("@d6", this.txtHistoriaPersonal.Text);
                        SqlCmd.Parameters.AddWithValue("@d7", this.txtTratamiento_Actual.Text);
                        SqlCmd.Parameters.AddWithValue("@d8", this.txtExamenFisico.Text);
                        SqlCmd.Parameters.AddWithValue("@d9", this.txtLaboratorio.Text);
                        SqlCmd.Parameters.AddWithValue("@d10", this.txtecg.Text);
                        SqlCmd.Parameters.AddWithValue("@d11", this.txtRayos_X.Text);
                        SqlCmd.Parameters.AddWithValue("@d12", this.txtEcocardiograma.Text);
                        SqlCmd.Parameters.AddWithValue("@d13", this.cbPlanEstudio.Text);
                        SqlCmd.Parameters.AddWithValue("@d14", this.cbPlanTerapeutico.Text);
                        SqlCmd.Parameters.AddWithValue("@d15", this.cmbEstadoHistoria.Text);
                        SqlCmd.Parameters.AddWithValue("@d16", this.lbl_id_historia.Text);
                        SqlCmd.Parameters.AddWithValue("@d17", this.cblTipo_Sangre.Text);
                        SqlCmd.Parameters.AddWithValue("@d18", this.txtDiagnosticos.Text);





                        //Ejecutamos nuestro comando

                        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";



                    }


                    if (this.IsNuevo)
                    {
                        this.MensajeOk("Se Insertó de forma correcta la historia clinica");
                        this.OperacionInsertarHistoria();
                    }
                    else
                    {
                        this.MensajeOk("Se Actualizó de forma correcta la historia clinica");
                        this.OperacionEditarHistoria();
                    }



                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                    this.MostrarHistoriasActivas();


                    OcultarColumnas();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.lbl_id_historia.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero la historia clinica a Modificar");
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

        private void chkAnular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnular.Checked)
            {
                this.datalistadohistorias.Columns[0].Visible = true;
                this.btnAnular.Enabled = true;
            }
            else
            {
                this.datalistadohistorias.Columns[0].Visible = false;
                this.btnAnular.Enabled = false;
            }
        }

        private void datalistadohistorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalistadohistorias.Columns["Anular"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)datalistadohistorias.Rows[e.RowIndex].Cells["Anular"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
            }

            OcultarColumnas();

        }

        private void datalistadohistorias_DoubleClick(object sender, EventArgs e)
        {
            int id_historia_seleccionada = Convert.ToInt32(this.datalistadohistorias.CurrentRow.Cells["idhistoria"].Value);

            this.lbl_id_historia.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["idhistoria"].Value);
            this.lblCodigoPaciente.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["idpaciente"].Value);

            this.lbl_ci_pac.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["num_cedula"].Value);
            this.lbl_nombre_pac.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["Paciente"].Value);


            //aca se pasan los datos del Historia a Evolucion 
            this.lbl_id_historia_evol.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["idhistoria"].Value);
            this.lblNombrePaciente_evol.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["Paciente"].Value);
            this.lblCedulaPaciente_evol.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["num_cedula"].Value);

            //aca se pasan los datos del Historia a Evolucion Lista
            this.lbl_lista_evol_id_historia.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["idhistoria"].Value);
            this.lbl_lista_evol_nombre.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["Paciente"].Value);
            this.lbl_lista_evol_ci.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["num_cedula"].Value);




            this.dtpFechaConsulta.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["fecha_consulta"].Value);
            this.txtRazonConsulta.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["razon_consulta"].Value);
            this.txtEnfermedadActual.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["enfermedad_actual"].Value);
            this.txtHistoriaFamiliar.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["historia_familiar"].Value);
            this.txtHistoriaPersonal.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["historia_personal"].Value);

            this.txtTratamiento_Actual.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["tratamiento_actual"].Value);
            this.txtExamenFisico.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["examen_fisico"].Value);
            this.txtHistoriaFamiliar.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["historia_familiar"].Value);
            this.txtEnfermedadActual.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["enfermedad_actual"].Value);
            this.txtLaboratorio.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["laboratorio"].Value);
            this.txtecg.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["ecg"].Value);
            this.txtRayos_X.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["rayos_x"].Value);
            this.txtEcocardiograma.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["ecocardiograma"].Value);
            this.cbPlanEstudio.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["plan_estudio"].Value);
            this.cbPlanTerapeutico.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["plan_terapeutico"].Value);
            this.cmbEstadoHistoria.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["estado"].Value);

            this.txtDiagnosticos.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["diagnosticos"].Value);
            this.cblTipo_Sangre.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["tipo_sangre"].Value);

            this.tabControl1.SelectedIndex = 1;

            OcultarColumnas();

            //si posee evoluciones, mostrarlas todas en la pestaña Lista de Evoluciones

            DataTable evoluciones_por_historia = new DataTable();



            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            SqlCommand cmdDataBase = new SqlCommand("SELECT * " +
                "FROM Evoluciones " +
                "INNER JOIN Historia ON Evoluciones.idhistoria = Historia.idhistoria " +
                "WHERE Historia.estado = 'Activo' AND Evoluciones.idhistoria = " + id_historia_seleccionada + " ; ", conDataBase);



            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                sda.Fill(evoluciones_por_historia);


                int Cant_evol_por_historia;

                Cant_evol_por_historia = evoluciones_por_historia.Rows.Count;

                if (Cant_evol_por_historia > 0)
                {
                    MessageBox.Show("La historia tiene evoluciones :)");
                }
                else
                {
                    MessageBox.Show("La historia NO tiene evoluciones");
                }

                dgv_lista_evol.DataSource = evoluciones_por_historia;

            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error");
            }



            OcultarColumnas();





        }



        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Anular la historia medica?", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in datalistadohistorias.Rows)
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
                            SqlCmd.CommandText = "update Historia set estado = @d1 where idhistoria = @d2";
                            //SqlCmd.CommandType = CommandType.StoredProcedure;



                            //Sqlcmd.Parameters.AddWithValue("@d1", txtNombreCliente.Text);
                            SqlCmd.Parameters.AddWithValue("@d1", "Inactivo");
                            SqlCmd.Parameters.AddWithValue("@d2", Convert.ToInt32(Codigo));





                            //Ejecutamos nuestro comando

                            rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "";







                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Anuló Correctamente la historia");
                                this.OperacionAnularHistoria();
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }

                        }
                    }
                    this.MostrarHistoriasActivas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }



        private void OperacionInsertarHistoria()
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
            SqlCmd2.Parameters.AddWithValue("@d2", "Se ha registrado una historia clinica al sistema");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }



        private void OperacionEditarHistoria()
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
            SqlCmd2.Parameters.AddWithValue("@d2", "Se editó una historia clinica");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }



        private void OperacionAnularHistoria()
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
            SqlCmd2.Parameters.AddWithValue("@d2", "Se anuló una historia clinica");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            this.ttMensaje.SetToolTip(this.label3, "Campo Obligatorio");
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                dataListado.Columns["idpaciente"].Visible = false;
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                datalistadohistorias.Columns["idhistoria"].Visible = false;
                datalistadohistorias.Columns["idpaciente"].Visible = false;
            }

            


        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }



        private void btnAnadirEvol_Click(object sender, EventArgs e)
        {

            //para llevar los datos de la Historia a Evolucion
            lbl_id_historia_evol.Text = this.lbl_id_historia.Text;
            lblNombrePaciente_evol.Text = this.lbl_nombre_pac.Text;
            lblCedulaPaciente_evol.Text = this.lbl_ci_pac.Text;

            //para llevar los datos de la Historia a la pestaña de Lista Evolucion
            lbl_lista_evol_id_historia.Text = this.lbl_id_historia.Text;
            lbl_lista_evol_ci.Text = this.lbl_ci_pac.Text;
            lbl_lista_evol_nombre.Text = this.lbl_nombre_pac.Text;

            //Para que se muestre la pestaña de Evolucion.
            this.tabControl1.SelectedIndex = 4;



            //insertar evolucion



            //anular evolucion




        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void datalistadohistorias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private int Contar_evol_segun_id_historia(int id_de_la_historia)
        {


            DataTable dt_evol = new DataTable();

            dt_evol = NEvolucion.MostrarEvolucion(id_de_la_historia);

            int cant_evoluciones = dt_evol.Rows.Count;

            MessageBox.Show("La cantidad de evoluciones asociadas con la historia seleccionada es: " + Convert.ToString(cant_evoluciones) + " :D");

            return cant_evoluciones;

        }


        private void btnGuardar_evol_Click(object sender, EventArgs e)
        {


                try
                {

                    //validacion de campos vacios

                    string rpta = "";
                    if (string.IsNullOrEmpty(this.txtRazonConsulta_Evol.Text) || string.IsNullOrEmpty(txtEdadSuc_Evol.Text))
                    {
                        //MensajeError("No se pueden dejar campos vacios");
                        /*errorIcono.SetError(txtNombre, "Ingrese un Valor");
                        errorIcono.SetError(txtApellidos, "Ingrese un Valor");
                        errorIcono.SetError(txtNum_Documento, "Ingrese un Valor");
                        errorIcono.SetError(txtUsuario, "Ingrese un Valor");
                        errorIcono.SetError(txtPassword, "Ingrese un Valor");*/

                    }
                    else
                    {




                        if (this.IsNuevo_evol)
                        {


                        //insertar nueva evolucion
                            rpta = NEvolucion.Insertar( Convert.ToInt32(this.lbl_id_historia_evol.Text),
                            this.dt_fecha_consulta_evol.Value, this.txtEdadSuc_Evol.Text, this.txtRazonConsulta_Evol.Text, 
                            this.cbPlanTerapeutico_Evol.Text, this.cbPlanEstudio_Evol.Text, this.txtObservaciones_Evol.Text, 
                            this.txtDiagnosticos_Evol.Text, this.dt_prox_cita.Value, this.cbEstado_Evol.Text);

                        }
                        


                    
                        else if (this.IsEditar_evol)
                        {


                            if (Contar_evol_segun_id_historia(Convert.ToInt32(this.lbl_id_historia_evol.Text)) > 0)
                        {


                            //editar evolucion
                            rpta = NEvolucion.Editar(Convert.ToInt32(this.lbl_id_paciente_select.Text), Convert.ToInt32(this.lbl_id_historia_evol.Text),
                            this.dt_fecha_consulta_evol.Value, this.txtEdadSuc_Evol.Text, this.txtRazonConsulta_Evol.Text,
                            this.cbPlanTerapeutico_Evol.Text, this.cbPlanEstudio_Evol.Text, this.txtObservaciones_Evol.Text,
                            this.txtDiagnosticos_Evol.Text, this.dt_prox_cita.Value, this.cbEstado_Evol.Text);
                        }
                            else
                            {
                                MensajeError("No puede editar un registro que no existe. Porfavor, revise nuevamente los datos");
                            }



                        }


                        if (rpta.Equals("OK"))
                        {




                            if (this.IsNuevo_evol)
                            {
                                this.MensajeOk("Se Insertó de forma correcta la evolucion");
                                //this.OperacionInsertarEvol();
                            }
                            else
                            {
                                this.MensajeOk("Se Actualizó de forma correcta la evolucion");
                                //this.OperacionEditarEvol();
                            }

                        }
                        else
                        {


                            this.MensajeError(rpta);
                        }

                        this.IsNuevo_evol = false;
                        this.IsEditar_evol = false;
                        //this.Botones_evol();
                        //this.Limpiar_evol();
                        this.lbl_id_historia_evol.Text = "";


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            


        }

        private void btnNueva_evol_Click(object sender, EventArgs e)
        {
            this.IsNuevo_evol = true;
            this.IsEditar_evol = false;
            //this.Botones_evol();
            //this.Limpiar_evol();
            //this.Habilitar_evol(true);



        }

        private void btnEditar_evol_Click(object sender, EventArgs e)
        {
            this.IsNuevo_evol = false;
            this.IsEditar_evol = true;
            //this.Boton_evol();
            //this.Limpiar_evol();
            //this.Habilitar_evol(true);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgv_lista_evol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes.frmListaHistorialTotal frm = new Reportes.frmListaHistorialTotal();
            frm.Show();
        }

        private void datalistadoMuertos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAbrirArchivoMuerto_Click(object sender, EventArgs e)
        {
            frmArchivosMuertos frm = new frmArchivosMuertos();
            frm.ShowDialog();
        }
    }
}
