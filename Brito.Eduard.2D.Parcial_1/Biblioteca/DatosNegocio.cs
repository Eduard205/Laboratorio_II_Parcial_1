using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class DatosNegocio
    {
        static List<Usuario> listaUsuarios;
        //static List<Producto> inventario;
        static List<Mesa> listaMesas;

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
        private static void InstanciarMesas()
        {
            listaMesas = new List<Mesa>()
            {
              new Mesa(1,new Cliente(1,"Juan",new Cuenta(new List<Producto>()))),
              /*
                new Mesa(2,new Cliente(2,"Margarita",
                    new Cuenta(new List<Producto>(){
                              new Comida(nombre:"Hambur Completa",cantDisp:20,precio:600,
                                        new List<EIngredientes>(){EIngredientes.CarneRoja,EIngredientes.Lechuga,EIngredientes.Queso,EIngredientes.Tomate}),

                              new Comida(nombre:"Entradadita",cantDisp:200,precio:300,
                                        new List<EIngredientes>(){ EIngredientes.Aceitunas,EIngredientes.Queso,EIngredientes.Papas,EIngredientes.Salchicha}),
                               new Bebida(nombre:"Coca Cola",cantDisp:101,precio: 350,conAlcohol: false,formato: EVersionBebida.BotellaLitro),
                                new Bebida(nombre:"Coca Cola",cantDisp:101,precio: 350,conAlcohol: false,formato: EVersionBebida.BotellaLitro)
                    }
                    ))),
              */
              new Mesa(3,null),
              new Mesa(4,null),
              new Mesa(5,null),
              new Mesa(6,null),
              new Mesa(7,null),
              new Mesa(8,null),
              new Mesa(9,null),
              new Mesa(10,null),
              new Mesa(11,null),
              new Mesa(12,null),
              new Mesa(13,null),
              new Mesa(14,null),
              new Mesa(15,null),
              new Mesa(16,null),
              new Mesa(17,null),
              new Mesa(18,null),
              new Mesa(18,null),
             // new Mesa(19,new Cliente(1,"Juan",new Cuenta(new List<Producto>(){new Bebida(nombre:"Andes",cantDisp:10,precio: 340,conAlcohol: true,formato: EVersionBebida.BotellaLitro)}))),
              new Mesa(20,null),
            };

        }
    }
}
