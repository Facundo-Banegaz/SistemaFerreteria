using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class DetalleVenta
    {
        public int Id_DetalleVenta { get; set; }
        public Producto Producto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }

    

        public decimal Subtotal { get; set; }
        public Venta Venta { get; set; }

    }
}
