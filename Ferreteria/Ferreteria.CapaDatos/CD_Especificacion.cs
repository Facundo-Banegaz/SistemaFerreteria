
using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos
{
    public class CD_Especificacion
    {

        //inicializa
        private CD_Conexion Conexion;
        private Especificacion Especificacion;
        private List<Especificacion> listaEspecificacion;


        //Metodo Mostrar

        public List<Especificacion> ListaEspecificacion()
        {
            //instancia

            Conexion = new CD_Conexion();

            listaEspecificacion = new List<Especificacion>();

            try
            {

                Conexion.SetConsultaProcedure("SpMostrar_Especificacion");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    Especificacion = new Especificacion();


                    Especificacion.Id = (int)Conexion.Lector["Id"];
           

                    Especificacion.Producto = new Producto();

                    Especificacion.Producto.Nombre = (string)Conexion.Lector["Producto"];



                    Especificacion.TipoEspecificacion = new TipoEspecificacion();

                    Especificacion.TipoEspecificacion.Nombre = (string)Conexion.Lector["TipoEspecificacion"];


                    Especificacion.ValorEspecificacion = new ValorEspecificacion();

                    Especificacion.ValorEspecificacion.Valor = (string)Conexion.Lector["ValorEspecificacion"];



                    listaEspecificacion.Add(Especificacion);
                }

                return listaEspecificacion;
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

        public void InsertarEspecificacion(Especificacion Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpInsertar_Especificacion");

                Conexion.SetearParametro("@Id", Especificacion.Id);

                //relaciones
                Conexion.SetearParametro("@ProductoId", Especificacion.Producto.Id);
                Conexion.SetearParametro("@TipoEspecificacionId", Especificacion.TipoEspecificacion.Id);
                Conexion.SetearParametro("@ValorEspecificacionId", Especificacion.ValorEspecificacion.Id);


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

        public void EditarEspecificacion(Especificacion Especificacion)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpEditar_Especificacion");

                Conexion.SetearParametro("@Id", Especificacion.Id);

                //relaciones
                Conexion.SetearParametro("@ProductoId", Especificacion.Producto.Id);
                Conexion.SetearParametro("@TipoEspecificacionId", Especificacion.TipoEspecificacion.Id);
                Conexion.SetearParametro("@ValorEspecificacionId", Especificacion.ValorEspecificacion.Id);
               

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
        public void EliminarEspecificacion(int Id_Especificacion)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpEliminar_Especificacion");

                Conexion.SetearParametro("@Id", Id_Especificacion);


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

        public List<Especificacion> EspecificacionBuscar(string buscar)
        {
            Conexion = new CD_Conexion();
            listaEspecificacion = new List<Especificacion>();

            try
            {
                Conexion.SetConsultaProcedure("SpBuscar_Especificacion");


                Conexion.SetearParametro("@txt_buscar", buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    Especificacion = new Especificacion();


                    Especificacion.Id = (int)Conexion.Lector["Id"];


                    Especificacion.Producto = new Producto();

                    Especificacion.Producto.Nombre = (string)Conexion.Lector["Producto"];



                    Especificacion.TipoEspecificacion = new TipoEspecificacion();

                    Especificacion.TipoEspecificacion.Nombre = (string)Conexion.Lector["TipoEspecificacion"];


                    Especificacion.ValorEspecificacion = new ValorEspecificacion();

                    Especificacion.ValorEspecificacion.Valor = (string)Conexion.Lector["ValorEspecificacion"];


                    listaEspecificacion.Add(Especificacion);
                }


                return listaEspecificacion;
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
