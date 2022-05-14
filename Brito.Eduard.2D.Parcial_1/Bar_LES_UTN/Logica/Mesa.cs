using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_LesUTN.Logica
{
    public class Mesa
    {
        int mesaNro;
        Cliente cliente;

        public Mesa(int mesaNro, Cliente cliente)
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
