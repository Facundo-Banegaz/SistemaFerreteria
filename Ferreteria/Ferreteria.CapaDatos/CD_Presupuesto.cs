using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos
{
    public class CD_Presupuesto
    {
        private CD_Conexion Conexion;
        private Presupuesto _Presupuesto;
        private List<Presupuesto> listaPresupuesto;


        public List<Presupuesto> ListaPresupuesto()
        {

            //instancia

            Conexion = new CD_Conexion();

            listaPresupuesto = new List<Presupuesto>();

            try
            {

                Conexion.SetConsultaProcedure("SpMostrar_Presupuesto");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    _Presupuesto = new Presupuesto();


                    _Presupuesto.Id = (int)Conexion.Lector["Id"];

                    _Presupuesto.Usuario = new Usuario();
                    _Presupuesto.Usuario.Nombre = (string)Conexion.Lector["Usuario"];

                

                    _Presupuesto.Fecha = (DateTime)Conexion.Lector["Fecha"];
                    _Presupuesto.Cliente = (string)Conexion.Lector["Cliente"];
             
                    _Presupuesto.Estado = (string)Conexion.Lector["Estado"];
                    _Presupuesto.Total = (decimal)Conexion.Lector["Total"];


                    listaPresupuesto.Add(_Presupuesto);
                }

                return listaPresupuesto;
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


        public void InsertarPresupuesto(Presupuesto Nuevo, List<DetallePresupuesto> DetallePresupuesto)
        {
            Conexion = new CD_Conexion();

            try
            {
                //Conexion.IniciarTransaccion();

                Conexion.SetConsultaProcedure("SpInsertar_Presupuesto");
                Conexion.SetearParametro("@UsuarioId", Nuevo.Usuario);
                Conexion.SetearParametro("@Fecha", Nuevo.Fecha.ToString("yyyy-MM-dd hh:mm:ss"));
                Conexion.SetearParametro("@Cliente", Nuevo.Cliente);
                Conexion.SetearParametro("@Total", Nuevo.Total);
                Conexion.SetearParametro("@Estado", Nuevo.Estado);



                // Configurar el parámetro de salida para el ID de ingreso

                Conexion.SetearParametroSalida("@Id", SqlDbType.Int);

                Conexion.EjecutarAccion();


                // Capturar el ID del ingreso insertado
                int Id_Presupuesto = Conexion.ObtenerValorParametroSalida("@Id");




                CD_DetallePresupuesto _Detalle_Presupuesto = new CD_DetallePresupuesto();

                // Insertar detalles de ingreso
                foreach (DetallePresupuesto detalle in DetallePresupuesto)
                {
                    detalle.Presupuesto.Id = Id_Presupuesto; // Suponiendo que tienes un método para obtener el último ID de ingreso insertado



                    _Detalle_Presupuesto.InsertarDetallePresupuesto(detalle);
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
        public void EliminarPresupuesto(int Id_Presupuesto)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpEliminar_Presupuesto");

                Conexion.SetearParametro("@Id", Id_Presupuesto);


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


     

        public List<Presupuesto> PresupuestoBuscarFecha(DateTime FechaInicio, DateTime FechaFin)
        {
            Conexion = new CD_Conexion();
            listaPresupuesto = new List<Presupuesto>();

            try
            {
                Conexion.SetConsultaProcedure("SpBuscar_Presupuesto_fecha");


                Conexion.SetearParametro("@txt_fecha_inicio", FechaInicio);
                Conexion.SetearParametro("@txt_fecha_fin", FechaFin);

                Conexion.EjecutarLectura();
                while (Conexion.Lector.Read())
                {
                    _Presupuesto = new Presupuesto();


                    _Presupuesto.Id = (int)Conexion.Lector["Id"];

                    _Presupuesto.Usuario = new Usuario();
                    _Presupuesto.Usuario.Nombre = (string)Conexion.Lector["Usuario"];



                    _Presupuesto.Fecha = (DateTime)Conexion.Lector["Fecha"];
                    _Presupuesto.Cliente = (string)Conexion.Lector["Cliente"];

                    _Presupuesto.Estado = (string)Conexion.Lector["Estado"];
                    _Presupuesto.Total = (decimal)Conexion.Lector["Total"];



                    listaPresupuesto.Add(_Presupuesto);
                }

                return listaPresupuesto;
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
