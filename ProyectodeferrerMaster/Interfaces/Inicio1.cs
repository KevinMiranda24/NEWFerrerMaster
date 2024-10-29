namespace ProyectodeferrerMaster.Interfaces
{
	public partial class Inicio1 : Form
    {

        // Constructor que recibe el token del login
        public Inicio1()
        {
            InitializeComponent();
        }

        // Carga inicial del formulario Inicio1
        private void Inicio1_Load(object sender, EventArgs e)
        {
            // Lógica para usar el token o mostrar alguna información
        }

        private void Inicio1_Load_1(object sender, EventArgs e)
        {

        }

        private void detalleUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Verificamos si el formulario ya está abierto
            UsuarioForm formUsuario = Application.OpenForms.OfType<UsuarioForm>().FirstOrDefault();

            if (formUsuario == null)
            {
                // Si no está abierto, lo instanciamos y lo mostramos
                formUsuario = new UsuarioForm();
                formUsuario.MdiParent = this;  // Asignamos el contenedor MDI (si tienes habilitada la propiedad IsMdiContainer)
                formUsuario.Show();
            }
            else
            {
                // Si ya está abierto, traemos el formulario al frente
                formUsuario.BringToFront();
            }
        }

        private void detallesDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario formDetalleVenta = Application.OpenForms.OfType<Inventario>().FirstOrDefault();

            if (formDetalleVenta == null)
            {
                // Si no está abierto, lo instanciamos y lo mostramos
                formDetalleVenta = new Inventario();
                formDetalleVenta.MdiParent = this;  // Asigna el formulario principal como contenedor MDI
                formDetalleVenta.Show();
            }
            else
            {
                // Si ya está abierto, traemos el formulario al frente
                formDetalleVenta.BringToFront();
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto formDetalleVenta = Application.OpenForms.OfType<FrmProducto>().FirstOrDefault();

            if (formDetalleVenta == null)
            {
                // Si no está abierto, lo instanciamos y lo mostramos
                formDetalleVenta = new FrmProducto();
                formDetalleVenta.MdiParent = this;  // Asigna el formulario principal como contenedor MDI
                formDetalleVenta.Show();
            }
            else
            {
                // Si ya está abierto, traemos el formulario al frente
                formDetalleVenta.BringToFront();
            }
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas formDetalleVenta = Application.OpenForms.OfType<Ventas>().FirstOrDefault();

            if (formDetalleVenta == null)
            {
                // Si no está abierto, lo instanciamos y lo mostramos
                formDetalleVenta = new Ventas();
                formDetalleVenta.MdiParent = this;  // Asigna el formulario principal como contenedor MDI
                formDetalleVenta.Show();
            }
            else
            {
                // Si ya está abierto, traemos el formulario al frente
                formDetalleVenta.BringToFront();
            }
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tiposDeCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategoria formUsuario = Application.OpenForms.OfType<FormCategoria>().FirstOrDefault();

            if (formUsuario == null)
            {
                // Si no está abierto, lo instanciamos y lo mostramos
                formUsuario = new FormCategoria();
                formUsuario.MdiParent = this;  // Asignamos el contenedor MDI (si tienes habilitada la propiedad IsMdiContainer)
                formUsuario.Show();
            }
            else
            {
                // Si ya está abierto, traemos el formulario al frente
                formUsuario.BringToFront();
            }
        }

        private void gestiónDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor formProveedor = Application.OpenForms.OfType<Proveedor>().FirstOrDefault();

            if (formProveedor == null)
            {
                // Si no está abierto, lo instanciamos y lo mostramos
                formProveedor = new Proveedor();
                formProveedor.MdiParent = this;  // Asignamos el contenedor MDI (si tienes habilitada la propiedad IsMdiContainer)
                formProveedor.Show();
            }
            else
            {
                // Si ya está abierto, traemos el formulario al frente
                formProveedor.BringToFront();
            }
        }
    }
}