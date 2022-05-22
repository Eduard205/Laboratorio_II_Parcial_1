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

        protected override int ComprarProducto 
        {
            set
            {
                this.cantidadDisponible += value * 12;
            }
        }

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
