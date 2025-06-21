using Ferreteria.CapaDatos;
using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaNegocio
{
    public class CN_TipoEspecificacion
    {
        private CD_TipoEspecificacion _CD_TipoEspecificacion;

        //Metodo para Listar los Productos em la DataWirdView
        public List<TipoEspecificacion> ListaTipoEspecificacion()
        {
            _CD_TipoEspecificacion = new CD_TipoEspecificacion();

            return _CD_TipoEspecificacion.ListaTipoEspecificacion();
        }

        //Metodo para Listar los Productos em la DataWirdView
        public List<TipoEspecificacion> CargarCbo()
        {
            _CD_TipoEspecificacion = new CD_TipoEspecificacion();

            return _CD_TipoEspecificacion.CargarCbo();
        }
        //Metodo para cargar un producto en la Base de Datos
        public void InsertarTipoEspecificacion(TipoEspecificacion Nuevo)
        {
            _CD_TipoEspecificacion = new CD_TipoEspecificacion();

            _CD_TipoEspecificacion.InsertarTipoEspecificacion(Nuevo);

        }

        //Metodo para Editar un producto en la Base de Datos
        public void EditarTipoEspecificacion(TipoEspecificacion Marca)
        {
            _CD_TipoEspecificacion = new CD_TipoEspecificacion();

            _CD_TipoEspecificacion.EditarTipoEspecificacion(Marca);
        }

        //Metodo para Eliminar un producto en la Base de Datos
        public void EliminarTipoEspecificacion(int Id_TipoEspecificacion)
        {
            _CD_TipoEspecificacion = new CD_TipoEspecificacion();

            _CD_TipoEspecificacion.EliminarTipoEspecificacion(Id_TipoEspecificacion);
        }
        //Metodo para Buscar un producto en la Base de Datos
        public List<TipoEspecificacion> TipoEspecificacionBuscar(string buscar)
        {
            _CD_TipoEspecificacion = new CD_TipoEspecificacion();

            return _CD_TipoEspecificacion.TipoEspecificacionBuscar(buscar);
        }
    }
}
