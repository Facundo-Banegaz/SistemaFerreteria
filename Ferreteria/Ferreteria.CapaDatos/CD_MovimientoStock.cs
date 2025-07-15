using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos
{
    public class CD_MovimientoStock
    {

        //inicializa
        private CD_Conexion Conexion;
        private MovimientoStock MovimientoStock;
        private List<MovimientoStock> listaMovimientoStock;


        //Metodo Mostrar

        public List<MovimientoStock> ListaMovimientoStock()
        {
            //instancia

            Conexion = new CD_Conexion();

            listaMovimientoStock = new List<MovimientoStock>();

            try
            {

                Conexion.SetConsultaProcedure("SpMostrar_MovimientoStock");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    MovimientoStock = new MovimientoStock();


                    MovimientoStock.Id_MovimientoStock = (int)Conexion.Lector["Id_MovimientoStock"];
                    MovimientoStock.Fecha = (DateTime)Conexion.Lector["Fecha"];
                    MovimientoStock.Cantidad = (decimal)Conexion.Lector["Cantidad"];
                    MovimientoStock.StockAnterior = (decimal)Conexion.Lector["StockAnterior"];
                    MovimientoStock.StockNuevo = (decimal)Conexion.Lector["StockNuevo"];
                    MovimientoStock.Estado = (bool)Conexion.Lector["Estado"];

                    MovimientoStock.Observacion = (string)Conexion.Lector["Observacion"];




                    MovimientoStock.Producto = new Producto();

                    MovimientoStock.Producto.Id_Producto = (int)Conexion.Lector["Id_Producto"];

                    MovimientoStock.Producto.Nombre = (string)Conexion.Lector["Producto"];
                    MovimientoStock.Producto.Codigo = (string)Conexion.Lector["Codigo"];
                    MovimientoStock.Producto.Descripcion = (string)Conexion.Lector["Descripcion"];

              

                    MovimientoStock.TipoMovimiento = new TipoMovimiento();

                    MovimientoStock.TipoMovimiento.Id_TipoMovimiento = (int)Conexion.Lector["Id_TipoMovimientoStock"];
                    MovimientoStock.TipoMovimiento.Nombre = (string)Conexion.Lector["Nombre"];


                    MovimientoStock.Usuario = new Usuario();

                    MovimientoStock.Usuario.Id_Usuario = (int)Conexion.Lector["Id_Usuario"];
                    MovimientoStock.Usuario.Nombre = (string)Conexion.Lector["Nombre"];
                    MovimientoStock.Usuario.Apellido = (string)Conexion.Lector["Apellido"];




                    listaMovimientoStock.Add(MovimientoStock);
                }

                return listaMovimientoStock;
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
        public void InsertarMovimientoStock(MovimientoStock nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpInsertar_MovimientoStock");

                Conexion.SetearParametro("@Id_Producto", nuevo.Producto.Id_Producto);
                Conexion.SetearParametro("@Cantidad", nuevo.Cantidad);
                Conexion.SetearParametro("@Id_TipoMovimiento", nuevo.TipoMovimiento.Id_TipoMovimiento);
                Conexion.SetearParametro("@Observacion", nuevo.Observacion);
                Conexion.SetearParametro("@Id_Usuario", nuevo.Usuario.Id_Usuario);

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

        //public void InsertarMovimientoStock(MovimientoStock Nuevo)
        //{
        //    Conexion = new CD_Conexion();

        //    try
        //    {



        //        Conexion.SetConsultaProcedure("SpInsertar_MovimientoStock");

        //        Conexion.SetearParametro("@Fecha", Nuevo.Fecha.ToString("yyyy-MM-dd hh:mm:ss"));
        //        Conexion.SetearParametro("@Cantidad", Nuevo.Cantidad);
        //        Conexion.SetearParametro("@StockAnterior", Nuevo.StockAnterior);
        //        Conexion.SetearParametro("@StockNuevo", Nuevo.StockNuevo);
        //        Conexion.SetearParametro("@Observacion", Nuevo.Observacion);
        //        Conexion.SetearParametro("@Estado", Nuevo.Estado);
        //        Conexion.SetearParametro("@Id_Producto", Nuevo.Producto.Id_Producto);
        //        Conexion.SetearParametro("@Id_TipoMovimiento", Nuevo.TipoMovimiento.Id_TipoMovimiento);
        //        Conexion.SetearParametro("@Id_Usuario", Nuevo.Usuario.Id_Usuario);

        //        Conexion.EjecutarAccion();


        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    finally
        //    {
        //        Conexion.CerrarConexion();
        //    }
        //}
    }
}
