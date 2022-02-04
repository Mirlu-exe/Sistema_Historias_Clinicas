using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DHistoria
    {

        //Variables

        private int _Id_historia;

        private int _Id_paciente;

        private DateTime _Fecha_consulta;

        private string _Motivo_consulta;

        private string _Enfermedad_actual;

        private string _Antecedentes_familiares;

        private string _Antecedentes_personales;

        private string _Tratamiento_actual;

        private string _Examen_fisico;

        private string _Laboratorio;

        private string _ECG;

        private string _Paraclinicos;

        private string _Ecocardiograma;

        private int _Plan_estudio;

        private int _Plan_terapeutico;

        private string _Estado;

        private string _Tipo_sangre;

        private string _Diagnosticos;

        private int _Idpac_a_buscar;




        //encapsulamiento

        public DateTime Fecha_consulta { get => _Fecha_consulta; set => _Fecha_consulta = value; }
        public string Motivo_consulta { get => _Motivo_consulta; set => _Motivo_consulta = value; }
        public string Enfermedad_actual { get => _Enfermedad_actual; set => _Enfermedad_actual = value; }
        public string Antecedentes_familiares { get => _Antecedentes_familiares; set => _Antecedentes_familiares = value; }
        public string Antecedentes_personales { get => _Antecedentes_personales; set => _Antecedentes_personales = value; }
        public string Tratamiento_actual { get => _Tratamiento_actual; set => _Tratamiento_actual = value; }
        public string Examen_fisico { get => _Examen_fisico; set => _Examen_fisico = value; }
        public string Laboratorio { get => _Laboratorio; set => _Laboratorio = value; }
        public string ECG { get => _ECG; set => _ECG = value; }
        public string Paraclinicos { get => _Paraclinicos; set => _Paraclinicos = value; }
        public string Ecocardiograma { get => _Ecocardiograma; set => _Ecocardiograma = value; }
        public int Plan_estudio { get => _Plan_estudio; set => _Plan_estudio = value; }
        public int Plan_terapeutico { get => _Plan_terapeutico; set => _Plan_terapeutico = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Tipo_sangre { get => _Tipo_sangre; set => _Tipo_sangre = value; }
        public string Diagnosticos { get => _Diagnosticos; set => _Diagnosticos = value; }

        public int Id_paciente { get => _Id_paciente; set => _Id_paciente = value; }
        public int Id_historia { get => _Id_historia; set => _Id_historia = value; }

        public int Idpac_a_buscar { get => _Idpac_a_buscar; set => _Idpac_a_buscar = value; }


        //Constructores
        public DHistoria()
        {

        }

        public DHistoria(int id_paciente, DateTime fecha_consulta, string motivo_consulta, 
            string enfermedad_actual, string antecedentes_familiares, string antecedentes_personales, 
            string tratamiento_actual, string examen_fisico, string laboratorio, 
            string ecg, string paraclinicos, string ecocardiograma, 
            int plan_estudio, int plan_terapeutico, string estado, 
            string tipo_sangre, string diagnosticos, int idpac_a_buscar )
        {
            this.Id_paciente = id_paciente;
            this.Fecha_consulta = fecha_consulta;
            this.Motivo_consulta = motivo_consulta;
            this.Enfermedad_actual = enfermedad_actual;
            this.Antecedentes_familiares = antecedentes_familiares;
            this.Antecedentes_personales = antecedentes_familiares;
            this.Tratamiento_actual = tratamiento_actual;
            this.Examen_fisico = examen_fisico;
            this.Laboratorio = laboratorio;
            this.ECG = ecg;
            this.Paraclinicos = paraclinicos;
            this.Ecocardiograma = ecocardiograma;
            this.Plan_estudio = plan_estudio;
            this.Plan_terapeutico = plan_terapeutico;
            this.Estado = estado;
            this.Tipo_sangre = tipo_sangre;
            this.Diagnosticos = diagnosticos;
            this.Idpac_a_buscar = idpac_a_buscar;
        }



        //Métodos

        public string Insertar(DHistoria Historia)
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
                SqlCmd.CommandText = "spinsertar_historia";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //SqlParameter ParIdhistoria= new SqlParameter();
                //ParIdhistoria.ParameterName = "@id_historia";
                //ParIdhistoria.SqlDbType = SqlDbType.Int;
                //ParIdhistoria.Direction = ParameterDirection.Output;
                //SqlCmd.Parameters.Add(ParIdhistoria);

                SqlParameter ParIdpaciente = new SqlParameter();
                ParIdpaciente.ParameterName = "@id_paciente";
                ParIdpaciente.SqlDbType = SqlDbType.Int;
                ParIdpaciente.Size = 50;
                ParIdpaciente.Value = Historia.Id_paciente;
                SqlCmd.Parameters.Add(ParIdpaciente);

                SqlParameter ParFechaconsulta = new SqlParameter();
                ParFechaconsulta.ParameterName = "@fecha_consulta";
                ParFechaconsulta.SqlDbType = SqlDbType.VarChar;
                ParFechaconsulta.Size = 100;
                ParFechaconsulta.Value = Historia.Fecha_consulta;
                SqlCmd.Parameters.Add(ParFechaconsulta);

                SqlParameter Parmotivo_consulta = new SqlParameter();
                Parmotivo_consulta.ParameterName = "@motivo_consulta";
                Parmotivo_consulta.SqlDbType = SqlDbType.VarChar;
                Parmotivo_consulta.Size = 400;
                Parmotivo_consulta.Value = Historia.Motivo_consulta;
                SqlCmd.Parameters.Add(Parmotivo_consulta);

                SqlParameter Parenfermedad_actual = new SqlParameter();
                Parenfermedad_actual.ParameterName = "@enfermedad_actual";
                Parenfermedad_actual.SqlDbType = SqlDbType.VarChar;
                Parenfermedad_actual.Size = 400;
                Parenfermedad_actual.Value = Historia.Enfermedad_actual;
                SqlCmd.Parameters.Add(Parenfermedad_actual);

                SqlParameter Parantecedentes_familiares = new SqlParameter();
                Parantecedentes_familiares.ParameterName = "@antecedentes_familiares";
                Parantecedentes_familiares.SqlDbType = SqlDbType.VarChar;
                Parantecedentes_familiares.Size = 200;
                Parantecedentes_familiares.Value = Historia.Antecedentes_familiares;
                SqlCmd.Parameters.Add(Parantecedentes_familiares);

                SqlParameter Parantecedentes_personales = new SqlParameter();
                Parantecedentes_personales.ParameterName = "@antecedentes_personales";
                Parantecedentes_personales.SqlDbType = SqlDbType.VarChar;
                Parantecedentes_personales.Size = 200;
                Parantecedentes_personales.Value = Historia.Antecedentes_familiares;
                SqlCmd.Parameters.Add(Parantecedentes_personales);


                SqlParameter Partratamiento_actual = new SqlParameter();
                Partratamiento_actual.ParameterName = "@tratamiento_actual";
                Partratamiento_actual.SqlDbType = SqlDbType.VarChar;
                Partratamiento_actual.Size = 400;
                Partratamiento_actual.Value = Historia.Tratamiento_actual;
                SqlCmd.Parameters.Add(Partratamiento_actual);

                SqlParameter Parexamen_fisico = new SqlParameter();
                Parexamen_fisico.ParameterName = "@examen_fisico";
                Parexamen_fisico.SqlDbType = SqlDbType.VarChar;
                Parexamen_fisico.Size = 200;
                Parexamen_fisico.Value = Historia.Examen_fisico;
                SqlCmd.Parameters.Add(Parexamen_fisico);

                SqlParameter Parlaboratorio = new SqlParameter();
                Parlaboratorio.ParameterName = "@laboratorio";
                Parlaboratorio.SqlDbType = SqlDbType.VarChar;
                Parlaboratorio.Size = 200;
                Parlaboratorio.Value = Historia.Laboratorio;
                SqlCmd.Parameters.Add(Parlaboratorio);

                SqlParameter Parecg = new SqlParameter();
                Parecg.ParameterName = "@ecg";
                Parecg.SqlDbType = SqlDbType.VarChar;
                Parecg.Size = 200;
                Parecg.Value = Historia.ECG;
                SqlCmd.Parameters.Add(Parecg);

                SqlParameter Parparaclinicos = new SqlParameter();
                Parparaclinicos.ParameterName = "@paraclinicos";
                Parparaclinicos.SqlDbType = SqlDbType.VarChar;
                Parparaclinicos.Size = 200;
                Parparaclinicos.Value = Historia.Paraclinicos;
                SqlCmd.Parameters.Add(Parparaclinicos);

                SqlParameter Parecocardiograma = new SqlParameter();
                Parecocardiograma.ParameterName = "@ecocardiograma";
                Parecocardiograma.SqlDbType = SqlDbType.VarChar;
                Parecocardiograma.Size = 200;
                Parecocardiograma.Value = Historia.Ecocardiograma;
                SqlCmd.Parameters.Add(Parecocardiograma);

                SqlParameter Partipo_sangre = new SqlParameter();
                Partipo_sangre.ParameterName = "@tipo_sangre";
                Partipo_sangre.SqlDbType = SqlDbType.VarChar;
                Partipo_sangre.Size = 15;
                Partipo_sangre.Value = Historia.Tipo_sangre;
                SqlCmd.Parameters.Add(Partipo_sangre);

                SqlParameter Pardiagnosticos = new SqlParameter();
                Pardiagnosticos.ParameterName = "@diagnosticos";
                Pardiagnosticos.SqlDbType = SqlDbType.VarChar;
                Pardiagnosticos.Size = 800;
                Pardiagnosticos.Value = Historia.Diagnosticos;
                SqlCmd.Parameters.Add(Pardiagnosticos);

                SqlParameter Parplan_estudio = new SqlParameter();
                Parplan_estudio.ParameterName = "@plan_estudio";
                Parplan_estudio.SqlDbType = SqlDbType.Int;
                Parplan_estudio.Value = Historia.Plan_estudio;
                SqlCmd.Parameters.Add(Parplan_estudio);

                SqlParameter Parplan_terapeutico = new SqlParameter();
                Parplan_terapeutico.ParameterName = "@plan_terapeutico";
                Parplan_terapeutico.SqlDbType = SqlDbType.Int;
                Parplan_terapeutico.Size = 50;
                Parplan_terapeutico.Value = Historia.Plan_terapeutico;
                SqlCmd.Parameters.Add(Parplan_terapeutico);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 50;
                ParEstado.Value = Historia.Estado;
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



        public string Editar(DHistoria Historia)
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
                SqlCmd.CommandText = "speditar_historia";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdhistoria = new SqlParameter();
                ParIdhistoria.ParameterName = "@id_historia";
                ParIdhistoria.SqlDbType = SqlDbType.Int;
                ParIdhistoria.Size = 50;
                ParIdhistoria.Value = Historia.Id_historia;
                SqlCmd.Parameters.Add(ParIdhistoria);

                SqlParameter ParIdpaciente = new SqlParameter();
                ParIdpaciente.ParameterName = "@id_paciente";
                ParIdpaciente.SqlDbType = SqlDbType.Int;
                ParIdpaciente.Size = 50;
                ParIdpaciente.Value = Historia.Id_paciente;
                SqlCmd.Parameters.Add(ParIdpaciente);

                SqlParameter ParFechaconsulta = new SqlParameter();
                ParFechaconsulta.ParameterName = "@fecha_consulta";
                ParFechaconsulta.SqlDbType = SqlDbType.VarChar;
                ParFechaconsulta.Size = 100;
                ParFechaconsulta.Value = Historia.Fecha_consulta;
                SqlCmd.Parameters.Add(ParFechaconsulta);

                SqlParameter Parmotivo_consulta = new SqlParameter();
                Parmotivo_consulta.ParameterName = "@motivo_consulta";
                Parmotivo_consulta.SqlDbType = SqlDbType.VarChar;
                Parmotivo_consulta.Size = 400;
                Parmotivo_consulta.Value = Historia.Motivo_consulta;
                SqlCmd.Parameters.Add(Parmotivo_consulta);

                SqlParameter Parenfermedad_actual = new SqlParameter();
                Parenfermedad_actual.ParameterName = "@enfermedad_actual";
                Parenfermedad_actual.SqlDbType = SqlDbType.VarChar;
                Parenfermedad_actual.Size = 400;
                Parenfermedad_actual.Value = Historia.Enfermedad_actual;
                SqlCmd.Parameters.Add(Parenfermedad_actual);

                SqlParameter Parantecedentes_familiares = new SqlParameter();
                Parantecedentes_familiares.ParameterName = "@antecedentes_familiares";
                Parantecedentes_familiares.SqlDbType = SqlDbType.VarChar;
                Parantecedentes_familiares.Size = 200;
                Parantecedentes_familiares.Value = Historia.Antecedentes_familiares;
                SqlCmd.Parameters.Add(Parantecedentes_familiares);

                SqlParameter Parantecedentes_personales = new SqlParameter();
                Parantecedentes_personales.ParameterName = "@antecedentes_personales";
                Parantecedentes_personales.SqlDbType = SqlDbType.VarChar;
                Parantecedentes_personales.Size = 200;
                Parantecedentes_personales.Value = Historia.Antecedentes_personales;
                SqlCmd.Parameters.Add(Parantecedentes_personales);


                SqlParameter Partratamiento_actual = new SqlParameter();
                Partratamiento_actual.ParameterName = "@tratamiento_actual";
                Partratamiento_actual.SqlDbType = SqlDbType.VarChar;
                Partratamiento_actual.Size = 400;
                Partratamiento_actual.Value = Historia.Tratamiento_actual;
                SqlCmd.Parameters.Add(Partratamiento_actual);

                SqlParameter Parexamen_fisico = new SqlParameter();
                Parexamen_fisico.ParameterName = "@examen_fisico";
                Parexamen_fisico.SqlDbType = SqlDbType.VarChar;
                Parexamen_fisico.Size = 200;
                Parexamen_fisico.Value = Historia.Examen_fisico;
                SqlCmd.Parameters.Add(Parexamen_fisico);

                SqlParameter Parlaboratorio = new SqlParameter();
                Parlaboratorio.ParameterName = "@laboratorio";
                Parlaboratorio.SqlDbType = SqlDbType.VarChar;
                Parlaboratorio.Size = 200;
                Parlaboratorio.Value = Historia.Laboratorio;
                SqlCmd.Parameters.Add(Parlaboratorio);

                SqlParameter Parecg = new SqlParameter();
                Parecg.ParameterName = "@ecg";
                Parecg.SqlDbType = SqlDbType.VarChar;
                Parecg.Size = 200;
                Parecg.Value = Historia.ECG;
                SqlCmd.Parameters.Add(Parecg);

                SqlParameter Parparaclinicos = new SqlParameter();
                Parparaclinicos.ParameterName = "@paraclinicos";
                Parparaclinicos.SqlDbType = SqlDbType.VarChar;
                Parparaclinicos.Size = 200;
                Parparaclinicos.Value = Historia.Paraclinicos;
                SqlCmd.Parameters.Add(Parparaclinicos);

                SqlParameter Parecocardiograma = new SqlParameter();
                Parecocardiograma.ParameterName = "@ecocardiograma";
                Parecocardiograma.SqlDbType = SqlDbType.VarChar;
                Parecocardiograma.Size = 200;
                Parecocardiograma.Value = Historia.Ecocardiograma;
                SqlCmd.Parameters.Add(Parecocardiograma);

                SqlParameter Partipo_sangre = new SqlParameter();
                Partipo_sangre.ParameterName = "@tipo_sangre";
                Partipo_sangre.SqlDbType = SqlDbType.VarChar;
                Partipo_sangre.Size = 15;
                Partipo_sangre.Value = Historia.Tipo_sangre;
                SqlCmd.Parameters.Add(Partipo_sangre);

                SqlParameter Pardiagnosticos = new SqlParameter();
                Pardiagnosticos.ParameterName = "@diagnosticos";
                Pardiagnosticos.SqlDbType = SqlDbType.VarChar;
                Pardiagnosticos.Size = 800;
                Pardiagnosticos.Value = Historia.Diagnosticos;
                SqlCmd.Parameters.Add(Pardiagnosticos);

                SqlParameter Parplan_estudio = new SqlParameter();
                Parplan_estudio.ParameterName = "@plan_estudio";
                Parplan_estudio.SqlDbType = SqlDbType.Int;
                Parplan_estudio.Value = Historia.Plan_estudio;
                SqlCmd.Parameters.Add(Parplan_estudio);

                SqlParameter Parplan_terapeutico = new SqlParameter();
                Parplan_terapeutico.ParameterName = "@plan_terapeutico";
                Parplan_terapeutico.SqlDbType = SqlDbType.Int;
                Parplan_terapeutico.Size = 50;
                Parplan_terapeutico.Value = Historia.Plan_terapeutico;
                SqlCmd.Parameters.Add(Parplan_terapeutico);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 50;
                ParEstado.Value = Historia.Estado;
                SqlCmd.Parameters.Add(ParEstado);





                //Ejecutamos nuestro comando


                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Edito el Registro";


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
        public string Restaurar(DHistoria Historia)
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
                SqlCmd.CommandText = "sp_restaurar_historia";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdpaciente = new SqlParameter();
                ParIdpaciente.ParameterName = "@idpaciente";
                ParIdpaciente.SqlDbType = SqlDbType.Int;
                ParIdpaciente.Value = Historia.Id_paciente;
                SqlCmd.Parameters.Add(ParIdpaciente);


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



        public DataTable Buscar_historia_segun_idpac(DHistoria Historia)
        {
            DataTable DtResultado = new DataTable("Historia");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_buscar_historia_segun_idpac";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@idpac_a_buscar";
                ParTextoBuscar.SqlDbType = SqlDbType.Int;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Historia.Idpac_a_buscar;
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
