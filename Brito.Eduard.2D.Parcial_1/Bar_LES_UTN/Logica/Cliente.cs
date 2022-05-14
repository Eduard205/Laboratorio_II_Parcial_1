using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_LesUTN.Logica
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
        }
    }
}
