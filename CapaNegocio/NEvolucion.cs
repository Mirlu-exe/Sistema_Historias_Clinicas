using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CapaDatos;

namespace CapaNegocio
{
    public class NEvolucion
    {

        //Método Mostrar que llama al método Mostrar de la clase DPacientes
        //de la CapaDatos
        public static DataTable MostrarEvolucion(int id_de_historia)
        {
            DEvolucion Obj = new DEvolucion();
            Obj.id_historia = id_de_historia;
            return Obj.MostrarEvolucion(Obj);
        }


        public static string Insertar(int id_de_historia, DateTime fecha_de_consulta, string edad_sucesiva, string motivo_consulta, string diagnosticos,
             int plan_de_estudio, int plan_tera, string observaciones, string proxima_consulta, string examen_fisico, string laboratorio, string examenes_paraclinicos, string EKG, string ecocardiograma, string estado)
        {
            DEvolucion Obj = new DEvolucion();
            Obj.id_historia = id_de_historia;
            Obj.fecha_consulta = fecha_de_consulta;
            Obj.edad_suc = edad_sucesiva;
            Obj.motivo_consulta = motivo_consulta;
            Obj.diagnosticos = diagnosticos;
            Obj.plan_terapeutico = plan_tera;
            Obj.plan_estudio = plan_de_estudio;
            Obj.observaciones = observaciones;
            Obj.prox_consulta = proxima_consulta;
            Obj.examen_fisico = examen_fisico;
            Obj.laboratorio = laboratorio;
            Obj.examenes_paraclinicos = examenes_paraclinicos;
            Obj.EKG = EKG;
            Obj.ecocardiograma = ecocardiograma;
            Obj.estado = estado;

            return Obj.Insertar(Obj);
        }

        public static string Editar(int id_evolucion, int id_de_historia, DateTime fecha_de_consulta, string edad_sucesiva,
          int plan_tera, int plan_de_estudio, string observaciones, string diagnosticos, string proxima_consulta, string estado)
        {
            DEvolucion Obj = new DEvolucion();
            Obj.id_evol = id_evolucion;
            Obj.id_historia = id_de_historia;
            Obj.fecha_consulta = fecha_de_consulta;
            Obj.edad_suc = edad_sucesiva;
            Obj.plan_terapeutico = plan_tera;
            Obj.plan_estudio = plan_de_estudio;
            Obj.observaciones = observaciones;
            Obj.diagnosticos = diagnosticos;
            Obj.prox_consulta = proxima_consulta;
            Obj.estado = estado;

            return Obj.Editar(Obj);
        }

    }
}
