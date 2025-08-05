using Ferreteria.CapaDatos;
using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaNegocio
{
    public class CN_Presupuesto
    {
        private CD_Presupuesto _Presupuesto;

        //Metodo para Listar los PPresupuestos em la DataWirdView
        public List<Presupuesto> ListaPresupuesto()
        {
            _Presupuesto = new CD_Presupuesto();
            return _Presupuesto.ListaPresupuesto();
        }

        public void InsertarPresupuesto(Presupuesto Nuevo, List<DetallePresupuesto> Detalle)
        {
            _Presupuesto = new CD_Presupuesto();

            _Presupuesto.InsertarPresupuesto(Nuevo, Detalle);
        }

        //Metodo para Anular un  Presupuesto en la Base de Datos
        public void CambiarEstadoPresupuesto(int Id_Presupuesto)
        {
            _Presupuesto = new CD_Presupuesto();

            _Presupuesto.CambiarEstadoPresupuesto(Id_Presupuesto);
        }

        public List<Presupuesto> PresupuestoBuscarFecha(DateTime FechaInicio, DateTime FechaFin)
        {
            _Presupuesto = new CD_Presupuesto();

            return _Presupuesto.PresupuestoBuscarFecha(FechaInicio, FechaFin);
        }

      
    }
}

