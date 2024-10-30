namespace ProyectodeferrerMaster.Interfaces
{
    partial class Clientes
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
			txtDireccion = new TextBox();
			label4 = new Label();
			dgvClientes = new DataGridView();
			bntEliminar = new Button();
			bntLimpiar = new Button();
			txtTelefono = new TextBox();
			label3 = new Label();
			txtCorreo = new TextBox();
			label2 = new Label();
			bntGuardar = new Button();
			txtNombre = new TextBox();
			label1 = new Label();
			label5 = new Label();
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			bntSalir = new Button();
			((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
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
			bntSalir.Location = new Point(721, 3);
			bntSalir.Name = "bntSalir";
			bntSalir.Size = new Size(53, 39);
			bntSalir.TabIndex = 50;
			bntSalir.UseVisualStyleBackColor = true;
			bntSalir.Click += bntSalir_Click;
			// 
			// txtDireccion
			// 
			txtDireccion.BorderStyle = BorderStyle.FixedSingle;
			txtDireccion.Location = new Point(469, 144);
			txtDireccion.Name = "txtDireccion";
			txtDireccion.Size = new Size(246, 23);
			txtDireccion.TabIndex = 49;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.FromArgb(52, 73, 94);
			label4.Location = new Point(381, 141);
			label4.Name = "label4";
			label4.Size = new Size(75, 21);
			label4.TabIndex = 48;
			label4.Text = "Dirección";
			// 
			// dgvClientes
			// 
			dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvClientes.Location = new Point(10, 275);
			dgvClientes.Name = "dgvClientes";
			dgvClientes.RowHeadersWidth = 51;
			dgvClientes.Size = new Size(715, 229);
			dgvClientes.TabIndex = 46;
			dgvClientes.CellContentClick += dgvClientes_CellContentClick;
			// 
			// bntEliminar
			// 
			bntEliminar.BackColor = Color.FromArgb(231, 76, 60);
			bntEliminar.FlatStyle = FlatStyle.Flat;
			bntEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			bntEliminar.ForeColor = Color.White;
			bntEliminar.Location = new Point(350, 197);
			bntEliminar.Name = "bntEliminar";
			bntEliminar.Size = new Size(89, 38);
			bntEliminar.TabIndex = 45;
			bntEliminar.Text = "Eliminar";
			bntEliminar.UseVisualStyleBackColor = false;
			bntEliminar.Click += bntEliminar_Click;
			// 
			// bntLimpiar
			// 
			bntLimpiar.BackColor = Color.FromArgb(241, 196, 15);
			bntLimpiar.FlatStyle = FlatStyle.Flat;
			bntLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			bntLimpiar.ForeColor = Color.White;
			bntLimpiar.Location = new Point(226, 197);
			bntLimpiar.Name = "bntLimpiar";
			bntLimpiar.Size = new Size(91, 38);
			bntLimpiar.TabIndex = 44;
			bntLimpiar.Text = "Limpiar";
			bntLimpiar.UseVisualStyleBackColor = false;
			bntLimpiar.Click += bntLimpiar_Click;
			// 
			// txtTelefono
			// 
			txtTelefono.BorderStyle = BorderStyle.FixedSingle;
			txtTelefono.Location = new Point(90, 139);
			txtTelefono.Name = "txtTelefono";
			txtTelefono.Size = new Size(246, 23);
			txtTelefono.TabIndex = 43;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F);
			label3.ForeColor = Color.FromArgb(52, 73, 94);
			label3.Location = new Point(16, 136);
			label3.Name = "label3";
			label3.Size = new Size(68, 21);
			label3.TabIndex = 42;
			label3.Text = "Teléfono";
			// 
			// txtCorreo
			// 
			txtCorreo.BorderStyle = BorderStyle.FixedSingle;
			txtCorreo.Location = new Point(445, 88);
			txtCorreo.Name = "txtCorreo";
			txtCorreo.Size = new Size(246, 23);
			txtCorreo.TabIndex = 41;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.ForeColor = Color.FromArgb(52, 73, 94);
			label2.Location = new Point(381, 87);
			label2.Name = "label2";
			label2.Size = new Size(58, 21);
			label2.TabIndex = 40;
			label2.Text = "Correo";
			// 
			// bntGuardar
			// 
			bntGuardar.BackColor = Color.FromArgb(52, 152, 219);
			bntGuardar.FlatStyle = FlatStyle.Flat;
			bntGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			bntGuardar.ForeColor = Color.White;
			bntGuardar.Location = new Point(103, 197);
			bntGuardar.Name = "bntGuardar";
			bntGuardar.Size = new Size(97, 38);
			bntGuardar.TabIndex = 39;
			bntGuardar.Text = "Guardar";
			bntGuardar.UseVisualStyleBackColor = false;
			bntGuardar.Click += bntGuardar_Click;
			// 
			// txtNombre
			// 
			txtNombre.BackColor = Color.White;
			txtNombre.BorderStyle = BorderStyle.FixedSingle;
			txtNombre.Location = new Point(90, 87);
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(246, 23);
			txtNombre.TabIndex = 38;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.ForeColor = Color.FromArgb(52, 73, 94);
			label1.Location = new Point(16, 85);
			label1.Name = "label1";
			label1.Size = new Size(72, 21);
			label1.TabIndex = 37;
			label1.Text = "Nombre ";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.FromArgb(44, 62, 80);
			label5.Location = new Point(282, 15);
			label5.Name = "label5";
			label5.Size = new Size(241, 32);
			label5.TabIndex = 52;
			label5.Text = "Detalles del Cliente";
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(189, 195, 199);
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(label8);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(bntSalir);
			panel1.Controls.Add(bntEliminar);
			panel1.Controls.Add(bntLimpiar);
			panel1.Controls.Add(bntGuardar);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(txtDireccion);
			panel1.Controls.Add(txtNombre);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(txtCorreo);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(txtTelefono);
			panel1.Location = new Point(10, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(777, 257);
			panel1.TabIndex = 53;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.iccc;
			pictureBox1.Location = new Point(16, 15);
			pictureBox1.Margin = new Padding(0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(52, 52);
			pictureBox1.TabIndex = 56;
			pictureBox1.TabStop = false;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 12F);
			label8.ForeColor = Color.FromArgb(52, 73, 94);
			label8.Location = new Point(323, 206);
			label8.Name = "label8";
			label8.Size = new Size(14, 21);
			label8.TabIndex = 55;
			label8.Text = "|";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 12F);
			label7.ForeColor = Color.FromArgb(52, 73, 94);
			label7.Location = new Point(206, 206);
			label7.Name = "label7";
			label7.Size = new Size(14, 21);
			label7.TabIndex = 54;
			label7.Text = "|";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 12F);
			label6.ForeColor = Color.FromArgb(52, 73, 94);
			label6.Location = new Point(16, 204);
			label6.Name = "label6";
			label6.Size = new Size(78, 21);
			label6.TabIndex = 53;
			label6.Text = "Acciones: ";
			// 
			// Clientes
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(240, 242, 245);
			ClientSize = new Size(799, 541);
			Controls.Add(panel1);
			Controls.Add(dgvClientes);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Clientes";
			Text = "Clientes";
			Load += Clientes_Load;
			((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TextBox txtDireccion;
        private Label label4;
        private DataGridView dgvClientes;
        private Button bntEliminar;
        private Button bntLimpiar;
        private TextBox txtTelefono;
        private Label label3;
        private TextBox txtCorreo;
        private Label label2;
        private Button bntGuardar;
        private TextBox txtNombre;
        private Label label1;
		private Label label5;
		private Panel panel1;
		private Label label8;
		private Label label7;
		private Label label6;
		private PictureBox pictureBox1;
	}
}