using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class DetalleIngreso
    {
        public int Id_DetalleIngreso { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioCompra { get; set; }

        ////public decimal Subtotal => Cantidad * PrecioCompra;
        public Producto Producto { get; set; }

        
        public Ingreso Ingreso { get; set; }

     
    }
}
