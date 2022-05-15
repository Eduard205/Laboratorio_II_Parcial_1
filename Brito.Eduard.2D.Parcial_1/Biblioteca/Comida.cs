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
        cebolla,
        Lechuga,
        Huevo,
        Papas,
        Sal,
        Salame,
        Anchoas,
        mozzarella,
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

        protected override int comprarProducto 
        {
            set { cantidadDisponible += value; }
        }

        public override bool reponerProducto(int cantidad)
        {
            if (cantidad > 0)
            {
                comprarProducto = cantidad;
                return true;
            }
            return false;
        }
    }
}
