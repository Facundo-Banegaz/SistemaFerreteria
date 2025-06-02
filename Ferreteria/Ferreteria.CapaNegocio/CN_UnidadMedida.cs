using Ferreteria.CapaDatos;
using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaNegocio
{
    public class CN_UnidadMedida
    {
        private CD_UnidadMedida _CD_UnidadMedida;

        //Metodo para Listar los Productos em la DataWirdView
        public List<UnidadMedida> ListaUnidadMedida()
        {
            _CD_UnidadMedida = new CD_UnidadMedida();

            return _CD_UnidadMedida.ListaUnidadMedida();
        }

        //Metodo para Listar los Productos em la DataWirdView
        public List<UnidadMedida> CargarCbo()
        {
            _CD_UnidadMedida = new CD_UnidadMedida();

            return _CD_UnidadMedida.CargarCbo();
        }
        //Metodo para cargar un producto en la Base de Datos
        public void InsertarUnidadMedida(UnidadMedida Nuevo)
        {
            _CD_UnidadMedida = new CD_UnidadMedida();

            _CD_UnidadMedida.InsertarUnidadMedida(Nuevo);

        }

        //Metodo para Editar un producto en la Base de Datos
        public void EditarUnidadMedida(UnidadMedida UnidadMedida)
        {
            _CD_UnidadMedida = new CD_UnidadMedida();

            _CD_UnidadMedida.EditarUnidadMedida(UnidadMedida);
        }

        //Metodo para Eliminar un producto en la Base de Datos
        public void EliminarUnidadMedida(int Id_UnidadMedida)
        {
            _CD_UnidadMedida = new CD_UnidadMedida();

            _CD_UnidadMedida.EliminarUnidadMedida(Id_UnidadMedida);
        }
        //Metodo para Buscar un producto en la Base de Datos
        public List<UnidadMedida> UnidadMedidaBuscar(string buscar)
        {
            _CD_UnidadMedida = new CD_UnidadMedida();

            return _CD_UnidadMedida.UnidadMedidaBuscar(buscar);
        }
    }
}
