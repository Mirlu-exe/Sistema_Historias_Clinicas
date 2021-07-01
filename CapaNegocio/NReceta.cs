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
        public static string Insertar(int idpaciente, string medicamento, string presentacion, string dosis, string duracion, int cantidad)
        {
            DReceta Obj = new DReceta();
            Obj.Idpaciente = idpaciente;
            Obj.Medicamento = medicamento;
            Obj.Presentacion = presentacion;
            Obj.Dosis = dosis;
            Obj.Duracion = duracion;
            Obj.Cantidad = cantidad;


            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DPacientes
        //de la CapaDatos
        public static string Editar(int idreceta, int idpaciente, string medicamento, string presentacion, string dosis, string duracion, int cantidad)
        {
            DReceta Obj = new DReceta();
            Obj.Idreceta = idreceta;
            Obj.Idpaciente = idpaciente;
            Obj.Medicamento = medicamento;
            Obj.Presentacion = presentacion;
            Obj.Dosis = dosis;
            Obj.Duracion = duracion;
            Obj.Cantidad = cantidad;
            return Obj.Editar(Obj);
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
    }
}
