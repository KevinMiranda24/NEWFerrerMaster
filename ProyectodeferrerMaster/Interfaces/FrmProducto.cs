using ProyectodeferrerMaster.Modelos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using HtmlAgilityPack;

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
                var productos = context.Productos
                    .Join(context.Proveedores,
                        producto => producto.ProveedorId,
                        proveedor => proveedor.IdProveedor,
                        (producto, proveedor) => new
                        {
                            producto.IdProducto,
                            producto.NombreProducto,
                            producto.Descripcion,
                            producto.PrecioUnitario,
                            producto.Stock,
                            producto.CategoriaProducto,
                            NombreProveedor = proveedor.NombreProveedor // Traer solo el nombre del proveedor
                        })
                    .ToList();

                dgvProductos.DataSource = productos;
                dgvProductos.Columns["IdProducto"].Visible = false; // Ocultar columna de ID si es necesario
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
                cmbProveedor.DisplayMember = "NombreProveedor"; // Nombre a mostrar en el ComboBox
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



        private void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            txtDescripcion.Clear();
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

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {

                if (e.RowIndex >= 0) // Asegurarse de que no se haga clic en el encabezado
                {
                    DataGridViewRow row = this.dgvProductos.Rows[e.RowIndex];

                    // Cargar datos en los campos de texto para edición
                    productoId = (int)row.Cells["IdProducto"].Value; // Obtener el Id del producto
                    txtNombreProducto.Text = row.Cells["NombreProducto"].Value.ToString();
                    txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                    cmbCategoria.Text = row.Cells["CategoriaProducto"].Value.ToString();

                    // Establecer el proveedor seleccionado en el ComboBox utilizando el nombre del proveedor
                    cmbProveedor.Text = row.Cells["NombreProveedor"].Value.ToString();

                    isEditMode = true; // Cambiar a modo edición
                }

            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRepProductos_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("ddMMyyyy") + "_Productos.pdf"; // Usar formato de nombre de archivo sin barras

            // Cargar la plantilla HTML base para el reporte
            string paginahtml_text = Properties.Resources.Plantilla1.ToString();

            // Configurar valores para los marcadores de cliente, documento y fecha
            string cliente = "Cliente Ejemplo"; // Aquí puedes colocar el nombre del cliente real
            string documento = "12345678";      // Documento de ejemplo; reemplaza por el valor real
            string fecha = DateTime.Now.ToString("dd/MM/yyyy");

            // Reemplazar los marcadores en la plantilla
            paginahtml_text = paginahtml_text.Replace("@Cliente", cliente);
            paginahtml_text = paginahtml_text.Replace("@Documento", documento);
            paginahtml_text = paginahtml_text.Replace("@Fecha", fecha);

            // Construir las filas del DataGridView en formato HTML
            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (!row.IsNewRow) // Evitar la fila vacía al final
                {
                    filas += "<tr>"; // Comienza una nueva fila

                    // Llenar las celdas de acuerdo con los nombres de columna del DataGridView
                    filas += "<td>" + row.Cells["NombreProducto"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Descripcion"].Value?.ToString() + "</td>";
                    filas += "<td>" + row.Cells["PrecioUnitario"].Value?.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Stock"].Value?.ToString() + "</td>";
                    filas += "<td>" + row.Cells["CategoriaProducto"].Value?.ToString() + "</td>";
                    filas += "<td>" + row.Cells["NombreProveedor"].Value?.ToString() + "</td>";

                    filas += "</tr>"; // Cierra la fila
                }
            }

            // Reemplazar el marcador de filas en la plantilla HTML
            paginahtml_text = paginahtml_text.Replace("@Filas", filas);

            // Configurar el flag para la etiqueta <td>
            HtmlAgilityPack.HtmlNode.ElementsFlags["td"] = HtmlAgilityPack.HtmlElementFlag.Closed;

            // Crear un documento HTML
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(paginahtml_text); // Cargar el HTML

            // Convertir el HTML limpio de vuelta a cadena
            paginahtml_text = doc.DocumentNode.OuterHtml;

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(paginahtml_text))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }
                MessageBox.Show("Reporte PDF generado exitosamente.");
            }
        }
    }
}

