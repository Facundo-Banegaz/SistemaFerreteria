using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos
{
    public class CD_ValorEspecificacion
    {

        //inicializa
        private CD_Conexion Conexion;
        private ValorEspecificacion ValorEspecificacion;
        private List<ValorEspecificacion> listaValorEspecificacion;


        //Metodo Mostrar

        public List<ValorEspecificacion> ListaValorEspecificacion()
        {
            //instancia

            Conexion = new CD_Conexion();

            listaValorEspecificacion = new List<ValorEspecificacion>();

            try
            {

                Conexion.SetConsultaProcedure("Sp_Mostrar_ValoresEspecificacion");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    ValorEspecificacion = new ValorEspecificacion();


                    ValorEspecificacion.Id_ValorEspecificacion = (int)Conexion.Lector["Id_ValorEspecificacion"];
                    ValorEspecificacion.Valor = (string)Conexion.Lector["Valor"];


                    listaValorEspecificacion.Add(ValorEspecificacion);
                }

                return listaValorEspecificacion;
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
        public List<ValorEspecificacion> CargarCbo()
        {

            //instancia

            Conexion = new CD_Conexion();

            listaValorEspecificacion = new List<ValorEspecificacion>();

            try
            {

                Conexion.SetConsulta("Select Id_ValorEspecificacion, Valor from ValorEspecificacion");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    ValorEspecificacion = new ValorEspecificacion();


                    ValorEspecificacion.Id_ValorEspecificacion = (int)Conexion.Lector["Id_ValorEspecificacion"];
                    ValorEspecificacion.Valor = (string)Conexion.Lector["Valor"];
                    listaValorEspecificacion.Add(ValorEspecificacion);
                }

                return listaValorEspecificacion;
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

        public void InsertarValorEspecificacion(ValorEspecificacion Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {

                // Validación: si ya existe, lanzar excepción
                if (ValidarValorEspecificacion(Nuevo.Valor))
                    throw new Exception("Ya existe un Valor de Especificacion con ese nombre.");

                Conexion.SetConsultaProcedure("Sp_Insertar_ValorEspecificacion");

                Conexion.SetearParametro("@Valor", Nuevo.Valor);


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

        public void EditarValorEspecificacion(ValorEspecificacion ValorEspecificacion)
        {
            Conexion = new CD_Conexion();

            try
            {

                // Validar que el nuevo nombre no exista en otra ValorEspecificacion
                Conexion.SetConsulta("SELECT COUNT(*) FROM ValoresEspecificacion WHERE Valor = @Valor AND Id_ValorEspecificacion != @Id_ValorEspecificacion");
                Conexion.SetearParametro("@Valor", ValorEspecificacion.Valor);
                Conexion.SetearParametro("@Id_ValorEspecificacion", ValorEspecificacion.Id_ValorEspecificacion);

                int count = Convert.ToInt32(Conexion.EjecutarEscalar());
                if (count > 0)
                    throw new Exception("Ya existe un Valor Especificacion con ese nombre.");

                Conexion.SetConsultaProcedure("Sp_Editar_ValorEspecificacion");

                Conexion.SetearParametro("@Id_ValorEspecificacion", ValorEspecificacion.Id_ValorEspecificacion);
                Conexion.SetearParametro("@Valor", ValorEspecificacion.Valor);


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


        public bool ValidarValorEspecificacion(string valor)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsulta("SELECT COUNT(*) FROM ValoresEspecificacion WHERE Valor = @Valor");
                Conexion.SetearParametro("@Valor", valor);

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
        public void EliminarValorEspecificacion(int Id_ValorEspecificacion)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("Sp_Eliminar_ValorEspecificacion");

                Conexion.SetearParametro("@Id_ValorEspecificacion", Id_ValorEspecificacion);


                Conexion.EjecutarAccion();


            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 547) // Violación FK
                {
                    throw new Exception("No se puede eliminar este Valor Especificación porque está relacionada con otros registros.");
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

        public List<ValorEspecificacion> ValorEspecificacionBuscar(string buscar)
        {
            Conexion = new CD_Conexion();
            listaValorEspecificacion = new List<ValorEspecificacion>();

            try
            {
                Conexion.SetConsultaProcedure("Sp_Buscar_ValoresEspecificacion");


                Conexion.SetearParametro("@Texto_Buscar", buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    ValorEspecificacion = new ValorEspecificacion();

                    ValorEspecificacion.Id_ValorEspecificacion = (int)Conexion.Lector["Id_ValorEspecificacion"];
                    ValorEspecificacion.Valor = (string)Conexion.Lector["Valor"];

                    listaValorEspecificacion.Add(ValorEspecificacion);
                }


                return listaValorEspecificacion;
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
