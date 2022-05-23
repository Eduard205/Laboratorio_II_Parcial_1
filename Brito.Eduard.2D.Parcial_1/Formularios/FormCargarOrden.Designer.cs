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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargarOrden));
            this.TextCantidad = new System.Windows.Forms.TextBox();
            this.LabCantidad = new System.Windows.Forms.Label();
            this.LabProducto = new System.Windows.Forms.Label();
            this.CheckedListBoxProducto = new System.Windows.Forms.CheckedListBox();
            this.CBoxEPresentacionBebida = new System.Windows.Forms.ComboBox();
            this.LabIngredientes = new System.Windows.Forms.Label();
            this.LabPresentacionBebida = new System.Windows.Forms.Label();
            this.CBoxMesaNro = new System.Windows.Forms.ComboBox();
            this.LabMesaNro = new System.Windows.Forms.Label();
            this.LabNombreCliente = new System.Windows.Forms.Label();
            this.TextNombreCliente = new System.Windows.Forms.TextBox();
            this.ListBoxIngredientes = new System.Windows.Forms.ListBox();
            this.BtnAgregarProductos = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DataGridAgregarProductos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreComida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingredientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresentacionBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabNombreComida = new System.Windows.Forms.Label();
            this.LabNombreBebida = new System.Windows.Forms.Label();
            this.CBoxNombreComida = new System.Windows.Forms.ComboBox();
            this.CBoxNombreBebida = new System.Windows.Forms.ComboBox();
            this.BtnVolverMenuPrincipal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAgregarProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // TextCantidad
            // 
            this.TextCantidad.Location = new System.Drawing.Point(434, 19);
            this.TextCantidad.Name = "TextCantidad";
            this.TextCantidad.Size = new System.Drawing.Size(39, 23);
            this.TextCantidad.TabIndex = 0;
            // 
            // LabCantidad
            // 
            this.LabCantidad.AutoSize = true;
            this.LabCantidad.Location = new System.Drawing.Point(373, 27);
            this.LabCantidad.Name = "LabCantidad";
            this.LabCantidad.Size = new System.Drawing.Size(55, 15);
            this.LabCantidad.TabIndex = 2;
            this.LabCantidad.Text = "Cantidad";
            // 
            // LabProducto
            // 
            this.LabProducto.AutoSize = true;
            this.LabProducto.Location = new System.Drawing.Point(479, 27);
            this.LabProducto.Name = "LabProducto";
            this.LabProducto.Size = new System.Drawing.Size(56, 15);
            this.LabProducto.TabIndex = 3;
            this.LabProducto.Text = "Producto";
            // 
            // CheckedListBoxProducto
            // 
            this.CheckedListBoxProducto.FormattingEnabled = true;
            this.CheckedListBoxProducto.Items.AddRange(new object[] {
            "Comida",
            "Bebida"});
            this.CheckedListBoxProducto.Location = new System.Drawing.Point(541, 2);
            this.CheckedListBoxProducto.Name = "CheckedListBoxProducto";
            this.CheckedListBoxProducto.Size = new System.Drawing.Size(71, 40);
            this.CheckedListBoxProducto.TabIndex = 4;
            this.CheckedListBoxProducto.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxProducto_SelectedIndexChanged);
            // 
            // CBoxEPresentacionBebida
            // 
            this.CBoxEPresentacionBebida.FormattingEnabled = true;
            this.CBoxEPresentacionBebida.Items.AddRange(new object[] {
            ""});
            this.CBoxEPresentacionBebida.Location = new System.Drawing.Point(638, 111);
            this.CBoxEPresentacionBebida.Name = "CBoxEPresentacionBebida";
            this.CBoxEPresentacionBebida.Size = new System.Drawing.Size(95, 23);
            this.CBoxEPresentacionBebida.TabIndex = 6;
            this.CBoxEPresentacionBebida.SelectedIndexChanged += new System.EventHandler(this.CBoxEPresentacionBebida_SelectedIndexChanged);
            // 
            // LabIngredientes
            // 
            this.LabIngredientes.AutoSize = true;
            this.LabIngredientes.Location = new System.Drawing.Point(252, 89);
            this.LabIngredientes.Name = "LabIngredientes";
            this.LabIngredientes.Size = new System.Drawing.Size(72, 15);
            this.LabIngredientes.TabIndex = 7;
            this.LabIngredientes.Text = "Ingredientes";
            // 
            // LabPresentacionBebida
            // 
            this.LabPresentacionBebida.AutoSize = true;
            this.LabPresentacionBebida.Location = new System.Drawing.Point(490, 119);
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
            this.CBoxMesaNro.Location = new System.Drawing.Point(76, 19);
            this.CBoxMesaNro.Name = "CBoxMesaNro";
            this.CBoxMesaNro.Size = new System.Drawing.Size(36, 23);
            this.CBoxMesaNro.TabIndex = 9;
            this.CBoxMesaNro.SelectedIndexChanged += new System.EventHandler(this.CBoxMesaNro_SelectedIndexChanged);
            this.CBoxMesaNro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CBoxMesaNro_MouseClick);
            // 
            // LabMesaNro
            // 
            this.LabMesaNro.AutoSize = true;
            this.LabMesaNro.Location = new System.Drawing.Point(12, 27);
            this.LabMesaNro.Name = "LabMesaNro";
            this.LabMesaNro.Size = new System.Drawing.Size(58, 15);
            this.LabMesaNro.TabIndex = 10;
            this.LabMesaNro.Text = "Mesa Nro";
            // 
            // LabNombreCliente
            // 
            this.LabNombreCliente.AutoSize = true;
            this.LabNombreCliente.Location = new System.Drawing.Point(118, 27);
            this.LabNombreCliente.Name = "LabNombreCliente";
            this.LabNombreCliente.Size = new System.Drawing.Size(110, 15);
            this.LabNombreCliente.TabIndex = 11;
            this.LabNombreCliente.Text = "Nombre del Cliente";
            // 
            // TextNombreCliente
            // 
            this.TextNombreCliente.Location = new System.Drawing.Point(234, 19);
            this.TextNombreCliente.Name = "TextNombreCliente";
            this.TextNombreCliente.Size = new System.Drawing.Size(133, 23);
            this.TextNombreCliente.TabIndex = 12;
            this.TextNombreCliente.TextChanged += new System.EventHandler(this.TextNombreCliente_TextChanged);
            // 
            // ListBoxIngredientes
            // 
            this.ListBoxIngredientes.FormattingEnabled = true;
            this.ListBoxIngredientes.ItemHeight = 15;
            this.ListBoxIngredientes.Location = new System.Drawing.Point(330, 57);
            this.ListBoxIngredientes.Name = "ListBoxIngredientes";
            this.ListBoxIngredientes.Size = new System.Drawing.Size(154, 49);
            this.ListBoxIngredientes.TabIndex = 13;
            this.ListBoxIngredientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxIngredientes_MouseClick);
            this.ListBoxIngredientes.SelectedIndexChanged += new System.EventHandler(this.ListBoxIngredientes_SelectedIndexChanged);
            // 
            // BtnAgregarProductos
            // 
            this.BtnAgregarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnAgregarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregarProductos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregarProductos.Location = new System.Drawing.Point(330, 167);
            this.BtnAgregarProductos.Name = "BtnAgregarProductos";
            this.BtnAgregarProductos.Size = new System.Drawing.Size(132, 28);
            this.BtnAgregarProductos.TabIndex = 15;
            this.BtnAgregarProductos.Text = "Agregar Productos";
            this.BtnAgregarProductos.UseVisualStyleBackColor = false;
            this.BtnAgregarProductos.Click += new System.EventHandler(this.BtnAgregarProductos_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // DataGridAgregarProductos
            // 
            this.DataGridAgregarProductos.AllowUserToAddRows = false;
            this.DataGridAgregarProductos.AllowUserToOrderColumns = true;
            this.DataGridAgregarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAgregarProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.NombreCliente,
            this.Cantidad,
            this.Producto,
            this.NombreComida,
            this.Ingredientes,
            this.NombreBebida,
            this.PresentacionBebida});
            this.DataGridAgregarProductos.Location = new System.Drawing.Point(12, 219);
            this.DataGridAgregarProductos.Name = "DataGridAgregarProductos";
            this.DataGridAgregarProductos.RowTemplate.Height = 25;
            this.DataGridAgregarProductos.Size = new System.Drawing.Size(840, 202);
            this.DataGridAgregarProductos.TabIndex = 16;
            this.DataGridAgregarProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridAgregarProductos_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.HeaderText = "Mesa Nro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 83;
            // 
            // NombreCliente
            // 
            this.NombreCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NombreCliente.HeaderText = "NombreCliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Width = 113;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad.HeaderText = "Cant";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 57;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.Width = 81;
            // 
            // NombreComida
            // 
            this.NombreComida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NombreComida.HeaderText = "NombreComida";
            this.NombreComida.Name = "NombreComida";
            this.NombreComida.Width = 118;
            // 
            // Ingredientes
            // 
            this.Ingredientes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Ingredientes.HeaderText = "Ingredientes";
            this.Ingredientes.Name = "Ingredientes";
            this.Ingredientes.Width = 97;
            // 
            // NombreBebida
            // 
            this.NombreBebida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NombreBebida.HeaderText = "NombreBebida";
            this.NombreBebida.Name = "NombreBebida";
            this.NombreBebida.Width = 112;
            // 
            // PresentacionBebida
            // 
            this.PresentacionBebida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PresentacionBebida.HeaderText = "PresentacionBebida";
            this.PresentacionBebida.Name = "PresentacionBebida";
            this.PresentacionBebida.Width = 136;
            // 
            // LabNombreComida
            // 
            this.LabNombreComida.AutoSize = true;
            this.LabNombreComida.Location = new System.Drawing.Point(12, 91);
            this.LabNombreComida.Name = "LabNombreComida";
            this.LabNombreComida.Size = new System.Drawing.Size(96, 15);
            this.LabNombreComida.TabIndex = 18;
            this.LabNombreComida.Text = "Nombre Comida";
            // 
            // LabNombreBebida
            // 
            this.LabNombreBebida.AutoSize = true;
            this.LabNombreBebida.Location = new System.Drawing.Point(490, 89);
            this.LabNombreBebida.Name = "LabNombreBebida";
            this.LabNombreBebida.Size = new System.Drawing.Size(90, 15);
            this.LabNombreBebida.TabIndex = 19;
            this.LabNombreBebida.Text = "Nombre Bebida";
            // 
            // CBoxNombreComida
            // 
            this.CBoxNombreComida.FormattingEnabled = true;
            this.CBoxNombreComida.Items.AddRange(new object[] {
            "",
            "Hamburguesa Simple",
            "Hamburguesa Especial",
            "Picada",
            "Pizza"});
            this.CBoxNombreComida.Location = new System.Drawing.Point(114, 81);
            this.CBoxNombreComida.Name = "CBoxNombreComida";
            this.CBoxNombreComida.Size = new System.Drawing.Size(132, 23);
            this.CBoxNombreComida.TabIndex = 21;
            // 
            // CBoxNombreBebida
            // 
            this.CBoxNombreBebida.FormattingEnabled = true;
            this.CBoxNombreBebida.Items.AddRange(new object[] {
            "",
            "Coca Cola",
            "Pepsi",
            "Mojito",
            "Dry Martini",
            "Daiquiri",
            "Margarita",
            "Tequila Sunrise",
            "Mimosa",
            "Quilmes",
            "Schneider",
            "Brahma",
            "Honey",
            "Red Honey",
            "IPA"});
            this.CBoxNombreBebida.Location = new System.Drawing.Point(586, 81);
            this.CBoxNombreBebida.Name = "CBoxNombreBebida";
            this.CBoxNombreBebida.Size = new System.Drawing.Size(131, 23);
            this.CBoxNombreBebida.TabIndex = 22;
            // 
            // BtnVolverMenuPrincipal
            // 
            this.BtnVolverMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnVolverMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVolverMenuPrincipal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnVolverMenuPrincipal.Location = new System.Drawing.Point(700, 12);
            this.BtnVolverMenuPrincipal.Name = "BtnVolverMenuPrincipal";
            this.BtnVolverMenuPrincipal.Size = new System.Drawing.Size(152, 30);
            this.BtnVolverMenuPrincipal.TabIndex = 23;
            this.BtnVolverMenuPrincipal.Text = "Volver al Menu Principal";
            this.BtnVolverMenuPrincipal.UseVisualStyleBackColor = false;
            this.BtnVolverMenuPrincipal.Click += new System.EventHandler(this.BtnVolverMenuPrincipal_Click);
            // 
            // FormCargarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.BtnVolverMenuPrincipal);
            this.Controls.Add(this.CBoxNombreBebida);
            this.Controls.Add(this.CBoxNombreComida);
            this.Controls.Add(this.LabNombreBebida);
            this.Controls.Add(this.LabNombreComida);
            this.Controls.Add(this.DataGridAgregarProductos);
            this.Controls.Add(this.BtnAgregarProductos);
            this.Controls.Add(this.ListBoxIngredientes);
            this.Controls.Add(this.TextNombreCliente);
            this.Controls.Add(this.LabNombreCliente);
            this.Controls.Add(this.LabMesaNro);
            this.Controls.Add(this.CBoxMesaNro);
            this.Controls.Add(this.LabPresentacionBebida);
            this.Controls.Add(this.LabIngredientes);
            this.Controls.Add(this.CBoxEPresentacionBebida);
            this.Controls.Add(this.CheckedListBoxProducto);
            this.Controls.Add(this.LabProducto);
            this.Controls.Add(this.LabCantidad);
            this.Controls.Add(this.TextCantidad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCargarOrden";
            this.Text = "Bar LesUTN > Menu Principal > Cargar Orden";
            this.Load += new System.EventHandler(this.FormCargarOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAgregarProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextCantidad;
        private System.Windows.Forms.Label LabCantidad;
        private System.Windows.Forms.Label LabProducto;
        private System.Windows.Forms.CheckedListBox CheckedListBoxProducto;
        private System.Windows.Forms.ComboBox CBoxEPresentacionBebida;
        private System.Windows.Forms.Label LabIngredientes;
        private System.Windows.Forms.Label LabPresentacionBebida;
        private System.Windows.Forms.ComboBox CBoxMesaNro;
        private System.Windows.Forms.Label LabMesaNro;
        private System.Windows.Forms.Label LabNombreCliente;
        private System.Windows.Forms.TextBox TextNombreCliente;
        private System.Windows.Forms.ListBox ListBoxIngredientes;
        private System.Windows.Forms.Button BtnAgregarProductos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView DataGridAgregarProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreComida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresentacionBebida;
        private System.Windows.Forms.Label LabNombreComida;
        private System.Windows.Forms.Label LabNombreBebida;
        private System.Windows.Forms.ComboBox CBoxNombreComida;
        private System.Windows.Forms.ComboBox CBoxNombreBebida;
        private System.Windows.Forms.Button BtnVolverMenuPrincipal;
    }
}