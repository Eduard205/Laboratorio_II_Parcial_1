using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum EIngredientes
    {
        Carne,
        Pollo,
        Queso,
        Tomate,
        Cebolla,
        Lechuga,
        Huevo,
        Papas,
        Sal,
        Salame,
        Anchoas,
        Mozzarella,
        Jamon,
        Rucula,
        Aceitunas,
    }
    public class Comida : Producto
    {
        List<EIngredientes> ingredientes;

        public Comida(string nombre, int cantidadDisponible, float precio, List<EIngredientes> ingredientes) :
            base(nombre, cantidadDisponible, precio)
        {
            this.ingredientes = ingredientes;
        }

        /// <summary> Aumenta la cantidad disponible
        /// <param name="int value">Elemento a exponer</param>
        /// </summary>
        protected override int ComprarProducto 
        {
            set { cantidadDisponible += value; }
        }
        /// <summary>
        /// Repone el producto de tipo comida
        /// </summary>
        /// <param name="cantidad"></param>
        /// <returns>true si repuso o false si no</returns>
        public override bool ReponerProducto(int cantidad)
        {
            if (cantidad > 0)
            {
                ComprarProducto = cantidad;
                return true;
            }
            return false;
        }
    }
}
