using ProyectodeferrerMaster.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectodeferrerMaster.Modelos
{
    internal class Venta
    {
        public int IdVenta { get; set; }
        public int? IdCliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }

        // Relación con el modelo de Cliente
        public Cliente Cliente { get; set; }

    }
}


