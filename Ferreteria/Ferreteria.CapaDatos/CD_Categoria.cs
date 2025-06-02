using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
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


                    categoria.Id = (int)Conexion.Lector["Id"];
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

                Conexion.SetConsulta("Select Id, Nombre from Categoria");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    categoria = new Categoria();


                    categoria.Id = (int)Conexion.Lector["Id"];
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
                Conexion.SetConsultaProcedure("SpEditar_categoria");

                Conexion.SetearParametro("@Id", categoria.Id);
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

        //Metodo eliminar
        public void EliminarCategoria(int Id_categoria)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpEliminar_categoria");

                Conexion.SetearParametro("@Id", Id_categoria);


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

                    categoria.Id = (int)Conexion.Lector["Id"];
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
