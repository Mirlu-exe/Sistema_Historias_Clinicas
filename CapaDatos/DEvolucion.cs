using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;

namespace CapaDatos
{
    public class DEvolucion
    {

        public int id_evol { get; set; }

        public int id_historia { get; set; }

        public DateTime fecha_consulta { get; set; }

        public string edad_suc { get; set; }

        public string razon_consulta { get; set; }

        public string plan_terapeutico { get; set; }

        public string plan_estudio { get; set; }

        public string observaciones { get; set; }

        public string diagnosticos { get; set; }

        public DateTime prox_consulta { get; set; }

        public string estado { get; set; }





        //Método Mostrar
        public DataTable MostrarEvolucion(DEvolucion evolucion)
        {
            DataTable DtResultado = new DataTable("Evolucion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_evolucion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Historia = new SqlParameter();
                ParId_Historia.ParameterName = "@id_historia";
                ParId_Historia.SqlDbType = SqlDbType.VarChar;
                ParId_Historia.Size = 50;
                ParId_Historia.Value = evolucion.id_historia;
                SqlCmd.Parameters.Add(ParId_Historia);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        //Métodos
        public string Insertar(DEvolucion Evolucion)
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
                SqlCmd.CommandText = "spinsertar_evolucion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //SqlParameter ParIdEvolucion = new SqlParameter();
                //ParIdEvolucion.ParameterName = "@idevolucion";
                //ParIdEvolucion.SqlDbType = SqlDbType.Int;
                //ParIdEvolucion.Direction = ParameterDirection.Output;
                //SqlCmd.Parameters.Add(ParIdEvolucion);

                SqlParameter ParIdHistoria = new SqlParameter();
                ParIdHistoria.ParameterName = "@idhistoria";
                ParIdHistoria.SqlDbType = SqlDbType.Int;
                ParIdHistoria.Size = 4;
                ParIdHistoria.Value = Evolucion.id_historia;
                SqlCmd.Parameters.Add(ParIdHistoria);

                SqlParameter ParFecha_Consulta = new SqlParameter();
                ParFecha_Consulta.ParameterName = "@fecha_consulta";
                ParFecha_Consulta.SqlDbType = SqlDbType.DateTime;
                ParFecha_Consulta.Size = 10;
                ParFecha_Consulta.Value = Evolucion.fecha_consulta;
                SqlCmd.Parameters.Add(ParFecha_Consulta);

                SqlParameter ParEdad_suc = new SqlParameter();
                ParEdad_suc.ParameterName = "@edad_suc";
                ParEdad_suc.SqlDbType = SqlDbType.VarChar;
                ParEdad_suc.Size = 10;
                ParEdad_suc.Value = Evolucion.edad_suc;
                SqlCmd.Parameters.Add(ParEdad_suc);

                SqlParameter ParRazonConsulta = new SqlParameter();
                ParRazonConsulta.ParameterName = "@razon_consulta";
                ParRazonConsulta.SqlDbType = SqlDbType.VarChar;
                ParRazonConsulta.Size = 100;
                ParRazonConsulta.Value = Evolucion.razon_consulta;
                SqlCmd.Parameters.Add(ParRazonConsulta);

                SqlParameter ParDiagnosticos = new SqlParameter();
                ParDiagnosticos.ParameterName = "@diagnosticos";
                ParDiagnosticos.SqlDbType = SqlDbType.VarChar;
                ParDiagnosticos.Size = 200;
                ParDiagnosticos.Value = Evolucion.diagnosticos;
                SqlCmd.Parameters.Add(ParDiagnosticos);

                SqlParameter ParPlanEstudio = new SqlParameter();
                ParPlanEstudio.ParameterName = "@plan_estudio";
                ParPlanEstudio.SqlDbType = SqlDbType.VarChar;
                ParPlanEstudio.Size = 100;
                ParPlanEstudio.Value = Evolucion.plan_estudio;
                SqlCmd.Parameters.Add(ParPlanEstudio);

                SqlParameter ParPlanTera = new SqlParameter();
                ParPlanTera.ParameterName = "@plan_terapeutico";
                ParPlanTera.SqlDbType = SqlDbType.VarChar;
                ParPlanTera.Size = 100;
                ParPlanTera.Value = Evolucion.plan_terapeutico;
                SqlCmd.Parameters.Add(ParPlanTera);

                SqlParameter ParObservaciones = new SqlParameter();
                ParObservaciones.ParameterName = "@observaciones";
                ParObservaciones.SqlDbType = SqlDbType.VarChar;
                ParObservaciones.Size = 300;
                ParObservaciones.Value = Evolucion.observaciones;
                SqlCmd.Parameters.Add(ParObservaciones);

                SqlParameter ParFecha_Prox_Consulta = new SqlParameter();
                ParFecha_Prox_Consulta.ParameterName = "@fecha_prox_consulta";
                ParFecha_Prox_Consulta.SqlDbType = SqlDbType.VarChar;
                ParFecha_Prox_Consulta.Size = 8;
                ParFecha_Prox_Consulta.Value = Evolucion.fecha_consulta;
                SqlCmd.Parameters.Add(ParFecha_Prox_Consulta);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 10;
                ParEstado.Value = Evolucion.estado;
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
        public string Editar(DEvolucion Evolucion)
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
                SqlCmd.CommandText = "speditar_evolucion";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParIdEvolucion = new SqlParameter();
                ParIdEvolucion.ParameterName = "@idevolucion";
                ParIdEvolucion.SqlDbType = SqlDbType.Int;
                ParIdEvolucion.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdEvolucion);

                SqlParameter ParIdHistoria = new SqlParameter();
                ParIdHistoria.ParameterName = "@idhistoria";
                ParIdHistoria.SqlDbType = SqlDbType.Int;
                ParIdHistoria.Size = 50;
                ParIdHistoria.Value = Evolucion.id_historia;
                SqlCmd.Parameters.Add(ParIdHistoria);

                SqlParameter ParFecha_Consulta = new SqlParameter();
                ParFecha_Consulta.ParameterName = "@fecha_consulta";
                ParFecha_Consulta.SqlDbType = SqlDbType.VarChar;
                ParFecha_Consulta.Size = 100;
                ParFecha_Consulta.Value = Evolucion.fecha_consulta;
                SqlCmd.Parameters.Add(ParFecha_Consulta);

                SqlParameter ParEdad_suc = new SqlParameter();
                ParEdad_suc.ParameterName = "@edad_suc";
                ParEdad_suc.SqlDbType = SqlDbType.VarChar;
                ParEdad_suc.Size = 11;
                ParEdad_suc.Value = Evolucion.edad_suc;
                SqlCmd.Parameters.Add(ParEdad_suc);

                SqlParameter ParRazonConsulta = new SqlParameter();
                ParRazonConsulta.ParameterName = "@razon_consulta";
                ParRazonConsulta.SqlDbType = SqlDbType.VarChar;
                ParRazonConsulta.Size = 100;
                ParRazonConsulta.Value = Evolucion.edad_suc;
                SqlCmd.Parameters.Add(ParRazonConsulta);

                SqlParameter ParDiagnosticos = new SqlParameter();
                ParDiagnosticos.ParameterName = "@diagnosticos";
                ParDiagnosticos.SqlDbType = SqlDbType.VarChar;
                ParDiagnosticos.Size = 10;
                ParDiagnosticos.Value = Evolucion.diagnosticos;
                SqlCmd.Parameters.Add(ParDiagnosticos);

                SqlParameter ParPlanEstudio = new SqlParameter();
                ParPlanEstudio.ParameterName = "@plan_estudio";
                ParPlanEstudio.SqlDbType = SqlDbType.VarChar;
                ParPlanEstudio.Size = 10;
                ParPlanEstudio.Value = Evolucion.plan_estudio;
                SqlCmd.Parameters.Add(ParDiagnosticos);

                SqlParameter ParPlanTera = new SqlParameter();
                ParPlanTera.ParameterName = "@plan_terapeutico";
                ParPlanTera.SqlDbType = SqlDbType.VarChar;
                ParPlanTera.Size = 10;
                ParPlanTera.Value = Evolucion.plan_terapeutico;
                SqlCmd.Parameters.Add(ParDiagnosticos);

                SqlParameter ParObservaciones = new SqlParameter();
                ParObservaciones.ParameterName = "@observaciones";
                ParObservaciones.SqlDbType = SqlDbType.VarChar;
                ParObservaciones.Size = 10;
                ParObservaciones.Value = Evolucion.observaciones;
                SqlCmd.Parameters.Add(ParObservaciones);

                SqlParameter ParFecha_Prox_Consulta = new SqlParameter();
                ParFecha_Prox_Consulta.ParameterName = "@fecha_prox_consulta";
                ParFecha_Prox_Consulta.SqlDbType = SqlDbType.VarChar;
                ParFecha_Prox_Consulta.Size = 100;
                ParFecha_Prox_Consulta.Value = Evolucion.fecha_consulta;
                SqlCmd.Parameters.Add(ParFecha_Prox_Consulta);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 10;
                ParEstado.Value = Evolucion.estado;
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




    }
}
