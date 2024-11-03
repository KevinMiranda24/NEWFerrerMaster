namespace ProyectodeferrerMaster.Interfaces
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            bntSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
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
            bntSalir.Location = new Point(624, 7);
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
            lblCliente.Location = new Point(124, 79);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 21);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(188, 81);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(175, 23);
            cmbCliente.TabIndex = 1;
            // 
            // lblFechaVenta
            // 
            lblFechaVenta.AutoSize = true;
            lblFechaVenta.BackColor = Color.FromArgb(189, 195, 199);
            lblFechaVenta.Font = new Font("Segoe UI", 12F);
            lblFechaVenta.ForeColor = Color.FromArgb(52, 73, 94);
            lblFechaVenta.Location = new Point(19, 135);
            lblFechaVenta.Name = "lblFechaVenta";
            lblFechaVenta.Size = new Size(113, 21);
            lblFechaVenta.TabIndex = 2;
            lblFechaVenta.Text = "Fecha de venta";
            // 
            // dtpFechaVenta
            // 
            dtpFechaVenta.Location = new Point(138, 135);
            dtpFechaVenta.Name = "dtpFechaVenta";
            dtpFechaVenta.Size = new Size(214, 23);
            dtpFechaVenta.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.FromArgb(189, 195, 199);
            lblTotal.Font = new Font("Segoe UI", 12F);
            lblTotal.ForeColor = Color.FromArgb(52, 73, 94);
            lblTotal.Location = new Point(19, 182);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 21);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.White;
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Location = new Point(67, 182);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(52, 152, 219);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardar.Location = new Point(96, 228);
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
            btnLimpiar.Location = new Point(359, 228);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(114, 43);
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
            btnEliminar.Location = new Point(226, 228);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(107, 43);
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
            dgvDetalleVenta.Location = new Point(2, 277);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.Size = new Size(707, 178);
            dgvDetalleVenta.TabIndex = 10;
            dgvDetalleVenta.CellClick += dgvDetalleVenta_CellClick;
            dgvDetalleVenta.CellContentClick += dgvDetalleVenta_CellContentClick;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(482, 81);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(178, 23);
            cmbProducto.TabIndex = 52;
            // 
            // Producto
            // 
            Producto.AutoSize = true;
            Producto.BackColor = Color.FromArgb(189, 195, 199);
            Producto.Font = new Font("Segoe UI", 12F);
            Producto.ForeColor = Color.FromArgb(52, 73, 94);
            Producto.Location = new Point(403, 83);
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
            label1.Location = new Point(403, 135);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 54;
            label1.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(481, 133);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 55;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(189, 195, 199);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbProducto);
            panel1.Controls.Add(Producto);
            panel1.Controls.Add(cmbCliente);
            panel1.Controls.Add(lblCliente);
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(bntSalir);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(dtpFechaVenta);
            panel1.Controls.Add(lblFechaVenta);
            panel1.Location = new Point(11, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(698, 217);
            panel1.TabIndex = 56;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ventas;
            pictureBox1.Location = new Point(19, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label5.Location = new Point(261, 20);
            label5.Name = "label5";
            label5.Size = new Size(225, 32);
            label5.TabIndex = 53;
            label5.Text = "Gestión de Ventas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.FromArgb(52, 73, 94);
            label6.Location = new Point(12, 238);
            label6.Name = "label6";
            label6.Size = new Size(78, 21);
            label6.TabIndex = 57;
            label6.Text = "Acciones: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.FromArgb(52, 73, 94);
            label8.Location = new Point(206, 239);
            label8.Name = "label8";
            label8.Size = new Size(14, 21);
            label8.TabIndex = 58;
            label8.Text = "|";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(52, 73, 94);
            label2.Location = new Point(339, 239);
            label2.Name = "label2";
            label2.Size = new Size(14, 21);
            label2.TabIndex = 59;
            label2.Text = "|";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(503, 228);
            button1.Name = "button1";
            button1.Size = new Size(145, 43);
            button1.TabIndex = 60;
            button1.Text = "Generar Reporte";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(483, 239);
            label3.Name = "label3";
            label3.Size = new Size(14, 21);
            label3.TabIndex = 61;
            label3.Text = "|";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 469);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(dgvDetalleVenta);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ventas";
            Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
		private Panel panel1;
		private Label label5;
		private PictureBox pictureBox1;
		private Label label6;
		private Label label8;
		private Label label2;
        private Button button1;
        private Label label3;
    }
}