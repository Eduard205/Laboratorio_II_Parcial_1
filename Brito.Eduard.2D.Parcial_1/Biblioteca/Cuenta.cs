using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cuenta
    {
        static int ultimaCuenta;

        int idCuenta;
        List<Producto> orden;
        Dictionary<int, int> ordenes;
        bool cuentaCerrada;
        float costo;

        static Cuenta()   
        {
            ultimaCuenta = 0;
        }

        public Cuenta(List<Producto> orden) : this()
        {
            this.orden = orden;
            this.costo = CalcularCosto(orden);
        }
        public Cuenta()
        {
            cuentaCerrada = true;
            idCuenta = ultimaCuenta;
            orden = new List<Producto>();
            ordenes = new Dictionary<int, int>();

        }

        private static float CalcularCosto(List<Producto> orden)
        {
            float costo = 0;

            foreach (Producto item in orden)
            {
                costo += item.Precio;
            }
            return costo;
        }
    }
}
