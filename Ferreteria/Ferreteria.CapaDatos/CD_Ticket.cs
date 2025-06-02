using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos
{
    public class CD_Ticket
    {
        private CD_Conexion Conexion;
        private Ticket _Ticket;
        private List<Ticket> listaDetalleTicket;

        //meto listar 
        public List<Ticket> ListaDetalleTicket(int Id_Ticket)
        {

            //instancia

            Conexion = new CD_Conexion();

            listaDetalleTicket = new List<Ticket>();

            try
            {

                Conexion.SetConsultaProcedure("SpMostrar_Ticket");

                Conexion.SetearParametro("@Id", Id_Ticket);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    _Ticket = new Ticket();


                    _Ticket.Venta = new Venta();

                    _Ticket.Venta.Id = (int)Conexion.Lector["VentaId"];

                    _Ticket.FechaEmision = (DateTime)Conexion.Lector["FechaEmision"];





                    listaDetalleTicket.Add(_Ticket);
                }

                return listaDetalleTicket;
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

        public void InsertarTicket(Ticket Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpInsertar_Ticket");

                Conexion.SetearParametro("@VentaId", Nuevo.Venta.Id);
                Conexion.SetearParametro("@FechaEmision", Nuevo.FechaEmision.ToString("yyyy-MM-dd hh:mm:ss")); ;
         


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
