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




    }
}
