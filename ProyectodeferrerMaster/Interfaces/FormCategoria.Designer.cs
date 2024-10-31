namespace ProyectodeferrerMaster.Interfaces
{
    partial class FormCategoria
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
            lbCategoria = new Label();
            dgvCategoria = new DataGridView();
            bntAgregar = new Button();
            txtCategoria = new TextBox();
            bntEliminar = new Button();
            bntLimpiar = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label7 = new Label();
            label6 = new Label();
            bntSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bntSalir
            // 
            bntSalir.BackColor = Color.Transparent;
            bntSalir.FlatStyle = FlatStyle.Popup;
            bntSalir.ForeColor = Color.Transparent;
            bntSalir.Image = Properties.Resources.borrar;
            bntSalir.Location = new Point(651, 6);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(53, 39);
            bntSalir.TabIndex = 51;
            bntSalir.UseVisualStyleBackColor = true;
            bntSalir.Click += bntSalir_Click;
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.BackColor = Color.FromArgb(189, 195, 199);
            lbCategoria.Font = new Font("Segoe UI", 12F);
            lbCategoria.ForeColor = Color.FromArgb(52, 73, 94);
            lbCategoria.Location = new Point(117, 36);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(77, 21);
            lbCategoria.TabIndex = 0;
            lbCategoria.Text = "Categoria";
            // 
            // dgvCategoria
            // 
            dgvCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategoria.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(12, 220);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.Size = new Size(595, 187);
            dgvCategoria.TabIndex = 1;
            dgvCategoria.CellContentClick += dgvCategoria_CellContentClick;
            // 
            // bntAgregar
            // 
            bntAgregar.BackColor = Color.FromArgb(52, 152, 219);
            bntAgregar.FlatStyle = FlatStyle.Flat;
            bntAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bntAgregar.ForeColor = Color.White;
            bntAgregar.Location = new Point(87, 154);
            bntAgregar.Name = "bntAgregar";
            bntAgregar.Size = new Size(90, 48);
            bntAgregar.TabIndex = 2;
            bntAgregar.Text = "Agregar";
            bntAgregar.UseVisualStyleBackColor = false;
            bntAgregar.Click += bntAgregar_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = Color.White;
            txtCategoria.BorderStyle = BorderStyle.FixedSingle;
            txtCategoria.Location = new Point(217, 39);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 3;
            txtCategoria.TextChanged += txtCategoria_TextChanged;
            // 
            // bntEliminar
            // 
            bntEliminar.BackColor = Color.FromArgb(231, 76, 60);
            bntEliminar.FlatStyle = FlatStyle.Flat;
            bntEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bntEliminar.ForeColor = Color.White;
            bntEliminar.Location = new Point(314, 154);
            bntEliminar.Name = "bntEliminar";
            bntEliminar.Size = new Size(101, 53);
            bntEliminar.TabIndex = 4;
            bntEliminar.Text = "Eliminar";
            bntEliminar.UseVisualStyleBackColor = false;
            bntEliminar.Click += bntEliminar_Click;
            // 
            // bntLimpiar
            // 
            bntLimpiar.BackColor = Color.FromArgb(241, 196, 15);
            bntLimpiar.FlatStyle = FlatStyle.Flat;
            bntLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bntLimpiar.ForeColor = Color.White;
            bntLimpiar.Location = new Point(203, 155);
            bntLimpiar.Name = "bntLimpiar";
            bntLimpiar.Size = new Size(85, 48);
            bntLimpiar.TabIndex = 5;
            bntLimpiar.Text = "Limpiar";
            bntLimpiar.UseVisualStyleBackColor = false;
            bntLimpiar.Click += bntLimpiar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(189, 195, 199);
            panel1.Controls.Add(bntEliminar);
            panel1.Controls.Add(bntLimpiar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(bntSalir);
            panel1.Controls.Add(bntAgregar);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(707, 202);
            panel1.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(52, 73, 94);
            label1.Location = new Point(294, 169);
            label1.Name = "label1";
            label1.Size = new Size(14, 21);
            label1.TabIndex = 56;
            label1.Text = "|";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.FromArgb(52, 73, 94);
            label7.Location = new Point(183, 169);
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
            label6.Location = new Point(3, 169);
            label6.Name = "label6";
            label6.Size = new Size(78, 21);
            label6.TabIndex = 54;
            label6.Text = "Acciones: ";
            // 
            // FormCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 439);
            Controls.Add(txtCategoria);
            Controls.Add(dgvCategoria);
            Controls.Add(lbCategoria);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCategoria";
            Text = "FormCategoria";
            Load += FormCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCategoria;
        private DataGridView dgvCategoria;
        private Button bntAgregar;
        private TextBox txtCategoria;
        private Button bntEliminar;
        private Button bntLimpiar;
		private Panel panel1;
		private Label label6;
		private Label label1;
		private Label label7;
	}
}