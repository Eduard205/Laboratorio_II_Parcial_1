using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
   /* public enum EUbicacionMesa
    {
        Salon,
        Barra,
        Vereda
    }*/
    public class Mesa
    {
        int mesaNro;
       // EUbicacionMesa ubicacionMesa;
        Cliente cliente;

        public Mesa()
        {

        }
        public Mesa(int mesaNro, Cliente cliente):this()
        {
            this.mesaNro = mesaNro;
            this.cliente = cliente;
        }
        public Cliente Cliente 
        {
            get { return cliente; } 
            set { cliente = value; }
        }
        public int MesaNro 
        {
            get { return mesaNro; }
            set { mesaNro = value; }
        }

        public bool EsBarra
        {
            get { return mesaNro > 15; }
        }

        public override string ToString()
        {
            string tipoMesa;

            if (EsBarra is true)
            {
                tipoMesa = "Barra";
            }
            else 
            {
                tipoMesa = "Mesa";
            }

            StringBuilder datosMesa = new StringBuilder();

            datosMesa.AppendLine($"{tipoMesa} N° {this.mesaNro}");

            if (cliente is null)
            {
                datosMesa.AppendLine("Mesa disponible");
            }
            else
            {
                datosMesa.AppendLine($"Mesa ocupada. Cliente: {cliente.Nombre}");
            }
            return datosMesa.ToString();
        }

    }
}
