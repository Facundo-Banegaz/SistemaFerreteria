using Ferreteria.CapaDatos;
using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaNegocio
{
    public class CN_DetallePresupuesto
    {
        private CD_DetallePresupuesto DetallePresupuesto;


        public List<DetallePresupuesto> ListaDetallePresupuesto(int Id_Presupuesto)
        {
            DetallePresupuesto = new CD_DetallePresupuesto();

            return DetallePresupuesto.ListaDetallePresupuesto(Id_Presupuesto);
        }
    }
}
