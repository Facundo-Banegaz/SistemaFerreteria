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
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioCompra { get; set; }

        public decimal PorcentajeGanancia { get; set; }


        public decimal Subtotal { get; set; }
  

        
        public Ingreso Ingreso { get; set; }

     
    }
}
