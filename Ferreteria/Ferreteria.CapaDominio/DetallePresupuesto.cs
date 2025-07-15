using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class DetallePresupuesto
    {
        public int Id_DetallePresupuesto { get; set; }


        public Presupuesto Presupuesto { get; set; }


        public Producto Producto { get; set; }

        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
