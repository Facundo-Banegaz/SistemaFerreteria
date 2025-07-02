using Ferreteria.CapaDatos;
using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaNegocio
{
    public class CN_DetalleIngreso
    {
        private CD_DetalleIngreso Detalle_Ingreso;


        public List<DetalleIngreso> ListaDetalleIngreso(int Id_ingreso)
        {
            Detalle_Ingreso = new CD_DetalleIngreso();

            return Detalle_Ingreso.ListaDetalleIngreso(Id_ingreso);
        }
    }
}
