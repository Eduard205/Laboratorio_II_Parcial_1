using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Mesa
    {
        int mesaNro;
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
       /// <summary>
       /// Propiedad que retorna true si la mesa esta en la Barra
       /// </summary>
        public bool EsBarra
        {
            get { return mesaNro > 15; }
        }
        /// <summary>
        /// Sobreescritura de ToString para mostrar si la mesa esta disponible
        /// </summary>
        /// <returns>Retorna un string con los datos de la mesa</returns>
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
