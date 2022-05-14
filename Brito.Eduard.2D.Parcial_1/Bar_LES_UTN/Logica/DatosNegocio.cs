using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_LesUTN.Logica
{
    public static class DatosNegocio
    {
        static List<Usuario> listaUsuarios;
        //static List<Producto> inventario;
       // static Mesa[] mesas;

        static DatosNegocio()
        {
           // InstanciarMesas();
            //InstanciarProductos();
            InstanciarUsuarios();
        }

        private static void InstanciarUsuarios()
        {
            listaUsuarios = new List<Usuario>()
            {
                new Usuario(95123456,"Jesus Gonzalez","Bar123",ENivelAcceso.UsuarioCajero),
                new Usuario(35333999,"Florencia Perez","Caja123",ENivelAcceso.UsuarioAdmin),
            };
        }
        public static Usuario loguearUsuario(int idUsuario, string password)
        {
            foreach (Usuario item in listaUsuarios)
            {
                if (item.Dni == idUsuario && item.ComprobarPassword(password))
                {
                    return item;
                }
            }
            return null;
        }

    }
}
