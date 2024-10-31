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
            label1 = new Label();
            label7 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
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
            bntSalir.Location = new Point(826, 4);
            bntSalir.Margin = new Padding(3, 4, 3, 4);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(61, 52);
            bntSalir.TabIndex = 52;
            bntSalir.UseVisualStyleBackColor = true;
            bntSalir.Click += bntSalir_Click;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 12F);
            lblProducto.ForeColor = Color.FromArgb(52, 73, 94);
            lblProducto.Location = new Point(25, 125);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(93, 28);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(115, 128);
            cmbProducto.Margin = new Padding(3, 4, 3, 4);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(274, 28);
            cmbProducto.TabIndex = 1;
            // 
            // cmbTipoMovimiento
            // 
            cmbTipoMovimiento.FormattingEnabled = true;
            cmbTipoMovimiento.Location = new Point(174, 192);
            cmbTipoMovimiento.Margin = new Padding(3, 4, 3, 4);
            cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            cmbTipoMovimiento.Size = new Size(138, 28);
            cmbTipoMovimiento.TabIndex = 3;
            // 
            // lblTipoMovimiento
            // 
            lblTipoMovimiento.AutoSize = true;
            lblTipoMovimiento.Font = new Font("Segoe UI", 12F);
            lblTipoMovimiento.ForeColor = Color.FromArgb(52, 73, 94);
            lblTipoMovimiento.Location = new Point(25, 189);
            lblTipoMovimiento.Name = "lblTipoMovimiento";
            lblTipoMovimiento.Size = new Size(158, 28);
            lblTipoMovimiento.TabIndex = 2;
            lblTipoMovimiento.Text = "TipoMovimiento";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 12F);
            lblCantidad.ForeColor = Color.FromArgb(52, 73, 94);
            lblCantidad.Location = new Point(365, 189);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(91, 28);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad";
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(454, 192);
            numCantidad.Margin = new Padding(3, 4, 3, 4);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(137, 27);
            numCantidad.TabIndex = 5;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.FromArgb(189, 195, 199);
            lblFecha.Font = new Font("Segoe UI", 12F);
            lblFecha.ForeColor = Color.FromArgb(52, 73, 94);
            lblFecha.Location = new Point(427, 128);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(62, 28);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha";
            // 
            // dtpFechaMovimiento
            // 
            dtpFechaMovimiento.Location = new Point(491, 128);
            dtpFechaMovimiento.Margin = new Padding(3, 4, 3, 4);
            dtpFechaMovimiento.Name = "dtpFechaMovimiento";
            dtpFechaMovimiento.Size = new Size(228, 27);
            dtpFechaMovimiento.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(52, 152, 219);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(126, 272);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(97, 49);
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
            btnLimpiar.Location = new Point(263, 273);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(103, 49);
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
            btnEliminar.Location = new Point(403, 272);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 49);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(10, 380);
            dgvInventario.Margin = new Padding(3, 4, 3, 4);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.Size = new Size(897, 237);
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
            panel1.Location = new Point(10, 19);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(897, 353);
            panel1.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(52, 73, 94);
            label1.Location = new Point(372, 283);
            label1.Name = "label1";
            label1.Size = new Size(17, 28);
            label1.TabIndex = 57;
            label1.Text = "|";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.FromArgb(52, 73, 94);
            label7.Location = new Point(229, 283);
            label7.Name = "label7";
            label7.Size = new Size(17, 28);
            label7.TabIndex = 56;
            label7.Text = "|";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.FromArgb(52, 73, 94);
            label6.Location = new Point(25, 283);
            label6.Name = "label6";
            label6.Size = new Size(98, 28);
            label6.TabIndex = 55;
            label6.Text = "Acciones: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.inventrio;
            pictureBox1.Location = new Point(25, 24);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label5.Location = new Point(302, 24);
            label5.Name = "label5";
            label5.Size = new Size(338, 41);
            label5.TabIndex = 53;
            label5.Text = "Inventario FerreMaster";
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 640);
            Controls.Add(dgvInventario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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