using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos
{
    public class CD_subCategoria
    {

        //inicializa
        private CD_Conexion Conexion;
        private SubCategoria subCategoria;
        private List<SubCategoria> listasubCategoria;


        //Metodo Mostrar

        public List<SubCategoria> ListaSubcategoria()
        {
            //instancia

            Conexion = new CD_Conexion();

            listasubCategoria = new List<SubCategoria>();

            try
            {

                Conexion.SetConsultaProcedure("SpMostrar_subcategoria");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    subCategoria = new SubCategoria();


                    subCategoria.Id = (int)Conexion.Lector["Id"];
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



        public List<SubCategoria> CargarCbo( int CategoriaId)
        {

            //instancia

            Conexion = new CD_Conexion();

            listasubCategoria = new List<SubCategoria>();

            try
            {

                Conexion.SetConsultaProcedure("SpObtener_subcategoria_por_categoria");

                Conexion.SetearParametro("@CategoriaId", CategoriaId);

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    subCategoria = new SubCategoria();


                    subCategoria.Id = (int)Conexion.Lector["Id"];
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

        public void InsertarSubcategoria(SubCategoria Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {

           
                // Validación: si ya existe, lanzar excepción
                if (ValidarSubcategoria(Nuevo.Nombre, Nuevo.Categoria.Id))
                    throw new Exception("Ya existe una Subcategoría con ese nombre.");

                Conexion.SetConsultaProcedure("SpInsertar_subcategoria");

                Conexion.SetearParametro("@Nombre", Nuevo.Nombre);

                //relacion con categoria
                Conexion.SetearParametro("@CategoriaId", Nuevo.Categoria.Id);

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

        public void EditarSubcategoria(SubCategoria subCategoria)
        {
            Conexion = new CD_Conexion();

            try
            {

                // Validar que el nuevo nombre no exista en otra subcategoría

                Conexion.SetConsulta("SELECT COUNT(*) FROM SubCategoria WHERE Nombre = @Nombre AND Id != @Id");
                Conexion.SetearParametro("@Nombre", subCategoria.Nombre);
                Conexion.SetearParametro("@Id", subCategoria.Id);

                int count = Convert.ToInt32(Conexion.EjecutarEscalar());
                if (count > 0)
                    throw new Exception("Ya existe otra Subcategoría con ese nombre.");


                Conexion.SetConsultaProcedure("SpEditar_subcategoria");

                Conexion.SetearParametro("@Id", subCategoria.Id);
                Conexion.SetearParametro("@Nombre", subCategoria.Nombre);
                //relacion con categoria
                Conexion.SetearParametro("@CategoriaId", subCategoria.Categoria.Id);

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
                Conexion.SetConsulta("SELECT COUNT(*) FROM SubCategoria WHERE Nombre = @Nombre AND CategoriaId = @CategoriaId");
                Conexion.SetearParametro("@Nombre", nombre);
                Conexion.SetearParametro("@CategoriaId", categoriaId);

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

                Conexion.SetearParametro("@Id", Id_subCategoria);


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

        public List<SubCategoria> SubcategoriaBuscar(string buscar)
        {
            Conexion = new CD_Conexion();
            listasubCategoria = new List<SubCategoria>();

            try
            {
                Conexion.SetConsultaProcedure("SpBuscar_subcategoria");


                Conexion.SetearParametro("@txt_buscar", buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    subCategoria = new SubCategoria();

                    subCategoria.Id = (int)Conexion.Lector["Id"];
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
