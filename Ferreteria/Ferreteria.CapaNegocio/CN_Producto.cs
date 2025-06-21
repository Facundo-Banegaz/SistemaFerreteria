using Ferreteria.CapaDatos;
using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaNegocio
{
    public class CN_Producto
    {
        private CD_Producto _CD_Producto;

        //Metodo para Listar los Productos em la DataWirdView
        public List<Producto> ListaProductos()
        {
            _CD_Producto = new CD_Producto();

            return _CD_Producto.ListaProductos();
        }

  

        //Metodo para cargar un producto en la Base de Datos
        public void InsertarProducto(Producto Nuevo)
        {
            _CD_Producto = new CD_Producto();

            _CD_Producto.InsertarProducto(Nuevo);

        }

        //Metodo para Editar un producto en la Base de Datos
        public void EditarProducto(Producto producto)
        {
            _CD_Producto = new CD_Producto();

            _CD_Producto.EditarProducto(producto);
        }
        public void ActualizarPrecio(int Id_Producto,decimal Precio)
        {
            _CD_Producto = new CD_Producto();

            _CD_Producto.ActualizarPrecio(Id_Producto, Precio);
        }

        //Metodo para Eliminar un producto en la Base de Datos
        public void EliminarProducto(int Id_Producto)
        {
            _CD_Producto = new CD_Producto();

            _CD_Producto.EliminarProducto(Id_Producto);
        }


        //Metodo para Buscar un producto en la Base de Datos
        public List<Producto> BuscarProducto(string buscar)
        {
            _CD_Producto = new CD_Producto();

            return _CD_Producto.BuscarProducto(buscar);
        }

   

    }
}
