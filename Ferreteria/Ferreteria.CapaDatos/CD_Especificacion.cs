
using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

                    Especificacion.Producto.Id_Producto = (int)Conexion.Lector["Id_Producto"];

                    Especificacion.Producto.Nombre = (string)Conexion.Lector["Producto"];
                    Especificacion.Producto.Codigo = (string)Conexion.Lector["Codigo"];
                    Especificacion.Producto.Descripcion = (string)Conexion.Lector["Descripcion"];







                    Especificacion.TipoEspecificacion = new TipoEspecificacion();

                    Especificacion.TipoEspecificacion.Id_TipoEspecificacion = (int)Conexion.Lector["Id_TipoEspecificacion"];
                    Especificacion.TipoEspecificacion.Nombre = (string)Conexion.Lector["TipoEspecificacion"];


                    Especificacion.ValorEspecificacion = new ValorEspecificacion();

                    Especificacion.ValorEspecificacion.Id_ValorEspecificacion = (int)Conexion.Lector["Id_ValorEspecificacion"];
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

        public List<Especificacion> MostrarDetalleEspecificacionesPorProducto(int Id_Producto)
        {
            Conexion = new CD_Conexion();
            listaEspecificacion = new List<Especificacion>();

            try
            {
                Conexion.SetConsultaProcedure("SpMostrar_Detalle_EspecificacionesPorProducto");


                Conexion.SetearParametro("@Id_Producto", Id_Producto);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {


                    Especificacion = new Especificacion();




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
                if (EspecificacionExiste(Nuevo.Producto.Id_Producto, Nuevo.TipoEspecificacion.Id_TipoEspecificacion, Nuevo.ValorEspecificacion.Id_ValorEspecificacion))
                {
                    throw new Exception("La especificación ya existe para ese producto con ese tipo y valor.");
                }


                Conexion.SetConsultaProcedure("Sp_Insertar_Especificacion");

                //relaciones
                Conexion.SetearParametro("@Id_Producto", Nuevo.Producto.Id_Producto);
                Conexion.SetearParametro("@Id_TipoEspecificacion", Nuevo.TipoEspecificacion.Id_TipoEspecificacion);
                Conexion.SetearParametro("@Id_ValorEspecificacion", Nuevo.ValorEspecificacion.Id_ValorEspecificacion);


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
                if (EspecificacionExiste(Especificacion.Producto.Id_Producto, Especificacion.TipoEspecificacion.Id_TipoEspecificacion, Especificacion.ValorEspecificacion.Id_ValorEspecificacion, Especificacion.Id_Especificacion))
                {
                    throw new Exception("Ya existe otra especificación con la misma combinación de producto, tipo y valor.");
                }


                Conexion.SetConsultaProcedure("Sp_Editar_Especificacion");

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
        public bool EspecificacionExiste(int Id_Producto, int Id_TipoEspecificacion, int Id_ValorEspecificacion, int? Id_Especificacion = null)
        {
            Conexion = new CD_Conexion();

            try
            {
                string consulta = "SELECT COUNT(*) FROM Especificaciones WHERE Id_Producto = @Id_Producto AND Id_TipoEspecificacion = @Id_TipoEspecificacion AND Id_ValorEspecificacion = @Id_ValorEspecificacion";

                // Si estás editando, evitá que cuente el mismo registro
                if (Id_Especificacion.HasValue)
                {
                    consulta += " AND Id_Especificacion != @Id_Especificacion";
                }

                Conexion.SetConsulta(consulta);
                Conexion.SetearParametro("@Id_Producto", Id_Producto);
                Conexion.SetearParametro("@Id_TipoEspecificacion", Id_TipoEspecificacion);
                Conexion.SetearParametro("@Id_ValorEspecificacion", Id_ValorEspecificacion);

                if (Id_Especificacion.HasValue)
                    Conexion.SetearParametro("@Id_Especificacion", Id_Especificacion.Value);

                int count = Convert.ToInt32(Conexion.EjecutarEscalar());
                return count > 0;
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
                Conexion.SetConsultaProcedure("Sp_Eliminar_Especificacion");

                Conexion.SetearParametro("@Id_Especificacion", Id_Especificacion);


                Conexion.EjecutarAccion();


            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 547) // Violación FK
                {
                    throw new Exception("No se puede eliminar esta especificación porque está relacionada con otros registros.");
                }
                else
                {
                    throw;
                }
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
                Conexion.SetConsultaProcedure("Sp_Buscar_Especificaciones");


                Conexion.SetearParametro("@Texto_Buscar", buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    Especificacion = new Especificacion();


                    Especificacion.Id_Especificacion = (int)Conexion.Lector["Id_Especificacion"];


                    Especificacion.Producto = new Producto();

                    Especificacion.Producto.Id_Producto = (int)Conexion.Lector["Id_Producto"];

                    Especificacion.Producto.Nombre = (string)Conexion.Lector["Producto"];
                    Especificacion.Producto.Codigo = (string)Conexion.Lector["Codigo"];
                    Especificacion.Producto.Descripcion = (string)Conexion.Lector["Descripcion"];

                   


                    Especificacion.TipoEspecificacion = new TipoEspecificacion();

                    Especificacion.TipoEspecificacion.Id_TipoEspecificacion = (int)Conexion.Lector["Id_TipoEspecificacion"];
                    Especificacion.TipoEspecificacion.Nombre = (string)Conexion.Lector["TipoEspecificacion"];


                    Especificacion.ValorEspecificacion = new ValorEspecificacion();

                    Especificacion.ValorEspecificacion.Id_ValorEspecificacion = (int)Conexion.Lector["Id_ValorEspecificacion"];
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
