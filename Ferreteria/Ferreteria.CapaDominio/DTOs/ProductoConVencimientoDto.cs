using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio.DTOs
{
    public class ProductoConVencimientoDto
    {
        public int Id_DetalleIngreso { get; set; }
        public int Id_Producto { get; set; }
        public string Codigo { get; set; }
        public string Producto { get; set; } 
        public decimal Stock { get; set; }
      
        public string Marca { get; set; }
        
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaFabricacion { get; set; }
        public DateTime FechaVencimiento { get; set; }

        public decimal CantidadLote { get; set; }
        public decimal CantidadLoteVencida { get; set; }
        public int DiasRestantes { get; set; }
        public string Estado { get; set; }
    }
}
