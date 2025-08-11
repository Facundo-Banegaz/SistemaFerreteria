using Ferreteria.CapaDatos;
using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaNegocio
{
    public class CN_MovimientoDetalleStock
    {
        private CD_DetalleMovimientoStock _DetalleMovimientoStock;


        public List<DetalleMovimientoStock> ListaDetalleMovimientoStock(int Id_MovimientoStock)
        {
            _DetalleMovimientoStock = new CD_DetalleMovimientoStock();

            return _DetalleMovimientoStock.ListaDetalleMovimientoStock(Id_MovimientoStock);
        }

        
    }
}
