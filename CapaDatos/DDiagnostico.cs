using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DDiagnostico
    {

        //Variables
        private int _Iddiagnostico;




        private string _Codigo;




        private string _Enfermedad;




        private string _Tipo;

        private string _Estado;

        private string _TextoBuscar;

       

       

        public int Iddiagnostico
        {
            get { return _Iddiagnostico; }
            set { _Iddiagnostico = value; }
        }

        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }


        public string Enfermedad
        {
            get { return _Enfermedad; }
            set { _Enfermedad = value; }
        }


        public string Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
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
        public DDiagnostico()
        {

        }

        public DDiagnostico(int iddiagnostico, string codigo, string enfermedad, string tipo, string Estado, string texto_buscar)
        {
            this.Iddiagnostico = iddiagnostico;
            this.Codigo = codigo;
            this.Enfermedad = enfermedad;
            this.Tipo = tipo;
            this.Estado = Estado;
            this.TextoBuscar = texto_buscar;
           

        }



        //Métodos
        public string Insertar(DDiagnostico Diagnostico)
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
                SqlCmd.CommandText = "spinsertar_diagnostico";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddiagnostico = new SqlParameter();
                ParIddiagnostico.ParameterName = "@iddiagnostico";
                ParIddiagnostico.SqlDbType = SqlDbType.Int;
                ParIddiagnostico.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddiagnostico);


                SqlParameter ParEnfermedad = new SqlParameter();
                ParEnfermedad.ParameterName = "@enfermedad";
                ParEnfermedad.SqlDbType = SqlDbType.VarChar;
                ParEnfermedad.Size = 70;
                ParEnfermedad.Value = Diagnostico.Enfermedad;
                SqlCmd.Parameters.Add(ParEnfermedad);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 30;
                ParTipo.Value = Diagnostico.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 30;
                ParEstado.Value = Diagnostico.Estado;
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
        public string Editar(DDiagnostico Diagnostico)
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
                SqlCmd.CommandText = "speditar_diagnostico";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddiagnostico = new SqlParameter();
                ParIddiagnostico.ParameterName = "@iddiagnostico";
                ParIddiagnostico.SqlDbType = SqlDbType.Int;
                ParIddiagnostico.Value = Diagnostico.Iddiagnostico;
                SqlCmd.Parameters.Add(ParIddiagnostico);


                SqlParameter ParEnfermedad = new SqlParameter();
                ParEnfermedad.ParameterName = "@enfermedad";
                ParEnfermedad.SqlDbType = SqlDbType.VarChar;
                ParEnfermedad.Size = 70;
                ParEnfermedad.Value = Diagnostico.Enfermedad;
                SqlCmd.Parameters.Add(ParEnfermedad);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 30;
                ParTipo.Value = Diagnostico.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 30;
                ParEstado.Value = Diagnostico.Estado;
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



        /*        //Método Eliminar: razon por que se sustituyo el eliminar por anular
        public string Eliminar(DDiagnostico Diagnostico)
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
                        SqlCmd.CommandText = "speliminar_diagnostico";
                        SqlCmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter ParIddiagnostico = new SqlParameter();
                        ParIddiagnostico.ParameterName = "@iddiagnostico";
                        ParIddiagnostico.SqlDbType = SqlDbType.Int;
                        ParIddiagnostico.Value = Diagnostico.Iddiagnostico;
                        SqlCmd.Parameters.Add(ParIddiagnostico);


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
                */
        //Metodo Anular
        public string Anular(DDiagnostico Diagnostico)
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
                SqlCmd.CommandText = "spanular_diagnostico";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddiagnostico = new SqlParameter();
                ParIddiagnostico.ParameterName = "@iddiagnostico";
                ParIddiagnostico.SqlDbType = SqlDbType.Int;
                ParIddiagnostico.Value = Diagnostico.Iddiagnostico;
                SqlCmd.Parameters.Add(ParIddiagnostico);


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
            DataTable DtResultado = new DataTable("Diagnostico");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_diagnostico";
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



        //Método BuscarCodigo
        public DataTable BuscarCodigo(DDiagnostico Diagnostico)
        {
            DataTable DtResultado = new DataTable("Diagnostico");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_codigo_diagnostico";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Diagnostico.TextoBuscar;
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



        public DataTable BuscarEnfermedad(DDiagnostico Diagnostico)
        {
            DataTable DtResultado = new DataTable("Diagnostico");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_enfermedad_diagnostico";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Diagnostico.TextoBuscar;
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



        public DataTable BuscarTipo(DDiagnostico Diagnostico)
        {
            DataTable DtResultado = new DataTable("Diagnostico");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_tipo_diagnostico";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Diagnostico.TextoBuscar;
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


        //Método Restaurar
        public string Restaurar(DDiagnostico Diagnostico)
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
                SqlCmd.CommandText = "sp_restaurar_diagnostico";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Diagnostico.Iddiagnostico;
                SqlCmd.Parameters.Add(ParId);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Restauro el Registro";


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



    }
}
