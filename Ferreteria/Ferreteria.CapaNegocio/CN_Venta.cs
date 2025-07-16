using Ferreteria.CapaDatos;
using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaNegocio
{
    public class CN_Venta
    {

        private CD_Venta _Venta;

        //Metodo para Listar los PVentas em la DataWirdView
        public List<Venta> ListaVenta()
        {
            _Venta = new CD_Venta();
            return _Venta.ListaVenta();
        }

        public void InsertarVenta(Venta Nuevo, List<DetalleVenta> Detalle)
        {
            _Venta = new CD_Venta();

            _Venta.InsertarVenta(Nuevo, Detalle);
        }

        //Metodo para Anular un  Venta en la Base de Datos
        public void AnularVenta(int Id_Venta)
        {
            _Venta = new CD_Venta();

            _Venta.AnularVenta(Id_Venta);
        }

        public List<Venta> VentaBuscarFecha(DateTime FechaInicio, DateTime FechaFin)
        {
            _Venta = new CD_Venta();

            return _Venta.VentaBuscarFecha(FechaInicio, FechaFin);
        }
    }
}
