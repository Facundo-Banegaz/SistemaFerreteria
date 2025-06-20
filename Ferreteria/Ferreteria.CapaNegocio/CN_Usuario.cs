using Ferreteria.CapaDatos;
using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario _CD_Usuario;

        //Metodo para Listar los _Usuarios em la DataWirdView
        public List<Usuario> ListaUsuario()
        {
            _CD_Usuario = new CD_Usuario();

            return _CD_Usuario.ListarUsuario();
        }
        public void ActualizarContrasenia(int Id_Usuario, string Clave)
        {
            _CD_Usuario = new CD_Usuario();

            _CD_Usuario.ActualizarContrasenia(Id_Usuario, Clave);
        }


        //Metodo para cargar un _Usuario en la Base de Datos
        public void InsertarUsuario(Usuario Nuevo)
        {
            _CD_Usuario = new CD_Usuario();

            _CD_Usuario.InsertarUsuario(Nuevo);

        }

        //Metodo para Editar un _Usuario en la Base de Datos
        public void EditarUsuario(Usuario Usuario)
        {
            _CD_Usuario = new CD_Usuario();

            _CD_Usuario.EditarUsuario(Usuario);
        }

        //Metodo para Eliminar un _Usuario en la Base de Datos
        public void EliminarUsuario(int Id_Usuario)
        {
            _CD_Usuario = new CD_Usuario();

            _CD_Usuario.EliminarUsuario(Id_Usuario);
        }
        //Metodo para Buscar un _Usuario en la Base de Datos
        public List<Usuario> UsuarioBuscar(string buscar)
        {
            _CD_Usuario = new CD_Usuario();

            return _CD_Usuario.UsuarioBuscar(buscar);
        }


        //Metodo para el login
        public Usuario Login(string Usuario, string Clave)
        {
            _CD_Usuario = new CD_Usuario();
            return _CD_Usuario.Login(Usuario, Clave);
        }
    }
}
