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
    public class CD_DetalleVenta
    {

        private CD_Conexion Conexion;
        private DetalleVenta _DetalleVenta;
        private List<DetalleVenta> listaDetalleVenta;

        //meto listar 
        public List<DetalleVenta> ListaDetalleVenta(int Id_Venta)
        {

            //instancia

            Conexion = new CD_Conexion();

            listaDetalleVenta = new List<DetalleVenta>();

            try
            {

                Conexion.SetConsultaProcedure("SpMostrar_DetalleVenta");

                Conexion.SetearParametro("@Id_venta", Id_Venta);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    _DetalleVenta = new DetalleVenta();


                    _DetalleVenta.Producto = new Producto();

                    _DetalleVenta.Producto.Nombre = (string)Conexion.Lector["Producto"];

                    _DetalleVenta.Cantidad = (decimal)Conexion.Lector["Cantidad"];

                    _DetalleVenta.PrecioVenta = (decimal)Conexion.Lector["PrecioVenta"];


                    _DetalleVenta.Subtotal = (decimal)Conexion.Lector["Subtotal"];


                    listaDetalleVenta.Add(_DetalleVenta);
                }

                return listaDetalleVenta;
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

        public void InsertarDetalleVenta(DetalleVenta detalle, SqlConnection conn, SqlTransaction trans)
        {
            using (SqlCommand cmd = new SqlCommand("Sp_Insertar_DetalleVenta", conn, trans))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Venta", detalle.Venta.Id_Venta);
                cmd.Parameters.AddWithValue("@Id_Producto", detalle.Producto.Id_Producto);
                cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioVenta", detalle.PrecioVenta);

                // Ejecuta el comando dentro de la transacción compartida
                cmd.ExecuteNonQuery();
            }
        }

    }
}
