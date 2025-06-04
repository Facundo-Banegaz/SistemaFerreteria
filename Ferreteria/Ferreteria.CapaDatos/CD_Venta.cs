using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Data;
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

            //instancia

            Conexion = new CD_Conexion();

            listaVenta = new List<Venta>();

            try
            {

                Conexion.SetConsultaProcedure("SpMostrar_venta");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    _Venta = new Venta();


                    _Venta.Id_Venta = (int)Conexion.Lector["Id_Venta"];

                    _Venta.Usuario = new Usuario();

                    _Venta.Usuario.Nombre = (string)Conexion.Lector["Usuario"];


                    _Venta.Fecha = (DateTime)Conexion.Lector["Fecha"];

                  
                    _Venta.Total = (decimal)Conexion.Lector["Total"];


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


        public void InsertarVenta(Venta Nuevo, List<DetalleVenta> DetalleVenta)
        {
            Conexion = new CD_Conexion();

            try
            {
                //Conexion.IniciarTransaccion();

                Conexion.SetConsultaProcedure("SpInsertar_Venta");

                Conexion.SetearParametro("@Id_Usuario", Nuevo.Usuario.Id_Usuario);
                Conexion.SetearParametro("@Fecha", Nuevo.Fecha.ToString("yyyy-MM-dd hh:mm:ss"));
                Conexion.SetearParametro("@Total", Nuevo.Total);
         



                // Configurar el parámetro de salida para el ID de ingreso

                Conexion.SetearParametroSalida("@Id_Venta", SqlDbType.Int);

                Conexion.EjecutarAccion();


                // Capturar el ID del ingreso insertado
                int Id_venta = Conexion.ObtenerValorParametroSalida("@Id_Venta");




                CD_DetalleVenta _Detalle_Venta = new CD_DetalleVenta();

                // Insertar detalles de ingreso
                foreach (DetalleVenta detalle in DetalleVenta)
                {
                    detalle.Venta.Id_Venta = Id_venta; // Suponiendo que tienes un método para obtener el último ID de ingreso insertado



                    _Detalle_Venta.InsertarDetalleVenta(detalle);
                }



                //Conexion.ConfirmarTransaccion();


            }
            catch (Exception ex)
            {
                Conexion.AnularTransaccion();
                throw ex;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }



        //Metodo eliminar
        public void EliminarVenta(int Id_venta)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpEliminar_venta");

                Conexion.SetearParametro("@Id_Venta", Id_venta);


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


        //Metodo modificar stock
        public void DisminuirStock(int Id_detalle_ingreso, int Stock_Actual)
        {

            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpDisminuir_stock");

                Conexion.SetearParametro("@Id_DetalleIngreso", Id_detalle_ingreso);
                Conexion.SetearParametro("@Cantidad", Stock_Actual);

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
        //Metodo Buscar

        public List<Venta> VentaBuscarFecha(DateTime FechaInicio, DateTime FechaFin)
        {
            Conexion = new CD_Conexion();
            listaVenta = new List<Venta>();

            try
            {
                Conexion.SetConsultaProcedure("SpBuscar_venta_fecha");


                Conexion.SetearParametro("@txt_fecha_inicio", FechaInicio);
                Conexion.SetearParametro("@txt_fecha_fin", FechaFin);

                Conexion.EjecutarLectura();
                while (Conexion.Lector.Read())
                {
                    _Venta = new Venta();


                    _Venta.Id_Venta= (int)Conexion.Lector["Id_Venta"];

                    _Venta.Usuario = new Usuario();

                    _Venta.Usuario.Nombre = (string)Conexion.Lector["Usuario"];


                    _Venta.Fecha = (DateTime)Conexion.Lector["Fecha"];


                    _Venta.Total = (decimal)Conexion.Lector["Total"];


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
