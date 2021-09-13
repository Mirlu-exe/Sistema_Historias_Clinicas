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

        public static string Insertar(int id_de_paciente, DateTime fecha_de_consulta, string razon_consulta,
        string enfermedad_actual, string antecedentes_familiares, string antecedentes_personales, string tratamiento_actual,
        string examen_fisico, string laboratorio, string ecg, string rayos_x, string ecocardiograma, string tipo_sangre, 
        string diagnosticos, int plan_estudio, int plan_terapeutico, string estado)
        {
            DHistoria Obj = new DHistoria();
            Obj.Id_paciente = id_de_paciente;
            Obj.Fecha_consulta = fecha_de_consulta;
            Obj.Razon_consulta = razon_consulta;
            Obj.Enfermedad_actual = enfermedad_actual;
            Obj.Antecedentes_familiares = antecedentes_familiares;
            Obj.Antecedentes_personales = antecedentes_personales;
            Obj.Tratamiento_actual = tratamiento_actual;
            Obj.Examen_fisico = examen_fisico;
            Obj.Laboratorio = laboratorio;
            Obj.ECG = ecg;
            Obj.Rayos_x = rayos_x;
            Obj.Ecocardiograma = ecocardiograma;
            Obj.Tipo_sangre = tipo_sangre;
            Obj.Diagnosticos = diagnosticos;
            Obj.Plan_estudio = plan_estudio;
            Obj.Plan_terapeutico = plan_terapeutico;
            Obj.Estado = estado;

            return Obj.Insertar(Obj);
        }

    }
}
