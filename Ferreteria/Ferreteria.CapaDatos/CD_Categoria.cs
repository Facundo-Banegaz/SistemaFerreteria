using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos
{
    public class CD_Categoria
    {
        //inicializa
        private CD_Conexion Conexion;
        private Categoria categoria;
        private List<Categoria> listaCategoria;


        //Metodo Mostrar

        public List<Categoria> ListaCategoria()
        {
            //instancia

            Conexion = new CD_Conexion();

            listaCategoria = new List<Categoria>();

            try
            {

                Conexion.SetConsultaProcedure("SpMostrar_categoria");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    categoria = new Categoria();


                    categoria.Id_Categoria = (int)Conexion.Lector["Id_Categoria"];
                    categoria.Nombre = (string)Conexion.Lector["Nombre"];
             

                    listaCategoria.Add(categoria);
                }

                return listaCategoria;
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
        public List<Categoria> CargarCbo()
        {

            //instancia

            Conexion = new CD_Conexion();

            listaCategoria = new List<Categoria>();

            try
            {

                Conexion.SetConsulta("Select Id_Categoria, Nombre from Categorias");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    categoria = new Categoria();


                    categoria.Id_Categoria = (int)Conexion.Lector["Id_Categoria"];
                    categoria.Nombre = (string)Conexion.Lector["Nombre"];
                    listaCategoria.Add(categoria);
                }

                return listaCategoria;
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

        public void InsertarCategoria(Categoria Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                // Validación: si ya existe, lanzar excepción
                if (ValidarCategoria(Nuevo.Nombre))
                    throw new Exception("Ya existe una categoría con ese nombre.");

                Conexion.SetConsultaProcedure("SpInsertar_categoria");

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

        public void EditarCategoria(Categoria categoria)
        {
            Conexion = new CD_Conexion();

            try
            {
                // Validar que el nuevo nombre no exista en otra categoría
                Conexion.SetConsulta("SELECT COUNT(*) FROM Categorias WHERE Nombre = @Nombre AND Id_Categoria != @Id_Categoria");
                Conexion.SetearParametro("@Nombre", categoria.Nombre);
                Conexion.SetearParametro("@Id_Categoria", categoria.Id_Categoria);

                int count = Convert.ToInt32(Conexion.EjecutarEscalar());
                if (count > 0)
                    throw new Exception("Ya existe otra categoría con ese nombre.");

                Conexion.SetConsultaProcedure("SpEditar_categoria");
                Conexion.SetearParametro("@Id_Categoria", categoria.Id_Categoria);
                Conexion.SetearParametro("@Nombre", categoria.Nombre);

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
        public bool ValidarCategoria(string nombre)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsulta("SELECT COUNT(*) FROM Categorias WHERE Nombre = @Nombre");
                Conexion.SetearParametro("@Nombre", nombre);

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
        public void EliminarCategoria(int Id_categoria)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpEliminar_categoria");

                Conexion.SetearParametro("@Id_Categoria", Id_categoria);


                Conexion.EjecutarAccion();


            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 547) // Error FK constraint violation
                {
                    throw new Exception("No se puede eliminar esta Categoria porque está asociada a una o más Subcategorias.");
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

        public List<Categoria> CategoriaBuscar(string buscar)
        {
            Conexion = new CD_Conexion();
            listaCategoria = new List<Categoria>();

            try
            {
                Conexion.SetConsultaProcedure("SpBuscar_categoria");


                Conexion.SetearParametro("@txt_buscar", buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    categoria = new Categoria();

                    categoria.Id_Categoria= (int)Conexion.Lector["Id_Categoria"];
                    categoria.Nombre = (string)Conexion.Lector["Nombre"];
           
                    listaCategoria.Add(categoria);
                }


                return listaCategoria;
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
