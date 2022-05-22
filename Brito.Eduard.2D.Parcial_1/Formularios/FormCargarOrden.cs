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
            CBoxEIngredientes.DataSource = Enum.GetValues(typeof(EIngredientes));
            CBoxEPresentacionBebida.DataSource = Enum.GetValues(typeof(EPresentacionBebida));
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBoxEIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CBoxEIngredientes.DataSource = Enum.GetValues(typeof(EIngredientes));

        }

        private void CBoxEPresentacionBebida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
