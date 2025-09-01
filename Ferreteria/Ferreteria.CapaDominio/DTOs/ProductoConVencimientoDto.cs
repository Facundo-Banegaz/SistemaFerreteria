using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Fecha Ingreso")]
        public DateTime FechaIngreso { get; set; }

        [DisplayName("Fecha Fabricacion")]
        public DateTime FechaFabricacion { get; set; }

        [DisplayName("Fecha Vencimiento")]
        public DateTime FechaVencimiento { get; set; }
        [DisplayName("Cantidad Lote")]
        public decimal CantidadLote { get; set; }
        [DisplayName("Cantidad Lote Vencida")]
        public decimal CantidadLoteVencida { get; set; }
        [DisplayName("Dias Restantes")]
        public int DiasRestantes { get; set; }
        public string Estado { get; set; }
    }
}
