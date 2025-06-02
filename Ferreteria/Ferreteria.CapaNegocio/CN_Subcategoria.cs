using Ferreteria.CapaDatos;
using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaNegocio
{
    public class CN_SubCategoria
    {
        private CD_subCategoria _CD_SubCategoria;

        //Metodo para Listar los Productos em la DataWirdView
        public List<SubCategoria> ListaSubCategoria()
        {
             _CD_SubCategoria = new CD_subCategoria();

            return  _CD_SubCategoria.ListasubCategoria();
        }

        //Metodo para Listar los Productos em la DataWirdView
        public List<SubCategoria> CargarCbo(int CategoriaId)
        {
             _CD_SubCategoria = new CD_subCategoria();

            return  _CD_SubCategoria.CargarCbo( CategoriaId);
        }
        //Metodo para cargar un producto en la Base de Datos
        public void InsertarSubCategoria(SubCategoria Nuevo)
        {
             _CD_SubCategoria = new CD_subCategoria();

             _CD_SubCategoria.InsertarsubCategoria(Nuevo);

        }

        //Metodo para Editar un producto en la Base de Datos
        public void EditarSubCategoria(SubCategoria SubCategoria)
        {
             _CD_SubCategoria = new CD_subCategoria();

             _CD_SubCategoria.EditarsubCategoria(SubCategoria);
        }

        //Metodo para Eliminar un producto en la Base de Datos
        public void EliminarSubCategoria(int Id_SubCategoria)
        {
             _CD_SubCategoria = new CD_subCategoria();

             _CD_SubCategoria.EliminarsubCategoria(Id_SubCategoria);
        }
        //Metodo para Buscar un producto en la Base de Datos
        public List<SubCategoria> SubCategoriaBuscar(string buscar)
        {
             _CD_SubCategoria = new CD_subCategoria();

            return  _CD_SubCategoria.subCategoriaBuscar(buscar);
        }
    }
}
