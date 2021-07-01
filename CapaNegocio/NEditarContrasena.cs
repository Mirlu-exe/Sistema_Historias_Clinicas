using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaDatos
{
    public class NEditarContrasena
    {

        //Método Editar que llama al método Editar de la clase DEditarContrasena
        //de la CapaDatos
        public static string Editar(int idusuario,  string password)
        {
            DEditarContrasena Obj = new DEditarContrasena();
            Obj.Idusuario = idusuario;
            Obj.Password = password;
            return Obj.Editar(Obj);
        }
    }
}
