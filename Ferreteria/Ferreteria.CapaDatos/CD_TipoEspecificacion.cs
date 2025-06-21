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

                Conexion.SetConsultaProcedure("SpMostrar_TiposEspecificacion");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    TipoEspecificacion = new TipoEspecificacion();


                    TipoEspecificacion.Id_TipoEspecificacion = (int)Conexion.Lector["Id_TipoEspecificacion"];
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

                Conexion.SetConsulta("Select Id, Nombre from TiposEspecificacion");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    TipoEspecificacion = new TipoEspecificacion();


                    TipoEspecificacion.Id_TipoEspecificacion = (int)Conexion.Lector["Id_TipoEspecificacion"];
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
                // Validación: si ya existe, lanzar excepción
                if (ValidarTipoEspecificacion(Nuevo.Nombre))
                    throw new Exception("Ya existe un Tipo de Especificacion con ese nombre.");

                Conexion.SetConsultaProcedure("Sp_Insertar_TipoEspecificacion");

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
                // Validar que el nuevo nombre no exista en otra TipoEspecificacion
                Conexion.SetConsulta("SELECT COUNT(*) FROM TiposEspecificacion WHERE Nombre = @Nombre AND Id_TipoEspecificacion != @Id_TipoEspecificacion");
                Conexion.SetearParametro("@Nombre", TipoEspecificacion.Nombre);
                Conexion.SetearParametro("@Id_TipoEspecificacion", TipoEspecificacion.Id_TipoEspecificacion);


                Conexion.SetConsultaProcedure("Sp_Editar_TipoEspecificacion");

                Conexion.SetearParametro("@Id_TipoEspecificacion", TipoEspecificacion.Id_TipoEspecificacion);
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
        public bool ValidarTipoEspecificacion(string Nombre)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsulta("SELECT COUNT(*) FROM TiposEspecificacion WHERE Nombre = @Nombre");
                Conexion.SetearParametro("@Nombre", Nombre);

                int count = Convert.ToInt32(Conexion.EjecutarEscalar());
                return count > 0; // true si ya existe
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
                Conexion.SetConsultaProcedure("Sp_Eliminar_TipoEspecificacion");

                Conexion.SetearParametro("@Id_TipoEspecificacion", Id_TipoEspecificacion);


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
                Conexion.SetConsultaProcedure("Sp_Buscar_TiposEspecificacion");


                Conexion.SetearParametro("@Texto_Buscar", buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    TipoEspecificacion = new TipoEspecificacion();

                    TipoEspecificacion.Id_TipoEspecificacion = (int)Conexion.Lector["Id_TipoEspecificacion"];
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
