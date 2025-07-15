using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class DetalleIngreso
    {
        public int Id_DetalleIngreso { get; set; }
        public Producto Producto { get; set; }
        public decimal Cantidad { get; set; }

        [DisplayName("Precio Compra")]
        public decimal PrecioCompra { get; set; }

       
        public DateTime? FechaFabricacion { get; set; } 

        public DateTime? FechaVencimiento { get; set; }

        [DisplayName("Porcentaje Ganancia")]
        public decimal PorcentajeGanancia { get; set; }

        
        public decimal Subtotal { get; set; }
  

        
        public Ingreso Ingreso { get; set; }

     
    }
}
