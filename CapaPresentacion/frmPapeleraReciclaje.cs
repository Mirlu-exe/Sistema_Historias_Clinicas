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

            this.dgv_Historia.DataSource = MostrarHistoriasAnuladas();

            this.dgv_Evol.DataSource = MostrarEvolucionesAnuladas();

            this.dgv_Citas.DataSource = MostrarCitasAnuladas();

            this.dgv_Servicios.DataSource = MostrarServiciosAnulados();

            this.dgv_Diagnosticos.DataSource = MostrarDiagnosticosAnulados();

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

    }
    
}
