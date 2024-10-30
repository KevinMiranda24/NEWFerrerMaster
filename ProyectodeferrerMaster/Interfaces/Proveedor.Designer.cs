namespace ProyectodeferrerMaster.Interfaces
{
    partial class Proveedor
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
			txtEmail = new TextBox();
			txtTelefono = new TextBox();
			txtDireccion = new TextBox();
			txtProveedor = new TextBox();
			btnEliminar = new Button();
			btnAgregar = new Button();
			dgvInfoProveedores = new DataGridView();
			lblEmail = new Label();
			lblTelefono = new Label();
			lblDireccion = new Label();
			label1 = new Label();
			panel1 = new Panel();
			label5 = new Label();
			pictureBox1 = new PictureBox();
			label6 = new Label();
			label7 = new Label();
			((System.ComponentModel.ISupportInitialize)dgvInfoProveedores).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// txtEmail
			// 
			txtEmail.BackColor = Color.White;
			txtEmail.BorderStyle = BorderStyle.FixedSingle;
			txtEmail.Location = new Point(474, 145);
			txtEmail.Margin = new Padding(3, 2, 3, 2);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(227, 23);
			txtEmail.TabIndex = 27;
			// 
			// txtTelefono
			// 
			txtTelefono.BackColor = Color.White;
			txtTelefono.BorderStyle = BorderStyle.FixedSingle;
			txtTelefono.Location = new Point(154, 140);
			txtTelefono.Margin = new Padding(3, 2, 3, 2);
			txtTelefono.Name = "txtTelefono";
			txtTelefono.Size = new Size(145, 23);
			txtTelefono.TabIndex = 26;
			// 
			// txtDireccion
			// 
			txtDireccion.BackColor = Color.White;
			txtDireccion.BorderStyle = BorderStyle.FixedSingle;
			txtDireccion.Location = new Point(501, 92);
			txtDireccion.Margin = new Padding(3, 2, 3, 2);
			txtDireccion.Name = "txtDireccion";
			txtDireccion.Size = new Size(200, 23);
			txtDireccion.TabIndex = 25;
			// 
			// txtProveedor
			// 
			txtProveedor.BackColor = Color.White;
			txtProveedor.BorderStyle = BorderStyle.FixedSingle;
			txtProveedor.Location = new Point(168, 90);
			txtProveedor.Margin = new Padding(3, 2, 3, 2);
			txtProveedor.Name = "txtProveedor";
			txtProveedor.Size = new Size(212, 23);
			txtProveedor.TabIndex = 24;
			// 
			// btnEliminar
			// 
			btnEliminar.BackColor = Color.FromArgb(231, 76, 60);
			btnEliminar.FlatStyle = FlatStyle.Flat;
			btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			btnEliminar.ForeColor = Color.White;
			btnEliminar.Location = new Point(290, 199);
			btnEliminar.Margin = new Padding(3, 2, 3, 2);
			btnEliminar.Name = "btnEliminar";
			btnEliminar.Size = new Size(98, 40);
			btnEliminar.TabIndex = 23;
			btnEliminar.Text = "Eliminar";
			btnEliminar.UseVisualStyleBackColor = false;
			btnEliminar.Click += btnEliminar_Click_1;
			// 
			// btnAgregar
			// 
			btnAgregar.BackColor = Color.FromArgb(52, 152, 219);
			btnAgregar.FlatStyle = FlatStyle.Flat;
			btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			btnAgregar.ForeColor = Color.White;
			btnAgregar.Location = new Point(164, 199);
			btnAgregar.Margin = new Padding(3, 2, 3, 2);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(100, 39);
			btnAgregar.TabIndex = 22;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = false;
			btnAgregar.Click += btnAgregar_Click;
			// 
			// dgvInfoProveedores
			// 
			dgvInfoProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvInfoProveedores.Location = new Point(11, 273);
			dgvInfoProveedores.Margin = new Padding(3, 2, 3, 2);
			dgvInfoProveedores.Name = "dgvInfoProveedores";
			dgvInfoProveedores.RowHeadersWidth = 51;
			dgvInfoProveedores.Size = new Size(638, 198);
			dgvInfoProveedores.TabIndex = 21;
			dgvInfoProveedores.CellContentClick += dgvInfoProveedores_CellContentClick_1;
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.BackColor = Color.FromArgb(189, 195, 199);
			lblEmail.Font = new Font("Segoe UI", 12F);
			lblEmail.ForeColor = Color.FromArgb(52, 73, 94);
			lblEmail.Location = new Point(420, 142);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(48, 21);
			lblEmail.TabIndex = 20;
			lblEmail.Text = "Email";
			// 
			// lblTelefono
			// 
			lblTelefono.AutoSize = true;
			lblTelefono.BackColor = Color.FromArgb(189, 195, 199);
			lblTelefono.Font = new Font("Segoe UI", 12F);
			lblTelefono.ForeColor = Color.FromArgb(52, 73, 94);
			lblTelefono.Location = new Point(80, 137);
			lblTelefono.Name = "lblTelefono";
			lblTelefono.Size = new Size(68, 21);
			lblTelefono.TabIndex = 19;
			lblTelefono.Text = "Teléfono";
			// 
			// lblDireccion
			// 
			lblDireccion.AutoSize = true;
			lblDireccion.BackColor = Color.FromArgb(189, 195, 199);
			lblDireccion.Font = new Font("Segoe UI", 12F);
			lblDireccion.ForeColor = Color.FromArgb(52, 73, 94);
			lblDireccion.Location = new Point(420, 92);
			lblDireccion.Name = "lblDireccion";
			lblDireccion.Size = new Size(75, 21);
			lblDireccion.TabIndex = 18;
			lblDireccion.Text = "Dirección";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.ForeColor = Color.FromArgb(52, 73, 94);
			label1.Location = new Point(80, 88);
			label1.Name = "label1";
			label1.Size = new Size(82, 21);
			label1.TabIndex = 17;
			label1.Text = "Proveedor";
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(189, 195, 199);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(txtDireccion);
			panel1.Controls.Add(lblDireccion);
			panel1.Controls.Add(txtEmail);
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(lblEmail);
			panel1.Controls.Add(txtTelefono);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(txtProveedor);
			panel1.Controls.Add(btnEliminar);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(lblTelefono);
			panel1.Controls.Add(btnAgregar);
			panel1.Location = new Point(11, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(719, 256);
			panel1.TabIndex = 28;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.FromArgb(44, 62, 80);
			label5.Location = new Point(254, 14);
			label5.Name = "label5";
			label5.Size = new Size(290, 32);
			label5.TabIndex = 53;
			label5.Text = "Gestión de Proveedores";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.provee;
			pictureBox1.Location = new Point(18, 13);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(64, 64);
			pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox1.TabIndex = 54;
			pictureBox1.TabStop = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 12F);
			label6.ForeColor = Color.FromArgb(52, 73, 94);
			label6.Location = new Point(80, 208);
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
			label7.Location = new Point(270, 208);
			label7.Name = "label7";
			label7.Size = new Size(14, 21);
			label7.TabIndex = 56;
			label7.Text = "|";
			// 
			// Proveedor
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(737, 477);
			Controls.Add(dgvInfoProveedores);
			Controls.Add(panel1);
			Name = "Proveedor";
			Text = "Proveedor";
			((System.ComponentModel.ISupportInitialize)dgvInfoProveedores).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtProveedor;
        private Button btnEliminar;
        private Button btnAgregar;
        private DataGridView dgvInfoProveedores;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblDireccion;
        private Label label1;
		private Panel panel1;
		private Label label5;
		private PictureBox pictureBox1;
		private Label label6;
		private Label label7;
	}
}