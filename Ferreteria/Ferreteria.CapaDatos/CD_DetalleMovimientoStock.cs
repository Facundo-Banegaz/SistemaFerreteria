using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos
{
    public class CD_DetalleMovimientoStock
    {

        //inicializa
        private CD_Conexion Conexion;
        private DetalleMovimientoStock DetalleMovimientoStock;
        private List<DetalleMovimientoStock> listaDetalleMovimientoStock;

        //Metodo Mostrar

        public List<DetalleMovimientoStock> ListaDetalleMovimientoStock(int Id_MovimientoStock)
        {
            //instancia

            Conexion = new CD_Conexion();

            listaDetalleMovimientoStock = new List<DetalleMovimientoStock>();

            try
            {

                Conexion.SetConsultaProcedure("Sp_MostrarDetalleMovimientoStock");

                Conexion.SetearParametro("@Id_MovimientoStock", Id_MovimientoStock);

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    DetalleMovimientoStock = new DetalleMovimientoStock();


                    DetalleMovimientoStock.Id_DetalleMovimientoStock = (int)Conexion.Lector["Id_DetalleMovimientoStock"];

                  
                    DetalleMovimientoStock.Producto = new Producto();

                    DetalleMovimientoStock.Producto.Id_Producto = (int)Conexion.Lector["Id_Producto"];
                    DetalleMovimientoStock.Producto.Nombre = (string)Conexion.Lector["Producto"];

                    DetalleMovimientoStock.Cantidad = (decimal)Conexion.Lector["Cantidad"];


                    DetalleMovimientoStock.StockAnterior = (decimal)Conexion.Lector["StockAnterior"];
                    DetalleMovimientoStock.StockNuevo = (decimal)Conexion.Lector["StockNuevo"];


                    DetalleMovimientoStock.ObservacionDetalle = (string)Conexion.Lector["ObservacionDetalle"]; 






                    listaDetalleMovimientoStock.Add(DetalleMovimientoStock);
                }

                return listaDetalleMovimientoStock;
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
        public void InsertarDetalleMovimientoStock(DetalleMovimientoStock detalle, SqlConnection conn, SqlTransaction trans)
        {
            using (SqlCommand cmd = new SqlCommand("SpInsertar_DetalleMovimientoStock", conn, trans))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_MovimientoStock", detalle.MovimientoStock.Id_MovimientoStock);
                cmd.Parameters.AddWithValue("@Id_Producto", detalle.Producto.Id_Producto);
                cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                cmd.Parameters.AddWithValue("@StockAnterior", detalle.StockAnterior);
                cmd.Parameters.AddWithValue("@StockNuevo", detalle.StockNuevo);
                cmd.Parameters.AddWithValue("@Observacion", detalle.ObservacionDetalle ?? "Sin Observación");

                cmd.ExecuteNonQuery();
            }
        }

    }
}
