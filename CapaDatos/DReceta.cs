using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DReceta
    {

        //Variables
        private int _Idreceta;








        private string _Medicamento;


        private int _Idmedicamento;



        private string _Presentacion;





        private string _Dosis;



        private string _TextoBuscar;

       

        public int Idreceta
        {
            get { return _Idreceta; }
            set { _Idreceta = value; }
        }

        public string Medicamento
        {
            get { return _Medicamento; }
            set { _Medicamento = value; }
        }

        public int Idedicamento
        {
            get { return _Idmedicamento; }
            set { _Idmedicamento = value; }
        }

        public string Presentacion
        {
            get { return _Presentacion; }
            set { _Presentacion = value; }
        }


        public string Dosis
        {
            get { return _Dosis; }
            set { _Dosis = value; }
        }



        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }


            //Constructores
        public DReceta()
        {

        }

        public DReceta(int idreceta, int idpaciente, string medicamento, string presentacion, string dosis, string texto_buscar)
        {
            this.Idreceta = idreceta;
            this.Medicamento = medicamento;
            this.Presentacion = presentacion;
            this.Dosis = dosis;
            this.TextoBuscar = texto_buscar;
        
        }



        //Métodos
        public string Insertar(DReceta Receta)
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
                SqlCmd.CommandText = "spinsertar_receta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdreceta = new SqlParameter();
                ParIdreceta.ParameterName = "@idreceta";
                ParIdreceta.SqlDbType = SqlDbType.Int;
                ParIdreceta.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdreceta);


                SqlParameter ParMedicamento = new SqlParameter();
                ParMedicamento.ParameterName = "@medicamento";
                ParMedicamento.SqlDbType = SqlDbType.VarChar;
                ParMedicamento.Size = 50;
                ParMedicamento.Value = Receta.Medicamento;
                SqlCmd.Parameters.Add(ParMedicamento);

                SqlParameter ParPresentacion = new SqlParameter();
                ParPresentacion.ParameterName = "@presentacion";
                ParPresentacion.SqlDbType = SqlDbType.VarChar;
                ParPresentacion.Size = 50;
                ParPresentacion.Value = Receta.Presentacion;
                SqlCmd.Parameters.Add(ParPresentacion);

                SqlParameter ParDosis = new SqlParameter();
                ParDosis.ParameterName = "@dosis";
                ParDosis.SqlDbType = SqlDbType.VarChar;
                ParDosis.Size = 50;
                ParDosis.Value = Receta.Dosis;
                SqlCmd.Parameters.Add(ParDosis);



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
        public string Editar(DReceta Receta)
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
                SqlCmd.CommandText = "speditar_receta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdreceta = new SqlParameter();
                ParIdreceta.ParameterName = "@idreceta";
                ParIdreceta.SqlDbType = SqlDbType.Int;
                ParIdreceta.Value = Receta.Idreceta;
                SqlCmd.Parameters.Add(ParIdreceta);


                SqlParameter ParMedicamento = new SqlParameter();
                ParMedicamento.ParameterName = "@medicamento";
                ParMedicamento.SqlDbType = SqlDbType.VarChar;
                ParMedicamento.Size = 50;
                ParMedicamento.Value = Receta.Medicamento;
                SqlCmd.Parameters.Add(ParMedicamento);

                SqlParameter ParPresentacion = new SqlParameter();
                ParPresentacion.ParameterName = "@presentacion";
                ParPresentacion.SqlDbType = SqlDbType.VarChar;
                ParPresentacion.Size = 50;
                ParPresentacion.Value = Receta.Presentacion;
                SqlCmd.Parameters.Add(ParPresentacion);

                SqlParameter ParDosis = new SqlParameter();
                ParDosis.ParameterName = "@dosis";
                ParDosis.SqlDbType = SqlDbType.VarChar;
                ParDosis.Size = 50;
                ParDosis.Value = Receta.Dosis;
                SqlCmd.Parameters.Add(ParDosis);



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
        public string Anular(DReceta receta)
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
                SqlCmd.CommandText = "spanular_receta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdreceta = new SqlParameter();
                ParIdreceta.ParameterName = "@idreceta";
                ParIdreceta.SqlDbType = SqlDbType.Int;
                ParIdreceta.Value = receta.Idreceta;
                SqlCmd.Parameters.Add(ParIdreceta);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Anulo el Registro";


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



        //Método Eliminar
        public string Eliminar(DReceta Receta)
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
                SqlCmd.CommandText = "speliminar_receta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdreceta = new SqlParameter();
                ParIdreceta.ParameterName = "@idreceta";
                ParIdreceta.SqlDbType = SqlDbType.Int;
                ParIdreceta.Value = Receta.Idreceta;
                SqlCmd.Parameters.Add(ParIdreceta);


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
            DataTable DtResultado = new DataTable("Receta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_mostrar_meds";
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

        //Método Mostrar
        public DataTable CargarNombreMeds()
        {
            DataTable DtResultado = new DataTable("Receta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_mostrar_nombre_meds";
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

        //Método Mostrar
        public DataTable CargarPresentacionMeds(DReceta Receta)
        {
            DataTable DtResultado = new DataTable("Presentacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_mostrar_presentacion_meds";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParmedicamentoBuscar = new SqlParameter();
                ParmedicamentoBuscar.ParameterName = "@nombre_del_medicamento";
                ParmedicamentoBuscar.SqlDbType = SqlDbType.VarChar;
                ParmedicamentoBuscar.Size = 50;
                ParmedicamentoBuscar.Value = Receta.Idedicamento;
                SqlCmd.Parameters.Add(ParmedicamentoBuscar);


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
        public DataTable BuscarMedicamento(DReceta Receta)
        {
            DataTable DtResultado = new DataTable("Receta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sbbuscar_receta_medicamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Receta.TextoBuscar;
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




        public DataTable BuscarPresentacion(DReceta Receta)
        {
            DataTable DtResultado = new DataTable("Meds_Nombres");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sbbuscar_receta_Nomb_medicamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Receta.TextoBuscar;
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
