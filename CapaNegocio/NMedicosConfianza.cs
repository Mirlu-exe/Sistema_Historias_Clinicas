using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CapaDatos;

namespace CapaNegocio
{
    public class NMedicosConfianza
    {

        //Métodos para comunicarnos con la capa datos
        //Método Insertar que llama al método Insertar de la clase DMedicosConfianza
        //de la CapaDatos
        public static string Insertar(string nombre, string especialidad, string direccion, string telefono, string correo, string estado)
        {
            DMedicosConfianza Obj = new DMedicosConfianza();
            Obj.Nombre = nombre;
            Obj.Especialidad = especialidad;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            Obj.Estado = estado;

            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DPacientes
        //de la CapaDatos
        //public static string Editar(string especialidad, string direccion, string telefono, string correo, string estado)
        //{
        //    DMedicosConfianza Obj = new DMedicosConfianza();
        //    Obj.Especialidad = especialidad;
        //    Obj.Direccion = direccion;
        //    Obj.Telefono = telefono;
        //    Obj.Correo = correo;
        //    Obj.Estado = estado;

        //    return Obj.Editar(Obj);
        //}

        //Método Eliminar que llama al método Eliminar de la clase DMedicosConfianza
        //de la CapaDatos
        //public static string Anular(int idmedico)
        //{
        //    //DMedicosConfianza Obj = new DMedicosConfianza();
        //    //Obj.Idmedico = idmedico;
        //    //return Obj.Anular(Obj);
        //}

        //Método Mostrar que llama al método Mostrar de la clase DMedicosConfianza
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DMedicosConfianza().Mostrar();
        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            DMedicosConfianza Obj = new DMedicosConfianza();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }





    }
}
