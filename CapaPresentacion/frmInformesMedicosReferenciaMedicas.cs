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
            //Mostrar_Informes_Meds();
            this.dataListado.DataSource = Mostrar_Informe_Referencia();

            this.OcultarColumnas();
            lblTotal.Text = "Total de Pacientes: " + Convert.ToString(dataListado.Rows.Count);
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

        private void Limpiar()
        {
            this.txtNumero_Documento.Clear();
            this.cbMedicosConfianza.SelectedIndex = -1;
        }

        private void btnNueva_evol_Click(object sender, EventArgs e)
        {
            Habilitar();

            this.txtNumero_Documento.Focus();

        }

        //Método para ocultar columnas
        private void OcultarColumnas()
        {
            this.dataListado.Columns[1].Visible = false;
            this.dataListado.Columns[3].Visible = false;
            this.dataListado.Columns[4].Visible = false;
            this.dataListado.Columns[5].Visible = false;
            this.dataListado.Columns["idpaciente"].Visible = false;
            this.dataListado.Columns["estado"].Visible = false;

        }

 

        //Método Mostrar Informes
        public DataTable Mostrar_Informe_Referencia()
        {
            DataTable DtResultado = new DataTable("Informes");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SELECT *FROM InformesParaReferencias INNER JOIN Paciente ON InformesParaReferencias.id = Paciente.idpaciente";
                SqlCmd.CommandType = CommandType.Text;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

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

        private int Traer_Id_Ultima_Evol( int id_historia_seleccionada) 
        {
            //si posee evoluciones, mostrarlas todas

            DataTable evoluciones_por_historia = new DataTable();



            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            SqlCommand cmdDataBase = new SqlCommand("SELECT * " +
                "FROM Evoluciones " +
                "INNER JOIN Historia ON Evoluciones.idhistoria = Historia.idhistoria " +
                "WHERE Historia.estado = 'Activo' AND Evoluciones.idhistoria = " + id_historia_seleccionada + " ; ", conDataBase);

            int id_evol;

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

                    DateTime fecha_evol = Convert.ToDateTime(evoluciones_por_historia.Rows[evoluciones_por_historia.Rows.Count - 1][2]);
                    

                    this.txtFecha_Ultima_Evol.Text = fecha_evol.ToString("dd/MM/yyyy");
                    id_evol = Convert.ToInt32(evoluciones_por_historia.Rows[0][0]);

                }
                else //aca tengo que poner la edad
                {
                    MessageBox.Show("La historia NO tiene evoluciones");
                    id_evol = 0;
                    txtEdadSuc_Evol.Clear();

                }




            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error " + ex.ToString() + "");

                id_evol = 0;
            }


            return id_evol;

        }



        private void CargarEvolucionesDeLaHistoria(int id_historia_seleccionada)
        {
            
            //si posee evoluciones, mostrarlas todas

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
                    txtEdadSuc_Evol.Clear();
                }




            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error " + ex.ToString() + "");
            }




        }


        private int Traer_Id_Historia_Pac(int id_pac_seleccionado)
        {


            string Cn = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            SqlCommand cmdDataBase = new SqlCommand("select Historia.idhistoria, Historia.idpaciente, Historia.historia_familiar, Historia.historia_personal, Historia.estado FROM Historia where Historia.estado = 'Activo' and Historia.idpaciente = " + id_pac_seleccionado + " ; ", conDataBase);


            int id_de_historia;


            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dtHistoriasPerPaciente = new DataTable();
                sda.Fill(dtHistoriasPerPaciente);


                if (dtHistoriasPerPaciente.Rows.Count == 0)
                {
                    MessageBox.Show("este paciente no tiene historia clinica");

                    id_de_historia = 0;
                }
                else
                {

                    int id_historia_del_pac = Convert.ToInt32(dtHistoriasPerPaciente.Rows[0][0]);
                    string historia_familiar_del_pac = Convert.ToString(dtHistoriasPerPaciente.Rows[0][2]);
                    string historia_personal_del_pac = Convert.ToString(dtHistoriasPerPaciente.Rows[0][3]);


                    this.txtHistoriaFamiliar.Text = historia_familiar_del_pac;
                    this.txtHistoriaPersonal.Text = historia_personal_del_pac;

                    DateTime Edad_Pac = Convert.ToDateTime(dtHistoriasPerPaciente.Rows[0][4]);

                    //DateTime Fecha_Nac_Pac = new DateTime(Edad_Pac); //Fecha de nacimiento
                    int edad = DateTime.Today.AddTicks(-Edad_Pac.Ticks).Year - 1;
                    string edad_paciente = Convert.ToString(edad);

                    this.txtEdadSuc_Evol.Text = edad_paciente;



                    //se envia el id de la historia para buscar sus ultima evolucion
                    CargarEvolucionesDeLaHistoria(id_historia_del_pac);

                    id_de_historia = id_historia_del_pac;

                }

            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error: " + ex.ToString() + "");
                id_de_historia = 0;
            }


            return id_de_historia;


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

        private void Medicos_Cargar_Txt()
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
                        string correo = myReader["correo"].ToString();



                        //this.lblCodMed.Text = idmedico;

                        this.txtEspecialidadMed.Text = especialidad;
                        this.txtTelefonoMedico.Text = telefono;
                        this.txtDireccionMedico.Text = direccion;
                        this.txtCorreo.Text = correo;



                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }


            }
        }


        private void cbMedicosConfianza_DropDownClosed(object sender, EventArgs e)
        {
            this.Medicos_Cargar_Txt();

        }

        private void btnGuardar_informe_Click(object sender, EventArgs e)
        {

            //Guardar todos los datos de los txtbox en una tabla llamada InformesParaReferencias, incluyendo la fecha en la que se guardó esta referencia.
            try
            {
                string rpta = "";
                if (this.txtNumero_Documento.Text == string.Empty || this.cbMedicosConfianza.SelectedIndex == -1)
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
                        SqlCmd.CommandText = "insert into InformesParaReferencias (fecha_emision, id_paciente, id_historia, id_ultima_evol, medico_nombre, medico_especialidad, medico_telefono, medico_correo, medico_direccion, historiafamiliar, historiapersonal, diagnosticos, planesterapeuticos, edad_suc, fecha_ult_evol) " +
                            "values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15);";
                        //SqlCmd.CommandType = CommandType.StoredProcedure;

                        int id_paciente_a_insertar = Buscar_idPac_por_cedula();

                        int id_historia = Traer_Id_Historia_Pac(id_paciente_a_insertar);
                        BuscarHistoria_por_Pac_id(id_paciente_a_insertar);

                        int id_ultima_evol = Traer_Id_Ultima_Evol(id_historia);

                        
                        SqlCmd.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
                        SqlCmd.Parameters.AddWithValue("@d2", id_paciente_a_insertar);
                        SqlCmd.Parameters.AddWithValue("@d3", id_historia);
                        SqlCmd.Parameters.AddWithValue("@d4", id_ultima_evol);
                        SqlCmd.Parameters.AddWithValue("@d5", this.cbMedicosConfianza.Text);
                        SqlCmd.Parameters.AddWithValue("@d6", this.txtEspecialidadMed.Text);
                        SqlCmd.Parameters.AddWithValue("@d7", this.txtTelefonoMedico.Text);
                        SqlCmd.Parameters.AddWithValue("@d8", this.txtCorreo.Text);
                        SqlCmd.Parameters.AddWithValue("@d9", this.txtDireccionMedico.Text);
                        SqlCmd.Parameters.AddWithValue("@d10", this.txtHistoriaFamiliar.Text);
                        SqlCmd.Parameters.AddWithValue("@d11", this.txtHistoriaPersonal.Text);
                        SqlCmd.Parameters.AddWithValue("@d12", this.txtDiagnosticos_Evol.Text);
                        SqlCmd.Parameters.AddWithValue("@d13", this.txtPlanTerapeutico_Evol.Text);
                        SqlCmd.Parameters.AddWithValue("@d14", this.txtEdadSuc_Evol.Text);
                        SqlCmd.Parameters.AddWithValue("@d15", this.txtFecha_Ultima_Evol.Text);





                        //Ejecutamos nuestro comando

                        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




                    }


                    if (this.IsNuevo)
                    {
                        MessageBox.Show("Se Insertó de forma correcta el informe medico para referencia");

                    }



                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Limpiar();
                    this.Deshabilitar();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnNueva_informe_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            //this.Botones();
            this.Limpiar();
            this.Habilitar();
            this.txtNumero_Documento.Focus();

        //    this.tabControl1.SelectedIndex = 1;

        //    OcultarColumnas();
        }


        private void btnCancelar_informe_Click(object sender, EventArgs e)
        {

        }

        private void cbMedicosConfianza_Validated(object sender, EventArgs e)
        {

        }

        private void txtHistoriaPersonal_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbMedicosConfianza_Leave(object sender, EventArgs e)
        {
            this.Medicos_Cargar_Txt();
        }

        private void cbMedicosConfianza_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //this.Medicos_Cargar_Txt();
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

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Anular"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Anular"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
            }
        }
    }
}
