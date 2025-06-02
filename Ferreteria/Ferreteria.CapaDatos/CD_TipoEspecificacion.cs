using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos
{
    public class CD_TipoEspecificacion
    {
        //inicializa
        private CD_Conexion Conexion;
        private TipoEspecificacion TipoEspecificacion;
        private List<TipoEspecificacion> listaTipoEspecificacion;


        //Metodo Mostrar

        public List<TipoEspecificacion> ListaTipoEspecificacion()
        {
            //instancia

            Conexion = new CD_Conexion();

            listaTipoEspecificacion = new List<TipoEspecificacion>();

            try
            {

                Conexion.SetConsultaProcedure("SpMostrar_TipoEspecificacion");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    TipoEspecificacion = new TipoEspecificacion();


                    TipoEspecificacion.Id = (int)Conexion.Lector["Id"];
                    TipoEspecificacion.Nombre = (string)Conexion.Lector["Nombre"];


                    listaTipoEspecificacion.Add(TipoEspecificacion);
                }

                return listaTipoEspecificacion;
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


        //Metodo del ComboBox
        public List<TipoEspecificacion> CargarCbo()
        {

            //instancia

            Conexion = new CD_Conexion();

            listaTipoEspecificacion = new List<TipoEspecificacion>();

            try
            {

                Conexion.SetConsulta("Select Id, Nombre from TipoEspecificacion");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    TipoEspecificacion = new TipoEspecificacion();


                    TipoEspecificacion.Id = (int)Conexion.Lector["Id"];
                    TipoEspecificacion.Nombre = (string)Conexion.Lector["Nombre"];
                    listaTipoEspecificacion.Add(TipoEspecificacion);
                }

                return listaTipoEspecificacion;
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

        public void InsertarTipoEspecificacion(TipoEspecificacion Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpInsertar_TipoEspecificacion");

                Conexion.SetearParametro("@Nombre", Nuevo.Nombre);


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


        //metodo editar

        public void EditarTipoEspecificacion(TipoEspecificacion TipoEspecificacion)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpEditar_TipoEspecificacion");

                Conexion.SetearParametro("@Id", TipoEspecificacion.Id);
                Conexion.SetearParametro("@Nombre", TipoEspecificacion.Nombre);


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

        //Metodo eliminar
        public void EliminarTipoEspecificacion(int Id_TipoEspecificacion)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpEliminar_TipoEspecificacion");

                Conexion.SetearParametro("@Id", Id_TipoEspecificacion);


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

        //Metodo Buscar

        public List<TipoEspecificacion> TipoEspecificacionBuscar(string buscar)
        {
            Conexion = new CD_Conexion();
            listaTipoEspecificacion = new List<TipoEspecificacion>();

            try
            {
                Conexion.SetConsultaProcedure("SpBuscar_TipoEspecificacion");


                Conexion.SetearParametro("@txt_buscar", buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    TipoEspecificacion = new TipoEspecificacion();

                    TipoEspecificacion.Id = (int)Conexion.Lector["Id"];
                    TipoEspecificacion.Nombre = (string)Conexion.Lector["Nombre"];

                    listaTipoEspecificacion.Add(TipoEspecificacion);
                }


                return listaTipoEspecificacion;
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
