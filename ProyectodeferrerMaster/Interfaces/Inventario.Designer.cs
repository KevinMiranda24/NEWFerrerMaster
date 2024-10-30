namespace ProyectodeferrerMaster.Interfaces
{
    partial class Inventario
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
			lblProducto = new Label();
			cmbProducto = new ComboBox();
			cmbTipoMovimiento = new ComboBox();
			lblTipoMovimiento = new Label();
			lblCantidad = new Label();
			numCantidad = new NumericUpDown();
			lblFecha = new Label();
			dtpFechaMovimiento = new DateTimePicker();
			btnGuardar = new Button();
			btnLimpiar = new Button();
			btnEliminar = new Button();
			dgvInventario = new DataGridView();
			panel1 = new Panel();
			label5 = new Label();
			pictureBox1 = new PictureBox();
			label6 = new Label();
			label7 = new Label();
			label1 = new Label();
			bntSalir = new Button();
			((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
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
			bntSalir.Location = new Point(723, 3);
			bntSalir.Name = "bntSalir";
			bntSalir.Size = new Size(53, 39);
			bntSalir.TabIndex = 52;
			bntSalir.UseVisualStyleBackColor = true;
			bntSalir.Click += bntSalir_Click;
			// 
			// lblProducto
			// 
			lblProducto.AutoSize = true;
			lblProducto.Font = new Font("Segoe UI", 12F);
			lblProducto.ForeColor = Color.FromArgb(52, 73, 94);
			lblProducto.Location = new Point(22, 94);
			lblProducto.Name = "lblProducto";
			lblProducto.Size = new Size(73, 21);
			lblProducto.TabIndex = 0;
			lblProducto.Text = "Producto";
			// 
			// cmbProducto
			// 
			cmbProducto.FormattingEnabled = true;
			cmbProducto.Location = new Point(101, 96);
			cmbProducto.Name = "cmbProducto";
			cmbProducto.Size = new Size(240, 23);
			cmbProducto.TabIndex = 1;
			// 
			// cmbTipoMovimiento
			// 
			cmbTipoMovimiento.FormattingEnabled = true;
			cmbTipoMovimiento.Location = new Point(152, 144);
			cmbTipoMovimiento.Name = "cmbTipoMovimiento";
			cmbTipoMovimiento.Size = new Size(121, 23);
			cmbTipoMovimiento.TabIndex = 3;
			// 
			// lblTipoMovimiento
			// 
			lblTipoMovimiento.AutoSize = true;
			lblTipoMovimiento.Font = new Font("Segoe UI", 12F);
			lblTipoMovimiento.ForeColor = Color.FromArgb(52, 73, 94);
			lblTipoMovimiento.Location = new Point(22, 142);
			lblTipoMovimiento.Name = "lblTipoMovimiento";
			lblTipoMovimiento.Size = new Size(124, 21);
			lblTipoMovimiento.TabIndex = 2;
			lblTipoMovimiento.Text = "TipoMovimiento";
			// 
			// lblCantidad
			// 
			lblCantidad.AutoSize = true;
			lblCantidad.Font = new Font("Segoe UI", 12F);
			lblCantidad.ForeColor = Color.FromArgb(52, 73, 94);
			lblCantidad.Location = new Point(319, 142);
			lblCantidad.Name = "lblCantidad";
			lblCantidad.Size = new Size(72, 21);
			lblCantidad.TabIndex = 4;
			lblCantidad.Text = "Cantidad";
			// 
			// numCantidad
			// 
			numCantidad.Location = new Point(397, 144);
			numCantidad.Name = "numCantidad";
			numCantidad.Size = new Size(120, 23);
			numCantidad.TabIndex = 5;
			// 
			// lblFecha
			// 
			lblFecha.AutoSize = true;
			lblFecha.BackColor = Color.FromArgb(189, 195, 199);
			lblFecha.Font = new Font("Segoe UI", 12F);
			lblFecha.ForeColor = Color.FromArgb(52, 73, 94);
			lblFecha.Location = new Point(374, 96);
			lblFecha.Name = "lblFecha";
			lblFecha.Size = new Size(50, 21);
			lblFecha.TabIndex = 6;
			lblFecha.Text = "Fecha";
			// 
			// dtpFechaMovimiento
			// 
			dtpFechaMovimiento.Location = new Point(430, 96);
			dtpFechaMovimiento.Name = "dtpFechaMovimiento";
			dtpFechaMovimiento.Size = new Size(200, 23);
			dtpFechaMovimiento.TabIndex = 7;
			// 
			// btnGuardar
			// 
			btnGuardar.BackColor = Color.FromArgb(52, 152, 219);
			btnGuardar.FlatStyle = FlatStyle.Flat;
			btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			btnGuardar.ForeColor = Color.White;
			btnGuardar.Location = new Point(101, 204);
			btnGuardar.Name = "btnGuardar";
			btnGuardar.Size = new Size(85, 37);
			btnGuardar.TabIndex = 8;
			btnGuardar.Text = "Guardar";
			btnGuardar.UseVisualStyleBackColor = false;
			// 
			// btnLimpiar
			// 
			btnLimpiar.BackColor = Color.FromArgb(241, 196, 15);
			btnLimpiar.FlatStyle = FlatStyle.Flat;
			btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			btnLimpiar.ForeColor = Color.White;
			btnLimpiar.Location = new Point(212, 204);
			btnLimpiar.Name = "btnLimpiar";
			btnLimpiar.Size = new Size(90, 37);
			btnLimpiar.TabIndex = 9;
			btnLimpiar.Text = "Limpiar";
			btnLimpiar.UseVisualStyleBackColor = false;
			// 
			// btnEliminar
			// 
			btnEliminar.BackColor = Color.FromArgb(231, 76, 60);
			btnEliminar.FlatStyle = FlatStyle.Flat;
			btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			btnEliminar.ForeColor = Color.White;
			btnEliminar.Location = new Point(328, 204);
			btnEliminar.Name = "btnEliminar";
			btnEliminar.Size = new Size(85, 45);
			btnEliminar.TabIndex = 10;
			btnEliminar.Text = "Eliminar";
			btnEliminar.UseVisualStyleBackColor = false;
			// 
			// dgvInventario
			// 
			dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvInventario.Location = new Point(9, 285);
			dgvInventario.Name = "dgvInventario";
			dgvInventario.Size = new Size(613, 178);
			dgvInventario.TabIndex = 11;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(189, 195, 199);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(btnEliminar);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(btnLimpiar);
			panel1.Controls.Add(bntSalir);
			panel1.Controls.Add(btnGuardar);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(numCantidad);
			panel1.Controls.Add(dtpFechaMovimiento);
			panel1.Controls.Add(lblCantidad);
			panel1.Controls.Add(lblFecha);
			panel1.Controls.Add(cmbTipoMovimiento);
			panel1.Controls.Add(lblTipoMovimiento);
			panel1.Controls.Add(cmbProducto);
			panel1.Controls.Add(lblProducto);
			panel1.Location = new Point(9, 14);
			panel1.Name = "panel1";
			panel1.Size = new Size(785, 265);
			panel1.TabIndex = 53;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.FromArgb(44, 62, 80);
			label5.Location = new Point(264, 18);
			label5.Name = "label5";
			label5.Size = new Size(277, 32);
			label5.TabIndex = 53;
			label5.Text = "Inventario FerreMaster";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.inventrio;
			pictureBox1.Location = new Point(22, 18);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(50, 50);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 54;
			pictureBox1.TabStop = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 12F);
			label6.ForeColor = Color.FromArgb(52, 73, 94);
			label6.Location = new Point(22, 212);
			label6.Name = "label6";
			label6.Size = new Size(78, 21);
			label6.TabIndex = 55;
			label6.Text = "Acciones: ";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 12F);
			label7.ForeColor = Color.FromArgb(52, 73, 94);
			label7.Location = new Point(192, 212);
			label7.Name = "label7";
			label7.Size = new Size(14, 21);
			label7.TabIndex = 56;
			label7.Text = "|";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.ForeColor = Color.FromArgb(52, 73, 94);
			label1.Location = new Point(308, 212);
			label1.Name = "label1";
			label1.Size = new Size(14, 21);
			label1.TabIndex = 57;
			label1.Text = "|";
			// 
			// Inventario
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(807, 480);
			Controls.Add(dgvInventario);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Inventario";
			Text = "Inventario";
			Load += Inventario_Load;
			((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Label lblProducto;
        private ComboBox cmbProducto;
        private ComboBox cmbTipoMovimiento;
        private Label lblTipoMovimiento;
        private Label lblCantidad;
        private NumericUpDown numCantidad;
        private Label lblFecha;
        private DateTimePicker dtpFechaMovimiento;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private DataGridView dgvInventario;
		private Panel panel1;
		private Label label5;
		private PictureBox pictureBox1;
		private Label label6;
		private Label label1;
		private Label label7;
	}
}