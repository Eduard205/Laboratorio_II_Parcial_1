using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        int idCliente;
        string nombre;
        Cuenta cuenta;

        public Cliente(int mesaNro, string nombre, Cuenta cuenta)
        {
            this.idCliente = mesaNro;
            this.nombre = nombre;
            this.cuenta = new Cuenta();
        }

        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
