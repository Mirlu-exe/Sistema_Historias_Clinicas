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

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //primero hacer un datatable con todos los pacientes cuyo estado sea inactivo 


            //meter ese datatable en el dgv_Paciente

            this.dgv_Pacientes.DataSource = MostrarPacientesAnulados();


        }

        //Método Mostrar
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

    }
    
}
