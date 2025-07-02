using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos
{
    public class CD_Marca
    {
        //inicializa
        private CD_Conexion Conexion;
        private Marca marca;
        private List<Marca> listaMarca;



        //Metodo Mostrar

        public List<Marca> ListaMarca()
        {
            //instancia

            Conexion = new CD_Conexion();

            listaMarca = new List<Marca>();

            try
            {

                Conexion.SetConsultaProcedure("SpMostrar_Marcas");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    marca = new Marca();


                    marca.Id_Marca = (int)Conexion.Lector["Id_Marca"];
                    marca.Nombre = (string)Conexion.Lector["Nombre"];
                    

             

                    listaMarca.Add(marca);
                }

                return listaMarca;
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
        public List<Marca> CargarCbo()
        {

            //instancia

            Conexion = new CD_Conexion();

            listaMarca = new List<Marca>();

            try
            {

                Conexion.SetConsulta("Select Id_Marca, Nombre from Marcas");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    marca = new Marca();


                    marca.Id_Marca = (int)Conexion.Lector["Id_Marca"];
                    marca.Nombre = (string)Conexion.Lector["Nombre"];
                    listaMarca.Add(marca);
                }

                return listaMarca;
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

        public void InsertarMarca(Marca Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {

                // Validación: si ya existe, lanzar excepción
                if (ValidarMarca(Nuevo.Nombre))
                    throw new Exception("Ya existe una Marca con ese nombre.");

                Conexion.SetConsultaProcedure("SpInsertar_Marca");

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

        public void EditarMarca(Marca Marca)
        {
            Conexion = new CD_Conexion();

            try
            {
                // Validar que el nuevo nombre no exista en otra categoría
                Conexion.SetConsulta("SELECT COUNT(*) FROM Marcas WHERE Nombre = @Nombre AND Id_Marca != @Id_Marca");
                Conexion.SetearParametro("@Nombre", Marca.Nombre);
                Conexion.SetearParametro("@Id_Marca", Marca.Id_Marca);

                int count = Convert.ToInt32(Conexion.EjecutarEscalar());
                if (count > 0)
                    throw new Exception("Ya existe otra Marca con ese nombre.");


                Conexion.SetConsultaProcedure("SpEditar_Marca");

                Conexion.SetearParametro("@Id_Marca", Marca.Id_Marca);
                Conexion.SetearParametro("@Nombre", Marca.Nombre);


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


        public bool ValidarMarca(string nombre)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsulta("SELECT COUNT(*) FROM Marcas WHERE Nombre = @Nombre");
                Conexion.SetearParametro("@Nombre", nombre);

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
        public void EliminarMarca(int Id_Marca)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpEliminar_Marca");
                Conexion.SetearParametro("@Id_Marca", Id_Marca);
                Conexion.EjecutarAccion();
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 547) // Error FK constraint violation
                {
                    throw new Exception("No se puede eliminar esta marca porque está asociada a uno o más productos.");
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }


        //Metodo Buscar

        public List<Marca> MarcaBuscar(string buscar)
        {
            Conexion = new CD_Conexion();
            listaMarca = new List<Marca>();

            try
            {
                Conexion.SetConsultaProcedure("SpBuscar_Marca");


                Conexion.SetearParametro("@txt_buscar", buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    marca = new Marca();

                    marca.Id_Marca = (int)Conexion.Lector["Id_Marca"];
                    marca.Nombre = (string)Conexion.Lector["Nombre"];
             

                    listaMarca.Add(marca);
                }


                return listaMarca;
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

