using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum EPresentacionBebida
    {
        BotellaLitro = 650,
        LataGrande = 450,
        LataChica = 250,
        VasoPinta = 300,
        Coctel = 1000
    }
    public class Bebida : Producto
    {

        bool conAlcohol;
        EPresentacionBebida presentacion;

        public Bebida(string nombre, int cantidadDisponible, float precio, bool conAlcohol, EPresentacionBebida presentacion) : 
            base(nombre, cantidadDisponible, precio)
        {
            this.presentacion = presentacion;
            this.conAlcohol = conAlcohol;
        }
        /// <summary>
        /// Sobreescritura del metodo ComprarProducto heredado de la clase Producto
        /// Compra producto de tipo Comida
        /// </summary>
        protected override int ComprarProducto 
        {
            set
            {
                this.cantidadDisponible += value * 12;
            }
        }
        /// <summary>
        /// Sobreescritura del metodo ReponerProducto heredado de la clase Producto.
        /// Repone productos de tipo Comida
        /// </summary>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        public override bool ReponerProducto(int cantidad)
        {
            if (this.cantidadDisponible < 100 && cantidad > 0)
            {
                ComprarProducto = cantidad;
                return true;
            }
            return false;
        }
    }
}
