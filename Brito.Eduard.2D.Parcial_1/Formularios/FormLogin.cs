using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

      

       

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textUsuario.Text) || string.IsNullOrEmpty(textContrasenia.Text))
            {
                MessageBox.Show("Debe ingresar un usuario y contraseña");
            }
            else
            {
                if (int.TryParse(textUsuario.Text, out int id))
                {
                    Usuario usuarioLogueado = DatosNegocio.loguearUsuario(id, textContrasenia.Text);

                    if (usuarioLogueado is not null)
                    {
                        FormMenuPrincipal menuPrincipal = new FormMenuPrincipal(usuarioLogueado);
                        menuPrincipal.Show();
                        this.Hide();
                    }
                    else
                    { 
                        MessageBox.Show("El usuario o contraseña es incorrecto"); 
                    }
                }
                else
                {
                    MessageBox.Show("Ingreso datos invalidos");
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            this.textUsuario.Text = "95123456";
            this.textContrasenia.Text = "Bar123";
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.textUsuario.Text = "35333999";
            this.textContrasenia.Text = "Caja123";
        }

       
    }
}
