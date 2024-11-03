namespace ProyectodeferrerMaster.Interfaces
{
    partial class UsuarioForm
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
            label1 = new Label();
            txtNombre = new TextBox();
            bntGuardar = new Button();
            txtCorreo = new TextBox();
            label2 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            bntLimpiar = new Button();
            bntEliminar = new Button();
            dgvClientes = new DataGridView();
            txtDireccion = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            bntSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bntSalir
            // 
            bntSalir.BackColor = Color.Transparent;
            bntSalir.FlatStyle = FlatStyle.Popup;
            bntSalir.ForeColor = Color.Transparent;
            bntSalir.Image = Properties.Resources.borrar;
            bntSalir.Location = new Point(705, 3);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(53, 39);
            bntSalir.TabIndex = 51;
            bntSalir.UseVisualStyleBackColor = true;
            bntSalir.Click += bntSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(189, 195, 199);
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(52, 73, 94);
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre ";
            label1.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(24, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(246, 23);
            txtNombre.TabIndex = 1;
            // 
            // bntGuardar
            // 
            bntGuardar.BackColor = Color.FromArgb(52, 152, 219);
            bntGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bntGuardar.ForeColor = Color.White;
            bntGuardar.Location = new Point(100, 301);
            bntGuardar.Name = "bntGuardar";
            bntGuardar.Size = new Size(97, 38);
            bntGuardar.TabIndex = 3;
            bntGuardar.Text = "Guardar";
            bntGuardar.UseVisualStyleBackColor = false;
            bntGuardar.Click += bntGuardar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.White;
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Location = new Point(24, 121);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(246, 23);
            txtCorreo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(189, 195, 199);
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(52, 73, 94);
            label2.Location = new Point(24, 94);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 4;
            label2.Text = "Correo";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.White;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Location = new Point(24, 191);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(246, 23);
            txtTelefono.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(189, 195, 199);
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.FromArgb(52, 73, 94);
            label3.Location = new Point(24, 158);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 6;
            label3.Text = "Teléfono";
            // 
            // bntLimpiar
            // 
            bntLimpiar.BackColor = Color.FromArgb(241, 196, 15);
            bntLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bntLimpiar.ForeColor = Color.White;
            bntLimpiar.Location = new Point(338, 301);
            bntLimpiar.Name = "bntLimpiar";
            bntLimpiar.Size = new Size(91, 38);
            bntLimpiar.TabIndex = 8;
            bntLimpiar.Text = "Limpiar";
            bntLimpiar.UseVisualStyleBackColor = false;
            bntLimpiar.Click += bntLimpiar_Click;
            // 
            // bntEliminar
            // 
            bntEliminar.BackColor = Color.FromArgb(231, 76, 60);
            bntEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bntEliminar.ForeColor = Color.White;
            bntEliminar.Location = new Point(223, 301);
            bntEliminar.Name = "bntEliminar";
            bntEliminar.Size = new Size(89, 38);
            bntEliminar.TabIndex = 9;
            bntEliminar.Text = "Eliminar";
            bntEliminar.UseVisualStyleBackColor = false;
            bntEliminar.Click += bntEliminar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(268, 48);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(481, 237);
            dgvClientes.TabIndex = 13;
            dgvClientes.CellClick += dgvClientes_CellClick;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.White;
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Location = new Point(24, 263);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(246, 23);
            txtDireccion.TabIndex = 16;
            txtDireccion.TextChanged += txtDirecccion_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(189, 195, 199);
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.FromArgb(52, 73, 94);
            label4.Location = new Point(24, 230);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 15;
            label4.Text = "Dirección";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(189, 195, 199);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(bntSalir);
            panel1.Controls.Add(bntGuardar);
            panel1.Controls.Add(bntLimpiar);
            panel1.Controls.Add(dgvClientes);
            panel1.Controls.Add(bntEliminar);
            panel1.Location = new Point(8, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(761, 368);
            panel1.TabIndex = 52;
            panel1.Paint += panel1_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.FromArgb(52, 73, 94);
            label8.Location = new Point(318, 308);
            label8.Name = "label8";
            label8.Size = new Size(14, 21);
            label8.TabIndex = 56;
            label8.Text = "|";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.FromArgb(52, 73, 94);
            label7.Location = new Point(203, 308);
            label7.Name = "label7";
            label7.Size = new Size(14, 21);
            label7.TabIndex = 55;
            label7.Text = "|";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.FromArgb(52, 73, 94);
            label6.Location = new Point(16, 308);
            label6.Name = "label6";
            label6.Size = new Size(78, 21);
            label6.TabIndex = 54;
            label6.Text = "Acciones: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label5.Location = new Point(346, 3);
            label5.Name = "label5";
            label5.Size = new Size(266, 32);
            label5.TabIndex = 53;
            label5.Text = "Detalles de Empleado";
            // 
            // UsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 402);
            Controls.Add(txtDireccion);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtCorreo);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UsuarioForm";
            Text = "UsuarioForm";
            Load += UsuarioForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private ComboBox cmbRol;
        private Button bntGuardar;
        private TextBox txtCorreo;
        private Label label2;
        private TextBox txtTelefono;
        private Label label3;
        private Button bntLimpiar;
        private Button bntEliminar;
        private DataGridView dgvClientes;
        private TextBox txtDireccion;
        private Label label4;
        private ComboBox cmbEstado;
        private Label label5;
		private Panel panel1;
		private Label label6;
		private Label label8;
		private Label label7;
	}
}