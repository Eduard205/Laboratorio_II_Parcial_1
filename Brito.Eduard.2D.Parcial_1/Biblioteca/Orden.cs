using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Orden
    {
        int cantidad;
        Producto producto;

        public Orden(int cantidad, Producto producto)
        {
            this.cantidad = cantidad;
            this.producto = producto;
        }

    }
}
