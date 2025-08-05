using Ferreteria.CapaDatos;
using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaNegocio
{
    public class CN_Ingreso
    {
        private CD_Ingreso _Ingreso;

        //Metodo para Listar los Pingresos em la DataWirdView
        public List<Ingreso> ListaIngreso()
        {
            _Ingreso = new CD_Ingreso();
            return _Ingreso.ListaIngreso();
        }

        public void InsertarIngreso(Ingreso Nuevo, List<DetalleIngreso> Detalle)
        {
            _Ingreso = new CD_Ingreso();

            _Ingreso.InsertarIngreso(Nuevo, Detalle);
        }

        //Metodo para Anular un  ingreso en la Base de Datos
        public void CambiarEstadoIngreso(int Id_ingreso)
        {
            _Ingreso = new CD_Ingreso();

            _Ingreso.CambiarEstadoIngreso(Id_ingreso);
        }

        public List<Ingreso> IngresoBuscarFecha(DateTime FechaInicio, DateTime FechaFin)
        {
            _Ingreso = new CD_Ingreso();

            return _Ingreso.IngresoBuscarFecha(FechaInicio, FechaFin);
        }
    }
}
