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


        public void InsertarIngreso(Ingreso Nuevo, List<DetalleIngreso> detalles)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.IniciarTransaccion();

                Conexion.SetConsultaProcedure("Sp_Insertar_ingreso");

                // Enviar solo parámetros que el SP espera (no @Fecha si es OUTPUT o generado internamente)
                Conexion.SetearParametro("@Id_Usuario", Nuevo.Usuario.Id_Usuario);
                Conexion.SetearParametro("@Id_Proveedor", Nuevo.Proveedor.Id_Proveedor);
                Conexion.SetearParametro("@Serie", Nuevo.Serie ?? "");
                Conexion.SetearParametro("@Correlativo", Nuevo.Correlativo ?? "");
                Conexion.SetearParametro("@Estado", Nuevo.Estado ?? "ACTIVO");
                Conexion.SetearParametro("@Tipo_Comprobante", Nuevo.Tipo_Comprobante ?? "");

                Conexion.SetearParametroSalida("@Id_Ingreso", SqlDbType.Int);

                Conexion.EjecutarAccion();

                int idIngreso = Conexion.ObtenerValorParametroSalida("@Id_Ingreso");

                CD_DetalleIngreso detalleIngresoDatos = new CD_DetalleIngreso();

                foreach (var detalle in detalles)
                {
                    detalle.Ingreso = new Ingreso { Id_Ingreso = idIngreso };
                    detalleIngresoDatos.InsertarDetalleIngreso(detalle);
                }

                Conexion.ConfirmarTransaccion();
            }
            catch
            {
                Conexion.AnularTransaccion();
                throw;  // Mantener pila original
            }
            finally
            {
                Conexion.CerrarConexion();
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
