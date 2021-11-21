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

    }
}
