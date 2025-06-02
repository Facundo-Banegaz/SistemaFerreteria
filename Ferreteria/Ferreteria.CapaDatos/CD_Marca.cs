using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
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

                Conexion.SetConsultaProcedure("SpMostrar_Marca");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    marca = new Marca();


                    marca.Id = (int)Conexion.Lector["Id"];
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

                Conexion.SetConsulta("Select Id, Nombre from Marca");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    marca = new Marca();


                    marca.Id = (int)Conexion.Lector["Id"];
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
                Conexion.SetConsultaProcedure("SpEditar_Marca");

                Conexion.SetearParametro("@Id", Marca.Id);
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

        //Metodo eliminar
        public void EliminarMarca(int Id_Marca)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpEliminar_Marca");

                Conexion.SetearParametro("@Id", Id_Marca);


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

                    marca.Id = (int)Conexion.Lector["Id"];
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

