using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public decimal Precio { get; set; }
        public decimal Stock { get; set; } = 0;
        [DisplayName("Stock Minimo")]
        public decimal StockMinimo { get; set; } = 0;
        public string Descripcion { get; set; }      
        public bool Estado { get; set; } = true;
        [DisplayName("Requiere Vencimiento")]
        public bool RequiereVencimiento { get; set; }= false;

        [DisplayName("Actualizar Precio Automaticamente")]
        public bool ActualizarPrecioAutomaticamente { get; set; } = false;



        [DisplayName("Fecha Ultima Actualizacion Precio")]

        public DateTime FechaUltimaActualizacionPrecio { get; set; } = DateTime.Now;

    
        public Subcategoria Subcategoria { get; set; }

    
        public Marca Marca { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

        public bool PermiteDecimales => UnidadMedida?.PermiteDecimales ?? false;

        [DisplayName("Unidad Medida")]
        public UnidadMedida UnidadMedida { get; set; }

        public List<Especificacion> Especificaciones { get; set; }
        public List<DetalleIngreso> DetallesIngreso { get; set; }
        public List<DetalleVenta> DetallesVenta { get; set; }
        public List<DetallePresupuesto> DetallesPresupuesto { get; set; }
    }
}
