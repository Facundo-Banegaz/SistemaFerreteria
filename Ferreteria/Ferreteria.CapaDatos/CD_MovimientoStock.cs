using Ferreteria.CapaDominio;
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


        //Metodo Mostrar

        public List<MovimientoStock> ListaMovimientoStock()
        {
            //instancia

            Conexion = new CD_Conexion();

            listaMovimientoStock = new List<MovimientoStock>();

            try
            {

                Conexion.SetConsultaProcedure("Sp_MostrarMovimientosStock");

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

        public List<MovimientoStock> ListaMovimientoStockManual()
        {
            //instancia

            Conexion = new CD_Conexion();

            listaMovimientoStock = new List<MovimientoStock>();

            try
            {

                Conexion.SetConsultaProcedure("Sp_MostrarAjustesManual");

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

    }
}
