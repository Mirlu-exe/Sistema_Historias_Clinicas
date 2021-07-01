using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DServicio
    {

        //Variables
        private int _Idservicio;





        private string _Nombre;






        private decimal _Costo;






        private string _Estado;

        
        private string _TextoBuscar;

        


        public int Idservicio
        {
            get { return _Idservicio; }
            set { _Idservicio = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }


        public decimal Costo
        {
            get { return _Costo; }
            set { _Costo = value; }
        }

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }


        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }


          //Constructores
        public DServicio()
        {

        }

        public DServicio(int idservicio, string nombre, decimal costo, string estado, string texto_buscar)
        {
            this.Idservicio = idservicio;
            this.Nombre = nombre;
            this.Costo = costo;
            this.Estado = estado;
            this.TextoBuscar = texto_buscar;
            
           

        }



        //Métodos
        public string Insertar(DServicio Servicio)
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
                SqlCmd.CommandText = "spinsertar_servicio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdservicio = new SqlParameter();
                ParIdservicio.ParameterName = "@idservicio";
                ParIdservicio.SqlDbType = SqlDbType.Int;
                ParIdservicio.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdservicio);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Servicio.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParCosto = new SqlParameter();
                ParCosto.ParameterName = "@costo";
                ParCosto.SqlDbType = SqlDbType.Decimal;
                ParCosto.Size = 50;
                ParCosto.Value = Servicio.Costo;
                SqlCmd.Parameters.Add(ParCosto);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                
                ParEstado.Value = Servicio.Estado;
                SqlCmd.Parameters.Add(ParEstado);

               


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

        //Método Editar
        public string Editar(DServicio Servicio)
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
                SqlCmd.CommandText = "speditar_servicio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdservicio = new SqlParameter();
                ParIdservicio.ParameterName = "@idservicio";
                ParIdservicio.SqlDbType = SqlDbType.Int;
                ParIdservicio.Value = Servicio.Idservicio;
                SqlCmd.Parameters.Add(ParIdservicio);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Servicio.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParCosto = new SqlParameter();
                ParCosto.ParameterName = "@costo";
                ParCosto.SqlDbType = SqlDbType.Decimal;
                ParCosto.Size = 50;
                ParCosto.Value = Servicio.Costo;
                SqlCmd.Parameters.Add(ParCosto);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;

                ParEstado.Value = Servicio.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Registro";


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



        //Método Anular
        public string Anular(DServicio Servicio)
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
                SqlCmd.CommandText = "spanular_servicio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdservicio = new SqlParameter();
                ParIdservicio.ParameterName = "@idservicio";
                ParIdservicio.SqlDbType = SqlDbType.Int;
                ParIdservicio.Value = Servicio.Idservicio;
                SqlCmd.Parameters.Add(ParIdservicio);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";


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
            DataTable DtResultado = new DataTable("Servicio");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_servicio";
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


        //Método BuscarMedicamento
        public DataTable BuscarNombre(DServicio Servicio)
        {
            DataTable DtResultado = new DataTable("Servicio");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_nombre_servicio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Servicio.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

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
