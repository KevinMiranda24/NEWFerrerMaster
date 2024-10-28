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
			label6 = new Label();
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
			button1 = new Button();
			bntSalir = new Button();
			((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
			SuspendLayout();
			// 
			// bntSalir
			// 
			bntSalir.BackColor = Color.Transparent;
			bntSalir.FlatStyle = FlatStyle.Popup;
			bntSalir.ForeColor = Color.Transparent;
			bntSalir.Image = Properties.Resources.borrar;
			bntSalir.Location = new Point(735, 12);
			bntSalir.Name = "bntSalir";
			bntSalir.Size = new Size(53, 39);
			bntSalir.TabIndex = 50;
			bntSalir.UseVisualStyleBackColor = true;
			bntSalir.Click += bntSalir_Click;
			// 
			// txtDireccion
			// 
			txtDireccion.Location = new Point(32, 248);
			txtDireccion.Name = "txtDireccion";
			txtDireccion.Size = new Size(246, 23);
			txtDireccion.TabIndex = 49;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(32, 215);
			label4.Name = "label4";
			label4.Size = new Size(57, 15);
			label4.TabIndex = 48;
			label4.Text = "Direccion";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.Location = new Point(326, 126);
			label6.Name = "label6";
			label6.Size = new Size(244, 32);
			label6.TabIndex = 47;
			label6.Text = "Detalles del Clientes";
			label6.Click += label6_Click;
			// 
			// dgvClientes
			// 
			dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvClientes.Location = new Point(326, 202);
			dgvClientes.Name = "dgvClientes";
			dgvClientes.Size = new Size(411, 229);
			dgvClientes.TabIndex = 46;
			dgvClientes.CellContentClick += dgvClientes_CellContentClick;
			// 
			// bntEliminar
			// 
			bntEliminar.BackColor = Color.FromArgb(255, 128, 128);
			bntEliminar.Location = new Point(107, 403);
			bntEliminar.Name = "bntEliminar";
			bntEliminar.Size = new Size(89, 38);
			bntEliminar.TabIndex = 45;
			bntEliminar.Text = "Eliminar";
			bntEliminar.UseVisualStyleBackColor = false;
			bntEliminar.Click += bntEliminar_Click;
			// 
			// bntLimpiar
			// 
			bntLimpiar.BackColor = Color.FromArgb(192, 255, 192);
			bntLimpiar.Location = new Point(155, 347);
			bntLimpiar.Name = "bntLimpiar";
			bntLimpiar.Size = new Size(91, 38);
			bntLimpiar.TabIndex = 44;
			bntLimpiar.Text = "Limpiar";
			bntLimpiar.UseVisualStyleBackColor = false;
			bntLimpiar.Click += bntLimpiar_Click;
			// 
			// txtTelefono
			// 
			txtTelefono.Location = new Point(32, 176);
			txtTelefono.Name = "txtTelefono";
			txtTelefono.Size = new Size(246, 23);
			txtTelefono.TabIndex = 43;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(32, 143);
			label3.Name = "label3";
			label3.Size = new Size(52, 15);
			label3.TabIndex = 42;
			label3.Text = "Telefono";
			// 
			// txtCorreo
			// 
			txtCorreo.Location = new Point(32, 106);
			txtCorreo.Name = "txtCorreo";
			txtCorreo.Size = new Size(246, 23);
			txtCorreo.TabIndex = 41;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(32, 79);
			label2.Name = "label2";
			label2.Size = new Size(43, 15);
			label2.TabIndex = 40;
			label2.Text = "Correo";
			// 
			// bntGuardar
			// 
			bntGuardar.BackColor = Color.Silver;
			bntGuardar.Location = new Point(20, 347);
			bntGuardar.Name = "bntGuardar";
			bntGuardar.Size = new Size(97, 38);
			bntGuardar.TabIndex = 39;
			bntGuardar.Text = "Guardar";
			bntGuardar.UseVisualStyleBackColor = false;
			bntGuardar.Click += bntGuardar_Click;
			// 
			// txtNombre
			// 
			txtNombre.Location = new Point(32, 40);
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(246, 23);
			txtNombre.TabIndex = 38;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(32, 13);
			label1.Name = "label1";
			label1.Size = new Size(54, 15);
			label1.TabIndex = 37;
			label1.Text = "Nombre ";
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(192, 255, 192);
			button1.Location = new Point(155, 303);
			button1.Name = "button1";
			button1.Size = new Size(91, 38);
			button1.TabIndex = 51;
			button1.Text = "Limpiar";
			button1.UseVisualStyleBackColor = false;
			// 
			// Clientes
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(bntSalir);
			Controls.Add(txtDireccion);
			Controls.Add(label4);
			Controls.Add(label6);
			Controls.Add(dgvClientes);
			Controls.Add(bntEliminar);
			Controls.Add(bntLimpiar);
			Controls.Add(txtTelefono);
			Controls.Add(label3);
			Controls.Add(txtCorreo);
			Controls.Add(label2);
			Controls.Add(bntGuardar);
			Controls.Add(txtNombre);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Clientes";
			Text = "Clientes";
			Load += Clientes_Load;
			((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtDireccion;
        private Label label4;
        private Label label6;
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
		private Button button1;
	}
}