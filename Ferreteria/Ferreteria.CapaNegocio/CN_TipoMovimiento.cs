using Ferreteria.CapaDatos;
using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaNegocio
{
    public class CN_TipoMovimiento
    {
        private CD_TipoMovimiento _CD_TipoMovimiento;

        //Metodo para Listar los Productos em la DataWirdView
        public List<TipoMovimiento> ListaTipoMovimiento()
        {
            _CD_TipoMovimiento = new CD_TipoMovimiento();

            return _CD_TipoMovimiento.ListarTipoMovimiento();
        }
        public List<TipoMovimiento> ListarTipoMovimientoStockManual()
        {
            _CD_TipoMovimiento = new CD_TipoMovimiento();

            return _CD_TipoMovimiento.ListarTipoMovimientoStockManual();
        }

    }
}
