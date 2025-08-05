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
    public class CD_DetallePresupuesto
    {
        private CD_Conexion Conexion;
        private DetallePresupuesto _DetallePresupuesto;
        private List<DetallePresupuesto> listaDetallePresupuesto;

        //meto listar 
        public List<DetallePresupuesto> ListaDetallePresupuesto(int Id_Presupuesto)
        {

            //instancia

            Conexion = new CD_Conexion();

            listaDetallePresupuesto = new List<DetallePresupuesto>();

            try
            {

                Conexion.SetConsultaProcedure("SpMostrar_DetallePresupuesto");

                Conexion.SetearParametro("@Id_Presupuesto", Id_Presupuesto);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    _DetallePresupuesto = new DetallePresupuesto();


                    
                    _DetallePresupuesto.Producto = new Producto();

                    _DetallePresupuesto.Producto.Nombre = (string)Conexion.Lector["Producto"];

                    _DetallePresupuesto.Cantidad = (decimal)Conexion.Lector["Cantidad"];
                    _DetallePresupuesto.PrecioUnitario = (decimal)Conexion.Lector["PrecioUnitario"];

                    _DetallePresupuesto.Subtotal = (decimal)Conexion.Lector["Subtotal"];


                    listaDetallePresupuesto.Add(_DetallePresupuesto);
                }

                return listaDetallePresupuesto;
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


        public List<DetallePresupuesto> ObtenerDetallePresupuesto(int Id_Presupuesto)
        {
        
            Conexion = new CD_Conexion();
            listaDetallePresupuesto = new List<DetallePresupuesto>();
            try
            {
               
                Conexion.SetConsultaProcedure("SpObtener_DetallePresupuesto");
                Conexion.SetearParametro("@Id_Presupuesto", Id_Presupuesto);
                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    _DetallePresupuesto = new DetallePresupuesto();



                    _DetallePresupuesto.Producto = new Producto();

                    _DetallePresupuesto.Producto.Nombre = (string)Conexion.Lector["Producto"];

                    _DetallePresupuesto.Cantidad = (decimal)Conexion.Lector["Cantidad"];
                    _DetallePresupuesto.PrecioUnitario = (decimal)Conexion.Lector["PrecioUnitario"];

                   


                    listaDetallePresupuesto.Add(_DetallePresupuesto);
                }
                return listaDetallePresupuesto;
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

        public void InsertarDetallePresupuesto(DetallePresupuesto detalle, SqlConnection conn, SqlTransaction trans)
        {
            using (SqlCommand cmd = new SqlCommand("Sp_Insertar_DetallePresupuesto", conn, trans))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Presupuesto", detalle.Presupuesto.Id_Presupuesto);
                cmd.Parameters.AddWithValue("@Id_Producto", detalle.Producto.Id_Producto);
                cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioUnitario", detalle.PrecioUnitario);

                cmd.ExecuteNonQuery();
            }
        }

    }
}
