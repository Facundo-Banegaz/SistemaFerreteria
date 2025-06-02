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

        public List<SubCategoria> ListasubCategoria()
        {
            //instancia

            Conexion = new CD_Conexion();

            listasubCategoria = new List<SubCategoria>();

            try
            {

                Conexion.SetConsultaProcedure("SpMostrar_subCategoria");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    subCategoria = new SubCategoria();


                    subCategoria.Id = (int)Conexion.Lector["Id"];
                    subCategoria.Nombre = (string)Conexion.Lector["Nombre"];

                    subCategoria.Categoria = new Categoria();

                    subCategoria.Categoria.Nombre  = (string)Conexion.Lector["Categoria"];

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

        public void InsertarsubCategoria(SubCategoria Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpInsertar_subCategoria");

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

        public void EditarsubCategoria(SubCategoria subCategoria)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpEditar_subCategoria");

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

        //Metodo eliminar
        public void EliminarsubCategoria(int Id_subCategoria)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpEliminar_subCategoria");

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

        public List<SubCategoria> subCategoriaBuscar(string buscar)
        {
            Conexion = new CD_Conexion();
            listasubCategoria = new List<SubCategoria>();

            try
            {
                Conexion.SetConsultaProcedure("SpBuscar_subCategoria");


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
