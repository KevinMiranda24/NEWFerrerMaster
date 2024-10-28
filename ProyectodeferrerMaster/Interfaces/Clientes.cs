using ProyectodeferrerMaster.Modelos;

namespace ProyectodeferrerMaster.Interfaces
{
	public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            CargarClientes();
        }
        private bool isEditMode = false;
        private int clienteId = 0;

        private void CargarClientes()
        {
            using (var context = new ApplicationDbContext())
            {
                var clientes = context.Clientes.ToList();
                dgvClientes.DataSource = clientes;
            }
        }
        private void Limpiar()
        {
            // Deseleccionar cualquier fila en el DataGridView
            dgvClientes.ClearSelection();

            // También puedes limpiar otros controles de entrada si tienes alguno.
            // Por ejemplo, si tienes cuadros de texto para la entrada de datos:
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();


            // Restablecer el modo de edición y el ID del cliente
            isEditMode = false;
            clienteId = 0;
        }



        private void bntEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si un cliente ha sido seleccionado (clienteId > 0)
            if (clienteId > 0)
            {
                try
                {
                    // Confirmar la eliminación
                    var confirmResult = MessageBox.Show("¿Estás seguro de que quieres eliminar este cliente?",
                                                        "Confirmar eliminación",
                                                        MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        using (var context = new ApplicationDbContext())
                        {
                            // Buscar el cliente en la base de datos usando clienteId
                            var cliente = context.Clientes.Find(clienteId);

                            if (cliente != null)
                            {
                                // Eliminar el cliente
                                context.Clientes.Remove(cliente);

                                // Guardar los cambios
                                context.SaveChanges();

                                MessageBox.Show("Cliente eliminado exitosamente.");

                                // Actualizar la tabla y limpiar los campos
                                CargarClientes();
                                Limpiar();
                            }
                            else
                            {
                                MessageBox.Show("Cliente no encontrado.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar el cliente: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
            }
        }

        private void bntGuardar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (isEditMode)
                {
                    // Modo de edición - Actualizar el cliente existente
                    var cliente = context.Clientes.Find(clienteId);

                    if (cliente != null)
                    {
                        cliente.NombreCliente = txtNombre.Text;
                        cliente.Direccion = txtDireccion.Text;
                        cliente.Telefono = txtTelefono.Text;
                        cliente.Email = txtCorreo.Text;

                        context.SaveChanges();
                        MessageBox.Show("Cliente actualizado exitosamente.");
                    }
                }
                else
                {
                    // Modo de guardado - Crear un nuevo cliente
                    var nuevoCliente = new Cliente
                    {
                        NombreCliente = txtNombre.Text,
                        Direccion = txtDireccion.Text,
                        Telefono = txtTelefono.Text,
                        Email = txtCorreo.Text
                    };

                    context.Clientes.Add(nuevoCliente);
                    context.SaveChanges();
                    MessageBox.Show("Cliente guardado exitosamente.");
                }

                // Restablecer el formulario y actualizar la tabla
                Limpiar();
                CargarClientes();
            }
        }

        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                // Llenar los TextBox con los datos seleccionados
                txtNombre.Text = row.Cells["NombreCliente"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = row.Cells["Email"].Value.ToString();

                // Guardar el ID del cliente seleccionado y activar el modo de edición
                clienteId = Convert.ToInt32(row.Cells["IdCliente"].Value);
                isEditMode = true;
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
