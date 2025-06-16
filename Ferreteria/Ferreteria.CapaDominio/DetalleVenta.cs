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
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }

        public Producto Producto { get; set; }

        public Venta Venta { get; set; }

    }
}
