namespace Formularios
{
    partial class FormCargarOrden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargarOrden));
            this.TextCantidad = new System.Windows.Forms.TextBox();
            this.bebidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabCantidad = new System.Windows.Forms.Label();
            this.LabProducto = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.CBoxEIngredientes = new System.Windows.Forms.ComboBox();
            this.comidaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CBoxEPresentacionBebida = new System.Windows.Forms.ComboBox();
            this.LabIngredientes = new System.Windows.Forms.Label();
            this.LabPresentacionBebida = new System.Windows.Forms.Label();
            this.CBoxMesaNro = new System.Windows.Forms.ComboBox();
            this.LabMesaNro = new System.Windows.Forms.Label();
            this.LabNombreCliente = new System.Windows.Forms.Label();
            this.TextNombreCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bebidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comidaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TextCantidad
            // 
            this.TextCantidad.Location = new System.Drawing.Point(73, 20);
            this.TextCantidad.Name = "TextCantidad";
            this.TextCantidad.Size = new System.Drawing.Size(39, 23);
            this.TextCantidad.TabIndex = 0;
            // 
            // bebidaBindingSource
            // 
            this.bebidaBindingSource.DataSource = typeof(Biblioteca.Bebida);
            // 
            // LabCantidad
            // 
            this.LabCantidad.AutoSize = true;
            this.LabCantidad.Location = new System.Drawing.Point(12, 28);
            this.LabCantidad.Name = "LabCantidad";
            this.LabCantidad.Size = new System.Drawing.Size(55, 15);
            this.LabCantidad.TabIndex = 2;
            this.LabCantidad.Text = "Cantidad";
            // 
            // LabProducto
            // 
            this.LabProducto.AutoSize = true;
            this.LabProducto.Location = new System.Drawing.Point(118, 28);
            this.LabProducto.Name = "LabProducto";
            this.LabProducto.Size = new System.Drawing.Size(56, 15);
            this.LabProducto.TabIndex = 3;
            this.LabProducto.Text = "Producto";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Comida",
            "Bebida"});
            this.checkedListBox1.Location = new System.Drawing.Point(180, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(71, 40);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // CBoxEIngredientes
            // 
            this.CBoxEIngredientes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CBoxEIngredientes.FormattingEnabled = true;
            this.CBoxEIngredientes.Location = new System.Drawing.Point(354, 20);
            this.CBoxEIngredientes.Name = "CBoxEIngredientes";
            this.CBoxEIngredientes.Size = new System.Drawing.Size(81, 23);
            this.CBoxEIngredientes.TabIndex = 5;
            this.CBoxEIngredientes.SelectedIndexChanged += new System.EventHandler(this.CBoxEIngredientes_SelectedIndexChanged);
            // 
            // CBoxEPresentacionBebida
            // 
            this.CBoxEPresentacionBebida.FormattingEnabled = true;
            this.CBoxEPresentacionBebida.Location = new System.Drawing.Point(600, 20);
            this.CBoxEPresentacionBebida.Name = "CBoxEPresentacionBebida";
            this.CBoxEPresentacionBebida.Size = new System.Drawing.Size(95, 23);
            this.CBoxEPresentacionBebida.TabIndex = 6;
            this.CBoxEPresentacionBebida.SelectedIndexChanged += new System.EventHandler(this.CBoxEPresentacionBebida_SelectedIndexChanged);
            // 
            // LabIngredientes
            // 
            this.LabIngredientes.AutoSize = true;
            this.LabIngredientes.Location = new System.Drawing.Point(276, 28);
            this.LabIngredientes.Name = "LabIngredientes";
            this.LabIngredientes.Size = new System.Drawing.Size(72, 15);
            this.LabIngredientes.TabIndex = 7;
            this.LabIngredientes.Text = "Ingredientes";
            // 
            // LabPresentacionBebida
            // 
            this.LabPresentacionBebida.AutoSize = true;
            this.LabPresentacionBebida.Location = new System.Drawing.Point(452, 28);
            this.LabPresentacionBebida.Name = "LabPresentacionBebida";
            this.LabPresentacionBebida.Size = new System.Drawing.Size(142, 15);
            this.LabPresentacionBebida.TabIndex = 8;
            this.LabPresentacionBebida.Text = "Presentación de la Bebida";
            // 
            // CBoxMesaNro
            // 
            this.CBoxMesaNro.FormattingEnabled = true;
            this.CBoxMesaNro.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.CBoxMesaNro.Location = new System.Drawing.Point(76, 63);
            this.CBoxMesaNro.Name = "CBoxMesaNro";
            this.CBoxMesaNro.Size = new System.Drawing.Size(36, 23);
            this.CBoxMesaNro.TabIndex = 9;
            // 
            // LabMesaNro
            // 
            this.LabMesaNro.AutoSize = true;
            this.LabMesaNro.Location = new System.Drawing.Point(12, 71);
            this.LabMesaNro.Name = "LabMesaNro";
            this.LabMesaNro.Size = new System.Drawing.Size(58, 15);
            this.LabMesaNro.TabIndex = 10;
            this.LabMesaNro.Text = "Mesa Nro";
            // 
            // LabNombreCliente
            // 
            this.LabNombreCliente.AutoSize = true;
            this.LabNombreCliente.Location = new System.Drawing.Point(160, 71);
            this.LabNombreCliente.Name = "LabNombreCliente";
            this.LabNombreCliente.Size = new System.Drawing.Size(110, 15);
            this.LabNombreCliente.TabIndex = 11;
            this.LabNombreCliente.Text = "Nombre del Cliente";
            // 
            // TextNombreCliente
            // 
            this.TextNombreCliente.Location = new System.Drawing.Point(280, 63);
            this.TextNombreCliente.Name = "TextNombreCliente";
            this.TextNombreCliente.Size = new System.Drawing.Size(133, 23);
            this.TextNombreCliente.TabIndex = 12;
            // 
            // FormCargarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextNombreCliente);
            this.Controls.Add(this.LabNombreCliente);
            this.Controls.Add(this.LabMesaNro);
            this.Controls.Add(this.CBoxMesaNro);
            this.Controls.Add(this.LabPresentacionBebida);
            this.Controls.Add(this.LabIngredientes);
            this.Controls.Add(this.CBoxEPresentacionBebida);
            this.Controls.Add(this.CBoxEIngredientes);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.LabProducto);
            this.Controls.Add(this.LabCantidad);
            this.Controls.Add(this.TextCantidad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCargarOrden";
            this.Text = "Bar LesUTN > Menu Principal > Cargar Orden";
            this.Load += new System.EventHandler(this.FormCargarOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bebidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comidaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comidaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextCantidad;
        private System.Windows.Forms.BindingSource bebidaBindingSource;
        private System.Windows.Forms.Label LabCantidad;
        private System.Windows.Forms.Label LabProducto;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox CBoxEIngredientes;
        private System.Windows.Forms.BindingSource comidaBindingSource1;
        private System.Windows.Forms.BindingSource comidaBindingSource;
        private System.Windows.Forms.ComboBox CBoxEPresentacionBebida;
        private System.Windows.Forms.Label LabIngredientes;
        private System.Windows.Forms.Label LabPresentacionBebida;
        private System.Windows.Forms.ComboBox CBoxMesaNro;
        private System.Windows.Forms.Label LabMesaNro;
        private System.Windows.Forms.Label LabNombreCliente;
        private System.Windows.Forms.TextBox TextNombreCliente;
    }
}