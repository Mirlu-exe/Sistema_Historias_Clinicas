using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public partial class DUsuario
    {
        //Variables
        private int _Idusuario;



        private string _Nombre;

        private string _Cargo;

       



        private string _Especialidad;



        private string _Acceso;




        private string _log;



        private string _Password;



        private string _Estado;

        private string _Salt;


        private string _Resp1, _Resp2, _Resp3;


        private string _TextoBuscar;

        

        public int Idusuario
        {
            get { return _Idusuario; }
            set { _Idusuario = value; }
        }


        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Cargo
        {
            get { return _Cargo; }
            set { _Cargo = value; }
        }

        public string Especialidad
        {
            get { return _Especialidad; }
            set { _Especialidad = value; }
        }

        public string Acceso
        {
            get { return _Acceso; }
            set { _Acceso = value; }
        }


        public string Log
        {
            get { return _log; }
            set { _log = value; }
        }


        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }


        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public string Salt
        {
            get { return _Salt; }
            set { _Salt = value; }
        }

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }



        public string Resp1
        {
            get { return _Resp1; }
            set { _Resp1 = value; }
        }
        public string Resp2
        {
            get { return _Resp2; }
            set { _Resp2 = value; }
        }
        public string Resp3
        {
            get { return _Resp3; }
            set { _Resp3 = value; }
        }






        //Constructores
        public DUsuario()
        {

        }

        public DUsuario(int idusuario,string nombre, string cargo, string especialidad, string acceso,
            string log,string password,string estado, string textobuscar, string salt)
        {
            this.Idusuario = idusuario;
            this.Nombre=nombre;
            this.Cargo = cargo;
            this.Especialidad=especialidad;
            this.Acceso = acceso;
            this.Log = log;
            this.Password = password;
            this.Estado = estado;
            this.Salt = salt;
            this.TextoBuscar = textobuscar;
            
           

        }


        //Métodos
        public string Insertar(DUsuario Usuario)
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
                SqlCmd.CommandText = "spinsertar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdusuario = new SqlParameter();
                ParIdusuario.ParameterName = "@idusuario";
                ParIdusuario.SqlDbType = SqlDbType.Int;
                ParIdusuario.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdusuario);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Usuario.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParCargo = new SqlParameter();
                ParCargo.ParameterName = "@cargo";
                ParCargo.SqlDbType = SqlDbType.VarChar;
                ParCargo.Size = 50;
                ParCargo.Value = Usuario.Cargo;
                SqlCmd.Parameters.Add(ParCargo);

                SqlParameter ParEspecialidad = new SqlParameter();
                ParEspecialidad.ParameterName = "@especialidad";
                ParEspecialidad.SqlDbType = SqlDbType.VarChar;
                ParEspecialidad.Size = 50;
                ParEspecialidad.Value = Usuario.Especialidad;
                SqlCmd.Parameters.Add(ParEspecialidad);

                SqlParameter ParAcceso = new SqlParameter();
                ParAcceso.ParameterName = "@acceso";
                ParAcceso.SqlDbType = SqlDbType.VarChar;
                ParAcceso.Size = 50;
                ParAcceso.Value = Usuario.Acceso;
                SqlCmd.Parameters.Add(ParAcceso);

                SqlParameter ParLog = new SqlParameter();
                ParLog.ParameterName = "@login";
                ParLog.SqlDbType = SqlDbType.VarChar;
                ParLog.Size = 50;
                ParLog.Value = Usuario.Log;
                SqlCmd.Parameters.Add(ParLog);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 50;
                ParPassword.Value = Usuario.Password;
                SqlCmd.Parameters.Add(ParPassword);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 50;
                ParEstado.Value = Usuario.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParSalt = new SqlParameter();
                ParSalt.ParameterName = "@salt";
                ParSalt.SqlDbType = SqlDbType.VarChar;
                ParSalt.Size = 256;
                ParSalt.Value = Usuario.Salt;
                SqlCmd.Parameters.Add(ParSalt);



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
        public string Editar(DUsuario Usuario)
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
                SqlCmd.CommandText = "speditar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdusuario = new SqlParameter();
                ParIdusuario.ParameterName = "@idusuario";
                ParIdusuario.SqlDbType = SqlDbType.Int;
                ParIdusuario.Value = Usuario.Idusuario;
                SqlCmd.Parameters.Add(ParIdusuario);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Usuario.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParCargo = new SqlParameter();
                ParCargo.ParameterName = "@cargo";
                ParCargo.SqlDbType = SqlDbType.VarChar;
                ParCargo.Size = 50;
                ParCargo.Value = Usuario.Cargo;
                SqlCmd.Parameters.Add(ParCargo);

                SqlParameter ParEspecialidad = new SqlParameter();
                ParEspecialidad.ParameterName = "@especialidad";
                ParEspecialidad.SqlDbType = SqlDbType.VarChar;
                ParEspecialidad.Size = 50;
                ParEspecialidad.Value = Usuario.Especialidad;
                SqlCmd.Parameters.Add(ParEspecialidad);

                SqlParameter ParAcceso = new SqlParameter();
                ParAcceso.ParameterName = "@acceso";
                ParAcceso.SqlDbType = SqlDbType.VarChar;
                ParAcceso.Size = 50;
                ParAcceso.Value = Usuario.Acceso;
                SqlCmd.Parameters.Add(ParAcceso);

                SqlParameter ParLog = new SqlParameter();
                ParLog.ParameterName = "@login";
                ParLog.SqlDbType = SqlDbType.VarChar;
                ParLog.Size = 50;
                ParLog.Value = Usuario.Log;
                SqlCmd.Parameters.Add(ParLog);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 50;
                ParPassword.Value = Usuario.Password;
                SqlCmd.Parameters.Add(ParPassword);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 50;
                ParEstado.Value = Usuario.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParSalt = new SqlParameter();
                ParSalt.ParameterName = "@salt";
                ParSalt.SqlDbType = SqlDbType.VarChar;
                ParSalt.Size = 256;
                ParSalt.Value = Usuario.Salt;
                SqlCmd.Parameters.Add(ParSalt);


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

        //Método Eliminar
        public string Eliminar(DUsuario Usuario)
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
                SqlCmd.CommandText = "speliminar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdusuario = new SqlParameter();
                ParIdusuario.ParameterName = "@idusuario";
                ParIdusuario.SqlDbType = SqlDbType.Int;
                ParIdusuario.Value = Usuario.Idusuario;
                SqlCmd.Parameters.Add(ParIdusuario);


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



        //Método Anular
        public string Anular(DUsuario Usuario)
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
                SqlCmd.CommandText = "spanular_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdusuario = new SqlParameter();
                ParIdusuario.ParameterName = "@idusuario";
                ParIdusuario.SqlDbType = SqlDbType.Int;
                ParIdusuario.Value = Usuario.Idusuario;
                SqlCmd.Parameters.Add(ParIdusuario);


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
            DataTable DtResultado = new DataTable("Usuario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_usuario";
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



        public DataTable Login(DUsuario Usuario)
        {
            DataTable DtResultado = new DataTable("Usuario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "splogin";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@login";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 20;
                ParUsuario.Value = Usuario.Log;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 20;
                ParPassword.Value = Usuario.Password;
                SqlCmd.Parameters.Add(ParPassword);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        public DataTable BuscarNombre(DUsuario Usuario)
        {
            DataTable DtResultado = new DataTable("Usuario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_nombre_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Usuario.TextoBuscar;
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



        public DataTable BuscarCargo(DUsuario Usuario)
        {
            DataTable DtResultado = new DataTable("Usuario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_cargo_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Usuario.TextoBuscar;
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


        public DataTable BuscarAcceso(DUsuario Usuario)
        {
            DataTable DtResultado = new DataTable("Usuario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_acceso_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Usuario.TextoBuscar;
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



        //Método EditarRespSeguridad
        public string EditarRespSeguridad(DUsuario Usuario)
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
                SqlCmd.CommandText = "speditar_usuario_respseguridad";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdusuario = new SqlParameter();
                ParIdusuario.ParameterName = "@idusuario";
                ParIdusuario.SqlDbType = SqlDbType.Int;
                ParIdusuario.Value = Usuario.Idusuario;
                SqlCmd.Parameters.Add(ParIdusuario);

                SqlParameter ParR1 = new SqlParameter();
                ParR1.ParameterName = "@r1";
                ParR1.SqlDbType = SqlDbType.VarChar;
                ParR1.Size = 50;
                ParR1.Value = Usuario.Resp1;
                SqlCmd.Parameters.Add(ParR1);

                SqlParameter ParR2 = new SqlParameter();
                ParR2.ParameterName = "@r2";
                ParR2.SqlDbType = SqlDbType.VarChar;
                ParR2.Size = 50;
                ParR2.Value = Usuario.Resp2;
                SqlCmd.Parameters.Add(ParR2);

                SqlParameter ParR3 = new SqlParameter();
                ParR3.ParameterName = "@r3";
                ParR3.SqlDbType = SqlDbType.VarChar;
                ParR3.Size = 50;
                ParR3.Value = Usuario.Resp3;
                SqlCmd.Parameters.Add(ParR3);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo las respuestas de seguridad";


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
        }//fin funcion EditarRespSeguridad








    }
}
