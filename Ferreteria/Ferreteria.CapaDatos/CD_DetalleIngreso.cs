using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos
{
    public class CD_DetalleIngreso
    {

        private CD_Conexion Conexion;
        private DetalleIngreso _DetalleIngreso;
        private List<DetalleIngreso> listaDetalleIngreso;

        //meto listar 
        public List<DetalleIngreso> ListaDetalleIngreso(int Id_ingreso)
        {

            //instancia

            Conexion = new CD_Conexion();

            listaDetalleIngreso = new List<DetalleIngreso>();

            try
            {

                Conexion.SetConsultaProcedure("SpMostrar_detalle_ingreso");

                Conexion.SetearParametro("@Id_DetalleIngreso", Id_ingreso);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    _DetalleIngreso = new DetalleIngreso();


                    _DetalleIngreso.Producto = new Producto();

                    _DetalleIngreso.Producto.Id_Producto = (int)Conexion.Lector["Id_Producto"];
                    _DetalleIngreso.Producto.Nombre = (string)Conexion.Lector["Producto"];


                    _DetalleIngreso.Cantidad = (int)Conexion.Lector["Cantidad"];
                    _DetalleIngreso.PrecioCompra = (decimal)Conexion.Lector["Preciocompra"];
                 
              
              



                    listaDetalleIngreso.Add(_DetalleIngreso);
                }

                return listaDetalleIngreso;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConexion();
            }

        }

        //metodo insertar

        public void InsertarDetalleIngreso(DetalleIngreso Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpInsertar_detalle_ingreso");

                Conexion.SetearParametro("@Cantidad", Nuevo.Cantidad);
                Conexion.SetearParametro("@Preciocompra", Nuevo.PrecioCompra);
                Conexion.SetearParametro("@Id_Producto", Nuevo.Producto.Id_Producto);
                Conexion.SetearParametro("@Id_Ingreso", Nuevo.Ingreso.Id_Ingreso);

                Conexion.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }

    }
}
