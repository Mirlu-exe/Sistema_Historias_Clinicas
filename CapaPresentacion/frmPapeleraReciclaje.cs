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
        public frmPapeleraReciclaje()
        {
            InitializeComponent();
        }

        private void frmPapeleraReciclaje_Load(object sender, EventArgs e)
        {

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

        //Método para ocultar columnas
        private void OcultarColumnasCitas()
        {

            this.dgv_Citas.Columns["idcita"].Visible = false;
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


        private void dgv_Pacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
