using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos
{
    public class CD_subCategoria
    {

        //inicializa
        private CD_Conexion Conexion;
        private Subcategoria subCategoria;
        private List<Subcategoria> listasubCategoria;


        //Metodo Mostrar

        public List<Subcategoria> ListaSubcategoria()
        {
            //instancia

            Conexion = new CD_Conexion();

            listasubCategoria = new List<Subcategoria>();

            try
            {

                Conexion.SetConsultaProcedure("SpMostrar_subcategoria");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    subCategoria = new Subcategoria();


                    subCategoria.Id_Subcategoria = (int)Conexion.Lector["Id_Subcategoria"];
                    subCategoria.Nombre = (string)Conexion.Lector["Nombre"];
                    subCategoria.Categoria = new Categoria();


                    subCategoria.Categoria.Id_Categoria = (int)Conexion.Lector["Id_Categoria"];
                    subCategoria.Categoria.Nombre = (string)Conexion.Lector["Categoria"];
                    listasubCategoria.Add(subCategoria);
                }

                return listasubCategoria;
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



        public List<Subcategoria> CargarCbo( int Id_Categoria)
        {

            //instancia

            Conexion = new CD_Conexion();

            listasubCategoria = new List<Subcategoria>();

            try
            {

                Conexion.SetConsultaProcedure("SpObtener_subcategoria_por_categoria");

                Conexion.SetearParametro("@Id_Categoria", Id_Categoria);

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    subCategoria = new Subcategoria();


                    subCategoria.Id_Subcategoria = (int)Conexion.Lector["Id_Subcategoria"];
                    subCategoria.Nombre = (string)Conexion.Lector["Nombre"];
                    listasubCategoria.Add(subCategoria);
                }

                return listasubCategoria;
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

        public void InsertarSubcategoria(Subcategoria Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {

           
                // Validación: si ya existe, lanzar excepción
                if (ValidarSubcategoria(Nuevo.Nombre, Nuevo.Categoria.Id_Categoria))
                    throw new Exception("Ya existe una Subcategoría con ese nombre.");

                Conexion.SetConsultaProcedure("SpInsertar_subcategoria");

                Conexion.SetearParametro("@Nombre", Nuevo.Nombre);

                //relacion con categoria
                Conexion.SetearParametro("@Id_Categoria", Nuevo.Categoria.Id_Categoria);

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

        public void EditarSubcategoria(Subcategoria subCategoria)
        {
            Conexion = new CD_Conexion();

            try
            {

                // Validar que el nuevo nombre no exista en otra subcategoría

                Conexion.SetConsulta("SELECT COUNT(*) FROM Subcategorias WHERE Nombre = @Nombre AND Id_Subcategoria != @Id_Subcategoria");
                Conexion.SetearParametro("@Nombre", subCategoria.Nombre);
                Conexion.SetearParametro("@Id_Subcategoria", subCategoria.Id_Subcategoria);

                int count = Convert.ToInt32(Conexion.EjecutarEscalar());
                if (count > 0)
                    throw new Exception("Ya existe otra Subcategoría con ese nombre.");


                Conexion.SetConsultaProcedure("SpEditar_subcategoria");

                Conexion.SetearParametro("@Id_Subcategoria", subCategoria.Id_Subcategoria);
                Conexion.SetearParametro("@Nombre", subCategoria.Nombre);

                //relacion con categoria
                Conexion.SetearParametro("@Id_Categoria", subCategoria.Categoria.Id_Categoria);

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


        //Metodo Validar
        public bool ValidarSubcategoria(string nombre, int categoriaId)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsulta("SELECT COUNT(*) FROM Subcategorias WHERE Nombre = @Nombre AND Id_Categoria = @Id_Categoria");
                Conexion.SetearParametro("@Nombre", nombre);
                Conexion.SetearParametro("@Id_Categoria", categoriaId);

                int cantidad = Convert.ToInt32(Conexion.EjecutarEscalar());
                return cantidad > 0;
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
        public void EliminarSubcategoria(int Id_subCategoria)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpEliminar_subcategoria");

                Conexion.SetearParametro("@Id_Subcategoria", Id_subCategoria);


                Conexion.EjecutarAccion();


            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 547) // Error FK constraint violation
                {
                    throw new Exception("No se puede eliminar esta Subcategoria porque está asociada a uno o más productos.");
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

        public List<Subcategoria> SubcategoriaBuscar(string buscar)
        {
            Conexion = new CD_Conexion();
            listasubCategoria = new List<Subcategoria>();

            try
            {
                Conexion.SetConsultaProcedure("SpBuscar_subcategoria");


                Conexion.SetearParametro("@txt_buscar", buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    subCategoria = new Subcategoria();

                    subCategoria.Id_Subcategoria = (int)Conexion.Lector["Id_Subcategoria"];
                    subCategoria.Nombre = (string)Conexion.Lector["Nombre"];

                    subCategoria.Categoria = new Categoria();

                    subCategoria.Categoria.Nombre = (string)Conexion.Lector["Categoria"];
                    listasubCategoria.Add(subCategoria);
                }


                return listasubCategoria;
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
