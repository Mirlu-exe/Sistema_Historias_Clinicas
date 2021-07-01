using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CapaDatos;


namespace CapaNegocio
{
    public class NPacientes
    {

        //Métodos para comunicarnos con la capa datos
        //Método Insertar que llama al método Insertar de la clase DPacientes
        //de la CapaDatos
        public static string Insertar(string nombre, string tipo_cedula, string num_cedula,
            string fecha_nacimiento, string sexo, string estado_civil,
            string direccion, string ocupacion, string telefono, string correo, string peso,
            string talla, string estado)
        {
            DPacientes Obj = new DPacientes();
            Obj.Nombre = nombre;
            Obj.Tipo_Cedula = tipo_cedula;
            Obj.Num_Cedula = num_cedula;
            Obj.Fecha_Nacimiento = fecha_nacimiento;
            Obj.Sexo = sexo;
            Obj.Estado_Civil = estado_civil;

            Obj.Direccion = direccion;
            Obj.Ocupacion = ocupacion;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            Obj.Peso = peso;
            Obj.Talla = talla;
            Obj.Estado = estado;

            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DPacientes
        //de la CapaDatos
        public static string Editar(int idpaciente, string nombre, string tipo_cedula, string num_cedula,
            string fecha_nacimiento, string sexo, string estado_civil,
            string direccion, string ocupacion, string telefono, string correo, string peso,
            string talla, string estado)
        {
            DPacientes Obj = new DPacientes();
            Obj.Idpaciente = idpaciente;
            Obj.Nombre = nombre;
            Obj.Tipo_Cedula = tipo_cedula;
            Obj.Num_Cedula = num_cedula;
            Obj.Fecha_Nacimiento = fecha_nacimiento;
            Obj.Sexo = sexo;
            Obj.Estado_Civil = estado_civil;

            Obj.Direccion = direccion;
            Obj.Ocupacion = ocupacion;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            Obj.Peso = peso;
            Obj.Talla = talla;
            Obj.Estado = estado;
            return Obj.Editar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DPacientes
        //de la CapaDatos
        public static string Anular(int idpaciente)
        {
            DPacientes Obj = new DPacientes();
            Obj.Idpaciente = idpaciente;
            return Obj.Anular(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DPacientes
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DPacientes().Mostrar();
        }


        public static DataTable BuscarNombre(string textobuscar)
        {
            DPacientes Obj = new DPacientes();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            DPacientes Obj = new DPacientes();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);
        }

        public static DataTable BuscarPeso(string textobuscar)
        {
            DPacientes Obj = new DPacientes();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarPeso(Obj);
        }

        public static DataTable BuscarTalla(string textobuscar)
        {
            DPacientes Obj = new DPacientes();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarTalla(Obj);
        }



    }
}
