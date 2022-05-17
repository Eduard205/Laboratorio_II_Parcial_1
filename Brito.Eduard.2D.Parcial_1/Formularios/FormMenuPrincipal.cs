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
    public partial class FormMenuPrincipal : Form
    {  
        Usuario usuarioLogueado;
        Dictionary<int, Button> botones;

        public FormMenuPrincipal()
        {
            InitializeComponent();
            botones = new Dictionary<int, Button>();
            CargarMesas();
        }

        public FormMenuPrincipal(Usuario usuario) : this()
        {
            usuarioLogueado = usuario;
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {      
        }

        private void CargarMesas()
        {
            botones.Add(1, this.btnMesa1);
            botones.Add(2, this.btnMesa2);
            botones.Add(3, this.btnMesa3);
            botones.Add(4, this.btnMesa4);
            botones.Add(5, this.btnMesa5);
            botones.Add(6, this.btnMesa6);
            botones.Add(7, this.btnMesa7);
            botones.Add(8, this.btnMesa8);
            botones.Add(9, this.btnMesa9);
            botones.Add(10, this.btnMesa10);
            botones.Add(11, this.btnMesa11);
            botones.Add(12, this.btnMesa12);
            botones.Add(13, this.btnMesa13);
            botones.Add(14, this.btnMesa14);
            botones.Add(15, this.btnMesa15);
            botones.Add(16, this.btnBarra16);
            botones.Add(17, this.btnBarra17);
            botones.Add(18, this.btnBarra18);
            botones.Add(19, this.btnBarra19);
            botones.Add(20, this.btnBarra20);
        }

        private void datosMesa(string datos)
        {
            MessageBox.Show(datos);
        }

        private void btn_mesa_Click(object sender, EventArgs e)
        {
            Button auxBtn = (Button)sender;

            foreach (KeyValuePair<int, Button> item in botones)
            {
                if (item.Value == auxBtn)
                {
                    datosMesa(DatosNegocio.MostrarDatosMesa(item.Key));
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
