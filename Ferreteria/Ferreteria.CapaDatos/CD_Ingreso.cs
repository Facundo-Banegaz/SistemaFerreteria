using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Data;
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

                Conexion.SetConsultaProcedure("SpMostrar_ingreso");

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


        public void InsertarIngreso(Ingreso Nuevo, List<DetalleIngreso> DetalleIngreso)
        {
            Conexion = new CD_Conexion();

            try
            {
                //Conexion.IniciarTransaccion();

                Conexion.SetConsultaProcedure("SpInsertar_ingreso");
                
                Conexion.SetearParametro("@Fecha", Nuevo.Fecha.ToString("yyyy-MM-dd hh:mm:ss"));
                Conexion.SetearParametro("@Id_Usuario", Nuevo.Usuario.Id_Usuario);
                Conexion.SetearParametro("@Id_Proveedor", Nuevo.Proveedor.Id_Proveedor);
 
              



                // Configurar el parámetro de salida para el ID de ingreso

                Conexion.SetearParametroSalida("@Id_Ingreso", SqlDbType.Int);

                Conexion.EjecutarAccion();


                // Capturar el ID del ingreso insertado
                int Id_ingreso = Conexion.ObtenerValorParametroSalida("@Id_Ingreso");




                CD_DetalleIngreso _Detalle_Ingreso = new CD_DetalleIngreso();

                // Insertar detalles de ingreso
                foreach (DetalleIngreso detalle in DetalleIngreso)
                {
                    detalle.Ingreso.Id_Ingreso = Id_ingreso; // Suponiendo que tienes un método para obtener el último ID de ingreso insertado



                    _Detalle_Ingreso.InsertarDetalleIngreso(detalle);
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
        public void AnularIngreso(int Id_ingreso)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpAnular_ingreso");

                Conexion.SetearParametro("@Id_Ingreso", Id_ingreso);


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
        public void AumentarStock(int Id_detalle_ingreso, int Stock_Actual)
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

        public List<Ingreso> IngresoBuscarFecha(DateTime FechaInicio, DateTime FechaFin)
        {
            Conexion = new CD_Conexion();
            listaIngreso = new List<Ingreso>();

            try
            {
                Conexion.SetConsultaProcedure("SpBuscar_ingreso_fecha");


                Conexion.SetearParametro("@txt_fecha_inicio", FechaInicio);
                Conexion.SetearParametro("@txt_fecha_fin", FechaFin);

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
