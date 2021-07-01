using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DPacientes
    {
        //Variables
        private int _Idpaciente;


        private string _Nombre;


        private string _Tipo_Cedula;


        private string _Num_Cedula;


        private string _Fecha_Nacimiento;


        private string _Sexo;


        private string _Estado_Civil;


        private string _Direccion;


        private string _Ocupacion;


        private string _Telefono;


        private string _Correo;


        private string _Peso;


        private string _Talla;


        private string _Estado;


        private string _TextoBuscar;

       


        public int Idpaciente
        {
            get { return _Idpaciente; }
            set { _Idpaciente = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }


        public string Tipo_Cedula
        {
            get { return _Tipo_Cedula; }
            set { _Tipo_Cedula = value; }
        }


        public string Num_Cedula
        {
            get { return _Num_Cedula; }
            set { _Num_Cedula = value; }
        }


        public string Fecha_Nacimiento
        {
            get { return _Fecha_Nacimiento; }
            set { _Fecha_Nacimiento = value; }
        }


        public string Sexo
        {
            get { return _Sexo; }
            set { _Sexo = value; }
        }

        public string Estado_Civil
        {
            get { return _Estado_Civil; }
            set { _Estado_Civil = value; }
        }


        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }


        public string Ocupacion
        {
            get { return _Ocupacion; }
            set { _Ocupacion = value; }
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


        public string Peso
        {
            get { return _Peso; }
            set { _Peso = value; }
        }

        public string Talla
        {
            get { return _Talla; }
            set { _Talla = value; }
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
        public DPacientes()
        {

        }

        public DPacientes(int idpaciente,string nombre, string tipo_cedula, string num_cedula,
            string fecha_nacimiento,string sexo,string estado_civil, string direccion,
            string ocupacion, string telefono, string correo, string peso, string talla, string estado, string texto_buscar)
        {
            this.Idpaciente = idpaciente;
            this.Nombre=nombre;
            this.Tipo_Cedula=tipo_cedula;
            this.Num_Cedula = num_cedula;
            this.Fecha_Nacimiento = fecha_nacimiento;
            this.Sexo = sexo;
            this.Estado_Civil = estado_civil;
            this.Direccion = direccion;
            this.Ocupacion = ocupacion;
            this.Telefono = telefono;
            this.Correo = correo;
            this.Peso = peso;
            this.Talla = talla;
            this.Estado = estado;
            this.TextoBuscar = texto_buscar;
           

        }


        //Métodos
        public string Insertar(DPacientes Paciente)
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
                SqlCmd.CommandText = "spinsertar_paciente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdpaciente = new SqlParameter();
                ParIdpaciente.ParameterName = "@idpaciente";
                ParIdpaciente.SqlDbType = SqlDbType.Int;
                ParIdpaciente.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdpaciente);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Paciente.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParTipoCedula = new SqlParameter();
                ParTipoCedula.ParameterName = "@tipo_cedula";
                ParTipoCedula.SqlDbType = SqlDbType.VarChar;
                ParTipoCedula.Size = 20;
                ParTipoCedula.Value = Paciente.Tipo_Cedula;
                SqlCmd.Parameters.Add(ParTipoCedula);

                SqlParameter ParNum_Cedula = new SqlParameter();
                ParNum_Cedula.ParameterName = "@num_cedula";
                ParNum_Cedula.SqlDbType = SqlDbType.VarChar;
                ParNum_Cedula.Size = 11;
                ParNum_Cedula.Value = Paciente.Num_Cedula;
                SqlCmd.Parameters.Add(ParNum_Cedula);

                SqlParameter ParFecha_Nacimiento = new SqlParameter();
                ParFecha_Nacimiento.ParameterName = "@fecha_nacimiento";
                ParFecha_Nacimiento.SqlDbType = SqlDbType.VarChar;
                ParFecha_Nacimiento.Size = 100;
                ParFecha_Nacimiento.Value = Paciente.Fecha_Nacimiento;
                SqlCmd.Parameters.Add(ParFecha_Nacimiento);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 10;
                ParSexo.Value = Paciente.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParEstado_Civil = new SqlParameter();
                ParEstado_Civil.ParameterName = "@estado_civil";
                ParEstado_Civil.SqlDbType = SqlDbType.VarChar;
                ParEstado_Civil.Size = 20;
                ParEstado_Civil.Value = Paciente.Estado_Civil;
                SqlCmd.Parameters.Add(ParEstado_Civil);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Paciente.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParOcupacion = new SqlParameter();
                ParOcupacion.ParameterName = "@ocupacion";
                ParOcupacion.SqlDbType = SqlDbType.VarChar;
                ParOcupacion.Size = 50;
                ParOcupacion.Value = Paciente.Ocupacion;
                SqlCmd.Parameters.Add(ParOcupacion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 20;
                ParTelefono.Value = Paciente.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 50;
                ParCorreo.Value = Paciente.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParPeso = new SqlParameter();
                ParPeso.ParameterName = "@peso";
                ParPeso.SqlDbType = SqlDbType.VarChar;
                ParPeso.Size = 20;
                ParPeso.Value = Paciente.Peso;
                SqlCmd.Parameters.Add(ParPeso);

                SqlParameter ParTalla = new SqlParameter();
                ParTalla.ParameterName = "@talla";
                ParTalla.SqlDbType = SqlDbType.VarChar;
                ParTalla.Size = 20;
                ParTalla.Value = Paciente.Talla;
                SqlCmd.Parameters.Add(ParTalla);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 10;
                ParEstado.Value = Paciente.Estado;
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
        public string Editar(DPacientes Paciente)
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
                SqlCmd.CommandText = "speditar_paciente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdpaciente = new SqlParameter();
                ParIdpaciente.ParameterName = "@idpaciente";
                ParIdpaciente.SqlDbType = SqlDbType.Int;
                ParIdpaciente.Value = Paciente.Idpaciente;
                SqlCmd.Parameters.Add(ParIdpaciente);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Paciente.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParTipoCedula = new SqlParameter();
                ParTipoCedula.ParameterName = "@tipo_cedula";
                ParTipoCedula.SqlDbType = SqlDbType.VarChar;
                ParTipoCedula.Size = 20;
                ParTipoCedula.Value = Paciente.Tipo_Cedula;
                SqlCmd.Parameters.Add(ParTipoCedula);

                SqlParameter ParNum_Cedula = new SqlParameter();
                ParNum_Cedula.ParameterName = "@num_cedula";
                ParNum_Cedula.SqlDbType = SqlDbType.VarChar;
                ParNum_Cedula.Size = 11;
                ParNum_Cedula.Value = Paciente.Num_Cedula;
                SqlCmd.Parameters.Add(ParNum_Cedula);

                SqlParameter ParFecha_Nacimiento = new SqlParameter();
                ParFecha_Nacimiento.ParameterName = "@fecha_nacimiento";
                ParFecha_Nacimiento.SqlDbType = SqlDbType.VarChar;
                ParFecha_Nacimiento.Size = 100;
                ParFecha_Nacimiento.Value = Paciente.Fecha_Nacimiento;
                SqlCmd.Parameters.Add(ParFecha_Nacimiento);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 10;
                ParSexo.Value = Paciente.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParEstado_Civil = new SqlParameter();
                ParEstado_Civil.ParameterName = "@estado_civil";
                ParEstado_Civil.SqlDbType = SqlDbType.VarChar;
                ParEstado_Civil.Size = 20;
                ParEstado_Civil.Value = Paciente.Estado_Civil;
                SqlCmd.Parameters.Add(ParEstado_Civil);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Paciente.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParOcupacion = new SqlParameter();
                ParOcupacion.ParameterName = "@ocupacion";
                ParOcupacion.SqlDbType = SqlDbType.VarChar;
                ParOcupacion.Size = 50;
                ParOcupacion.Value = Paciente.Ocupacion;
                SqlCmd.Parameters.Add(ParOcupacion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 20;
                ParTelefono.Value = Paciente.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 50;
                ParCorreo.Value = Paciente.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParPeso = new SqlParameter();
                ParPeso.ParameterName = "@peso";
                ParPeso.SqlDbType = SqlDbType.VarChar;
                ParPeso.Size = 20;
                ParPeso.Value = Paciente.Peso;
                SqlCmd.Parameters.Add(ParPeso);

                SqlParameter ParTalla = new SqlParameter();
                ParTalla.ParameterName = "@talla";
                ParTalla.SqlDbType = SqlDbType.VarChar;
                ParTalla.Size = 20;
                ParTalla.Value = Paciente.Talla;
                SqlCmd.Parameters.Add(ParTalla);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size =10;
                ParEstado.Value = Paciente.Estado;
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

        //Método Eliminar
        public string Eliminar(DPacientes Paciente)
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
                SqlCmd.CommandText = "speliminar_paciente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdpaciente = new SqlParameter();
                ParIdpaciente.ParameterName = "@idpaciente";
                ParIdpaciente.SqlDbType = SqlDbType.Int;
                ParIdpaciente.Value = Paciente.Idpaciente;
                SqlCmd.Parameters.Add(ParIdpaciente);


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
        public string Anular(DPacientes Paciente)
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
                SqlCmd.CommandText = "spanular_paciente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdpaciente = new SqlParameter();
                ParIdpaciente.ParameterName = "@idpaciente";
                ParIdpaciente.SqlDbType = SqlDbType.Int;
                ParIdpaciente.Value = Paciente.Idpaciente;
                SqlCmd.Parameters.Add(ParIdpaciente);


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
            DataTable DtResultado = new DataTable("Paciente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_paciente";
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



        //Método BuscarApellidos
        public DataTable BuscarNombre(DPacientes Paciente)
        {
            DataTable DtResultado = new DataTable("Paciente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_paciente_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Paciente.TextoBuscar;
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




        public DataTable BuscarNum_Documento(DPacientes Paciente)
        {
            DataTable DtResultado = new DataTable("Paciente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_paciente_num_documento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Paciente.TextoBuscar;
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


        //Método BuscarPeso
        public DataTable BuscarPeso(DPacientes Paciente)
        {
            DataTable DtResultado = new DataTable("Paciente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_paciente_peso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Paciente.TextoBuscar;
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


        //Método BuscarTalla
        public DataTable BuscarTalla(DPacientes Paciente)
        {
            DataTable DtResultado = new DataTable("Paciente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_paciente_talla";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Paciente.TextoBuscar;
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
