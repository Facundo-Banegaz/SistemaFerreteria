using Ferreteria.CapaDominio.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos.Reportes
{
    public class CD_ReporteVenta
    {
        private CD_Conexion Conexion;

        // Devuelve listado de ventas por rango de fechas
        public List<SalesListing> ListaReporteVenta(DateTime FechaInicio, DateTime FechaFin)
        {
            List<SalesListing> listaReporteVenta = new List<SalesListing>();
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("Sp_ReporteDeVentas");
                Conexion.SetearParametro("@FechaInicio", FechaInicio);
                Conexion.SetearParametro("@FechaFin", FechaFin);
                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    var venta = new SalesListing
                    {
                        Id_Venta = (int)Conexion.Lector["Id_Venta"],
                        Fecha = (DateTime)Conexion.Lector["Fecha"],
                        Cliente = (string)Conexion.Lector["Cliente"],
                        Usuario = (string)Conexion.Lector["Usuario"],
                        Productos = (string)Conexion.Lector["Productos"], 
                        TotalVenta = (decimal)Conexion.Lector["TotalVenta"]
                    };

                    listaReporteVenta.Add(venta);
                }

                return listaReporteVenta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }

        // Devuelve resumen de ventas por periodo (día, semana, mes, año)
        public List<NetSalesByPeriod> ResumenVentasPorPeriodo(List<SalesListing> listaVentas, DateTime FechaInicio, DateTime FechaFin)
        {
            List<NetSalesByPeriod> resumen = new List<NetSalesByPeriod>();
            int totalDays = (FechaFin - FechaInicio).Days;

            var ventasPorDia = listaVentas
                .GroupBy(v => v.Fecha.Date)
                .Select(g => new { Fecha = g.Key, Total = g.Sum(x => x.TotalVenta) })
                .ToList();

            if (totalDays <= 7)
            {
                resumen = ventasPorDia
                    .Select(v => new NetSalesByPeriod
                    {
                        Periodo = v.Fecha.ToString("dd-MMM-yyyy"),
                        VentasNetas = v.Total
                    }).ToList();
            }
            else if (totalDays <= 30)
            {
                resumen = ventasPorDia
                    .GroupBy(v => System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                        v.Fecha, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday))
                    .Select(g => new NetSalesByPeriod
                    {
                        Periodo = "Semana " + g.Key,
                        VentasNetas = g.Sum(x => x.Total)
                    }).ToList();
            }
            else if (totalDays <= 365)
            {
                resumen = ventasPorDia
                    .GroupBy(v => v.Fecha.ToString("MMM-yyyy"))
                    .Select(g => new NetSalesByPeriod
                    {
                        Periodo = g.Key,
                        VentasNetas = g.Sum(x => x.Total)
                    }).ToList();
            }
            else
            {
                resumen = ventasPorDia
                    .GroupBy(v => v.Fecha.Year)
                    .Select(g => new NetSalesByPeriod
                    {
                        Periodo = g.Key.ToString(),
                        VentasNetas = g.Sum(x => x.Total)
                    }).ToList();
            }

            return resumen;
        }

        // Devuelve total acumulado de todas las ventas
        public decimal TotalVentasAcumulado(List<SalesListing> listaVentas)
        {
            return listaVentas.Sum(v => v.TotalVenta);
        }




    }

}
