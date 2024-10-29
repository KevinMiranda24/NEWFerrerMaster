﻿using ProyectodeferrerMaster.Modelos;

namespace ProyectodeferrerMaster.Interfaces
{
	public partial class FrmProducto : Form
    {
        private bool isEditMode = false;
        private int productoId = 0;

        public FrmProducto()
        {
            InitializeComponent();
            CargarProductos();
            CargarComboBoxCategorias();
            CargarComboBoxProveedores();

        }

        // Método para cargar datos de productos en el DataGridView
        private void CargarProductos()
        {
            using (var context = new ApplicationDbContext())
            {
                var productos = context.Productos.ToList();
                dgvProductos.DataSource = productos;
            }
        }

        private void CargarComboBoxCategorias()
        {
            using (var context = new ApplicationDbContext())
            {
                // Obtener la lista de categorías desde la base de datos
                var categorias = context.Categorias
                    .Select(c => new { c.IdCategoria, c.NombreCategoria })
                    .ToList();

                // Configurar ComboBox
                cmbCategoria.DataSource = categorias;
                cmbCategoria.DisplayMember = "NombreCategoria"; // Nombre que se mostrará
                cmbCategoria.ValueMember = "IdCategoria"; // Valor de cada elemento
            }
        }
        private void CargarComboBoxProveedores()
        {
            using (var context = new ApplicationDbContext())
            {
                // Obtener todos los proveedores de la base de datos
                var proveedores = context.Proveedores
                    .Select(p => new { p.IdProveedor, p.NombreProveedor })
                    .ToList();

                // Asignar la lista de proveedores al ComboBox
                cmbProveedor.DataSource = proveedores;
                cmbProveedor.DisplayMember = "NombreProveedor"; // Nombre a mostrar
                cmbProveedor.ValueMember = "IdProveedor";       // Valor real que se almacena
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    // Validación de campos requeridos
                    if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) ||
                        string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                        string.IsNullOrWhiteSpace(txtUnidadMedida.Text) ||
                        cmbProveedor.SelectedValue == null || // Comprobar si el proveedor está seleccionado
                        cmbCategoria.SelectedValue == null) // Comprobar si la categoría está seleccionada
                    {
                        MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                        return; // Salir del método si hay campos vacíos
                    }

                    if (isEditMode)
                    {
                        // Modo de edición - Actualizar el producto existente
                        var producto = context.Productos.Find(productoId);

                        if (producto != null)
                        {
                            producto.NombreProducto = txtNombreProducto.Text;
                            producto.Descripcion = txtDescripcion.Text;
                            producto.UnidadMedida = txtUnidadMedida.Text;
                            producto.ProveedorId = (int)cmbProveedor.SelectedValue; // Obtener el Id del proveedor seleccionado
                            producto.CategoriaProducto = cmbCategoria.Text;

                            context.SaveChanges();
                            MessageBox.Show("Producto actualizado exitosamente.");
                        }
                    }
                    else
                    {
                        // Modo de guardado - Crear un nuevo producto
                        var nuevoProducto = new Producto
                        {
                            NombreProducto = txtNombreProducto.Text,
                            Descripcion = txtDescripcion.Text,
                            UnidadMedida = txtUnidadMedida.Text,
                            ProveedorId = (int)cmbProveedor.SelectedValue, // Obtener el Id del proveedor seleccionado
                            CategoriaProducto = cmbCategoria.Text
                        };

                        context.Productos.Add(nuevoProducto);
                        context.SaveChanges();
                        MessageBox.Show("Producto guardado exitosamente.");
                    }

                    // Restablecer el formulario y actualizar la tabla
                    LimpiarCampos();
                    CargarProductos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el producto: " + ex.Message);
                }
            }
        }


        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que no se haga clic en el encabezado
            {
                DataGridViewRow row = this.dgvProductos.Rows[e.RowIndex];
                // Cargar datos en los campos de texto para edición
                productoId = (int)row.Cells["IdProducto"].Value; // Obtener el Id del producto
                txtNombreProducto.Text = row.Cells["NombreProducto"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtUnidadMedida.Text = row.Cells["UnidadMedida"].Value.ToString();
                cmbProveedor.SelectedValue = row.Cells["ProveedorId"].Value; // Establecer el proveedor seleccionado
                cmbCategoria.Text = row.Cells["CategoriaProducto"].Value.ToString(); // Establecer la categoría
                isEditMode = true; // Cambiar a modo edición
            }
        }
        private void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            txtDescripcion.Clear();
            txtUnidadMedida.Clear();
            cmbProveedor.SelectedIndex = -1; // Limpiar la selección del ComboBox
            cmbCategoria.SelectedIndex = -1; // Limpiar la selección del ComboBox
            numStock.Value = 0; // Restablecer el valor de numStock
            numPrecioUnitario.Value = 0; // Restablecer el valor de numPrecioUnitario
        }
        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                var idProducto = (int)dgvProductos.SelectedRows[0].Cells["IdProducto"].Value; // Obtener el IdProducto de la fila seleccionada

                using (var context = new ApplicationDbContext())
                {
                    var producto = context.Productos.Find(idProducto);
                    if (producto != null)
                    {
                        context.Productos.Remove(producto); // Eliminar el producto
                        context.SaveChanges(); // Guardar cambios en la base de datos
                        MessageBox.Show("Producto eliminado correctamente.");
                        LimpiarCampos(); // Limpiar campos después de eliminar
                        CargarProductos(); // Recargar los productos
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.");
            }
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {

        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
