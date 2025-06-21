using Ferreteria.CapaDatos;
using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaNegocio
{
    public class CN_Especificacion
    {
        private CD_Especificacion _CD_Especificacion;

        //Metodo para Listar los Productos em la DataWirdView
        public List<Especificacion> ListaEspecificacion()
        {
            _CD_Especificacion = new CD_Especificacion();

            return _CD_Especificacion.ListaEspecificacion();
        }

  
        //Metodo para cargar un producto en la Base de Datos
        public void InsertarEspecificacion(Especificacion Nuevo)
        {
            _CD_Especificacion = new CD_Especificacion();

            _CD_Especificacion.InsertarEspecificacion(Nuevo);

        }

        //Metodo para Editar un producto en la Base de Datos
        public void EditarEspecificacion(Especificacion Especificacion)
        {
            _CD_Especificacion = new CD_Especificacion();

            _CD_Especificacion.EditarEspecificacion(Especificacion);
        }

        //Metodo para Eliminar un producto en la Base de Datos
        public void EliminarEspecificacion(int Id_Especificacion)
        {
            _CD_Especificacion = new CD_Especificacion();

            _CD_Especificacion.EliminarEspecificacion(Id_Especificacion);
        }
        //Metodo para Buscar un producto en la Base de Datos
        public List<Especificacion> EspecificacionBuscar(string buscar)
        {
            _CD_Especificacion = new CD_Especificacion();

            return _CD_Especificacion.EspecificacionBuscar(buscar);
        }
        public List<Especificacion> MostrarDetalleEspecificacionesPorProducto(int Id_Producto)
        {
            _CD_Especificacion = new CD_Especificacion();

            return _CD_Especificacion.MostrarDetalleEspecificacionesPorProducto( Id_Producto);
        }
    }
}
