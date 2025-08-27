using Ferreteria.CapaDominio;
using Ferreteria.CapaDominio.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        private MoviminetoStockDto MovimientoStockDto;
        private List<MoviminetoStockDto> listaMovimientoStockDto;

        //Metodo Mostrar

        public List<MovimientoStock> ListaMovimientoStock(int Id_TipoMovimiento)
        {
            //instancia

            Conexion = new CD_Conexion();

            listaMovimientoStock = new List<MovimientoStock>();

            try
            {

                Conexion.SetConsultaProcedure("Sp_MostrarMovimientosStock");
                Conexion.SetearParametro("@Id_TipoMovimiento", Id_TipoMovimiento);
                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    MovimientoStock = new MovimientoStock();


                    MovimientoStock.Id_MovimientoStock = (int)Conexion.Lector["Id_MovimientoStock"];

                    
                    MovimientoStock.Fecha = (DateTime)Conexion.Lector["Fecha"];
                   

                    MovimientoStock.Observacion = (string)Conexion.Lector["Observacion"];



              

                    MovimientoStock.TipoMovimiento = new TipoMovimiento();

                    MovimientoStock.TipoMovimiento.Id_TipoMovimiento = (int)Conexion.Lector["Id_TipoMovimiento"];
                    MovimientoStock.TipoMovimiento.Nombre = (string)Conexion.Lector["TipoMovimiento"];


                    MovimientoStock.Usuario = new Usuario();

                    MovimientoStock.Usuario.Id_Usuario = (int)Conexion.Lector["Id_Usuario"];
                    MovimientoStock.Usuario.Nombre = (string)Conexion.Lector["Usuario"];
                    



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

        //Metodo Mostrar Ajustes Manual

        public List<MoviminetoStockDto> ListaMovimientoStockManual(int Id_TipoMovimiento)
        {
            listaMovimientoStockDto = new List<MoviminetoStockDto>();

            try
            {
                Conexion = new CD_Conexion();
                Conexion.SetConsultaProcedure("sp_MostrarMovimientosPorTipoManual");
                Conexion.SetearParametro("@Id_TipoMovimiento", Id_TipoMovimiento);
                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    MovimientoStockDto = new MoviminetoStockDto();


                    MovimientoStockDto.Id_MovimientoStock = (int)Conexion.Lector["Id_MovimientoStock"];
                    MovimientoStockDto.Fecha = (DateTime)Conexion.Lector["Fecha"];
                    MovimientoStockDto.TipoMovimiento = (string)Conexion.Lector["TipoMovimiento"];
                    MovimientoStockDto.Usuario = (string)Conexion.Lector["Usuario"];
                    MovimientoStockDto.Observacion = (string)Conexion.Lector["Observacion"];
                    MovimientoStockDto.Id_DetalleMovimientoStock = (int)Conexion.Lector["Id_DetalleMovimientoStock"];
                   MovimientoStockDto.Producto = Conexion.Lector["Producto"].ToString();
                    MovimientoStockDto.Cantidad = (decimal)Conexion.Lector["Cantidad"];
                    MovimientoStockDto.StockAnterior =(decimal)Conexion.Lector["StockAnterior"];
                   MovimientoStockDto.StockNuevo = (decimal)Conexion.Lector["StockNuevo"];
                    MovimientoStockDto.ObservacionDetalle = (string)Conexion.Lector["ObservacionDetalle"];



                    listaMovimientoStockDto.Add(MovimientoStockDto);
                }

                return listaMovimientoStockDto;
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
        public void InsertarMovimientoStock(MovimientoStock nuevo, List<DetalleMovimientoStock> detalles)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.IniciarTransaccion(); // Abre conexión y crea transacción

                Conexion.SetConsultaProcedure("SpInsertar_MovimientoStock");

                Conexion.SetearParametro("@Fecha", nuevo.Fecha.ToString("yyyy-MM-dd HH:mm:ss"));
                Conexion.SetearParametro("@Id_TipoMovimiento", nuevo.TipoMovimiento.Id_TipoMovimiento);
                Conexion.SetearParametro("@Observacion", nuevo.Observacion ?? "SIN OBSERVACIÓN");
                Conexion.SetearParametro("@Id_Usuario", nuevo.Usuario.Id_Usuario);
                Conexion.SetearParametroSalida("@Id_MovimientoStock", SqlDbType.Int);

                Conexion.EjecutarAccion(); // Ejecuta SP de inserción de MovimientoStock

                int idMovimientoStock = Conexion.ObtenerValorParametroSalida("@Id_MovimientoStock");

                SqlConnection conn = Conexion.ObtenerConexion();
                SqlTransaction trans = Conexion.ObtenerTransaccion();

                CD_DetalleMovimientoStock detalleDatos = new CD_DetalleMovimientoStock();

                foreach (var detalle in detalles)
                {
                    detalle.MovimientoStock = new MovimientoStock { Id_MovimientoStock = idMovimientoStock };
                    detalleDatos.InsertarDetalleMovimientoStock(detalle, conn, trans);
                }

                Conexion.ConfirmarTransaccion(); // Commit final
            }
            catch
            {
                Conexion.AnularTransaccion(); // Rollback si hay error
                throw;
            }
            finally
            {
                Conexion.CerrarConexion(); // Cierre conexion
            }
        }

        //metodo buscar

        public List<MovimientoStock> BuscarMovimientoStock(DateTime FechaDesde , DateTime FechaHasta, int Id_TipoMovimiento)
        {
            // Instancia de conexión
            Conexion = new CD_Conexion();
            List<MovimientoStock> listaMovimientoStock = new List<MovimientoStock>();

            try
            {
                // Configurar el procedimiento almacenado
                Conexion.SetConsultaProcedure("Sp_BuscarMovimientos");
                Conexion.SetearParametro("@Id_TipoMovimiento", Id_TipoMovimiento);
                Conexion.SetearParametro("@FechaDesde", FechaDesde);
                Conexion.SetearParametro("@FechaHasta", FechaHasta);
          
                // Ejecutar lectura
                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    MovimientoStock = new MovimientoStock();


                    MovimientoStock.Id_MovimientoStock = (int)Conexion.Lector["Id_MovimientoStock"];


                    MovimientoStock.Fecha = (DateTime)Conexion.Lector["Fecha"];


                    MovimientoStock.Observacion = (string)Conexion.Lector["Observacion"];





                    MovimientoStock.TipoMovimiento = new TipoMovimiento();

                    MovimientoStock.TipoMovimiento.Id_TipoMovimiento = (int)Conexion.Lector["Id_TipoMovimiento"];
                    MovimientoStock.TipoMovimiento.Nombre = (string)Conexion.Lector["TipoMovimiento"];


                    MovimientoStock.Usuario = new Usuario();

                    MovimientoStock.Usuario.Id_Usuario = (int)Conexion.Lector["Id_Usuario"];
                    MovimientoStock.Usuario.Nombre = (string)Conexion.Lector["Usuario"];




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

        public List<MoviminetoStockDto> BuscarMovimientosManual(DateTime FechaDesde, DateTime FechaHasta, int Id_TipoMovimiento)
        {
            // Instancia de conexión
            Conexion = new CD_Conexion();
            listaMovimientoStockDto = new List<MoviminetoStockDto>();

            try
            {
                // Configurar el procedimiento almacenado
                Conexion.SetConsultaProcedure("sp_BuscarMovimientosManual");
                Conexion.SetearParametro("@Id_TipoMovimiento", Id_TipoMovimiento);
                Conexion.SetearParametro("@FechaDesde", FechaDesde);
                Conexion.SetearParametro("@FechaHasta", FechaHasta);

                // Ejecutar lectura
                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    MovimientoStockDto = new MoviminetoStockDto();

                    MovimientoStockDto.Id_MovimientoStock = (int)Conexion.Lector["Id_MovimientoStock"];
                    MovimientoStockDto.Fecha = (DateTime)Conexion.Lector["Fecha"];
                    MovimientoStockDto.TipoMovimiento = (string)Conexion.Lector["TipoMovimiento"];
                    MovimientoStockDto.Usuario = (string)Conexion.Lector["Usuario"];
                    MovimientoStockDto.Observacion = (string)Conexion.Lector["Observacion"];
                    MovimientoStockDto.Id_DetalleMovimientoStock = (int)Conexion.Lector["Id_DetalleMovimientoStock"];
                    MovimientoStockDto.Producto = Conexion.Lector["Producto"].ToString();
                    MovimientoStockDto.Cantidad = (decimal)Conexion.Lector["Cantidad"];
                    MovimientoStockDto.StockAnterior = (decimal)Conexion.Lector["StockAnterior"];
                    MovimientoStockDto.StockNuevo = (decimal)Conexion.Lector["StockNuevo"];
                    MovimientoStockDto.ObservacionDetalle = (string)Conexion.Lector["ObservacionDetalle"];



                    listaMovimientoStockDto.Add(MovimientoStockDto);
                }

                return listaMovimientoStockDto;
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



        public void AjusteManualStock(MovimientoStockInsertDto movimientoStockInsertDto)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.IniciarTransaccion(); // Abre conexión y crea transacción

                Conexion.SetConsultaProcedure("Sp_AjusteManualStock");

                Conexion.SetearParametro("@Id_TipoMovimiento", movimientoStockInsertDto.Id_TipoMovimiento);
                Conexion.SetearParametro("@Id_Usuario", movimientoStockInsertDto.Id_Usuario);
                Conexion.SetearParametro("@Id_Producto", movimientoStockInsertDto.Id_Producto);
                Conexion.SetearParametro("@Cantidad", movimientoStockInsertDto.Cantidad); Conexion.SetearParametro("@ObservacionDetalle",   string.IsNullOrWhiteSpace(movimientoStockInsertDto.ObservacionDetalle) ? DBNull.Value  : (object)movimientoStockInsertDto.ObservacionDetalle);


                Conexion.EjecutarAccion(); // Ejecuta SP

                Conexion.ConfirmarTransaccion(); // Commit
            }
            catch (SqlException sqlEx)
            {
                Conexion.AnularTransaccion(); // Rollback

                string userMessage;

                if (sqlEx.Message.Contains("Stock Inicial"))
                    userMessage = "Ya existe un stock inicial para este producto. No se puede registrar nuevamente.";
                else if (sqlEx.Message.Contains("Stock insuficiente"))
                    userMessage = "No hay suficiente stock para realizar la salida.";
                else if (sqlEx.Message.Contains("producto no existe"))
                    userMessage = "El producto seleccionado no existe.";
                else
                    userMessage = "Error al procesar el ajuste de stock. Intente nuevamente.";

                throw new Exception(userMessage, sqlEx);
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }


    }
}
