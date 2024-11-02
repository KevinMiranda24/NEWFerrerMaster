using Microsoft.Data.SqlClient;
using ProyectodeferrerMaster.Modelos;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectodeferrerMaster.Interfaces
{
    public partial class Reportes : Form
    {
        private DataGridView dgvDetalleVenta = new DataGridView();
        private DataGridView dgvProductos = new DataGridView();
        private DataGridView dgvClientes = new DataGridView();
        public Reportes()
        {
            InitializeComponent();
            InicializarDataGrids();
        }

        private void InicializarDataGrids()
        {
            dgvDetalleVenta.Columns.Add("IdCliente", "ID Cliente");
            dgvDetalleVenta.Columns.Add("IdProducto", "ID Producto");
            dgvDetalleVenta.Columns.Add("FechaVenta", "Fecha de Venta");
            dgvDetalleVenta.Columns.Add("Cantidad", "Cantidad");
            dgvDetalleVenta.Columns.Add("Total", "Total");
            dgvDetalleVenta.Rows.Add("1", "101", DateTime.Now.ToShortDateString(), "5", "50");
            dgvDetalleVenta.Rows.Add("2", "102", DateTime.Now.ToShortDateString(), "10", "100");

            // Configurar columnas y datos para dgvProductos
            dgvProductos.Columns.Add("IdProducto", "ID Producto");
            dgvProductos.Columns.Add("NombreProducto", "Nombre");
            dgvProductos.Columns.Add("Descripcion", "Descripción");
            dgvProductos.Columns.Add("CategoriaProducto", "Categoría");
            dgvProductos.Columns.Add("NombreProveedor", "Proveedor");
            dgvProductos.Columns.Add("Stock", "Stock");
            dgvProductos.Rows.Add("");
            dgvProductos.Rows.Add("");

            // Configurar columnas y datos para dgvClientes
            dgvClientes.Columns.Add("IdCliente", "ID Cliente");
            dgvClientes.Columns.Add("NombreCliente", "Nombre");
            dgvClientes.Columns.Add("Direccion", "Dirección");
            dgvClientes.Columns.Add("Telefono", "Teléfono");
            dgvClientes.Columns.Add("Email", "Correo");
            dgvClientes.Rows.Add("1", "Cliente A", "Dirección A", "555-1234", "clientea@example.com");
            dgvClientes.Rows.Add("2", "Cliente B", "Dirección B", "555-5678", "clienteb@example.com");
        }

        private DataTable ConvertirDataGridViewADataTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            // Crear las columnas en el DataTable
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                // Si el tipo de dato es nulo, asignar typeof(string) como valor predeterminado
                Type dataType = column.ValueType ?? typeof(string);
                dt.Columns.Add(column.Name, dataType);
            }

            // Añadir las filas al DataTable
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow) // Ignorar la fila nueva en blanco
                {
                    DataRow dr = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dr[cell.ColumnIndex] = cell.Value;
                    }
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }



        private void Reportes_Load(object sender, EventArgs e)
        {
            // Rellenar ComboBox en el constructor o en el evento Load del formulario
            cmbReportes.Items.Add("Compras");
            cmbReportes.Items.Add("Productos");
            cmbReportes.Items.Add("Empleados");
        }

        // Fuente de datos de ejemplo
        DataTable comprasTable = new DataTable();
        DataTable productosTable = new DataTable();
        DataTable empleadosTable = new DataTable();

        private void cmbReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar el DataGridView antes de cargar nuevos datos
            dgvreportes.DataSource = null;

            switch (cmbReportes.SelectedItem.ToString())
            {
                case "Compras":
                    dgvreportes.DataSource = ConvertirDataGridViewADataTable(dgvDetalleVenta);
                    break;

                case "Productos":
                    dgvreportes.DataSource = ConvertirDataGridViewADataTable(dgvProductos);
                    break;

                case "Empleados":
                    dgvreportes.DataSource = ConvertirDataGridViewADataTable(dgvClientes);
                    break;
            }
        }
    }
}