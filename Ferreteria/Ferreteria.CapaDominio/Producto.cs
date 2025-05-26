using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class Producto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; } = 1;
        public DateTime FechaUltimaActualizacionPrecio { get; set; } = DateTime.Now;
        public int Stock { get; set; } = 1;
        public int StockMinimo { get; set; } = 5;  
        public bool Estado { get; set; } =true;

        public int SubcategoriaId { get; set; }
        public SubCategoria Subcategoria { get; set; }

        public int MarcaId { get; set; }
        public Marca Marca { get; set; }

        public int UnidadMedidaId { get; set; }
        public UnidadMedida UnidadMedida { get; set; }

        public List<Especificacion> Especificaciones { get; set; }
        public List<DetalleIngreso> DetallesIngreso { get; set; }
        public List<DetalleVenta> DetallesVenta { get; set; }
        public List<DetallePresupuesto> DetallesPresupuesto { get; set; }
    }
}
