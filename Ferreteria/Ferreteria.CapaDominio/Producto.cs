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
        public int Stock { get; set; } = 0;
        [DisplayName("Stock Minimo")]
        public int StockMinimo { get; set; } = 0;
        public string Descripcion { get; set; }      
        public bool Estado { get; set; } = true;
        [DisplayName("Requiere Vencimiento")]
        public bool RequiereVencimiento { get; set; }= false;
        [DisplayName("Actualizar Precio Automaticamente")]
        public bool ActualizarPrecioAutomaticamente { get; set; } = true;
        [DisplayName("En Promocion")]
        public bool EnPromocion { get; set; } = false;
        [DisplayName("Porcentaje Descuento Promocion")]
        public decimal PorcentajeDescuentoPromocion { get; set; } = 0;



        [DisplayName("Fecha Ultima Actualizacion Precio")]

        public DateTime FechaUltimaActualizacionPrecio { get; set; } = DateTime.Now;

    
        public Subcategoria Subcategoria { get; set; }

    
        public Marca Marca { get; set; }

        public override string ToString()
        {
            return Nombre;
        }


        [DisplayName("Unidad Medida")]
        public UnidadMedida UnidadMedida { get; set; }

        public List<Especificacion> Especificaciones { get; set; }
        public List<DetalleIngreso> DetallesIngreso { get; set; }
        public List<DetalleVenta> DetallesVenta { get; set; }
        public List<DetallePresupuesto> DetallesPresupuesto { get; set; }
    }
}
