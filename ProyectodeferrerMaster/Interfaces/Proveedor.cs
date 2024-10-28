using ProyectodeferrerMaster.Modelos;

namespace ProyectodeferrerMaster.Interfaces
{
	public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
            CargarProveedores();
        }

        private bool isEditMode = false;
        private int proveedorId = 0;
        private string NombreProveedor;
        private string Direccion;
        private string Telefono;
        private string Email;

        private void CargarProveedores()
        {
            using (var context = new ApplicationDbContext())
            {
                var proveedores = context.Proveedores.ToList();
                dgvInfoProveedores.DataSource = proveedores;
            }
        }

        private void Limpiar()
        {
            // Deseleccionar cualquier fila en el DataGridView
            dgvInfoProveedores.ClearSelection();

            // También puedes limpiar otros controles de entrada si tienes alguno.
            // Por ejemplo, si tienes cuadros de texto para la entrada de datos:
            txtProveedor.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();


            // Restablecer el modo de edición y el ID del cliente
            isEditMode = false;
            proveedorId = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (isEditMode)
                {
                    // Modo de edición - Actualizar el cliente existente
                    var proveedor = context.Proveedores.Find(proveedorId);

                    if (proveedor != null)
                    {
                        proveedor.NombreProveedor = txtProveedor.Text;
                        proveedor.Direccion = txtDireccion.Text;
                        proveedor.Telefono = txtTelefono.Text;
                        proveedor.Email = txtEmail.Text;

                        context.SaveChanges();
                        MessageBox.Show("Cliente actualizado exitosamente.");
                    }
                }
                else
                {
                    // Modo de guardado - Crear un nuevo cliente
                    var nuevoProveedor = new ProyectodeferrerMaster.Modelos.Proveedor
                    {
                        NombreProveedor = txtProveedor.Text,
                        Direccion = txtDireccion.Text,
                        Telefono = txtTelefono.Text,
                        Email = txtEmail.Text
                    };

                    context.Proveedores.Add(nuevoProveedor);
                    context.SaveChanges();
                    MessageBox.Show("Cliente guardado exitosamente.");
                }

                // Restablecer el formulario y actualizar la tabla
                Limpiar();
                CargarProveedores();
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            // Verificar si un cliente ha sido seleccionado (clienteId > 0)
            if (proveedorId > 0)
            {
                try
                {
                    // Confirmar la eliminación
                    var confirmResult = MessageBox.Show("¿Estás seguro de que quieres eliminar este proveedor?",
                                                        "Confirmar eliminación",
                                                        MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        using (var context = new ApplicationDbContext())
                        {
                            // Buscar el cliente en la base de datos usando clienteId
                            var proveedor = context.Proveedores.Find(proveedorId);

                            if (proveedor != null)
                            {
                                // Eliminar el cliente
                                context.Proveedores.Remove(proveedor);

                                // Guardar los cambios
                                context.SaveChanges();

                                MessageBox.Show("Proveedor eliminado exitosamente.");

                                // Actualizar la tabla y limpiar los campos
                                CargarProveedores();
                                Limpiar();
                            }
                            else
                            {
                                MessageBox.Show("Proveedor no encontrado.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar el Proveedor: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un Proveedor para eliminar.");
            }
        }

        private void dgvInfoProveedores_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInfoProveedores.Rows[e.RowIndex];

                // Llenar los TextBox con los datos seleccionados
                txtProveedor.Text = row.Cells["NombreProveedor"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();

                // Guardar el ID del cliente seleccionado y activar el modo de edición
                proveedorId = Convert.ToInt32(row.Cells["IdProveedor"].Value);
                isEditMode = true;
            }
        }
    }
}
