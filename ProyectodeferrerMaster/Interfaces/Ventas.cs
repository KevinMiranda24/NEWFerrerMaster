using ProyectodeferrerMaster.Modelos;
using System.Data;

namespace ProyectodeferrerMaster.Interfaces
{
    public partial class Ventas : Form
    {
        private bool isEditMode = false;
        private int ventaId = 0;

        public Ventas()
        {
            InitializeComponent();
            CargarVentas();
            CargarClientes();
            CargarProductos();
        }
        private void Limpiar()
        {
            txtTotal.Clear();
            cmbCliente.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;
            txtCantidad.Clear();
            dtpFechaVenta.Value = DateTime.Now;
            isEditMode = false;
            ventaId = 0;
        }
        private void CargarClientes()
        {
            using (var context = new ApplicationDbContext())
            {
                var clientes = context.Clientes.ToList();
                cmbCliente.DataSource = clientes;
                cmbCliente.DisplayMember = "NombreCliente"; // Muestra el nombre del cliente
                cmbCliente.ValueMember = "IdCliente"; // Usa el ID como valor
            }
        }

        private void CargarProductos()
        {
            using (var context = new ApplicationDbContext())
            {
                var productos = context.Productos.ToList();
                cmbProducto.DataSource = productos;
                cmbProducto.DisplayMember = "NombreProducto";
                cmbProducto.ValueMember = "IdProducto";
            }
        }

        private void CargarVentas()
        {
            using (var context = new ApplicationDbContext())
            {
				var ventas = context.Ventas
			.Join(context.Clientes,
				  v => v.IdCliente,
				  c => c.IdCliente,
				  (v, c) => new { Venta = v, Cliente = c })
			.Join(context.Productos,
				  vc => vc.Venta.IdProducto,
				  p => p.IdProducto,
				  (vc, p) => new
				  {
					  vc.Venta.IdVenta,
					  Cliente = vc.Cliente.NombreCliente,  // Nombre del cliente
					  Producto = p.NombreProducto,         // Nombre del producto
					  vc.Venta.Cantidad,
					  vc.Venta.Total,
					  vc.Venta.FechaVenta
				  })
			.ToList();

				dgvDetalleVenta.DataSource = ventas;

				// Cambiar los encabezados de las columnas si es necesario
				dgvDetalleVenta.Columns["Cliente"].HeaderText = "Nombre del Cliente";
				dgvDetalleVenta.Columns["Producto"].HeaderText = "Nombre del Producto";
			}
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                int idProducto = (int)cmbProducto.SelectedValue;
                int cantidad = int.Parse(txtCantidad.Text);

                // Obtener el producto y verificar el stock
                var producto = context.Productos.Find(idProducto);
                if (producto == null)
                {
                    MessageBox.Show("Producto no encontrado.");
                    return;
                }

                if (producto.Stock < cantidad)
                {
                    MessageBox.Show("Stock insuficiente para completar la venta.");
                    return;
                }

                if (isEditMode)
                {
                    var venta = context.Ventas.Find(ventaId);
                    if (venta != null)
                    {
                        venta.IdCliente = (int)cmbCliente.SelectedValue;
                        venta.FechaVenta = dtpFechaVenta.Value;
                        venta.Total = decimal.Parse(txtTotal.Text);
                        venta.IdProducto = idProducto;
                        venta.Cantidad = cantidad;
                        venta.PrecioUnitario = (int)producto.PrecioUnitario;

                        // Reducir el stock del producto
                        producto.Stock -= cantidad;

                        context.SaveChanges();
                        MessageBox.Show("Venta actualizada exitosamente.");
                    }
                }
                else
                {
                    var nuevaVenta = new Venta
                    {
                        IdCliente = (int)cmbCliente.SelectedValue,
                        FechaVenta = dtpFechaVenta.Value,
                        Total = decimal.Parse(txtTotal.Text),
                        IdProducto = idProducto,
                        Cantidad = cantidad,
                        PrecioUnitario = (int)producto.PrecioUnitario
                    };

                    // Reducir el stock del producto
                    producto.Stock -= cantidad;

                    context.Ventas.Add(nuevaVenta);
                    context.SaveChanges();
                    MessageBox.Show("Venta guardada exitosamente.");
                }

                Limpiar();
                CargarVentas();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ventaId > 0)
            {
                try
                {
                    var confirmResult = MessageBox.Show("¿Estás seguro de que quieres eliminar esta venta?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        using (var context = new ApplicationDbContext())
                        {
                            var venta = context.Ventas.Find(ventaId);

                            if (venta != null)
                            {
                                context.Ventas.Remove(venta);
                                context.SaveChanges();
                                MessageBox.Show("Venta eliminada exitosamente.");
                                CargarVentas();
                                Limpiar();
                            }
                            else
                            {
                                MessageBox.Show("Venta no encontrada.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar la venta: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una venta para eliminar.");
            }
        }

        private void dgvDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDetalleVenta.Rows[e.RowIndex];

                // Llenar los campos con los datos seleccionados
                cmbCliente.SelectedValue = row.Cells["IdCliente"].Value;
                cmbProducto.SelectedValue = row.Cells["IdProducto"].Value;
                dtpFechaVenta.Value = Convert.ToDateTime(row.Cells["FechaVenta"].Value);
                txtCantidad.Text = row.Cells["Cantidad"].Value.ToString();
                txtTotal.Text = row.Cells["Total"].Value.ToString();

                ventaId = Convert.ToInt32(row.Cells["IdVenta"].Value);
                isEditMode = true;
            }
        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
