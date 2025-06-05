using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class Producto
    {
        public int Id_Producto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; } = 1;
        public int Stock { get; set; } = 1;
        public int StockMinimo { get; set; } = 1;
        public string Descripcion { get; set; }
        public DateTime FechaUltimaActualizacionPrecio { get; set; } = DateTime.Now;
   
        public bool Estado { get; set; } =true;

 
        public Subcategoria Subcategoria { get; set; }

    
        public Marca Marca { get; set; }

   
        public UnidadMedida UnidadMedida { get; set; }

        public List<Especificacion> Especificaciones { get; set; }
        public List<DetalleIngreso> DetallesIngreso { get; set; }
        public List<DetalleVenta> DetallesVenta { get; set; }
        public List<DetallePresupuesto> DetallesPresupuesto { get; set; }
    }
}
