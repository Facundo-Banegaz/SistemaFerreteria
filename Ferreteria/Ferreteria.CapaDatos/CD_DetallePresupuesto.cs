using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
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


                    _DetallePresupuesto.Presupuesto = new Presupuesto();

                    _DetallePresupuesto.Presupuesto.Id_Presupuesto = (int)Conexion.Lector["Id_Presupuesto"];
                    
                    _DetallePresupuesto.Producto = new Producto();

                    _DetallePresupuesto.Producto.Nombre = (string)Conexion.Lector["Producto"];

                    _DetallePresupuesto.Cantidad = (int)Conexion.Lector["Cantidad"];
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

        public void InsertarDetallePresupuesto(DetallePresupuesto Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpInsertar_DetallePresupuesto");

                Conexion.SetearParametro("@Id_Presupuesto", Nuevo.Presupuesto.Id_Presupuesto);
                Conexion.SetearParametro("@Id_Producto", Nuevo.Producto.Id_Producto);
                Conexion.SetearParametro("@Cantidad", Nuevo.Cantidad);
                Conexion.SetearParametro("@PrecioUnitario", Nuevo.PrecioUnitario);


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

    }
}
