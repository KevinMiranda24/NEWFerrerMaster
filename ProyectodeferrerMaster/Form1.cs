using ProyectodeferrerMaster.Interfaces;
using ProyectodeferrerMaster.Modelos;

namespace ProyectodeferrerMaster
{
    public partial class Form1 : Form
    {
        private readonly Services services; // Instancia del servicio para manejar login



        // Constructor que recibe el servicio inyectado
        public Form1()
        {
            InitializeComponent();
            var dbContext = new ApplicationDbContext();
            services = new Services(dbContext);// Inicializa correctamente tu DbContext
                                               // Pasa el DbContext a tu servicio
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Si necesitas realizar alguna acción al cargar el formulario, puedes hacerlo aquí.
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario
            string usuario = txtUsuario.Text;
            string password = txtContraseña.Text;

            try
            {
                if (services.Login(usuario, password))
                {
                    MessageBox.Show("Login exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    var inicioForm = new Inicio1();
                    inicioForm.Dock = DockStyle.Fill;
                    inicioForm.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Evento para cerrar la aplicación
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario
        }

        // Eventos para capturar el cambio de texto en el campo de usuario
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            // Aquí puedes agregar alguna validación mientras el usuario escribe
        }

        // Eventos para capturar el cambio de texto en el campo de contraseña
        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            // Aquí puedes agregar alguna validación mientras el usuario escribe
        }

        // Eventos de los labels por si necesitas agregar alguna acción
        private void lblUsuario_Click(object sender, EventArgs e)
        {
        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
        }
    }
}