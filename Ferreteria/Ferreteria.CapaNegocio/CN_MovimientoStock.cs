using Ferreteria.CapaDatos;
using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaNegocio
{
    public class CN_MovimientoStock
    {
        private CD_MovimientoStock _MovimientoStock;

        //Metodo para Listar los Pingresos em la DataWirdView
        public List<MovimientoStock> ListaMovimientoStock()
        {
            _MovimientoStock = new CD_MovimientoStock();
            return _MovimientoStock.ListaMovimientoStock();
        }
        public List<MovimientoStock> ListaMovimientoStockManual()
        {
            _MovimientoStock = new CD_MovimientoStock();
            return _MovimientoStock.ListaMovimientoStockManual();
        }
        public void InsertarIngreso(MovimientoStock Nuevo, List<DetalleMovimientoStock> Detalle)
        {
            _MovimientoStock = new CD_MovimientoStock();

            _MovimientoStock.InsertarMovimientoStock(Nuevo, Detalle);
        }

  

        //public List<Ingreso> MovimientoStockBuscarFecha(DateTime FechaInicio, DateTime FechaFin)
        //{
        //    _MovimientoStock = new CD_MovimientoStock();

        //    return _MovimientoStock.MovimientoStockBuscarFecha(FechaInicio, FechaFin);
        //}
    }
}
