using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NUsuario
    {

        public static string Insertar(string nombre, string cargo, string especialidad, string acceso,
           string log, string password, string estado, string salt)
        {
            DUsuario Obj = new DUsuario();
            Obj.Nombre = nombre;
            Obj.Cargo = cargo;
            Obj.Especialidad = especialidad;
            Obj.Acceso = acceso;
            Obj.Log = log;
            Obj.Password = password;
            Obj.Estado = estado;
            Obj.Salt = salt;
           

            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DTrabajador
        //de la CapaDatos
        public static string Editar(int idusuario, string nombre, string cargo, string especialidad, string acceso,
           string log, string password, string estado, string salt)
        {
            DUsuario Obj = new DUsuario();
            Obj.Idusuario = idusuario;
            Obj.Nombre = nombre;
            Obj.Cargo = cargo;
            Obj.Especialidad = especialidad;
            Obj.Acceso = acceso;
            Obj.Log = log;
            Obj.Password = password;
            Obj.Estado = estado;
            Obj.Salt = salt;
            return Obj.Editar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DTrabajador
        //de la CapaDatos
        public static string Anular(int idusuario)
        {
            DUsuario Obj = new DUsuario();
            Obj.Idusuario = idusuario;
            return Obj.Anular(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DTrabajador
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DUsuario().Mostrar();
        }

        //Método BuscarApellidos que llama al método BuscarApellidos
        //de la clase DTrabajador de la CapaDatos

       /* public static DataTable BuscarApellidos(string textobuscar)
        {
            /*DTrabajador Obj = new DTrabajador();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarApellidos(Obj);
        }*/

        //Método BuscarNum_Documento que llama al método BuscarNum_Documento
        //de la clase DTRabajador de la CapaDatos

        /*public static DataTable BuscarNum_Documento(string textobuscar)
        {
            /*DTrabajador Obj = new DTrabajador();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);
        }*/

        public static DataTable Login(string log, string password)
        {
            DUsuario Obj = new DUsuario();
            Obj.Log = log;
            Obj.Password = password;
            return Obj.Login(Obj);
        }


        public static DataTable BuscarNombre(string textobuscar)
        {
            DUsuario Obj = new DUsuario();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }


        public static DataTable BuscarCargo(string textobuscar)
        {
            DUsuario Obj = new DUsuario();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCargo(Obj);
        }

        public static DataTable BuscarAcceso(string textobuscar)
        {
            DUsuario Obj = new DUsuario();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarAcceso(Obj);
        }

        public static string EditarRespSeguridad(int idusuario, string resp1, string resp2, string resp3)
        {
            DUsuario Obj = new DUsuario();
            Obj.Idusuario = idusuario;
            Obj.Resp1 = resp1;
            Obj.Resp2 = resp2;
            Obj.Resp3 = resp3;
            return Obj.EditarRespSeguridad(Obj);
        }

    }
}
