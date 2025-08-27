using Ferreteria.CapaDatos;
using Ferreteria.CapaDominio;
using Ferreteria.CapaDominio.DTOs;
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
        public List<ProductoAvanzadoDto> ConsultaMostrarProductosAvanzado()
        {
            _CD_Producto = new CD_Producto();

            return _CD_Producto.ConsultaMostrarProductosAvanzado();
        }
        public List<ProductoInventarioBajoDto> ListaProductosInventarioBajo()
        {
            _CD_Producto = new CD_Producto();

            return _CD_Producto.ListaProductosInventarioBajo();
        }
        public List<ProductoConVencimientoDto> ListaProductosConVencimiento(string FiltroEstado)
        {
            _CD_Producto = new CD_Producto();

            return _CD_Producto.ListaProductosConVencimiento(FiltroEstado);
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


        public void DescontarProductoVencido(int Id_Usuario, int Id_DetalleIngreso)
        { 
            _CD_Producto = new CD_Producto();

        _CD_Producto.DescontarProductoVencido(Id_Usuario,  Id_DetalleIngreso);
        }


        //Metodo para Buscar un producto en la Base de Datos
        public List<Producto> BuscarProducto(string buscar)
        {
            _CD_Producto = new CD_Producto();

            return _CD_Producto.BuscarProducto(buscar);
        }
        public List<ProductoAvanzadoDto> ConsultaBuscarProductoAvanzado(string buscar)
        {
            _CD_Producto = new CD_Producto();

            return _CD_Producto.ConsultaBuscarProductoAvanzado(buscar);
        }

        public List<ProductoInventarioBajoDto> BuscarProductosInventarioBajo(string buscar)
            {
                _CD_Producto = new CD_Producto();

                return _CD_Producto.BuscarProductosInventarioBajo(buscar);
            }

        public List<ProductoConVencimientoDto> BuscarProductoConVencimiento(string filtroEstado,string buscar)
        {
            _CD_Producto = new CD_Producto();

            return _CD_Producto.BuscarProductosConVencimiento(filtroEstado,buscar);
        }


        //Metodo para Buscar Producto Por Codigo De Barras En Ingresos
        public Producto BuscarProductoPorCodigoEnIngresos(string Codigo)
        {
            _CD_Producto = new CD_Producto();

            return _CD_Producto.BuscarProductoPorCodigoEnIngresos(Codigo);
        }

        public Producto BuscarProductoPorCodigoEnVentas(string Codigo)
        {
            _CD_Producto = new CD_Producto();

            return _CD_Producto.BuscarProductoPorCodigoEnVentas(Codigo);
        }
    }
}
