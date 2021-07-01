using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NOperacion
    {

        public static string Insertar(string fecha, string descripcion)
        {
            DOperacion Obj = new DOperacion();
            Obj.Fecha = fecha;
            Obj.Descripcion = descripcion;
            


            return Obj.Insertar(Obj);
        }


        //Método Mostrar que llama al método Mostrar de la clase DTrabajador
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DOperacion().Mostrar();
        }
    }
}
