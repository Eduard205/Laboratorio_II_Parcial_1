using Bar_LesUTN.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_LesUTN
{
    public partial class FormMenuPrincipal : Form
    {
        Usuario usuarioLogueado;

        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        public FormMenuPrincipal(Usuario usuario) : this()
        {
            usuarioLogueado = usuario;
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
