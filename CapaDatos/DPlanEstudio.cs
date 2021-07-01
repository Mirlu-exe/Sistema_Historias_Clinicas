using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DPlanEstudio
    {

        //Variables
        private int _IdPlanEstudio;

        private int _IdPaciente;

        private string _ListaEstudios;


        public int IdPlanEstudio
        {
            get { return _IdPlanEstudio; }
            set { _IdPlanEstudio = value; }
        }

        public int IdPaciente
        {
            get { return _IdPaciente; }
            set { _IdPaciente = value; }
        }

        public string ListaEstudios
        {
            get { return _ListaEstudios; }
            set { _ListaEstudios = value; }
        }



        //Constructores
        public DPlanEstudio()
        {

        }

        public DPlanEstudio(int idPlanEstudio, int idpaciente, string listaEstudios)
        {
            this.IdPlanEstudio = idPlanEstudio;
            this.IdPaciente = idpaciente;
            this.ListaEstudios = listaEstudios;

        }

        //Métodos
        public string Insertar(DPlanEstudio PlanEstudio)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_planestudio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //SqlParameter ParIdplanestudio = new SqlParameter();
                //ParIdplanestudio.ParameterName = "@idplanestudio";
                //ParIdplanestudio.SqlDbType = SqlDbType.Int;
                //ParIdplanestudio.Direction = ParameterDirection.Output;
                //SqlCmd.Parameters.Add(ParIdplanestudio);

                SqlParameter ParIdPaciente = new SqlParameter();
                ParIdPaciente.ParameterName = "@idpaciente";
                ParIdPaciente.SqlDbType = SqlDbType.Int;
                ParIdPaciente.Value = PlanEstudio.IdPaciente;
                SqlCmd.Parameters.Add(ParIdPaciente);

                SqlParameter ParEstudios = new SqlParameter();
                ParEstudios.ParameterName = "@listaestudios";
                ParEstudios.SqlDbType = SqlDbType.VarChar;
                ParEstudios.Size = 100;
                ParEstudios.Value = PlanEstudio.ListaEstudios;
                SqlCmd.Parameters.Add(ParEstudios);



                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }


        //Método Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("PlanEstudio");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_planestudio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


    }
}
