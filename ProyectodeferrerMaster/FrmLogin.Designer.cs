namespace ProyectodeferrerMaster
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Button button2;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
			lblUsuario = new Label();
			txtUsuario = new TextBox();
			txtContraseña = new TextBox();
			lblContraseña = new Label();
			btnIngresar = new Button();
			panel1 = new Panel();
			label3 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			button2 = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// button2
			// 
			button2.BackColor = Color.Transparent;
			button2.FlatStyle = FlatStyle.Popup;
			button2.ForeColor = Color.Transparent;
			button2.Image = Properties.Resources.borrar;
			button2.Location = new Point(593, 21);
			button2.Name = "button2";
			button2.Size = new Size(53, 39);
			button2.TabIndex = 6;
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// lblUsuario
			// 
			lblUsuario.AutoSize = true;
			lblUsuario.BackColor = Color.Transparent;
			lblUsuario.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
			lblUsuario.ForeColor = Color.FromArgb(236, 239, 241);
			lblUsuario.Location = new Point(151, 201);
			lblUsuario.Name = "lblUsuario";
			lblUsuario.Size = new Size(145, 37);
			lblUsuario.TabIndex = 0;
			lblUsuario.Text = "Usuario:";
			lblUsuario.Click += lblUsuario_Click;
			// 
			// txtUsuario
			// 
			txtUsuario.Location = new Point(317, 209);
			txtUsuario.Multiline = true;
			txtUsuario.Name = "txtUsuario";
			txtUsuario.Size = new Size(182, 29);
			txtUsuario.TabIndex = 1;
			txtUsuario.TextChanged += txtUsuario_TextChanged;
			// 
			// txtContraseña
			// 
			txtContraseña.Location = new Point(317, 268);
			txtContraseña.Multiline = true;
			txtContraseña.Name = "txtContraseña";
			txtContraseña.PasswordChar = '*';
			txtContraseña.Size = new Size(182, 29);
			txtContraseña.TabIndex = 3;
			txtContraseña.TextChanged += txtContraseña_TextChanged;
			// 
			// lblContraseña
			// 
			lblContraseña.AutoSize = true;
			lblContraseña.BackColor = Color.Transparent;
			lblContraseña.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
			lblContraseña.ForeColor = Color.FromArgb(236, 239, 241);
			lblContraseña.Location = new Point(93, 268);
			lblContraseña.Name = "lblContraseña";
			lblContraseña.Size = new Size(203, 37);
			lblContraseña.TabIndex = 2;
			lblContraseña.Text = "Contraseña:";
			lblContraseña.Click += lblContraseña_Click;
			// 
			// btnIngresar
			// 
			btnIngresar.BackColor = Color.FromArgb(241, 196, 15);
			btnIngresar.BackgroundImageLayout = ImageLayout.None;
			btnIngresar.FlatStyle = FlatStyle.Flat;
			btnIngresar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
			btnIngresar.ForeColor = Color.FromArgb(44, 62, 80);
			btnIngresar.Location = new Point(260, 333);
			btnIngresar.Name = "btnIngresar";
			btnIngresar.Size = new Size(141, 50);
			btnIngresar.TabIndex = 4;
			btnIngresar.Text = " Iniciar";
			btnIngresar.UseVisualStyleBackColor = false;
			btnIngresar.Click += btnIngresar_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.Transparent;
			panel1.Controls.Add(label3);
			panel1.Location = new Point(90, 39);
			panel1.Name = "panel1";
			panel1.Size = new Size(461, 100);
			panel1.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label3.ForeColor = SystemColors.ButtonHighlight;
			label3.Location = new Point(23, 12);
			label3.Name = "label3";
			label3.Size = new Size(381, 73);
			label3.TabIndex = 6;
			label3.Text = "FerreMaster";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Italic);
			label1.ForeColor = Color.FromArgb(241, 196, 15);
			label1.Location = new Point(229, 153);
			label1.Name = "label1";
			label1.Size = new Size(212, 37);
			label1.TabIndex = 7;
			label1.Text = "Bienvenido/a";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(517, 268);
			pictureBox1.Margin = new Padding(3, 2, 3, 2);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(34, 28);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 8;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(517, 268);
			pictureBox2.Margin = new Padding(3, 2, 3, 2);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(34, 28);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 9;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			BackgroundImage = Properties.Resources._6843484;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(658, 450);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Controls.Add(label1);
			Controls.Add(button2);
			Controls.Add(panel1);
			Controls.Add(btnIngresar);
			Controls.Add(txtContraseña);
			Controls.Add(lblContraseña);
			Controls.Add(txtUsuario);
			Controls.Add(lblUsuario);
			FormBorderStyle = FormBorderStyle.None;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Form1";
			ShowIcon = false;
			Load += Form1_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label lblContraseña;
        private Button btnIngresar;
        private Panel panel1;
        private Label label3;
        private Button button2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
