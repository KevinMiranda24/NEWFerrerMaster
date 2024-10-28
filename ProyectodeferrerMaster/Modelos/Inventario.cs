using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectodeferrerMaster.Modelos
{
    internal class Inventario
    {
        public int IdInventario { get; set; }
        public int IdProducto { get; set; }
        public string TipoMovimiento { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaMovimiento { get; set; }

        // Relación con el modelo de Producto
        public Producto Producto { get; set; }
    }
}
