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
            label6 = new Label();
            txtDireccion = new TextBox();
            label4 = new Label();
            bntSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre ";
            label1.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(24, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(246, 23);
            txtNombre.TabIndex = 1;
            // 
            // bntGuardar
            // 
            bntGuardar.BackColor = Color.Silver;
            bntGuardar.Location = new Point(12, 362);
            bntGuardar.Name = "bntGuardar";
            bntGuardar.Size = new Size(97, 38);
            bntGuardar.TabIndex = 3;
            bntGuardar.Text = "Guardar";
            bntGuardar.UseVisualStyleBackColor = false;
            bntGuardar.Click += bntGuardar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(24, 121);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(246, 23);
            txtCorreo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 94);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Correo";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(24, 191);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(246, 23);
            txtTelefono.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 158);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 6;
            label3.Text = "Telefono";
            // 
            // bntLimpiar
            // 
            bntLimpiar.BackColor = Color.FromArgb(192, 255, 192);
            bntLimpiar.Location = new Point(147, 362);
            bntLimpiar.Name = "bntLimpiar";
            bntLimpiar.Size = new Size(91, 38);
            bntLimpiar.TabIndex = 8;
            bntLimpiar.Text = "Limpiar";
            bntLimpiar.UseVisualStyleBackColor = false;
            bntLimpiar.Click += bntLimpiar_Click;
            // 
            // bntEliminar
            // 
            bntEliminar.BackColor = Color.FromArgb(255, 128, 128);
            bntEliminar.Location = new Point(77, 422);
            bntEliminar.Name = "bntEliminar";
            bntEliminar.Size = new Size(89, 38);
            bntEliminar.TabIndex = 9;
            bntEliminar.Text = "Eliminar";
            bntEliminar.UseVisualStyleBackColor = false;
            bntEliminar.Click += bntEliminar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(318, 217);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(411, 229);
            dgvClientes.TabIndex = 13;
            dgvClientes.CellClick += dgvClientes_CellClick;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(318, 141);
            label6.Name = "label6";
            label6.Size = new Size(244, 32);
            label6.TabIndex = 14;
            label6.Text = "Detalles del Clientes";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(24, 263);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(246, 23);
            txtDireccion.TabIndex = 16;
            txtDireccion.TextChanged += txtDirecccion_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 230);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 15;
            label4.Text = "Direccion";
            // 
            // bntSalir
            // 
            bntSalir.BackColor = Color.Transparent;
            bntSalir.FlatStyle = FlatStyle.Popup;
            bntSalir.ForeColor = Color.Transparent;
            bntSalir.Image = Properties.Resources.borrar;
            bntSalir.Location = new Point(653, 16);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(53, 39);
            bntSalir.TabIndex = 51;
            bntSalir.UseVisualStyleBackColor = true;
            bntSalir.Click += bntSalir_Click;
            // 
            // UsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 472);
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UsuarioForm";
            Text = "UsuarioForm";
            Load += UsuarioForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
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
        private Label label6;
        private TextBox txtDireccion;
        private Label label4;
        private ComboBox cmbEstado;
        private Label label5;
    }
}