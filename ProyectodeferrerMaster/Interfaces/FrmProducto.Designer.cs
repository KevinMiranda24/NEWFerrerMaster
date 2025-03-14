﻿namespace ProyectodeferrerMaster.Interfaces
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
            lblStock = new Label();
            cmbCategoria = new ComboBox();
            lblCategoria = new Label();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            dgvProductos = new DataGridView();
            numStock = new NumericUpDown();
            lblProveedor = new Label();
            txtDescripcion = new TextBox();
            label1 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btnRepProductos = new Button();
            label8 = new Label();
            bntSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)numPrecioUnitario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bntSalir
            // 
            bntSalir.BackColor = Color.Transparent;
            bntSalir.FlatStyle = FlatStyle.Popup;
            bntSalir.ForeColor = Color.Transparent;
            bntSalir.Image = Properties.Resources.borrar;
            bntSalir.Location = new Point(827, 3);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(53, 39);
            bntSalir.TabIndex = 51;
            bntSalir.UseVisualStyleBackColor = true;
            bntSalir.Click += bntSalir_Click;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Segoe UI", 12F);
            lblNombreProducto.ForeColor = Color.FromArgb(52, 73, 94);
            lblNombreProducto.Location = new Point(3, 108);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(135, 21);
            lblNombreProducto.TabIndex = 0;
            lblNombreProducto.Text = "Nombre Producto";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.BorderStyle = BorderStyle.FixedSingle;
            txtNombreProducto.Location = new Point(144, 109);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(184, 23);
            txtNombreProducto.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 12F);
            lblDescripcion.ForeColor = Color.FromArgb(52, 73, 94);
            lblDescripcion.Location = new Point(3, 153);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(91, 21);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion";
            // 
            // numPrecioUnitario
            // 
            numPrecioUnitario.Location = new Point(473, 153);
            numPrecioUnitario.Name = "numPrecioUnitario";
            numPrecioUnitario.Size = new Size(120, 23);
            numPrecioUnitario.TabIndex = 3;
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Font = new Font("Segoe UI", 12F);
            lblPrecioUnitario.ForeColor = Color.FromArgb(52, 73, 94);
            lblPrecioUnitario.Location = new Point(352, 154);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(113, 21);
            lblPrecioUnitario.TabIndex = 4;
            lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(709, 112);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(163, 23);
            cmbProveedor.TabIndex = 5;
            cmbProveedor.SelectedIndexChanged += cmbProveedor_SelectedIndexChanged;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 12F);
            lblStock.ForeColor = Color.FromArgb(52, 73, 94);
            lblStock.Location = new Point(647, 154);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(47, 21);
            lblStock.TabIndex = 6;
            lblStock.Text = "Stock";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(435, 110);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(158, 23);
            cmbCategoria.TabIndex = 9;
            // 
            // lblCategoria
            // 
            lblCategoria.Location = new Point(575, 24);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(100, 23);
            lblCategoria.TabIndex = 18;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(52, 152, 219);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(100, 241);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 32);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(241, 196, 15);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(212, 242);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(93, 33);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(231, 76, 60);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(331, 242);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(87, 34);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 306);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(872, 178);
            dgvProductos.TabIndex = 13;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // numStock
            // 
            numStock.Location = new Point(709, 154);
            numStock.Name = "numStock";
            numStock.Size = new Size(120, 23);
            numStock.TabIndex = 14;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Font = new Font("Segoe UI", 12F);
            lblProveedor.ForeColor = Color.FromArgb(52, 73, 94);
            lblProveedor.Location = new Point(621, 113);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(82, 21);
            lblProveedor.TabIndex = 16;
            lblProveedor.Text = "Proveedor";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Location = new Point(100, 152);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(228, 23);
            txtDescripcion.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(52, 73, 94);
            label1.Location = new Point(352, 111);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 19;
            label1.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label5.Location = new Point(327, 11);
            label5.Name = "label5";
            label5.Size = new Size(237, 32);
            label5.TabIndex = 54;
            label5.Text = "Stock de Productos";
            label5.Click += label5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(189, 195, 199);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnRepProductos);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblCategoria);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(bntSalir);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(lblNombreProducto);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(numStock);
            panel1.Controls.Add(lblProveedor);
            panel1.Controls.Add(txtNombreProducto);
            panel1.Controls.Add(lblDescripcion);
            panel1.Controls.Add(lblStock);
            panel1.Controls.Add(cmbCategoria);
            panel1.Controls.Add(cmbProveedor);
            panel1.Controls.Add(lblPrecioUnitario);
            panel1.Controls.Add(numPrecioUnitario);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(883, 288);
            panel1.TabIndex = 55;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.FromArgb(52, 73, 94);
            label4.Location = new Point(767, 232);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 60;
            label4.Text = "- Mi abuelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(327, 201);
            label3.Name = "label3";
            label3.Size = new Size(514, 32);
            label3.TabIndex = 59;
            label3.Text = "¡El que compra barato, compra a cada rato!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(52, 73, 94);
            label2.Location = new Point(311, 248);
            label2.Name = "label2";
            label2.Size = new Size(14, 21);
            label2.TabIndex = 58;
            label2.Text = "|";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.FromArgb(52, 73, 94);
            label7.Location = new Point(192, 247);
            label7.Name = "label7";
            label7.Size = new Size(14, 21);
            label7.TabIndex = 57;
            label7.Text = "|";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.FromArgb(52, 73, 94);
            label6.Location = new Point(16, 252);
            label6.Name = "label6";
            label6.Size = new Size(78, 21);
            label6.TabIndex = 56;
            label6.Text = "Acciones: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hr;
            pictureBox1.Location = new Point(10, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 70);
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            // 
            // btnRepProductos
            // 
            btnRepProductos.BackColor = Color.FromArgb(128, 128, 255);
            btnRepProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRepProductos.ForeColor = Color.White;
            btnRepProductos.Location = new Point(460, 242);
            btnRepProductos.Name = "btnRepProductos";
            btnRepProductos.Size = new Size(146, 33);
            btnRepProductos.TabIndex = 61;
            btnRepProductos.Text = "Generar Reporte";
            btnRepProductos.UseVisualStyleBackColor = false;
            btnRepProductos.Click += btnRepProductos_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(432, 247);
            label8.Name = "label8";
            label8.Size = new Size(14, 21);
            label8.TabIndex = 62;
            label8.Text = "|";
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 498);
            Controls.Add(dgvProductos);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmProducto";
            Load += FrmProducto_Load;
            ((System.ComponentModel.ISupportInitialize)numPrecioUnitario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombreProducto;
        private TextBox txtNombreProducto;
        private Label lblDescripcion;
        private NumericUpDown numPrecioUnitario;
        private Label lblPrecioUnitario;
        private ComboBox cmbProveedor;
        private Label lblStock;
        private ComboBox cmbCategoria;
        private Label lblCategoria;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private DataGridView dgvProductos;
        private NumericUpDown numStock;
        private Label lblProveedor;
        private TextBox txtDescripcion;
        private Label label1;
		private Label label5;
		private Panel panel1;
		private PictureBox pictureBox1;
		private Label label6;
		private Label label2;
		private Label label7;
		private Label label4;
		private Label label3;
        private Label label8;
        private Button btnRepProductos;
    }
}