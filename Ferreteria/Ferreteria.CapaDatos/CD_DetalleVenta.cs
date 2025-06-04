using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos
{
    public class CD_DetalleVenta
    {

        private CD_Conexion Conexion;
        private DetalleVenta _DetalleVenta;
        private List<DetalleVenta> listaDetalleVenta;

        //meto listar 
        public List<DetalleVenta> ListaDetalleVenta(int Id_Venta)
        {

            //instancia

            Conexion = new CD_Conexion();

            listaDetalleVenta = new List<DetalleVenta>();

            try
            {

                Conexion.SetConsultaProcedure("SpMostrar_detalle_venta");

                Conexion.SetearParametro("@Id_venta", Id_Venta);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    _DetalleVenta = new DetalleVenta();


                    _DetalleVenta.Producto = new Producto();

                    _DetalleVenta.Producto.Nombre = (string)Conexion.Lector["Producto"];

                    _DetalleVenta.Cantidad = (int)Conexion.Lector["Cantidad"];

                    _DetalleVenta.PrecioVenta = (decimal)Conexion.Lector["PrecioVenta"];
                




                    listaDetalleVenta.Add(_DetalleVenta);
                }

                return listaDetalleVenta;
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

        public void InsertarDetalleVenta(DetalleVenta Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpInsertar_detalle_venta");

                Conexion.SetearParametro("@Id_venta", Nuevo.Venta.Id_Venta);
                Conexion.SetearParametro("@Id_Producto", Nuevo.Producto.Id_Producto);
                Conexion.SetearParametro("@Cantidad", Nuevo.Cantidad);
                Conexion.SetearParametro("@Precioventa", Nuevo.PrecioVenta);
                


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
