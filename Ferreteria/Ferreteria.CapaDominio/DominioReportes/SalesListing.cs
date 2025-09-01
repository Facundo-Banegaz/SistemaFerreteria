using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio.Reportes
{
    public class SalesListing
    {
        public int Id_Venta { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Usuario { get; set; }
        public string Productos { get; set; } 
        public decimal TotalVenta { get; set; }
    }
}
