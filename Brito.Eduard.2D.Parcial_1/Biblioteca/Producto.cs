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

        protected abstract int comprarProducto
        {
            set;
        }

        public abstract bool reponerProducto(int cantidad);

        public static bool operator ==(Producto p1, int id)
        {
            return p1.idProducto == id;
        }

        public static bool operator !=(Producto p1, int id)
        {
            return !(p1 == id);
        }

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
