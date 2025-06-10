using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos
{
    public class CD_Proveedor
    {
        private CD_Conexion Conexion;
        private Proveedor Proveedor;

        private List<Proveedor> listaProveedor;

        public List<Proveedor> ListarProveedores()
        {

            Conexion = new CD_Conexion();
            listaProveedor = new List<Proveedor>();


            try
            {
                Conexion.SetConsultaProcedure("SpMostrar_Proveedor");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    Proveedor = new Proveedor();

                    Proveedor.Id_Proveedor = (int)Conexion.Lector["Id_Proveedor"];
                    Proveedor.Nombre = (string)Conexion.Lector["Nombre"];
                  


                    listaProveedor.Add(Proveedor);


                }

                return listaProveedor;
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
        public List<Proveedor> CargarCbo()
        {

            //instancia

            Conexion = new CD_Conexion();

            listaProveedor = new List<Proveedor>();

            try
            {

                Conexion.SetConsulta("select Id_Proveedor, Nombre from Proveedores");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    Proveedor = new Proveedor();


                    Proveedor.Id_Proveedor = (int)Conexion.Lector["Id_Proveedor"];
                    Proveedor.Nombre = (string)Conexion.Lector["Nombre"];

                    listaProveedor.Add(Proveedor);
                }

                return listaProveedor;
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
        public bool ValidarProveedor(string Nombre)
        {
            Conexion = new CD_Conexion();
            try
            {
                Conexion.SetConsulta("SELECT COUNT(*) FROM Proveedores WHERE Nombre = @Nombre");
                Conexion.SetearParametro("@Nombre", Nombre);

                Conexion.EjecutarLectura();

                // Verificar si hay alguna fila devuelta por la consulta
                if (Conexion.Lector.HasRows)
                {
                    // Leer el valor del primer campo (que es el resultado del conteo)
                    Conexion.Lector.Read();
                    int count = Convert.ToInt32(Conexion.Lector[0]);
                    return count > 0;
                }
                else
                {
                    // Si no hay filas, no hay resultados, por lo que el cliente no existe
                    return false;
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

 
        //metodo insertar

        public void InsertarProveedor(Proveedor Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                // Validación: si ya existe, lanzar excepción
                if (ValidarProveedor(Nuevo.Nombre))
                    throw new Exception("Ya existe un Proveedor con ese nombre.");

                Conexion.SetConsultaProcedure("SpInsertar_proveedor");

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

        public void EditarProveedor(Proveedor proveedor)
        {
            Conexion = new CD_Conexion();

            try
            {
                // Validar que el nuevo nombre no exista en otra categoría
                Conexion.SetConsulta("SELECT COUNT(*) FROM Proveedores WHERE Nombre = @Nombre AND Id_Proveedor != @Id_Proveedor");
                Conexion.SetearParametro("@Nombre", Proveedor.Nombre);
                Conexion.SetearParametro("@Id_Proveedor", proveedor.Id_Proveedor);

                int count = Convert.ToInt32(Conexion.EjecutarEscalar());
                if (count > 0)
                    throw new Exception("Ya existe otro Proveedor con ese nombre.");

                Conexion.SetConsultaProcedure("SpEditar_proveedor");

                Conexion.SetearParametro("@Id_Proveedor", proveedor.Id_Proveedor);
                Conexion.SetearParametro("@Nombre", proveedor.Nombre);
         

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
        public void EliminarProveedor(int Id_proveedor)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpEliminar_proveedor");

                Conexion.SetearParametro("@Id_Proveedor", Id_proveedor);


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

        public List<Proveedor> ProveedorBuscar(string buscar)
        {
            Conexion = new CD_Conexion();
            listaProveedor = new List<Proveedor>();

            try
            {
                Conexion.SetConsultaProcedure("SpBuscar_proveedor");


                Conexion.SetearParametro("@txt_buscar", buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    Proveedor = new Proveedor();

                    Proveedor.Id_Proveedor = (int)Conexion.Lector["Id_Proveedor"];
                    Proveedor.Nombre = (string)Conexion.Lector["Nombre"];
         
                    listaProveedor.Add(Proveedor);
                }


                return listaProveedor;
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
