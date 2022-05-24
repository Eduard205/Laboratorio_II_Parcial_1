using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Producto
    {
        static int ultimoId;

        protected int idProducto;
        protected string nombre;
        protected int cantidadDisponible;
        private float precio;

        static Producto()
        {  
            ultimoId = 1;
        }
        protected Producto(string nombre, int cantidadDisponible, float precio)
        {
            this.idProducto = ultimoId;
            this.nombre = nombre;
            this.cantidadDisponible = cantidadDisponible;
            this.precio = precio;

            ultimoId++;
        }

        public float Precio
        {
            get { return precio; }
        }
        /// <summary>
        /// Metodo abstracto para comprar Productos que se implementa en la clase Comida y Bebida
        /// </summary>
        protected abstract int ComprarProducto
        {
            set;
        }
        /// <summary>
        /// Metodo abstracto para reponer Productos que se implementa en la clase Comida y Bebida
        /// </summary>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        public abstract bool ReponerProducto(int cantidad);
        /// <summary>
        /// Sobrecarga del operador == para comparar productos por id
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="id"></param>
        /// <returns>Retorna true si los id de los productos son iguales</returns>
        public static bool operator ==(Producto p1, int id)
        {
            return p1.idProducto == id;
        }
        /// <summary>
        /// Sobrecarga del operador !== para comparar productos por id
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="id"></param>
        /// <returns>Retorna false si los id de los productos son iguales</returns>
        public static bool operator !=(Producto p1, int id)
        {
            return !(p1 == id);
        }
        /// <summary>
        /// Busca productos por id
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="id"></param>
        /// <returns>Retorno el obejto de tipo Producto que contine el id ingresado</returns>
        public static Producto BuscarProducto(List<Producto> lista, int id)
        {
            foreach (Producto item in lista)
            {
                if (item == id) 
                { 
                    return item; 
                }
            }
            return null;
        }
    }
}
