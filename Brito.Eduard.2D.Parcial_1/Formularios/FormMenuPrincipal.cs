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
            botones.Add(1, this.BtnMesa1);
            botones.Add(2, this.BtnMesa2);
            botones.Add(3, this.BtnMesa3);
            botones.Add(4, this.BtnMesa4);
            botones.Add(5, this.BtnMesa5);
            botones.Add(6, this.BtnMesa6);
            botones.Add(7, this.BtnMesa7);
            botones.Add(8, this.BtnMesa8);
            botones.Add(9, this.BtnMesa9);
            botones.Add(10, this.BtnMesa10);
            botones.Add(11, this.BtnMesa11);
            botones.Add(12, this.BtnMesa12);
            botones.Add(13, this.BtnMesa13);
            botones.Add(14, this.BtnMesa14);
            botones.Add(15, this.BtnMesa15);
            botones.Add(16, this.BtnBarra16);
            botones.Add(17, this.BtnBarra17);
            botones.Add(18, this.BtnBarra18);
            botones.Add(19, this.BtnBarra19);
            botones.Add(20, this.BtnBarra20);
        }

        private void DatosMesa(string datos)
        {
            MessageBox.Show(datos);
        }

        private void BtnMesa_Click(object sender, EventArgs e)
        {
            Button auxBtn = (Button)sender;

            foreach (KeyValuePair<int, Button> item in botones)
            {
                if (item.Value == auxBtn)
                {
                    DatosMesa(DatosNegocio.MostrarDatosMesa(item.Key));
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCargarOrden_Click(object sender, EventArgs e)
        {
            FormCargarOrden cargarOrden = new FormCargarOrden();
            cargarOrden.Show();

        }
    }
}
