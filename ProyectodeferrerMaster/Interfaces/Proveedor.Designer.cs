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
            lblGestorProveedores = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInfoProveedores).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(692, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 27;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(488, 136);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 26;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(293, 136);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 27);
            txtDireccion.TabIndex = 25;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(82, 136);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(125, 27);
            txtProveedor.TabIndex = 24;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(612, 242);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(179, 242);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvInfoProveedores
            // 
            dgvInfoProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfoProveedores.Location = new Point(104, 300);
            dgvInfoProveedores.Name = "dgvInfoProveedores";
            dgvInfoProveedores.RowHeadersWidth = 51;
            dgvInfoProveedores.Size = new Size(729, 264);
            dgvInfoProveedores.TabIndex = 21;
            dgvInfoProveedores.CellContentClick += dgvInfoProveedores_CellContentClick_1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(731, 103);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 20;
            lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(519, 103);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 19;
            lblTelefono.Text = "Teléfono";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(320, 103);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 18;
            lblDireccion.Text = "Dirección";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 103);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 17;
            label1.Text = "Proveedor";
            // 
            // lblGestorProveedores
            // 
            lblGestorProveedores.AutoSize = true;
            lblGestorProveedores.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestorProveedores.Location = new Point(366, 36);
            lblGestorProveedores.Name = "lblGestorProveedores";
            lblGestorProveedores.Size = new Size(205, 25);
            lblGestorProveedores.TabIndex = 16;
            lblGestorProveedores.Text = "Gestor de Proveedores";
            // 
            // Proveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtProveedor);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvInfoProveedores);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefono);
            Controls.Add(lblDireccion);
            Controls.Add(label1);
            Controls.Add(lblGestorProveedores);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Proveedor";
            Text = "Proveedor";
            ((System.ComponentModel.ISupportInitialize)dgvInfoProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblGestorProveedores;
    }
}