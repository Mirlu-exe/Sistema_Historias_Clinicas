using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CapaDatos;

namespace CapaNegocio
{
    public class NHistoria
    {

        ////Método Mostrar que llama al método Mostrar de la clase DHistoria
        ////de la CapaDatos
        ////public static DataTable MostrarHistoria(int id_de_paciente)
        ////{
        ////    DHistoria Obj = new DHistoria();
        ////    Obj.Id_paciente = id_de_paciente;
        ////    return Obj.MostrarHistoria(Obj);
        ////}

        public static string Insertar(int id_de_paciente, DateTime fecha_de_consulta, string motivo_consulta,
        string enfermedad_actual, string antecedentes_familiares, string antecedentes_personales, string tratamiento_actual,
        string examen_fisico, string laboratorio, string ecg, string paraclinicos, string ecocardiograma, string tipo_sangre, 
        string diagnosticos, int plan_estudio, int plan_terapeutico, string estado)
        {
            DHistoria Obj = new DHistoria();
            Obj.Id_paciente = id_de_paciente;
            Obj.Fecha_consulta = fecha_de_consulta;
            Obj.Motivo_consulta = motivo_consulta;
            Obj.Enfermedad_actual = enfermedad_actual;
            Obj.Antecedentes_familiares = antecedentes_familiares;
            Obj.Antecedentes_personales = antecedentes_personales;
            Obj.Tratamiento_actual = tratamiento_actual;
            Obj.Examen_fisico = examen_fisico;
            Obj.Laboratorio = laboratorio;
            Obj.ECG = ecg;
            Obj.Paraclinicos = paraclinicos;
            Obj.Ecocardiograma = ecocardiograma;
            Obj.Tipo_sangre = tipo_sangre;
            Obj.Diagnosticos = diagnosticos;
            Obj.Plan_estudio = plan_estudio;
            Obj.Plan_terapeutico = plan_terapeutico;
            Obj.Estado = estado;

            return Obj.Insertar(Obj);
        }

        public static string Editar(int id_historia, int id_de_paciente, DateTime fecha_de_consulta, string motivo_consulta,
        string enfermedad_actual, string antecedentes_familiares, string antecedentes_personales, string tratamiento_actual,
        string examen_fisico, string laboratorio, string ecg, string paraclinicos, string ecocardiograma, string tipo_sangre,
        string diagnosticos, int plan_estudio, int plan_terapeutico, string estado)
        {
            DHistoria Obj = new DHistoria();
            Obj.Id_historia = id_historia;
            Obj.Id_paciente = id_de_paciente;
            Obj.Fecha_consulta = fecha_de_consulta;
            Obj.Motivo_consulta = motivo_consulta;
            Obj.Enfermedad_actual = enfermedad_actual;
            Obj.Antecedentes_familiares = antecedentes_familiares;
            Obj.Antecedentes_personales = antecedentes_personales;
            Obj.Tratamiento_actual = tratamiento_actual;
            Obj.Examen_fisico = examen_fisico;
            Obj.Laboratorio = laboratorio;
            Obj.ECG = ecg;
            Obj.Paraclinicos = paraclinicos;
            Obj.Ecocardiograma = ecocardiograma;
            Obj.Tipo_sangre = tipo_sangre;
            Obj.Diagnosticos = diagnosticos;
            Obj.Plan_estudio = plan_estudio;
            Obj.Plan_terapeutico = plan_terapeutico;
            Obj.Estado = estado;

            return Obj.Editar(Obj);
        }


        public static string Restaurar(int idpaciente)
        {
            DHistoria Obj = new DHistoria();
            Obj.Id_paciente = idpaciente;
            return Obj.Restaurar(Obj);
        }

        public static DataTable Buscar_Historia_segun_idpac(int id_pac)
        {

            DHistoria Obj = new DHistoria();
            Obj.Idpac_a_buscar= id_pac;
            return Obj.Buscar_historia_segun_idpac(Obj);

        }



    }
}
