using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

using CapaDatos;

namespace CapaNegocio
{
    public class NServicio
    {

        //Métodos para comunicarnos con la capa datos
        //Método Insertar que llama al método Insertar de la clase DPacientes
        //de la CapaDatos
        public static string Insertar(string nombre, decimal costo, string estado)
        {
            DServicio Obj = new DServicio();
            Obj.Nombre = nombre;
            Obj.Costo = costo;
            Obj.Estado = estado;


            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DPacientes
        //de la CapaDatos
        public static string Editar(int idservicio, string nombre, decimal costo, string estado)
        {
            DServicio Obj = new DServicio();
            Obj.Idservicio = idservicio;
            Obj.Nombre = nombre;
            Obj.Costo = costo;
            Obj.Estado = estado;
            return Obj.Editar(Obj);
        }


        //Método Eliminar que llama al método Eliminar de la clase DPacientes
        //de la CapaDatos
        public static string Anular(int idservicio)
        {
            DServicio Obj = new DServicio();
            Obj.Idservicio = idservicio;
            return Obj.Anular(Obj);
        }


        //Método Mostrar que llama al método Mostrar de la clase DPacientes
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DServicio().Mostrar();
        }


        public static DataTable BuscarNombre(string textobuscar)
        {
            DServicio Obj = new DServicio();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
