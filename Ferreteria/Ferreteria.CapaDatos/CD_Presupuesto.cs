using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

                Conexion.SetConsultaProcedure("SpMostrar_Presupuestos");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    _Presupuesto = new Presupuesto();


                    _Presupuesto.Id_Presupuesto= (int)Conexion.Lector["Id_Presupuesto"];

                    _Presupuesto.Usuario = new Usuario();
                    _Presupuesto.Usuario.Id_Usuario = (int)Conexion.Lector["Id_Usuario"];

                    _Presupuesto.Usuario.Nombre = (string)Conexion.Lector["Usuario"];

                    _Presupuesto.Serie = (string)Conexion.Lector["Serie"];

                    _Presupuesto.Correlativo = (string)Conexion.Lector["Correlativo"];

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


        public void InsertarPresupuesto(Presupuesto nuevo, List<DetallePresupuesto> detalles)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.IniciarTransaccion(); // Abre conexión y transacción

                Conexion.SetConsultaProcedure("Sp_Insertar_Presupuesto");

                Conexion.SetearParametro("@Id_Usuario", nuevo.Usuario.Id_Usuario);
                Conexion.SetearParametro("@Fecha", nuevo.Fecha.ToString("yyyy-MM-dd HH:mm:ss"));
                Conexion.SetearParametro("@Cliente", nuevo.Cliente);
                Conexion.SetearParametro("@Serie", nuevo.Serie);
                Conexion.SetearParametro("@Correlativo", nuevo.Correlativo);
                Conexion.SetearParametro("@Estado", nuevo.Estado ?? "Activo");
                Conexion.SetearParametroSalida("@Id_Presupuesto", SqlDbType.Int);

                Conexion.EjecutarAccion();

                int idPresupuesto = Conexion.ObtenerValorParametroSalida("@Id_Presupuesto");

                SqlConnection conn = Conexion.ObtenerConexion();
                SqlTransaction trans = Conexion.ObtenerTransaccion();

                CD_DetallePresupuesto detallePresupuestoDatos = new CD_DetallePresupuesto();

                foreach (var detalle in detalles)
                {
                    detalle.Presupuesto = new Presupuesto { Id_Presupuesto = idPresupuesto };
                    detallePresupuestoDatos.InsertarDetallePresupuesto(detalle, conn, trans);
                }

                Conexion.ConfirmarTransaccion(); // Si todo va bien, commitea
            }
            catch
            {
                Conexion.AnularTransaccion(); // Rollback si falla algo
                throw;
            }
            finally
            {
                Conexion.CerrarConexion(); // Cierre limpio
            }
        }


        //Metodo Estado
        public void CambiarEstadoPresupuesto(int Id_Presupuesto)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpCambiarEstado_Presupuesto");
                Conexion.SetearParametro("@Id_Presupuesto", Id_Presupuesto);
                Conexion.EjecutarAccion();
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 50001:
                        throw new Exception("El presupuesto no fue encontrado.");
                    default:
                        throw new Exception("Error al cambiar el estado del presupuesto: " + ex.Message);
                }
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
                Conexion.SetConsultaProcedure("Sp_BuscarPresupuestoPorFecha");


                Conexion.SetearParametro("@FechaInicio", FechaInicio);
                Conexion.SetearParametro("@FechaFin", FechaFin);

                Conexion.EjecutarLectura();
                while (Conexion.Lector.Read())
                {
                    _Presupuesto = new Presupuesto();


                    _Presupuesto.Id_Presupuesto = (int)Conexion.Lector["Id_Presupuesto"];

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
