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
        public FormCargarOrden()
        {
            InitializeComponent();
            
        }

        private void FormCargarOrden_Load(object sender, EventArgs e)
        {
            CBoxEPresentacionBebida.DataSource = Enum.GetValues(typeof(EPresentacionBebida));
            ListBoxIngredientes.DataSource = Enum.GetValues(typeof(EIngredientes));

        }

     

        private void CBoxEPresentacionBebida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBoxIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ListBoxIngredientes_MouseClick(object sender, MouseEventArgs e)
        {
            ListBoxIngredientes.SelectionMode = SelectionMode.One;
        }


        private void CheckedListBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregarProductos_Click(object sender, EventArgs e)
        {
            int mesaNro;
            string nombreCliente;
            int cantidad;
            string tipoProducto;
            string nombreComida;
            List<string> listaIngredientes;
            string nombreBebida;
            string presentacionBebida;


            int.TryParse(CBoxMesaNro.Text.Trim(), out mesaNro);
            nombreCliente = TextNombreCliente.Text.Trim();
            int.TryParse(TextCantidad.Text.Trim(), out cantidad);
            tipoProducto = CheckedListBoxProducto.Text.Trim();
            nombreComida = CBoxNombreComida.Text.Trim();
            listaIngredientes = new List<string>();
            listaIngredientes.Add(ListBoxIngredientes.Text.Trim());
            nombreBebida = CBoxNombreBebida.Text.Trim();
            presentacionBebida = CBoxEPresentacionBebida.Text.Trim();




            //listBox1.Items.Add($" MesaNro: \n{mesaNro} " +
            //    $"Nombre Cliente {nombreCliente}" +
            //    $" Cantidad: \n{cantidad} " +
            //    $"Tipo de Producto: {tipoProducto} " +
            //    $"Ingredientes: {ListBoxIngredientes.Text} " +
            //    $"Presentación de la Bebida: {presentacionBebida}");

            //listBox1.Items.($"{CBoxMesaNro.ToString()}");
            //Mesa(CBoxMesaNro.SelectedItem, Cliente(CBoxMesaNro.SelectedItem, TextNombreCliente, Cuenta(Orden(CheckedListBoxProducto));


            DataGridAgregarProductos.Rows.Add(mesaNro, nombreCliente, cantidad, tipoProducto, nombreComida, ListBoxIngredientes.Text, nombreBebida, presentacionBebida);

        }

        private void CBoxMesaNro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CBoxMesaNro_MouseClick(object sender, MouseEventArgs e)
        {
            


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void TextNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridAgregarProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     


        }

        private void BtnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
