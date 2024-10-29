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
        }
        private void Limpiar()
        {
            txtTotal.Clear();
            cmbCliente.SelectedIndex = -1;
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
        private void CargarVentas()
        {
            using (var context = new ApplicationDbContext())
            {
                var ventas = context.Ventas
                    .Select(v => new
                    {
                        v.IdVenta,
                        v.IdCliente,
                        v.FechaVenta,
                        v.Total
                    })
                    .ToList();
                dgvDetalleVenta.DataSource = ventas;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void dgvDetalleVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (isEditMode)
                {
                    var venta = context.Ventas.Find(ventaId);

                    if (venta != null)
                    {
                        venta.IdCliente = (int)cmbCliente.SelectedValue;
                        venta.FechaVenta = dtpFechaVenta.Value;
                        venta.Total = decimal.Parse(txtTotal.Text);

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
                        Total = decimal.Parse(txtTotal.Text)
                    };

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


        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaVenta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDetalleVenta.Rows[e.RowIndex];

                // Llenar los campos con los datos seleccionados
                cmbCliente.SelectedValue = row.Cells["IdCliente"].Value;
                dtpFechaVenta.Value = Convert.ToDateTime(row.Cells["FechaVenta"].Value);
                txtTotal.Text = row.Cells["Total"].Value.ToString();

                ventaId = Convert.ToInt32(row.Cells["IdVenta"].Value);
                isEditMode = true;
            }
        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
