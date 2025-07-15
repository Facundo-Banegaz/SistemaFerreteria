using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos
{
    public class CD_UnidadMedida
    {
        //inicializa
        private CD_Conexion Conexion;
        private UnidadMedida UnidadMedida;
        private List<UnidadMedida> listaUnidadMedida;


        //Metodo Mostrar

        public List<UnidadMedida> ListaUnidadMedida()
        {

            //instancia

            Conexion = new CD_Conexion();

            listaUnidadMedida = new List<UnidadMedida>();

            try
            {

                Conexion.SetConsultaProcedure("SpMostrar_UnidadMedida");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    UnidadMedida = new UnidadMedida();


                    UnidadMedida.Id_UnidadMedida = (int)Conexion.Lector["Id_UnidadMedida"];
                    UnidadMedida.Nombre = (string)Conexion.Lector["Nombre"];
                    UnidadMedida.Abreviacion = (string)Conexion.Lector["Abreviacion"];
                    UnidadMedida.PermiteDecimales = (bool)Conexion.Lector["PermiteDecimales"];
                    listaUnidadMedida.Add(UnidadMedida);
                }

                return listaUnidadMedida;
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
        public List<UnidadMedida> CargarCbo()
        {

            //instancia

            Conexion = new CD_Conexion();

            listaUnidadMedida = new List<UnidadMedida>();

            try
            {

                Conexion.SetConsulta("Select Id_UnidadMedida, Nombre, Abreviacion from UnidadMedida");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    UnidadMedida = new UnidadMedida();


                    UnidadMedida.Id_UnidadMedida = (int)Conexion.Lector["Id_UnidadMedida"];
                    UnidadMedida.Nombre = (string)Conexion.Lector["Nombre"];
          
                    listaUnidadMedida.Add(UnidadMedida);
                }

                return listaUnidadMedida;
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

        public void InsertarUnidadMedida(UnidadMedida Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpInsertar_UnidadMedida");

                Conexion.SetearParametro("@Nombre", Nuevo.Nombre);
                Conexion.SetearParametro("@Abreviacion", Nuevo.Abreviacion);
                Conexion.SetearParametro("@PermiteDecimales", Nuevo.PermiteDecimales);
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

        public void EditarUnidadMedida(UnidadMedida UnidadMedida)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpEditar_UnidadMedida");

                Conexion.SetearParametro("@Id_UnidadMedida", UnidadMedida.Id_UnidadMedida);
                Conexion.SetearParametro("@Nombre", UnidadMedida.Nombre);
                Conexion.SetearParametro("@Abreviacion", UnidadMedida.Abreviacion);
                Conexion.SetearParametro("@PermiteDecimales", UnidadMedida.PermiteDecimales);

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
        public void EliminarUnidadMedida(int Id_UnidadMedida)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpEliminar_UnidadMedida");

                Conexion.SetearParametro("@Id_UnidadMedida", Id_UnidadMedida);


                Conexion.EjecutarAccion();


            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 547) // Violación FK
                {
                    throw new Exception("No se puede eliminar esta UnidadMedida porque está relacionada con otros registros.");
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

        public List<UnidadMedida> UnidadMedidaBuscar(string buscar)
        {
            Conexion = new CD_Conexion();
            listaUnidadMedida = new List<UnidadMedida>();

            try
            {
                Conexion.SetConsultaProcedure("SpBuscar_UnidadMedida");


                Conexion.SetearParametro("@txt_buscar", buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    UnidadMedida = new UnidadMedida();

                    UnidadMedida.Id_UnidadMedida = (int)Conexion.Lector["Id_UnidadMedida"];
                    UnidadMedida.Nombre = (string)Conexion.Lector["Nombre"];
                    UnidadMedida.Abreviacion = (string)Conexion.Lector["Abreviacion"];
                    UnidadMedida.PermiteDecimales = (bool)Conexion.Lector["PermiteDecimales"];

                    listaUnidadMedida.Add(UnidadMedida);
                }


                return listaUnidadMedida;
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
