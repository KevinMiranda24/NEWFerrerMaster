using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectodeferrerMaster.Modelos
{
    internal class DetalleDeVenta
    {

        public int IdDetalleDeVenta { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public int PrecioUnitario { get; set; }

        // Propiedad de navegación
        public Venta Venta { get; set; }
        public Producto Producto { get; set; }

        
    }

}
