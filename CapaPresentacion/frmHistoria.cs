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
            //this.ttMensaje.SetToolTip(this.cbPlanEstudio, "Ingrese el plan de estudio");
            //this.ttMensaje.SetToolTip(this.cbPlanTerapeutico, "Ingrese el plan terapeutico");

            this.btnAnular.Enabled = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void 
            
            frmHistoria_Load(object sender, EventArgs e)
        {
            this.MostrarHistoriasActivas();
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Deshabilitar();
            this.Botones();
            this.LlenarComboDiagnosticos();

            //this.LlenarCbPlanTerapeutico();


            OcultarColumnas();
            //dataListado.Columns["idpaciente"].Visible = false;

            Gestionar_PlanEstudio();

            Gestionar_PlanTerapeutico();



        }


        private int TraerIdPlanEstudio(string cedula_pac)
        {
            int id_plan_estudio = 0;

            id_plan_estudio = buscar_plan_estudio_del_pac(Convert.ToInt32(this.lbl_idpac.Text));
        
            return id_plan_estudio;

        }

        private int TraerIdPlanTerapeutico(string cedula_pac)
        {
            int id_plan_terapeutico = 0;

            id_plan_terapeutico = buscar_plan_terapeutico_del_pac(Convert.ToInt32(this.lbl_idpac.Text));

            return id_plan_terapeutico;

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

            this.txtNumero_Documento.Text = string.Empty;
            this.txtNombre_Paciente.Text = string.Empty;
            this.txtSexo.Text = string.Empty;

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
            //this.cbPlanEstudio.Text = string.Empty;
            //this.cbPlanTerapeutico.Text = string.Empty;
            this.cblTipo_Sangre.Text = string.Empty;
            this.cbDiagnosticos.Text = string.Empty;
            



        }

        //Habilitar los controles del formulario
        private void Habilitar()
        {
            this.txtRazonConsulta.Enabled = true;
            this.txtEnfermedadActual.Enabled = true;
            this.txtHistoriaPersonal.Enabled = true;
            this.txtHistoriaFamiliar.Enabled = true;
            this.txtTratamiento_Actual.Enabled = true;
            this.txtExamenFisico.Enabled = true;
            this.txtLaboratorio.Enabled = true;
            this.txtecg.Enabled = true;
            this.txtRayos_X.Enabled = true;
            this.txtEcocardiograma.Enabled = true;
            //this.cbPlanEstudio.Enabled = true;
            //this.cbPlanTerapeutico.Enabled = true;
            this.cblTipo_Sangre.Enabled = true;
            this.cbDiagnosticos.Enabled = true;
        }

        //Habilitar los controles del formulario
        private void Deshabilitar()
        {
            this.txtRazonConsulta.Enabled = false;
            this.txtEnfermedadActual.Enabled = false;
            this.txtHistoriaPersonal.Enabled = false;
            this.txtHistoriaFamiliar.Enabled = false;
            this.txtTratamiento_Actual.Enabled = false;
            this.txtExamenFisico.Enabled = false;
            this.txtLaboratorio.Enabled = false;
            this.txtecg.Enabled = false;
            this.txtRayos_X.Enabled = false;
            this.txtEcocardiograma.Enabled = false;
            //this.cbPlanEstudio.Enabled = false;
            //this.cbPlanTerapeutico.Enabled = false;
            this.cblTipo_Sangre.Enabled = false;
            this.cbDiagnosticos.Enabled = false;
        }


        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar) //Alt + 124
            {
                this.Habilitar();
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Deshabilitar();
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }

        }



        private void LlenarComboDiagnosticos()
        {
            //llenar el cb diagnostico aplicando autocompletado

            DataTable tabla_meds = new DataTable();

            tabla_meds = NDiagnostico.Mostrar();

            if (tabla_meds == null)
            {
                MessageBox.Show("No hay registros en medicamentos ");

            }
            else
            {
                List<string> meds = tabla_meds.AsEnumerable().Select(r => r.Field<string>("enfermedad")).ToList();

                string[] meds_array = meds.ToArray();

                var autoComplete = new AutoCompleteStringCollection();
                autoComplete.AddRange(meds_array);

                this.cbDiagnosticos.AutoCompleteCustomSource = autoComplete;

                //traer toda la tabla de medicamentos
                cbDiagnosticos.ValueMember = "id"; //id
                cbDiagnosticos.DisplayMember = "enfermedad"; //medicamento




            }





            //this.cbPresentacion.DataSource = NReceta.Mostrar();
            //cbPresentacion.ValueMember = "presentacion";
            //cbPresentacion.DisplayMember = "presentacion";

            //this.cbDosis.DataSource = NReceta.Mostrar();
            //cbDosis.ValueMember = "dosis";
            //cbDosis.DisplayMember = "dosis";

        }

        //private void LlenarCbPlanTerapeutico()
        //{

            //crear un list que contenga 2 display member: "Sin Plan Terapeutico" y "Plan Terapeutico del dia 02/08/2021"
            //dichos valuemembers seran: "id=0" y "id= id_del_plan_terapeutico_del_dia_02/08/2021"

            //si se selecciona "Sin Plan Terapeutico" se guardará el id 0 en la historia.
            //pero en caso de que se seleccione "Plan Terapeutico del dia 02/08/2021" se cargará el id correspondiente a ese PlanTerapeutico

            //en caso de que no haya PlanTerapeutico de ese mismo dia, se mostrara un messagebox que 
            //diga "Los Planes Terapeuticos registrados son muy antiguos, desea crear uno con la fecha de hoy?"



            ////// Create a list  
            ////List<string> AuthorList = new List<string>();

            ////// Add items using Add method   
            ////AuthorList.Add("Mahesh Chand");
            ////AuthorList.Add("Praveen Kumar");
            ////AuthorList.Add("Raj Kumar");

            ////this.cbPlanTerapeutico.DataSource = 

        //}


        //Método para ocultar columnas
        private void OcultarColumnas()
        {

            //this.datalistadohistorias.Columns[0].Visible = false;
            //this.dataListado.Columns[1].Visible = false;



        }





        //Método Mostrar
        private void Mostrar()
        {





            //this.dataListado.DataSource = NPacientes.Mostrar();
            OcultarColumnas();
           // lblTotal.Text = "Total de Pacientes: " + Convert.ToString(dataListado.Rows.Count);




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

            //this.dataListado.DataSource = NPacientes.BuscarNombre(this.txtBuscar1.Text);
            this.OcultarColumnas();
            //lblTotal.Text = "Total de Pacientes: " + Convert.ToString(dataListado.Rows.Count);
            
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
           // this.dataListado.DataSource = NPacientes.BuscarTalla(this.txtBuscar1.Text);
            this.OcultarColumnas();
          //  lblTotal.Text = "Total de Pacientes: " + Convert.ToString(dataListado.Rows.Count);
        }


        //Método BuscarPeso
        private void BuscarPeso()
        {
            //this.dataListado.DataSource = NPacientes.BuscarPeso(this.txtBuscar.Text);
            this.OcultarColumnas();
            //lblTotal.Text = "Total de Pacientes: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarPeso
        private void BuscarCedula()
        {

            //this.dataListado.DataSource = NPacientes.BuscarNum_Documento(this.txtBuscar1.Text);
            this.OcultarColumnas();

            //lblTotal.Text = "Total de Pacientes: " + Convert.ToString(dataListado.Rows.Count);
            
            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("num_cedula LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;





            lblTotal.Text = "Total de Citas: " + Convert.ToString(dataListado.Rows.Count);*/
        }


        private DataTable Datos_De_La_Historia( int id_pac)
        {
            //aca se buscará la historia del paciente segun su id

            DataTable DtResultado = new DataTable("Datos_Historia");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_buscar_historia";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDBuscar = new SqlParameter();
                ParIDBuscar.ParameterName = "@id_pac";
                ParIDBuscar.SqlDbType = SqlDbType.Int;
                ParIDBuscar.Size = 50;
                ParIDBuscar.Value = id_pac;
                SqlCmd.Parameters.Add(ParIDBuscar);

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


        private void Cargar_Historia_En_Campos()
        {

            int id_pac = Buscar_idPac_por_cedula();

            DataTable HistoriaDelPac = Datos_De_La_Historia(id_pac);

            if (HistoriaDelPac.Rows.Count <= 0)
            {

                MessageBox.Show("Oops, este paciente no tiene historia!");
                HistoriaDelPac = null;

            }
            else
            {

                MessageBox.Show("Este paciente posee historia");

                //meter los row/column de esa datatable en cada campo del form


                this.dtpFechaConsulta.Value = Convert.ToDateTime(HistoriaDelPac.Rows[0][2]);
                this.txtRazonConsulta.Text = Convert.ToString(HistoriaDelPac.Rows[0][3]);
                this.txtEnfermedadActual.Text = Convert.ToString(HistoriaDelPac.Rows[0][4]);
                this.txtHistoriaFamiliar.Text = Convert.ToString(HistoriaDelPac.Rows[0][5]);
                this.txtHistoriaPersonal.Text = Convert.ToString(HistoriaDelPac.Rows[0][6]);
                this.txtTratamiento_Actual.Text = Convert.ToString(HistoriaDelPac.Rows[0][7]);
                this.txtExamenFisico.Text = Convert.ToString(HistoriaDelPac.Rows[0][8]);
                this.txtExamenFisico.Text = Convert.ToString(HistoriaDelPac.Rows[0][9]);
                this.txtLaboratorio.Text = Convert.ToString(HistoriaDelPac.Rows[0][10]);
                this.txtecg.Text = Convert.ToString(HistoriaDelPac.Rows[0][11]);
                this.txtRayos_X.Text = Convert.ToString(HistoriaDelPac.Rows[0][12]);
                this.txtEcocardiograma.Text = Convert.ToString(HistoriaDelPac.Rows[0][13]);
                this.cblTipo_Sangre.Text = Convert.ToString(HistoriaDelPac.Rows[0][14]);



            }

            


        }







        private void Gestionar_PlanEstudio()
        {



            ///////////////////////////// PLAN ESTUDIO WIP //////////////////////////////



            //se busca segun la cedula y segun la fecha de emision a ver si existe un plan de estudio

            //si la fecha es igual a la de la historia, se selecciona.

            //si la fecha es diferente, se debe crear un nuevo plan de estudio


            if (TraerIdPlanEstudio(this.txtNumero_Documento.Text) == 0)
            {
                this.btnVerPlanEstudio.Text = "Sin plan de estudio seleccionado";
                this.btnVerPlanEstudio.BackColor = Color.DarkGray;
            }
            else
            {
                //buscar la fecha de ese plan de estudio para ver si es del dia de hoy, o es muy vieja.

                this.btnVerPlanEstudio.Text = "Plan de estudio asignado";
                this.btnVerPlanEstudio.BackColor = Color.LightSeaGreen;

            }





        }


        private void Gestionar_PlanTerapeutico()
        {


            ///////////////////////////// PLAN TERAPEUTICO WIP //////////////////////////////

            //se busca segun la cedula y segun la fecha de emision a ver si existe un plan terapeutico

            //si la fecha es igual a la de la historia, se selecciona.

            //si la fecha es diferente, se debe crear un nuevo plan terapeutico


            if (TraerIdPlanTerapeutico(this.txtNumero_Documento.Text) == 0)
            {
                this.btnVerPlanTerapeutico.Text = "Sin plan terapeutico seleccionado";
                this.btnVerPlanTerapeutico.BackColor = Color.DarkGray;
            }
            else
            {
                //buscar la fecha de ese plan terapeutico para ver si es del dia de hoy, o es muy vieja.

                this.btnVerPlanTerapeutico.Text = "Plan terapeutico asignado";
                this.btnVerPlanTerapeutico.BackColor = Color.LightSeaGreen;

            }
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
               // dataListado.DataSource = bSource;
                sda.Update(dbdataset);


            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error");
            }





            //this.OcultarColumnas();
            //lblTotal.Text = "Total de Citas: " + Convert.ToString(dataListado.Rows.Count);
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


        //private void OpcionPlanEstudio()
        //{
        //    if (cbPlanEstudio.SelectedIndex == 0)
        //    {
        //        this.cbPlanEstudio.ValueMember = "0";


        //    }
        //    else if (cbPlanEstudio.SelectedIndex == 1)
        //    {
        //        this.cbPlanEstudio.ValueMember = Convert.ToString(buscar_plan_estudio_del_pac(Convert.ToInt32(lblCodigoPaciente.Text)));
        //    }

        //    MessageBox.Show(Convert.ToString(cbPlanEstudio.ValueMember));
        //}




        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            //aca te lleva a la pestaña de historia
            this.tabControl1.SelectedIndex = 1;

            //this.lbl_ci_pac.Text = this.txtCedula.Text;
            //this.txtPaciente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            //this.lblCodigoPaciente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idpaciente"].Value);



            ////this.cbPlanEstudio.Items.Add("Sin Plan de Estudio");

            ////this.cbPlanEstudio.Items.Add(Convert.ToString(buscar_plan_estudio_del_pac(Convert.ToInt32(lblCodigoPaciente.Text))));


            //OpcionPlanEstudio();


            



            ////this.lblCodigoCita.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idcita"].Value);
            //this.cmbTipoCedula.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_cedula"].Value);
            //this.txtCedula.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["num_cedula"].Value);
            ////this.txtServicio.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Servicio"].Value);
            //this.txtMostrarPeso.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["peso"].Value);
            //this.txtMostrarTalla.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["talla"].Value);

            //this.lbl_nombre_pac.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            //this.lbl_id_historia.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idpaciente"].Value);
            ////this.lbl_ci_pac.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["num_cedula"].Value);


            this.OcultarColumnas();
        }

        //private void txtBuscar_TextChanged(object sender, EventArgs e)
        //{
        //    if (this.cblBusqueda.Text.Equals("Paciente"))
        //    {

        //        this.BuscarNombre();
                
        //    }
        //    else if (this.cblBusqueda.Text.Equals("Servicio"))
        //    {
        //        //this.BuscarServicio();
        //    }

        //    else if (this.cblBusqueda.Text.Equals("Talla"))
        //    {
        //        this.BuscarTalla();
        //    }

        //    else if (this.cblBusqueda.Text.Equals("Peso"))
        //    {
        //        this.BuscarPeso();
        //    }

        //    else if (this.cblBusqueda.Text.Equals("Cedula"))
        //    {
        //        this.BuscarCedula();
                
        //    }
        //}

        //private void btnBuscar_Click(object sender, EventArgs e)
        //{
        //    if (this.cblBusqueda.Text.Equals("Paciente"))
        //    {



        //        this.BuscarNombre();
                
        //    }
        //    else if (this.cblBusqueda.Text.Equals("Servicio"))
        //    {
        //        //this.BuscarServicio();
        //    }

        //    else if (this.cblBusqueda.Text.Equals("Talla"))
        //    {
        //        this.BuscarTalla();
        //    }

        //    else if (this.cblBusqueda.Text.Equals("Peso"))
        //    {
        //        this.BuscarPeso();
        //    }

        //    else if (this.cblBusqueda.Text.Equals("Cedula"))
        //    {
        //        this.BuscarCedula();
                
        //    }
        //}

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar();

            OcultarColumnas();


            this.dtpFechaConsulta.Value = DateTime.Today;


        }

        //private void btnGuardar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string rpta = "";
        //        if (this.lblCodigoPaciente.Text == string.Empty)
        //        {
        //            MessageBox.Show("No puede dejar campos vacios o sin seleccionar. ", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //            this.tabControl1.SelectedIndex = 1;
        //        }
        //        else
        //        {



        //            if (this.IsNuevo)
        //            {


        //                SqlConnection SqlCon = new SqlConnection();



        //                //Código
        //                SqlCon.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
        //                SqlCon.Open();
        //                //Establecer el Comando
        //                SqlCommand SqlCmd = new SqlCommand();
        //                SqlCmd.Connection = SqlCon;
        //                SqlCmd.CommandText = "insert into Historia (idpaciente, fecha_consulta, razon_consulta, enfermedad_actual, historia_familiar, historia_personal, tratamiento_actual, examen_fisico, laboratorio, ecg, rayos_x, ecocardiograma, plan_estudio, plan_terapeutico, estado, tipo_sangre, diagnosticos) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15, @d16, @d17);";
        //                //SqlCmd.CommandType = CommandType.StoredProcedure;



        //                //Sqlcmd.Parameters.AddWithValue("@d1", txtNombreCliente.Text);
        //               // SqlCmd.Parameters.AddWithValue("@d1", this.lblCodigoPaciente.Text);
        //                SqlCmd.Parameters.AddWithValue("@d2", this.dtpFechaConsulta.Text);
        //                SqlCmd.Parameters.AddWithValue("@d3", this.txtRazonConsulta.Text);
        //                SqlCmd.Parameters.AddWithValue("@d4", this.txtEnfermedadActual.Text);
        //                SqlCmd.Parameters.AddWithValue("@d5", this.txtHistoriaFamiliar.Text);
        //                SqlCmd.Parameters.AddWithValue("@d6", this.txtHistoriaPersonal.Text);
        //                SqlCmd.Parameters.AddWithValue("@d7", this.txtTratamiento_Actual.Text);
        //                SqlCmd.Parameters.AddWithValue("@d8", this.txtExamenFisico.Text);
        //                SqlCmd.Parameters.AddWithValue("@d9", this.txtLaboratorio.Text);
        //                SqlCmd.Parameters.AddWithValue("@d10", this.txtecg.Text);
        //                SqlCmd.Parameters.AddWithValue("@d11", this.txtRayos_X.Text);
        //                SqlCmd.Parameters.AddWithValue("@d12", this.txtEcocardiograma.Text);
        //                //SqlCmd.Parameters.AddWithValue("@d13", this.cbPlanEstudio.Text);
        //                //SqlCmd.Parameters.AddWithValue("@d14", this.cbPlanTerapeutico.Text);
        //                SqlCmd.Parameters.AddWithValue("@d15", this.cmbEstadoHistoria.Text);
        //                SqlCmd.Parameters.AddWithValue("@d16", this.cblTipo_Sangre.Text);
        //                SqlCmd.Parameters.AddWithValue("@d17", this.cbDiagnosticos.Text);





        //                //Ejecutamos nuestro comando

        //                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        //            }
        //            else
        //            {

        //                SqlConnection SqlCon = new SqlConnection();



        //                //Código
        //                SqlCon.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
        //                SqlCon.Open();
        //                //Establecer el Comando
        //                SqlCommand SqlCmd = new SqlCommand();
        //                SqlCmd.Connection = SqlCon;
        //                SqlCmd.CommandText = "update Historia set idpaciente = @d1, fecha_consulta = @d2, razon_consulta = @d3, enfermedad_actual = @d4, historia_familiar = @d5, historia_personal = @d6, tratamiento_actual = @d7, examen_fisico = @d8, laboratorio = @d9, ecg = @d10, rayos_x = @d11, ecocardiograma = @d12, plan_estudio = @d13, plan_terapeutico = @d14,  estado = @d15 , tipo_sangre = @d17, diagnosticos = @d18 where idhistoria=@d16";
        //                //SqlCmd.CommandType = CommandType.StoredProcedure;



        //                //Sqlcmd.Parameters.AddWithValue("@d1", txtNombreCliente.Text);
        //                //SqlCmd.Parameters.AddWithValue("@d1", this.lblCodigoPaciente.Text);
        //                SqlCmd.Parameters.AddWithValue("@d2", this.dtpFechaConsulta.Text);
        //                SqlCmd.Parameters.AddWithValue("@d3", this.txtRazonConsulta.Text);
        //                SqlCmd.Parameters.AddWithValue("@d4", this.txtEnfermedadActual.Text);
        //                SqlCmd.Parameters.AddWithValue("@d5", this.txtHistoriaFamiliar.Text);
        //                SqlCmd.Parameters.AddWithValue("@d6", this.txtHistoriaPersonal.Text);
        //                SqlCmd.Parameters.AddWithValue("@d7", this.txtTratamiento_Actual.Text);
        //                SqlCmd.Parameters.AddWithValue("@d8", this.txtExamenFisico.Text);
        //                SqlCmd.Parameters.AddWithValue("@d9", this.txtLaboratorio.Text);
        //                SqlCmd.Parameters.AddWithValue("@d10", this.txtecg.Text);
        //                SqlCmd.Parameters.AddWithValue("@d11", this.txtRayos_X.Text);
        //                SqlCmd.Parameters.AddWithValue("@d12", this.txtEcocardiograma.Text);
        //                //SqlCmd.Parameters.AddWithValue("@d13", this.cbPlanEstudio.Text);
        //                //SqlCmd.Parameters.AddWithValue("@d14", this.cbPlanTerapeutico.Text);
        //                SqlCmd.Parameters.AddWithValue("@d15", this.cmbEstadoHistoria.Text);
        //                SqlCmd.Parameters.AddWithValue("@d16", this.lbl_id_historia.Text);
        //                SqlCmd.Parameters.AddWithValue("@d17", this.cblTipo_Sangre.Text);
        //                SqlCmd.Parameters.AddWithValue("@d18", this.cbDiagnosticos.Text);





        //                //Ejecutamos nuestro comando

        //                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";



        //            }


        //            if (this.IsNuevo)
        //            {
        //                this.MensajeOk("Se Insertó de forma correcta la historia clinica");
        //                this.OperacionInsertarHistoria();
        //            }
        //            else
        //            {
        //                this.MensajeOk("Se Actualizó de forma correcta la historia clinica");
        //                this.OperacionEditarHistoria();
        //            }



        //            this.IsNuevo = false;
        //            this.IsEditar = false;
        //            this.Botones();
        //            this.Limpiar();
        //            this.Mostrar();
        //            this.MostrarHistoriasActivas();


        //            OcultarColumnas();


        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message + ex.StackTrace);
        //    }
        //}

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.lbl_id_historia.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar();
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
            this.Deshabilitar();
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
           // this.lblCodigoPaciente.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["idpaciente"].Value);

            //this.lbl_ci_pac.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["num_cedula"].Value);
            //this.lbl_nombre_pac.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["Paciente"].Value);


            //aca se pasan los datos del Historia a Evolucion 
            this.lbl_id_historia_evol.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["idhistoria"].Value);
            this.lblNombrePaciente_evol.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["Paciente"].Value);
            this.lblCedulaPaciente_evol.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["num_cedula"].Value);

            //aca se pasan los datos del Historia a Evolucion Lista
            this.lbl_lista_evol_id_historia.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["idhistoria"].Value);
            this.lbl_lista_evol_nombre.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["Paciente"].Value);
            this.lbl_lista_evol_ci.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["num_cedula"].Value);

            //aca pasan de lista a historias clinicas

            //this.lbl_nombre_pac.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            //this.lbl_id_historia.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idpaciente"].Value);
            //this.lbl_ci_pac.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["num_cedula"].Value);



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
            //this.cbPlanEstudio.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["plan_estudio"].Value);
            //this.cbPlanTerapeutico.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["plan_terapeutico"].Value);
            this.cmbEstadoHistoria.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["estado"].Value);

            this.cbDiagnosticos.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["diagnosticos"].Value);
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

        //private void label2_MouseHover(object sender, EventArgs e)
        //{
        //    this.ttMensaje.SetToolTip(this.label3, "Campo Obligatorio");
        //}

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
                //dataListado.Columns["idpaciente"].Visible = false;
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
            //lblNombrePaciente_evol.Text = this.lbl_nombre_pac.Text;
            //lblCedulaPaciente_evol.Text = this.lbl_ci_pac.Text;

            //para llevar los datos de la Historia a la pestaña de Lista Evolucion
            lbl_lista_evol_id_historia.Text = this.lbl_id_historia.Text;
            //lbl_lista_evol_ci.Text = this.lbl_ci_pac.Text;
            //lbl_lista_evol_nombre.Text = this.lbl_nombre_pac.Text;

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

        
        

        private void datalistadoMuertos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAbrirArchivoMuerto_Click(object sender, EventArgs e)
        {
            frmArchivosMuertos frm = new frmArchivosMuertos();
            frm.ShowDialog();
        }

        private void cbPlanTerapeutico_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mostrar el nombre y cedula del pac, fecha del plan terapeutico, y lista de Recipe e Indicaciones");
        }

        private void cbDiagnosticos_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.KeyChar -= (char)32;
            }



        }


        private int buscar_plan_estudio_del_pac(int id_pac)
        {

            //aca se buscará cual es el ID de el PlanEstudio de ese paciente.

                DataTable DtResultado = new DataTable("PlanEstudioDelPac");
                SqlConnection SqlCon = new SqlConnection();
                try
                {
                    SqlCon.ConnectionString = Conexion.Cn;
                    SqlCommand SqlCmd = new SqlCommand();
                    SqlCmd.Connection = SqlCon;
                    SqlCmd.CommandText = "sp_buscar_idplanestudio_segun_idpac";
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDBuscar = new SqlParameter();
                ParIDBuscar.ParameterName = "@id_pac";
                ParIDBuscar.SqlDbType = SqlDbType.Int;
                ParIDBuscar.Size = 50;
                ParIDBuscar.Value = id_pac;
                SqlCmd.Parameters.Add(ParIDBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                    SqlDat.Fill(DtResultado);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    DtResultado = null;
                }


            int id_del_plan_estudio = 0;


            if (DtResultado.Rows.Count <= 0 )
            {

                //MessageBox.Show("whoops!");
                id_del_plan_estudio = 0;

            }
            else
            {
                id_del_plan_estudio = Convert.ToInt32(DtResultado.Rows[0][0]);
            }


            return id_del_plan_estudio;


            

            //Se cargara en el txtbox 2 opciones: 
            // 1. Sin PlanEstudio
            // 2. Con PlanEstudio

            //el id dependera de la opcion
            //en caso de ser la primera, el id será 0
            //en caso de ser la segunda, primero se valida la fecha de dicho registro 
            //(si es de hoy, se guarda el id. Si es muy vieja se muestra un messagebox pidiendo crear un nuevo PlanEstudio

        }




        private int buscar_plan_terapeutico_del_pac(int id_pac)
        {

            //aca se buscará cual es el ID de el PlanTerapeutico de ese paciente.

            DataTable DtResultado = new DataTable("PlanTerapeuticoDelPac");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_buscar_idplanterapeutico_segun_idpac";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDBuscar = new SqlParameter();
                ParIDBuscar.ParameterName = "@id_pac";
                ParIDBuscar.SqlDbType = SqlDbType.Int;
                ParIDBuscar.Size = 50;
                ParIDBuscar.Value = id_pac;
                SqlCmd.Parameters.Add(ParIDBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                DtResultado = null;
            }




            int id_del_plan_terapeutico = 0;


            if (DtResultado.Rows.Count <= 0)
            {

                //MessageBox.Show("whoops!");
                id_del_plan_terapeutico = 0;

            }
            else
            {
                id_del_plan_terapeutico = Convert.ToInt32(DtResultado.Rows[0][0]);
            }


            return id_del_plan_terapeutico;


            //Se cargara en el txtbox 2 opciones: 
            // 1. Sin PlanEstudio
            // 2. Con PlanEstudio

            //el id dependera de la opcion
            //en caso de ser la primera, el id será 0
            //en caso de ser la segunda, primero se valida la fecha de dicho registro 
            //(si es de hoy, se guarda el id. Si es muy vieja se muestra un messagebox pidiendo crear un nuevo PlanEstudio

        }




        private int Buscar_idPac_por_cedula()
        {

            string cedula_del_pac = this.txtNumero_Documento.Text;

            DataTable paciente_tabla = new DataTable();

            paciente_tabla = NPacientes.BuscarNum_Documento(cedula_del_pac);

            int id_del_pac = 0;

            if (paciente_tabla.Rows.Count == 0)
            {
                //MessageBox.Show("no existe ese paciente");
                id_del_pac = 0;
            }
            else
            {

                id_del_pac = Convert.ToInt32(paciente_tabla.Rows[0][0]);
                string nombre_del_pac = Convert.ToString(paciente_tabla.Rows[0][1]);
                string sexo_del_pac = Convert.ToString(paciente_tabla.Rows[0][5]);


                this.txtNombre_Paciente.Text = nombre_del_pac;
                this.txtSexo.Text = sexo_del_pac;

                this.dtpNacimientoPac.Text = Convert.ToString(paciente_tabla.Rows[0][4]);


                //lblTotal.Text = "Total de Pacientes: " + Convert.ToString(paciente_tabla.Rows.Count);
            }

            return id_del_pac;

        }





        private void buscar_plan_terapeutico_del_pac()
        {
            //aca se buscará cual es el ID de el PlanTerapeutico de ese paciente.

            //Se cargara en el txtbox 2 opciones: 
            // 1. Sin PlanTerapeutico
            // 2. Con PlanTerapeutico

            //el id dependera de la opcion
            //en caso de ser la primera, el id será 0
            //en caso de ser la segunda, primero se valida la fecha de dicho registro 
                //(si es de hoy, se guarda el id. Si es muy vieja se muestra un messagebox pidiendo crear un nuevo PlanTerapeutico
        }

        private void lbl_id_pac_TextChanged(object sender, EventArgs e)
        {
            
        }

        //private void cbPlanEstudio_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    OpcionPlanEstudio();

        //}

        private void btnReporte_Historia_Click(object sender, EventArgs e)
        {
            frmListaHistorialTotal frm = new frmListaHistorialTotal();
            frm.Show();
        }

        private void cbDiagnosticos_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnVerPlanEstudio_Click(object sender, EventArgs e)
        {
            frmPlanEstudio frm = new frmPlanEstudio();
            frm.FormBorderStyle = FormBorderStyle.FixedDialog;
            frm.MinimizeBox = false;
            frm.Show();

        }

        private void btnVerPlanTerapeutico_Click(object sender, EventArgs e)
        {
            frmPlanTerapeutico frm = new frmPlanTerapeutico();
            frm.FormBorderStyle = FormBorderStyle.FixedDialog;
            frm.MinimizeBox = false;
            frm.Show();
        }

        private void txtNumero_Documento_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {

                int id_del_paciente_a_cargar;

                id_del_paciente_a_cargar = Buscar_idPac_por_cedula();

                if (id_del_paciente_a_cargar > 0)
                {
                    this.lbl_idpac.Text = id_del_paciente_a_cargar.ToString();

                    Cargar_Historia_En_Campos();

                    Gestionar_PlanEstudio();

                    Gestionar_PlanTerapeutico();

                }
                else
                {
                    MessageBox.Show("Este paciente no esta registrado");
                }

            }
        }
    }
}
