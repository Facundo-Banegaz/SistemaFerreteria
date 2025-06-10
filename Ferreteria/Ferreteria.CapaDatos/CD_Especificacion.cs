
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

                Conexion.SetConsultaProcedure("SpMostrar_Especificaciones");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    Especificacion = new Especificacion();


                    Especificacion.Id_Especificacion = (int)Conexion.Lector["Id_Especificacion"];
           

                    Especificacion.Producto = new Producto();

                    Especificacion.Producto.Nombre = (string)Conexion.Lector["Producto"];
                    Especificacion.Producto.Codigo = (string)Conexion.Lector["Codigo"];
                    Especificacion.Producto.Descripcion = (string)Conexion.Lector["Descripcion"];

                    Especificacion.TipoEspecificacion = new TipoEspecificacion();

                    Especificacion.TipoEspecificacion.Nombre = (string)Conexion.Lector["TiposEspecificacion"];


                    Especificacion.ValorEspecificacion = new ValorEspecificacion();

                    Especificacion.ValorEspecificacion.Valor = (string)Conexion.Lector["ValoresEspecificacion"];



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

                Conexion.SetearParametro("@Id_Especificacion", Especificacion.Id_Especificacion);

                //relaciones
                Conexion.SetearParametro("@Id_Producto", Especificacion.Producto.Id_Producto);
                Conexion.SetearParametro("@Id_TipoEspecificacion", Especificacion.TipoEspecificacion.Id_TipoEspecificacion);
                Conexion.SetearParametro("@Id_ValorEspecificacion", Especificacion.ValorEspecificacion.Id_ValorEspecificacion);


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

                Conexion.SetearParametro("@Id_Especificacion", Especificacion.Id_Especificacion);

                //relaciones
                Conexion.SetearParametro("@Id_Producto", Especificacion.Producto.Id_Producto);
                Conexion.SetearParametro("@Id_TipoEspecificacionId", Especificacion.TipoEspecificacion.Id_TipoEspecificacion);
                Conexion.SetearParametro("@Id_ValorEspecificacionId", Especificacion.ValorEspecificacion.Id_ValorEspecificacion);
               

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

                Conexion.SetearParametro("@Id_Especificacion", Id_Especificacion);


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
                Conexion.SetConsultaProcedure("SpBuscar_Especificaciones");


                Conexion.SetearParametro("@Texto_Buscar", buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    Especificacion = new Especificacion();


                    Especificacion.Id_Especificacion = (int)Conexion.Lector["Id_Especificacion"];


                    Especificacion.Producto = new Producto();

                    Especificacion.Producto.Nombre = (string)Conexion.Lector["Producto"];
                    Especificacion.Producto.Codigo = (string)Conexion.Lector["Codigo"];
                    Especificacion.Producto.Descripcion = (string)Conexion.Lector["Descripcion"];

                    Especificacion.TipoEspecificacion = new TipoEspecificacion();

                    Especificacion.TipoEspecificacion.Nombre = (string)Conexion.Lector["TiposEspecificacion"];


                    Especificacion.ValorEspecificacion = new ValorEspecificacion();

                    Especificacion.ValorEspecificacion.Valor = (string)Conexion.Lector["ValoresEspecificacion"];



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
