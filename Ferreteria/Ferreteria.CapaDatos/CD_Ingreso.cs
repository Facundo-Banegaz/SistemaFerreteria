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
    public class CD_Ingreso
    {
        private CD_Conexion Conexion;
        private Ingreso Ingreso;
        private List<Ingreso> listaIngreso;


        public List<Ingreso> ListaIngreso()
        {

            //instancia

            Conexion = new CD_Conexion();

            listaIngreso = new List<Ingreso>();

            try
            {

                Conexion.SetConsultaProcedure("Sp_MostrarIngresos");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    Ingreso = new Ingreso();


                    Ingreso.Id_Ingreso = (int)Conexion.Lector["Id_Ingreso"];
                    Ingreso.Fecha = (DateTime)Conexion.Lector["Fecha"];

                    Ingreso.Usuario = new Usuario();

                    Ingreso.Usuario.Id_Usuario = (int)Conexion.Lector["Id_Usuario"];
                    Ingreso.Usuario.Nombre = (string)Conexion.Lector["Usuario"];


                    Ingreso.Proveedor = new Proveedor();

                    Ingreso.Proveedor.Id_Proveedor = (int)Conexion.Lector["Id_Proveedor"];
                    Ingreso.Proveedor.Nombre = (string)Conexion.Lector["Proveedor"];



                    Ingreso.Tipo_Comprobante = (string)Conexion.Lector["Tipo_comprobante"];
                    Ingreso.Serie = (string)Conexion.Lector["Serie"];

                    Ingreso.Correlativo = (string)Conexion.Lector["Correlativo"];
                
                    Ingreso.Estado = (string)Conexion.Lector["Estado"];
                    Ingreso.Total = (decimal)Conexion.Lector["Total"];

                    listaIngreso.Add(Ingreso);
                }

                return listaIngreso;
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


        public void InsertarIngreso(Ingreso nuevo, List<DetalleIngreso> detalles)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.IniciarTransaccion(); // Abre conexión y crea transacción

                Conexion.SetConsultaProcedure("Sp_Insertar_Ingreso");

                Conexion.SetearParametro("@Id_Usuario", nuevo.Usuario.Id_Usuario);
                Conexion.SetearParametro("@Id_Proveedor", nuevo.Proveedor.Id_Proveedor);
                Conexion.SetearParametro("@Serie", nuevo.Serie);
                Conexion.SetearParametro("@Correlativo", nuevo.Correlativo);
                Conexion.SetearParametro("@Estado", nuevo.Estado ?? "EMITIDO");
                Conexion.SetearParametro("@Tipo_Comprobante", nuevo.Tipo_Comprobante);
                Conexion.SetearParametro("@Fecha", nuevo.Fecha.ToString("yyyy-MM-dd hh:mm:ss"));
                Conexion.SetearParametroSalida("@Id_Ingreso", SqlDbType.Int);

                Conexion.EjecutarAccion(); // Ejecuta y no cierra conexión

                int idIngreso = Conexion.ObtenerValorParametroSalida("@Id_Ingreso");
                nuevo.Id_Ingreso = idIngreso;
                SqlConnection conn = Conexion.ObtenerConexion();
                SqlTransaction trans = Conexion.ObtenerTransaccion();

                CD_DetalleIngreso detalleIngresoDatos = new CD_DetalleIngreso();

                foreach (var detalle in detalles)
                {
                    detalle.Ingreso = new Ingreso { Id_Ingreso = idIngreso };
                    detalleIngresoDatos.InsertarDetalleIngreso(detalle, conn, trans);
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
                Conexion.CerrarConexion(); // Cierre limpio
            }
        }

        //Metodo eliminar
        public void AnularIngreso(int Id_Ingreso)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("Sp_AnularIngreso"); // Verificá el nombre exacto
                Conexion.SetearParametro("@Id_Ingreso", Id_Ingreso);

                Conexion.EjecutarAccion();
            }
            catch (SqlException ex)

            {
                switch (ex.Number)
                {

                    case 50001:
                        throw new Exception("Este ingreso ya ha sido anulado anteriormente.");
                    case 50002:
                        throw new Exception("No hay suficiente stock para anular este ingreso.");
                    default:
                        throw;
                }
            }

            finally
            {
                Conexion.CerrarConexion();
            }
        }
        //Metodo eliminar
        //public void CambiarEstadoIngreso(int Id_Ingreso)
        //{
        //    if (Id_Ingreso <= 0)
        //        throw new ArgumentException("El ID del ingreso no es válido.");

                //    Conexion = new CD_Conexion();

                //    try
                //    {
                //        Conexion.SetConsultaProcedure("Sp_CambiarEstadoIngreso");
                //        Conexion.SetearParametro("@Id_Ingreso", Id_Ingreso);

                //        Conexion.EjecutarAccion();
                //    }
                //    catch (SqlException ex)
                //    {
                //        // Manejamos errores específicos
                //        switch (ex.Number)
                //        {
                //            case 50001:
                //                throw new Exception("Este ingreso ya se encuentra en el estado solicitado.");
                //            case 50002:
                //                throw new Exception("No hay suficiente stock para realizar la operación.");
                //            default:
                //                // Si el procedimiento lanza un RAISERROR personalizado sin número de error fijo
                //                if (!string.IsNullOrWhiteSpace(ex.Message))
                //                    throw new Exception("Error al cambiar el estado del ingreso: " + ex.Message);
                //                else
                //                    throw new Exception("Ocurrió un error inesperado en la base de datos.", ex);
                //        }
                //    }
                //    finally
                //    {
                //        Conexion.CerrarConexion();
                //    }
                //}




                //Metodo Buscar

        public List<Ingreso> IngresoBuscarFecha(DateTime FechaInicio, DateTime FechaFin)
        {
            Conexion = new CD_Conexion();
            listaIngreso = new List<Ingreso>();

            try
            {
                Conexion.SetConsultaProcedure("Sp_BuscarIngresoPorFecha");


                Conexion.SetearParametro("@FechaInicio", FechaInicio);
                Conexion.SetearParametro("@FechaFin", FechaFin);

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    Ingreso = new Ingreso();


                    Ingreso.Id_Ingreso = (int)Conexion.Lector["Id_Ingreso"];
                    Ingreso.Fecha = (DateTime)Conexion.Lector["Fecha"];

                    Ingreso.Usuario = new Usuario();

                    Ingreso.Usuario.Id_Usuario = (int)Conexion.Lector["Id_Usuario"];
                    Ingreso.Usuario.Nombre = (string)Conexion.Lector["Usuario"];


                    Ingreso.Proveedor = new Proveedor();

                    Ingreso.Proveedor.Id_Proveedor = (int)Conexion.Lector["Id_Proveedor"];
                    Ingreso.Proveedor.Nombre = (string)Conexion.Lector["Proveedor"];



                    Ingreso.Tipo_Comprobante = (string)Conexion.Lector["Tipo_comprobante"];
                    Ingreso.Serie = (string)Conexion.Lector["Serie"];

                    Ingreso.Correlativo = (string)Conexion.Lector["Correlativo"];

                    Ingreso.Estado = (string)Conexion.Lector["Estado"];
                    Ingreso.Total = (decimal)Conexion.Lector["Total"];

                    listaIngreso.Add(Ingreso);
                }
                return listaIngreso;
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
