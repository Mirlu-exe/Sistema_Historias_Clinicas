using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CapaDatos;


namespace CapaNegocio
{
    public class NReceta
    {

        //Métodos para comunicarnos con la capa datos
        //Método Insertar que llama al método Insertar de la clase DPacientes
        //de la CapaDatos
        public static string Insertar(string medicamento, string presentacion, string dosis)
        {
            DReceta Obj = new DReceta();
            Obj.Medicamento = medicamento;
            Obj.Presentacion = presentacion;
            Obj.Dosis = dosis;


            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DPacientes
        //de la CapaDatos
        public static string Editar(int idreceta, string medicamento, string presentacion, string dosis)
        {
            DReceta Obj = new DReceta();
            Obj.Idreceta = idreceta;
            Obj.Medicamento = medicamento;
            Obj.Presentacion = presentacion;
            Obj.Dosis = dosis;
            return Obj.Editar(Obj);
        }


        //Método Anular que llama al método Anular de la clase DPacientes
        //de la CapaDatos
        public static string Anular(int idreceta)
        {
            DReceta Obj = new DReceta();
            Obj.Idreceta = idreceta;
            return Obj.Anular(Obj);
        }



        //Método Eliminar que llama al método Eliminar de la clase DPacientes
        //de la CapaDatos
        public static string Eliminar(int idreceta)
        {
            DReceta Obj = new DReceta();
            Obj.Idreceta = idreceta;
            return Obj.Eliminar(Obj);
        }


        //Método Mostrar que llama al método Mostrar de la clase DPacientes
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DReceta().Mostrar();
        }


        //Método CargarNombreMeds que llama al método Mostrar de la clase DReceta
        //de la CapaDatos
        public static DataTable CargarNombreMeds()
        {
            return new DReceta().CargarNombreMeds();
        }


        //Método CargarPresentacionMeds que llama al método Mostrar de la clase DReceta
        //de la CapaDatos
        public static DataTable CargarPresentacionMeds(int id_med_a_buscar)
        {
            DReceta Obj = new DReceta();
            Obj.Idedicamento = id_med_a_buscar;
            return Obj.BuscarMedicamento(Obj);
        }



        public static DataTable BuscarMedicamento(string textobuscar)
        {
            DReceta Obj = new DReceta();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarMedicamento(Obj);
        }

        public static DataTable BuscarPresentacion(string textobuscar)
        {
            DReceta Obj = new DReceta();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarPresentacion(Obj);
        }

        public static DataTable BuscarDosis(string textobuscar)
        {
            DReceta Obj = new DReceta();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarDosis(Obj);
        }

        public static string Restaurar(int id_med)
        {
            DReceta Obj = new DReceta();
            Obj.Idedicamento = id_med;
            return Obj.Restaurar(Obj);
        }


        public static DataTable Buscar_PlanTerapeutico_segun_id(int id_planterapeutico)
        {
            DReceta Obj = new DReceta();
            Obj.Id_a_buscar = id_planterapeutico;
            return Obj.Buscar_PlanTerapeutico_segun_id(Obj);
        }



    }
}
