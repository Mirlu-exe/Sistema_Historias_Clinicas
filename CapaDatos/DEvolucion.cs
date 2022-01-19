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



        private int _Idhistoria_a_buscar;


        public int id_evol { get; set; }

        public int id_historia { get; set; }

        public DateTime fecha_consulta { get; set; }

        public string edad_suc { get; set; }

        public string motivo_consulta { get; set; }

        public int plan_terapeutico { get; set; }

        public int plan_estudio { get; set; }

        public string observaciones { get; set; }

        public string diagnosticos { get; set; }

        public string prox_consulta { get; set; }

        public string examen_fisico { get; set; }

        public string laboratorio { get; set; }

        public string examenes_paraclinicos { get; set; }

        public string EKG { get; set; }

        public string ecocardiograma { get; set; }

        public string estado { get; set; }

        public int Idhistoria_a_buscar { get => _Idhistoria_a_buscar; set => _Idhistoria_a_buscar = value; }






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

                SqlParameter ParMotivo = new SqlParameter();
                ParMotivo.ParameterName = "@motivo_consulta";
                ParMotivo.SqlDbType = SqlDbType.VarChar;
                ParMotivo.Size = 100;
                ParMotivo.Value = Evolucion.motivo_consulta;
                SqlCmd.Parameters.Add(ParMotivo);

                SqlParameter ParDiagnosticos = new SqlParameter();
                ParDiagnosticos.ParameterName = "@diagnosticos";
                ParDiagnosticos.SqlDbType = SqlDbType.VarChar;
                ParDiagnosticos.Size = 200;
                ParDiagnosticos.Value = Evolucion.diagnosticos;
                SqlCmd.Parameters.Add(ParDiagnosticos);

                SqlParameter ParPlanEstudio = new SqlParameter();
                ParPlanEstudio.ParameterName = "@plan_estudio";
                ParPlanEstudio.SqlDbType = SqlDbType.Int;
                ParPlanEstudio.Size = 100;
                ParPlanEstudio.Value = Evolucion.plan_estudio;
                SqlCmd.Parameters.Add(ParPlanEstudio);

                SqlParameter ParPlanTera = new SqlParameter();
                ParPlanTera.ParameterName = "@plan_terapeutico";
                ParPlanTera.SqlDbType = SqlDbType.Int;
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
                ParFecha_Prox_Consulta.ParameterName = "@prox_consulta";
                ParFecha_Prox_Consulta.SqlDbType = SqlDbType.VarChar;
                ParFecha_Prox_Consulta.Size = 8;
                ParFecha_Prox_Consulta.Value = Evolucion.prox_consulta;
                SqlCmd.Parameters.Add(ParFecha_Prox_Consulta);

                SqlParameter ParExamenFisico = new SqlParameter();
                ParExamenFisico.ParameterName = "@examen_fisico";
                ParExamenFisico.SqlDbType = SqlDbType.VarChar;
                ParExamenFisico.Size = 100;
                ParExamenFisico.Value = Evolucion.examen_fisico;
                SqlCmd.Parameters.Add(ParExamenFisico);

                SqlParameter ParLab= new SqlParameter();
                ParLab.ParameterName = "@laboratorio";
                ParLab.SqlDbType = SqlDbType.VarChar;
                ParLab.Size = 200;
                ParLab.Value = Evolucion.laboratorio;
                SqlCmd.Parameters.Add(ParLab);

                SqlParameter ParParaclinicos = new SqlParameter();
                ParParaclinicos.ParameterName = "@examenes_paraclinicos";
                ParParaclinicos.SqlDbType = SqlDbType.VarChar;
                ParParaclinicos.Size = 200;
                ParParaclinicos.Value = Evolucion.examenes_paraclinicos;
                SqlCmd.Parameters.Add(ParParaclinicos);

                SqlParameter ParEKG = new SqlParameter();
                ParEKG.ParameterName = "@EKG";
                ParEKG.SqlDbType = SqlDbType.VarChar;
                ParEKG.Size = 200;
                ParEKG.Value = Evolucion.EKG;
                SqlCmd.Parameters.Add(ParEKG);

                SqlParameter ParEcocardiograma = new SqlParameter();
                ParEcocardiograma.ParameterName = "@ecocardiograma";
                ParEcocardiograma.SqlDbType = SqlDbType.VarChar;
                ParEcocardiograma.Size = 200;
                ParEcocardiograma.Value = Evolucion.ecocardiograma;
                SqlCmd.Parameters.Add(ParEcocardiograma);

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

                SqlParameter ParDiagnosticos = new SqlParameter();
                ParDiagnosticos.ParameterName = "@diagnosticos";
                ParDiagnosticos.SqlDbType = SqlDbType.VarChar;
                ParDiagnosticos.Size = 10;
                ParDiagnosticos.Value = Evolucion.diagnosticos;
                SqlCmd.Parameters.Add(ParDiagnosticos);

                SqlParameter ParPlanEstudio = new SqlParameter();
                ParPlanEstudio.ParameterName = "@plan_estudio";
                ParPlanEstudio.SqlDbType = SqlDbType.Int;
                ParPlanEstudio.Size = 10;
                ParPlanEstudio.Value = Evolucion.plan_estudio;
                SqlCmd.Parameters.Add(ParDiagnosticos);

                SqlParameter ParPlanTera = new SqlParameter();
                ParPlanTera.ParameterName = "@plan_terapeutico";
                ParPlanTera.SqlDbType = SqlDbType.Int;
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

        //Método Restaurar
        public string Restaurar(DEvolucion Evolucion)
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
                SqlCmd.CommandText = "sp_restaurar_evol";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Evolucion.id_evol;
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


        public DataTable Buscar_ultima_evolucion_segun_idhistoria(DEvolucion Evolucion)
        {
            DataTable DtResultado = new DataTable("Evolucion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_buscar_ultima_evolucion_segun_idhistoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@idhistoria";
                ParTextoBuscar.SqlDbType = SqlDbType.Int;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Evolucion.Idhistoria_a_buscar;
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
