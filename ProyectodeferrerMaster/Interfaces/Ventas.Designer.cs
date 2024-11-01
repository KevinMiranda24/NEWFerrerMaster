﻿namespace ProyectodeferrerMaster.Interfaces
{
    partial class Ventas
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
			lblCliente = new Label();
			cmbCliente = new ComboBox();
			lblFechaVenta = new Label();
			dtpFechaVenta = new DateTimePicker();
			lblTotal = new Label();
			txtTotal = new TextBox();
			btnGuardar = new Button();
			btnLimpiar = new Button();
			btnEliminar = new Button();
			dgvDetalleVenta = new DataGridView();
			cmbProducto = new ComboBox();
			Producto = new Label();
			label1 = new Label();
			txtCantidad = new TextBox();
			bntSalir = new Button();
			((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
			SuspendLayout();
			// 
			// bntSalir
			// 
			bntSalir.BackColor = Color.Transparent;
			bntSalir.FlatStyle = FlatStyle.Popup;
			bntSalir.ForeColor = Color.Transparent;
			bntSalir.Image = Properties.Resources.borrar;
			bntSalir.Location = new Point(725, 27);
			bntSalir.Name = "bntSalir";
			bntSalir.Size = new Size(53, 39);
			bntSalir.TabIndex = 51;
			bntSalir.UseVisualStyleBackColor = true;
			bntSalir.Click += bntSalir_Click;
			// 
			// lblCliente
			// 
			lblCliente.AutoSize = true;
			lblCliente.BackColor = Color.FromArgb(189, 195, 199);
			lblCliente.Font = new Font("Segoe UI", 12F);
			lblCliente.ForeColor = Color.FromArgb(52, 73, 94);
			lblCliente.Location = new Point(21, 27);
			lblCliente.Name = "lblCliente";
			lblCliente.Size = new Size(58, 21);
			lblCliente.TabIndex = 0;
			lblCliente.Text = "Cliente";
			// 
			// cmbCliente
			// 
			cmbCliente.FormattingEnabled = true;
			cmbCliente.Location = new Point(21, 69);
			cmbCliente.Name = "cmbCliente";
			cmbCliente.Size = new Size(121, 23);
			cmbCliente.TabIndex = 1;
			// 
			// lblFechaVenta
			// 
			lblFechaVenta.AutoSize = true;
			lblFechaVenta.BackColor = Color.FromArgb(189, 195, 199);
			lblFechaVenta.Font = new Font("Segoe UI", 12F);
			lblFechaVenta.ForeColor = Color.FromArgb(52, 73, 94);
			lblFechaVenta.Location = new Point(170, 27);
			lblFechaVenta.Name = "lblFechaVenta";
			lblFechaVenta.Size = new Size(113, 21);
			lblFechaVenta.TabIndex = 2;
			lblFechaVenta.Text = "Fecha de venta";
			// 
			// dtpFechaVenta
			// 
			dtpFechaVenta.Location = new Point(170, 66);
			dtpFechaVenta.Name = "dtpFechaVenta";
			dtpFechaVenta.Size = new Size(200, 23);
			dtpFechaVenta.TabIndex = 3;
			// 
			// lblTotal
			// 
			lblTotal.AutoSize = true;
			lblTotal.BackColor = Color.FromArgb(189, 195, 199);
			lblTotal.Font = new Font("Segoe UI", 12F);
			lblTotal.ForeColor = Color.FromArgb(52, 73, 94);
			lblTotal.Location = new Point(426, 27);
			lblTotal.Name = "lblTotal";
			lblTotal.Size = new Size(42, 21);
			lblTotal.TabIndex = 4;
			lblTotal.Text = "Total";
			// 
			// txtTotal
			// 
			txtTotal.BackColor = Color.White;
			txtTotal.BorderStyle = BorderStyle.FixedSingle;
			txtTotal.Location = new Point(413, 69);
			txtTotal.Name = "txtTotal";
			txtTotal.Size = new Size(100, 23);
			txtTotal.TabIndex = 5;
			// 
			// btnGuardar
			// 
			btnGuardar.BackColor = Color.FromArgb(52, 152, 219);
			btnGuardar.FlatStyle = FlatStyle.Flat;
			btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			btnGuardar.Location = new Point(584, 228);
			btnGuardar.Name = "btnGuardar";
			btnGuardar.Size = new Size(104, 43);
			btnGuardar.TabIndex = 6;
			btnGuardar.Text = "Guardar";
			btnGuardar.UseVisualStyleBackColor = false;
			btnGuardar.Click += btnGuardar_Click;
			// 
			// btnLimpiar
			// 
			btnLimpiar.BackColor = Color.FromArgb(241, 196, 15);
			btnLimpiar.FlatStyle = FlatStyle.Flat;
			btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			btnLimpiar.Location = new Point(584, 391);
			btnLimpiar.Name = "btnLimpiar";
			btnLimpiar.Size = new Size(104, 38);
			btnLimpiar.TabIndex = 7;
			btnLimpiar.Text = "Limpiar";
			btnLimpiar.UseVisualStyleBackColor = false;
			btnLimpiar.Click += btnLimpiar_Click;
			// 
			// btnEliminar
			// 
			btnEliminar.BackColor = Color.FromArgb(231, 76, 60);
			btnEliminar.FlatStyle = FlatStyle.Flat;
			btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			btnEliminar.Location = new Point(584, 311);
			btnEliminar.Name = "btnEliminar";
			btnEliminar.Size = new Size(104, 40);
			btnEliminar.TabIndex = 8;
			btnEliminar.Text = "Eliminar";
			btnEliminar.UseVisualStyleBackColor = false;
			btnEliminar.Click += btnEliminar_Click;
			// 
			// dgvDetalleVenta
			// 
			dgvDetalleVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvDetalleVenta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDetalleVenta.Location = new Point(21, 239);
			dgvDetalleVenta.Name = "dgvDetalleVenta";
			dgvDetalleVenta.Size = new Size(461, 190);
			dgvDetalleVenta.TabIndex = 10;
			dgvDetalleVenta.CellClick += dgvDetalleVenta_CellClick;
			// 
			// cmbProducto
			// 
			cmbProducto.FormattingEnabled = true;
			cmbProducto.Location = new Point(330, 174);
			cmbProducto.Name = "cmbProducto";
			cmbProducto.Size = new Size(121, 23);
			cmbProducto.TabIndex = 52;
			// 
			// Producto
			// 
			Producto.AutoSize = true;
			Producto.BackColor = Color.FromArgb(189, 195, 199);
			Producto.Font = new Font("Segoe UI", 12F);
			Producto.ForeColor = Color.FromArgb(52, 73, 94);
			Producto.Location = new Point(330, 140);
			Producto.Name = "Producto";
			Producto.Size = new Size(73, 21);
			Producto.TabIndex = 53;
			Producto.Text = "Producto";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.FromArgb(189, 195, 199);
			label1.Font = new Font("Segoe UI", 12F);
			label1.ForeColor = Color.FromArgb(52, 73, 94);
			label1.Location = new Point(35, 140);
			label1.Name = "label1";
			label1.Size = new Size(72, 21);
			label1.TabIndex = 54;
			label1.Text = "Cantidad";
			// 
			// txtCantidad
			// 
			txtCantidad.Location = new Point(39, 177);
			txtCantidad.Name = "txtCantidad";
			txtCantidad.Size = new Size(100, 23);
			txtCantidad.TabIndex = 55;
			// 
			// Ventas
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(txtCantidad);
			Controls.Add(label1);
			Controls.Add(Producto);
			Controls.Add(cmbProducto);
			Controls.Add(bntSalir);
			Controls.Add(dgvDetalleVenta);
			Controls.Add(btnEliminar);
			Controls.Add(btnLimpiar);
			Controls.Add(btnGuardar);
			Controls.Add(txtTotal);
			Controls.Add(lblTotal);
			Controls.Add(dtpFechaVenta);
			Controls.Add(lblFechaVenta);
			Controls.Add(cmbCliente);
			Controls.Add(lblCliente);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Ventas";
			Text = "Ventas";
			((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblCliente;
        private ComboBox cmbCliente;
        private Label lblFechaVenta;
        private DateTimePicker dtpFechaVenta;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private DataGridView dgvDetalleVenta;
		private ComboBox cmbProducto;
		private Label Producto;
		private Label label1;
		private TextBox txtCantidad;
	}
}