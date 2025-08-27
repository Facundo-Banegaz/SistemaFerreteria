using Ferreteria.CapaDatos;
using Ferreteria.CapaDatos.Reportes;
using Ferreteria.CapaDominio.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaNegocio.Reportes
{
    public class CN_ReporteVenta
    {
        CD_ReporteVenta CD_ReporteVenta;
       public  List<SalesListing>   ListaReporteVenta(DateTime FechaInicio, DateTime FechaFin)
       {
            CD_ReporteVenta = new CD_ReporteVenta();

            return CD_ReporteVenta.ListaReporteVenta(FechaInicio,FechaFin);
       
       }
    }
}
