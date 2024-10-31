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
            bntSalir.Location = new Point(824, 4);
            bntSalir.Margin = new Padding(3, 4, 3, 4);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(61, 52);
            bntSalir.TabIndex = 50;
            bntSalir.UseVisualStyleBackColor = true;
            bntSalir.Click += bntSalir_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Location = new Point(536, 192);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(281, 27);
            txtDireccion.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(52, 73, 94);
            label4.Location = new Point(435, 188);
            label4.Name = "label4";
            label4.Size = new Size(94, 28);
            label4.TabIndex = 48;
            label4.Text = "Dirección";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(11, 367);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(817, 305);
            dgvClientes.TabIndex = 46;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // bntEliminar
            // 
            bntEliminar.BackColor = Color.FromArgb(231, 76, 60);
            bntEliminar.FlatStyle = FlatStyle.Flat;
            bntEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntEliminar.ForeColor = Color.White;
            bntEliminar.Location = new Point(400, 263);
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
            bntLimpiar.BackColor = Color.FromArgb(241, 196, 15);
            bntLimpiar.FlatStyle = FlatStyle.Flat;
            bntLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntLimpiar.ForeColor = Color.White;
            bntLimpiar.Location = new Point(258, 263);
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
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Location = new Point(103, 185);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(281, 27);
            txtTelefono.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.FromArgb(52, 73, 94);
            label3.Location = new Point(18, 181);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 42;
            label3.Text = "Teléfono";
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Location = new Point(509, 117);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(281, 27);
            txtCorreo.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(52, 73, 94);
            label2.Location = new Point(435, 116);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 40;
            label2.Text = "Correo";
            // 
            // bntGuardar
            // 
            bntGuardar.BackColor = Color.FromArgb(52, 152, 219);
            bntGuardar.FlatStyle = FlatStyle.Flat;
            bntGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntGuardar.ForeColor = Color.White;
            bntGuardar.Location = new Point(118, 263);
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
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(103, 116);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(281, 27);
            txtNombre.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(52, 73, 94);
            label1.Location = new Point(18, 113);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 37;
            label1.Text = "Nombre ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label5.Location = new Point(322, 20);
            label5.Name = "label5";
            label5.Size = new Size(292, 41);
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
            panel1.Location = new Point(11, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 343);
            panel1.TabIndex = 53;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iccc;
            pictureBox1.Location = new Point(18, 20);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 69);
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.FromArgb(52, 73, 94);
            label8.Location = new Point(369, 275);
            label8.Name = "label8";
            label8.Size = new Size(17, 28);
            label8.TabIndex = 55;
            label8.Text = "|";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.FromArgb(52, 73, 94);
            label7.Location = new Point(235, 275);
            label7.Name = "label7";
            label7.Size = new Size(17, 28);
            label7.TabIndex = 54;
            label7.Text = "|";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.FromArgb(52, 73, 94);
            label6.Location = new Point(18, 272);
            label6.Name = "label6";
            label6.Size = new Size(98, 28);
            label6.TabIndex = 53;
            label6.Text = "Acciones: ";
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(913, 721);
            Controls.Add(panel1);
            Controls.Add(dgvClientes);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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