using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Data;
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

                Conexion.SetConsultaProcedure("SpMostrar_DetalleIngreso");

                Conexion.SetearParametro("@Id_Ingreso", Id_ingreso);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    _DetalleIngreso = new DetalleIngreso();

                    _DetalleIngreso.Id_DetalleIngreso = (int)Conexion.Lector["Id_DetalleIngreso"];


                    _DetalleIngreso.Producto = new Producto();

                    _DetalleIngreso.Producto.Id_Producto = (int)Conexion.Lector["Id_Producto"];
                    _DetalleIngreso.Producto.Nombre = (string)Conexion.Lector["Producto"];


                    _DetalleIngreso.Cantidad = (decimal)Conexion.Lector["Cantidad"];
                    _DetalleIngreso.PrecioCompra = (decimal)Conexion.Lector["PrecioCompra"];

                    _DetalleIngreso.Subtotal = (decimal)Conexion.Lector["Subtotal"];



                

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

        public void InsertarDetalleIngreso(DetalleIngreso detalle)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("Sp_Insertar_DetalleIngreso");

                Conexion.SetearParametro("@Cantidad", detalle.Cantidad);
                Conexion.SetearParametro("@PrecioCompra", detalle.PrecioCompra);
                Conexion.SetearParametro("@Id_Producto", detalle.Producto.Id_Producto);
                Conexion.SetearParametro("@Id_Ingreso", detalle.Ingreso.Id_Ingreso);
                Conexion.SetearParametro("@FechaFabricacion", detalle.FechaFabricacion.ToString("yyyy-MM-dd hh:mm:ss"));
                Conexion.SetearParametro("@FechaVencimiento", detalle.FechaVencimiento.ToString("yyyy-MM-dd hh:mm:ss"));
                Conexion.SetearParametro("@PorcentajeGanancia", detalle.PorcentajeGanancia);


                Conexion.SetearParametroSalida("@Id_DetalleIngreso", SqlDbType.Int);

                Conexion.EjecutarAccion();

                int idDetalle = Conexion.ObtenerValorParametroSalida("@Id_DetalleIngreso");
                detalle.Id_DetalleIngreso = idDetalle;
            }
            catch
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }

    }
}
