using Ferreteria.CapaDatos;
using Ferreteria.CapaDominio;
using Ferreteria.CapaDominio.DTOs;
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
        public List<MovimientoStock> ListaMovimientoStock(int Id_TipoMovimiento)
        {
            _MovimientoStock = new CD_MovimientoStock();
            return _MovimientoStock.ListaMovimientoStock(Id_TipoMovimiento);
        }
        public List<MoviminetoStockDto> ListaMovimientoStockManual(int Id_TipoMovimiento)
        {
            _MovimientoStock = new CD_MovimientoStock();
            return _MovimientoStock.ListaMovimientoStockManual(Id_TipoMovimiento);
        }
        public void InsertarIngreso(MovimientoStock Nuevo, List<DetalleMovimientoStock> Detalle)
        {
            _MovimientoStock = new CD_MovimientoStock();

            _MovimientoStock.InsertarMovimientoStock(Nuevo, Detalle);
        }



        public List<MovimientoStock> BuscarMovimientoStock(DateTime FechaInicio, DateTime FechaFin,int Id_TipoMovimiento)
        {
            _MovimientoStock = new CD_MovimientoStock();

            return _MovimientoStock.BuscarMovimientoStock(FechaInicio, FechaFin, Id_TipoMovimiento);
        }


        public List<MoviminetoStockDto> BuscarMovimientosManual(DateTime FechaInicio, DateTime FechaFin, int Id_TipoMovimiento)
        {
            _MovimientoStock = new CD_MovimientoStock();

            return _MovimientoStock.BuscarMovimientosManual(FechaInicio, FechaFin, Id_TipoMovimiento);
        }

        public void AjusteManualStock(MovimientoStockInsertDto movimientoStockInsertDto)
        {
            _MovimientoStock = new CD_MovimientoStock();

            _MovimientoStock.AjusteManualStock(movimientoStockInsertDto);
        }
    }
}
