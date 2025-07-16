using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class Venta
    {
        public int Id_Venta { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public decimal Total { get; set; }

        public string Estado { get; set; } 
        public string Tipo_Comprobante { get; set; }
        public string MetodoPago { get; set; }
        public string Serie { get; set; }
        public string Correlativo { get; set; }
        public Usuario Usuario { get; set; }


        
        public Presupuesto Presupuesto { get; set; }


        public List<DetalleVenta> Detalles { get; set; }
    }
}
