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
            bntSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Location = new Point(112, 39);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(58, 15);
            lbCategoria.TabIndex = 0;
            lbCategoria.Text = "Categoria";
            // 
            // dgvCategoria
            // 
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(50, 186);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.Size = new Size(595, 187);
            dgvCategoria.TabIndex = 1;
            dgvCategoria.CellContentClick += dgvCategoria_CellContentClick;
            // 
            // bntAgregar
            // 
            bntAgregar.Location = new Point(169, 135);
            bntAgregar.Name = "bntAgregar";
            bntAgregar.Size = new Size(75, 23);
            bntAgregar.TabIndex = 2;
            bntAgregar.Text = "Agregar";
            bntAgregar.UseVisualStyleBackColor = true;
            bntAgregar.Click += bntAgregar_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(192, 36);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 3;
            txtCategoria.TextChanged += txtCategoria_TextChanged;
            // 
            // bntEliminar
            // 
            bntEliminar.Location = new Point(379, 135);
            bntEliminar.Name = "bntEliminar";
            bntEliminar.Size = new Size(75, 23);
            bntEliminar.TabIndex = 4;
            bntEliminar.Text = "Eliminar";
            bntEliminar.UseVisualStyleBackColor = true;
            bntEliminar.Click += bntEliminar_Click;
            // 
            // bntLimpiar
            // 
            bntLimpiar.Location = new Point(274, 135);
            bntLimpiar.Name = "bntLimpiar";
            bntLimpiar.Size = new Size(75, 23);
            bntLimpiar.TabIndex = 5;
            bntLimpiar.Text = "Limpiar";
            bntLimpiar.UseVisualStyleBackColor = true;
            bntLimpiar.Click += bntLimpiar_Click;
            // 
            // bntSalir
            // 
            bntSalir.BackColor = Color.Transparent;
            bntSalir.FlatStyle = FlatStyle.Popup;
            bntSalir.ForeColor = Color.Transparent;
            bntSalir.Image = Properties.Resources.borrar;
            bntSalir.Location = new Point(699, 39);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(53, 39);
            bntSalir.TabIndex = 51;
            bntSalir.UseVisualStyleBackColor = true;
            bntSalir.Click += bntSalir_Click;
            // 
            // FormCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bntSalir);
            Controls.Add(bntAgregar);
            Controls.Add(bntLimpiar);
            Controls.Add(bntEliminar);
            Controls.Add(txtCategoria);
            Controls.Add(dgvCategoria);
            Controls.Add(lbCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCategoria";
            Text = "FormCategoria";
            Load += FormCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
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
    }
}