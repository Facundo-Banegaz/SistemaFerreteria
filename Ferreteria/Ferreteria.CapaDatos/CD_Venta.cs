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
    public class CD_Venta
    {
        private CD_Conexion Conexion;
        private Venta _Venta;
        private List<Venta> listaVenta;
   

        public List<Venta> ListaVenta()
        {
            Conexion = new CD_Conexion();
            listaVenta = new List<Venta>();

            try
            {
                Conexion.SetConsultaProcedure("Sp_Mostrarventas");
                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    _Venta = new Venta
                    {
                        Id_Venta = (int)Conexion.Lector["Id_Venta"],
                        Tipo_Comprobante = (string)Conexion.Lector["Tipo_Comprobante"],
                        Serie = (string)Conexion.Lector["Serie"],
                        Correlativo = (string)Conexion.Lector["Correlativo"],
                        Estado = (string)Conexion.Lector["Estado"],
                        MetodoPago = (string)Conexion.Lector["MetodoPago"],
                        Cliente = (string)Conexion.Lector["Cliente"],
                        Fecha = (DateTime)Conexion.Lector["Fecha"],
                        Total = (decimal)Conexion.Lector["Total"],
                        Usuario = new Usuario
                        {
                            Nombre = (string)Conexion.Lector["Usuario"]
                        }

                    };

                    listaVenta.Add(_Venta);
                }

                return listaVenta;
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

        public void InsertarVenta(Venta nuevo, List<DetalleVenta> detalles)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.IniciarTransaccion(); // Abre conexión y transacción

                Conexion.SetConsultaProcedure("Sp_Insertar_Venta");

                Conexion.SetearParametro("@Id_Usuario", nuevo.Usuario.Id_Usuario);
                Conexion.SetearParametro("@Fecha", nuevo.Fecha.ToString("yyyy-MM-dd HH:mm:ss"));
                Conexion.SetearParametro("@Tipo_Comprobante", nuevo.Tipo_Comprobante);
                Conexion.SetearParametro("@Serie", nuevo.Serie);
                Conexion.SetearParametro("@Correlativo", nuevo.Correlativo);
                Conexion.SetearParametro("@MetodoPago", nuevo.MetodoPago);
                Conexion.SetearParametro("@Cliente", nuevo.Cliente);
                Conexion.SetearParametro("@Estado", string.IsNullOrEmpty(nuevo.Estado) ? "EMITIDO" : nuevo.Estado);
                 

                Conexion.SetearParametroSalida("@Id_Venta", SqlDbType.Int);

                Conexion.EjecutarAccion(); // Ejecuta sin cerrar la conexión

                int idVenta = Conexion.ObtenerValorParametroSalida("@Id_Venta");
                nuevo.Id_Venta = idVenta; 
                SqlConnection conn = Conexion.ObtenerConexion();
                SqlTransaction trans = Conexion.ObtenerTransaccion();

                CD_DetalleVenta detalleVentaDatos = new CD_DetalleVenta();

                foreach (var detalle in detalles)
                {
                    detalle.Venta = new Venta { Id_Venta = idVenta };
                    detalleVentaDatos.InsertarDetalleVenta(detalle, conn, trans);
                }

                Conexion.ConfirmarTransaccion(); // Commit final
            }
            catch (SqlException ex)
            {
                Conexion.AnularTransaccion();

                switch (ex.Number)
                {
                    case 50001:
                        throw new Exception("No hay suficiente stock para esta venta.");
                    default:
                        throw;
                }
            }
            catch
            {
                Conexion.AnularTransaccion();
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }

        //Metodo Estado
        public void AnularVenta(int Id_Venta)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("Sp_AnularVenta");

                Conexion.SetearParametro("@Id_Venta", Id_Venta);


                Conexion.EjecutarAccion();
            }
            catch (SqlException ex)
            {
                // Manejo específico (opcional)
                switch (ex.Number)
                {
                    case 50001:
                        throw new Exception("Esta venta ya fue anulada anteriormente.");
                    case 50002:
                        throw new Exception("No hay stock suficiente para anular la venta.");
                    default:
                        throw;
                }
            }

            finally
            {
                Conexion.CerrarConexion();
            }
        }
        
        

        //    public void CambiarEstadoVenta(int idVenta)
        //{
        //    Conexion = new CD_Conexion();

        //    try
        //    {
        //        Conexion.SetConsultaProcedure("Sp_CambiarEstadoVenta");
        //        Conexion.SetearParametro("@Id_Venta", idVenta);
        //        Conexion.EjecutarAccion();
        //    }
        //    catch (SqlException ex)
        //    {
        //        switch (ex.Number)
        //        {

        //            case 50003:
        //                throw new Exception("Solo se puede reactivar una venta dentro de las 48 horas.");
        //            case 50004:
        //                throw new Exception("No hay suficiente stock para reactivar esta venta.");
        //            case 50005:
        //                throw new Exception("Solo se puede anular una venta dentro de las 48 horas.");
        //            case 50000:
        //                throw new Exception($"Error al cambiar el estado de la venta: {ex.Message}");
        //            default:
        //                throw;
        //        }
        //    }
        //    finally
        //    {
        //        Conexion.CerrarConexion();
        //    }
        //}



        public List<Venta> VentaBuscarFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            Conexion = new CD_Conexion();
            listaVenta = new List<Venta>();

            try
            {
                Conexion.SetConsultaProcedure("Sp_BuscarVentaPorFecha");

                Conexion.SetearParametro("@FechaInicio", fechaInicio);
                Conexion.SetearParametro("@FechaFin", fechaFin);

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    _Venta = new Venta
                    {
                        Id_Venta = (int)Conexion.Lector["Id_Venta"],
                        Tipo_Comprobante = (string)Conexion.Lector["Tipo_Comprobante"],
                        Serie = (string)Conexion.Lector["Serie"],
                        Correlativo = (string)Conexion.Lector["Correlativo"],
                        Estado = (string)Conexion.Lector["Estado"],
                        MetodoPago = (string)Conexion.Lector["MetodoPago"],
                        Cliente = (string)Conexion.Lector["Cliente"],
                        Fecha = (DateTime)Conexion.Lector["Fecha"],
                        Total = (decimal)Conexion.Lector["Total"],
                        Usuario = new Usuario
                        {
                            Nombre = (string)Conexion.Lector["Usuario"]
                        }

                    };

                    listaVenta.Add(_Venta);
                }
                return listaVenta;
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
