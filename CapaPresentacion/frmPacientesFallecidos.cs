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
    public partial class frmPacientesFallecidos : Form
    {
        public frmPacientesFallecidos()
        {
            InitializeComponent();
        }

        private void frmPacientesFallecidos_Load(object sender, EventArgs e)
        {
            this.dgv_all_dead.DataSource = MostrarTodosPacientesMuertos();
        }

        private void OcultarColumnas()
        {

            this.dgv_all_dead.Columns[0].Visible = false;
            this.dgv_all_dead.Columns[1].Visible = false;
            this.dgv_all_dead.Columns["estado"].Visible = false;
            this.dgv_all_dead.Columns["is_dead"].Visible = false;
            
        }
        private void SolofallecidosActivos()
        {

            (dgv_all_dead.DataSource as DataTable).DefaultView.RowFilter = string.Format("estado = 'Activo'");

        }

        private void dgv_all_dead_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_all_dead.Rows != null && dgv_all_dead.Rows.Count != 0)
            {

                tabControl1.SelectedTab = tabPage2;

                this.lbl_id.Text = Convert.ToString(this.dgv_all_dead.CurrentRow.Cells["idpaciente"].Value);

                this.lbl_cedula.Text = Convert.ToString(this.dgv_all_dead.CurrentRow.Cells["num_cedula"].Value);

                this.dtp_Death_Date.Value = Convert.ToDateTime(this.dgv_all_dead.CurrentRow.Cells["fecha_muerte"].Value);

                this.txtCausaMuerte.Text = Convert.ToString(this.dgv_all_dead.CurrentRow.Cells["causa_muerte"].Value);

                MostrarPacienteFallecido();

                this.dgv_Historia_fallecido.DataSource = MostrarHistoriaFallecido(Convert.ToInt32(this.lbl_id.Text));

                //this.dgv_Evolución_fallecido.DataSource =  MostrarEvolucionesFallecido(Convert.ToInt32(this.lbl_id.Text));




                this.Habilitar(false);
            }
            else
            {

                MessageBox.Show("ERROR!! La lista esta vacia, por favor revise bien las credenciales que desea buscar");

            }
        }

        public DataTable MostrarTodosPacientesMuertos()
        {
            DataTable DtResultado = new DataTable("TodosPacientesMuertos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_todos_pacientes_muertos";
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

        public void Buscar_paciente_fallecidos_Cedula() 
        {
            this.dgv_all_dead.DataSource = NPacientes.BuscarMuertoCedula(this.txtBuscar_fallecidos.Text);
          this.OcultarColumnas();
         //   SolofallecidosActivos();
            lblTotal.Text = "Todos los pacientes fallecidos: " + Convert.ToString(dgv_all_dead.Rows.Count);
        }

        public void Buscar_paciente_fallecidos_Nombre()
        {
            this.dgv_all_dead.DataSource = NPacientes.BuscarMuertoNombre(this.txtBuscar_fallecidos.Text);
               this.OcultarColumnas();
            //   SolofallecidosActivos();
            lblTotal.Text = "Todos los pacientes fallecidos: " + Convert.ToString(dgv_all_dead.Rows.Count);
        }

        public void MostrarPacienteFallecido()
        {
            this.dgv_Paciente_fallecido.DataSource = NPacientes.BuscarNum_Cedula(this.lbl_cedula.Text);
            this.OcultarColumnas();
        }

        public DataTable MostrarHistoriaFallecido(int id_pac)
        {
            DataTable DtResultado = new DataTable("HistoriaFallecido");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_mostrar_historia_del_pac_fallecido";
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

        //public DataTable MostrarEvolucionesFallecido(string cedula)
        //{
        //    //DataTable DtResultado = new DataTable("HistoriaFallecido");
        //    //SqlConnection SqlCon = new SqlConnection();
        //    //try
        //    //{
        //    //    SqlCon.ConnectionString = Conexion.Cn;
        //    //    SqlCommand SqlCmd = new SqlCommand();
        //    //    SqlCmd.Connection = SqlCon;
        //    //    SqlCmd.CommandText = "sp_mostrar_historia_del_pac_fallecido";
        //    //    SqlCmd.CommandType = CommandType.StoredProcedure;

        //    //    SqlParameter ParIDBuscar = new SqlParameter();
        //    //    ParIDBuscar.ParameterName = "@cedula_pac";
        //    //    ParIDBuscar.SqlDbType = SqlDbType.Int;
        //    //    ParIDBuscar.Size = 50;
        //    //    ParIDBuscar.Value = cedula;
        //    //    SqlCmd.Parameters.Add(ParIDBuscar);

        //    //    SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
        //    //    SqlDat.Fill(DtResultado);

        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show(ex.ToString());
        //    //    DtResultado = null;
        //    //}


        //    //return DtResultado;

        //}


        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtCausaMuerte.ReadOnly = !valor;
            this.dtp_Death_Date.Enabled = !valor;

        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurar_fallecido_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Restaurar los/el registros", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dgv_all_dead.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = NPacientes.RestaurarPacienteMuerto(Convert.ToInt32(Codigo));


                            if (rpta.Equals("OK"))
                            {
                                MessageBox.Show("Se Restauró Correctamente el Paciente");
                                //this.OperacionRestaurarPaciente();
                            }
                            else
                            {
                                MessageBox.Show(rpta);
                            }

                        }
                    }

                    this.dgv_all_dead.DataSource = MostrarTodosPacientesMuertos();

                    //OcultarColumnas();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }






        }

        private void btnBorrar_fallecido_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Anular los/el pacientes", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dgv_all_dead.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = NPacientes.Muerto_a_papelera(Convert.ToInt32(Codigo));

                            //MessageBox.Show("spaceonomy wish me luck");

                            if (rpta.Equals("OK"))
                            {
                                MessageBox.Show("Se Anuló Correctamente el Paciente fallecido");
                                //this.OperacionAnularPaciente();
                            }
                            else
                            {
                                MessageBox.Show(rpta);
                            }


                        }
                    }
                    this.dgv_all_dead.DataSource = MostrarTodosPacientesMuertos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtBuscar_fallecidos_TextChanged(object sender, EventArgs e)
        {
            if (this.cblBusqueda_fallecidos.Text.Equals("Nombre"))
            {

                this.Buscar_paciente_fallecidos_Nombre();
            }
            else if (this.cblBusqueda_fallecidos.Text.Equals("Cedula"))
            {
                this.Buscar_paciente_fallecidos_Cedula();
            }

        }

        private void btnBuscar_fallecidos_Click(object sender, EventArgs e)
        {
            if (this.cblBusqueda_fallecidos.Text.Equals("Nombre"))
            {

                 this.Buscar_paciente_fallecidos_Nombre();
            }
            else if (this.cblBusqueda_fallecidos.Text.Equals("Cedula"))
            {
                this.Buscar_paciente_fallecidos_Cedula();
            }

        }
    }
}
