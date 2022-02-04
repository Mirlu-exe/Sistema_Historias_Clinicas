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
using CapaPresentacion;

namespace CapaPresentacion
{
    public partial class frmPapeleraReciclaje : Form
    {

        public static DUsuario Session_Actual = frmPrincipal.User_Actual;


        public frmPapeleraReciclaje()
        {
            InitializeComponent();
        }

        private void frmPapeleraReciclaje_Load(object sender, EventArgs e)
        {

            if (Session_Actual.Acceso == "Administrador")
            {
                this.btnBorrar_def_pac.Enabled = true;
            }
            else
            {
                this.btnBorrar_def_pac.Enabled = false;
            }


            this.dgv_Pacientes.DataSource = MostrarPacientesAnulados();

            OcultarColumnasPaciente();

            this.dgv_Historia.DataSource = MostrarHistoriasAnuladas();

            OcultarColumnasHistoria();

            this.dgv_Evol.DataSource = MostrarEvolucionesAnuladas();

            //OcultarColumnasHistoria();

            this.dgv_Citas.DataSource = MostrarCitasAnuladas();

            OcultarColumnasCitas();

            this.dgv_Servicios.DataSource = MostrarServiciosAnulados();

            OcultarColumnasServicio();

            this.dgv_Diagnosticos.DataSource = MostrarDiagnosticosAnulados();

            OcultarColumnasDiagnosticos();

            this.dgv_meds.DataSource = MostrarMedsAnulados();

            //OcultarColumnasMeds();

            this.dgv_Medicos.DataSource = MostrarMedicosAnulados();

            //OcultarColumnasMedicos();

            this.dgv_estudios.DataSource = MostrarEstudiosAnulados();

            //OcultarColumnasEstudios();

            this.dgv_usuarios.DataSource = MostrarUsuariosAnulados();

            OcultarColumnasUsuarios();

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
           
        }
        


        public DataTable MostrarPacientesAnulados()
        {
            DataTable DtResultado = new DataTable("PacientesAnulados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_pacientes_anulados";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
                MessageBox.Show(ex.ToString());
            }
            return DtResultado;
        }

        //Método para ocultar columnas
        private void OcultarColumnasPaciente()
        {

            this.dgv_Pacientes.Columns["idpaciente"].Visible = false;
            this.dgv_Pacientes.Columns["estado"].Visible = false;
            this.dgv_Pacientes.Columns["is_dead"].Visible = false;

        }

        public DataTable MostrarHistoriasAnuladas()
        {
            DataTable DtResultado = new DataTable("HistoriasAnuladas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_historias_anuladas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
                MessageBox.Show(ex.ToString());
            }
            return DtResultado;
        }

        //Método para ocultar columnas
        private void OcultarColumnasHistoria()
        {

            this.dgv_Historia.Columns["idhistoria"].Visible = false;
            this.dgv_Historia.Columns["idpaciente"].Visible = false;
            this.dgv_Historia.Columns["estado"].Visible = false;
            this.dgv_Historia.Columns["plan_estudio"].Visible = false;
            this.dgv_Historia.Columns["plan_terapeutico"].Visible = false;

        }



        public DataTable MostrarEvolucionesAnuladas()
        {
            DataTable DtResultado = new DataTable("EvolucionesAnuladas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_evoluciones_anuladas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
                MessageBox.Show(ex.ToString());
            }
            return DtResultado;
        }

        public DataTable MostrarCitasAnuladas()
        {
            DataTable DtResultado = new DataTable("CitasAnuladas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_citas_anuladas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
                MessageBox.Show(ex.ToString());
            }
            return DtResultado;
        }

        public DataTable MostrarMedsAnulados()
        {
            DataTable DtResultado = new DataTable("MedsAnulados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_mostrar_meds_anulados";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
                MessageBox.Show(ex.ToString());
            }
            return DtResultado;
        }


