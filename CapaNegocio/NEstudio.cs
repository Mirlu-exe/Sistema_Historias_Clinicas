using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;


namespace CapaNegocio
{
    public class NEstudio
    {
        //Métodos para comunicarnos con la capa datos
        //Método Insertar que llama al método Insertar de la clase DEstudio
        //de la CapaDatos
        public static string Insertar(string nombre, string estado)
        {
            DEstudio Obj = new DEstudio();
            Obj.Nombre = nombre;
            Obj.Estado = estado;

            return Obj.Insertar(Obj);
        }

        //Método Anular que llama al método Anular de la clase DEstudioPacientes
        //de la CapaDatos
        public static string Anular(int idestudio)
        {
            DEstudio Obj = new DEstudio();
            Obj.Idestudio = idestudio;
            return Obj.Anular(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DPacientes
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DEstudio().Mostrar();
        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            DEstudio Obj = new DEstudio();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }


    }
}
