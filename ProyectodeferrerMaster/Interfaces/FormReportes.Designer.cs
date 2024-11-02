
namespace ProyectodeferrerMaster.Interfaces
{
    partial class Reportes
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
            lblReportes = new Label();
            btnRepCompras = new Button();
            btnRepProductos = new Button();
            btnRepUsuarios = new Button();
            btnRepGeneral = new Button();
            dgvreportes = new DataGridView();
            cmbReportes = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvreportes).BeginInit();
            SuspendLayout();
            // 
            // lblReportes
            // 
            lblReportes.AutoSize = true;
            lblReportes.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblReportes.Location = new Point(350, 22);
            lblReportes.Name = "lblReportes";
            lblReportes.Size = new Size(97, 28);
            lblReportes.TabIndex = 0;
            lblReportes.Text = "Reportes";
            // 
            // btnRepCompras
            // 
            btnRepCompras.Location = new Point(80, 90);
            btnRepCompras.Name = "btnRepCompras";
            btnRepCompras.Size = new Size(118, 46);
            btnRepCompras.TabIndex = 1;
            btnRepCompras.Text = "Reporte Compras";
            btnRepCompras.UseVisualStyleBackColor = true;
            // 
            // btnRepProductos
            // 
            btnRepProductos.Location = new Point(246, 90);
            btnRepProductos.Name = "btnRepProductos";
            btnRepProductos.Size = new Size(132, 46);
            btnRepProductos.TabIndex = 2;
            btnRepProductos.Text = "Reporte Productos";
            btnRepProductos.UseVisualStyleBackColor = true;
            // 
            // btnRepUsuarios
            // 
            btnRepUsuarios.Location = new Point(422, 90);
            btnRepUsuarios.Name = "btnRepUsuarios";
            btnRepUsuarios.Size = new Size(120, 46);
            btnRepUsuarios.TabIndex = 3;
            btnRepUsuarios.Text = "Reporte Usuarios";
            btnRepUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnRepGeneral
            // 
            btnRepGeneral.Location = new Point(600, 90);
            btnRepGeneral.Name = "btnRepGeneral";
            btnRepGeneral.Size = new Size(111, 46);
            btnRepGeneral.TabIndex = 4;
            btnRepGeneral.Text = "Reporte General";
            btnRepGeneral.UseVisualStyleBackColor = true;
            // 
            // dgvreportes
            // 
            dgvreportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvreportes.Location = new Point(32, 249);
            dgvreportes.Name = "dgvreportes";
            dgvreportes.Size = new Size(738, 150);
            dgvreportes.TabIndex = 5;
            // 
            // cmbReportes
            // 
            cmbReportes.FormattingEnabled = true;
            cmbReportes.Location = new Point(339, 183);
            cmbReportes.Name = "cmbReportes";
            cmbReportes.Size = new Size(121, 23);
            cmbReportes.TabIndex = 6;
            cmbReportes.SelectedIndexChanged += cmbReportes_SelectedIndexChanged;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 428);
            Controls.Add(cmbReportes);
            Controls.Add(dgvreportes);
            Controls.Add(btnRepGeneral);
            Controls.Add(btnRepUsuarios);
            Controls.Add(btnRepProductos);
            Controls.Add(btnRepCompras);
            Controls.Add(lblReportes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Reportes";
            Text = "Reportes";
            Load += Reportes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvreportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dgvTablasReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblReportes;
        private Button btnRepCompras;
        private Button btnRepProductos;
        private Button btnRepUsuarios;
        private Button btnRepGeneral;
        private DataGridView dgvreportes;
        private ComboBox cmbReportes;
    }
}