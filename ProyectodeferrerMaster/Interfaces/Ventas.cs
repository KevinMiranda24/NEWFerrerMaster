using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using ProyectodeferrerMaster.Modelos;
using System.Data;
using System.IO;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using HtmlAgilityPack;

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

        //boton para crear reportes
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("dd_MM_yyyy") + "_ReporteGeneral.pdf";

            // Verificar que la plantilla HTML exista
            string paginaHtml = Properties.Resources.PlantillaVentas?.ToString();
            if (paginaHtml == null)
            {
                MessageBox.Show("La plantilla HTML no se encontró en los recursos.");
                return;
            }

            // Configurar valores para los marcadores de título, documento y fecha
            string titulo = "Todos los Clientes";  // Puedes cambiar este título según el tipo de reporte
            string numeroDocumento = "98765432";          // Ejemplo de número de documento
            string fechaActual = DateTime.Now.ToString("dd/MM/yyyy");

            // Reemplazar los marcadores en la plantilla HTML
            paginaHtml = paginaHtml.Replace("@Cliente", titulo);
            paginaHtml = paginaHtml.Replace("@Fecha", fechaActual);

            // Verificar que el DataGridView tenga filas
            if (dgvDetalleVenta.Rows == null || dgvDetalleVenta.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para generar el reporte.");
                return;
            }

            // Construir las filas del DataGridView en formato HTML
            string filasHtml = string.Empty;
            foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
            {
                if (!row.IsNewRow)
                {
                    filasHtml += "<tr>";
                    filasHtml += "<td>" + row.Cells["IdVenta"].Value?.ToString() + "</td>";
                    filasHtml += "<td>" + row.Cells["Cliente"].Value?.ToString() + "</td>";
                    filasHtml += "<td>" + row.Cells["Producto"].Value?.ToString() + "</td>";
                    filasHtml += "<td>" + row.Cells["Cantidad"].Value?.ToString() + "</td>";
                    filasHtml += "<td>" + row.Cells["Total"].Value?.ToString() + "</td>";
                    filasHtml += "</tr>";
                }
            }

            paginaHtml = paginaHtml.Replace("@Filas", filasHtml);

            // Configurar el flag para la etiqueta <td>
            HtmlAgilityPack.HtmlNode.ElementsFlags["td"] = HtmlAgilityPack.HtmlElementFlag.Closed;

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(paginaHtml);
            paginaHtml = doc.DocumentNode.OuterHtml;

            // Guardar el archivo PDF
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDocu = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDocu, stream);
                    pdfDocu.Open();

                    // Verificar que la imagen existe antes de usarla
                    byte[] imageBytes = (byte[])new ImageConverter().ConvertTo(Properties.Resources.FerreMaster, typeof(byte[]));

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imageBytes);
                    img.ScaleToFit(80, 60);
                    img.SetAbsolutePosition(pdfDocu.LeftMargin, pdfDocu.Top - 60);
                    pdfDocu.Add(img);

                    // Agregar el contenido HTML al PDF
                    try
                    {
                        using (StringReader sr = new StringReader(paginaHtml))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDocu, sr);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar el PDF: " + ex.Message);
                    }


                    pdfDocu.Close();
                    stream.Close();
                }
                MessageBox.Show("Reporte PDF generado exitosamente.");
            }
        }



        private void dgvDetalleVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
