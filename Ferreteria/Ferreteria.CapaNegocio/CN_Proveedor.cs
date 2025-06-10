using Ferreteria.CapaDatos;
using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor _CD_Proveedor;

        //Metodo para Listar los _Proveedors em la DataWirdView
        public List<Proveedor> ListaProveedor()
        {
            _CD_Proveedor = new CD_Proveedor();

            return _CD_Proveedor.ListarProveedores();
        }

        //Metodo para Listar los _Proveedors em la DataWirdView
        public List<Proveedor> CargarCbo()
        {
            _CD_Proveedor = new CD_Proveedor();

            return _CD_Proveedor.CargarCbo();
        }
        //Metodo para cargar un _Proveedor en la Base de Datos
        public void InsertarProveedor(Proveedor Nuevo)
        {
            _CD_Proveedor = new CD_Proveedor();

            _CD_Proveedor.InsertarProveedor(Nuevo);

        }

        //Metodo para Editar un _Proveedor en la Base de Datos
        public void EditarProveedor(Proveedor Proveedor)
        {
            _CD_Proveedor = new CD_Proveedor();

            _CD_Proveedor.EditarProveedor(Proveedor);
        }

        //Metodo para Eliminar un _Proveedor en la Base de Datos
        public void EliminarProveedor(int Id_Proveedor)
        {
            _CD_Proveedor = new CD_Proveedor();

            _CD_Proveedor.EliminarProveedor(Id_Proveedor);
        }
        //Metodo para Buscar un _Proveedor en la Base de Datos
        public List<Proveedor> ProveedorBuscar(string buscar)
        {
            _CD_Proveedor = new CD_Proveedor();

            return _CD_Proveedor.ProveedorBuscar(buscar);
        }
    }
}
