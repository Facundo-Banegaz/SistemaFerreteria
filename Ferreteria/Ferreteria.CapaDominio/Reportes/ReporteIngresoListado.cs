using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio.Reportes
{
    public class ReporteIngresoListado
    {
        public int Id_Ingreso { get; set; }
        public DateTime Fecha { get; set; }
        public string Proveedor { get; set; }
        public string Productos { get; set; } 
        public decimal TotalIngreso { get; set; }
        public string TotalIngresoFormatoArg => TotalIngreso.ToString("C2", new CultureInfo("es-AR"));
    }
}