        //Método para ocultar columnas
        private void OcultarColumnasCitas()
        {

            //this.dgv_Citas.Columns["idcita"].Visible = false;
            this.dgv_Citas.Columns["estado"].Visible = false;

        }


        public DataTable MostrarServiciosAnulados()
        {
            DataTable DtResultado = new DataTable("ServiciosAnulados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_servicios_anulados";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
                MessageBox.Show(ex.ToString());
            }
            return DtResultado;
        }

        //Método para ocultar columnas
        private void OcultarColumnasServicio()
        {

            this.dgv_Servicios.Columns["idservicio"].Visible = false;
            this.dgv_Servicios.Columns["estado"].Visible = false;

        }


        public DataTable MostrarEstudiosAnulados()
        {
            DataTable DtResultado = new DataTable("EstudiosAnulados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_estudios_anulados";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
                MessageBox.Show(ex.ToString());
            }
            return DtResultado;
        }


        public DataTable MostrarUsuariosAnulados()
        {
            DataTable DtResultado = new DataTable("UsuariosAnulados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_usuarios_anulados";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
                MessageBox.Show(ex.ToString());
            }
            return DtResultado;
        }

        //Método para ocultar columnas
        private void OcultarColumnasUsuarios()
        {

            this.dgv_usuarios.Columns["password"].Visible = false;
            this.dgv_usuarios.Columns["salt"].Visible = false;
            this.dgv_usuarios.Columns["estado"].Visible = false;

        }


        public DataTable MostrarMedicosAnulados()
        {
            DataTable DtResultado = new DataTable("MedicosAnulados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_medicos_anulados";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
                MessageBox.Show(ex.ToString());
            }
            return DtResultado;
        }


        public DataTable MostrarDiagnosticosAnulados()
        {
            DataTable DtResultado = new DataTable("DiagnosticosAnulados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_diagnosticos_anulados";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
                MessageBox.Show(ex.ToString());
            }
            return DtResultado;
        }

        //Método para ocultar columnas
        private void OcultarColumnasDiagnosticos()
        {

            this.dgv_Diagnosticos.Columns["iddiagnostico"].Visible = false;
            this.dgv_Diagnosticos.Columns["estado"].Visible = false;

        }

        private bool Buscar_RegistroActivoConMismaCedula(string cedula)
        {

            bool existe_coincidencia;


            int rpta = NPacientes.BuscarNum_Cedula(cedula).Rows.Count;


            if (rpta > 0 ) 
            {
                existe_coincidencia = true;

            }
            else
            {
                existe_coincidencia = false;
            }


            return existe_coincidencia;

            
        }


        private void dgv_Pacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_Pacientes.Columns["Seleccionado"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)dgv_Pacientes.Rows[e.RowIndex].Cells["Seleccionado"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Restaurar los/el registros", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                
                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Cedula;
                    string rpta = "";

                    foreach (DataGridViewRow row in dgv_Pacientes.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {

                            Codigo = Convert.ToString(row.Cells[1].Value);

                            Cedula = Convert.ToString(row.Cells["num_cedula"].Value);

                            //funcion que busque si hay un registro con la misma cedula cuyo estado sea activo


                            if  (Buscar_RegistroActivoConMismaCedula(Cedula) == false)
                            {

                                
                                rpta = NPacientes.Restaurar(Convert.ToInt32(Codigo));


                                if (rpta.Equals("OK"))
                                {
                                    MessageBox.Show("Se Restauró Correctamente El Paciente");
                                    //this.OperacionRestaurarPaciente();
                                }
                                else
                                {
                                    MessageBox.Show(rpta);
                                }


                            }
                            else 
                            {

                                MessageBox.Show("ERROR! No se puede restaurar porque ya existe un registro activo con la misma cedula!");

                            }


                        }
                    }

                    this.dgv_Pacientes.DataSource = MostrarPacientesAnulados();

                    OcultarColumnasPaciente();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void chkAnular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnular.Checked)
            {
                this.dgv_Pacientes.Columns[0].Visible = true;
                this.btnRestaurar_pac.Enabled = true;
            }
            else
            {
                this.dgv_Pacientes.Columns[0].Visible = false;
                this.btnRestaurar_pac.Enabled = false;
            }
        }

