namespace ProyectodeferrerMaster.Interfaces
{
    partial class FrmProducto
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
            Button bntSalir;
            lblNombreProducto = new Label();
            txtNombreProducto = new TextBox();
            lblDescripcion = new Label();
            numPrecioUnitario = new NumericUpDown();
            lblPrecioUnitario = new Label();
            cmbProveedor = new ComboBox();
            txtUnidadMedida = new TextBox();
            lblStock = new Label();
            cmbCategoria = new ComboBox();
            lblCategoria = new Label();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            dgvProductos = new DataGridView();
            numStock = new NumericUpDown();
            lblUnidadMedida = new Label();
            lblProveedor = new Label();
            txtDescripcion = new TextBox();
            label1 = new Label();
            bntSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)numPrecioUnitario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(12, 20);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(103, 15);
            lblNombreProducto.TabIndex = 0;
            lblNombreProducto.Text = "Nombre Producto";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(15, 51);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(100, 23);
            txtNombreProducto.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(183, 20);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion";
            // 
            // numPrecioUnitario
            // 
            numPrecioUnitario.Location = new Point(333, 63);
            numPrecioUnitario.Name = "numPrecioUnitario";
            numPrecioUnitario.Size = new Size(120, 23);
            numPrecioUnitario.TabIndex = 3;
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Location = new Point(341, 20);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(85, 15);
            lblPrecioUnitario.TabIndex = 4;
            lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(495, 134);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(121, 23);
            cmbProveedor.TabIndex = 5;
            // 
            // txtUnidadMedida
            // 
            txtUnidadMedida.Location = new Point(370, 134);
            txtUnidadMedida.Name = "txtUnidadMedida";
            txtUnidadMedida.Size = new Size(100, 23);
            txtUnidadMedida.TabIndex = 7;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(559, 30);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 6;
            lblStock.Text = "Stock";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(183, 134);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 9;
            // 
            // lblCategoria
            // 
            lblCategoria.Location = new Point(0, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(100, 23);
            lblCategoria.TabIndex = 18;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(213, 206);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(333, 206);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(471, 206);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(15, 247);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(672, 178);
            dgvProductos.TabIndex = 13;
            // 
            // numStock
            // 
            numStock.Location = new Point(517, 77);
            numStock.Name = "numStock";
            numStock.Size = new Size(120, 23);
            numStock.TabIndex = 14;
            // 
            // lblUnidadMedida
            // 
            lblUnidadMedida.AutoSize = true;
            lblUnidadMedida.Location = new Point(370, 107);
            lblUnidadMedida.Name = "lblUnidadMedida";
            lblUnidadMedida.Size = new Size(88, 15);
            lblUnidadMedida.TabIndex = 15;
            lblUnidadMedida.Text = "Unidad Medida";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(517, 107);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(61, 15);
            lblProveedor.TabIndex = 16;
            lblProveedor.Text = "Proveedor";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(171, 51);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 107);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 19;
            label1.Text = "Categoria";
            // 
            // bntSalir
            // 
            bntSalir.BackColor = Color.Transparent;
            bntSalir.FlatStyle = FlatStyle.Popup;
            bntSalir.ForeColor = Color.Transparent;
            bntSalir.Image = Properties.Resources.borrar;
            bntSalir.Location = new Point(735, 18);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(53, 39);
            bntSalir.TabIndex = 51;
            bntSalir.UseVisualStyleBackColor = true;
            bntSalir.Click += bntSalir_Click;
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bntSalir);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            Controls.Add(lblProveedor);
            Controls.Add(lblUnidadMedida);
            Controls.Add(numStock);
            Controls.Add(dgvProductos);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(txtUnidadMedida);
            Controls.Add(lblStock);
            Controls.Add(cmbProveedor);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(numPrecioUnitario);
            Controls.Add(lblDescripcion);
            Controls.Add(txtNombreProducto);
            Controls.Add(lblNombreProducto);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmProducto";
            Text = "Producto";
            Load += FrmProducto_Load;
            ((System.ComponentModel.ISupportInitialize)numPrecioUnitario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreProducto;
        private TextBox txtNombreProducto;
        private Label lblDescripcion;
        private NumericUpDown numPrecioUnitario;
        private Label lblPrecioUnitario;
        private ComboBox cmbProveedor;
        private TextBox txtUnidadMedida;
        private Label lblStock;
        private ComboBox cmbCategoria;
        private Label lblCategoria;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private DataGridView dgvProductos;
        private NumericUpDown numStock;
        private Label lblUnidadMedida;
        private Label lblProveedor;
        private TextBox txtDescripcion;
        private Label label1;
    }
}