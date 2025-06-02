using Ferreteria.CapaDatos;
using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaNegocio
{
    public class CN_Marca
    {

            private CD_Marca _CD_Marca;

            //Metodo para Listar los Productos em la DataWirdView
            public List<Marca> ListaMarca()
            {
                _CD_Marca = new CD_Marca();

                return _CD_Marca.ListaMarca();
            }

            //Metodo para Listar los Productos em la DataWirdView
            public List<Marca> CargarCbo()
            {
                _CD_Marca = new CD_Marca();

                return _CD_Marca.CargarCbo();
            }
            //Metodo para cargar un producto en la Base de Datos
            public void InsertarMarca(Marca Nuevo)
            {
                _CD_Marca = new CD_Marca();

                _CD_Marca.InsertarMarca(Nuevo);

            }

            //Metodo para Editar un producto en la Base de Datos
            public void EditarMarca(Marca Marca)
            {
                _CD_Marca = new CD_Marca();

                _CD_Marca.EditarMarca(Marca);
            }

            //Metodo para Eliminar un producto en la Base de Datos
            public void EliminarMarca(int Id_Marca)
            {
                _CD_Marca = new CD_Marca();

                _CD_Marca.EliminarMarca(Id_Marca);
            }
            //Metodo para Buscar un producto en la Base de Datos
            public List<Marca> MarcaBuscar(string buscar)
            {
                _CD_Marca = new CD_Marca();

                return _CD_Marca.MarcaBuscar(buscar);
            }
        
    }
}
