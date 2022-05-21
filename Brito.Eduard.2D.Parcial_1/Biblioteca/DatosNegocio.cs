using System.Collections.Generic;

namespace Biblioteca
{
    public static class DatosNegocio
    {
        static List<Usuario> listaUsuarios;
        static List<Producto> inventario;
        static Dictionary<int, Mesa> listaMesas;

        static DatosNegocio()
        {
            InstanciarMesas();
            InstanciarProductos();
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

        public static Usuario LoguearUsuario(int idUsuario, string password)
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

        private static Dictionary<int, Mesa> InstanciarMesas()
        {
            return listaMesas = new Dictionary<int, Mesa>
            {
                {1,new Mesa() { MesaNro= 1, Cliente= new Cliente(mesaNro:1, nombre:"Carlos", new Cuenta(new List<Producto>(){
                    new Comida(nombre:"Hamburguesa Especial", cantidadDisponible:20, precio:600, new List<EIngredientes>(){
                        EIngredientes.Carne, EIngredientes.Lechuga, EIngredientes.Queso, EIngredientes.Tomate})}))}},

                {2,new Mesa() { MesaNro= 2, Cliente= new Cliente(mesaNro:2, nombre:"Maria", new Cuenta(new List<Producto>(){
                    new Comida(nombre:"Hamburguesa Simple", cantidadDisponible:50, precio:400, new List<EIngredientes>(){
                        EIngredientes.Carne, EIngredientes.Queso})}))}},

                {3,new Mesa() { MesaNro= 3, Cliente= new Cliente(mesaNro:3, nombre:"Diego", new Cuenta(new List<Producto>()))}},
                {4,new Mesa() { MesaNro= 4, Cliente= null}},
                {5,new Mesa() { MesaNro= 5, Cliente= null}},
                {6,new Mesa() { MesaNro= 6, Cliente= null}},
                {7,new Mesa() { MesaNro= 7, Cliente= null}},
                {8,new Mesa() { MesaNro= 8, Cliente= null}},
                {9,new Mesa() { MesaNro= 9, Cliente= null}},
                {10,new Mesa() { MesaNro= 10, Cliente= null}},
                {11,new Mesa() { MesaNro= 11, Cliente= null}},
                {12,new Mesa() { MesaNro= 12, Cliente= null}},
                {13,new Mesa() { MesaNro= 13, Cliente= null}},
                {14,new Mesa() { MesaNro= 14, Cliente= null}},
                {15,new Mesa() { MesaNro= 15, Cliente= null}},
                {16,new Mesa() { MesaNro= 16, Cliente= null}},
                {17,new Mesa() { MesaNro= 17, Cliente= new Cliente(mesaNro:17, nombre:"Alberto", new Cuenta(new List<Producto>()))}},
                {18,new Mesa() { MesaNro= 18, Cliente= null}},
                {19,new Mesa() { MesaNro= 19, Cliente= null}},
                {20,new Mesa() { MesaNro= 20, Cliente= new Cliente(mesaNro:20, nombre:"Micaela", new Cuenta(new List<Producto>(){
                    new Bebida(nombre:"Quilmes", cantidadDisponible:50, precio:250, conAlcohol:true, EPresentacionBebida.LataChica)}))}},

            };
        }

        private static void InstanciarProductos()
        {
            inventario = new List<Producto>()
            {
              new Bebida(nombre:"Coca Cola", cantidadDisponible:100, precio:100, conAlcohol:false, EPresentacionBebida.LataChica),
              new Bebida(nombre:"Mojito", cantidadDisponible:50, precio:700, conAlcohol:true, EPresentacionBebida.coctel),
              new Bebida(nombre:"Quilmes", cantidadDisponible:100, precio:450, conAlcohol:true, EPresentacionBebida.BotellaLitro),
              new Bebida(nombre:"IPA", cantidadDisponible:50, precio:250, conAlcohol:true, EPresentacionBebida.VasoPinta),

              new Comida(nombre:"Hamburguesa Especial", cantidadDisponible:30, precio:800, new List<EIngredientes>(){
                  EIngredientes.Carne,EIngredientes.Lechuga,EIngredientes.Queso,EIngredientes.Tomate}),
              new Comida(nombre:"Hambur Simple", cantidadDisponible:50, precio:400, new List<EIngredientes>(){
                  EIngredientes.Carne, EIngredientes.Queso}),
              new Comida(nombre:"Picada",cantidadDisponible:100, precio:700, new List<EIngredientes>(){
                  EIngredientes.Aceitunas,EIngredientes.Queso,EIngredientes.Salame,EIngredientes.Jamon})
            };

        }

        public static string MostrarDatosMesa(int idMesa)
        {
            Mesa auxMesa = null;

            foreach (KeyValuePair<int, Mesa> item in listaMesas)
            {
                if (listaMesas.ContainsKey(idMesa)== true)
                    auxMesa = listaMesas[idMesa];
            }

            if (auxMesa is null)
                return "Mesa no tiene datos";

            return auxMesa.ToString();
        }
        
    }
}
