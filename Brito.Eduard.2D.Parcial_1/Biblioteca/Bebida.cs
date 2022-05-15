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
        coctel = 1000
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

        protected override int comprarProducto 
        {
            set
            {
                this.cantidadDisponible += value * 12;
            }
        }
        public override bool reponerProducto(int cantidad)
        {
            if (this.cantidadDisponible < 100 && cantidad > 0)
            {
                comprarProducto = cantidad;
                return true;
            }
            return false;
        }
    }
}
