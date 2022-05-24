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

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextUsuario.Text) || string.IsNullOrEmpty(TextContrasenia.Text))
            {
                MessageBox.Show("Debe ingresar un usuario y contraseña");
            }
            else
            {
                if (int.TryParse(TextUsuario.Text, out int id))
                {
                    Usuario usuarioLogueado = DatosNegocio.LoguearUsuario(id, TextContrasenia.Text);

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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            this.TextUsuario.Text = "95123456";
            this.TextContrasenia.Text = "Bar123";
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            this.TextUsuario.Text = "35333999";
            this.TextContrasenia.Text = "Caja123";
        }
    }
}
