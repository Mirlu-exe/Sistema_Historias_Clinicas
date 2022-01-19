using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DMedicosConfianza
    {
        //Variables
        private int _Idmedico;


        private string _Nombre;



        private string _Especialidad;


        private string _Direccion;


        private string _Telefono;


        private string _Correo;


        private string _Estado;


        private string _TextoBuscar;




        public int Idmedico
        {
            get { return _Idmedico; }
            set { _Idmedico = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Especialidad
        {
            get { return _Especialidad; }
            set { _Especialidad = value; }
        }

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }


        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }


        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
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
        public DMedicosConfianza()
        {

        }

        public DMedicosConfianza( string nombre, string especialidad,  string direccion, string telefono, string correo, string estado, int idreferencia, string texto_buscar)
        {
            this.Nombre = nombre;
            this.Especialidad = especialidad;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Correo = correo;
            this.Estado = estado;
            this.Idmedico = idreferencia;
            this.TextoBuscar = texto_buscar;


        }

        //Métodos

            //Insertar
        public string Insertar(DMedicosConfianza medicoconfianza)
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
                SqlCmd.CommandText = "spinsertar_medico";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = medicoconfianza.Nombre;
                SqlCmd.Parameters.Add(ParNombre);


                SqlParameter ParEspecialidad = new SqlParameter();
                ParEspecialidad.ParameterName = "@especialidad";
                ParEspecialidad.SqlDbType = SqlDbType.VarChar;
                ParEspecialidad.Size = 50;
                ParEspecialidad.Value = medicoconfianza.Especialidad;
                SqlCmd.Parameters.Add(ParEspecialidad);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = medicoconfianza.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 20;
                ParTelefono.Value = medicoconfianza.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 50;
                ParCorreo.Value = medicoconfianza.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 10;
                ParEstado.Value = medicoconfianza.Estado;
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





        //Método Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Medicos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_medico";
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

        //Metodo Editar
        public string Editar(DMedicosConfianza medico)
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
                SqlCmd.CommandText = "speditar_medico_Confianza";
                SqlCmd.CommandType = CommandType.StoredProcedure;

               

                SqlParameter EspecialidadMedic = new SqlParameter();
                EspecialidadMedic.ParameterName = "@especialidad";
                EspecialidadMedic.SqlDbType = SqlDbType.VarChar;
                EspecialidadMedic.Size = 50;
                EspecialidadMedic.Value = medico.Especialidad;
                SqlCmd.Parameters.Add(EspecialidadMedic);

                SqlParameter DirecionMedic = new SqlParameter();
                DirecionMedic.ParameterName = "@direccion";
                DirecionMedic.SqlDbType = SqlDbType.VarChar;
                DirecionMedic.Size = 100;
                DirecionMedic.Value = medico.Direccion;
                SqlCmd.Parameters.Add(DirecionMedic);

                SqlParameter TelefMedic = new SqlParameter();
                TelefMedic.ParameterName = "@telefono";
                TelefMedic.SqlDbType = SqlDbType.VarChar;
                TelefMedic.Size = 20;
                TelefMedic.Value = medico.Telefono;
                SqlCmd.Parameters.Add(TelefMedic);

                SqlParameter CorreoMedic = new SqlParameter();
                CorreoMedic.ParameterName = "@correo";
                CorreoMedic.SqlDbType = SqlDbType.VarChar;
                CorreoMedic.Size = 50;
                CorreoMedic.Value = medico.Correo;
                SqlCmd.Parameters.Add(CorreoMedic);

                SqlParameter EstadoMedic = new SqlParameter();
                EstadoMedic.ParameterName = "@estado";
                EstadoMedic.SqlDbType = SqlDbType.VarChar;
                EstadoMedic.Size = 10;
                EstadoMedic.Value = medico.Estado;
                SqlCmd.Parameters.Add(EstadoMedic);

                SqlParameter Id_Referencia = new SqlParameter();
                Id_Referencia.ParameterName = "@idreferencia";
                Id_Referencia.SqlDbType = SqlDbType.Int;
                Id_Referencia.Value = medico.Idmedico;
                SqlCmd.Parameters.Add(Id_Referencia);

                SqlParameter NombreMedic = new SqlParameter();
                NombreMedic.ParameterName = "@nombre";
                NombreMedic.SqlDbType = SqlDbType.VarChar;
                NombreMedic.Size = 50;
                NombreMedic.Value = medico.Nombre;
                SqlCmd.Parameters.Add(NombreMedic);


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
        public string Anular(DMedicosConfianza MedicosConfianza)
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
                SqlCmd.CommandText = "spanular_medico_confianza";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = MedicosConfianza.Nombre;
                SqlCmd.Parameters.Add(ParNombre);


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






        //Método BuscarNombre
        public DataTable BuscarNombre(DMedicosConfianza medico)
        {
            DataTable DtResultado = new DataTable("Paciente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_medico_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = medico.TextoBuscar;
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
        //Metodo BuscarEspecialidad
        public DataTable BuscarEspecialidad(DMedicosConfianza medico)
        {
            DataTable DtResultado = new DataTable("Paciente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_medico_especialidad";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = medico.TextoBuscar;
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
        public string Restaurar(DMedicosConfianza MedicosConfianza)
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
                SqlCmd.CommandText = "sp_restaurar_medico";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = MedicosConfianza.Idmedico;
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
