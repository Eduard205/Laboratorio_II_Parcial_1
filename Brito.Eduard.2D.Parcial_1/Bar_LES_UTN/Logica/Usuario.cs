using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_LesUTN.Logica
{

    public enum ENivelAcceso
    {
        UsuarioCajero,
        UsuarioAdmin
    }
    public class Usuario
    {
        int idUsuario;
        string nombre;
        string password;
        ENivelAcceso nivelAcceso;

        public Usuario(int idUsuario, string nombre, string password, ENivelAcceso nivelAcceso)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.password = password;
            this.nivelAcceso = nivelAcceso;
        }
        public int Dni 
        {
            get { return idUsuario; } 
        }
        public string Nombre 
        { 
            get { return nombre; }
        }
        public ENivelAcceso NivelAcceso 
        { 
            get { return nivelAcceso; } 
        }
        public bool ComprobarPassword(string datoIngresado)
        {
            return (!string.IsNullOrEmpty(datoIngresado) && datoIngresado.Trim() == password.Trim());
        }


    }
}
