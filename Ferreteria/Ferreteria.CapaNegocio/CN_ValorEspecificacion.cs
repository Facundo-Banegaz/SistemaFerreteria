using Ferreteria.CapaDatos;
using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaNegocio
{
    public class CN_ValorEspecificacion
    {
        private CD_ValorEspecificacion _CD_ValorEspecificacion;

        //Metodo para Listar los ValorEspecificacions em la DataWirdView
        public List<ValorEspecificacion> listaValorEspecificacion()
        {
            _CD_ValorEspecificacion = new CD_ValorEspecificacion();

            return _CD_ValorEspecificacion.ListaValorEspecificacion();
        }

        //Metodo para Listar los ValorEspecificacions em la DataWirdView
        public List<ValorEspecificacion> CargarCbo()
        {
            _CD_ValorEspecificacion = new CD_ValorEspecificacion();

            return _CD_ValorEspecificacion.CargarCbo();
        }
        //Metodo para cargar un ValorEspecificacion en la Base de Datos
        public void InsertarValorEspecificacion(ValorEspecificacion Nuevo)
        {
            _CD_ValorEspecificacion = new CD_ValorEspecificacion();

            _CD_ValorEspecificacion.InsertarValorEspecificacion(Nuevo);

        }

        //Metodo para Editar un ValorEspecificacion en la Base de Datos
        public void EditarValorEspecificacion(ValorEspecificacion Marca)
        {
            _CD_ValorEspecificacion = new CD_ValorEspecificacion();

            _CD_ValorEspecificacion.EditarValorEspecificacion(Marca);
        }

        //Metodo para Eliminar un ValorEspecificacion en la Base de Datos
        public void EliminarValorEspecificacion(int Id_ValorEspecificacion)
        {
            _CD_ValorEspecificacion = new CD_ValorEspecificacion();

            _CD_ValorEspecificacion.EliminarValorEspecificacion(Id_ValorEspecificacion);
        }
        //Metodo para Buscar un ValorEspecificacion en la Base de Datos
        public List<ValorEspecificacion> ValorEspecificacionBuscar(string buscar)
        {
            _CD_ValorEspecificacion = new CD_ValorEspecificacion();

            return _CD_ValorEspecificacion.ValorEspecificacionBuscar(buscar);
        }
    }
}
