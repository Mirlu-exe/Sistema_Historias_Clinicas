using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CapaDatos;

namespace CapaNegocio
{
    public class NDiagnostico
    {

        //Métodos para comunicarnos con la capa datos
        //Método Insertar que llama al método Insertar de la clase DPacientes
        //de la CapaDatos
        public static string Insertar(string codigo, string enfermedad, string tipo)
        {
            DDiagnostico Obj = new DDiagnostico();
            Obj.Codigo = codigo;
            Obj.Enfermedad = enfermedad;
            Obj.Tipo = tipo;
            

            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DPacientes
        //de la CapaDatos
        public static string Editar(int iddiagnostico, string codigo, string enfermedad, string tipo)
        {
            DDiagnostico Obj = new DDiagnostico();
            Obj.Iddiagnostico = iddiagnostico;
            Obj.Codigo = codigo;
            Obj.Enfermedad = enfermedad;
            Obj.Tipo = tipo;
            return Obj.Editar(Obj);
        }


        //Método Eliminar que llama al método Eliminar de la clase DPacientes
        //de la CapaDatos
        public static string Eliminar(int iddiagnostico)
        {
            DDiagnostico Obj = new DDiagnostico();
            Obj.Iddiagnostico = iddiagnostico;
            return Obj.Eliminar(Obj);
        }

        
        //Método Mostrar que llama al método Mostrar de la clase DPacientes
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DDiagnostico().Mostrar();
        }


        public static DataTable BuscarCodigo(string textobuscar)
        {
            DDiagnostico Obj = new DDiagnostico();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCodigo(Obj);
        }

        public static DataTable BuscarEnfermedad(string textobuscar)
        {
            DDiagnostico Obj = new DDiagnostico();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarEnfermedad(Obj);
        }


        public static DataTable BuscarTipo(string textobuscar)
        {
            DDiagnostico Obj = new DDiagnostico();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarTipo(Obj);
        }
    }
}
