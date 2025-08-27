using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio.Reportes
{
    public class IngresosNetosPorPeriodo
    {
        public string Periodo { get; set; }         // Puede ser "2025-08", "Semana 32", etc.
        public decimal IngresosNetos { get; set; }  // Total de ingresos en ese período

        // Método auxiliar para formato argentino
        public string IngresosNetosFormatoArg => IngresosNetos.ToString("C2", new CultureInfo("es-AR"));
    }

}
