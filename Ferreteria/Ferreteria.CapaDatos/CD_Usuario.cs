using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                    Usuario.Dni = (string)Conexion.Lector["Dni"];

                    Usuario.UsuarioNombre = (string)Conexion.Lector["UsuarioNombre"];
                 
                    
                    Usuario.Estado = (bool)Conexion.Lector["Estado"];

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
                // Validación: si ya existe, lanzar excepción
                if (ValidarUsuario(Nuevo.Dni))
                    throw new Exception("El  Usuario ya esta Registrado.");

                Conexion.SetConsultaProcedure("SpInsertar_Usuario");

                Conexion.SetearParametro("@Nombre", Nuevo.Nombre);
                Conexion.SetearParametro("@Apellido", Nuevo.Apellido);
                Conexion.SetearParametro("@Dni", Nuevo.Dni);
                Conexion.SetearParametro("@UsuarioNombre", Nuevo.UsuarioNombre);
                Conexion.SetearParametro("@Clave", Nuevo.Clave);
                Conexion.SetearParametro("@Estado", Nuevo.Estado);

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
                Conexion.SetConsulta("SELECT COUNT(*) FROM Usuarios WHERE Dni = @Dni");
                Conexion.SetearParametro("@Dni", Dni);

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
        //actualizar precio
        public void ActualizarContrasenia(int Id_Usario, string Clave)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("SpCambiar_ClaveUsuario");

                Conexion.SetearParametro("@Id_Usuario", Id_Usario);

                Conexion.SetearParametro("@Clave", Clave);


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

        public void EditarUsuario(Usuario Usuario)
        {
            Conexion = new CD_Conexion();

            try
            {

                // Validar que el nuevo Dni no exista en otro Usuario
                Conexion.SetConsulta("SELECT COUNT(*) FROM Usuarios WHERE Dni = @Dni AND Id_Usuario != @Id_Usuario");
                Conexion.SetearParametro("@Dni", Usuario.Dni);
                Conexion.SetearParametro("@Id_Usuario", Usuario.Id_Usuario);

                int count = Convert.ToInt32(Conexion.EjecutarEscalar());
                if (count > 0)
                    throw new Exception("El  Usuario ya esta Registrado.");

                Conexion.SetConsultaProcedure("SpEditar_Usuario");

                Conexion.SetearParametro("@Id_Usuario", Usuario.Id_Usuario);
                Conexion.SetearParametro("@Nombre", Usuario.Nombre);
                Conexion.SetearParametro("@Apellido", Usuario.Apellido);
                Conexion.SetearParametro("@Dni", Usuario.Dni);
                Conexion.SetearParametro("@UsuarioNombre", Usuario.UsuarioNombre);
                Conexion.SetearParametro("@Estado", Usuario.Estado);
         
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
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 547) // Violación FK
                {
                    throw new Exception("No se puede eliminar este Usuario porque está relacionada con otros registros.");
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
                    Usuario.Dni = (string)Conexion.Lector["Dni"];

                    Usuario.UsuarioNombre = (string)Conexion.Lector["UsuarioNombre"];
        
          
                    Usuario.Estado = (bool)Conexion.Lector["Estado"];
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

                Conexion.SetearParametro("@UsuarioNombre", User);
                Conexion.SetearParametro("@Clave", Clave);

                Conexion.EjecutarLectura();

                // Si hay al menos un Usuario en la lista, devolvemos el primero (asumiendo que no debería haber más de uno)
                if (Conexion.Lector.Read())
                {
                    Usuario = new Usuario();
                    Usuario.Id_Usuario = Convert.ToInt32(Conexion.Lector["Id_Usuario"]);
                    Usuario.Nombre = Conexion.Lector["Nombre"].ToString();
                    Usuario.Apellido = Conexion.Lector["Apellido"].ToString();
                    Usuario.UsuarioNombre = Conexion.Lector["UsuarioNombre"].ToString();
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
