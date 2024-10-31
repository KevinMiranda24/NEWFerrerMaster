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
            SuspendLayout();
            // 
            // lblReportes
            // 
            lblReportes.AutoSize = true;
            lblReportes.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblReportes.Location = new Point(400, 29);
            lblReportes.Name = "lblReportes";
            lblReportes.Size = new Size(121, 35);
            lblReportes.TabIndex = 0;
            lblReportes.Text = "Reportes";
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 571);
            Controls.Add(lblReportes);
            Name = "Reportes";
            Text = "Reportes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReportes;
    }
}