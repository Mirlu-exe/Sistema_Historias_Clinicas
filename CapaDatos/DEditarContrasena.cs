using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public partial class DEditarContrasena
    {

        private static DEditarContrasena _instancia;

        public static DEditarContrasena GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new DEditarContrasena();
            }
            return _instancia;
        }


        //Variables
        private int _Idusuario;

        private string _Password;





        public int Idusuario
        {
            get { return _Idusuario; }
            set { _Idusuario = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }



        //Constructores
        public DEditarContrasena()
        {

        }

        public DEditarContrasena(int idusuario, string password)
        {
            this.Idusuario = idusuario;
            this.Password = password;

        }

        //Metodos

        //Método Editar
        public string Editar(DEditarContrasena EditarContrasena)
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
                SqlCmd.CommandText = "speditar_usuario_contrasena";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdusuario = new SqlParameter();
                ParIdusuario.ParameterName = "@idusuario";
                ParIdusuario.SqlDbType = SqlDbType.Int;
                ParIdusuario.Value = EditarContrasena.Idusuario;
                SqlCmd.Parameters.Add(ParIdusuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 50;
                ParPassword.Value = EditarContrasena.Password;
                SqlCmd.Parameters.Add(ParPassword);


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


    }
}
