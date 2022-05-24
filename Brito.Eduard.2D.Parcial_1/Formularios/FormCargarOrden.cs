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
    public partial class FormCargarOrden : Form
    {
        int mesaNro;
        string nombreCliente;
        int cantidad;
        string tipoProducto;
        string nombreComida;
        List<string> listaIngredientes;
        string nombreBebida;
        string presentacionBebida;

        public FormCargarOrden()
        {
            InitializeComponent();
        }

        private void FormCargarOrden_Load(object sender, EventArgs e)
        {
            CBoxEPresentacionBebida.DataSource = Enum.GetValues(typeof(EPresentacionBebida));
            ListBoxIngredientes.DataSource = Enum.GetValues(typeof(EIngredientes));
            CBoxEPresentacionBebida.SelectedItem = null;
            ListBoxIngredientes.SelectedItem = null;
            CBoxNombreComida.SelectedItem = null;
            CBoxNombreBebida.SelectedItem = null;

        }

        private void ListBoxIngredientes_MouseClick(object sender, MouseEventArgs e)
        {
            ListBoxIngredientes.SelectionMode = SelectionMode.One;
        }

        private void BtnAgregarProductos_Click(object sender, EventArgs e)
        {
            int.TryParse(CBoxMesaNro.Text.Trim(), out mesaNro);
            nombreCliente = TextNombreCliente.Text.Trim();
            int.TryParse(TextCantidad.Text.Trim(), out cantidad);
            tipoProducto = CheckedListBoxProducto.Text.Trim();
            nombreComida = CBoxNombreComida.Text.Trim();
            listaIngredientes = new List<string>();
            listaIngredientes.Add(ListBoxIngredientes.Text);
            nombreBebida = CBoxNombreBebida.Text.Trim();
            presentacionBebida = CBoxEPresentacionBebida.Text.Trim();

            DataGridAgregarProductos.Rows.Add(mesaNro, nombreCliente, cantidad, tipoProducto, nombreComida, ListBoxIngredientes.Text, nombreBebida, presentacionBebida);
        }

        private void BtnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnCargarOrden_Click(object sender, EventArgs e)
        {
            if (tipoProducto == "Comida")
            {
                switch (nombreComida)
                {
                    case "Hamburguesa Especial":
                        new Mesa(mesaNro, new Cliente(mesaNro, nombreCliente, new Cuenta(new List<Producto>()
                        { new Comida(nombre: nombreComida, cantidadDisponible: 1, precio: 800, new List<EIngredientes>(){EIngredientes.Carne, EIngredientes.Lechuga, EIngredientes.Queso, EIngredientes.Tomate})})));
                        MessageBox.Show("Orden Cargada");
                        break;

                    case "Hamburguesa Simple":
                        new Mesa(mesaNro, new Cliente(mesaNro, nombreCliente, new Cuenta(new List<Producto>()
                        { new Comida(nombre: nombreComida, cantidadDisponible: 1, precio: 400, new List<EIngredientes>(){EIngredientes.Carne,EIngredientes.Queso})})));
                        MessageBox.Show("Orden Cargada");
                        break;

                    case "Picada":
                        new Mesa(mesaNro, new Cliente(mesaNro, nombreCliente, new Cuenta(new List<Producto>()
                        { new Comida(nombre: nombreComida, cantidadDisponible: 1, precio: 700, new List<EIngredientes>(){EIngredientes.Aceitunas,EIngredientes.Queso,EIngredientes.Salame,EIngredientes.Jamon})})));
                        MessageBox.Show("Orden Cargada");
                        break;

                    case "Pizza":
                        new Mesa(mesaNro, new Cliente(mesaNro, nombreCliente, new Cuenta(new List<Producto>()
                        { new Comida(nombre: nombreComida, cantidadDisponible: 1, precio: 800, new List<EIngredientes>(){EIngredientes.Aceitunas,EIngredientes.Queso,EIngredientes.Salame,EIngredientes.Jamon,EIngredientes.Mozzarella})})));
                        MessageBox.Show("Orden Cargada");
                        break;
                }   
            }
            else 
            {
                switch (nombreBebida)
                {
                    case "Coca Cola":
                        new Mesa(mesaNro, new Cliente(mesaNro, nombreCliente, new Cuenta(new List<Producto>()
                        { new Bebida(nombre: nombreBebida, cantidadDisponible: 1, precio: 100, conAlcohol: false, EPresentacionBebida.LataChica)})));
                        MessageBox.Show("Orden Cargada");
                        break;

                    case "Mojito":
                        new Mesa(mesaNro, new Cliente(mesaNro, nombreCliente, new Cuenta(new List<Producto>()
                        { new Bebida(nombre: nombreBebida, cantidadDisponible: 1, precio: 700, conAlcohol: true, EPresentacionBebida.Coctel)})));
                        MessageBox.Show("Orden Cargada");
                        break;

                    case "Quilmes":
                        new Mesa(mesaNro, new Cliente(mesaNro, nombreCliente, new Cuenta(new List<Producto>()
                        { new Bebida(nombre: nombreBebida, cantidadDisponible: 1, precio: 450, conAlcohol: true, EPresentacionBebida.BotellaLitro)})));
                        MessageBox.Show("Orden Cargada");
                        break;

                    case "IPA":
                        new Mesa(mesaNro, new Cliente(mesaNro, nombreCliente, new Cuenta(new List<Producto>()
                        { new Bebida(nombre: nombreBebida, cantidadDisponible: 1, precio: 250, conAlcohol: true, EPresentacionBebida.VasoPinta)})));
                        MessageBox.Show("Orden Cargada");
                        break;
                }
            }
        }
    }
}
