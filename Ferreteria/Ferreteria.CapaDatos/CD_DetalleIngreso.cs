using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

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

                    _DetalleIngreso.FechaFabricacion = (DateTime)Conexion.Lector["FechaFabricacion"];
                    _DetalleIngreso.FechaVencimiento = (DateTime)Conexion.Lector["FechaVencimiento"];
                    _DetalleIngreso.PorcentajeGanancia = (decimal)Conexion.Lector["PorcentajeGanancia"];
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


        public void InsertarDetalleIngreso(DetalleIngreso detalle, SqlConnection conn, SqlTransaction trans)
        {
            using (SqlCommand cmd = new SqlCommand("Sp_Insertar_DetalleIngreso", conn, trans))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Ingreso", detalle.Ingreso.Id_Ingreso);
                cmd.Parameters.AddWithValue("@Id_Producto", detalle.Producto.Id_Producto);
                cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioCompra", detalle.PrecioCompra);

                // Validar FechaFabricacion
                if (detalle.FechaFabricacion.HasValue && detalle.FechaFabricacion.Value >= SqlDateTime.MinValue.Value)
                    cmd.Parameters.AddWithValue("@FechaFabricacion", detalle.FechaFabricacion.Value);
                else
                    cmd.Parameters.AddWithValue("@FechaFabricacion", DBNull.Value);

                // Validar FechaVencimiento
                if (detalle.FechaVencimiento.HasValue && detalle.FechaVencimiento.Value >= SqlDateTime.MinValue.Value)
                    cmd.Parameters.AddWithValue("@FechaVencimiento", detalle.FechaVencimiento.Value);
                else
                    cmd.Parameters.AddWithValue("@FechaVencimiento", DBNull.Value);

                cmd.Parameters.AddWithValue("@PorcentajeGanancia", detalle.PorcentajeGanancia);

                SqlParameter pIdDetalle = new SqlParameter("@Id_DetalleIngreso", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(pIdDetalle);

                cmd.ExecuteNonQuery();

                detalle.Id_DetalleIngreso = Convert.ToInt32(pIdDetalle.Value);
            }
        }



    }
}
