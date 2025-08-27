using Ferreteria.CapaDatos;
using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaNegocio
{
    public class CN_DetalleVenta
    {
        private CD_DetalleVenta Detalle_Venta;

        public List<DetalleVenta> ObtenerDetalleVenta(int Id_Venta)
        {
            Detalle_Venta = new CD_DetalleVenta();

            return Detalle_Venta.ObtenerDetalleVenta(Id_Venta);
        }
        public List<DetalleVenta> ListaDetalleVenta(int Id_Venta)
        {
            Detalle_Venta = new CD_DetalleVenta();

            return Detalle_Venta.ListaDetalleVenta(Id_Venta);
        }
    }
}
