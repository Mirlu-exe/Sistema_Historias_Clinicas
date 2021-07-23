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
    public partial class frmInformesMedicosReferenciaMedicas : Form
    {



        private bool IsNuevo = false;

        private bool IsEditar = false;




        public static DUsuario Session_Actual = frmPrincipal.User_Actual;


        public frmInformesMedicosReferenciaMedicas()
        {
            InitializeComponent();
        }

        private void frmInformesMedicosReferenciaMedicas_Load(object sender, EventArgs e)
        {
            LlenarComboMedicos();

            Deshabilitar();

            this.Top = 0;
            this.Left = 0;
            //this.Mostrar();
            //this.Botones();



        }

        private void Deshabilitar()
        {
            this.groupBox1.Enabled = false;

            this.groupBox2.Enabled = false;

            this.groupBox3.Enabled = false;

            this.groupBox4.Enabled = false;

        }

        private void Habilitar()
        {
            this.groupBox1.Enabled = true;

            this.groupBox2.Enabled = true;

            this.groupBox3.Enabled = true;

            this.groupBox4.Enabled = true;

        }

        private void btnNueva_evol_Click(object sender, EventArgs e)
        {
            Habilitar();

            this.txtNumero_Documento.Focus();

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


        private void CargarEvolucionesDeLaHistoria(int id_historia_seleccionada)
        {

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

                    DateTime fecha_evol = Convert.ToDateTime(evoluciones_por_historia.Rows[0][2]);
                    string edad_sucesiva = Convert.ToString(evoluciones_por_historia.Rows[0][3]);
                    string diagnosticos_evol = Convert.ToString(evoluciones_por_historia.Rows[0][4]);
                    string planterapeutico_evol = Convert.ToString(evoluciones_por_historia.Rows[0][6]);

                    this.txtFecha_Ultima_Evol.Text = fecha_evol.ToString("dd/MM/yyyy");
                    this.txtEdadSuc_Evol.Text = edad_sucesiva;
                    this.txtDiagnosticos_Evol.Text = diagnosticos_evol;
                    this.txtPlanTerapeutico_Evol.Text = planterapeutico_evol;


                }
                else
                {
                    MessageBox.Show("La historia NO tiene evoluciones");
                }




            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error " + ex.ToString() + "");
            }




        }




        private void BuscarHistoria_por_Pac_id( int id_del_paciente)
        {

                string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                SqlConnection conDataBase = new SqlConnection(Cn);
                SqlCommand cmdDataBase = new SqlCommand("select Historia.idhistoria, Historia.idpaciente, Historia.historia_familiar, Historia.historia_personal, Historia.estado FROM Historia where Historia.estado = 'Activo' and Historia.idpaciente = " + id_del_paciente + " ; ", conDataBase);





                try
                {

                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmdDataBase;
                    DataTable dtHistoriasPerPaciente = new DataTable();
                    sda.Fill(dtHistoriasPerPaciente);


                    if (dtHistoriasPerPaciente.Rows.Count == 0)
                    {
                        MessageBox.Show("este paciente no tiene historia clinica");
                    }
                    else
                    {

                        int id_historia_del_pac = Convert.ToInt32(dtHistoriasPerPaciente.Rows[0][0]);
                        string historia_familiar_del_pac = Convert.ToString(dtHistoriasPerPaciente.Rows[0][2]);
                        string historia_personal_del_pac = Convert.ToString(dtHistoriasPerPaciente.Rows[0][3]);

                    
                        this.txtHistoriaFamiliar.Text = historia_familiar_del_pac;
                        this.txtHistoriaPersonal.Text = historia_personal_del_pac;


                        //se envia el id de la historia para buscar sus ultima evolucion
                        CargarEvolucionesDeLaHistoria(id_historia_del_pac);
                    
                    }

                }
                catch (Exception ex)
                {


                    MessageBox.Show("Ha ocurrido un error: " + ex.ToString() + "");
                }



            

        }


        private void LlenarComboMedicos()
        {
            this.cbMedicosConfianza.DataSource = NMedicosConfianza.Mostrar();
            cbMedicosConfianza.ValueMember = "nombre";
            cbMedicosConfianza.DisplayMember = "nombre";

        }

        private void txtNumero_Documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                int id_del_paciente_a_cargar;

                id_del_paciente_a_cargar = Buscar_idPac_por_cedula();

                if (id_del_paciente_a_cargar > 0)
                {
                    BuscarHistoria_por_Pac_id(id_del_paciente_a_cargar);
                }
                else
                {
                    MessageBox.Show("Este paciente no esta registrado");
                }


                


            }
        }

        private void cbMedicosConfianza_DropDownClosed(object sender, EventArgs e)
        {
            if (this.cbMedicosConfianza.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un medico de la lista");
            }
            else
            {
                //MessageBox.Show(Convert.ToString(this.cmbPacientes.Text));

                string nombremed = this.cbMedicosConfianza.Text;


                string CN = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                string Query = "select * from MedicoConfianza where nombre = '" + nombremed + "' ;";
                SqlConnection conDataBase = new SqlConnection(CN);
                SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
                SqlDataReader myReader;

                try
                {

                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();

                    while (myReader.Read())
                    {

                        //string idmedico = myReader["idmedico"].ToString();
                        string nombre = myReader["nombre"].ToString();
                        string especialidad = myReader["especialidad"].ToString();
                        string telefono = myReader["telefono"].ToString();
                        string direccion = myReader["direccion"].ToString();



                        //this.lblCodMed.Text = idmedico;

                        this.txtEspecialidadMed.Text = especialidad;
                        this.txtTelefonoMedico.Text = telefono;
                        this.txtDireccionMedico.Text = direccion;



                    }



                }
                catch (Exception ex)
                {


                }


            }

        }

        private void btnGuardar_informe_Click(object sender, EventArgs e)
        {

            //Guardar todos los datos de los txtbox en una tabla llamada InformesParaReferencias, 
            //incluyendo la fecha en la que se guardó esta referencia.

            //try
            //{
            //    string rpta = "";
            //    if (this.txtNumero_Documento.Text == string.Empty)
            //    {
            //        MessageBox.Show("No puede dejar campos vacios o sin seleccionar. ", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //        this.tabControl1.SelectedIndex = 1;
            //    }
            //    else
            //    {



            //        if (this.IsNuevo)
            //        {


            //            SqlConnection SqlCon = new SqlConnection();



            //            //Código
            //            SqlCon.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            //            SqlCon.Open();
            //            //Establecer el Comando
            //            SqlCommand SqlCmd = new SqlCommand();
            //            SqlCmd.Connection = SqlCon;
            //            SqlCmd.CommandText = "insert into Historia (idpaciente, fecha_consulta, razon_consulta, enfermedad_actual, historia_familiar, historia_personal, tratamiento_actual, examen_fisico, laboratorio, ecg, rayos_x, ecocardiograma, plan_estudio, plan_terapeutico, estado) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15);";
            //            //SqlCmd.CommandType = CommandType.StoredProcedure;



            //            //Sqlcmd.Parameters.AddWithValue("@d1", txtNombreCliente.Text);
            //            SqlCmd.Parameters.AddWithValue("@d1", this.lblCodigoPaciente.Text);
            //            SqlCmd.Parameters.AddWithValue("@d2", this.dtpFechaConsulta.Text);
            //            SqlCmd.Parameters.AddWithValue("@d3", this.txtRazonConsulta.Text);
            //            SqlCmd.Parameters.AddWithValue("@d4", this.txtEnfermedadActual.Text);
            //            SqlCmd.Parameters.AddWithValue("@d5", this.txtHistoriaFamiliar.Text);
            //            SqlCmd.Parameters.AddWithValue("@d6", this.txtHistoriaPersonal.Text);
            //            SqlCmd.Parameters.AddWithValue("@d7", this.txtTratamiento_Actual.Text);
            //            SqlCmd.Parameters.AddWithValue("@d8", this.txtExamenFisico.Text);
            //            SqlCmd.Parameters.AddWithValue("@d9", this.txtLaboratorio.Text);
            //            SqlCmd.Parameters.AddWithValue("@d10", this.txtecg.Text);
            //            SqlCmd.Parameters.AddWithValue("@d11", this.txtRayos_X.Text);
            //            SqlCmd.Parameters.AddWithValue("@d12", this.txtEcocardiograma.Text);
            //            SqlCmd.Parameters.AddWithValue("@d13", this.txtPlanEstudio.Text);
            //            SqlCmd.Parameters.AddWithValue("@d14", this.txtTerapeutico.Text);
            //            SqlCmd.Parameters.AddWithValue("@d15", this.cmbEstadoHistoria.Text);





            //            //Ejecutamos nuestro comando

            //            rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




            //        }
            //        else
            //        {

            //            SqlConnection SqlCon = new SqlConnection();



            //            //Código
            //            SqlCon.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            //            SqlCon.Open();
            //            //Establecer el Comando
            //            SqlCommand SqlCmd = new SqlCommand();
            //            SqlCmd.Connection = SqlCon;
            //            SqlCmd.CommandText = "update Historia set idpaciente = @d1, fecha_consulta = @d2, razon_consulta = @d3, enfermedad_actual = @d4, historia_familiar = @d5, historia_personal = @d6, tratamiento_actual = @d7, examen_fisico = @d8, laboratorio = @d9, ecg = @d10, rayos_x = @d11, ecocardiograma = @d12, plan_estudio = @d13, plan_terapeutico = @d14, estado = @d15 where idhistoria=@d16";
            //            //SqlCmd.CommandType = CommandType.StoredProcedure;



            //            //Sqlcmd.Parameters.AddWithValue("@d1", txtNombreCliente.Text);
            //            SqlCmd.Parameters.AddWithValue("@d1", this.lblCodigoPaciente.Text);
            //            SqlCmd.Parameters.AddWithValue("@d2", this.dtpFechaConsulta.Text);
            //            SqlCmd.Parameters.AddWithValue("@d3", this.txtRazonConsulta.Text);
            //            SqlCmd.Parameters.AddWithValue("@d4", this.txtEnfermedadActual.Text);
            //            SqlCmd.Parameters.AddWithValue("@d5", this.txtHistoriaFamiliar.Text);
            //            SqlCmd.Parameters.AddWithValue("@d6", this.txtHistoriaPersonal.Text);
            //            SqlCmd.Parameters.AddWithValue("@d7", this.txtTratamiento_Actual.Text);
            //            SqlCmd.Parameters.AddWithValue("@d8", this.txtExamenFisico.Text);
            //            SqlCmd.Parameters.AddWithValue("@d9", this.txtLaboratorio.Text);
            //            SqlCmd.Parameters.AddWithValue("@d10", this.txtecg.Text);
            //            SqlCmd.Parameters.AddWithValue("@d11", this.txtRayos_X.Text);
            //            SqlCmd.Parameters.AddWithValue("@d12", this.txtEcocardiograma.Text);
            //            SqlCmd.Parameters.AddWithValue("@d13", this.txtPlanEstudio.Text);
            //            SqlCmd.Parameters.AddWithValue("@d14", this.txtTerapeutico.Text);
            //            SqlCmd.Parameters.AddWithValue("@d15", this.cmbEstadoHistoria.Text);
            //            SqlCmd.Parameters.AddWithValue("@d16", this.lbl_id_historia.Text);





            //            //Ejecutamos nuestro comando

            //            rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";



            //        }


            //        if (this.IsNuevo)
            //        {
            //            this.MensajeOk("Se Insertó de forma correcta la historia clinica");
            //            this.OperacionInsertarHistoria();
            //        }
            //        else
            //        {
            //            this.MensajeOk("Se Actualizó de forma correcta la historia clinica");
            //            this.OperacionEditarHistoria();
            //        }



            //        this.IsNuevo = false;
            //        this.IsEditar = false;
            //        this.Botones();
            //        this.Limpiar();
            //        this.Mostrar();
            //        this.MostrarHistoriasActivas();
            //        this.MostrarHistoriasAnuladas();


            //        OcultarColumnas();


            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + ex.StackTrace);
            //}


        }

        private void btnNueva_informe_Click(object sender, EventArgs e)
        {
        //    this.IsNuevo = true;
        //    this.IsEditar = false;
        //    this.Botones();
        //    this.Limpiar();
        //    this.Habilitar(true);
        //    this.txtPaciente.Focus();

        //    this.tabControl1.SelectedIndex = 1;

        //    OcultarColumnas();
        }

        private void btnEditar_informe_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_informe_Click(object sender, EventArgs e)
        {

        }

        private void cbMedicosConfianza_Validated(object sender, EventArgs e)
        {

        }
    }
}
