using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos
{
    public class CD_Usuario
    {
        private CD_Conexion Conexion;
        private Usuario Usuario;
        private List<Usuario> listaUsuario;

        public List<Usuario> ListarUsuario()
        {

            Conexion = new CD_Conexion();
            listaUsuario = new List<Usuario>();


            try
            {
                Conexion.SetConsultaProcedure("SpMostrar_Usuario");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    Usuario = new Usuario();

                    Usuario.Id_Usuario = (int)Conexion.Lector["Id_Usuario"];
                    Usuario.Nombre = (string)Conexion.Lector["Nombre"];
                    Usuario.Apellido = (string)Conexion.Lector["Apellido"];

                    Usuario.UsuarioNombre = (string)Conexion.Lector["Usuario"];
                    Usuario.Clave = (string)Conexion.Lector["Clave"];
                    //Usuario.UltimoAcceso = (DateTime)Conexion.Lector["UltimoAcceso"];
                    Usuario.Estado = (byte)Conexion.Lector["Estado"];
                    Usuario.Dni = (string)Conexion.Lector["Dni"]; 
                    Usuario.Acceso = (string)Conexion.Lector["Acceso"];




            




                    listaUsuario.Add(Usuario);


                }

                return listaUsuario;
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

        public void InsertarUsuario(Usuario Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpInsertar_Usuario");

                Conexion.SetearParametro("@Nombre", Nuevo.Nombre);
                Conexion.SetearParametro("@Apellido", Nuevo.Apellido);
                //Conexion.SetearParametro("@UrlImagen", Nuevo.UrlImagen);
                Conexion.SetearParametro("@Usuario", Nuevo.UsuarioNombre);
                Conexion.SetearParametro("@Clave", Nuevo.Clave);
                //Conexion.SetearParametro("@UltimoAcceso", Nuevo.UltimoAcceso);
                Conexion.SetearParametro("@Estado", Nuevo.Estado);
                Conexion.SetearParametro("@Dni", Nuevo.Dni);
                Conexion.SetearParametro("@Acceso", Nuevo.Acceso);




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

        public bool ValidarUsuario(string Dni)
        {
            Conexion = new CD_Conexion();
            try
            {
                Conexion.SetConsulta("SELECT COUNT(*) FROM Usuarios WHERE Dni =  @Dni");
                Conexion.SetearParametro("@Dni", Dni);

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

        //metodo editar

        public void EditarUsuario(Usuario Usuario)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpEditar_Usuario");

                Conexion.SetearParametro("@Id_Usuario", Usuario.Id_Usuario);
                Conexion.SetearParametro("@Nombre", Usuario.Nombre);
                Conexion.SetearParametro("@Apellido", Usuario.Apellido);
            
                Conexion.SetearParametro("@Usuario", Usuario.UsuarioNombre);
                Conexion.SetearParametro("@Clave", Usuario.Clave);
                //Conexion.SetearParametro("@UltimoAcceso", Usuario.UltimoAcceso);
                Conexion.SetearParametro("@Estado", Usuario.Estado);
                Conexion.SetearParametro("@Dni", Usuario.Dni);
                Conexion.SetearParametro("@Acceso", Usuario.Acceso);

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
        public void EliminarUsuario(int Id_Usuario)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpEliminar_Usuario");

                Conexion.SetearParametro("@Id_Usuario", Id_Usuario);


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



        public List<Usuario> UsuarioBuscar(string buscar)
        {
            Conexion = new CD_Conexion();
            listaUsuario = new List<Usuario>();

            try
            {
                Conexion.SetConsultaProcedure("SpBuscar_Usuario");


                Conexion.SetearParametro("@txt_buscar", buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    Usuario = new Usuario();


                    Usuario.Id_Usuario = (int)Conexion.Lector["Id_Usuario"];
                    Usuario.Nombre = (string)Conexion.Lector["Nombre"];
                    Usuario.Apellido = (string)Conexion.Lector["Apellido"];
                    Usuario.UsuarioNombre = (string)Conexion.Lector["Usuario"];
                    Usuario.Clave = (string)Conexion.Lector["Clave"];
                    //Usuario.UltimoAcceso = (DateTime)Conexion.Lector["UltimoAcceso"];
                    Usuario.Estado = (byte)Conexion.Lector["Estado"];
                    Usuario.Dni = (string)Conexion.Lector["Dni"];
                    Usuario.Acceso = (string)Conexion.Lector["Acceso"];






                    listaUsuario.Add(Usuario);
                }


                return listaUsuario;
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


        public Usuario Login(string User, string Clave)
        {
            Conexion = new CD_Conexion();


            try
            {
                Conexion.SetConsultaProcedure("Sp_login");

                Conexion.SetearParametro("@Usuario", User);
                Conexion.SetearParametro("@Clave", Clave);

                Conexion.EjecutarLectura();

                // Si hay al menos un Usuario en la lista, devolvemos el primero (asumiendo que no debería haber más de uno)
                if (Conexion.Lector.Read())
                {
                    Usuario = new Usuario();
                    Usuario.Id_Usuario = Convert.ToInt32(Conexion.Lector["Id_Usuario"]);
                    Usuario.Nombre = Conexion.Lector["Nombre"].ToString();
                    Usuario.Apellido = Conexion.Lector["Apellido"].ToString();
                    Usuario.UsuarioNombre = Conexion.Lector["Usuario"].ToString();
                    Usuario.Clave = Conexion.Lector["Clave"].ToString();
                    Usuario.Acceso = Conexion.Lector["Acceso"].ToString();


                }

                return Usuario;
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
