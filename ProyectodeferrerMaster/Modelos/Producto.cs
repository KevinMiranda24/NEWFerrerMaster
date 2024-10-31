namespace ProyectodeferrerMaster.Modelos
{
    internal class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Stock { get; set; }
        public string CategoriaProducto { get; set; } 
        public int ProveedorId { get; set; }
       
        // Relación con el modelo de Proveedor
        public Proveedor Proveedor { get; set; }
    }
}
