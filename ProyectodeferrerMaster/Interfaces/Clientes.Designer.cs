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
            bntSalir.Location = new Point(840, 16);
            bntSalir.Margin = new Padding(3, 4, 3, 4);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(61, 52);
            bntSalir.TabIndex = 50;
            bntSalir.UseVisualStyleBackColor = true;
            bntSalir.Click += bntSalir_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(37, 331);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(281, 27);
            txtDireccion.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 287);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 48;
            label4.Text = "Direccion";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(373, 269);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(470, 305);
            dgvClientes.TabIndex = 46;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // bntEliminar
            // 
            bntEliminar.BackColor = Color.FromArgb(255, 128, 128);
            bntEliminar.Location = new Point(122, 537);
            bntEliminar.Margin = new Padding(3, 4, 3, 4);
            bntEliminar.Name = "bntEliminar";
            bntEliminar.Size = new Size(102, 51);
            bntEliminar.TabIndex = 45;
            bntEliminar.Text = "Eliminar";
            bntEliminar.UseVisualStyleBackColor = false;
            bntEliminar.Click += bntEliminar_Click;
            // 
            // bntLimpiar
            // 
            bntLimpiar.BackColor = Color.FromArgb(192, 255, 192);
            bntLimpiar.Location = new Point(177, 463);
            bntLimpiar.Margin = new Padding(3, 4, 3, 4);
            bntLimpiar.Name = "bntLimpiar";
            bntLimpiar.Size = new Size(104, 51);
            bntLimpiar.TabIndex = 44;
            bntLimpiar.Text = "Limpiar";
            bntLimpiar.UseVisualStyleBackColor = false;
            bntLimpiar.Click += bntLimpiar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(37, 235);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(281, 27);
            txtTelefono.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 191);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 42;
            label3.Text = "Telefono";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(37, 141);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(281, 27);
            txtCorreo.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 105);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 40;
            label2.Text = "Correo";
            // 
            // bntGuardar
            // 
            bntGuardar.BackColor = Color.Silver;
            bntGuardar.Location = new Point(23, 463);
            bntGuardar.Margin = new Padding(3, 4, 3, 4);
            bntGuardar.Name = "bntGuardar";
            bntGuardar.Size = new Size(111, 51);
            bntGuardar.TabIndex = 39;
            bntGuardar.Text = "Guardar";
            bntGuardar.UseVisualStyleBackColor = false;
            bntGuardar.Click += bntGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(37, 53);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(281, 27);
            txtNombre.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 17);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 37;
            label1.Text = "Nombre ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(373, 87);
            label5.Name = "label5";
            label5.Size = new Size(303, 41);
            label5.TabIndex = 52;
            label5.Text = "Detalles del Clientes";
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label5);
            Controls.Add(bntSalir);
            Controls.Add(txtDireccion);
            Controls.Add(label4);
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
            Margin = new Padding(3, 4, 3, 4);
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
	}
}