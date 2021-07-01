using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DOperacion
    {
        //Variables
        private int _Idoperacion;






        private string _Fecha;





        private string _Descripcion;

        



        public int Idoperacion
        {
            get { return _Idoperacion; }
            set { _Idoperacion = value; }
        }

        public string Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }



           //Constructores
        public DOperacion()
        {

        }

        public DOperacion(int idoperacion, string fecha, string descripcion)
        {
            this.Idoperacion = idoperacion;
            this.Fecha = fecha;
            this.Descripcion = descripcion;
      
           

        }



        //Métodos
        public string Insertar(DOperacion Operacion)
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
                SqlCmd.CommandText = "spinsertar_operacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdoperacion = new SqlParameter();
                ParIdoperacion.ParameterName = "@idoperacion";
                ParIdoperacion.SqlDbType = SqlDbType.Int;
                ParIdoperacion.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdoperacion);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.VarChar;
                ParFecha.Size = 50;
                ParFecha.Value = Operacion.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 70;
                ParDescripcion.Value = Operacion.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                

               


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
            DataTable DtResultado = new DataTable("Operacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_operacion";
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
