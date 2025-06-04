using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos
{
    public class CD_Boleta
    {
        private CD_Conexion Conexion;
        private Boleta _Boleta;
        private List<Boleta> listaDetalleBoleta;

        //meto listar 
        public List<Boleta> ListaDetalleBoleta(int Id_Boleta)
        {

            //instancia

            Conexion = new CD_Conexion();

            listaDetalleBoleta = new List<Boleta>();

            try
            {

                Conexion.SetConsultaProcedure("SpMostrar_Boleta");

                Conexion.SetearParametro("@Id_Boleta", Id_Boleta);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    _Boleta = new Boleta();


                    _Boleta.Venta = new Venta();

                    _Boleta.Venta.Id_Venta = (int)Conexion.Lector["Id_Venta"];

                    _Boleta.FechaEmision = (DateTime)Conexion.Lector["FechaEmision"];

                    _Boleta.NombreCliente = (string)Conexion.Lector["NombreCliente"];
                    _Boleta.Domicilio = (string)Conexion.Lector["Donicilio"];
                    _Boleta.CUIT_CUIL = (string)Conexion.Lector["CUIT_CUIL"];




                    listaDetalleBoleta.Add(_Boleta);
                }

                return listaDetalleBoleta;
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

        public void InsertarBoleta(Boleta Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpInsertar_Boleta");

                Conexion.SetearParametro("@Id_Venta", Nuevo.Venta.Id_Venta);
                Conexion.SetearParametro("@FechaEmision", Nuevo.FechaEmision.ToString("yyyy-MM-dd hh:mm:ss")); ;
                Conexion.SetearParametro("@NombreCliente", Nuevo.NombreCliente);
                Conexion.SetearParametro("@Domicilio", Nuevo.Domicilio);
                Conexion.SetearParametro("@CUIT-CUIL", Nuevo.CUIT_CUIL);


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
