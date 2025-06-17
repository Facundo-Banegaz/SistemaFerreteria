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
        public List<Subcategoria> ListaSubCategoria()
        {
             _CD_SubCategoria = new CD_subCategoria();

            return  _CD_SubCategoria.ListaSubcategoria();
        }

        //Metodo para Listar los Productos em la DataWirdView
        public List<Subcategoria> CargarCbo(int Id_Categoria)
        {
             _CD_SubCategoria = new CD_subCategoria();

            return  _CD_SubCategoria.CargarCbo(Id_Categoria);
        }
        //Metodo para cargar un producto en la Base de Datos
        public void InsertarSubCategoria(Subcategoria Nuevo)
        {
             _CD_SubCategoria = new CD_subCategoria();

             _CD_SubCategoria.InsertarSubcategoria(Nuevo);

        }

        //Metodo para Editar un producto en la Base de Datos
        public void EditarSubCategoria(Subcategoria SubCategoria)
        {
             _CD_SubCategoria = new CD_subCategoria();

             _CD_SubCategoria.EditarSubcategoria(SubCategoria);
        }

        //Metodo para Eliminar un producto en la Base de Datos
        public void EliminarSubCategoria(int Id_SubCategoria)
        {
             _CD_SubCategoria = new CD_subCategoria();

             _CD_SubCategoria.EliminarSubcategoria(Id_SubCategoria);
        }
        //Metodo para Buscar un producto en la Base de Datos
        public List<Subcategoria> SubCategoriaBuscar(string buscar)
        {
             _CD_SubCategoria = new CD_subCategoria();

            return  _CD_SubCategoria.SubcategoriaBuscar(buscar);
        }
    }
}
