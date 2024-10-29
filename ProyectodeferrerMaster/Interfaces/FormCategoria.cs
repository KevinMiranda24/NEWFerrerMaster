using ProyectodeferrerMaster.Modelos;

namespace ProyectodeferrerMaster.Interfaces
{
	public partial class FormCategoria : Form
    {

        private bool isEditMode = false;
        private int categoriaId = 0;

        public FormCategoria()
        {
            InitializeComponent();
            CargarCategorias();
        }
        private void LimpiarCampos()
        {
            txtCategoria.Clear();
            isEditMode = false;
            categoriaId = 0;
        }


        private void CargarCategorias()
        {
            using (var context = new ApplicationDbContext())
            {
                var categoria = context.Categorias.ToList();
                dgvCategoria.DataSource = categoria;
            }
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bntAgregar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (isEditMode)
                {
                    // Editar categoría existente
                    var categoria = context.Categorias.Find(categoriaId);
                    if (categoria != null)
                    {
                        categoria.NombreCategoria = txtCategoria.Text;
                        context.SaveChanges();
                        MessageBox.Show("Categoría actualizada exitosamente.");
                    }
                }
                else
                {
                    // Guardar nueva categoría
                    var nuevaCategoria = new Categoria
                    {
                        NombreCategoria = txtCategoria.Text
                    };

                    context.Categorias.Add(nuevaCategoria);
                    context.SaveChanges();
                    MessageBox.Show("Categoría guardada exitosamente.");
                }

                // Limpiar campos y recargar datos
                LimpiarCampos();
                CargarCategorias();
            }

        }

        private void bntEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.SelectedRows.Count > 0)
            {
                var idCategoria = (int)dgvCategoria.SelectedRows[0].Cells["IdCategoria"].Value;
                using (var context = new ApplicationDbContext())
                {
                    var categoria = context.Categorias.Find(idCategoria);
                    if (categoria != null)
                    {
                        context.Categorias.Remove(categoria);
                        context.SaveChanges();
                        MessageBox.Show("Categoría eliminada correctamente.");
                        CargarCategorias();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una categoría para eliminar.");
            }
        }


        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {

        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