        private void btnBorrar_def_Click(object sender, EventArgs e)
        {
            //insertar codigo que haga un hard delete

            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea borrar definitivamente los pacientes seleccionados?", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {

                    frmConfirmarContraseña_BorrarRegistros frm = new frmConfirmarContraseña_BorrarRegistros(); 

                    frm.ShowDialog();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }


        }

        private void btnRestaurar_historia_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Restaurar las/la historia?", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Cedula;
                    string rpta = "";

                    foreach (DataGridViewRow row in dgv_Historia.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {

                            Codigo = Convert.ToString(row.Cells["idpaciente"].Value);

                            Cedula = Convert.ToString(row.Cells["num_cedula"].Value);

                            // TO DO: funcion que verifique si el paciente está activo y está vivo


                            rpta = NHistoria.Restaurar(Convert.ToInt32(Codigo));


                            if (rpta.Equals("OK"))
                            {
                                MessageBox.Show("Se Restauró Correctamente la historia");
                                //this.OperacionRestaurarPaciente();
                            }
                            else
                            {
                                MessageBox.Show(rpta);
                            }


                            //if (Verificar_Paciente_esta_activo(Cedula) == false)
                            //{

                                    ////aqui va el codigo de restaurar

                            //}
                            //else
                            //{

                            //    MessageBox.Show("ERROR! No se puede restaurar porque ya existe un registro activo con la misma cedula!");

                            //}


                        }
                    }

                    this.dgv_Historia.DataSource = MostrarHistoriasAnuladas();

                    OcultarColumnasPaciente();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void dgv_Historia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_Historia.Columns["Seleccionado_h"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)dgv_Historia.Rows[e.RowIndex].Cells["Seleccionado_h"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
            }
        }

        private void dgv_Evol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_Evol.Columns["Seleccionado_e"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)dgv_Evol.Rows[e.RowIndex].Cells["Seleccionado_e"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
            }
        }

        private void dgv_Citas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_Citas.Columns["Seleccionado_c"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)dgv_Citas.Rows[e.RowIndex].Cells["Seleccionado_c"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
            }
        }

        private void dgv_meds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_meds.Columns["Seleccionado_meds"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)dgv_meds.Rows[e.RowIndex].Cells["Seleccionado_meds"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
            }
        }

        private void dgv_Servicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_Servicios.Columns["Seleccionado_s"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)dgv_Servicios.Rows[e.RowIndex].Cells["Seleccionado_s"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
            }
        }

        private void dgv_Diagnosticos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_Diagnosticos.Columns["Seleccionado_d"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)dgv_Diagnosticos.Rows[e.RowIndex].Cells["Seleccionado_d"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
            }
        }

        private void dgv_Medicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_Medicos.Columns["Seleccionado_medicos"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)dgv_Medicos.Rows[e.RowIndex].Cells["Seleccionado_medicos"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
            }
        }

        private void btnRestaurar_evol_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Restaurar las/la evolucion?", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string idhistoria;
                    string rpta = "";

                    foreach (DataGridViewRow row in dgv_Evol.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {

                            Codigo = Convert.ToString(row.Cells["id"].Value);

                            idhistoria = Convert.ToString(row.Cells["idpaciente"].Value);

                            // TO DO: funcion que verifique si la historia está activa 


                            rpta = NEvolucion.Restaurar(Convert.ToInt32(Codigo));


                            if (rpta.Equals("OK"))
                            {
                                MessageBox.Show("Se Restauró Correctamente la evolucion");
                                //this.OperacionRestaurarPaciente();
                            }
                            else
                            {
                                MessageBox.Show(rpta);
                            }


                            //if (Verificar_Historia_esta_activa(idpaciente) == false)
                            //{

                            ////aqui va el codigo de restaurar

                            //}
                            //else
                            //{

                            //    MessageBox.Show("ERROR! No se puede restaurar porque la historia esta anulada!");

                            //}


                        }
                    }

                    this.dgv_Evol.DataSource = MostrarEvolucionesAnuladas();

                    //OcultarColumnasPaciente();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnRestaurar_cita_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Restaurar las/la cita?", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;

                    foreach (DataGridViewRow row in dgv_Citas.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {

                            Codigo = Convert.ToString(row.Cells["idcita"].Value);

                            // TO DO: funcion que verifique si el paciente está activo



                            // Restaurar Cita
                            string rpta2 = "";

                            SqlConnection SqlCon2 = new SqlConnection();

                            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                            SqlCon2.Open();

                            SqlCommand SqlCmd2 = new SqlCommand();
                            SqlCmd2.Connection = SqlCon2;
                            SqlCmd2.CommandText = "update Cita set estado = 'Activo' where idcita = ' " + Codigo + "  '";

                            //Ejecutamos nuestro comando

                            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";


                            //if (Verificar_paciente_esta_activo(idpaciente) == false)
                            //{

                            ////aqui va el codigo de restaurar

                            //}
                            //else
                            //{

                            //    MessageBox.Show("ERROR! No se puede restaurar porque el paciente esta anulado!");

                            //}


                        }
                    }

                    this.dgv_Citas.DataSource = MostrarCitasAnuladas();

                    //OcultarColumnas();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnRestaurar_meds_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Restaurar los/el medicamentos", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dgv_meds.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {

                            Codigo = Convert.ToString(row.Cells[1].Value);


                            rpta = NReceta.Restaurar(Convert.ToInt32(Codigo));


                            if (rpta.Equals("OK"))
                            {
                                MessageBox.Show("Se Restauró Correctamente el medicamento");
                                //this.OperacionRestaurarPaciente();
                            }
                            else
                            {
                                MessageBox.Show(rpta);
                            }


                        }
                    }

                    this.dgv_meds.DataSource = MostrarMedsAnulados();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void btnRestaurar_serv_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Restaurar los/el servicios", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dgv_Servicios.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {

                            Codigo = Convert.ToString(row.Cells[1].Value);


                            rpta = NServicio.Restaurar(Convert.ToInt32(Codigo));


                            if (rpta.Equals("OK"))
                            {
                                MessageBox.Show("Se Restauró Correctamente el servicio");
                                //this.OperacionRestaurarPaciente();
                            }
                            else
                            {
                                MessageBox.Show(rpta);
                            }


                        }
                    }

                    this.dgv_Servicios.DataSource = MostrarServiciosAnulados();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void btnRestaurar_diag_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Restaurar los/el diagnostico", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dgv_Diagnosticos.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {

                            Codigo = Convert.ToString(row.Cells[1].Value);


                            rpta = NDiagnostico.Restaurar(Convert.ToInt32(Codigo));


                            if (rpta.Equals("OK"))
                            {
                                MessageBox.Show("Se Restauró Correctamente el diagnostico");
                                //this.OperacionRestaurarPaciente();
                            }
                            else
                            {
                                MessageBox.Show(rpta);
                            }


                        }
                    }

                    this.dgv_Diagnosticos.DataSource = MostrarDiagnosticosAnulados();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void btnRestaurarMedicos_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Restaurar los/el medicos", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dgv_Medicos.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {

                            Codigo = Convert.ToString(row.Cells[1].Value);


                            rpta = NMedicosConfianza.Restaurar(Convert.ToInt32(Codigo));


                            if (rpta.Equals("OK"))
                            {
                                MessageBox.Show("Se Restauró Correctamente el medico");
                                //this.OperacionRestaurarPaciente();
                            }
                            else
                            {
                                MessageBox.Show(rpta);
                            }


                        }
                    }

                    this.dgv_Medicos.DataSource = MostrarMedicosAnulados();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
    
}
